﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NationalInstruments.NI4882;

namespace Ke648x
{
    public partial class Ke648xGUI : Form
    {

        Ke648xControl pAmm;

        public Ke648xGUI()
        {
            InitializeComponent();
            pAmm = new Ke648xControl();


        }

        private void startGPIBbutton_Click(object sender, EventArgs e)
        {
            
            pAmm.InitSession();
            string stringRead = pAmm.GetIdentString();

            gpibReadBox.Text = stringRead;
            

        }


        private void initDeviceButton_Click(object sender, EventArgs e)
        {
            pAmm.InitDevice();

        }

        private void Ke648xGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            e.Cancel = true;
            base.OnClosing(e);
        }

    }
}
