
namespace IotShopSerialViewer
{
    partial class SerialViewier
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
            this.components = new System.ComponentModel.Container();
            this.SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.COMPortsButton = new System.Windows.Forms.Button();
            this.ReciveDataTextBox = new System.Windows.Forms.TextBox();
            this.SerialPortDataLabel = new System.Windows.Forms.Label();
            this.FileSavingCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // SerialPort
            // 
            this.SerialPort.PortName = "COM3";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // COMPortsButton
            // 
            this.COMPortsButton.Location = new System.Drawing.Point(27, 119);
            this.COMPortsButton.Name = "COMPortsButton";
            this.COMPortsButton.Size = new System.Drawing.Size(160, 35);
            this.COMPortsButton.TabIndex = 1;
            this.COMPortsButton.Text = "COM Ports ";
            this.COMPortsButton.UseVisualStyleBackColor = true;
            this.COMPortsButton.Click += new System.EventHandler(this.COMPortsButton_Click);
            // 
            // ReciveDataTextBox
            // 
            this.ReciveDataTextBox.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ReciveDataTextBox.Location = new System.Drawing.Point(27, 195);
            this.ReciveDataTextBox.Multiline = true;
            this.ReciveDataTextBox.Name = "ReciveDataTextBox";
            this.ReciveDataTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ReciveDataTextBox.Size = new System.Drawing.Size(440, 273);
            this.ReciveDataTextBox.TabIndex = 2;
            this.ReciveDataTextBox.UseWaitCursor = true;
            this.ReciveDataTextBox.TextChanged += new System.EventHandler(this.ReciveDataTextBox_TextChanged);
            // 
            // SerialPortDataLabel
            // 
            this.SerialPortDataLabel.AutoSize = true;
            this.SerialPortDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialPortDataLabel.Location = new System.Drawing.Point(159, 157);
            this.SerialPortDataLabel.Name = "SerialPortDataLabel";
            this.SerialPortDataLabel.Size = new System.Drawing.Size(186, 25);
            this.SerialPortDataLabel.TabIndex = 3;
            this.SerialPortDataLabel.Text = "Serial Port Data ";
            // 
            // FileSavingCheckBox
            // 
            this.FileSavingCheckBox.AutoSize = true;
            this.FileSavingCheckBox.Location = new System.Drawing.Point(402, 162);
            this.FileSavingCheckBox.Name = "FileSavingCheckBox";
            this.FileSavingCheckBox.Size = new System.Drawing.Size(107, 20);
            this.FileSavingCheckBox.TabIndex = 4;
            this.FileSavingCheckBox.Text = "Save To File ";
            this.FileSavingCheckBox.UseVisualStyleBackColor = true;
            this.FileSavingCheckBox.CheckedChanged += new System.EventHandler(this.FileSavingCheckBox_CheckedChanged);
            // 
            // SerialViewier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(521, 523);
            this.Controls.Add(this.FileSavingCheckBox);
            this.Controls.Add(this.SerialPortDataLabel);
            this.Controls.Add(this.ReciveDataTextBox);
            this.Controls.Add(this.COMPortsButton);
            this.Controls.Add(this.comboBox1);
            this.Name = "SerialViewier";
            this.Text = "Arduino Software Serial Viewier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort SerialPort;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button COMPortsButton;
        private System.Windows.Forms.TextBox ReciveDataTextBox;
        private System.Windows.Forms.Label SerialPortDataLabel;
        private System.Windows.Forms.CheckBox FileSavingCheckBox;
    }
}

