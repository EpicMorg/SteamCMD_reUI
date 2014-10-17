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
            mComboAppStyle.Items.Clear();
            //this.Style = MetroColorStyle.Red;
            //this.Theme = MetroThemeStyle.Light;
            var langs = new Langs[] {
                new Langs {
                    LangName = Strings.sEnglish, LangCode = "en-US"
                },
                new Langs {
                    LangName = Strings.sRussian, LangCode = "ru-RU"
                }
            };
            mComboLang.Items.AddRange(langs);
            var cfg = CoreHandler.Instance.Config;
            var intf = cfg.Interface;
            var cl = intf.InterfaceLang; 
            mComboLang.SelectedIndex = String.IsNullOrEmpty(cl) ? 0 : langs.Select((a, i) => new { a, i }).First(a => a.a.LangCode == cl).i;
            var styles = new Style[] {
                new Style {
                   StyleName = "Black", StyleCode = "MetroColorStyle.Black"
                },
                new Style {
                    
                     StyleName = "Blue", StyleCode = "MetroColorStyle.Blue"
                },
                new Style {
                   StyleName = "Brown", StyleCode = "MetroColorStyle.Brown"
                },
                new Style {
                    
                     StyleName = "Green", StyleCode = "MetroColorStyle.Green"
                },
                new Style {
                   StyleName = "Lime", StyleCode = "MetroColorStyle.Lime"
                },
                new Style {
                    
                     StyleName = "Magenta", StyleCode = "MetroColorStyle.Magenta"
                },
                new Style {
                   StyleName = "Orange", StyleCode = "MetroColorStyle.Orange"
                },
                new Style {
                    
                     StyleName = "Pink", StyleCode = "MetroColorStyle.Pink"
                },
                new Style {
                   StyleName = "Purple", StyleCode = "MetroColorStyle.Purple"
                },
                new Style {
                    
                     StyleName = "Red", StyleCode = "MetroColorStyle.Red"
                }, 
                new Style {
                   StyleName = "Silver", StyleCode = "MetroColorStyle.Silver"
                },
                new Style {
                    
                     StyleName = "Teal", StyleCode = "MetroColorStyle.Teal"
                },
                new Style {
                    
                     StyleName = "White", StyleCode = "MetroColorStyle.White"
                },
                new Style {
                   StyleName = "Yellow", StyleCode = "MetroColorStyle.Yellow"
                }
            };
            mComboAppStyle.Items.AddRange(styles);
            var allst = cfg.Style;
            var st = allst.StyleName;
            var sc = allst.StyleCode;
            mComboAppStyle.SelectedIndex = String.IsNullOrEmpty(st) ? 0 : styles.Select((a, i) => new { a, i }).First(a => a.a.StyleName == st).i;
            MessageBox.Show( sc );
        }

        private void FrmSettings_Load( object sender, EventArgs e ) { LoadConfig(); }

        // ReSharper disable once MemberCanBePrivate.Global
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
            var stc = ((Style)mComboAppStyle.SelectedItem).StyleCode;
            var stn = ((Style)mComboAppStyle.SelectedItem).StyleName;
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
            c.Style.StyleCode = stc;
            c.Style.StyleName = stn;
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
            var lc = ((Langs)mComboLang.SelectedItem).LangCode;
            var stc = ((Style)mComboAppStyle.SelectedItem).StyleCode;
            var stn = ((Style)mComboAppStyle.SelectedItem).StyleName;
            var i = CoreHandler.Instance;
            var c = i.Config;
            var m = c.Misc;
            var l = c.Interface;
            c.Style.StyleCode = stc;
            c.Style.StyleName = stn;
            m.FirstRun = true;
            m.LicensesAccepted = false;
            l.SplashScreen = true;
            i.SaveConfig();
            LoadConfig();
            MetroMessageBox.Show(this, Strings.sReset, Strings.sDone, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Restart();
        }

        private void mBtnBrowse_Click(object sender, EventArgs e) { 
            if (fileBrowser.ShowDialog() != DialogResult.OK)
                return;
            mTxtSTEAMCMD.Text = fileBrowser.FileName;
        }
 
    }
}
