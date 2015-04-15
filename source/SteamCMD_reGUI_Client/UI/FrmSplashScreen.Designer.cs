namespace SteamCMD_reGUI_Client.UI
{
    partial class FrmSplashScreen
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSplashScreen));
			this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
			this.wpfMediaControl1 = new SteamCMD_reGUI_Client_WpfControls.WpfMediaControl();
			this.cstmLblWait = new SteamCMD_reGUI_Client.UI.CustomLabel();
			this.cstmLblVersion = new SteamCMD_reGUI_Client.UI.CustomLabel();
			this.cstmLblName = new SteamCMD_reGUI_Client.UI.CustomLabel();
			this.SuspendLayout();
			// 
			// elementHost1
			// 
			this.elementHost1.BackColor = System.Drawing.Color.Transparent;
			this.elementHost1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.elementHost1.Location = new System.Drawing.Point(0, 35);
			this.elementHost1.Name = "elementHost1";
			this.elementHost1.Size = new System.Drawing.Size(493, 251);
			this.elementHost1.TabIndex = 9;
			this.elementHost1.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.elementHost1_ChildChanged);
			this.elementHost1.Child = this.wpfMediaControl1;
			// 
			// cstmLblWait
			// 
			this.cstmLblWait.AutoSize = true;
			this.cstmLblWait.BackColor = System.Drawing.Color.Black;
			this.cstmLblWait.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cstmLblWait.ForeColor = System.Drawing.Color.White;
			this.cstmLblWait.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.cstmLblWait.Location = new System.Drawing.Point(12, 260);
			this.cstmLblWait.Name = "cstmLblWait";
			this.cstmLblWait.OutlineForeColor = System.Drawing.Color.Navy;
			this.cstmLblWait.OutlineWidth = 5F;
			this.cstmLblWait.Size = new System.Drawing.Size(148, 17);
			this.cstmLblWait.TabIndex = 8;
			this.cstmLblWait.Text = "Loading.. Please wait";
			this.cstmLblWait.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cstmLblVersion
			// 
			this.cstmLblVersion.AutoSize = true;
			this.cstmLblVersion.BackColor = System.Drawing.Color.Black;
			this.cstmLblVersion.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cstmLblVersion.ForeColor = System.Drawing.Color.White;
			this.cstmLblVersion.Location = new System.Drawing.Point(419, 9);
			this.cstmLblVersion.Name = "cstmLblVersion";
			this.cstmLblVersion.OutlineForeColor = System.Drawing.Color.Navy;
			this.cstmLblVersion.OutlineWidth = 5F;
			this.cstmLblVersion.Size = new System.Drawing.Size(52, 17);
			this.cstmLblVersion.TabIndex = 8;
			this.cstmLblVersion.Text = "0.0.0.0";
			this.cstmLblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cstmLblName
			// 
			this.cstmLblName.AutoSize = true;
			this.cstmLblName.BackColor = System.Drawing.Color.Black;
			this.cstmLblName.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cstmLblName.ForeColor = System.Drawing.Color.White;
			this.cstmLblName.Location = new System.Drawing.Point(12, 9);
			this.cstmLblName.Name = "cstmLblName";
			this.cstmLblName.OutlineForeColor = System.Drawing.Color.Navy;
			this.cstmLblName.OutlineWidth = 5F;
			this.cstmLblName.Size = new System.Drawing.Size(252, 33);
			this.cstmLblName.TabIndex = 7;
			this.cstmLblName.Text = "Steam CMD reGUI";
			this.cstmLblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// FrmSplashScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(493, 286);
			this.Controls.Add(this.cstmLblWait);
			this.Controls.Add(this.cstmLblVersion);
			this.Controls.Add(this.cstmLblName);
			this.Controls.Add(this.elementHost1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmSplashScreen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = " ";
			this.Load += new System.EventHandler(this.FrmSplashScreen_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
		private System.Windows.Forms.Integration.ElementHost elementHost1;
		private SteamCMD_reGUI_Client_WpfControls.WpfMediaControl wpfMediaControl1;
		private CustomLabel cstmLblName;
		private CustomLabel cstmLblVersion;
		private CustomLabel cstmLblWait;
	}
}