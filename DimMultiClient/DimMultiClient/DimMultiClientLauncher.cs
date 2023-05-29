using DimMultiClient;
using Microsoft.Web.WebView2.Core;
using System.Reflection;
using TsadriuUtilities;
using TsadriuUtilities.Csv.CsvObjects;

namespace DimMultiClient
{
    public partial class DimMultiClientLauncher : Form
    {
        public static readonly string CurrentDirectory = Path.GetPathRoot(Environment.CurrentDirectory) ?? Directory.GetCurrentDirectory();
        public static readonly string ProgramStorage = Path.Combine(CurrentDirectory, "Dim MultiClient");
        public static readonly string ProgramNetworkStorage = Path.Combine(ProgramStorage, "Network Data");
        public static readonly string ProfilesDirectory = Path.Combine(ProgramStorage, "Profile");
        public static readonly string ProfilesFile = Path.Combine(ProfilesDirectory, "profiles.txt");
        public static readonly string newsLink = "https://universe.flyff.com/news";
        public static readonly int defaultWidth = 800;
        public static readonly int defaultHeight = 600;
        public static TTable usersInFile = new TTable();
        public static ICsvTable userTable;
        private List<DimClient> _clientList = new List<DimClient>();

        public DimMultiClientLauncher()
        {
            InitializeComponent();
            AssignUsers();
            Text += Program.GetVersionAsString();
        }

        private void AssignUsers()
        {
            if (!Directory.Exists(ProfilesDirectory))
            {
                Directory.CreateDirectory(ProfilesDirectory);
            }

            var x = new CsvTable(new string[] { });

            if (!File.Exists(ProfilesFile))
            {
                usersInFile.AddColumn("Profile", "Last Login", "Width", "Height");
                return;
            }

            usersInFile.CsvToTable(ProfilesFile);

            if (usersInFile.GetColumn("User") != null)
            {
                usersInFile.RenameColumn("User", "Profile");
            }

            selectUserInput.Items.AddRange(usersInFile.GetData("Profile").ToArray());
        }

        private async void playButton_Click(object sender, EventArgs e)
        {
            string currentUser = selectUserInput.Text.ToLower();

            if (currentUser.IsNotEmpty())
            {
                SaveCurrentUser();
                var selectedWidth = widthInput.Text.ToInt().ClampValue(defaultWidth, Screen.FromControl(this).Bounds.Width);
                var selectedHeight = heightInput.Text.ToInt().ClampValue(defaultHeight, Screen.FromControl(this).Bounds.Height);
                bool isFullScreen = fullScreenCheckBox.Checked;
                var flyff = new DimClient(currentUser, selectedWidth, selectedHeight, isFullScreen);
                await flyff.LaunchGame();
                _clientList.Add(flyff);
            }
        }

        private void SaveCurrentUser()
        {
            string user = selectUserInput.Text.ToLower();

            if (!usersInFile.ExistsData("Profile", user))
            {
                usersInFile.AddData("Profile", user);
                usersInFile.AddData("Last Login", DateTime.Now);
                usersInFile.AddData("Width", widthInput.Text.IsEmpty() ? defaultWidth : widthInput.Text);
                usersInFile.AddData("Height", heightInput.Text.IsEmpty() ? defaultHeight : heightInput.Text);
                File.WriteAllLines(ProfilesFile, usersInFile.TableToCsv());
                selectUserInput.Items.Clear();
                selectUserInput.Items.AddRange(usersInFile.GetData("Profile").ToArray());
            }
            else
            {
                widthInput.Text = widthInput.Text.IsEmpty() ? defaultWidth.ToString() : widthInput.Text;
                heightInput.Text = heightInput.Text.IsEmpty() ? defaultHeight.ToString() : heightInput.Text;
                var userIndex = usersInFile.GetColumn("Profile").ColumnData.FindIndex(x => x.Equals(user));
                usersInFile.GetColumn("Width").ColumnData[userIndex] = widthInput.Text;
                usersInFile.GetColumn("Height").ColumnData[userIndex] = heightInput.Text;

                File.WriteAllLines(ProfilesFile, usersInFile.TableToCsv());
            }
        }

        private void selectUserInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            widthInput.Text = usersInFile.GetData("Width")[selectUserInput.SelectedIndex].ToString();
            heightInput.Text = usersInFile.GetData("Height")[selectUserInput.SelectedIndex].ToString();
        }

        private void selectUserInput_TextChanged(object sender, EventArgs e)
        {
            if (!usersInFile.ExistsData("Profile", selectUserInput.Text.ToLower()))
            {
                widthInput.Text = defaultWidth.ToString();
                heightInput.Text = defaultHeight.ToString();
            }
        }

        private void closeAllLauncherButton_Click(object sender, EventArgs e)
        {
            foreach (DimClient launcher in _clientList)
            {
                launcher.Close();
            }

            _clientList.Clear();
        }

        private void adaptScreenSizeButton_Click(object sender, EventArgs e)
        {
            widthInput.Text = Screen.FromControl(this).Bounds.Width.ToString();
            heightInput.Text = Screen.FromControl(this).Bounds.Height.ToString();
        }
    }
}