namespace SteamCMD_reGUI_Client.UI
{
    partial class FrmMain
    { 
        private System.ComponentModel.IContainer components = null;
 
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.mTabsMain = new MetroFramework.Controls.MetroTabControl();
            this.mTabMain = new MetroFramework.Controls.MetroTabPage();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.mToggleValidate = new MetroFramework.Controls.MetroToggle();
            this.mTileProcess = new MetroFramework.Controls.MetroTile();
            this.mLblValidate = new MetroFramework.Controls.MetroLabel();
            this.mLblServer = new MetroFramework.Controls.MetroLabel();
            this.mPanelLogin = new MetroFramework.Controls.MetroPanel();
            this.mTxtPassword = new MetroFramework.Controls.MetroTextBox();
            this.mTxtLogin = new MetroFramework.Controls.MetroTextBox();
            this.mLblPassword = new MetroFramework.Controls.MetroLabel();
            this.mLblLogin = new MetroFramework.Controls.MetroLabel();
            this.mComboServers = new MetroFramework.Controls.MetroComboBox();
            this.mTileAbout = new MetroFramework.Controls.MetroTile();
            this.mTileSettings = new MetroFramework.Controls.MetroTile();
            this.mTileConsole = new MetroFramework.Controls.MetroTile();
            this.mTabConsole = new MetroFramework.Controls.MetroTabPage();
            this.mTxtConLog = new MetroFramework.Controls.MetroTextBox();
            this.mTabAbout = new MetroFramework.Controls.MetroTabPage();
            this.mLnkMF = new MetroFramework.Controls.MetroLink();
            this.mLnkMIC = new MetroFramework.Controls.MetroLink();
            this.mLnkRG = new MetroFramework.Controls.MetroLink();
            this.mLblWrng = new MetroFramework.Controls.MetroLabel();
            this.mLblTM = new MetroFramework.Controls.MetroLabel();
            this.mLblAltGUI = new MetroFramework.Controls.MetroLabel();
            this.mLblProdVer = new MetroFramework.Controls.MetroLabel();
            this.mLblKASTHACK = new MetroFramework.Controls.MetroLabel();
            this.mLblSTAM = new MetroFramework.Controls.MetroLabel();
            this.mLblProdName = new MetroFramework.Controls.MetroLabel();
            this.picAbout = new System.Windows.Forms.PictureBox();
            this.picMF = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.mTabsMain.SuspendLayout();
            this.mTabMain.SuspendLayout();
            this.mPanelLogin.SuspendLayout();
            this.mTabConsole.SuspendLayout();
            this.mTabAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // mTabsMain
            // 
            this.mTabsMain.Controls.Add(this.mTabMain);
            this.mTabsMain.Controls.Add(this.mTabConsole);
            this.mTabsMain.Controls.Add(this.mTabAbout);
            resources.ApplyResources(this.mTabsMain, "mTabsMain");
            this.mTabsMain.Name = "mTabsMain";
            this.mTabsMain.SelectedIndex = 0;
            this.mTabsMain.UseSelectable = true;
            // 
            // mTabMain
            // 
            this.mTabMain.Controls.Add(this.metroProgressBar1);
            this.mTabMain.Controls.Add(this.mToggleValidate);
            this.mTabMain.Controls.Add(this.mTileProcess);
            this.mTabMain.Controls.Add(this.mLblValidate);
            this.mTabMain.Controls.Add(this.mLblServer);
            this.mTabMain.Controls.Add(this.mPanelLogin);
            this.mTabMain.Controls.Add(this.mComboServers);
            this.mTabMain.Controls.Add(this.mTileAbout);
            this.mTabMain.Controls.Add(this.mTileSettings);
            this.mTabMain.Controls.Add(this.mTileConsole);
            this.mTabMain.HorizontalScrollbarBarColor = true;
            this.mTabMain.HorizontalScrollbarHighlightOnWheel = false;
            this.mTabMain.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.mTabMain, "mTabMain");
            this.mTabMain.Name = "mTabMain";
            this.mTabMain.VerticalScrollbarBarColor = true;
            this.mTabMain.VerticalScrollbarHighlightOnWheel = false;
            this.mTabMain.VerticalScrollbarSize = 10;
            this.mTabMain.Click += new System.EventHandler(this.mTabMain_Click);
            // 
            // metroProgressBar1
            // 
            resources.ApplyResources(this.metroProgressBar1, "metroProgressBar1");
            this.metroProgressBar1.Name = "metroProgressBar1";
            // 
            // mToggleValidate
            // 
            resources.ApplyResources(this.mToggleValidate, "mToggleValidate");
            this.mToggleValidate.Checked = true;
            this.mToggleValidate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mToggleValidate.Name = "mToggleValidate";
            this.mToggleValidate.UseSelectable = true;
            // 
            // mTileProcess
            // 
            this.mTileProcess.ActiveControl = null;
            resources.ApplyResources(this.mTileProcess, "mTileProcess");
            this.mTileProcess.Name = "mTileProcess";
            this.mTileProcess.TileImage = global::SteamCMD_reGUI_Client.Properties.Resources.start_dark;
            this.mTileProcess.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mTileProcess.UseSelectable = true;
            this.mTileProcess.UseTileImage = true;
            this.mTileProcess.Click += new System.EventHandler(this.mTileProcess_Click);
            // 
            // mLblValidate
            // 
            resources.ApplyResources(this.mLblValidate, "mLblValidate");
            this.mLblValidate.Name = "mLblValidate";
            // 
            // mLblServer
            // 
            resources.ApplyResources(this.mLblServer, "mLblServer");
            this.mLblServer.Name = "mLblServer";
            // 
            // mPanelLogin
            // 
            resources.ApplyResources(this.mPanelLogin, "mPanelLogin");
            this.mPanelLogin.Controls.Add(this.mTxtPassword);
            this.mPanelLogin.Controls.Add(this.mTxtLogin);
            this.mPanelLogin.Controls.Add(this.mLblPassword);
            this.mPanelLogin.Controls.Add(this.mLblLogin);
            this.mPanelLogin.HorizontalScrollbarBarColor = true;
            this.mPanelLogin.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanelLogin.HorizontalScrollbarSize = 10;
            this.mPanelLogin.Name = "mPanelLogin";
            this.mPanelLogin.VerticalScrollbarBarColor = true;
            this.mPanelLogin.VerticalScrollbarHighlightOnWheel = false;
            this.mPanelLogin.VerticalScrollbarSize = 10;
            // 
            // mTxtPassword
            // 
            resources.ApplyResources(this.mTxtPassword, "mTxtPassword");
            this.mTxtPassword.Lines = new string[0];
            this.mTxtPassword.MaxLength = 32767;
            this.mTxtPassword.Name = "mTxtPassword";
            this.mTxtPassword.PasswordChar = '*';
            this.mTxtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtPassword.SelectedText = "";
            this.mTxtPassword.UseSelectable = true;
            // 
            // mTxtLogin
            // 
            resources.ApplyResources(this.mTxtLogin, "mTxtLogin");
            this.mTxtLogin.Lines = new string[0];
            this.mTxtLogin.MaxLength = 32767;
            this.mTxtLogin.Name = "mTxtLogin";
            this.mTxtLogin.PasswordChar = '\0';
            this.mTxtLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtLogin.SelectedText = "";
            this.mTxtLogin.UseSelectable = true;
            // 
            // mLblPassword
            // 
            resources.ApplyResources(this.mLblPassword, "mLblPassword");
            this.mLblPassword.Name = "mLblPassword";
            // 
            // mLblLogin
            // 
            resources.ApplyResources(this.mLblLogin, "mLblLogin");
            this.mLblLogin.Name = "mLblLogin";
            // 
            // mComboServers
            // 
            resources.ApplyResources(this.mComboServers, "mComboServers");
            this.mComboServers.FormattingEnabled = true;
            this.mComboServers.Name = "mComboServers";
            this.mComboServers.UseSelectable = true;
            // 
            // mTileAbout
            // 
            this.mTileAbout.ActiveControl = null;
            resources.ApplyResources(this.mTileAbout, "mTileAbout");
            this.mTileAbout.Name = "mTileAbout";
            this.mTileAbout.TileImage = global::SteamCMD_reGUI_Client.Properties.Resources.nyan_dark;
            this.mTileAbout.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mTileAbout.UseSelectable = true;
            this.mTileAbout.UseTileImage = true;
            this.mTileAbout.Click += new System.EventHandler(this.mTileAbout_Click);
            // 
            // mTileSettings
            // 
            this.mTileSettings.ActiveControl = null;
            resources.ApplyResources(this.mTileSettings, "mTileSettings");
            this.mTileSettings.Name = "mTileSettings";
            this.mTileSettings.TileImage = global::SteamCMD_reGUI_Client.Properties.Resources.setings_dark;
            this.mTileSettings.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mTileSettings.UseSelectable = true;
            this.mTileSettings.UseTileImage = true;
            this.mTileSettings.Click += new System.EventHandler(this.mTileSettings_Click);
            // 
            // mTileConsole
            // 
            this.mTileConsole.ActiveControl = null;
            resources.ApplyResources(this.mTileConsole, "mTileConsole");
            this.mTileConsole.Name = "mTileConsole";
            this.mTileConsole.TileImage = global::SteamCMD_reGUI_Client.Properties.Resources.console_dark;
            this.mTileConsole.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mTileConsole.UseSelectable = true;
            this.mTileConsole.UseTileImage = true;
            this.mTileConsole.Click += new System.EventHandler(this.mTileConsole_Click);
            // 
            // mTabConsole
            // 
            this.mTabConsole.Controls.Add(this.mTxtConLog);
            this.mTabConsole.HorizontalScrollbarBarColor = true;
            this.mTabConsole.HorizontalScrollbarHighlightOnWheel = false;
            this.mTabConsole.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.mTabConsole, "mTabConsole");
            this.mTabConsole.Name = "mTabConsole";
            this.mTabConsole.VerticalScrollbarBarColor = true;
            this.mTabConsole.VerticalScrollbarHighlightOnWheel = false;
            this.mTabConsole.VerticalScrollbarSize = 10;
            // 
            // mTxtConLog
            // 
            resources.ApplyResources(this.mTxtConLog, "mTxtConLog");
            this.mTxtConLog.Lines = new string[0];
            this.mTxtConLog.MaxLength = 32767;
            this.mTxtConLog.Multiline = true;
            this.mTxtConLog.Name = "mTxtConLog";
            this.mTxtConLog.PasswordChar = '\0';
            this.mTxtConLog.ReadOnly = true;
            this.mTxtConLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.mTxtConLog.SelectedText = "";
            this.mTxtConLog.UseSelectable = true;
            // 
            // mTabAbout
            // 
            this.mTabAbout.Controls.Add(this.mLnkMF);
            this.mTabAbout.Controls.Add(this.mLnkMIC);
            this.mTabAbout.Controls.Add(this.mLnkRG);
            this.mTabAbout.Controls.Add(this.mLblWrng);
            this.mTabAbout.Controls.Add(this.mLblTM);
            this.mTabAbout.Controls.Add(this.mLblAltGUI);
            this.mTabAbout.Controls.Add(this.mLblProdVer);
            this.mTabAbout.Controls.Add(this.mLblKASTHACK);
            this.mTabAbout.Controls.Add(this.mLblSTAM);
            this.mTabAbout.Controls.Add(this.mLblProdName);
            this.mTabAbout.Controls.Add(this.picAbout);
            this.mTabAbout.Controls.Add(this.picMF);
            this.mTabAbout.Controls.Add(this.picLogo);
            this.mTabAbout.HorizontalScrollbarBarColor = true;
            this.mTabAbout.HorizontalScrollbarHighlightOnWheel = false;
            this.mTabAbout.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.mTabAbout, "mTabAbout");
            this.mTabAbout.Name = "mTabAbout";
            this.mTabAbout.VerticalScrollbarBarColor = true;
            this.mTabAbout.VerticalScrollbarHighlightOnWheel = false;
            this.mTabAbout.VerticalScrollbarSize = 10;
            // 
            // mLnkMF
            // 
            resources.ApplyResources(this.mLnkMF, "mLnkMF");
            this.mLnkMF.Name = "mLnkMF";
            this.mLnkMF.UseSelectable = true;
            this.mLnkMF.Click += new System.EventHandler(this.mLnkMF_Click);
            // 
            // mLnkMIC
            // 
            resources.ApplyResources(this.mLnkMIC, "mLnkMIC");
            this.mLnkMIC.Name = "mLnkMIC";
            this.mLnkMIC.UseSelectable = true;
            this.mLnkMIC.Click += new System.EventHandler(this.mLnkMIC_Click);
            // 
            // mLnkRG
            // 
            resources.ApplyResources(this.mLnkRG, "mLnkRG");
            this.mLnkRG.Name = "mLnkRG";
            this.mLnkRG.UseSelectable = true;
            this.mLnkRG.Click += new System.EventHandler(this.mLnkRG_Click);
            // 
            // mLblWrng
            // 
            resources.ApplyResources(this.mLblWrng, "mLblWrng");
            this.mLblWrng.Name = "mLblWrng";
            this.mLblWrng.WrapToLine = true;
            // 
            // mLblTM
            // 
            resources.ApplyResources(this.mLblTM, "mLblTM");
            this.mLblTM.Name = "mLblTM";
            this.mLblTM.WrapToLine = true;
            // 
            // mLblAltGUI
            // 
            resources.ApplyResources(this.mLblAltGUI, "mLblAltGUI");
            this.mLblAltGUI.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mLblAltGUI.Name = "mLblAltGUI";
            // 
            // mLblProdVer
            // 
            resources.ApplyResources(this.mLblProdVer, "mLblProdVer");
            this.mLblProdVer.BackColor = System.Drawing.Color.Transparent;
            this.mLblProdVer.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mLblProdVer.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mLblProdVer.Name = "mLblProdVer";
            // 
            // mLblKASTHACK
            // 
            resources.ApplyResources(this.mLblKASTHACK, "mLblKASTHACK");
            this.mLblKASTHACK.BackColor = System.Drawing.Color.Transparent;
            this.mLblKASTHACK.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mLblKASTHACK.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mLblKASTHACK.Name = "mLblKASTHACK";
            // 
            // mLblSTAM
            // 
            resources.ApplyResources(this.mLblSTAM, "mLblSTAM");
            this.mLblSTAM.BackColor = System.Drawing.Color.Transparent;
            this.mLblSTAM.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mLblSTAM.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mLblSTAM.Name = "mLblSTAM";
            // 
            // mLblProdName
            // 
            resources.ApplyResources(this.mLblProdName, "mLblProdName");
            this.mLblProdName.BackColor = System.Drawing.Color.Transparent;
            this.mLblProdName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mLblProdName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mLblProdName.Name = "mLblProdName";
            // 
            // picAbout
            // 
            this.picAbout.BackColor = System.Drawing.Color.Transparent;
            this.picAbout.Image = global::SteamCMD_reGUI_Client.Properties.Resources.nyan_dark;
            resources.ApplyResources(this.picAbout, "picAbout");
            this.picAbout.Name = "picAbout";
            this.picAbout.TabStop = false;
            // 
            // picMF
            // 
            this.picMF.BackColor = System.Drawing.Color.Transparent;
            this.picMF.Image = global::SteamCMD_reGUI_Client.Properties.Resources.github_octocat_dark;
            resources.ApplyResources(this.picMF, "picMF");
            this.picMF.Name = "picMF";
            this.picMF.TabStop = false;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::SteamCMD_reGUI_Client.Properties.Resources.steam_dark_128;
            resources.ApplyResources(this.picLogo, "picLogo");
            this.picLogo.Name = "picLogo";
            this.picLogo.TabStop = false;
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImagePadding = new System.Windows.Forms.Padding(210, 10, 0, 0);
            this.BackLocation = MetroFramework.Forms.BackLocation.TopRight;
            this.Controls.Add(this.mTabsMain);
            this.Name = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.mTabsMain.ResumeLayout(false);
            this.mTabMain.ResumeLayout(false);
            this.mTabMain.PerformLayout();
            this.mPanelLogin.ResumeLayout(false);
            this.mPanelLogin.PerformLayout();
            this.mTabConsole.ResumeLayout(false);
            this.mTabAbout.ResumeLayout(false);
            this.mTabAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mTabsMain;
        private MetroFramework.Controls.MetroTabPage mTabMain;
        private MetroFramework.Controls.MetroTabPage mTabConsole;
        private MetroFramework.Controls.MetroTabPage mTabAbout;
        private MetroFramework.Controls.MetroTextBox mTxtConLog;
        private System.Windows.Forms.PictureBox picLogo;
        private MetroFramework.Controls.MetroLabel mLblProdName;
        private MetroFramework.Controls.MetroLabel mLblProdVer;
        private MetroFramework.Controls.MetroLabel mLblAltGUI;
        private MetroFramework.Controls.MetroLabel mLblTM;
        private MetroFramework.Controls.MetroLabel mLblWrng;
        private System.Windows.Forms.PictureBox picMF;
        private MetroFramework.Controls.MetroLink mLnkRG;
        private MetroFramework.Controls.MetroLink mLnkMF;
        private System.Windows.Forms.PictureBox picAbout;
        private MetroFramework.Controls.MetroLink mLnkMIC;
        private MetroFramework.Controls.MetroLabel mLblKASTHACK;
        private MetroFramework.Controls.MetroLabel mLblSTAM;
        private MetroFramework.Controls.MetroTile mTileAbout;
        private MetroFramework.Controls.MetroTile mTileSettings;
        private MetroFramework.Controls.MetroTile mTileConsole;
        private MetroFramework.Controls.MetroComboBox mComboServers;
        private MetroFramework.Controls.MetroLabel mLblServer;
        private MetroFramework.Controls.MetroPanel mPanelLogin;
        private MetroFramework.Controls.MetroLabel mLblLogin;
        private MetroFramework.Controls.MetroTextBox mTxtPassword;
        private MetroFramework.Controls.MetroTextBox mTxtLogin;
        private MetroFramework.Controls.MetroLabel mLblPassword;
        private MetroFramework.Controls.MetroTile mTileProcess;
        private MetroFramework.Controls.MetroLabel mLblValidate;
        private MetroFramework.Controls.MetroToggle mToggleValidate;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;




    }
}

