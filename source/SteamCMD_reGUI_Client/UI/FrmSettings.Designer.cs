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
            this.fileBrowser = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.mTabsSettings = new MetroFramework.Controls.MetroTabControl();
            this.mTabInterface = new MetroFramework.Controls.MetroTabPage();
            this.mToogleShowSplash = new MetroFramework.Controls.MetroToggle();
            this.mLblShowSplash = new MetroFramework.Controls.MetroLabel();
            this.mLblAppStyle = new MetroFramework.Controls.MetroLabel();
            this.mComboAppStyle = new MetroFramework.Controls.MetroComboBox();
            this.mLblAppTheme = new MetroFramework.Controls.MetroLabel();
            this.mComboAppTheme = new MetroFramework.Controls.MetroComboBox();
            this.mLblLang = new MetroFramework.Controls.MetroLabel();
            this.mComboLang = new MetroFramework.Controls.MetroComboBox();
            this.mTabPaths = new MetroFramework.Controls.MetroTabPage();
            this.mBtnDownload = new MetroFramework.Controls.MetroButton();
            this.mBtnDeafOD = new MetroFramework.Controls.MetroButton();
            this.mBtnBrowse = new MetroFramework.Controls.MetroButton();
            this.mTxtDeafOD = new MetroFramework.Controls.MetroTextBox();
            this.mLblDeafOD = new MetroFramework.Controls.MetroLabel();
            this.mTxtSTEAMCMD = new MetroFramework.Controls.MetroTextBox();
            this.mLblSTEAMCMD = new MetroFramework.Controls.MetroLabel();
            this.mTabOther = new MetroFramework.Controls.MetroTabPage();
            this.mToogleLog = new MetroFramework.Controls.MetroToggle();
            this.mLblLog = new MetroFramework.Controls.MetroLabel();
            this.mBtnReset = new MetroFramework.Controls.MetroButton();
            this.mBtnSave = new MetroFramework.Controls.MetroButton();
            this.mTabsSettings.SuspendLayout();
            this.mTabInterface.SuspendLayout();
            this.mTabPaths.SuspendLayout();
            this.mTabOther.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileBrowser
            // 
            resources.ApplyResources(this.fileBrowser, "fileBrowser");
            // 
            // mTabsSettings
            // 
            resources.ApplyResources(this.mTabsSettings, "mTabsSettings");
            this.mTabsSettings.Controls.Add(this.mTabInterface);
            this.mTabsSettings.Controls.Add(this.mTabPaths);
            this.mTabsSettings.Controls.Add(this.mTabOther);
            this.mTabsSettings.Multiline = true;
            this.mTabsSettings.Name = "mTabsSettings";
            this.mTabsSettings.SelectedIndex = 2;
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
            // mToogleShowSplash
            // 
            resources.ApplyResources(this.mToogleShowSplash, "mToogleShowSplash");
            this.mToogleShowSplash.Checked = true;
            this.mToogleShowSplash.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mToogleShowSplash.Name = "mToogleShowSplash";
            this.mToogleShowSplash.UseSelectable = true;
            // 
            // mLblShowSplash
            // 
            resources.ApplyResources(this.mLblShowSplash, "mLblShowSplash");
            this.mLblShowSplash.Name = "mLblShowSplash";
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
            this.mComboLang.Name = "mComboLang";
            this.mComboLang.UseSelectable = true;
            // 
            // mTabPaths
            // 
            this.mTabPaths.Controls.Add(this.mBtnDownload);
            this.mTabPaths.Controls.Add(this.mBtnDeafOD);
            this.mTabPaths.Controls.Add(this.mBtnBrowse);
            this.mTabPaths.Controls.Add(this.mTxtDeafOD);
            this.mTabPaths.Controls.Add(this.mLblDeafOD);
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
            // mBtnDownload
            // 
            resources.ApplyResources(this.mBtnDownload, "mBtnDownload");
            this.mBtnDownload.Name = "mBtnDownload";
            this.mBtnDownload.UseSelectable = true;
            this.mBtnDownload.Click += new System.EventHandler(this.mBtnDownload_Click);
            // 
            // mBtnDeafOD
            // 
            resources.ApplyResources(this.mBtnDeafOD, "mBtnDeafOD");
            this.mBtnDeafOD.Name = "mBtnDeafOD";
            this.mBtnDeafOD.UseSelectable = true;
            this.mBtnDeafOD.Click += new System.EventHandler(this.mBtnDeafOD_Click);
            // 
            // mBtnBrowse
            // 
            resources.ApplyResources(this.mBtnBrowse, "mBtnBrowse");
            this.mBtnBrowse.Name = "mBtnBrowse";
            this.mBtnBrowse.UseSelectable = true;
            this.mBtnBrowse.Click += new System.EventHandler(this.mBtnBrowse_Click);
            // 
            // mTxtDeafOD
            // 
            this.mTxtDeafOD.Lines = new string[0];
            resources.ApplyResources(this.mTxtDeafOD, "mTxtDeafOD");
            this.mTxtDeafOD.MaxLength = 32767;
            this.mTxtDeafOD.Name = "mTxtDeafOD"; 
            this.mTxtDeafOD.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtDeafOD.SelectedText = "";
            this.mTxtDeafOD.UseSelectable = true;
            // 
            // mLblDeafOD
            // 
            resources.ApplyResources(this.mLblDeafOD, "mLblDeafOD");
            this.mLblDeafOD.Name = "mLblDeafOD";
            // 
            // mTxtSTEAMCMD
            // 
            this.mTxtSTEAMCMD.Lines = new string[0];
            resources.ApplyResources(this.mTxtSTEAMCMD, "mTxtSTEAMCMD");
            this.mTxtSTEAMCMD.MaxLength = 32767;
            this.mTxtSTEAMCMD.Name = "mTxtSTEAMCMD"; 
            this.mTxtSTEAMCMD.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtSTEAMCMD.SelectedText = "";
            this.mTxtSTEAMCMD.UseSelectable = true;
            // 
            // mLblSTEAMCMD
            // 
            resources.ApplyResources(this.mLblSTEAMCMD, "mLblSTEAMCMD");
            this.mLblSTEAMCMD.Name = "mLblSTEAMCMD";
            // 
            // mTabOther
            // 
            this.mTabOther.Controls.Add(this.mToogleLog);
            this.mTabOther.Controls.Add(this.mLblLog);
            this.mTabOther.HorizontalScrollbarBarColor = true;
            this.mTabOther.HorizontalScrollbarHighlightOnWheel = false;
            this.mTabOther.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.mTabOther, "mTabOther");
            this.mTabOther.Name = "mTabOther";
            this.mTabOther.VerticalScrollbarBarColor = true;
            this.mTabOther.VerticalScrollbarHighlightOnWheel = false;
            this.mTabOther.VerticalScrollbarSize = 10;
            // 
            // mToogleLog
            // 
            resources.ApplyResources(this.mToogleLog, "mToogleLog");
            this.mToogleLog.Checked = true;
            this.mToogleLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mToogleLog.Name = "mToogleLog";
            this.mToogleLog.UseSelectable = true;
            // 
            // mLblLog
            // 
            resources.ApplyResources(this.mLblLog, "mLblLog");
            this.mLblLog.Name = "mLblLog";
            // 
            // mBtnReset
            // 
            resources.ApplyResources(this.mBtnReset, "mBtnReset");
            this.mBtnReset.Name = "mBtnReset";
            this.mBtnReset.UseSelectable = true;
            this.mBtnReset.Click += new System.EventHandler(this.mBtnReset_Click);
            // 
            // mBtnSave
            // 
            resources.ApplyResources(this.mBtnSave, "mBtnSave");
            this.mBtnSave.Name = "mBtnSave";
            this.mBtnSave.UseSelectable = true;
            this.mBtnSave.Click += new System.EventHandler(this.mBtnSave_Click);
            // 
            // FrmSettings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mTabsSettings);
            this.Controls.Add(this.mBtnReset);
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
            this.mTabOther.ResumeLayout(false);
            this.mTabOther.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton mBtnSave;
        private MetroFramework.Controls.MetroTabControl mTabsSettings;
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
        private MetroFramework.Controls.MetroButton mBtnReset;
        private System.Windows.Forms.OpenFileDialog fileBrowser;
        public MetroFramework.Controls.MetroTabPage mTabInterface;
        private MetroFramework.Controls.MetroButton mBtnDeafOD;
        private MetroFramework.Controls.MetroTextBox mTxtDeafOD;
        private MetroFramework.Controls.MetroLabel mLblDeafOD;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private MetroFramework.Controls.MetroTabPage mTabOther;
        private MetroFramework.Controls.MetroToggle mToogleLog;
        private MetroFramework.Controls.MetroLabel mLblLog;
        private MetroFramework.Controls.MetroButton mBtnDownload;
    }
}