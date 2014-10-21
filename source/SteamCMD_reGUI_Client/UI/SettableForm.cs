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
            sm.Owner = this;
            this.StyleManager = sm; 
            this.Style = sm.Style = iface.Style;
            this.Theme = sm.Theme = iface.Theme;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SettableForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Name = "SettableForm";
            this.Load += new System.EventHandler(this.SettableForm_Load);
            this.ResumeLayout(false);

        }

        private void SettableForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}
