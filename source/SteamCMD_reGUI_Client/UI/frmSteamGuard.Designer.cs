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
            this.mTxtSGPhrase = new MetroFramework.Controls.MetroTextBox();
            this.mBtnEnter = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // mTxtSGPhrase
            // 
            this.mTxtSGPhrase.Lines = new string[0];
            this.mTxtSGPhrase.Location = new System.Drawing.Point(23, 63);
            this.mTxtSGPhrase.MaxLength = 32767;
            this.mTxtSGPhrase.Name = "mTxtSGPhrase";
            this.mTxtSGPhrase.PasswordChar = '\0';
            this.mTxtSGPhrase.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtSGPhrase.SelectedText = "";
            this.mTxtSGPhrase.Size = new System.Drawing.Size(385, 23);
            this.mTxtSGPhrase.TabIndex = 0;
            this.mTxtSGPhrase.UseSelectable = true;
            // 
            // mBtnEnter
            // 
            this.mBtnEnter.Location = new System.Drawing.Point(414, 63);
            this.mBtnEnter.Name = "mBtnEnter";
            this.mBtnEnter.Size = new System.Drawing.Size(75, 23);
            this.mBtnEnter.TabIndex = 1;
            this.mBtnEnter.Text = "OK";
            this.mBtnEnter.UseSelectable = true;
            // 
            // FrmSteamGuard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 109);
            this.Controls.Add(this.mBtnEnter);
            this.Controls.Add(this.mTxtSGPhrase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSteamGuard";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Text = "SteamGuard";
            this.Load += new System.EventHandler(this.frmSteamGuard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox mTxtSGPhrase;
        private MetroFramework.Controls.MetroButton mBtnEnter;
    }
}