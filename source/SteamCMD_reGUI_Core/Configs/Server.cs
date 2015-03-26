using System.Xml.Serialization;

namespace SteamCMD_reGUI_Core.Configs
{
    public class Server : IValidatable {
          
        // ReSharper disable once FunctionRecursiveOnAllPaths
  
        [XmlText]
        public string server
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
        public bool MustBePurchased
		{
			get; set;
		}
		[XmlAttribute]
		public bool SteamClientRequered
		{
			get; set;
		}

		[XmlAttribute]
		public string WarningMessage
		{
			get;
			set;
		}


		public override string ToString() => server;
        public bool Validate() => true;
    }
}
