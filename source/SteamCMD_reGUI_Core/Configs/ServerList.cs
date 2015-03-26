using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SteamCMD_reGUI_Core.Configs
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
