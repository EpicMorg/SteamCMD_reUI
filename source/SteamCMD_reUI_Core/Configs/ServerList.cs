using System;
using System.Xml.Serialization;

namespace SteamCMD_reUI_Core.Configs
{   [XmlRoot("Servers")]
    public class ServerList
    {
        public Meta Meta { get; set; }
        public Server[] List { get; set; }


    }

    public class Meta
    {
        public string Version { get; set; }

        [XmlElement(DataType = "date")]
        public DateTime Date { get; set; }
        
        public string Author { get; set; }

        public string Comment { get; set; }
    }
}
