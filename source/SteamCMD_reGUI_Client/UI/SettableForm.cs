using MetroFramework.Components;
using MetroFramework.Forms;
using SteamCMD_reGUI_Client.WRAPPER;

namespace SteamCMD_reGUI_Client.UI
{
    public class SettableForm: MetroForm
    {
        public SettableForm()   {
            var iface = CoreHandler.Instance.Config.Interface;
            var sm = new MetroStyleManager();
            this.Style = sm.Style = iface.Style;
            this.Theme = sm.Theme = iface.Theme;
        }
    }
}
