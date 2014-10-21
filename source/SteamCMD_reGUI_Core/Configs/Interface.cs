using System.Globalization;
using MetroFramework;

namespace SteamCMD_reGUI_Core.Configs {
    public class Interface : IValidatable {
        public Interface() {
            InterfaceLang = "en-US";
            SplashScreen = true;
        }

        public string InterfaceLang {
            get;
            set;
        }

        public bool SplashScreen {
            get;
            set;
        }

        public bool Validate() {
            try {
                CultureInfo.GetCultureInfo( InterfaceLang );
                return true;
            }
            catch {
                return false;
            }
        }
        public MetroThemeStyle Theme { get; set; }
        public MetroColorStyle Style { get; set; }
    }
}