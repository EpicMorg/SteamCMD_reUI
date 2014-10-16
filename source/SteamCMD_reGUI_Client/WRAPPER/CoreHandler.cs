using System;
using System.IO; 
using SteamCMD_reGUI_Core.Configs;

namespace SteamCMD_reGUI_Client.WRAPPER
{
    internal class CoreHandler
    {
        #region Singleton
        private static readonly Lazy<CoreHandler> InstanceLazy = new Lazy<CoreHandler>(() => new CoreHandler());

        public static CoreHandler Instance
        {
            get
            {
                return InstanceLazy.Value;
            }
        }
        #endregion

        private const string ConfigName = "config.xml";
        private readonly string _configPath;

        private CoreHandler() {
            var exePath = Locator.GetExeDir; 
            _configPath = Path.Combine(exePath, ConfigName);
            Config = Config.Load(_configPath);
            SaveConfig();
        }

        public Config Config
        {
            get;
            set;
        }

        public void SaveConfig() { Config.Save(_configPath); }
    }
}
