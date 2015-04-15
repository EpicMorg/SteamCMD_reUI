namespace SteamCMD_reGUI_Client.UI
{
	partial class FrmWizStep1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWizStep1));
			this.mTabsControl = new MetroFramework.Controls.MetroTabControl();
			this.mTabpS1 = new MetroFramework.Controls.MetroTabPage();
			this.mLblInfo1 = new MetroFramework.Controls.MetroLabel();
			this.mBtnIstallSteam = new MetroFramework.Controls.MetroButton();
			this.mBtnIHaveSteam = new MetroFramework.Controls.MetroButton();
			this.mTabpS2 = new MetroFramework.Controls.MetroTabPage();
			this.mBtnBack = new MetroFramework.Controls.MetroButton();
			this.mBtnNext = new MetroFramework.Controls.MetroButton();
			this.mBtnBrowse = new MetroFramework.Controls.MetroButton();
			this.mTxtSTEAMCMD = new MetroFramework.Controls.MetroTextBox();
			this.mLblSTEAMCMD = new MetroFramework.Controls.MetroLabel();
			this.mTabsControl.SuspendLayout();
			this.mTabpS1.SuspendLayout();
			this.mTabpS2.SuspendLayout();
			this.SuspendLayout();
			// 
			// mTabsControl
			// 
			this.mTabsControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mTabsControl.Controls.Add(this.mTabpS1);
			this.mTabsControl.Controls.Add(this.mTabpS2);
			this.mTabsControl.Location = new System.Drawing.Point(23, 63);
			this.mTabsControl.Name = "mTabsControl";
			this.mTabsControl.SelectedIndex = 0;
			this.mTabsControl.Size = new System.Drawing.Size(426, 236);
			this.mTabsControl.TabIndex = 8;
			this.mTabsControl.UseSelectable = true;
			// 
			// mTabpS1
			// 
			this.mTabpS1.Controls.Add(this.mLblInfo1);
			this.mTabpS1.Controls.Add(this.mBtnIstallSteam);
			this.mTabpS1.Controls.Add(this.mBtnIHaveSteam);
			this.mTabpS1.HorizontalScrollbarBarColor = true;
			this.mTabpS1.HorizontalScrollbarHighlightOnWheel = false;
			this.mTabpS1.HorizontalScrollbarSize = 10;
			this.mTabpS1.Location = new System.Drawing.Point(4, 38);
			this.mTabpS1.Name = "mTabpS1";
			this.mTabpS1.Size = new System.Drawing.Size(418, 194);
			this.mTabpS1.TabIndex = 0;
			this.mTabpS1.VerticalScrollbarBarColor = true;
			this.mTabpS1.VerticalScrollbarHighlightOnWheel = false;
			this.mTabpS1.VerticalScrollbarSize = 10;
			// 
			// mLblInfo1
			// 
			this.mLblInfo1.Location = new System.Drawing.Point(3, 10);
			this.mLblInfo1.Name = "mLblInfo1";
			this.mLblInfo1.Size = new System.Drawing.Size(412, 90);
			this.mLblInfo1.TabIndex = 3;
			this.mLblInfo1.Text = resources.GetString("mLblInfo1.Text");
			this.mLblInfo1.WrapToLine = true;
			// 
			// mBtnIstallSteam
			// 
			this.mBtnIstallSteam.Location = new System.Drawing.Point(215, 122);
			this.mBtnIstallSteam.Name = "mBtnIstallSteam";
			this.mBtnIstallSteam.Size = new System.Drawing.Size(200, 45);
			this.mBtnIstallSteam.TabIndex = 2;
			this.mBtnIstallSteam.Text = "Install SteamCMD";
			this.mBtnIstallSteam.UseSelectable = true;
			this.mBtnIstallSteam.Click += new System.EventHandler(this.mBtnIstallSteam_Click);
			// 
			// mBtnIHaveSteam
			// 
			this.mBtnIHaveSteam.Location = new System.Drawing.Point(3, 122);
			this.mBtnIHaveSteam.Name = "mBtnIHaveSteam";
			this.mBtnIHaveSteam.Size = new System.Drawing.Size(200, 45);
			this.mBtnIHaveSteam.TabIndex = 2;
			this.mBtnIHaveSteam.Text = "I have already installed SteamCMD";
			this.mBtnIHaveSteam.UseSelectable = true;
			this.mBtnIHaveSteam.Click += new System.EventHandler(this.mBtnIHaveSteam_Click);
			// 
			// mTabpS2
			// 
			this.mTabpS2.Controls.Add(this.mBtnBack);
			this.mTabpS2.Controls.Add(this.mBtnNext);
			this.mTabpS2.Controls.Add(this.mBtnBrowse);
			this.mTabpS2.Controls.Add(this.mTxtSTEAMCMD);
			this.mTabpS2.Controls.Add(this.mLblSTEAMCMD);
			this.mTabpS2.HorizontalScrollbarBarColor = true;
			this.mTabpS2.HorizontalScrollbarHighlightOnWheel = false;
			this.mTabpS2.HorizontalScrollbarSize = 10;
			this.mTabpS2.Location = new System.Drawing.Point(4, 38);
			this.mTabpS2.Name = "mTabpS2";
			this.mTabpS2.Size = new System.Drawing.Size(418, 194);
			this.mTabpS2.TabIndex = 1;
			this.mTabpS2.VerticalScrollbarBarColor = true;
			this.mTabpS2.VerticalScrollbarHighlightOnWheel = false;
			this.mTabpS2.VerticalScrollbarSize = 10;
			// 
			// mBtnBack
			// 
			this.mBtnBack.Location = new System.Drawing.Point(3, 168);
			this.mBtnBack.Name = "mBtnBack";
			this.mBtnBack.Size = new System.Drawing.Size(75, 23);
			this.mBtnBack.TabIndex = 10;
			this.mBtnBack.Text = "Back";
			this.mBtnBack.UseSelectable = true;
			this.mBtnBack.Click += new System.EventHandler(this.mBtnBack_Click);
			// 
			// mBtnNext
			// 
			this.mBtnNext.Location = new System.Drawing.Point(340, 168);
			this.mBtnNext.Name = "mBtnNext";
			this.mBtnNext.Size = new System.Drawing.Size(75, 23);
			this.mBtnNext.TabIndex = 10;
			this.mBtnNext.Text = "Next";
			this.mBtnNext.UseSelectable = true;
			// 
			// mBtnBrowse
			// 
			this.mBtnBrowse.Location = new System.Drawing.Point(340, 32);
			this.mBtnBrowse.Name = "mBtnBrowse";
			this.mBtnBrowse.Size = new System.Drawing.Size(75, 23);
			this.mBtnBrowse.TabIndex = 10;
			this.mBtnBrowse.Text = "Browse";
			this.mBtnBrowse.UseSelectable = true;
			// 
			// mTxtSTEAMCMD
			// 
			this.mTxtSTEAMCMD.Lines = new string[0];
			this.mTxtSTEAMCMD.Location = new System.Drawing.Point(3, 32);
			this.mTxtSTEAMCMD.MaxLength = 32767;
			this.mTxtSTEAMCMD.Name = "mTxtSTEAMCMD";
			this.mTxtSTEAMCMD.PasswordChar = '\0';
			this.mTxtSTEAMCMD.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mTxtSTEAMCMD.SelectedText = "";
			this.mTxtSTEAMCMD.Size = new System.Drawing.Size(331, 23);
			this.mTxtSTEAMCMD.TabIndex = 9;
			this.mTxtSTEAMCMD.UseSelectable = true;
			// 
			// mLblSTEAMCMD
			// 
			this.mLblSTEAMCMD.AutoSize = true;
			this.mLblSTEAMCMD.Location = new System.Drawing.Point(3, 10);
			this.mLblSTEAMCMD.Name = "mLblSTEAMCMD";
			this.mLblSTEAMCMD.Size = new System.Drawing.Size(217, 19);
			this.mLblSTEAMCMD.TabIndex = 8;
			this.mLblSTEAMCMD.Text = "Ok! Plaese, select Steam CMD Path:";
			// 
			// FrmWizStep1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(472, 322);
			this.Controls.Add(this.mTabsControl);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmWizStep1";
			this.Resizable = false;
			this.ShowInTaskbar = false;
			this.Text = "First Run Wizzard. Step 1";
			this.Load += new System.EventHandler(this.FrmWizStep1_Load);
			this.mTabsControl.ResumeLayout(false);
			this.mTabpS1.ResumeLayout(false);
			this.mTabpS2.ResumeLayout(false);
			this.mTabpS2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroTabControl mTabsControl;
		private MetroFramework.Controls.MetroTabPage mTabpS2;
		private MetroFramework.Controls.MetroTabPage mTabpS1;
		private MetroFramework.Controls.MetroLabel mLblInfo1;
		private MetroFramework.Controls.MetroButton mBtnIstallSteam;
		private MetroFramework.Controls.MetroButton mBtnIHaveSteam;
		private MetroFramework.Controls.MetroButton mBtnBrowse;
		private MetroFramework.Controls.MetroTextBox mTxtSTEAMCMD;
		private MetroFramework.Controls.MetroLabel mLblSTEAMCMD;
		private MetroFramework.Controls.MetroButton mBtnBack;
		private MetroFramework.Controls.MetroButton mBtnNext;
	}
}