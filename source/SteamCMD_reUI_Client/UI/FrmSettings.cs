using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;
using SteamCMD_reUI_Client.LOCALE; 
using SteamCMD_reUI_Client.WRAPPER;
using SteamCMD_reUI_Core.Configs;

#pragma warning disable 219

namespace SteamCMD_reUI_Client.UI {
    public partial class FrmSettings : MetroForm
    {
        public FrmSettings() {
            var iface = CoreHandler.Instance.Config.Interface;
            var sm = new MetroStyleManager();
            sm.Owner = this;
            StyleManager = sm;
            Style = sm.Style = iface.Style;
            Theme = sm.Theme = iface.Theme;
            SuspendLayout();
            InitializeComponent();
            mTabsSettings.SelectTab( mTabInterface );
            var langs = new[] { "en-US", "ru-RU", "be-BY" }.Select( a => new Langs( a ) ).ToArray();
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
            Activate();
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

        private static void DownloadMe()
        {
            var frmDownloader = new FrmDownloader();
            frmDownloader.ShowDialog();
        }

        private bool AlertOnBadConfig() {
            var txtbox = mTxtSTEAMCMD.Text;
            var txtbox2 = mTxtDeafOD.Text;
            var ok = true;
            string error = null;
            if ( !CoreHandler.Instance.Config.Validate() ) {
                ok = false;
                //error = Strings.sError;
            }
            if ( ok && (string.IsNullOrWhiteSpace( txtbox ) || !File.Exists( txtbox ) ) ) {
                if ( this.MetroMessageBox( Strings.sCheckPath, Strings.sError, MessageBoxButtons.YesNo ) == DialogResult.Yes ) { 
                   DownloadMe();
                }
                else {
                    ok = false;
                    //error = Strings.sError;
                } 
            }
            if (ok && (string.IsNullOrWhiteSpace(txtbox2) || !Directory.Exists(txtbox2)))
            {
                ok = false;
                if (this.MetroMessageBox(Strings.sServersDirectoryNotExistis, Strings.sError, MessageBoxButtons.YesNo) == DialogResult.Yes)  {
                    try {
                        if (txtbox2 != null) Directory.CreateDirectory(txtbox2);
                        ok = true;
                    }  catch (Exception ex) {
                        //error = Strings.sError;
                        ok = false;
                        Console.Write(ex); }
                    //if ( !ok) {
                    //   this.MetroMessageBox( error, Strings.sError, MessageBoxButtons.OK, MessageBoxIcon.Error ); //Все время срабатывает. Нахера это здесь?
                    //}
                    ok = true;
                }
                return ok;
            }
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

        private void mBtnDownload_Click(object sender, EventArgs e)
        {
            DownloadMe();
        }
    }
}