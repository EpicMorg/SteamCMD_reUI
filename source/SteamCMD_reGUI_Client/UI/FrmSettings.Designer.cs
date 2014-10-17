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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.mBtnSave = new MetroFramework.Controls.MetroButton();
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
            this.mBtnBrowse = new MetroFramework.Controls.MetroButton();
            this.mTxtSTEAMCMD = new MetroFramework.Controls.MetroTextBox();
            this.mLblSTEAMCMD = new MetroFramework.Controls.MetroLabel();
            this.mBtnReset = new MetroFramework.Controls.MetroButton();
            this.fileBrowser = new System.Windows.Forms.OpenFileDialog();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mTabsSettings.SuspendLayout();
            this.mTabInterface.SuspendLayout();
            this.mTabPaths.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // mBtnSave
            // 
            resources.ApplyResources(this.mBtnSave, "mBtnSave");
            this.mBtnSave.Name = "mBtnSave";
            this.mBtnSave.Style = MetroFramework.MetroColorStyle.Silver;
            this.mBtnSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mBtnSave.UseSelectable = true;
            this.mBtnSave.Click += new System.EventHandler(this.mBtnSave_Click);
            // 
            // mTabsSettings
            // 
            resources.ApplyResources(this.mTabsSettings, "mTabsSettings");
            this.mTabsSettings.Controls.Add(this.mTabInterface);
            this.mTabsSettings.Controls.Add(this.mTabPaths);
            this.mTabsSettings.Multiline = true;
            this.mTabsSettings.Name = "mTabsSettings";
            this.mTabsSettings.SelectedIndex = 0;
            this.mTabsSettings.Style = MetroFramework.MetroColorStyle.Silver;
            this.mTabsSettings.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            this.mTabInterface.Style = MetroFramework.MetroColorStyle.Silver;
            this.mTabInterface.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            this.mToogleShowSplash.Style = MetroFramework.MetroColorStyle.Silver;
            this.mToogleShowSplash.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mToogleShowSplash.UseSelectable = true;
            // 
            // mLblShowSplash
            // 
            resources.ApplyResources(this.mLblShowSplash, "mLblShowSplash");
            this.mLblShowSplash.Name = "mLblShowSplash";
            this.mLblShowSplash.Style = MetroFramework.MetroColorStyle.Silver;
            this.mLblShowSplash.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mLblAppStyle
            // 
            resources.ApplyResources(this.mLblAppStyle, "mLblAppStyle");
            this.mLblAppStyle.Name = "mLblAppStyle";
            this.mLblAppStyle.Style = MetroFramework.MetroColorStyle.Silver;
            this.mLblAppStyle.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mComboAppStyle
            // 
            this.mComboAppStyle.FormattingEnabled = true;
            resources.ApplyResources(this.mComboAppStyle, "mComboAppStyle");
            this.mComboAppStyle.Items.AddRange(new object[] {
            resources.GetString("mComboAppStyle.Items"),
            resources.GetString("mComboAppStyle.Items1")});
            this.mComboAppStyle.Name = "mComboAppStyle";
            this.mComboAppStyle.Style = MetroFramework.MetroColorStyle.Silver;
            this.mComboAppStyle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mComboAppStyle.UseSelectable = true;
            // 
            // mLblAppTheme
            // 
            resources.ApplyResources(this.mLblAppTheme, "mLblAppTheme");
            this.mLblAppTheme.Name = "mLblAppTheme";
            this.mLblAppTheme.Style = MetroFramework.MetroColorStyle.Silver;
            this.mLblAppTheme.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mComboAppTheme
            // 
            resources.ApplyResources(this.mComboAppTheme, "mComboAppTheme");
            this.mComboAppTheme.FormattingEnabled = true;
            this.mComboAppTheme.Items.AddRange(new object[] {
            resources.GetString("mComboAppTheme.Items"),
            resources.GetString("mComboAppTheme.Items1")});
            this.mComboAppTheme.Name = "mComboAppTheme";
            this.mComboAppTheme.Style = MetroFramework.MetroColorStyle.Silver;
            this.mComboAppTheme.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mComboAppTheme.UseSelectable = true;
            // 
            // mLblLang
            // 
            resources.ApplyResources(this.mLblLang, "mLblLang");
            this.mLblLang.Name = "mLblLang";
            this.mLblLang.Style = MetroFramework.MetroColorStyle.Silver;
            this.mLblLang.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mComboLang
            // 
            this.mComboLang.FormattingEnabled = true;
            resources.ApplyResources(this.mComboLang, "mComboLang");
            this.mComboLang.Name = "mComboLang";
            this.mComboLang.Style = MetroFramework.MetroColorStyle.Silver;
            this.mComboLang.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            this.mTabPaths.Style = MetroFramework.MetroColorStyle.Silver;
            this.mTabPaths.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mTabPaths.VerticalScrollbarBarColor = true;
            this.mTabPaths.VerticalScrollbarHighlightOnWheel = false;
            this.mTabPaths.VerticalScrollbarSize = 10;
            // 
            // mBtnBrowse
            // 
            resources.ApplyResources(this.mBtnBrowse, "mBtnBrowse");
            this.mBtnBrowse.Name = "mBtnBrowse";
            this.mBtnBrowse.Style = MetroFramework.MetroColorStyle.Silver;
            this.mBtnBrowse.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mBtnBrowse.UseSelectable = true;
            this.mBtnBrowse.Click += new System.EventHandler(this.mBtnBrowse_Click);
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
            this.mTxtSTEAMCMD.Style = MetroFramework.MetroColorStyle.Silver;
            this.mTxtSTEAMCMD.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mTxtSTEAMCMD.UseSelectable = true;
            // 
            // mLblSTEAMCMD
            // 
            resources.ApplyResources(this.mLblSTEAMCMD, "mLblSTEAMCMD");
            this.mLblSTEAMCMD.Name = "mLblSTEAMCMD";
            this.mLblSTEAMCMD.Style = MetroFramework.MetroColorStyle.Silver;
            this.mLblSTEAMCMD.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mBtnReset
            // 
            resources.ApplyResources(this.mBtnReset, "mBtnReset");
            this.mBtnReset.Name = "mBtnReset";
            this.mBtnReset.Style = MetroFramework.MetroColorStyle.Silver;
            this.mBtnReset.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mBtnReset.UseSelectable = true;
            this.mBtnReset.Click += new System.EventHandler(this.mBtnReset_Click);
            // 
            // fileBrowser
            // 
            resources.ApplyResources(this.fileBrowser, "fileBrowser");
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            this.metroStyleManager.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSettings_FormClosing);
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.mTabsSettings.ResumeLayout(false);
            this.mTabInterface.ResumeLayout(false);
            this.mTabInterface.PerformLayout();
            this.mTabPaths.ResumeLayout(false);
            this.mTabPaths.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
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
        private MetroFramework.Controls.MetroButton mBtnReset;
        private System.Windows.Forms.OpenFileDialog fileBrowser;
        public MetroFramework.Components.MetroStyleManager metroStyleManager;
    }
}