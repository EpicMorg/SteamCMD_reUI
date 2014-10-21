using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;
using SteamCMD_reGUI_Client.LOCALE;
using SteamCMD_reGUI_Client.WRAPPER;
using SteamCMD_reGUI_Core.Configs;

namespace SteamCMD_reGUI_Client.UI {
    public partial class FrmSettings : SettableForm {
        public FrmSettings() {
            InitializeComponent(); 
            mTabsSettings.SelectTab( mTabInterface );
            var langs = new[] {
                "en-US", "ru-RU"
            }.Select( a => new Langs( a ) ).ToArray();
            mComboLang.Items.AddRange( langs );
            mComboAppStyle.Items.AddRange(Enum.GetValues(typeof(MetroColorStyle)).OfType<object>().ToArray());
            mComboAppTheme.Items.AddRange(Enum.GetValues(typeof(MetroThemeStyle)).OfType<object>().ToArray());
            var iface = CoreHandler.Instance.Config.Interface;
            mComboAppStyle.SelectedItem = iface.Style;
            mComboAppTheme.SelectedItem = iface.Theme;
            mComboLang.SelectedItem = langs.FirstOrDefault( a => a.LangCode == iface.InterfaceLang );
            metroStyleManager.Style = iface.Style;
            metroStyleManager.Theme = iface.Theme;
        }

        private void FrmSettings_Load( object sender, EventArgs e ) {
            LoadConfig();
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public void LoadConfig() {
            var ch = CoreHandler.Instance.Config;
            var path = ch.Paths;
            var interf = ch.Interface;

            mTxtSTEAMCMD.Text = path.SteamCmdPath;
            mToogleShowSplash.Checked = interf.SplashScreen;
        }

        private bool ValidateInput() {
            var txtbox = mTxtSTEAMCMD.Text;
            return !String.IsNullOrWhiteSpace( txtbox ) && File.Exists( txtbox );
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
    }
}