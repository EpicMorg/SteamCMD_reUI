using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamCMD_reGUI_Client.UI
{
	public partial class FrmWizStep1 : SettableForm
	{
		public FrmWizStep1()
		{
			InitializeComponent();
		}

		private void FrmWizStep1_Load(object sender, EventArgs e)
		{
			mTabsControl.SelectTab(mTabpS1);
		}

		private void mBtnIHaveSteam_Click(object sender, EventArgs e)
		{
			mTabsControl.SelectTab(mTabpS2);
		}

		private void mBtnBack_Click(object sender, EventArgs e)
		{
			mTabsControl.SelectTab(mTabpS1);
		}

		private void mBtnIstallSteam_Click(object sender, EventArgs e)
		{
			var frmDownloader = new FrmDownloader();
			frmDownloader.ShowDialog();
		}
	}
}
