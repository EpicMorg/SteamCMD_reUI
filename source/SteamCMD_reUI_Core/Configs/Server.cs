using System.Xml.Serialization;

namespace SteamCMD_reUI_Core.Configs
{
    public class Server : IValidatable {
            
        [XmlText] 
        public string Name
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


		public override string ToString() => Name;
        public bool Validate() => true;
    }
}
