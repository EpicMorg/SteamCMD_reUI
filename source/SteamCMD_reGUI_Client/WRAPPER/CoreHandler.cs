using System;
using System.IO;
using SteamCMD_reGUI_Core.Configs;

namespace SteamCMD_reGUI_Client.WRAPPER {
    internal class CoreHandler {
        #region Singleton
        private static readonly Lazy<CoreHandler> InstanceLazy = new Lazy<CoreHandler>( () => new CoreHandler() );

        public static CoreHandler Instance => InstanceLazy.Value;
        #endregion
        private const string ServersName = "servers.xml";
        private const string ConfigName = "config.xml";
        private readonly string _configPath;

        private CoreHandler() {
            _configPath = Path.Combine( Locator.GetExeDir, ConfigName );
            Config = Config.Load( _configPath );
            Servers = Formatter<ServerList>.Deserialize( Path.Combine( Locator.GetExeDir, ServersName ) )??new ServerList { };
            SaveConfig();
        }

        public Config Config { get; set; }

        public ServerList Servers { get; set; }

        public void SaveConfig() { Config.Save( _configPath ); }
    }
}