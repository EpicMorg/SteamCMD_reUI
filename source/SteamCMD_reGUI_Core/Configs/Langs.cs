using System.Globalization;
using System.Runtime.ConstrainedExecution;

namespace SteamCMD_reGUI_Core.Configs {
    public class Langs {
        public Langs( string code ) {
            var ci = CultureInfo.GetCultureInfo( code );
            LangCode = ci.Name;
            LangName = ci.DisplayName;
        }

        public string LangName {
            get; }

        public string LangCode {
            get;
            private set;
        }

        public override string ToString() => LangName;
    }
}
