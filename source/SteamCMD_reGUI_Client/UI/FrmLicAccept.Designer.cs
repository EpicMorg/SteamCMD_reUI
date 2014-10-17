namespace SteamCMD_reGUI_Client.UI
{
    partial class FrmLicAccept
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLicAccept));
            this.StyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mPanelMain = new MetroFramework.Controls.MetroPanel();
            this.mTabsControl = new MetroFramework.Controls.MetroTabControl();
            this.mTabpLic1 = new MetroFramework.Controls.MetroTabPage();
            this.mBtnPrevNull = new MetroFramework.Controls.MetroButton();
            this.mBtnAccept = new MetroFramework.Controls.MetroButton();
            this.mBtnDecline = new MetroFramework.Controls.MetroButton();
            this.rTxtLic1 = new System.Windows.Forms.RichTextBox();
            this.mTabpLic2 = new MetroFramework.Controls.MetroTabPage();
            this.mBtnPrev = new MetroFramework.Controls.MetroButton();
            this.mBtnAcceptFinal = new MetroFramework.Controls.MetroButton();
            this.mBtnDecline2 = new MetroFramework.Controls.MetroButton();
            this.rTxtLic2 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager)).BeginInit();
            this.mPanelMain.SuspendLayout();
            this.mTabsControl.SuspendLayout();
            this.mTabpLic1.SuspendLayout();
            this.mTabpLic2.SuspendLayout();
            this.SuspendLayout();
            // 
            // StyleManager
            // 
            this.StyleManager.Owner = null;
            this.StyleManager.Style = MetroFramework.MetroColorStyle.Silver;
            this.StyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mPanelMain
            // 
            resources.ApplyResources(this.mPanelMain, "mPanelMain");
            this.mPanelMain.Controls.Add(this.mTabsControl);
            this.mPanelMain.HorizontalScrollbarBarColor = true;
            this.mPanelMain.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanelMain.HorizontalScrollbarSize = 10;
            this.mPanelMain.Name = "mPanelMain";
            this.mPanelMain.Style = MetroFramework.MetroColorStyle.Silver;
            this.mPanelMain.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mPanelMain.VerticalScrollbarBarColor = true;
            this.mPanelMain.VerticalScrollbarHighlightOnWheel = false;
            this.mPanelMain.VerticalScrollbarSize = 10;
            // 
            // mTabsControl
            // 
            resources.ApplyResources(this.mTabsControl, "mTabsControl");
            this.mTabsControl.Controls.Add(this.mTabpLic1);
            this.mTabsControl.Controls.Add(this.mTabpLic2);
            this.mTabsControl.Name = "mTabsControl";
            this.mTabsControl.SelectedIndex = 1;
            this.mTabsControl.Style = MetroFramework.MetroColorStyle.Silver;
            this.mTabsControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mTabsControl.UseSelectable = true;
            // 
            // mTabpLic1
            // 
            resources.ApplyResources(this.mTabpLic1, "mTabpLic1");
            this.mTabpLic1.Controls.Add(this.mBtnPrevNull);
            this.mTabpLic1.Controls.Add(this.mBtnAccept);
            this.mTabpLic1.Controls.Add(this.mBtnDecline);
            this.mTabpLic1.Controls.Add(this.rTxtLic1);
            this.mTabpLic1.HorizontalScrollbarBarColor = true;
            this.mTabpLic1.HorizontalScrollbarHighlightOnWheel = false;
            this.mTabpLic1.HorizontalScrollbarSize = 10;
            this.mTabpLic1.Name = "mTabpLic1";
            this.mTabpLic1.Style = MetroFramework.MetroColorStyle.Silver;
            this.mTabpLic1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mTabpLic1.VerticalScrollbarBarColor = true;
            this.mTabpLic1.VerticalScrollbarHighlightOnWheel = false;
            this.mTabpLic1.VerticalScrollbarSize = 10;
            // 
            // mBtnPrevNull
            // 
            resources.ApplyResources(this.mBtnPrevNull, "mBtnPrevNull");
            this.mBtnPrevNull.Name = "mBtnPrevNull";
            this.mBtnPrevNull.Style = MetroFramework.MetroColorStyle.Silver;
            this.mBtnPrevNull.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mBtnPrevNull.UseSelectable = true;
            // 
            // mBtnAccept
            // 
            resources.ApplyResources(this.mBtnAccept, "mBtnAccept");
            this.mBtnAccept.Name = "mBtnAccept";
            this.mBtnAccept.Style = MetroFramework.MetroColorStyle.Silver;
            this.mBtnAccept.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mBtnAccept.UseSelectable = true;
            this.mBtnAccept.Click += new System.EventHandler(this.mBtnAccept_Click);
            // 
            // mBtnDecline
            // 
            resources.ApplyResources(this.mBtnDecline, "mBtnDecline");
            this.mBtnDecline.Name = "mBtnDecline";
            this.mBtnDecline.Style = MetroFramework.MetroColorStyle.Silver;
            this.mBtnDecline.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mBtnDecline.UseSelectable = true;
            this.mBtnDecline.Click += new System.EventHandler(this.mBtnDecline_Click);
            // 
            // rTxtLic1
            // 
            resources.ApplyResources(this.rTxtLic1, "rTxtLic1");
            this.rTxtLic1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.rTxtLic1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTxtLic1.Cursor = System.Windows.Forms.Cursors.Default;
            this.rTxtLic1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.rTxtLic1.Name = "rTxtLic1";
            this.rTxtLic1.ReadOnly = true;
            // 
            // mTabpLic2
            // 
            resources.ApplyResources(this.mTabpLic2, "mTabpLic2");
            this.mTabpLic2.Controls.Add(this.mBtnPrev);
            this.mTabpLic2.Controls.Add(this.mBtnAcceptFinal);
            this.mTabpLic2.Controls.Add(this.mBtnDecline2);
            this.mTabpLic2.Controls.Add(this.rTxtLic2);
            this.mTabpLic2.HorizontalScrollbarBarColor = true;
            this.mTabpLic2.HorizontalScrollbarHighlightOnWheel = false;
            this.mTabpLic2.HorizontalScrollbarSize = 10;
            this.mTabpLic2.Name = "mTabpLic2";
            this.mTabpLic2.Style = MetroFramework.MetroColorStyle.Silver;
            this.mTabpLic2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mTabpLic2.VerticalScrollbarBarColor = true;
            this.mTabpLic2.VerticalScrollbarHighlightOnWheel = false;
            this.mTabpLic2.VerticalScrollbarSize = 10;
            // 
            // mBtnPrev
            // 
            resources.ApplyResources(this.mBtnPrev, "mBtnPrev");
            this.mBtnPrev.Name = "mBtnPrev";
            this.mBtnPrev.Style = MetroFramework.MetroColorStyle.Green;
            this.mBtnPrev.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mBtnPrev.UseSelectable = true;
            this.mBtnPrev.Click += new System.EventHandler(this.mBtnPrev_Click);
            // 
            // mBtnAcceptFinal
            // 
            resources.ApplyResources(this.mBtnAcceptFinal, "mBtnAcceptFinal");
            this.mBtnAcceptFinal.Name = "mBtnAcceptFinal";
            this.mBtnAcceptFinal.Style = MetroFramework.MetroColorStyle.Green;
            this.mBtnAcceptFinal.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mBtnAcceptFinal.UseSelectable = true;
            this.mBtnAcceptFinal.Click += new System.EventHandler(this.mBtnAcceptFinal_Click);
            // 
            // mBtnDecline2
            // 
            resources.ApplyResources(this.mBtnDecline2, "mBtnDecline2");
            this.mBtnDecline2.Name = "mBtnDecline2";
            this.mBtnDecline2.Style = MetroFramework.MetroColorStyle.Green;
            this.mBtnDecline2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mBtnDecline2.UseSelectable = true;
            this.mBtnDecline2.Click += new System.EventHandler(this.mBtnDecline2_Click);
            // 
            // rTxtLic2
            // 
            resources.ApplyResources(this.rTxtLic2, "rTxtLic2");
            this.rTxtLic2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.rTxtLic2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTxtLic2.Cursor = System.Windows.Forms.Cursors.Default;
            this.rTxtLic2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.rTxtLic2.Name = "rTxtLic2";
            this.rTxtLic2.ReadOnly = true;
            // 
            // FrmLicAccept
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mPanelMain);
            this.MaximizeBox = false;
            this.Name = "FrmLicAccept";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.FrmLicAccept_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager)).EndInit();
            this.mPanelMain.ResumeLayout(false);
            this.mTabsControl.ResumeLayout(false);
            this.mTabpLic1.ResumeLayout(false);
            this.mTabpLic2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager StyleManager;
        private MetroFramework.Controls.MetroPanel mPanelMain;
        private MetroFramework.Controls.MetroButton mBtnAccept;
        private MetroFramework.Controls.MetroButton mBtnDecline;
        private MetroFramework.Controls.MetroTabControl mTabsControl;
        private MetroFramework.Controls.MetroTabPage mTabpLic1;
        private MetroFramework.Controls.MetroTabPage mTabpLic2;
        private System.Windows.Forms.RichTextBox rTxtLic1;
        private System.Windows.Forms.RichTextBox rTxtLic2;
        private MetroFramework.Controls.MetroButton mBtnPrevNull;
        private MetroFramework.Controls.MetroButton mBtnPrev;
        private MetroFramework.Controls.MetroButton mBtnAcceptFinal;
        private MetroFramework.Controls.MetroButton mBtnDecline2;

    }
}