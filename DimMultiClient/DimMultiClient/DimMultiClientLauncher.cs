using TsadriuUtilities;
using TsadriuUtilities.Csv.CsvObjects;
using TsadriuUtilities.Enums.StringHelper;

namespace DimMultiClient
{
    public partial class DimMultiClientLauncher : Form
    {
        private static readonly string CurrentDirectory = Path.GetPathRoot(Environment.CurrentDirectory) ?? Directory.GetCurrentDirectory();
        private static readonly string ProgramStorage = Path.Combine(CurrentDirectory, "Dim MultiClient");
        public static readonly string ProgramNetworkStorage = Path.Combine(ProgramStorage, "Network Data");
        private static readonly string ProfilesDirectory = Path.Combine(ProgramStorage, "Profile");
        private static readonly string OldProfilesFile = Path.Combine(ProfilesDirectory, "profiles.txt");
        private static readonly string NewProfilesFile = Path.Combine(ProfilesDirectory, "profiles.csv");
        private static ICsvTable _profilesTable = new CsvTable();
        private List<DimClient> _clientList = new List<DimClient>();

        /// <summary>
        /// Initializes a new instance of the <b><see cref="DimMultiClientLauncher"/></b> class.
        /// </summary>
        public DimMultiClientLauncher()
        {
            InitializeComponent();
            AssignUsersToComboBox();
            Text += Program.GetVersionAsString();
        }
        private static int DefaultWidth { get => 800; }
        private static int DefaultHeight { get => 600; }


        /// <summary>
        /// Checks if there is a profile file. If there is one, the <b><see cref="ComboBox"/></b> will contain the profiles' names in it.
        /// </summary>
        private void AssignUsersToComboBox()
        {
            if (!Directory.Exists(ProfilesDirectory))
            {
                Directory.CreateDirectory(ProfilesDirectory);
            }

            bool hasSetupData = false;

            // If the old profiles file exists, replace it with the new format
            if (File.Exists(OldProfilesFile))
            {
                _profilesTable = new CsvTable(File.ReadAllText(OldProfilesFile).SplitBy(SplitType.EnvironmentNewLine), ";");
                _profilesTable["Width"].Name = "Preferred Width";
                _profilesTable["Height"].Name = "Preferred Height";
                _profilesTable.AddColumn("Is Full Screen");
                _profilesTable["Is Full Screen"].AddRow("0");
                File.Delete(OldProfilesFile);
                File.WriteAllLines(NewProfilesFile, _profilesTable.ToList());
                hasSetupData = true;
            }

            if (File.Exists(NewProfilesFile))
            {
                _profilesTable = new CsvTable(File.ReadAllText(NewProfilesFile).SplitBy(SplitType.EnvironmentNewLine), ";");
                hasSetupData = true;
            }

            if (!hasSetupData)
            {
                _profilesTable = new CsvTable(new CsvColumn("Profile"), new CsvColumn("Last login"),
                    new CsvColumn("Preferred Width"), new CsvColumn("Preferred Height"),
                    new CsvColumn("IsFullScreen"));
            }

            foreach (string? profile in _profilesTable["Profile"].RowList.Where(profile => !string.IsNullOrEmpty(profile)))
            {
                if (profile != null)
                {
                    selectUserInput.Items.Add(profile);
                }
            }
        }

        private async void playButton_Click(object sender, EventArgs e)
        {
            string currentUser = selectUserInput.Text.ToLower();

            if (currentUser.IsEmpty())
            {
                return;
            }

            int selectedWidth = widthInput.Text.ToInt().ClampValue(DefaultWidth, Screen.FromControl(this).Bounds.Width);
            int selectedHeight = heightInput.Text.ToInt().ClampValue(DefaultHeight, Screen.FromControl(this).Bounds.Height);
            bool isFullScreen = fullScreenCheckBox.Checked;

            SaveCurrentProfile(currentUser, selectedWidth.ToString(), selectedHeight.ToString(), isFullScreen);

            var dimClient = new DimClient(currentUser, selectedWidth, selectedHeight, isFullScreen);
            await dimClient.LaunchDimClient();
            _clientList.Add(dimClient);
        }

        private void SaveCurrentProfile(string user, string selectedWidth, string selectedHeight, bool isFullScreen)
        {
            int userIndex = _profilesTable["Profile"].RowList.FindIndex(x => x != null && x.Equals(user));
            bool hasProfile = userIndex != -1;

            if (hasProfile)
            {
                _profilesTable["Preferred Width"].RowList[userIndex] = selectedWidth;
                _profilesTable["Preferred Height"].RowList[userIndex] = selectedHeight;
                _profilesTable["Is Full Screen"].RowList[userIndex] = isFullScreen ? "1" : "0";
            }
            else
            {
                _profilesTable["Profile"].AddRow(user);
                _profilesTable["Last Login"].AddRow(DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"));
                _profilesTable["Preferred Width"].AddRow(selectedWidth);
                _profilesTable["Preferred Height"].AddRow(selectedHeight);
                _profilesTable["Is Full Screen"].AddRow(isFullScreen ? "1" : "0");
                selectUserInput.Items.Add(user);
            }

            File.WriteAllLines(NewProfilesFile, _profilesTable.ToList());
        }

        private void selectUserInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            int profileIndex = _profilesTable["Profile"].RowList.FindIndex(x => x != null && x.Equals(selectUserInput.Text));

            if (profileIndex == -1)
            {
                throw new ArgumentOutOfRangeException(nameof(profileIndex), @"Could not determine the index of the selected profile. Has the program been tempered with in runtime?");
            }

            widthInput.Text = _profilesTable["Preferred Width"].RowList[profileIndex];
            heightInput.Text = _profilesTable["Preferred Height"].RowList[profileIndex];
            fullScreenCheckBox.Checked = _profilesTable["Is Full Screen"].RowList[profileIndex] == "1";
        }

        private void selectUserInput_TextChanged(object sender, EventArgs e)
        {
            if (_profilesTable["Profile"].RowList.FirstOrDefault(x => x != null && x.Equals(selectUserInput.Text, StringComparison.OrdinalIgnoreCase)) != null)
            {
                return;
            }

            widthInput.Text = DefaultWidth.ToString();
            heightInput.Text = DefaultHeight.ToString();
            fullScreenCheckBox.Checked = false;
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
