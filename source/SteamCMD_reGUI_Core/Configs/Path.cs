using System;
using System.IO;

namespace SteamCMD_reGUI_Core.Configs
{
    public class Paths : IValidatable
    {
        public Paths() { 
            SteamCmdPath = Path.Combine(Locator.GetExeDir, "steamcmd.exe");
            DefaultOutputDir = Locator.GetExeDir;
        }

        public string SteamCmdPath
        {
            get;
            set;
        }

        public string DefaultOutputDir
        {
            get;
            set;
        }

        public bool Validate() {
            return ValidatePath(SteamCmdPath) & ValidatePath(DefaultOutputDir);
            
        }

        private static bool ValidatePath(string a)
        {
            try
            {
                // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
                Path.GetFullPath(a);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}