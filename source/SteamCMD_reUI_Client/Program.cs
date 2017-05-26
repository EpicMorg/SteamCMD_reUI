using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using SteamCMD_reUI_Client.UI;
using SteamCMD_reUI_Client.WRAPPER;

namespace SteamCMD_reUI_Client {
    internal static class Program {
        [STAThread]
        private static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoadLocale();
            if ( !CoreHandler.Instance.Config.Interface.SplashScreen )
                CheckIt();
            else
                Application.Run( new FrmSplashScreen() );
        }

        public static void CheckIt() {
            if (CoreHandler.Instance.Config.Misc.LicensesAccepted)
                Application.Run(CoreHandler.Instance.Config.Misc.FirstRun ? new FrmSettings() : (Form)new FrmSettings() );
            else
                Application.Run( new FrmLicAccept() );
        }

        private static void LoadLocale() {
            var loc = CoreHandler.Instance.Config.Interface.InterfaceLang;
            if (string.IsNullOrEmpty( loc ) )
                return;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo( loc );
        }
    }
}