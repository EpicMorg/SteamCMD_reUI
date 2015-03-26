using System; 
using SteamCMD_reGUI_Client.WRAPPER; 

namespace SteamCMD_reGUI_Client.UI
{
    public partial class FrmServListInfo : SettableForm
    {
        public FrmServListInfo()
        {
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
