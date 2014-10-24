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

        private async void FrmDownloader_Load( object sender, EventArgs e ) { await Download(); }

        public async Task Download() {
            if ( saveFileDialog.ShowDialog() != DialogResult.OK )
                this.Close();
            else {
                var steamCmdPathfull = saveFileDialog.FileName;
                //var steamCmdPathfull = Path.Combine( Path.GetDirectoryName( CoreHandler.Instance.Config.Paths.SteamCmdPath ), "steamcmd.zip" ); 
                try {
                    var webClient = new WebClient();
                    webClient.DownloadFileCompleted += Completed;
                    webClient.DownloadProgressChanged += ProgressChanged;
                    await webClient.DownloadFileTaskAsync( new Uri( "http://media.steampowered.com/installer/steamcmd.zip" ), steamCmdPathfull );
                }
                catch ( Exception ex ) {
                    this.MetroMessageBox( ex + "", Strings.sError, MessageBoxButtons.OK, MessageBoxIcon.Information );
                    this.Close();
                }
            }
        }

        private void ProgressChanged( object sender, DownloadProgressChangedEventArgs e ) { metroProgressBar.Value = e.ProgressPercentage; }

        private void Completed( object sender, AsyncCompletedEventArgs e ) {
            this.MetroMessageBox( Strings.sDownloadingComplete + Environment.NewLine + Strings.sUnpacking, Strings.sDone, MessageBoxButtons.OK, MessageBoxIcon.Information );
            Unpack();
        }

        private void Unpack() {
            this.Text = Strings.sUnpacking;
            //var ch = CoreHandler.Instance.Config.Paths.SteamCmdPath;
            //var steamCmdPathZip = ch.Replace("steamcmd.exe", "steamcmd.zip");
            var zipfile = saveFileDialog.FileName;
            var targetpath = Path.GetDirectoryName( zipfile );
            if ( File.Exists( zipfile ) ) {
                ZipFile.ExtractToDirectory( zipfile, targetpath );
                this.MetroMessageBox( Strings.sUnpackingComplete, Strings.sDone, MessageBoxButtons.OK, MessageBoxIcon.Information );
                this.Close();
            }
            else {
                this.Text = Strings.sError;
                this.Close();
            }
            this.Text = Strings.sDone;
        }
    }
}