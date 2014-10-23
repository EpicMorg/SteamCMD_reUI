using System;
using System.Diagnostics;
using MetroFramework;

namespace SteamCMD_reGUI_Client.UI {
    public partial class FrmMain : SettableForm {
        public FrmMain() {
            InitializeComponent();
            mTabsMain.SelectTab( mTabMain );
            if ( this.Theme == MetroThemeStyle.Light )
                return;
            picLogo.Image = Properties.Resources.steam_light_128;
            picMF.Image = Properties.Resources.github_octocat_light;
            picAbout.Image = Properties.Resources.nyan_light;
        }

        private void FrmMain_Load( object sender, EventArgs e ) {
            mLblProdName.Text = String.Format( "{0}", FrmSplashScreen.AssemblyProduct );
            mLblProdVer.Text = String.Format( "{0}", FrmSplashScreen.AssemblyVersion );
            this.Focus();
        }

        private void button1_Click( object sender, EventArgs e ) {
            var frmset = new FrmSettings();
            frmset.ShowDialog();
        }

        private void button2_Click( object sender, EventArgs e ) {
            var frmbet = new FrmDownloader();
            frmbet.ShowDialog();
        }

        private void button3_Click( object sender, EventArgs e ) {
            var frmd = new FrmDownloader();
            frmd.ShowDialog();
        }

        private void mTabMain_Click( object sender, EventArgs e ) { }

        private void mLnkMF_Click( object sender, EventArgs e ) { Process.Start( "https://github.com/dennismagno/winforms-modernui/" ); }

        private void mLnkRG_Click( object sender, EventArgs e ) { Process.Start( "https://github.com/stamepicmorg/SteamCMD_reGUI/" ); }

        private void mLnkMIC_Click( object sender, EventArgs e ) { Process.Start( "https://github.com/Templarian/WindowsIcons/" ); }
    }
}

