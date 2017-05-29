using System;
using System.Reflection;
using System.Threading.Tasks;
using MetroFramework.Components;
using MetroFramework.Forms;
using SteamCMD_reUI_Client.LOCALE;
using SteamCMD_reUI_Client.WRAPPER;

namespace SteamCMD_reUI_Client.UI {
    public partial class FrmSplashScreen : MetroForm
    {
        private static readonly Assembly CurrentAssembly = Assembly.GetExecutingAssembly();

        public FrmSplashScreen() {
            var iface = CoreHandler.Instance.Config.Interface;
            var sm = new MetroStyleManager();
            sm.Owner = this;
            StyleManager = sm;
            Style = sm.Style = iface.Style;
            Theme = sm.Theme = iface.Theme;
            SuspendLayout();
            InitializeComponent();
            metroLabelLoading.Text = Strings.sLoading;

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
            Text = metroLabelProduct.Text = String.Format( "{0}", AssemblyProduct );
            metroLabelVersion.Text = String.Format( "{0}", AssemblyVersion );
            await Task.Delay( 3500 );
            Check();
            Focus();
            Activate();
        }

		private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
		{

		}
	}
}