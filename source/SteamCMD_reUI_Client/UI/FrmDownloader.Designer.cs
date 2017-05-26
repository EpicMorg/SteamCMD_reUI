namespace SteamCMD_reUI_Client.UI
{
    partial class FrmDownloader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDownloader));
            this.metroProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // metroProgressBar
            // 
            resources.ApplyResources(this.metroProgressBar, "metroProgressBar");
            this.metroProgressBar.Name = "metroProgressBar";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "steamcmd.zip";
            resources.ApplyResources(this.saveFileDialog, "saveFileDialog");
            // 
            // FrmDownloader
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroProgressBar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDownloader";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FrmDownloader_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroProgressBar metroProgressBar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;

    }
}