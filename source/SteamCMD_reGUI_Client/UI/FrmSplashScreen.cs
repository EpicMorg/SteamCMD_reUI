using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using SteamCMD_reGUI_Client.LOCALE;
using SteamCMD_reGUI_Client.WRAPPER;
using SteamCMD_reGUI_Client_WpfControls;

namespace SteamCMD_reGUI_Client.UI {
    public partial class FrmSplashScreen : Form {
        private static readonly Assembly CurrentAssembly = Assembly.GetExecutingAssembly();

        public FrmSplashScreen() {
            InitializeComponent();
            cstmLblWait.Text = Strings.sLoading;

		}
        #region
        public static string AssemblyVersion => CurrentAssembly.GetName().Version.ToString();
        public static string AssemblyProduct {
            get {
                var attributes = CurrentAssembly.GetCustomAttributes( typeof( AssemblyProductAttribute ), false );
                return attributes.Length == 0 ? "" : ( (AssemblyProductAttribute) attributes[ 0 ] ).Product;
            }
        }
		#endregion
	

		private void Check() {
            if ( !CoreHandler.Instance.Config.Misc.LicensesAccepted ) {
                Hide();
                new FrmLicAccept().ShowDialog();
                Close();
            }
            else if ( CoreHandler.Instance.Config.Misc.FirstRun ) {
                Hide();
                new FrmSettings().ShowDialog();
                Close();
            }
            else {
                var frmLicMain = new FrmMain();
                Hide();
                frmLicMain.ShowDialog();
                Close();
            }
        }

        private async void FrmSplashScreen_Load( object sender, EventArgs e ) {
            cstmLblName.Text = String.Format( "{0}", AssemblyProduct );
            cstmLblVersion.Text = String.Format( "{0}", AssemblyVersion );
            await Task.Delay( 3500 );
            Check();
        }

		private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
		{

		}
	}
}