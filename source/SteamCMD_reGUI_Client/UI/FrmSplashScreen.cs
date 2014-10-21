using System;
using System.Reflection;
using System.Windows.Forms;
using SteamCMD_reGUI_Client.LOCALE;
using SteamCMD_reGUI_Client.WRAPPER;

namespace SteamCMD_reGUI_Client.UI
{    
    public partial class FrmSplashScreen : Form
    {
        int _time1;
        public FrmSplashScreen()
        {
            InitializeComponent();
            cstmLblWait.Text = Strings.sLoading;
        }

        #region
        private static string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        private static string AssemblyProduct
        {
            get
            {
                var attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                return attributes.Length == 0 ? "" : ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }
        #endregion
     
        private void Check() {
            if (!CoreHandler.Instance.Config.Misc.LicensesAccepted)
            {
                var frmLicAccept = new FrmLicAccept();
                this.Hide();
                frmLicAccept.ShowDialog();
                this.Close();
            }
            else
            {
                if (CoreHandler.Instance.Config.Misc.FirstRun)
                {
                    var frmLicSettings = new FrmSettings();
                    this.Hide();
                    frmLicSettings.ShowDialog();
                    this.Close();
                }
                else
                {
                    var frmLicMain = new FrmMain();
                    this.Hide();
                    frmLicMain.ShowDialog();
                    this.Close();
                }
            }
        }
        private void FrmSplashScreen_Load(object sender, EventArgs e)
        {
            cstmLblName.Text  = String.Format("{0}", AssemblyProduct);
            cstmLblVersion.Text = String.Format("{0}", AssemblyVersion);
        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            Check();
        } 
    }
}
