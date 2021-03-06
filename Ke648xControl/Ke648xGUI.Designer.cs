﻿namespace Ke648x
{
    partial class Ke648xGUI
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
            this.initDeviceButton = new System.Windows.Forms.Button();
            this.picoammRangeUpDown = new System.Windows.Forms.NumericUpDown();
            this.presPicoammRead = new System.Windows.Forms.TextBox();
            this.refreshPicoammRead = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picoammRangeUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // initDeviceButton
            // 
            this.initDeviceButton.Location = new System.Drawing.Point(40, 39);
            this.initDeviceButton.Name = "initDeviceButton";
            this.initDeviceButton.Size = new System.Drawing.Size(66, 46);
            this.initDeviceButton.TabIndex = 2;
            this.initDeviceButton.Text = "Re-Init 648x";
            this.initDeviceButton.UseVisualStyleBackColor = true;
            this.initDeviceButton.Click += new System.EventHandler(this.initDeviceButton_Click);
            // 
            // picoammRangeUpDown
            // 
            this.picoammRangeUpDown.Location = new System.Drawing.Point(56, 156);
            this.picoammRangeUpDown.Name = "picoammRangeUpDown";
            this.picoammRangeUpDown.Size = new System.Drawing.Size(50, 22);
            this.picoammRangeUpDown.TabIndex = 3;
            // 
            // presPicoammRead
            // 
            this.presPicoammRead.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.presPicoammRead.Location = new System.Drawing.Point(258, 108);
            this.presPicoammRead.Name = "presPicoammRead";
            this.presPicoammRead.Size = new System.Drawing.Size(100, 22);
            this.presPicoammRead.TabIndex = 4;
            // 
            // refreshPicoammRead
            // 
            this.refreshPicoammRead.AutoSize = true;
            this.refreshPicoammRead.Location = new System.Drawing.Point(262, 156);
            this.refreshPicoammRead.Name = "refreshPicoammRead";
            this.refreshPicoammRead.Size = new System.Drawing.Size(163, 38);
            this.refreshPicoammRead.TabIndex = 5;
            this.refreshPicoammRead.Text = "Refresh Picoammeter\r\nReadings";
            this.refreshPicoammRead.UseVisualStyleBackColor = true;
            // 
            // Ke648xGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 256);
            this.Controls.Add(this.refreshPicoammRead);
            this.Controls.Add(this.presPicoammRead);
            this.Controls.Add(this.picoammRangeUpDown);
            this.Controls.Add(this.initDeviceButton);
            this.Name = "Ke648xGUI";
            this.Text = "Keithley 648x Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ke648xGUI_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picoammRangeUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button initDeviceButton;
        private System.Windows.Forms.NumericUpDown picoammRangeUpDown;
        private System.Windows.Forms.TextBox presPicoammRead;
        private System.Windows.Forms.CheckBox refreshPicoammRead;
    }
}

