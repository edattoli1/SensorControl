using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Runtime;
using Ke648x;

namespace MFCcontrol
{
    public partial class Form1 : Form
    {
        private DataForDaqOutput dataForDaq;
        private GenStopwatch watch;
        private GenTimer timerUI;
        private GenTimer timerADgraph;
        //private HiResTimer timerADacquire;
        private GenTimer timerADacquire;
        private GenTimer timerADoutUpdate;
        private StreamWriter swriter;
        private List<string[]> ADoutTableValues_s;
        private List<double[]> ADoutTableValues_d;
        private List<double[]> ADoutTableVolts;
        private static double[] currentADin;
        private DaqAction daqInput;
        public DaqAction daqOutput;
        private int curRow_ADoutTable;
        private bool recipeRunning;
        private bool AinGraphUpdateState;
        private int ADgraphUpdateCnt;
        private double[] presentMFCsetting;
        private static Ke648xGUI PicoammForm;
        static private Ke648xControl PicoammControl;

        // state of the MFCs for the recipe to be used
        // 0th in array corresponds to MFC 1, .., etc
        private bool[] stateMFCs;

        // maximum flow rate of the MFCs for the recipe to be used
        // 0th in array corresponds to MFC 1, .., etc
        private int[] maxFlowMFCs;

        //Helper Classes
        private RecipeView RecipeView1;
        private ConfigureMFCs MFCconfigure1;

        //used for closing file properly when stop or exit button is hit
        private bool IsADoutfileOpen = false;
        
        
        public Form1(DataForDaqOutput inputDataDaq, GenStopwatch inputWatch)
        {
            InitializeComponent();

            //Used for Drawing Rows in MFC table
            tableLayoutPanel1.CellPaint += tableLayoutPanel_CellPaint;
            tableLayoutPanel2.CellPaint += tableLayoutPanel_CellPaint;

            // Initialized Saved Settings Values Into Form

            samplesToResetUpDown.Value = Settings1.Default.SamplesToGraphReset;
            AinGraphUpdateState = true;

            stateMFCs = new bool[Settings1.Default.MFCcontrol_numMFCs];
            maxFlowMFCs = new int[Settings1.Default.MFCcontrol_numMFCs];

            currentADin = new double[Settings1.Default.MFCcontrol_numMFCs];
            presentMFCsetting = new double[Settings1.Default.MFCcontrol_numMFCs];

            // Initialize Members of Form1 Class

            daqInput = new DaqAction();
            daqOutput = new DaqAction();

            dataForDaq = inputDataDaq;
            watch = inputWatch;
            
            timerUI = new GenTimer();
            timerUI.SetInterval(Settings1.Default.timerUI_ms);

            //timerADacquire = new HiResTimer();
            timerADacquire = new GenTimer();
            timerADacquire.SetInterval(Settings1.Default.ADacquireTime_ms);

            timerADgraph = new GenTimer();
            timerADgraph.SetInterval(Settings1.Default.GraphTimeUpdateMS);

            //Set NumericUpDown Control box for Graph Update Time to Saved Value
            graphUpdateUDbox.Value = Convert.ToDecimal(Settings1.Default.GraphTimeUpdateMS) / 1000;

            timerADoutUpdate = new GenTimer();
            timerADoutUpdate.AutoResetEnable();
            timerADoutUpdate.SetInterval(Settings1.Default.ADoutRefreshTime_ms);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Make sure counters are at 0 (for DAQ output and Graph Reset count)
            curRow_ADoutTable = 0;
            ADgraphUpdateCnt = 0;
            
            timeElapsedBox.Text = (watch.GetMsElapsed()/3600.0).ToString();

            // Let MFC Control Panels know that about parent form so they can interact with it
            mfcControl1.parentForm = this;
            mfcControl2.parentForm = this;
            mfcControl3.parentForm = this;
            mfcControl4.parentForm = this;

            chart1.ChartAreas[0].Axes[0].Title = "Time (min)";
            chart1.ChartAreas[0].Axes[1].Title = "MFC Flow (sccm)";
            chart1.Series[0].Name = Settings1.Default.MFC1Gas;
            chart1.Series[1].Name = Settings1.Default.MFC2Gas;
            chart1.Series[2].Name = Settings1.Default.MFC3Gas;
            chart1.Series[3].Name = Settings1.Default.MFC4Gas;

            chart1.Series[0].Enabled = Settings1.Default.MFC1PlotEnable;
            chart1.Series[1].Enabled = Settings1.Default.MFC2PlotEnable;
            chart1.Series[2].Enabled = Settings1.Default.MFC3PlotEnable;
            chart1.Series[3].Enabled = Settings1.Default.MFC4PlotEnable;

            //Set MFC USer Controls to correct MFC
            mfcControl1.SetMFCnumber(1);
            mfcControl2.SetMFCnumber(2);
            mfcControl3.SetMFCnumber(3);
            mfcControl4.SetMFCnumber(4);

            //Set whether recipe controls the following MFCs, stateMFC is logic control at runtime, Settings is permanent store
            stateMFCs[0] = Settings1.Default.MFC1enable;
            stateMFCs[1] = Settings1.Default.MFC2enable;
            stateMFCs[2] = Settings1.Default.MFC3enable;
            stateMFCs[3] = Settings1.Default.MFC4enable;

            // Picoammeter init stuff
            PicoammControl = new Ke648xControl();
            controlPicoammBox.Checked = Settings1.Default.PicoammeterControlEnable;

            viewFlowRecipe.Enabled = false;
            startButton.Enabled = false;
            recipePauseCheckbox.Enabled = false;
            exitRecipeButton.Enabled = false;

            openFileDialog1.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

            //start StopWatch
            watch.StartStopwatch();

            //start UI Timer
            timerUI.TimerElapsed += UpdateUIhandler;
            timerUI.StartTimer();

            //start AD timer (when to acquire from A/D)
            UpdateADacquireBusy = false;
            timerADacquire.StartTimer();
            timerADacquire.TimerElapsed += UpdateADacquireHandlerAsync;

            //start AD graph timer (when to graph data from A/D)
            timerADgraph.StartTimer();
            timerADgraph.TimerElapsed += UpdateADgraphHandler;

            //Zero all AD outputs
            ZeroAllOutputs();

        }


        private void UpdateUIhandler(object obj, EventArgs e)
        {
            UpdateUI((Convert.ToDouble(watch.GetMsElapsed()) * .001 / 60.0).ToString("0.00"));
        }

        void UpdateUI(string text)
        {
            //the GenTimer class operates the timer on a different thread than the UI
            //UI updates must though be executed on the UI thread, this code ensures that happens
            if (InvokeRequired)
            {
                BeginInvoke((Action<string>)UpdateUI, text);
                return;
            }

            timeElapsedBox.Text = text;
            mfcControl1.UpdatePresFlowBox(DaqAction.GetMFCflowFromVolts(currentADin[0], 1));
            mfcControl2.UpdatePresFlowBox(DaqAction.GetMFCflowFromVolts(currentADin[1], 2));
            mfcControl3.UpdatePresFlowBox(DaqAction.GetMFCflowFromVolts(currentADin[2], 3));
            mfcControl4.UpdatePresFlowBox(DaqAction.GetMFCflowFromVolts(currentADin[3], 4));

            if (recipeRunning == true)
            {
                
                //Update Next Time for Recipe Event on GUI in Recipe Section

                if (curRow_ADoutTable < ADoutTableVolts.Count)
                {
                    nextRecipeTimeEventBox.Text = ADoutTableVolts[curRow_ADoutTable][0].ToString("0.00");
                    lastRecipeTimeEventBox.Text = ADoutTableVolts[curRow_ADoutTable - 1][0].ToString("0.00");
                }
                else // Recipe is Over
                {
                    lastRecipeTimeEventBox.Text = ADoutTableVolts[curRow_ADoutTable - 1][0].ToString("0.00");
                    nextRecipeTimeEventBox.Text = "Recipe Over";
                }

                //Update Present Set Flow in GUI on MFC Control Section

                mfcControl1.UpdateSetFlowValue(presentMFCsetting[0]);
                mfcControl2.UpdateSetFlowValue(presentMFCsetting[1]);
                mfcControl3.UpdateSetFlowValue(presentMFCsetting[2]);
                mfcControl4.UpdateSetFlowValue(presentMFCsetting[3]);

            }
        }


        private void startButton_Click(object sender, EventArgs e)
        {
            //Create AD results text file, put headers in
            //Make sure writes are done asynchronously using FileStream to open file async
            
            FileStream sourceStream = new FileStream("adInput.txt",
                   FileMode.Create, FileAccess.Write, FileShare.Read,
                   bufferSize: 4096, useAsync: true);

            swriter = new StreamWriter(sourceStream);
            swriter.AutoFlush = true;

            string headerString = "Time (s)";


            int numActiveMFCs = 0;
            for (int i = 0; i < stateMFCs.Length; i++)
            {
                if (stateMFCs[i] == true)
                {
                    numActiveMFCs++;
                    headerString += "\tMFC " + (i+1).ToString() + " Flow (sccm)";
                }
            }
                
            swriter.Write(headerString + Environment.NewLine);

            IsADoutfileOpen = true;
            

            //Go Into Low Latency Mode for Garbage Collector
            GCSettings.LatencyMode = GCLatencyMode.SustainedLowLatency;

            //Output initial DAQ Output values
            for (int i = 1; i <= Settings1.Default.MFCcontrol_numMFCs; i++)
            {
                if (stateMFCs[i - 1] == true)
                {
                    try
                    {
                        daqOutput.UpdateDaqOut(i - 1, ADoutTableVolts[0][i]);
                    }
                    catch
                    {
                        DaqOutputProblem();
                    }

                }
            }

            curRow_ADoutTable = 1;

            //start Program Stopwatch
            watch.StopStopwatch();
            watch.ResetStopwatch();
            watch.StartStopwatch();

            //start AD output update timer (when to update output for A/D), units of ms
            timerADoutUpdate.SetInterval(ADoutTableVolts[1][0]*60*1000);
            nextRecipeTimeEventBox.Text = ADoutTableVolts[1][0].ToString();
            timerADoutUpdate.StartTimer();
            timerADoutUpdate.TimerElapsed += UpdateADoutputHandler;

            //Clear Output Graph
            resetGraphButton_Click(this, EventArgs.Empty);

            //Disable users from Changing MFC states
            configMFCsButton.Enabled = false;
            recipePauseCheckbox.Enabled = true;


            mfcControl1.DisableUserControl();
            mfcControl2.DisableUserControl();
            mfcControl3.DisableUserControl();
            mfcControl4.DisableUserControl();

            startButton.Enabled = false;
            exitRecipeButton.Enabled = true;

            recipeRunning = true;

            lastRecipeTimeEventBox.Text = "0";
            
        }


        delegate void UpdateADgraphDelegate ();

        private bool UpdateADgraphBusy = false;
        private bool UpdateADacquireBusy = false;
        private bool saveADdataBusy = false;
        private bool updateADoutputBusy = false;

        private void UpdateADoutputHandler(object obj, EventArgs e)
        {
            if (updateADoutputBusy == true)
                return;
            else if (curRow_ADoutTable >= ADoutTableVolts.Count)
            {
                updateADoutputBusy = false;
                return;
            }
            else
            {
                updateADoutputBusy = true;
                for (int i = 1; i <= Settings1.Default.MFCcontrol_numMFCs; i++)
                {
                    // check record of AD out values has a current output for the AD at this particular time (i.e., row)
                    // and check whether current MFC is enabled in the recipe
                    if ( (ADoutTableVolts[curRow_ADoutTable][i] >= 0) && (stateMFCs[i-1] == true) )
                        UpdateADoutput(ADoutTableVolts, i);
                }
                curRow_ADoutTable++;
                timerADoutUpdate.StopTimer();

                //Check if at end of AO output recipe, if so, keep AO update timer off and just exit
                //if ((ADoutTableValues_d[curRow_ADoutTable][0]) < 0)
                if (curRow_ADoutTable >= ADoutTableVolts.Count)
                {
                    updateADoutputBusy = false;
                    return;
                }

                timerADoutUpdate.SetInterval(((ADoutTableVolts[curRow_ADoutTable][0]) - ADoutTableVolts[curRow_ADoutTable - 1][0]) * 60.0 * 1000.0);

                timerADoutUpdate.StartTimer();

                updateADoutputBusy = false;
            }
        }

        private void UpdateADoutput(List<double[]> ADoutTable, int mfcNumber)
        {
            try
            {
                if (mfcNumber == 1)
                {
                    daqOutput.UpdateDaqOut(0, ADoutTable[curRow_ADoutTable][1]);
                    presentMFCsetting[0] = (ADoutTableValues_d[curRow_ADoutTable][1]);
                }

                else if (mfcNumber == 2)
                {
                    daqOutput.UpdateDaqOut(1, ADoutTable[curRow_ADoutTable][2]);
                    presentMFCsetting[1] = (ADoutTableValues_d[curRow_ADoutTable][2]);
                }

                else if (mfcNumber == 3)
                {
                    daqOutput.UpdateDaqOut(2, ADoutTable[curRow_ADoutTable][3]);
                    presentMFCsetting[2] = (ADoutTableValues_d[curRow_ADoutTable][3]);
                }

                else if (mfcNumber == 4)
                {
                    daqOutput.UpdateDaqOut(3, ADoutTable[curRow_ADoutTable][4]);
                    presentMFCsetting[3] = (ADoutTableValues_d[curRow_ADoutTable][4]);
                }
            }
            catch
            {
                DaqOutputProblem();
            }

        }


        private void UpdateADgraphHandler (object obj, EventArgs e)
        {
            if (UpdateADgraphBusy == true)
                return;
            else
            {
                 UpdateADgraph();
            }
        }

        private async void UpdateADacquireHandlerAsync (object obj, EventArgs e)
        {
            if (UpdateADacquireBusy == true)
                return;
            else
            {
               await UpdateADacquireAsync();
            }
        }

        private async void SaveADdataHandlerAsync (object obj, EventArgs e)
        {
            if (saveADdataBusy == true)
                return;
            else
            {
                await SaveADdataAsync();
            }
        }


        private async Task UpdateADacquireAsync()
        {
            //Record new A/D data input
            
            UpdateADacquireBusy = true;

            try
            {
                daqInput.Read(ref currentADin);
            }
            catch
            {
                string messageBoxText = "Do you want to exit?";
                string caption = "DAQ Input Problem";
                var result = MessageBox.Show (messageBoxText, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    Environment.Exit(0); 
            }


            // Don't worry about saving AD data in or plotting it if recipe not runnin
            if (recipeRunning != true)
            {
                UpdateADacquireBusy = false;
                return;
            }


            await SaveADdataAsync();
            UpdateADacquireBusy = false;
        }

        private async Task SaveADdataAsync()
        {
            saveADdataBusy = true;
            //Open AD results text file, append data to it

            //ADinputSaveFormat_s += "\t{" + (numActiveMFCs).ToString() + ":F6}";

            //write time to File
            await swriter.WriteAsync(string.Format("{0:F3}",  watch.GetMsElapsed() * .001));

            //Output active MFCs input information
            //int numActiveMFCs = 0;
            for (int i = 0; i < stateMFCs.Length; i++)
            {
                if (stateMFCs[i] == true)
                {
                    //numActiveMFCs++;
                    await swriter.WriteAsync(string.Format("\t{0:F6}", DaqAction.GetMFCflowFromVolts(currentADin[i], i + 1)));
                }
            }

            await swriter.WriteAsync(Environment.NewLine);

            saveADdataBusy = false;
        }

        private void UpdateADgraph()
        {
            //the GenTimer class operates the timer on a different thread than the UI
            //UI updates must though be executed on the UI thread, this code ensures that happens

            UpdateADgraphBusy = true;

            if (InvokeRequired)
            {
                BeginInvoke( new UpdateADgraphDelegate(UpdateADgraph));
                return;
            }


            double time = Math.Round(Convert.ToDouble(watch.GetMsElapsed()) / 1000.0 / 60.0,2);

            chart1.Series[0].Points.AddXY(time, DaqAction.GetMFCflowFromVolts(currentADin[0], 1));
            chart1.Series[1].Points.AddXY(time, DaqAction.GetMFCflowFromVolts(currentADin[1], 2));
            chart1.Series[2].Points.AddXY(time, DaqAction.GetMFCflowFromVolts(currentADin[2], 3));
            chart1.Series[3].Points.AddXY(time, DaqAction.GetMFCflowFromVolts(currentADin[3], 4));

            ADgraphUpdateCnt++;
            if (ADgraphUpdateCnt >= Settings1.Default.SamplesToGraphReset)
            {
                resetGraphButton_Click(this, EventArgs.Empty);
                ADgraphUpdateCnt = 0;
            }

           UpdateADgraphBusy = false;
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           //timerSaveADdata.StopTimer();
            
            GCSettings.LatencyMode = GCLatencyMode.Interactive;
            timerADgraph.StopTimer();
            timerADacquire.StopTimer();
            timerUI.StopTimer();
            watch.StopStopwatch();

            //Zero all AD outputs
            ZeroAllOutputs();

            //Save all Settings
            Settings1.Default.Save();

            //wait for disk writes, our timer handlers to finish before closing file
            while ((saveADdataBusy == true) || (UpdateADacquireBusy == true) || (updateADoutputBusy == true))
                Thread.Sleep(200);

            if (IsADoutfileOpen == true)
            {
                swriter.Close();
                IsADoutfileOpen = false;
            }
 
        }

        private void loadFlowsButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK) // Test result.
            {
                if (FileInUse(openFileDialog1.FileName) == true)
                    return;
                
                //ADoutTableValues = new List<string[]>();

                SShtLoad sshtLoad1 = new SShtLoad();

                stateMFCs = sshtLoad1.LoadMFCstate(openFileDialog1.FileName);
                Settings1.Default.MFC1enable = stateMFCs[0];
                Settings1.Default.MFC2enable = stateMFCs[1];
                Settings1.Default.MFC3enable = stateMFCs[2];
                Settings1.Default.MFC4enable = stateMFCs[3];

                maxFlowMFCs = sshtLoad1.LoadMFCmaxFlows(openFileDialog1.FileName);

                //Update Size of MFCs in Program Wide Value Storage
                Settings1.Default.MFC1maxRange = maxFlowMFCs[0].ToString();
                Settings1.Default.MFC2maxRange = maxFlowMFCs[1].ToString();
                Settings1.Default.MFC3maxRange = maxFlowMFCs[2].ToString();
                Settings1.Default.MFC4maxRange = maxFlowMFCs[3].ToString();
                Settings1.Default.Save();

                mfcControl1.SetMFCnumber(1);
                mfcControl2.SetMFCnumber(2);
                mfcControl3.SetMFCnumber(3);
                mfcControl4.SetMFCnumber(4);

                // Load all rows of recipe Spreadsheet into ADoutTableValues_s
                // Empty cells are marked translated into -1 (means do nothing)
                // ADoutTableValues_d is in format of Flow (sccm)

                ADoutTableValues_s = sshtLoad1.Load(openFileDialog1.FileName);

                ADoutTableValues_d = new List<double[]> ();
                double[] currentRow_d;
                foreach (string[] rowArray in ADoutTableValues_s)
                {
                    currentRow_d = new double[Settings1.Default.MFCcontrol_numMFCs+1];
                    for (int i = 0; i < Settings1.Default.MFCcontrol_numMFCs+1; i++)
                    {
                        if (rowArray[i] == "")
                            currentRow_d[i] = -1.0;
                        else
                            currentRow_d[i] = Convert.ToDouble(rowArray[i]);
                    }
                    ADoutTableValues_d.Add(currentRow_d);
                }

                // Convert ADoutTableValues_d (flow sccm) into ADoutTableVolts (volts)
                // column 1 is times, rest of columns are MFC voltage control values (1,2...)

                ADoutTableVolts = new List<double[]>();

                foreach (string[] rowArray in ADoutTableValues_s)
                {
                    currentRow_d = new double[Settings1.Default.MFCcontrol_numMFCs + 1];
                    
                    //Load times (column 1 into volts list of arrays
                    currentRow_d[0] = Convert.ToDouble(rowArray[0]);

                    for (int i = 1; i <= stateMFCs.Length; i++)
                    {
                        if (rowArray[i] == "")
                            currentRow_d[i] = -1.0;
                        else
                            currentRow_d[i] = DaqAction.GetVoltsFromMFCflow(rowArray[i], i);
                    }
                    ADoutTableVolts.Add(currentRow_d);
                }

                startButton.Enabled = true;
                viewFlowRecipe.Enabled = true;
            }
        }

        private void viewFlowRecipe_Click(object sender, EventArgs e)
        {
            RecipeView1 = new RecipeView(this, ADoutTableValues_s, stateMFCs);
            
            RecipeView1.Show();
        }

        public void DisableViewFlowBtn()
        {
            this.viewFlowRecipe.Enabled = false;
        }

        public void EnableViewFlowBtn()
        {
            this.viewFlowRecipe.Enabled = true;
        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings1.Default.Save();
        }

        private void configMFCbuttonClick(object sender, EventArgs e)
        {
            MFCconfigure1 = new ConfigureMFCs();

            MFCconfigure1.ShowDialog();

            mfcControl1.UpdateConfig();
            mfcControl2.UpdateConfig();
            mfcControl3.UpdateConfig();
            mfcControl4.UpdateConfig();
            //mfc4TextBox.Maximum = Convert.ToDecimal(Settings1.Default.MFC4maxRange);
            chart1.Series[0].Name = Settings1.Default.MFC1Gas;
            chart1.Series[1].Name = Settings1.Default.MFC2Gas;
            chart1.Series[2].Name = Settings1.Default.MFC3Gas;
            chart1.Series[3].Name = Settings1.Default.MFC4Gas;
        }

        public void MfcPlotCheck_CheckedChanged(int MFCnumber, bool checkState)
        {
            if (checkState == true)
                chart1.Series[MFCnumber-1].Enabled = true;
            else
                chart1.Series[MFCnumber - 1].Enabled = false;

        }
        

        public void mfcTextBox_ValueChanged(int mfcNumber, decimal valueNew)
        {
            double inputValue = DaqAction.GetVoltsFromMFCflow(valueNew.ToString(), mfcNumber);

            switch (mfcNumber)
            {
                case 1 :
                    if (Settings1.Default.MFC1enable == true)
                        daqOutput.UpdateDaqOut(mfcNumber - 1, inputValue);
                    break;
                case 2:
                    if (Settings1.Default.MFC2enable == true)
                        daqOutput.UpdateDaqOut(mfcNumber - 1, inputValue);
                    break;
                case 3:
                    if (Settings1.Default.MFC3enable == true)
                        daqOutput.UpdateDaqOut(mfcNumber - 1, inputValue);
                    break;
                case 4:
                    if (Settings1.Default.MFC4enable == true)
                        daqOutput.UpdateDaqOut(mfcNumber - 1, inputValue);
                    break;
            }


        }
        

        private void resetGraphButton_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            chart1.Series[3].Points.Clear();
        }

        private void graphUpdateUD_ValueChanged(object sender, EventArgs e)
        {
            //On Startup this value is 0, in this case don't overwritten saved GraphTimeUpdate value
            if (graphUpdateUDbox.Value != 0)
            {
                Settings1.Default.GraphTimeUpdateMS = Convert.ToInt32(graphUpdateUDbox.Value * 1000);
                Settings1.Default.ADacquireTime_ms = Convert.ToInt32(graphUpdateUDbox.Value * 1000);
            }

            timerADacquire.SetInterval(Settings1.Default.ADacquireTime_ms);
            timerADgraph.SetInterval(Settings1.Default.GraphTimeUpdateMS);
            Settings1.Default.Save();
        }

        private void AinGraphUpdateBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AinGraphUpdateBox.Checked == true)
            {
                AinGraphUpdateState = true;
                timerADgraph.StartTimer();
            }
            else
            {
                AinGraphUpdateState = false;
                timerADgraph.StopTimer();
            }
        }

        private void samplesToResetUpDown_ValueChanged(object sender, EventArgs e)
        {
            Settings1.Default.SamplesToGraphReset = Convert.ToInt32(samplesToResetUpDown.Value) ;
            Settings1.Default.Save();
        }

        private void exitRecipe_Click(object sender, EventArgs e)
        {
            watch.StopStopwatch();
            watch.ResetStopwatch();

            timerADoutUpdate.StopTimer();

            recipeRunning = false;
            GCSettings.LatencyMode = GCLatencyMode.Interactive;
            //disable writing to disk for last AD acquire events due to last callbacks from HiResTimer class
            //UpdateADacquireBusy = true;


            //wait for disk writes, our timer handlers to finish before closing file
            while ((saveADdataBusy == true) || (UpdateADacquireBusy == true) || (updateADoutputBusy == true))
                Thread.Sleep(200);

            if (IsADoutfileOpen == true)
            {
                swriter.Close();
                IsADoutfileOpen = false;
            }

            startButton.Enabled = true;
            configMFCsButton.Enabled = true;


            mfcControl1.EnableUserControl();
            mfcControl2.EnableUserControl();
            mfcControl3.EnableUserControl();
            mfcControl4.EnableUserControl();

            //Zero all AD outputs
            ZeroAllOutputs();

            recipeRunning = false;
            recipePauseCheckbox.Enabled = false;
            resetGraphButton_Click(this, EventArgs.Empty);
            this.Form1_Load(this, EventArgs.Empty);
            startButton.Enabled = true;
            viewFlowRecipe.Enabled = true;
        }

        private void recipePauseCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (recipePauseCheckbox.Checked == true)
            {
                timerADoutUpdate.StopTimer();
                recipeRunning = false;
            }
            else
            {
                recipeRunning = true;
                timerADoutUpdate.StartTimer();
            }
        }



        private void ke648xStart_Click(object sender, EventArgs e)
        {
            //PicoAmmForm = new Ke648xGUI();
            if (PicoammForm == null)
                PicoammForm = new Ke648xGUI();

            PicoammForm.Show();
        }


        //Helper Functions

        private void DaqOutputProblem()
        {
            string messageBoxText = "Do you want to exit?";
            string caption = "DAQ Output Problem";
            var result = MessageBox.Show(messageBoxText, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Environment.Exit(0);
        }

        static bool FileInUse(string path)
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    var test = fs.CanWrite;
                }
                return false;
            }
            catch (IOException ex)
            {
                System.Windows.Forms.MessageBox.Show("File Access Exception " + ex.Message);
                return true;
            }
        }

        //Used for Drawing Rows in MFC Table
        private void tableLayoutPanel_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.Black, e.CellBounds.Location, new Point(e.CellBounds.Right, e.CellBounds.Top));
        }

        private void ZeroAllOutputs()
        {
            try
            {
                daqOutput.ZeroDaqOuts();
                mfcControl1.ZeroControl();
                mfcControl2.ZeroControl();
                mfcControl3.ZeroControl();
                mfcControl4.ZeroControl();
            }
            catch
            {
                DaqOutputProblem();
            }
        }

        private void controlPicoammBox_CheckedChanged(object sender, EventArgs e)
        {
            if (controlPicoammBox.Checked == true)
            {
                PicoammControl.InitSession();
                PicoammControl.InitDevice();
                Settings1.Default.PicoammeterControlEnable = controlPicoammBox.Checked;
            }
            else
            {
                PicoammControl.EndSession();
                Settings1.Default.PicoammeterControlEnable = controlPicoammBox.Checked;
            }
        }

    }

    

}
