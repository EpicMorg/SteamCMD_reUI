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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSplashScreen));
            this.progressbar = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cstmLblWait = new SteamCMD_reGUI_Client.UI.CustomLabel();
            this.cstmLblVersion = new SteamCMD_reGUI_Client.UI.CustomLabel();
            this.cstmLblName = new SteamCMD_reGUI_Client.UI.CustomLabel();
            this.SuspendLayout();
            // 
            // progressbar
            // 
            this.progressbar.Location = new System.Drawing.Point(12, 205);
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(456, 23);
            this.progressbar.Step = 1;
            this.progressbar.TabIndex = 9;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 30;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // cstmLblWait
            // 
            this.cstmLblWait.AutoSize = true;
            this.cstmLblWait.BackColor = System.Drawing.Color.Transparent;
            this.cstmLblWait.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cstmLblWait.ForeColor = System.Drawing.Color.White;
            this.cstmLblWait.Location = new System.Drawing.Point(12, 179);
            this.cstmLblWait.Name = "cstmLblWait";
            this.cstmLblWait.OutlineForeColor = System.Drawing.Color.Black;
            this.cstmLblWait.OutlineWidth = 5F;
            this.cstmLblWait.Size = new System.Drawing.Size(199, 23);
            this.cstmLblWait.TabIndex = 8;
            this.cstmLblWait.Text = "Loading.. Please wait";
            this.cstmLblWait.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cstmLblVersion
            // 
            this.cstmLblVersion.AutoSize = true;
            this.cstmLblVersion.BackColor = System.Drawing.Color.Transparent;
            this.cstmLblVersion.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cstmLblVersion.ForeColor = System.Drawing.Color.White;
            this.cstmLblVersion.Location = new System.Drawing.Point(218, 57);
            this.cstmLblVersion.Name = "cstmLblVersion";
            this.cstmLblVersion.OutlineForeColor = System.Drawing.Color.Black;
            this.cstmLblVersion.OutlineWidth = 5F;
            this.cstmLblVersion.Size = new System.Drawing.Size(69, 23);
            this.cstmLblVersion.TabIndex = 8;
            this.cstmLblVersion.Text = "0.0.0.0";
            this.cstmLblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cstmLblName
            // 
            this.cstmLblName.AutoSize = true;
            this.cstmLblName.BackColor = System.Drawing.Color.Transparent;
            this.cstmLblName.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cstmLblName.ForeColor = System.Drawing.Color.White;
            this.cstmLblName.Location = new System.Drawing.Point(216, 24);
            this.cstmLblName.Name = "cstmLblName";
            this.cstmLblName.OutlineForeColor = System.Drawing.Color.Black;
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
            this.BackColor = System.Drawing.Color.Lime;
            this.BackgroundImage = global::SteamCMD_reGUI_Client.Properties.Resources.splash;
            this.ClientSize = new System.Drawing.Size(480, 240);
            this.Controls.Add(this.progressbar);
            this.Controls.Add(this.cstmLblWait);
            this.Controls.Add(this.cstmLblVersion);
            this.Controls.Add(this.cstmLblName);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.Load += new System.EventHandler(this.FrmSplashScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomLabel cstmLblName;
        private CustomLabel cstmLblVersion;
        private System.Windows.Forms.ProgressBar progressbar;
        private System.Windows.Forms.Timer timer;
        private CustomLabel cstmLblWait;
        
    }
}