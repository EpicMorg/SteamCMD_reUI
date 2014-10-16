using System.Globalization;

namespace SteamCMD_reGUI_Core.Configs
{
    public class Misc : IValidatable
    {
        public Misc()
        {
            FirstRun = true;
            LicensesAccepted = false;
            InterfaceLang = "en-US";
        }

        public bool FirstRun
        {
            get;
            set;
        }

        public bool LicensesAccepted
        {
            get;
            set;
        }


        public string InterfaceLang
        {
            get;
            set;
        }

        public bool Validate()
        {
            try
            {
                CultureInfo.GetCultureInfo(InterfaceLang);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
