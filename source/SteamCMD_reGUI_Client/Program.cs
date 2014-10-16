using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using SteamCMD_reGUI_Client.UI;
using SteamCMD_reGUI_Client.WRAPPER;
using SteamCMD_reGUI_Core.Configs;

namespace SteamCMD_reGUI_Client
{
    static class Program
    { 
        [STAThread]
        static void Main() { 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CheckIt();
        } 

        private static void CheckIt()
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
            var loc = CoreHandler.Instance.Config.Misc.InterfaceLang;
            if (String.IsNullOrEmpty(loc))
                return;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(loc);
        }
    }
}
