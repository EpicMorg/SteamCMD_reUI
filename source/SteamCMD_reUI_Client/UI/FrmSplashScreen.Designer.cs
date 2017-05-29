using SteamCMD_reUI_Client.UI;

namespace SteamCMD_reUI_Client.UI
{
    partial class FrmSplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSplashScreen));
            this.metroLabelLoading = new MetroFramework.Controls.MetroLabel();
            this.metroLabelProduct = new MetroFramework.Controls.MetroLabel();
            this.metroLabelVersion = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabelLoading
            // 
            this.metroLabelLoading.AutoSize = true;
            this.metroLabelLoading.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelLoading.Location = new System.Drawing.Point(23, 60);
            this.metroLabelLoading.Name = "metroLabelLoading";
            this.metroLabelLoading.Size = new System.Drawing.Size(101, 25);
            this.metroLabelLoading.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroLabelLoading.TabIndex = 0;
            this.metroLabelLoading.Text = "loading text";
            // 
            // metroLabelProduct
            // 
            this.metroLabelProduct.AutoSize = true;
            this.metroLabelProduct.Location = new System.Drawing.Point(23, 228);
            this.metroLabelProduct.Name = "metroLabelProduct";
            this.metroLabelProduct.Size = new System.Drawing.Size(55, 19);
            this.metroLabelProduct.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroLabelProduct.TabIndex = 1;
            this.metroLabelProduct.Text = "product";
            // 
            // metroLabelVersion
            // 
            this.metroLabelVersion.AutoSize = true;
            this.metroLabelVersion.Location = new System.Drawing.Point(23, 247);
            this.metroLabelVersion.Name = "metroLabelVersion";
            this.metroLabelVersion.Size = new System.Drawing.Size(50, 19);
            this.metroLabelVersion.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroLabelVersion.TabIndex = 2;
            this.metroLabelVersion.Text = "version";
            // 
            // FrmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 286);
            this.ControlBox = false;
            this.Controls.Add(this.metroLabelVersion);
            this.Controls.Add(this.metroLabelProduct);
            this.Controls.Add(this.metroLabelLoading);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSplashScreen";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = " SteamCMD reUI";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.FrmSplashScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabelLoading;
        private MetroFramework.Controls.MetroLabel metroLabelProduct;
        private MetroFramework.Controls.MetroLabel metroLabelVersion;
    }
}