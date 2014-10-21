using System.Globalization;
using System.Runtime.ConstrainedExecution;

namespace SteamCMD_reGUI_Core.Configs {
    public class Langs {
        public Langs( string code ) {
            var ci = CultureInfo.GetCultureInfo( code );
            this.LangCode = ci.Name;
            this.LangName = ci.DisplayName;
        }

        public string LangName {
            get;
            private set;
        }

        public string LangCode {
            get;
            private set;
        }

        public override string ToString() { return this.LangName; }
    }
}
