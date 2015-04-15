using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace SteamCMD_reGUI_Client_WpfControls
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class WpfMediaControl : UserControl
    {
        public WpfMediaControl()
        {
            InitializeComponent();
			try
			{
				WpfMediaElement.Source = new Uri(Directory.GetCurrentDirectory() + "\\MEDIA\\steam_logo.mp4");
				WpfMediaElement.LoadedBehavior = MediaState.Manual;
				WpfMediaElement.Play();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				Console.WriteLine(ex);
			}
		}
    }
}
