using System;
using System.IO;

namespace SteamCMD_reGUI_Core.Configs
{
    public class Paths : IValidatable
    {
        public Paths()
        { 
            SteamCmdPath = ""; 
        }

        public string SteamCmdPath
        {
            get;
            set;
        }



        public bool Validate() {
            return ValidatePath( SteamCmdPath );
            
        }

        private static bool ValidatePath(string a)
        {
            try
            {
                Path.GetFullPath(a);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            //return ( Uri.IsWellFormedUriString( a, UriKind.RelativeOrAbsolute ));
        }
    }
}