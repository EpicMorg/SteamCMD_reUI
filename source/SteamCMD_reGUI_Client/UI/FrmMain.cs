using System;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using SteamCMD_reGUI_Client.LOCALE;

namespace SteamCMD_reGUI_Client.UI
{
    public partial class FrmMain : MetroForm
    {
        public FrmMain()
        {
            InitializeComponent();
            
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click( object sender, EventArgs e ) {
            var frmset = new FrmSettings();
            frmset.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frmbet = new FrmBrowser();
            frmbet.ShowDialog();
        }

       
    }
}
