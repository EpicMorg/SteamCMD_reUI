using System;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using SteamCMD_reUI_Client.LOCALE;
using SteamCMD_reUI_Client.Properties;

namespace SteamCMD_reUI_Client.UI {
    public partial class FrmSteamGuard : MetroForm
    {
        public FrmSteamGuard() {
            InitializeComponent();
            mTxtSGPhrase.PromptText = Strings.sHere;
            if (Theme != MetroThemeStyle.Light) {
                mBtnEnter.TileImage = Resources.light_key;
                mTxtSGPhrase.Icon = Resources.light_unlock; }
            if (Style == MetroColorStyle.Black) {
                mBtnEnter.TileImage = Resources.light_key;
                mTxtSGPhrase.Icon = Resources.light_unlock; }
        }

        private void frmSteamGuard_Load(object sender, EventArgs e) { }

        private void mTxtSGPhrase_TextChanged(object sender, EventArgs e)
        {
            if (mTxtSGPhrase.Text == string.Empty) {
                if (Theme != MetroThemeStyle.Light)
                    mTxtSGPhrase.Icon = Resources.light_unlock;
                else
                    mTxtSGPhrase.Icon = Resources.dark_unlock; }
            else {
                if (Theme != MetroThemeStyle.Light)
                    mTxtSGPhrase.Icon = Resources.light_unlock_keyhole;
                else
                    mTxtSGPhrase.Icon = Resources.dark_unlock_keyhole; }
        }

        private void mBtnEnter_Click(object sender, EventArgs e)
        {
            if (mTxtSGPhrase.Text == string.Empty) {
               this.MetroMessageBox( Strings.sEmptyField, Strings.sError, MessageBoxButtons.OK,MessageBoxIcon.Error);
               return; }
            else{ 
                //code here
            }
        }
    }
}