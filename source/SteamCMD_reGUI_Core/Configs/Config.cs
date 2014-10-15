using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace SteamCMD_reGUI_Core.Configs {
    [Serializable]
    public class Config : IValidatable {
        private static readonly Lazy<XmlSerializer> FormatterLazy = new Lazy<XmlSerializer>( () => new XmlSerializer( typeof( Config ) ) );

        public Config() {
            Misc = new Misc();
        }

        public Misc Misc {
            get;
            set;
        }

        private static XmlSerializer Formatter {
            get {
                return FormatterLazy.Value;
            }
        }

        public void Save( string path ) {
            using ( var f = File.Open( path, FileMode.OpenOrCreate, FileAccess.Write ) ) {
                f.SetLength( 0 );
                Formatter.Serialize( f, this );
            }
        }

        public static Config Load( string path ) {
            if ( File.Exists( path ) ) {
                using ( var f = File.OpenRead( path ) ) {
                    using ( var r = XmlReader.Create( f ) ) {
                        if ( Formatter.CanDeserialize( r ) )
                            return Formatter.Deserialize( r ) as Config;
                    }
                }
            }
            return new Config();
        }

        public bool Validate() { return Misc.Validate(); }
    }

}