namespace SteamCMD_reGUI_Core.Configs {
    public class Langs {
        public string LangName {
            get;
            set;
        }

        public string LangCode {
            get;
            set;
        }

        public override string ToString() { return this.LangName; }
    }
}
