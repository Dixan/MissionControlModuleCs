namespace MissionControlModuleCs
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
			this.btnLaunch = new System.Windows.Forms.Button();
			this.btnSetAltitude = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.pnlTimerActive = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.cbSelectIfDangerShieldIsUsed = new System.Windows.Forms.CheckBox();
			this.lblArduinoConnectionSettingsHelpDkal = new System.Windows.Forms.Label();
			this.btnScanPortsDkal = new System.Windows.Forms.Button();
			this.cbbSerialPortsDkal = new System.Windows.Forms.ComboBox();
			this.cbbBaudRateDkal = new System.Windows.Forms.ComboBox();
			this.label17 = new System.Windows.Forms.Label();
			this.btnSerialPortOpenDkal = new System.Windows.Forms.Button();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnLaunch
			// 
			this.btnLaunch.Location = new System.Drawing.Point(93, 415);
			this.btnLaunch.Name = "btnLaunch";
			this.btnLaunch.Size = new System.Drawing.Size(75, 23);
			this.btnLaunch.TabIndex = 0;
			this.btnLaunch.Text = "Launch";
			this.btnLaunch.UseVisualStyleBackColor = true;
			this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
			// 
			// btnSetAltitude
			// 
			this.btnSetAltitude.Location = new System.Drawing.Point(12, 415);
			this.btnSetAltitude.Name = "btnSetAltitude";
			this.btnSetAltitude.Size = new System.Drawing.Size(75, 23);
			this.btnSetAltitude.TabIndex = 1;
			this.btnSetAltitude.Text = "Set altitude";
			this.btnSetAltitude.UseVisualStyleBackColor = true;
			this.btnSetAltitude.Click += new System.EventHandler(this.btnSetAltitude_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(174, 415);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(450, 374);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// groupBox2
			// 
			this.groupBox2.Location = new System.Drawing.Point(535, 329);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 100);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "groupBox2";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.label7);
			this.groupBox4.Controls.Add(this.pnlTimerActive);
			this.groupBox4.Controls.Add(this.label1);
			this.groupBox4.Controls.Add(this.cbSelectIfDangerShieldIsUsed);
			this.groupBox4.Controls.Add(this.lblArduinoConnectionSettingsHelpDkal);
			this.groupBox4.Controls.Add(this.btnScanPortsDkal);
			this.groupBox4.Controls.Add(this.cbbSerialPortsDkal);
			this.groupBox4.Controls.Add(this.cbbBaudRateDkal);
			this.groupBox4.Controls.Add(this.label17);
			this.groupBox4.Controls.Add(this.btnSerialPortOpenDkal);
			this.groupBox4.Location = new System.Drawing.Point(741, 41);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(143, 198);
			this.groupBox4.TabIndex = 23;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Arduino connection";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 74);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(29, 13);
			this.label7.TabIndex = 26;
			this.label7.Text = "Port:";
			// 
			// pnlTimerActive
			// 
			this.pnlTimerActive.Location = new System.Drawing.Point(93, 172);
			this.pnlTimerActive.Name = "pnlTimerActive";
			this.pnlTimerActive.Size = new System.Drawing.Size(41, 10);
			this.pnlTimerActive.TabIndex = 25;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(5, 169);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 13);
			this.label1.TabIndex = 24;
			this.label1.Text = "Timer active:";
			// 
			// cbSelectIfDangerShieldIsUsed
			// 
			this.cbSelectIfDangerShieldIsUsed.AutoSize = true;
			this.cbSelectIfDangerShieldIsUsed.Location = new System.Drawing.Point(9, 48);
			this.cbSelectIfDangerShieldIsUsed.Name = "cbSelectIfDangerShieldIsUsed";
			this.cbSelectIfDangerShieldIsUsed.Size = new System.Drawing.Size(128, 17);
			this.cbSelectIfDangerShieldIsUsed.TabIndex = 11;
			this.cbSelectIfDangerShieldIsUsed.Text = "remove last character";
			this.cbSelectIfDangerShieldIsUsed.UseVisualStyleBackColor = true;
			// 
			// lblArduinoConnectionSettingsHelpDkal
			// 
			this.lblArduinoConnectionSettingsHelpDkal.AutoSize = true;
			this.lblArduinoConnectionSettingsHelpDkal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.lblArduinoConnectionSettingsHelpDkal.Location = new System.Drawing.Point(378, 0);
			this.lblArduinoConnectionSettingsHelpDkal.Name = "lblArduinoConnectionSettingsHelpDkal";
			this.lblArduinoConnectionSettingsHelpDkal.Size = new System.Drawing.Size(13, 13);
			this.lblArduinoConnectionSettingsHelpDkal.TabIndex = 10;
			this.lblArduinoConnectionSettingsHelpDkal.Text = "?";
			// 
			// btnScanPortsDkal
			// 
			this.btnScanPortsDkal.Location = new System.Drawing.Point(9, 19);
			this.btnScanPortsDkal.Name = "btnScanPortsDkal";
			this.btnScanPortsDkal.Size = new System.Drawing.Size(128, 23);
			this.btnScanPortsDkal.TabIndex = 3;
			this.btnScanPortsDkal.Text = "Scan USB ports";
			this.btnScanPortsDkal.UseVisualStyleBackColor = true;
			// 
			// cbbSerialPortsDkal
			// 
			this.cbbSerialPortsDkal.FormattingEnabled = true;
			this.cbbSerialPortsDkal.Location = new System.Drawing.Point(41, 71);
			this.cbbSerialPortsDkal.Name = "cbbSerialPortsDkal";
			this.cbbSerialPortsDkal.Size = new System.Drawing.Size(93, 21);
			this.cbbSerialPortsDkal.TabIndex = 2;
			// 
			// cbbBaudRateDkal
			// 
			this.cbbBaudRateDkal.Enabled = false;
			this.cbbBaudRateDkal.FormattingEnabled = true;
			this.cbbBaudRateDkal.Items.AddRange(new object[] {
            "9600",
            "38400"});
			this.cbbBaudRateDkal.Location = new System.Drawing.Point(9, 140);
			this.cbbBaudRateDkal.Name = "cbbBaudRateDkal";
			this.cbbBaudRateDkal.Size = new System.Drawing.Size(125, 21);
			this.cbbBaudRateDkal.TabIndex = 4;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Enabled = false;
			this.label17.Location = new System.Drawing.Point(6, 124);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(123, 13);
			this.label17.TabIndex = 5;
			this.label17.Text = "select Arduino Baudrate:";
			// 
			// btnSerialPortOpenDkal
			// 
			this.btnSerialPortOpenDkal.Enabled = false;
			this.btnSerialPortOpenDkal.Location = new System.Drawing.Point(9, 98);
			this.btnSerialPortOpenDkal.Name = "btnSerialPortOpenDkal";
			this.btnSerialPortOpenDkal.Size = new System.Drawing.Size(125, 23);
			this.btnSerialPortOpenDkal.TabIndex = 6;
			this.btnSerialPortOpenDkal.Text = "Open port";
			this.btnSerialPortOpenDkal.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1031, 478);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnSetAltitude);
			this.Controls.Add(this.btnLaunch);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnLaunch;
		private System.Windows.Forms.Button btnSetAltitude;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel pnlTimerActive;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox cbSelectIfDangerShieldIsUsed;
		private System.Windows.Forms.Label lblArduinoConnectionSettingsHelpDkal;
		private System.Windows.Forms.Button btnScanPortsDkal;
		private System.Windows.Forms.ComboBox cbbSerialPortsDkal;
		private System.Windows.Forms.ComboBox cbbBaudRateDkal;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Button btnSerialPortOpenDkal;
	}
}

