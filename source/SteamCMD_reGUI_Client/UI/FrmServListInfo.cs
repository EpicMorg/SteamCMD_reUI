using System;
using SteamCMD_reGUI_Core.Configs;
using SteamCMD_reGUI_Client.LOCALE;
using SteamCMD_reGUI_Client.WRAPPER;
using SteamCMD_reGUI_Core.Configs;
namespace SteamCMD_reGUI_Client.UI
{
    public partial class FrmServListInfo : SettableForm
    {
        public FrmServListInfo()
        {
            InitializeComponent();
            var infofromxml = CoreHandler.Instance.Servers;
        }

        private void FrmServListInfo_Load(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }
    }
}
