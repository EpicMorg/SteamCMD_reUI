namespace SteamCMD_reGUI_Client.UI
{
    partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.mBtnSave = new MetroFramework.Controls.MetroButton();
            this.mTabsSettings = new MetroFramework.Controls.MetroTabControl();
            this.mTabInterface = new MetroFramework.Controls.MetroTabPage();
            this.mLblAppStyle = new MetroFramework.Controls.MetroLabel();
            this.mComboAppStyle = new MetroFramework.Controls.MetroComboBox();
            this.mLblAppTheme = new MetroFramework.Controls.MetroLabel();
            this.mComboAppTheme = new MetroFramework.Controls.MetroComboBox();
            this.mLblLang = new MetroFramework.Controls.MetroLabel();
            this.mComboLang = new MetroFramework.Controls.MetroComboBox();
            this.mTabPaths = new MetroFramework.Controls.MetroTabPage();
            this.mLblSTEAMCMD = new MetroFramework.Controls.MetroLabel();
            this.mLblShowSplash = new MetroFramework.Controls.MetroLabel();
            this.mToogleShowSplash = new MetroFramework.Controls.MetroToggle();
            this.mTxtSTEAMCMD = new MetroFramework.Controls.MetroTextBox();
            this.mBtnBrowse = new MetroFramework.Controls.MetroButton();
            this.mTabsSettings.SuspendLayout();
            this.mTabInterface.SuspendLayout();
            this.mTabPaths.SuspendLayout();
            this.SuspendLayout();
            // 
            // mBtnSave
            // 
            resources.ApplyResources(this.mBtnSave, "mBtnSave");
            this.mBtnSave.Name = "mBtnSave";
            this.mBtnSave.UseSelectable = true;
            // 
            // mTabsSettings
            // 
            resources.ApplyResources(this.mTabsSettings, "mTabsSettings");
            this.mTabsSettings.Controls.Add(this.mTabInterface);
            this.mTabsSettings.Controls.Add(this.mTabPaths);
            this.mTabsSettings.Multiline = true;
            this.mTabsSettings.Name = "mTabsSettings";
            this.mTabsSettings.SelectedIndex = 1;
            this.mTabsSettings.UseSelectable = true;
            // 
            // mTabInterface
            // 
            this.mTabInterface.Controls.Add(this.mToogleShowSplash);
            this.mTabInterface.Controls.Add(this.mLblShowSplash);
            this.mTabInterface.Controls.Add(this.mLblAppStyle);
            this.mTabInterface.Controls.Add(this.mComboAppStyle);
            this.mTabInterface.Controls.Add(this.mLblAppTheme);
            this.mTabInterface.Controls.Add(this.mComboAppTheme);
            this.mTabInterface.Controls.Add(this.mLblLang);
            this.mTabInterface.Controls.Add(this.mComboLang);
            this.mTabInterface.HorizontalScrollbarBarColor = true;
            this.mTabInterface.HorizontalScrollbarHighlightOnWheel = false;
            this.mTabInterface.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.mTabInterface, "mTabInterface");
            this.mTabInterface.Name = "mTabInterface";
            this.mTabInterface.VerticalScrollbarBarColor = true;
            this.mTabInterface.VerticalScrollbarHighlightOnWheel = false;
            this.mTabInterface.VerticalScrollbarSize = 10;
            // 
            // mLblAppStyle
            // 
            resources.ApplyResources(this.mLblAppStyle, "mLblAppStyle");
            this.mLblAppStyle.Name = "mLblAppStyle";
            // 
            // mComboAppStyle
            // 
            this.mComboAppStyle.FormattingEnabled = true;
            resources.ApplyResources(this.mComboAppStyle, "mComboAppStyle");
            this.mComboAppStyle.Items.AddRange(new object[] {
            resources.GetString("mComboAppStyle.Items"),
            resources.GetString("mComboAppStyle.Items1")});
            this.mComboAppStyle.Name = "mComboAppStyle";
            this.mComboAppStyle.UseSelectable = true;
            // 
            // mLblAppTheme
            // 
            resources.ApplyResources(this.mLblAppTheme, "mLblAppTheme");
            this.mLblAppTheme.Name = "mLblAppTheme";
            // 
            // mComboAppTheme
            // 
            this.mComboAppTheme.FormattingEnabled = true;
            resources.ApplyResources(this.mComboAppTheme, "mComboAppTheme");
            this.mComboAppTheme.Items.AddRange(new object[] {
            resources.GetString("mComboAppTheme.Items"),
            resources.GetString("mComboAppTheme.Items1")});
            this.mComboAppTheme.Name = "mComboAppTheme";
            this.mComboAppTheme.UseSelectable = true;
            // 
            // mLblLang
            // 
            resources.ApplyResources(this.mLblLang, "mLblLang");
            this.mLblLang.Name = "mLblLang";
            // 
            // mComboLang
            // 
            this.mComboLang.FormattingEnabled = true;
            resources.ApplyResources(this.mComboLang, "mComboLang");
            this.mComboLang.Items.AddRange(new object[] {
            resources.GetString("mComboLang.Items"),
            resources.GetString("mComboLang.Items1")});
            this.mComboLang.Name = "mComboLang";
            this.mComboLang.UseSelectable = true;
            // 
            // mTabPaths
            // 
            this.mTabPaths.Controls.Add(this.mBtnBrowse);
            this.mTabPaths.Controls.Add(this.mTxtSTEAMCMD);
            this.mTabPaths.Controls.Add(this.mLblSTEAMCMD);
            this.mTabPaths.HorizontalScrollbarBarColor = true;
            this.mTabPaths.HorizontalScrollbarHighlightOnWheel = false;
            this.mTabPaths.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.mTabPaths, "mTabPaths");
            this.mTabPaths.Name = "mTabPaths";
            this.mTabPaths.VerticalScrollbarBarColor = true;
            this.mTabPaths.VerticalScrollbarHighlightOnWheel = false;
            this.mTabPaths.VerticalScrollbarSize = 10;
            // 
            // mLblSTEAMCMD
            // 
            resources.ApplyResources(this.mLblSTEAMCMD, "mLblSTEAMCMD");
            this.mLblSTEAMCMD.Name = "mLblSTEAMCMD";
            // 
            // mLblShowSplash
            // 
            resources.ApplyResources(this.mLblShowSplash, "mLblShowSplash");
            this.mLblShowSplash.Name = "mLblShowSplash";
            // 
            // mToogleShowSplash
            // 
            resources.ApplyResources(this.mToogleShowSplash, "mToogleShowSplash");
            this.mToogleShowSplash.Checked = true;
            this.mToogleShowSplash.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mToogleShowSplash.Name = "mToogleShowSplash";
            this.mToogleShowSplash.UseSelectable = true;
            // 
            // mTxtSTEAMCMD
            // 
            this.mTxtSTEAMCMD.Lines = new string[0];
            resources.ApplyResources(this.mTxtSTEAMCMD, "mTxtSTEAMCMD");
            this.mTxtSTEAMCMD.MaxLength = 32767;
            this.mTxtSTEAMCMD.Name = "mTxtSTEAMCMD";
            this.mTxtSTEAMCMD.PasswordChar = '\0';
            this.mTxtSTEAMCMD.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtSTEAMCMD.SelectedText = "";
            this.mTxtSTEAMCMD.UseSelectable = true;
            // 
            // mBtnBrowse
            // 
            resources.ApplyResources(this.mBtnBrowse, "mBtnBrowse");
            this.mBtnBrowse.Name = "mBtnBrowse";
            this.mBtnBrowse.UseSelectable = true;
            // 
            // FrmSettings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mTabsSettings);
            this.Controls.Add(this.mBtnSave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSettings";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.mTabsSettings.ResumeLayout(false);
            this.mTabInterface.ResumeLayout(false);
            this.mTabInterface.PerformLayout();
            this.mTabPaths.ResumeLayout(false);
            this.mTabPaths.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton mBtnSave;
        private MetroFramework.Controls.MetroTabControl mTabsSettings;
        private MetroFramework.Controls.MetroTabPage mTabInterface;
        private MetroFramework.Controls.MetroComboBox mComboLang;
        private MetroFramework.Controls.MetroLabel mLblLang;
        private MetroFramework.Controls.MetroLabel mLblAppStyle;
        private MetroFramework.Controls.MetroComboBox mComboAppStyle;
        private MetroFramework.Controls.MetroLabel mLblAppTheme;
        private MetroFramework.Controls.MetroComboBox mComboAppTheme;
        private MetroFramework.Controls.MetroTabPage mTabPaths;
        private MetroFramework.Controls.MetroLabel mLblSTEAMCMD;
        private MetroFramework.Controls.MetroLabel mLblShowSplash;
        private MetroFramework.Controls.MetroToggle mToogleShowSplash;
        private MetroFramework.Controls.MetroTextBox mTxtSTEAMCMD;
        private MetroFramework.Controls.MetroButton mBtnBrowse;
    }
}