using System;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using SteamCMD_reGUI_Client.LOCALE;
using SteamCMD_reGUI_Client.WRAPPER;

namespace SteamCMD_reGUI_Client.UI {
    public partial class FrmDownloader : SettableForm {
        public FrmDownloader() { InitializeComponent(); }

        private async void FrmDownloader_Load( object sender, EventArgs e ) => await Download();

        public void LoadConfig()
        { 
           
        }

        public async Task Download() {
            if ( saveFileDialog.ShowDialog() != DialogResult.OK ) { 
                Close();
                return;
            }
            var steamCmdPathfull = saveFileDialog.FileName;
            var webClient = new WebClient();
            webClient.DownloadFileCompleted += Completed;
            webClient.DownloadProgressChanged += ProgressChanged;
            try
            {
                    await webClient.DownloadFileTaskAsync( new Uri( "http://media.steampowered.com/installer/steamcmd.zip" ), steamCmdPathfull );
            }
            catch {
                try
                {
                    await
                        webClient.DownloadFileTaskAsync(
                            new Uri("https://mirror.epicm.org/pub/steamcmd/steamcmd.zip"), steamCmdPathfull);
                }
                catch (Exception ex)
                {
                    this.MetroMessageBox(ex.Message, Strings.sError, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
        }

        private void ProgressChanged( object sender, DownloadProgressChangedEventArgs e ) => metroProgressBar.Value = e.ProgressPercentage;
        private void Completed( object sender, AsyncCompletedEventArgs e ) {
            this.MetroMessageBox( Strings.sDownloadingComplete + Environment.NewLine + Strings.sUnpacking, Strings.sDone, MessageBoxButtons.OK, MessageBoxIcon.Information );
            Unpack();
        }

        public async void Unpack() {
            Text = Strings.sUnpacking;
            var zipfile = saveFileDialog.FileName;
            var targetpath = Path.GetDirectoryName( zipfile );
            var exefile = Path.Combine(zipfile).Replace("steamcmd.zip", "steamcmd.exe");
            if (File.Exists(zipfile))
            {
                try
                {
                    ZipFile.ExtractToDirectory(zipfile, targetpath);
                    this.MetroMessageBox(Strings.sUnpackingComplete, Strings.sDone, MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex);
                }

            }
            else
            {
                if (this.MetroMessageBox(Strings.sCheckZip, Strings.sError, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    await Download();
                }
            }
            Close();
           if (File.Exists(exefile))
            {
                CoreHandler.Instance.Config.Paths.SteamCmdPath = exefile;
                CoreHandler.Instance.SaveConfig();
                MetroMessageBox.Show(this, Strings.sCfgSaved, Strings.sDone, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }
            Text = Strings.sDone;
        }
    }
}