using System;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Xml;
using System.Xml.Serialization;

namespace SteamCMD_reGUI_Core.Configs {

    public class Config : IValidatable { 
        // ReSharper disable once MemberCanBePrivate.Global
        public Config() {
            Paths = new Paths();
            Misc = new Misc();
            Interface = new Interface();
        }
        public Interface Interface
        {
            get;
            set;
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public Paths Paths
        {
            get;
            set;
        }
 
        public Misc Misc {
            get;
            // ReSharper disable once MemberCanBePrivate.Global
            set;
        }
         
        public void Save( string path ) { 
            Formatter<Config>.Serialize( path,this );
        }

        public static Config Load( string path ) {
            return Formatter<Config>.Deserialize(path)??new Config();
        }

        public bool Validate() { return Paths.Validate() && Misc.Validate() && Interface.Validate(); }
    }

}