using System;
using MetroFramework.Components;
using MetroFramework.Forms;
using SteamCMD_reUI_Client.WRAPPER;

namespace SteamCMD_reUI_Client.UI
{
    public partial class FrmServListInfo : MetroForm
    {
        public FrmServListInfo()
        {
            var iface = CoreHandler.Instance.Config.Interface;
            var sm = new MetroStyleManager();
            sm.Owner = this;
            StyleManager = sm;
            Style = sm.Style = iface.Style;
            Theme = sm.Theme = iface.Theme;
            SuspendLayout();
            InitializeComponent();
        }

        private void FrmServListInfo_Load(object sender, EventArgs e)
        {
            var meta = CoreHandler.Instance.Servers.Meta;
            mTxtVersion.Text = meta.Version;
            mTxtAuthor.Text = meta.Author;
            mTxtComment.Text = meta.Comment;
            mTxtDate.Text = meta.Date.ToShortDateString();
        }
         
    }
}
