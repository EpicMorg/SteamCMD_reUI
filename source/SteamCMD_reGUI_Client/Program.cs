using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using SteamCMD_reGUI_Client.UI;
using SteamCMD_reGUI_Client.WRAPPER; 

namespace SteamCMD_reGUI_Client
{
    static class Program
    { 
        [STAThread]
        static void Main() { 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if ( !CoreHandler.Instance.Config.Interface.SplashScreen ) {
                CheckIt();
            }
            else {
                Application.Run(new FrmSplashScreen());
            }
            LoadLocale();
        } 

        public static void CheckIt()
        {
             if ( !CoreHandler.Instance.Config.Misc.LicensesAccepted ) {
                Application.Run(new FrmLicAccept());
            }
            else {
                if (CoreHandler.Instance.Config.Misc.FirstRun ) {
                        Application.Run(new FrmSettings()); 
                }
                else { 
                Application.Run(new FrmMain());
                } 
            }
        }
       
        private static void LoadLocale()
        {
            var loc = CoreHandler.Instance.Config.Interface.InterfaceLang;
            if (String.IsNullOrEmpty(loc))
                return;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(loc);
        }
    }
}
