namespace SteamCMD_reUI_Client.UI
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
            this.mLblHelp.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mLblHelp.Name = "mLblHelp";
            this.mLblHelp.WrapToLine = true;
            // 
            // mBtnEnter
            // 
            resources.ApplyResources(this.mBtnEnter, "mBtnEnter");
            this.mBtnEnter.ActiveControl = null;
            this.mBtnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mBtnEnter.Name = "mBtnEnter";
            this.mBtnEnter.TileImage = global::SteamCMD_reUI_Client.Properties.Resources.dark_key;
            this.mBtnEnter.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mBtnEnter.UseSelectable = true;
            this.mBtnEnter.UseTileImage = true;
            this.mBtnEnter.Click += new System.EventHandler(this.mBtnEnter_Click);
            // 
            // mTxtSGPhrase
            // 
            resources.ApplyResources(this.mTxtSGPhrase, "mTxtSGPhrase");
            // 
            // 
            // 
            this.mTxtSGPhrase.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription");
            this.mTxtSGPhrase.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName");
            this.mTxtSGPhrase.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("resource.Anchor")));
            this.mTxtSGPhrase.CustomButton.AutoSize = ((bool)(resources.GetObject("resource.AutoSize")));
            this.mTxtSGPhrase.CustomButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("resource.AutoSizeMode")));
            this.mTxtSGPhrase.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage")));
            this.mTxtSGPhrase.CustomButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("resource.BackgroundImageLayout")));
            this.mTxtSGPhrase.CustomButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("resource.Dock")));
            this.mTxtSGPhrase.CustomButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("resource.FlatStyle")));
            this.mTxtSGPhrase.CustomButton.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font")));
            this.mTxtSGPhrase.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.mTxtSGPhrase.CustomButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.ImageAlign")));
            this.mTxtSGPhrase.CustomButton.ImageIndex = ((int)(resources.GetObject("resource.ImageIndex")));
            this.mTxtSGPhrase.CustomButton.ImageKey = resources.GetString("resource.ImageKey");
            this.mTxtSGPhrase.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.mTxtSGPhrase.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.mTxtSGPhrase.CustomButton.MaximumSize = ((System.Drawing.Size)(resources.GetObject("resource.MaximumSize")));
            this.mTxtSGPhrase.CustomButton.Name = "";
            this.mTxtSGPhrase.CustomButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("resource.RightToLeft")));
            this.mTxtSGPhrase.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.mTxtSGPhrase.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtSGPhrase.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.mTxtSGPhrase.CustomButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.TextAlign")));
            this.mTxtSGPhrase.CustomButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("resource.TextImageRelation")));
            this.mTxtSGPhrase.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtSGPhrase.CustomButton.UseSelectable = true;
            this.mTxtSGPhrase.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.mTxtSGPhrase.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.mTxtSGPhrase.Icon = global::SteamCMD_reUI_Client.Properties.Resources.dark_unlock;
            this.mTxtSGPhrase.Lines = new string[0];
            this.mTxtSGPhrase.MaxLength = 32767;
            this.mTxtSGPhrase.Name = "mTxtSGPhrase";
            this.mTxtSGPhrase.PasswordChar = '\0';
            this.mTxtSGPhrase.PromptText = "...в это поле.";
            this.mTxtSGPhrase.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtSGPhrase.SelectedText = "";
            this.mTxtSGPhrase.SelectionLength = 0;
            this.mTxtSGPhrase.SelectionStart = 0;
            this.mTxtSGPhrase.ShortcutsEnabled = true;
            this.mTxtSGPhrase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mTxtSGPhrase.UseSelectable = true;
            this.mTxtSGPhrase.WaterMark = "...в это поле.";
            this.mTxtSGPhrase.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtSGPhrase.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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