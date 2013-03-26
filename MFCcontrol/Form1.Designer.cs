namespace MFCcontrol
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timeElapsedBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.loadFlowsButton = new System.Windows.Forms.Button();
            this.viewFlowRecipe = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.mfcControl4 = new MFCcontrol.MFCcontrolTemplate();
            this.mfcControl1 = new MFCcontrol.MFCcontrolTemplate();
            this.mfcControl2 = new MFCcontrol.MFCcontrolTemplate();
            this.mfcControl3 = new MFCcontrol.MFCcontrolTemplate();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.configMFCsButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nextRecipeTimeEventBox = new System.Windows.Forms.TextBox();
            this.lastRecipeTimeEventBox = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.recipePauseCheckbox = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.exitRecipeButton = new System.Windows.Forms.Button();
            this.resetGraphButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.samplesToResetUpDown = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.AinGraphUpdateBox = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.graphUpdateUDbox = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.picoammSettingsButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.controlPicoammBox = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.mfcMainControlEnable = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.samplesToResetUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphUpdateUDbox)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(19, 7);
            this.chart1.Name = "chart1";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.CustomProperties = "IsXAxisQuantitative=False";
            series5.Legend = "Legend1";
            series5.Name = "MFC1";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series5.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.CustomProperties = "IsXAxisQuantitative=False";
            series6.Legend = "Legend1";
            series6.Name = "MFC2";
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series6.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "MFC3";
            series8.BorderWidth = 3;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "MFC4";
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(651, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // timeElapsedBox
            // 
            this.timeElapsedBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.timeElapsedBox.Enabled = false;
            this.timeElapsedBox.Location = new System.Drawing.Point(820, 271);
            this.timeElapsedBox.Name = "timeElapsedBox";
            this.timeElapsedBox.ReadOnly = true;
            this.timeElapsedBox.Size = new System.Drawing.Size(66, 22);
            this.timeElapsedBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(682, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time Elapsed (min):";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(8, 128);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // loadFlowsButton
            // 
            this.loadFlowsButton.Location = new System.Drawing.Point(137, 128);
            this.loadFlowsButton.Name = "loadFlowsButton";
            this.loadFlowsButton.Size = new System.Drawing.Size(143, 23);
            this.loadFlowsButton.TabIndex = 6;
            this.loadFlowsButton.Text = "Load Flow Recipe";
            this.loadFlowsButton.UseVisualStyleBackColor = true;
            this.loadFlowsButton.Click += new System.EventHandler(this.loadFlowsButton_Click);
            // 
            // viewFlowRecipe
            // 
            this.viewFlowRecipe.Location = new System.Drawing.Point(137, 165);
            this.viewFlowRecipe.Name = "viewFlowRecipe";
            this.viewFlowRecipe.Size = new System.Drawing.Size(143, 23);
            this.viewFlowRecipe.TabIndex = 7;
            this.viewFlowRecipe.Text = "View Flow Recipe";
            this.viewFlowRecipe.UseVisualStyleBackColor = true;
            this.viewFlowRecipe.Click += new System.EventHandler(this.viewFlowRecipe_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Excel2007+|*.xlsx";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "MFC MAIN CONTROL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Enable?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(299, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Set Flow";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.mfcMainControlEnable);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.configMFCsButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(43, 336);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 303);
            this.panel1.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.mfcControl4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.mfcControl1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.mfcControl2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.mfcControl3, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 75);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(498, 174);
            this.tableLayoutPanel2.TabIndex = 36;
            // 
            // mfcControl4
            // 
            this.mfcControl4.Location = new System.Drawing.Point(3, 132);
            this.mfcControl4.Name = "mfcControl4";
            this.mfcControl4.Size = new System.Drawing.Size(487, 39);
            this.mfcControl4.TabIndex = 35;
            // 
            // mfcControl1
            // 
            this.mfcControl1.Location = new System.Drawing.Point(3, 3);
            this.mfcControl1.Name = "mfcControl1";
            this.mfcControl1.Size = new System.Drawing.Size(492, 37);
            this.mfcControl1.TabIndex = 36;
            // 
            // mfcControl2
            // 
            this.mfcControl2.Location = new System.Drawing.Point(3, 46);
            this.mfcControl2.Name = "mfcControl2";
            this.mfcControl2.Size = new System.Drawing.Size(492, 31);
            this.mfcControl2.TabIndex = 37;
            // 
            // mfcControl3
            // 
            this.mfcControl3.Location = new System.Drawing.Point(3, 89);
            this.mfcControl3.Name = "mfcControl3";
            this.mfcControl3.Size = new System.Drawing.Size(492, 33);
            this.mfcControl3.TabIndex = 38;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(498, 30);
            this.tableLayoutPanel1.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(8, 8);
            this.label16.Margin = new System.Windows.Forms.Padding(8);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "MFC";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(456, 8);
            this.label9.Margin = new System.Windows.Forms.Padding(8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Plot?";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(376, 8);
            this.label10.Margin = new System.Windows.Forms.Padding(8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Pres. Flow";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(230, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Max Flow";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 8);
            this.label6.Margin = new System.Windows.Forms.Padding(8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Gas";
            // 
            // configMFCsButton
            // 
            this.configMFCsButton.Location = new System.Drawing.Point(236, 255);
            this.configMFCsButton.Name = "configMFCsButton";
            this.configMFCsButton.Size = new System.Drawing.Size(87, 43);
            this.configMFCsButton.TabIndex = 25;
            this.configMFCsButton.Text = "Configure MFCs";
            this.configMFCsButton.UseVisualStyleBackColor = true;
            this.configMFCsButton.Click += new System.EventHandler(this.configMFCbuttonClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(205, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "MFC RECIPE CONTROL";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.nextRecipeTimeEventBox);
            this.panel2.Controls.Add(this.lastRecipeTimeEventBox);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.recipePauseCheckbox);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.exitRecipeButton);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.startButton);
            this.panel2.Controls.Add(this.viewFlowRecipe);
            this.panel2.Controls.Add(this.loadFlowsButton);
            this.panel2.Location = new System.Drawing.Point(577, 336);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 265);
            this.panel2.TabIndex = 17;
            // 
            // nextRecipeTimeEventBox
            // 
            this.nextRecipeTimeEventBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.nextRecipeTimeEventBox.Enabled = false;
            this.nextRecipeTimeEventBox.Location = new System.Drawing.Point(164, 81);
            this.nextRecipeTimeEventBox.Name = "nextRecipeTimeEventBox";
            this.nextRecipeTimeEventBox.ReadOnly = true;
            this.nextRecipeTimeEventBox.Size = new System.Drawing.Size(88, 22);
            this.nextRecipeTimeEventBox.TabIndex = 23;
            // 
            // lastRecipeTimeEventBox
            // 
            this.lastRecipeTimeEventBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lastRecipeTimeEventBox.Enabled = false;
            this.lastRecipeTimeEventBox.Location = new System.Drawing.Point(164, 51);
            this.lastRecipeTimeEventBox.Name = "lastRecipeTimeEventBox";
            this.lastRecipeTimeEventBox.ReadOnly = true;
            this.lastRecipeTimeEventBox.Size = new System.Drawing.Size(88, 22);
            this.lastRecipeTimeEventBox.TabIndex = 22;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(13, 81);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(116, 17);
            this.label23.TabIndex = 21;
            this.label23.Text = "Next Event (min):";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(13, 51);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(115, 17);
            this.label22.TabIndex = 20;
            this.label22.Text = "Last Event (min):";
            // 
            // recipePauseCheckbox
            // 
            this.recipePauseCheckbox.AutoSize = true;
            this.recipePauseCheckbox.Location = new System.Drawing.Point(67, 170);
            this.recipePauseCheckbox.Name = "recipePauseCheckbox";
            this.recipePauseCheckbox.Size = new System.Drawing.Size(15, 14);
            this.recipePauseCheckbox.TabIndex = 19;
            this.recipePauseCheckbox.UseVisualStyleBackColor = true;
            this.recipePauseCheckbox.CheckedChanged += new System.EventHandler(this.recipePauseCheckbox_CheckedChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(5, 168);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 17);
            this.label21.TabIndex = 18;
            this.label21.Text = "Pause?";
            // 
            // exitRecipeButton
            // 
            this.exitRecipeButton.Location = new System.Drawing.Point(8, 204);
            this.exitRecipeButton.Name = "exitRecipeButton";
            this.exitRecipeButton.Size = new System.Drawing.Size(75, 49);
            this.exitRecipeButton.TabIndex = 17;
            this.exitRecipeButton.Text = "Exit Recipe";
            this.exitRecipeButton.UseVisualStyleBackColor = true;
            this.exitRecipeButton.Click += new System.EventHandler(this.exitRecipe_Click);
            // 
            // resetGraphButton
            // 
            this.resetGraphButton.Location = new System.Drawing.Point(685, 78);
            this.resetGraphButton.Name = "resetGraphButton";
            this.resetGraphButton.Size = new System.Drawing.Size(75, 44);
            this.resetGraphButton.TabIndex = 18;
            this.resetGraphButton.Text = "Reset Graph";
            this.resetGraphButton.UseVisualStyleBackColor = true;
            this.resetGraphButton.Click += new System.EventHandler(this.resetGraphButton_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.samplesToResetUpDown);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.AinGraphUpdateBox);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.graphUpdateUDbox);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.resetGraphButton);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.timeElapsedBox);
            this.panel3.Controls.Add(this.chart1);
            this.panel3.Location = new System.Drawing.Point(6, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(913, 319);
            this.panel3.TabIndex = 19;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(676, 7);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(160, 20);
            this.label18.TabIndex = 25;
            this.label18.Text = "GRAPH CONTROL";
            // 
            // samplesToResetUpDown
            // 
            this.samplesToResetUpDown.Location = new System.Drawing.Point(822, 201);
            this.samplesToResetUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.samplesToResetUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.samplesToResetUpDown.Name = "samplesToResetUpDown";
            this.samplesToResetUpDown.Size = new System.Drawing.Size(73, 22);
            this.samplesToResetUpDown.TabIndex = 24;
            this.samplesToResetUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.samplesToResetUpDown.ValueChanged += new System.EventHandler(this.samplesToResetUpDown_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(676, 201);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 17);
            this.label14.TabIndex = 23;
            this.label14.Text = "Samples until Reset:";
            // 
            // AinGraphUpdateBox
            // 
            this.AinGraphUpdateBox.AutoSize = true;
            this.AinGraphUpdateBox.Checked = true;
            this.AinGraphUpdateBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AinGraphUpdateBox.Location = new System.Drawing.Point(808, 160);
            this.AinGraphUpdateBox.Name = "AinGraphUpdateBox";
            this.AinGraphUpdateBox.Size = new System.Drawing.Size(15, 14);
            this.AinGraphUpdateBox.TabIndex = 22;
            this.AinGraphUpdateBox.UseVisualStyleBackColor = true;
            this.AinGraphUpdateBox.CheckedChanged += new System.EventHandler(this.AinGraphUpdateBox_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(686, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 17);
            this.label13.TabIndex = 21;
            this.label13.Text = "Graph Update?";
            // 
            // graphUpdateUDbox
            // 
            this.graphUpdateUDbox.DecimalPlaces = 1;
            this.graphUpdateUDbox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.graphUpdateUDbox.Location = new System.Drawing.Point(807, 236);
            this.graphUpdateUDbox.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.graphUpdateUDbox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.graphUpdateUDbox.Name = "graphUpdateUDbox";
            this.graphUpdateUDbox.Size = new System.Drawing.Size(79, 22);
            this.graphUpdateUDbox.TabIndex = 20;
            this.graphUpdateUDbox.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.graphUpdateUDbox.ValueChanged += new System.EventHandler(this.graphUpdateUD_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(682, 236);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "Update Time (s)";
            // 
            // picoammSettingsButton
            // 
            this.picoammSettingsButton.Location = new System.Drawing.Point(219, 55);
            this.picoammSettingsButton.Name = "picoammSettingsButton";
            this.picoammSettingsButton.Size = new System.Drawing.Size(88, 31);
            this.picoammSettingsButton.TabIndex = 20;
            this.picoammSettingsButton.Text = "Settings";
            this.picoammSettingsButton.UseVisualStyleBackColor = true;
            this.picoammSettingsButton.Click += new System.EventHandler(this.ke648xStart_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "PICOAMMETER";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.controlPicoammBox);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.picoammSettingsButton);
            this.panel5.Location = new System.Drawing.Point(47, 668);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(331, 100);
            this.panel5.TabIndex = 23;
            // 
            // controlPicoammBox
            // 
            this.controlPicoammBox.AutoSize = true;
            this.controlPicoammBox.Location = new System.Drawing.Point(22, 61);
            this.controlPicoammBox.Name = "controlPicoammBox";
            this.controlPicoammBox.Size = new System.Drawing.Size(158, 21);
            this.controlPicoammBox.TabIndex = 22;
            this.controlPicoammBox.Text = "Control Picoammeter";
            this.controlPicoammBox.UseVisualStyleBackColor = true;
            this.controlPicoammBox.CheckedChanged += new System.EventHandler(this.controlPicoammBox_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(439, 668);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(381, 100);
            this.panel4.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "ANALOG DAQ OUTPUT";
            // 
            // mfcMainControlEnable
            // 
            this.mfcMainControlEnable.AutoSize = true;
            this.mfcMainControlEnable.Location = new System.Drawing.Point(26, 267);
            this.mfcMainControlEnable.Name = "mfcMainControlEnable";
            this.mfcMainControlEnable.Size = new System.Drawing.Size(111, 21);
            this.mfcMainControlEnable.TabIndex = 37;
            this.mfcMainControlEnable.Text = "Control MFCs";
            this.mfcMainControlEnable.UseVisualStyleBackColor = true;
            this.mfcMainControlEnable.CheckedChanged += new System.EventHandler(this.mfcMainControlEnable_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 867);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Main Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.samplesToResetUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphUpdateUDbox)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox timeElapsedBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button loadFlowsButton;
        private System.Windows.Forms.Button viewFlowRecipe;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button configMFCsButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button resetGraphButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown graphUpdateUDbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox AinGraphUpdateBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown samplesToResetUpDown;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button exitRecipeButton;
        private System.Windows.Forms.CheckBox recipePauseCheckbox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox lastRecipeTimeEventBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox nextRecipeTimeEventBox;
        private System.Windows.Forms.Button picoammSettingsButton;
        private MFCcontrolTemplate mfcControl4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MFCcontrolTemplate mfcControl1;
        private MFCcontrolTemplate mfcControl2;
        private MFCcontrolTemplate mfcControl3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox controlPicoammBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox mfcMainControlEnable;
        
    }
}

