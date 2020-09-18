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
			this.SuspendLayout();
			// 
			// btnLaunch
			// 
			this.btnLaunch.Location = new System.Drawing.Point(12, 12);
			this.btnLaunch.Name = "btnLaunch";
			this.btnLaunch.Size = new System.Drawing.Size(75, 23);
			this.btnLaunch.TabIndex = 0;
			this.btnLaunch.Text = "Launch";
			this.btnLaunch.UseVisualStyleBackColor = true;
			this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
			// 
			// btnSetAltitude
			// 
			this.btnSetAltitude.Location = new System.Drawing.Point(93, 12);
			this.btnSetAltitude.Name = "btnSetAltitude";
			this.btnSetAltitude.Size = new System.Drawing.Size(75, 23);
			this.btnSetAltitude.TabIndex = 1;
			this.btnSetAltitude.Text = "Set altitude";
			this.btnSetAltitude.UseVisualStyleBackColor = true;
			this.btnSetAltitude.Click += new System.EventHandler(this.btnSetAltitude_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(174, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnSetAltitude);
			this.Controls.Add(this.btnLaunch);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnLaunch;
		private System.Windows.Forms.Button btnSetAltitude;
		private System.Windows.Forms.Button button1;
	}
}

