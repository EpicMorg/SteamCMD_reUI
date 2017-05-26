﻿namespace SteamCMD_reUI_Core.Configs
{
    public class Misc : IValidatable
    {
        public Misc()
        {
            FirstRun = true;
            LicensesAccepted = false;
            Logging = false;
        }

        public bool FirstRun
        {
            get;
            set;
        }
        public bool Logging
        {
            get;
            set;
        }

        public bool LicensesAccepted
        {
            get;
            set;
        }

        public bool Validate() => true;
    }
}
