using System;
using System.IO;
using System.Reflection;

namespace SteamCMD_reUI_Core.Configs
{
    public static class Locator
    {
        private static readonly Lazy<string> GetExeDirLazy = new Lazy<string>(GetDirectoryName);
        private static string GetDirectoryName() => Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        public static string GetExeDir => GetExeDirLazy.Value;
    }
}
