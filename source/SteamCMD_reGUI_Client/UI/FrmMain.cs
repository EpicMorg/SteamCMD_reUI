using System;
using System.Diagnostics;
using MetroFramework;
using SteamCMD_reGUI_Client.LOCALE;

namespace SteamCMD_reGUI_Client.UI {
    public partial class FrmMain : SettableForm {
        bool _procStarted; 
        public FrmMain() {
            InitializeComponent();
            mTabsMain.SelectTab( mTabMain );
            mTileProcess.Text = Strings.sStartP;
            if ( this.Theme == MetroThemeStyle.Light ) {}
            else {
                picLogo.Image = Properties.Resources.steam_light_128;
                picMF.Image = Properties.Resources.github_octocat_light;
                picAbout.Image = Properties.Resources.nyan_light;
            }
            if ( this.Style != MetroColorStyle.Black ) {}
            else {
                mTileAbout.TileImage = Properties.Resources.nyan_light;
                mTileConsole.TileImage = Properties.Resources.console_light;
                mTileSettings.TileImage = Properties.Resources.settings_light;
                mTileProcess.TileImage = Properties.Resources.start_light;
            }
        }

        private void FrmMain_Load( object sender, EventArgs e ) {
            mLblProdName.Text = String.Format( "{0}", FrmSplashScreen.AssemblyProduct );
            mLblProdVer.Text = String.Format( "{0}", FrmSplashScreen.AssemblyVersion );
            this.Focus();
        }

        private void button3_Click( object sender, EventArgs e ) {
            var frmd = new FrmDownloader();
            frmd.ShowDialog();
        }

        private void mTabMain_Click( object sender, EventArgs e ) { }

        private void mLnkMF_Click( object sender, EventArgs e ) { Process.Start( "https://github.com/dennismagno/winforms-modernui/" ); }

        private void mLnkRG_Click( object sender, EventArgs e ) { Process.Start( "https://github.com/stamepicmorg/SteamCMD_reGUI/" ); }

        private void mLnkMIC_Click( object sender, EventArgs e ) { Process.Start( "https://github.com/Templarian/WindowsIcons/" ); }

        private void mTileConsole_Click( object sender, EventArgs e ) { mTabsMain.SelectTab( mTabConsole ); }

        private void mTileAbout_Click( object sender, EventArgs e ) { mTabsMain.SelectTab( mTabAbout ); }

        private void mTileSettings_Click( object sender, EventArgs e ) {
            var frmset = new FrmSettings();
            frmset.ShowDialog();
        }

        private void mTileProcess_Click( object sender, EventArgs e ) { StartPicCheck(); }

        private void StartPicCheck() {
            if ( !_procStarted ) {
                _procStarted = true;
                mTileProcess.Text = Strings.sStopP;
                mTileProcess.TileImage = this.Style != MetroColorStyle.Black ? Properties.Resources.stop_dark : Properties.Resources.stop_light;
            }
            else {
                _procStarted = false;
                mTileProcess.Text = Strings.sStartP;
                mTileProcess.TileImage = this.Style != MetroColorStyle.Black ? Properties.Resources.start_dark : Properties.Resources.start_light;
            }
        }
    }
}