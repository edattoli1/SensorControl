namespace Ke648x
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // initDeviceButton
            // 
            this.initDeviceButton.Location = new System.Drawing.Point(40, 39);
            this.initDeviceButton.Name = "initDeviceButton";
            this.initDeviceButton.Size = new System.Drawing.Size(66, 46);
            this.initDeviceButton.TabIndex = 2;
            this.initDeviceButton.Text = "Re-Init 6487";
            this.initDeviceButton.UseVisualStyleBackColor = true;
            this.initDeviceButton.Click += new System.EventHandler(this.initDeviceButton_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(56, 156);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(50, 22);
            this.numericUpDown1.TabIndex = 3;
            // 
            // Ke648xGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 256);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.initDeviceButton);
            this.Name = "Ke648xGUI";
            this.Text = "Keithley 648x Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ke648xGUI_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button initDeviceButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

