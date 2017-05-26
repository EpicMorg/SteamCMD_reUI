using System;
using System.IO;
using System.Windows.Forms;
using MetroFramework.Forms; 
using SteamCMD_reUI_Client.WRAPPER;

namespace SteamCMD_reUI_Client.UI {
    public partial class FrmLicAccept : MetroForm {
        public FrmLicAccept() {
            InitializeComponent();
            mTabsControl.SelectTab( mTabpLic1 );
        }

        private void FrmLicAccept_Load( object sender, EventArgs e ) {
            var path = Application.StartupPath;
            var lic1 = path + @"//LICENSES//SteamCMDreUI.txt";
            try {
                rTxtLic1.Text = File.ReadAllText( lic1 );
            }
            catch ( Exception ex1 ) {
                this.MetroMessageBox( "" + ex1, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                rTxtLic1.Text = @"File Not Found!";
            }
            var lic2 = path + @"//LICENSES//ModernMetroUIFramework.txt";
            try {
                rTxtLic2.Text = File.ReadAllText( lic2 );
            }
            catch ( Exception ex2 ) {
                this.MetroMessageBox( "" + ex2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                rTxtLic1.Text = @"File Not Found!";
            }
            var lic3 = path + @"//LICENSES//WindowsIcons.txt";
            try {
                rTxtLic3.Text = File.ReadAllText( lic3 );
            }
            catch ( Exception ex3 ) {
                this.MetroMessageBox( "" + ex3, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                rTxtLic3.Text = @"File Not Found!";
            }
        }

        private void Exterinate() { Application.Exit(); }

        private void mBtnDecline_Click( object sender, EventArgs e ) { Exterinate(); }

        private void mBtnAccept_Click( object sender, EventArgs e ) { mTabsControl.SelectTab( mTabpLic2 ); }

        private void mBtnDecline2_Click( object sender, EventArgs e ) { Exterinate(); }

        private void mBtnPrev_Click( object sender, EventArgs e ) { mTabsControl.SelectTab( mTabpLic1 ); }

        private void mBtnAcceptFinal_Click( object sender, EventArgs e ) {
            var i = CoreHandler.Instance;
            var c = i.Config;
            var m = c.Misc;
            if ( !c.Validate() ) {
                this.MetroMessageBox( @"Config is invalid! Fix it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }
            m.LicensesAccepted = true;
            i.SaveConfig();
            Application.Restart();
        }

        private void mBtnAcceptMUF_Click( object sender, EventArgs e ) { mTabsControl.SelectTab( mTabpLic3 ); }

        private void mBtnPrev2_Click( object sender, EventArgs e ) { mTabsControl.SelectTab( mTabpLic2 ); }

        private void mBtnDecline3_Click( object sender, EventArgs e ) { Exterinate(); }
    }
}