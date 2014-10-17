using System.Xml.Serialization;

namespace SteamCMD_reGUI_Core.Configs
{
    public class Theme
    {
        public Theme()
        {
            ThemeName = "Dark";
            ThemeCode = "MetroThemeStyle.Dark";
        }
        [XmlAttribute]
        public string ThemeName
        {
            get;
            set;
        }
        [XmlAttribute]
        public string ThemeCode
        {
            get;
            set;
        }
        public override string ToString() { return this.ThemeName; }
    }
}
