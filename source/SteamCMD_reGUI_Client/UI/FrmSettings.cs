using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MetroFramework; 
using MetroFramework.Forms;
using SteamCMD_reGUI_Client.LOCALE;
using SteamCMD_reGUI_Client.WRAPPER;
using SteamCMD_reGUI_Core.Configs;

namespace SteamCMD_reGUI_Client.UI {
    public partial class FrmSettings : SettableForm
    {
        public FrmSettings() {
            InitializeComponent(); 
            var iface = CoreHandler.Instance.Config.Interface;
            mTabsSettings.SelectTab( mTabInterface );
            var langs = new[] {
                "en-US", "ru-RU"
            }.Select( a => new Langs( a ) ).ToArray();
            mComboLang.Items.AddRange( langs );
            mComboAppStyle.Items.AddRange(Enum.GetValues(typeof(MetroColorStyle)).OfType<object>().ToArray());
            mComboAppTheme.Items.AddRange(Enum.GetValues(typeof(MetroThemeStyle)).OfType<object>().ToArray());
            mComboAppStyle.SelectedItem = iface.Style;
            mComboAppTheme.SelectedItem = iface.Theme;
            mComboLang.SelectedItem = langs.FirstOrDefault( a => a.LangCode == iface.InterfaceLang );  
        }

        private void FrmSettings_Load( object sender, EventArgs e ) {
            LoadConfig();
            this.Focus();
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public void LoadConfig() {
            var ch = CoreHandler.Instance.Config;
            var path = ch.Paths;
            var interf = ch.Interface;

            mTxtSTEAMCMD.Text = path.SteamCmdPath;
            mTxtDeafOD.Text = path.DefaultOutputDir;
            mToogleShowSplash.Checked = interf.SplashScreen;
        }

        private bool ValidateInput() {
            var txtbox = mTxtSTEAMCMD.Text;
            var txtbox2 = mTxtDeafOD.Text;
            return !String.IsNullOrWhiteSpace(txtbox) && File.Exists(txtbox) && !String.IsNullOrWhiteSpace(txtbox2) && Directory.Exists(txtbox2);
        }

        private bool AlertOnBadConfig() {
            var ok = CoreHandler.Instance.Config.Validate() && ( ValidateInput() || !CoreHandler.Instance.Config.Misc.FirstRun );
            if ( !ok )
                MessageBox.Show( Strings.sCheckPath, Strings.sError, MessageBoxButtons.OK, MessageBoxIcon.Error );
            return ok;
        }

        private void mBtnSave_Click( object sender, EventArgs e ) {
            if ( !ValidateInput() ) {
                MetroMessageBox.Show( this, Strings.sCheckPath, Strings.sError, MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }

            var config = CoreHandler.Instance.Config;

            config.Paths.SteamCmdPath = mTxtSTEAMCMD.Text;
            config.Paths.DefaultOutputDir = mTxtDeafOD.Text;
            config.Interface.SplashScreen = mToogleShowSplash.Checked;
            config.Interface.InterfaceLang = ( (Langs) mComboLang.SelectedItem ).LangCode;
            config.Interface.Style = (MetroColorStyle) mComboAppStyle.SelectedItem;
            config.Interface.Theme = (MetroThemeStyle)mComboAppTheme.SelectedItem;
            config.Misc.FirstRun = false;

            if (!config.Validate()) {
                MetroMessageBox.Show(this, Strings.sCfgInvalid, Strings.sError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CoreHandler.Instance.SaveConfig();
            MetroMessageBox.Show( this, Strings.sCfgSaved, Strings.sDone, MessageBoxButtons.OK, MessageBoxIcon.Information );
            Application.Restart();
        }

        private void FrmSettings_FormClosing( object sender, FormClosingEventArgs e ) {
            if ( !AlertOnBadConfig() )
                e.Cancel = true;
        }

        private void mBtnReset_Click( object sender, EventArgs e ) {
            var config = CoreHandler.Instance.Config;
            config.Interface.Theme = (MetroThemeStyle) mComboAppTheme.SelectedItem;
            config.Interface.Style = (MetroColorStyle) mComboAppStyle.SelectedItem;
            config.Misc.FirstRun = true;
            config.Misc.LicensesAccepted = false;
            config.Interface.SplashScreen = true;
            if (!config.Validate()) {
                MetroMessageBox.Show(this, Strings.sCfgInvalid, Strings.sError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CoreHandler.Instance.SaveConfig();
            LoadConfig();
            MetroMessageBox.Show( this, Strings.sReset, Strings.sDone, MessageBoxButtons.OK, MessageBoxIcon.Information );
            Application.Restart();
        }

        private void mBtnBrowse_Click( object sender, EventArgs e ) {
            if ( fileBrowser.ShowDialog() != DialogResult.OK )
                return;
            mTxtSTEAMCMD.Text = fileBrowser.FileName;
        }

        private void mTabsSettings_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mTabInterface_Click(object sender, EventArgs e)
        {

        }

        private void mToogleShowSplash_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mLblShowSplash_Click(object sender, EventArgs e)
        {

        }

        private void mLblAppStyle_Click(object sender, EventArgs e)
        {

        }

        private void mComboAppStyle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mLblAppTheme_Click(object sender, EventArgs e)
        {

        }

        private void mComboAppTheme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mLblLang_Click(object sender, EventArgs e)
        {

        }

        private void mComboLang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mTabPaths_Click(object sender, EventArgs e)
        {

        }

        private void mTxtSTEAMCMD_Click(object sender, EventArgs e)
        {

        }

        private void mLblSTEAMCMD_Click(object sender, EventArgs e)
        {

        }

        private void fileBrowser_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
         

        private void mBtnDeafOD_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() != DialogResult.OK)
                return;
            mTxtDeafOD.Text = folderBrowser.SelectedPath;
        }
    }
}