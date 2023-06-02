using Microsoft.Web.WebView2.Core;
using TsadriuUtilities;

namespace DimMultiClient
{
    public partial class DimClient : Form
    {
        private const string DimLink = "https://app.destinyitemmanager.com/";
        private string _currentUser = string.Empty;
        private bool _isFullScreen;

        public DimClient(string currentUser, int clientWidth, int clientHeight, bool isClientFullScreen)
        {
            InitializeComponent();
            dimMenuStrip.Visible = false;
            SetWindowProperties(currentUser, clientWidth, clientHeight, isClientFullScreen);
            Task.Run(LaunchDimClient);
        }

        /// <summary>
        /// Called when the window receives input.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="keyEvent">Current event.</param>
        private void webView_KeyDown(object sender, KeyEventArgs keyEvent)
        {
            switch (keyEvent.KeyCode)
            {
                case Keys.Home:
                    dimMenuStrip.Visible = !dimMenuStrip.Visible;
                    break;
                case Keys.F11 when _isFullScreen:
                    _isFullScreen = false;
                    FormBorderStyle = FormBorderStyle.Sizable;
                    WindowState = FormWindowState.Normal;
                    CenterToScreen();
                    return;
                case Keys.F11:
                    _isFullScreen = true;
                    FormBorderStyle = FormBorderStyle.None;
                    WindowState = FormWindowState.Maximized;
                    CenterToScreen();
                    break;
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
        /// <param name="currentUser">The profile user's name.</param>
        /// <param name="clientWidth">Width of the window.</param>
        /// <param name="clientHeight">Height of the window.</param>
        /// <param name="isClientFullScreen">Should this app start in full screen or not.</param>
        private void SetWindowProperties(string currentUser, int clientWidth, int clientHeight, bool isClientFullScreen)
        {
            StartPosition = Program.Launcher.StartPosition;
            _currentUser = currentUser;
            Size = new Size(clientWidth, clientHeight);
            Text += $@"{Program.GetVersionAsString()} - {currentUser.LetterUpperCase()}";
            Resize += ResizeWebView;
            Location = Program.Launcher.Location;

            // Resize the window.
            ResizeWebView(null, EventArgs.Empty);
            webView_KeyDown(this, isClientFullScreen ? new KeyEventArgs(Keys.F11) : new KeyEventArgs(Keys.None));
        }

        /// <summary>
        /// Task that launches a web request to load the dim client.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public async Task LaunchDimClient()
        {
            string directory = Path.Combine(DimMultiClientLauncher.ProgramNetworkStorage, _currentUser);
            var webViewEnvironment = await CoreWebView2Environment.CreateAsync(string.Empty, directory);
            await webView.EnsureCoreWebView2Async(webViewEnvironment);
            webView.Source = new Uri(DimLink);

            // Set the agent to appear as a chrome browser
            webView.CoreWebView2.Settings.UserAgent = "Chrome/114.0.0.0";
            webView.CoreWebView2.Settings.AreBrowserAcceleratorKeysEnabled = false;

            // Display the window to the user
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

        private void closeClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
