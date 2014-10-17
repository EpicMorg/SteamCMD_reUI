using System.Xml.Serialization;

namespace SteamCMD_reGUI_Core.Configs
{
    public class Style
    { 
        public Style() {
            StyleName = "Sylver";
            StyleCode = "MetroColorStyle.Silver";
        }
       [XmlAttribute]
        public string StyleName
        {
            get;
            set;
        }
        [XmlAttribute]
        public string StyleCode
        {
            get;
            set;
        }
        public override string ToString() { return this.StyleName; }
    }
}
