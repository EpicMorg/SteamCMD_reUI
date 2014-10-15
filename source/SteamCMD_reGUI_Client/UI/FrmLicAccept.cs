using System;
using System.IO;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using SteamCMD_reGUI_Client.WRAPPER;

namespace SteamCMD_reGUI_Client.UI
{
    public partial class FrmLicAccept :   MetroForm
    {
         public FrmLicAccept()
        {
            InitializeComponent();
            mTabsControl.SelectTab(mTabpLic1); 
         }

        private void FrmLicAccept_Load( object sender, EventArgs e ) {
            var path = Application.StartupPath;
            var lic1 = path + @"//LICENSES//SteamCMDreGUI.txt"; 
            try {
                rTxtLic1.Text = File.ReadAllText(lic1); 
            }
            catch ( Exception ex1) {
                MetroMessageBox.Show(this, "" +ex1, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rTxtLic1.Text = @"File Not Found!";
            }
            var lic2 = path + @"//LICENSES//ModernMetroUIFramework.txt";
            try
            {
                rTxtLic2.Text = File.ReadAllText(lic2);
            }
            catch (Exception ex2)
            {
                MetroMessageBox.Show(this, "" + ex2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rTxtLic1.Text = @"File Not Found!";
            }
        }
        private void Exterinate() {
            Application.Exit();
        }

        private void mBtnDecline_Click( object sender, EventArgs e ) { Exterinate(); }



        private void mBtnAccept_Click(object sender, EventArgs e)
        {
            mTabsControl.SelectTab(mTabpLic2);
            
        }

        private void mBtnDecline2_Click(object sender, EventArgs e)
        {
            Exterinate();
        }

        private void mBtnPrev_Click(object sender, EventArgs e)
        {
            mTabsControl.SelectTab(mTabpLic1);
        }
  
        private void mBtnAcceptFinal_Click(object sender, EventArgs e)
        {
     
            var i = CoreHandler.Instance;
            var c = i.Config;
            var m = c.Misc;
            if (!c.Validate())
            {
                 MetroMessageBox.Show(this, @"Config is invalid! Fix it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return;
            }
            m.LicensesAccepted = true;
            i.SaveConfig();
            Application.Restart();
        }
         
    }
}
