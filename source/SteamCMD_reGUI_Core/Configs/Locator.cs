using System; 
using System.IO; 
using System.Reflection; 

namespace SteamCMD_reGUI_Core.Configs
{
    public static class Locator
    {
        private static readonly Lazy<string> GetExeDirLazy = new Lazy<string>(GetDirectoryName);
        private static string GetDirectoryName() { return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location); }

        public static string GetExeDir
        {
            get { return GetExeDirLazy.Value; } 
        } 
    }
}
