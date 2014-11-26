using System.Xml.Serialization;
using MetroFramework;

namespace SteamCMD_reGUI_Core.Configs
{
    public class Theme
    {
        public Theme() { }
        public Theme(MetroThemeStyle theme = MetroThemeStyle.Dark)
        {
            ThemeCode = theme;
        }
        [XmlAttribute]
        public MetroThemeStyle ThemeCode
        {
            get;
            set;
        }
        public override string ToString() => ThemeCode.ToString();
    }
}
