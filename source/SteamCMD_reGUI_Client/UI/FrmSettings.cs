using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using SteamCMD_reGUI_Client.LOCALE;
using SteamCMD_reGUI_Client.WRAPPER;
using SteamCMD_reGUI_Core.Configs;

namespace SteamCMD_reGUI_Client.UI
{
    public partial class FrmSettings : MetroForm
    {
        public FrmSettings()
        {
            InitializeComponent();
            mTabsSettings.SelectTab(mTabInterface);
            mComboLang.Items.Clear();
            var langs = new Langs[] {
                new Langs {
                    LangName = "English", LangCode = "en-US"
                },
                new Langs {
                    LangName = "Russian", LangCode = "ru-RU"
                }
            };
            mComboLang.Items.AddRange(langs);
            var cl = CoreHandler.Instance.Config.Interface.InterfaceLang;
            mComboLang.SelectedIndex = String.IsNullOrEmpty(cl) ? 0 : langs.Select((a, i) => new { a, i }).First(a => a.a.LangCode == cl).i;
        }

        private void FrmSettings_Load( object sender, EventArgs e ) { LoadConfig(); }

        public void LoadConfig() {
            var ch = CoreHandler.Instance.Config;
            var path =ch.Paths;
            var interf = ch.Interface;
            mTxtSTEAMCMD.Text = path.SteamCmdPath;
            mToogleShowSplash.Checked = interf.SplashScreen;
        }
        private bool ValidateInput() {
            var txtbox = mTxtSTEAMCMD.Text;
            return !String.IsNullOrWhiteSpace( txtbox )
                   && File.Exists( txtbox );
        }

        private bool AlertOnBadConfig()
        {
            var ok = CoreHandler.Instance.Config.Validate() && (ValidateInput() || !CoreHandler.Instance.Config.Misc.FirstRun);
            if (!ok) MessageBox.Show(Strings.sCheckPath, Strings.sError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return ok;
        }

        private void mBtnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MetroMessageBox.Show(this, Strings.sCheckPath, Strings.sError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var lc = ((Langs)mComboLang.SelectedItem).LangCode;
            var i = CoreHandler.Instance;
            var c = i.Config;
            var p = c.Paths;
            var m = c.Misc;
            var l = c.Interface;
            p.SteamCmdPath = mTxtSTEAMCMD.Text;
            l.SplashScreen = mToogleShowSplash.Checked;
            if (!c.Validate())
            {
                MetroMessageBox.Show(this, Strings.sCfgInvalid, Strings.sError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //var langChanged = l.InterfaceLang != lc;
            l.InterfaceLang = lc;
            m.FirstRun = false;
            i.SaveConfig();
            MetroMessageBox.Show(this, Strings.sCfgSaved, Strings.sDone, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //if ( langChanged ) {
            //    MetroMessageBox.Show(this, Strings.sLangChanged, Strings.sDone, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            Application.Restart();
        }

        private void FrmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!AlertOnBadConfig())
                e.Cancel = true;
        }

        private void mBtnReset_Click(object sender, EventArgs e)
        {
            //var lc = ((Langs)mComboLang.SelectedItem).LangCode;
            //var i = CoreHandler.Instance;
            //i.Config = new Config();
            //var l = c.Interface;
            //var m = i.Config.Misc;
            var lc = ((Langs)mComboLang.SelectedItem).LangCode;
            var i = CoreHandler.Instance;
            var c = i.Config;
            var m = c.Misc;
            var l = c.Interface;
            m.FirstRun = true;
            m.LicensesAccepted = false;
            l.SplashScreen = true;
            i.SaveConfig();
            LoadConfig();
            MetroMessageBox.Show(this, Strings.sReset, Strings.sDone, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Restart();
        }
 
    }
}
