using System; 
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace SteamCMD_reGUI_Client.UI
{
    public partial class FrmSettings : MetroForm
    {
        public FrmSettings()
        {
            InitializeComponent();
            mTabsSettings.SelectTab(mTabInterface);
           
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
             
        } 
    }
}
