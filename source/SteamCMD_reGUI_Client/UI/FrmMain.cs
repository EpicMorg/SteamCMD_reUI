using System;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MetroFramework;
using SteamCMD_reGUI_Client.LOCALE;
using SteamCMD_reGUI_Client.Properties;
using SteamCMD_reGUI_Client.WRAPPER;
using SteamCMD_reGUI_Core.Configs;

namespace SteamCMD_reGUI_Client.UI {
    public partial class FrmMain : SettableForm {
        bool _procStarted; 
        public FrmMain() {
            InitializeComponent();
            mTabsMain.SelectTab( mTabMain );
            mComboServers.DataSource = CoreHandler.Instance.Servers;
            mTileProcess.Text = Strings.sStartP;
            if ( Theme != MetroThemeStyle.Light ) {
                picLogo.Image = Resources.steam_light_128;
                picMF.Image = Resources.github_octocat_light;
                picAbout.Image = Resources.nyan_light;
            }
            if ( Style == MetroColorStyle.Black ) {
                mTileAbout.TileImage = Resources.nyan_light;
                mTileConsole.TileImage = Resources.console_light;
                mTileSettings.TileImage = Resources.settings_light;
                mTileProcess.TileImage = Resources.start_light;
            }
        }

        private void FrmMain_Load( object sender, EventArgs e ) {
            mLblProdName.Text = String.Format( "{0}", FrmSplashScreen.AssemblyProduct );
            mLblProdVer.Text = String.Format( "{0}", FrmSplashScreen.AssemblyVersion );
            Focus();
        }

        private void button3_Click( object sender, EventArgs e ) => new FrmDownloader().ShowDialog();

        private void mTabMain_Click( object sender, EventArgs e ) { }

        private void mLnkMF_Click( object sender, EventArgs e ) => Process.Start( "https://github.com/dennismagno/winforms-modernui/" );

        private void mLnkRG_Click( object sender, EventArgs e ) => Process.Start( "https://github.com/stamepicmorg/SteamCMD_reGUI/" );

        private void mLnkMIC_Click( object sender, EventArgs e ) => Process.Start( "https://github.com/Templarian/WindowsIcons/" );

        private void mTileConsole_Click( object sender, EventArgs e ) => mTabsMain.SelectTab( mTabConsole );

        private void mTileAbout_Click( object sender, EventArgs e ) => mTabsMain.SelectTab( mTabAbout );

        private void mTileSettings_Click( object sender, EventArgs e ) => new FrmSettings().ShowDialog();

        private void mTileProcess_Click( object sender, EventArgs e ) => StartPicCheck();

        private async void StartPicCheck() {
            SetExecState();
            try {
                var paths = CoreHandler.Instance.Config.Paths;
                var srv = mComboServers.SelectedItem as Server;
                if ( srv == null ) return;
                var args = BuildArgs( srv );
                using (var proc = new Process() {
                    StartInfo =
                        new ProcessStartInfo() {
                            Arguments = args,
                            CreateNoWindow = true,
                            RedirectStandardError = true,
                            RedirectStandardInput = true,
                            RedirectStandardOutput = true,
                            UseShellExecute = true,
                            FileName = paths.SteamCmdPath,
                            WorkingDirectory = paths.DefaultOutputDir,
                            WindowStyle = ProcessWindowStyle.Hidden,
                            StandardErrorEncoding = Encoding.UTF8,
                            StandardOutputEncoding = Encoding.UTF8,
                            ErrorDialog = true,
                            ErrorDialogParentHandle = Handle
                        }
                }) {
                    var mrs = new ManualResetEvent(false);
                    proc.Exited += ( a, b ) => mrs.Set();
                    DataReceivedEventHandler procOnErrorDataReceived = ( a, b ) => mTxtConLog.Text += b.Data;
                    proc.ErrorDataReceived += procOnErrorDataReceived;
                    proc.OutputDataReceived += procOnErrorDataReceived;
                    proc.Start();
                    await Task.Run( (Action)(() => mrs.WaitOne()) );
                }
            }
            catch ( Exception ) {
                
                throw;
            }
            finally { 
                SetExecState();
            }
        }

        private string BuildArgs( Server srv ) {
            var sb = new StringBuilder();

            if ( srv.AnonLogin ) sb.Append( "+login anonymous" );
            else sb.AppendFormat( "+login {0} {1} ", mTxtLogin.Text, mTxtPassword.Text );

            sb.AppendFormat( "+app_update {0} ", srv.AppId );

            if ( !string.IsNullOrWhiteSpace( srv.ModName ) ) sb.AppendFormat( "mod {0} ", srv.ModName );

            sb.AppendFormat( "+force_install_dir {0} ", CoreHandler.Instance.Config.Paths.DefaultOutputDir );

            sb.AppendFormat( "+app_set_config {0} ", srv.AppId );

            if ( mToggleValidate.Checked ) sb.Append( "+validate " );

            sb.Append( "+quit" );

            return sb.ToString();
        }

        private void SetExecState() {
            _procStarted ^= true;
            mTileProcess.Enabled = !_procStarted;
            mTileProcess.Text = _procStarted ? Strings.sStopP : Strings.sStartP;
            if ( Style != MetroColorStyle.Black ) mTileProcess.TileImage = _procStarted ? Resources.stop_dark : Resources.start_dark;
            else mTileProcess.TileImage = _procStarted ? Resources.stop_light : Resources.start_light;
        }

        private void mComboServers_SelectedIndexChanged( object sender, EventArgs e ) {
            var srv = mComboServers.SelectedItem as Server;
            if ( srv == null ) return;
            mTxtLogin.Enabled = mTxtPassword.Enabled = !srv.AnonLogin;
        }
    }
}