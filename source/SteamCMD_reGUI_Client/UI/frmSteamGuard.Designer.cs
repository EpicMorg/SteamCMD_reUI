namespace SteamCMD_reGUI_Client.UI
{
    partial class FrmSteamGuard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSteamGuard));
            this.mLblHelp = new MetroFramework.Controls.MetroLabel();
            this.mBtnEnter = new MetroFramework.Controls.MetroTile();
            this.mTxtSGPhrase = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // mLblHelp
            // 
            resources.ApplyResources(this.mLblHelp, "mLblHelp");
            this.mLblHelp.BackColor = System.Drawing.Color.Transparent;
            this.mLblHelp.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mLblHelp.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mLblHelp.Name = "mLblHelp";
            this.mLblHelp.WrapToLine = true;
            // 
            // mBtnEnter
            // 
            this.mBtnEnter.ActiveControl = null;
            resources.ApplyResources(this.mBtnEnter, "mBtnEnter");
            this.mBtnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mBtnEnter.Name = "mBtnEnter";
            this.mBtnEnter.TileImage = global::SteamCMD_reGUI_Client.Properties.Resources.dark_key;
            this.mBtnEnter.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mBtnEnter.UseSelectable = true;
            this.mBtnEnter.UseTileImage = true;
            this.mBtnEnter.Click += new System.EventHandler(this.mBtnEnter_Click);
            // 
            // mTxtSGPhrase
            // 
            resources.ApplyResources(this.mTxtSGPhrase, "mTxtSGPhrase");
            this.mTxtSGPhrase.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.mTxtSGPhrase.Icon = global::SteamCMD_reGUI_Client.Properties.Resources.dark_unlock;
            this.mTxtSGPhrase.Lines = new string[0];
            this.mTxtSGPhrase.MaxLength = 32767;
            this.mTxtSGPhrase.Name = "mTxtSGPhrase";
            this.mTxtSGPhrase.PromptText = "...here";
            this.mTxtSGPhrase.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtSGPhrase.SelectedText = "";
            this.mTxtSGPhrase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mTxtSGPhrase.UseSelectable = true;
            this.mTxtSGPhrase.TextChanged += new System.EventHandler(this.mTxtSGPhrase_TextChanged);
            // 
            // FrmSteamGuard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mBtnEnter);
            this.Controls.Add(this.mLblHelp);
            this.Controls.Add(this.mTxtSGPhrase);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSteamGuard";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.frmSteamGuard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox mTxtSGPhrase;
        private MetroFramework.Controls.MetroLabel mLblHelp;
        private MetroFramework.Controls.MetroTile mBtnEnter;
    }
}