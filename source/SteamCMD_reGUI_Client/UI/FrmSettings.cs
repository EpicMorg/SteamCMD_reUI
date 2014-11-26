﻿using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using SteamCMD_reGUI_Client.LOCALE;
using SteamCMD_reGUI_Client.WRAPPER;
using SteamCMD_reGUI_Core.Configs;

namespace SteamCMD_reGUI_Client.UI {
    public partial class FrmSettings : SettableForm {
        public FrmSettings() {
            InitializeComponent();
            var iface = CoreHandler.Instance.Config.Interface;
            mTabsSettings.SelectTab( mTabInterface );
            var langs = new[] { "en-US", "ru-RU" }.Select( a => new Langs( a ) ).ToArray();
            mComboLang.Items.AddRange( langs );
            mComboAppStyle.Items.AddRange( Enum.GetValues( typeof( MetroColorStyle ) ).OfType<object>().ToArray() );
            mComboAppTheme.Items.AddRange( Enum.GetValues( typeof( MetroThemeStyle ) ).OfType<object>().ToArray() );
            mComboAppStyle.SelectedItem = iface.Style;
            mComboAppTheme.SelectedItem = iface.Theme;
            mComboLang.SelectedItem = langs.FirstOrDefault( a => a.LangCode == iface.InterfaceLang );
        }

        private void FrmSettings_Load( object sender, EventArgs e ) {
            LoadConfig();
            Focus();
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public void LoadConfig() {
            var ch = CoreHandler.Instance.Config;
            var path = ch.Paths;
            var interf = ch.Interface;
            mTxtSTEAMCMD.Text = path.SteamCmdPath;
            mTxtDeafOD.Text = path.DefaultOutputDir;
            mToogleShowSplash.Checked = interf.SplashScreen;
            mToogleLog.Checked = ch.Misc.Logging;
        }

        private bool AlertOnBadConfig() {
            var txtbox = mTxtSTEAMCMD.Text;
            var txtbox2 = mTxtDeafOD.Text;
            var ok = true;
            string error = null;
            if ( !CoreHandler.Instance.Config.Validate() ) {
                ok = false;
                error = Strings.sError;
            }
            if ( ok && ( String.IsNullOrWhiteSpace( txtbox ) || !File.Exists( txtbox ) ) ) {
                if ( this.MetroMessageBox( Strings.sCheckPath, Strings.sError, MessageBoxButtons.YesNo ) == DialogResult.Yes ) {
                    var frmDownloader = new FrmDownloader();
                    frmDownloader.ShowDialog();
                }
                else {
                    ok = false;
                    error = Strings.sError;
                }
            }
            if ( ok && ( String.IsNullOrWhiteSpace( txtbox2 ) || !Directory.Exists( txtbox2 ) ) ) {
                ok = false;
                error = Strings.sError;
            }
            if ( !ok )
                this.MetroMessageBox( error, Strings.sError, MessageBoxButtons.OK, MessageBoxIcon.Error );
            return ok;
        }

        private void mBtnSave_Click( object sender, EventArgs e ) {
            if ( !AlertOnBadConfig() ) return;
            var config = CoreHandler.Instance.Config;
            config.Misc.Logging = mToogleLog.Checked;
            config.Paths.SteamCmdPath = mTxtSTEAMCMD.Text;
            config.Paths.DefaultOutputDir = mTxtDeafOD.Text;
            config.Interface.SplashScreen = mToogleShowSplash.Checked;
            config.Interface.InterfaceLang = ( (Langs) mComboLang.SelectedItem ).LangCode;
            config.Interface.Style = (MetroColorStyle) mComboAppStyle.SelectedItem;
            config.Interface.Theme = (MetroThemeStyle) mComboAppTheme.SelectedItem;
            config.Misc.FirstRun = false;

            if ( !config.Validate() ) {
                this.MetroMessageBox( Strings.sCfgInvalid, Strings.sError, MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }
            CoreHandler.Instance.SaveConfig();
            MetroMessageBox.Show( this, Strings.sCfgSaved, Strings.sDone, MessageBoxButtons.OK, MessageBoxIcon.Information );
            Application.Restart();
        }

        private void mBtnReset_Click( object sender, EventArgs e ) {
            var config = CoreHandler.Instance.Config;
            config.Misc.Logging = false;
            config.Interface.Theme = (MetroThemeStyle) mComboAppTheme.SelectedItem;
            config.Interface.Style = (MetroColorStyle) mComboAppStyle.SelectedItem;
            config.Misc.FirstRun = true;
            config.Misc.LicensesAccepted = false;
            config.Interface.SplashScreen = true;
            if ( !config.Validate() ) {
                this.MetroMessageBox( Strings.sCfgInvalid, Strings.sError, MessageBoxButtons.OK, MessageBoxIcon.Error );
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

        private void mBtnDeafOD_Click( object sender, EventArgs e ) {
            if ( folderBrowser.ShowDialog() != DialogResult.OK )
                return;
            mTxtDeafOD.Text = folderBrowser.SelectedPath;
        }
    }
}