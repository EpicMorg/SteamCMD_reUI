using System.Xml.Serialization;

namespace SteamCMD_reGUI_Core.Configs
{
    public class Server : IValidatable {
          
        // ReSharper disable once FunctionRecursiveOnAllPaths
        public Server() {
        } 

        [XmlText]
        public string ServerName
        {
            get;
            set;
        }

        [XmlAttribute]
        public int AppId
        {
            get;
            set;
        }
        [XmlAttribute]
        public string ModName
        {
            get;
            set;
        }
        [XmlAttribute]
        public bool AnonLogin
        {
            get;
            set;
        }
        [XmlAttribute]
        public bool Purchased { get; set; }

        public override string ToString() => ServerName;
        public bool Validate() => true;
    }
}
