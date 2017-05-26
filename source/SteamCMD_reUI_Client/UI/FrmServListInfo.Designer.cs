namespace SteamCMD_reUI_Client.UI
{
    partial class FrmServListInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServListInfo));
            this.lblVersion = new MetroFramework.Controls.MetroLabel();
            this.mTxtVersion = new MetroFramework.Controls.MetroTextBox();
            this.lblDate = new MetroFramework.Controls.MetroLabel();
            this.mTxtDate = new MetroFramework.Controls.MetroTextBox();
            this.lblAutor = new MetroFramework.Controls.MetroLabel();
            this.mTxtAuthor = new MetroFramework.Controls.MetroTextBox();
            this.mTxtComment = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // lblVersion
            // 
            resources.ApplyResources(this.lblVersion, "lblVersion");
            this.lblVersion.Name = "lblVersion";
            // 
            // mTxtVersion
            // 
            resources.ApplyResources(this.mTxtVersion, "mTxtVersion");
            this.mTxtVersion.Lines = new string[0];
            this.mTxtVersion.MaxLength = 32767;
            this.mTxtVersion.Name = "mTxtVersion"; 
            this.mTxtVersion.ReadOnly = true;
            this.mTxtVersion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtVersion.SelectedText = "";
            this.mTxtVersion.UseSelectable = true;
            // 
            // lblDate
            // 
            resources.ApplyResources(this.lblDate, "lblDate");
            this.lblDate.Name = "lblDate"; 
            // 
            // mTxtDate
            // 
            resources.ApplyResources(this.mTxtDate, "mTxtDate");
            this.mTxtDate.Lines = new string[0];
            this.mTxtDate.MaxLength = 32767;
            this.mTxtDate.Name = "mTxtDate"; 
            this.mTxtDate.ReadOnly = true;
            this.mTxtDate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtDate.SelectedText = "";
            this.mTxtDate.UseSelectable = true;
            // 
            // lblAutor
            // 
            resources.ApplyResources(this.lblAutor, "lblAutor");
            this.lblAutor.Name = "lblAutor";
            // 
            // mTxtAuthor
            // 
            resources.ApplyResources(this.mTxtAuthor, "mTxtAuthor");
            this.mTxtAuthor.Lines = new string[0];
            this.mTxtAuthor.MaxLength = 32767;
            this.mTxtAuthor.Name = "mTxtAuthor"; 
            this.mTxtAuthor.ReadOnly = true;
            this.mTxtAuthor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtAuthor.SelectedText = "";
            this.mTxtAuthor.UseSelectable = true;
            // 
            // mTxtComment
            // 
            resources.ApplyResources(this.mTxtComment, "mTxtComment");
            this.mTxtComment.Lines = new string[0];
            this.mTxtComment.MaxLength = 32767;
            this.mTxtComment.Multiline = true;
            this.mTxtComment.Name = "mTxtComment"; 
            this.mTxtComment.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtComment.SelectedText = "";
            this.mTxtComment.UseSelectable = true;
            // 
            // FrmServListInfo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mTxtComment);
            this.Controls.Add(this.mTxtAuthor);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.mTxtDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.mTxtVersion);
            this.Controls.Add(this.lblVersion);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmServListInfo";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FrmServListInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblVersion;
        private MetroFramework.Controls.MetroTextBox mTxtVersion;
        private MetroFramework.Controls.MetroLabel lblDate;
        private MetroFramework.Controls.MetroTextBox mTxtDate;
        private MetroFramework.Controls.MetroLabel lblAutor;
        private MetroFramework.Controls.MetroTextBox mTxtAuthor;
        private MetroFramework.Controls.MetroTextBox mTxtComment;
    }
}