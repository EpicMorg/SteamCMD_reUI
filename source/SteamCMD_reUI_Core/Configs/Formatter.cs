using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace SteamCMD_reUI_Core.Configs {
    public static class Formatter<TEntity> where TEntity : class {
        private static readonly Lazy<XmlSerializer> FormatterLazy = new Lazy<XmlSerializer>( () => new XmlSerializer( typeof( TEntity ) ) );

        public static void Serialize( string file, TEntity entity ) {
            using ( TextWriter stream = new StreamWriter( file ) )
                FormatterLazy.Value.Serialize( stream, entity );
        }

        public static TEntity Deserialize( string file ) {
            if ( File.Exists( file ) ) {
                using ( var f = File.OpenRead( file ) ) {
                    using ( var r = XmlReader.Create( f ) ) {
                        if ( FormatterLazy.Value.CanDeserialize( r ) )
                            return FormatterLazy.Value.Deserialize( r ) as TEntity;
                    }
                }
            }
            return null;
        }
    }
}