using DimMultiClient;
using Microsoft.Web.WebView2.Core;
using TsadriuUtilities;

namespace DimMultiClient
{
    public partial class DimClient : Form
    {
        private readonly string dimLink = "https://app.destinyitemmanager.com/";
        private string currentUser = string.Empty;
        private bool isFullScreen = false;

        public DimClient(string windowName, int width, int height, bool isFullScreen)
        {
            InitializeComponent();
            dimMenuStrip.Visible = false;
            SetWindowProperties(windowName, width, height, isFullScreen);
            Task.Run(LaunchGame);
        }

        /// <summary>
        /// Called when the window receives input.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="keyEvent">Current event.</param>
        private void webView_KeyDown(object sender, KeyEventArgs keyEvent)
        {
            if (keyEvent.KeyCode == Keys.Home)
            {
                dimMenuStrip.Visible = !dimMenuStrip.Visible;
            }

            if (keyEvent.KeyCode == Keys.F11)
            {
                if (isFullScreen)
                {
                    isFullScreen = false;
                    FormBorderStyle = FormBorderStyle.Sizable;
                    WindowState = FormWindowState.Normal;
                    CenterToScreen();
                    return;
                }

                isFullScreen = true;
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                CenterToScreen();
            }
        }

        /// <summary>
        /// Custom event that is called when the window is resized.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">Current event.</param>
        private void ResizeWebView(object? sender, EventArgs e)
        {
            webView.Size = ClientSize - new Size(webView.Location);
        }

        /// <summary>
        /// Sets the window's properties, such as the window name, size and location.
        /// </summary>
        /// <param name="profileName">The profile user's name.</param>
        /// <param name="width">Width of the window.</param>
        /// <param name="height">Height of the window.</param>
        /// <param name="isFullScreen">Should this app start in full screen or not.</param>
        private void SetWindowProperties(string profileName, int width, int height, bool isFullScreen)
        {
            StartPosition = Program.Launcher.StartPosition;
            currentUser = profileName;
            Size = new Size(width, height);
            Text += $"{Program.GetVersionAsString()} - {profileName.LetterUpperCase()}";
            Resize += new EventHandler(ResizeWebView);
            Location = Program.Launcher.Location;

            // Resize the window.
            ResizeWebView(this, EventArgs.Empty);
            webView_KeyDown(this, isFullScreen ? new KeyEventArgs(Keys.F11) : new KeyEventArgs(Keys.None));
        }

        /// <summary>
        /// Task that launches a web request to load the game.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public async Task LaunchGame()
        {
            var directory = Path.Combine(DimMultiClientLauncher.ProgramNetworkStorage, currentUser);
            var webViewEnvironment = await CoreWebView2Environment.CreateAsync(string.Empty, directory);
            await webView.EnsureCoreWebView2Async(webViewEnvironment);
            webView.Source = new Uri(dimLink);
            webView.CoreWebView2.Settings.UserAgent = "Chrome/103.0.0.0";
            webView.CoreWebView2.Settings.AreBrowserAcceleratorKeysEnabled = false;
            Show();
        }

        private void reloadPageMenuItem_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.Reload();
        }

        private void hideToolbarMenuItem_Click(object sender, EventArgs e)
        {
            dimMenuStrip.Visible = false;
        }
    }
}
