using System; 
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

        public bool Validate() {
            throw new NotImplementedException(); 
        }
    }
}
