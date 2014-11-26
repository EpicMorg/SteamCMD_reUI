using System;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using SteamCMD_reGUI_Client.LOCALE; 

namespace SteamCMD_reGUI_Client.UI {
    public partial class FrmDownloader : SettableForm {
        public FrmDownloader() { InitializeComponent(); }

        private async void FrmDownloader_Load( object sender, EventArgs e ) => await Download();

        private async Task Download() {
            if ( saveFileDialog.ShowDialog() != DialogResult.OK ) { 
                Close();
                return;
            }
            var steamCmdPathfull = saveFileDialog.FileName;
            try {
                using ( var webClient = new WebClient() ) {
                    webClient.DownloadFileCompleted += Completed;
                    webClient.DownloadProgressChanged += ProgressChanged;
                    await webClient.DownloadFileTaskAsync( new Uri( "http://media.steampowered.com/installer/steamcmd.zip" ), steamCmdPathfull );
                }
            }
            catch ( Exception ex ) {
                this.MetroMessageBox( ex.Message, Strings.sError, MessageBoxButtons.OK, MessageBoxIcon.Information );
                Close();
            }
        }

        private void ProgressChanged( object sender, DownloadProgressChangedEventArgs e ) => metroProgressBar.Value = e.ProgressPercentage;
        private void Completed( object sender, AsyncCompletedEventArgs e ) {
            this.MetroMessageBox( Strings.sDownloadingComplete + Environment.NewLine + Strings.sUnpacking, Strings.sDone, MessageBoxButtons.OK, MessageBoxIcon.Information );
            Unpack();
        }

        private void Unpack() {
            Text = Strings.sUnpacking;
            var zipfile = saveFileDialog.FileName;
            var targetpath = Path.GetDirectoryName( zipfile );
            if ( File.Exists( zipfile ) ) {
                ZipFile.ExtractToDirectory( zipfile, targetpath );
                this.MetroMessageBox( Strings.sUnpackingComplete, Strings.sDone, MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
            else {
                Text = Strings.sError;
            }
            Close();
            Text = Strings.sDone;
        }
    }
}