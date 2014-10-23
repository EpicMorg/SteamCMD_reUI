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
            this.button1 = new System.Windows.Forms.Button();
            this.mTabsMain = new MetroFramework.Controls.MetroTabControl();
            this.mTabMain = new MetroFramework.Controls.MetroTabPage();
            this.button3 = new System.Windows.Forms.Button();
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
            this.mTabConsole.SuspendLayout();
            this.mTabAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mTabsMain
            // 
            resources.ApplyResources(this.mTabsMain, "mTabsMain");
            this.mTabsMain.Controls.Add(this.mTabMain);
            this.mTabsMain.Controls.Add(this.mTabConsole);
            this.mTabsMain.Controls.Add(this.mTabAbout);
            this.mTabsMain.Name = "mTabsMain";
            this.mTabsMain.SelectedIndex = 2;
            this.mTabsMain.UseSelectable = true;
            // 
            // mTabMain
            // 
            resources.ApplyResources(this.mTabMain, "mTabMain");
            this.mTabMain.Controls.Add(this.button3);
            this.mTabMain.Controls.Add(this.button1);
            this.mTabMain.HorizontalScrollbarBarColor = true;
            this.mTabMain.HorizontalScrollbarHighlightOnWheel = false;
            this.mTabMain.HorizontalScrollbarSize = 10;
            this.mTabMain.Name = "mTabMain";
            this.mTabMain.VerticalScrollbarBarColor = true;
            this.mTabMain.VerticalScrollbarHighlightOnWheel = false;
            this.mTabMain.VerticalScrollbarSize = 10;
            this.mTabMain.Click += new System.EventHandler(this.mTabMain_Click);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // mTabConsole
            // 
            resources.ApplyResources(this.mTabConsole, "mTabConsole");
            this.mTabConsole.Controls.Add(this.mTxtConLog);
            this.mTabConsole.HorizontalScrollbarBarColor = true;
            this.mTabConsole.HorizontalScrollbarHighlightOnWheel = false;
            this.mTabConsole.HorizontalScrollbarSize = 10;
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
            resources.ApplyResources(this.mTabAbout, "mTabAbout");
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
            resources.ApplyResources(this.picAbout, "picAbout");
            this.picAbout.BackColor = System.Drawing.Color.Transparent;
            this.picAbout.Image = global::SteamCMD_reGUI_Client.Properties.Resources.nyan_dark;
            this.picAbout.Name = "picAbout";
            this.picAbout.TabStop = false;
            // 
            // picMF
            // 
            resources.ApplyResources(this.picMF, "picMF");
            this.picMF.BackColor = System.Drawing.Color.Transparent;
            this.picMF.Image = global::SteamCMD_reGUI_Client.Properties.Resources.github_octocat_dark;
            this.picMF.Name = "picMF";
            this.picMF.TabStop = false;
            // 
            // picLogo
            // 
            resources.ApplyResources(this.picLogo, "picLogo");
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::SteamCMD_reGUI_Client.Properties.Resources.steam_dark_128;
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
            this.mTabConsole.ResumeLayout(false);
            this.mTabAbout.ResumeLayout(false);
            this.mTabAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroTabControl mTabsMain;
        private MetroFramework.Controls.MetroTabPage mTabMain; 
        private System.Windows.Forms.Button button3;
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




    }
}

