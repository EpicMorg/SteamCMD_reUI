﻿ 
using System.Windows.Forms; 
using MetroFramework.Forms;

namespace SteamCMD_reUI_Client.UI
{
    public static class MetroFormExtensions
    {
        public static DialogResult MetroMessageBox( this MetroForm form, string message, string title, MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.None ) =>
            MetroFramework.MetroMessageBox.Show( form, message, title, buttons, icon );
    }
}
