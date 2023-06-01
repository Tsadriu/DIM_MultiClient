using DimMultiClient;
using Microsoft.Web.WebView2.Core;
using System.Reflection;
using System.Security.Permissions;
using TsadriuUtilities;
using TsadriuUtilities.Csv.CsvObjects;
using TsadriuUtilities.Enums.StringHelper;

namespace DimMultiClient
{
    public partial class DimMultiClientLauncher : Form
    {
        public static readonly string CurrentDirectory = Path.GetPathRoot(Environment.CurrentDirectory) ?? Directory.GetCurrentDirectory();
        public static readonly string ProgramStorage = Path.Combine(CurrentDirectory, "Dim MultiClient");
        public static readonly string ProgramNetworkStorage = Path.Combine(ProgramStorage, "Network Data");
        public static readonly string ProfilesDirectory = Path.Combine(ProgramStorage, "Profile");
        public static readonly string OldProfilesFile = Path.Combine(ProfilesDirectory, "profiles.txt");
        public static readonly string NewProfilesFile = Path.Combine(ProfilesDirectory, "profiles.csv");
        public static readonly string NewsLink = "https://universe.flyff.com/news";


        public static TTable usersInFile = new TTable();
        public static ICsvTable profilesTable;
        public static int DefaultWidth { get => 800; }
        public static int DefaultHeight { get => 600; }

        private List<DimClient> _clientList = new List<DimClient>();


        public DimMultiClientLauncher()
        {
            InitializeComponent();
            AssignUsersToComboBox();
            Text += Program.GetVersionAsString();
        }

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
                profilesTable = new CsvTable(File.ReadAllText(OldProfilesFile).SplitBy(SplitType.EnvironmentNewLine), ";");
                profilesTable["Width"].Name = "Preferred Width";
                profilesTable["Height"].Name = "Preferred Height";
                profilesTable.AddColumn("Is Full Screen");
                profilesTable["Is Full Screen"].AddRow("0");
                File.Delete(OldProfilesFile);
                File.WriteAllLines(NewProfilesFile, profilesTable.ToList());
                hasSetupData = true;
            }

            if (File.Exists(NewProfilesFile))
            {
                profilesTable = new CsvTable(File.ReadAllText(NewProfilesFile).SplitBy(SplitType.EnvironmentNewLine), ";");
                hasSetupData = true;
            }

            if (!hasSetupData)
            {
                profilesTable = new CsvTable(new CsvColumn("Profile"), new CsvColumn("Last login"),
                    new CsvColumn("Preferred Width"), new CsvColumn("Preferred Height"),
                    new CsvColumn("IsFullScreen"));
            }

            foreach (string? profile in profilesTable["Profile"].RowList.Where(profile => !string.IsNullOrEmpty(profile)))
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
            bool hasProfile = profilesTable[user].Name != "UNDEFINED";

            if (hasProfile)
            {
                
            }

            if (!hasProfile)
            {
                profilesTable["Profile"].AddRow(user);
                profilesTable["Last Login"].AddRow(DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"));
                profilesTable["Preferred Width"].AddRow(selectedWidth);
                profilesTable["Preferred Height"].AddRow(selectedHeight);
                profilesTable["Is Full Screen"].AddRow(isFullScreen ? "1" : "0");
                File.WriteAllLines(NewProfilesFile, profilesTable.ToList());
                selectUserInput.Items.Add(user);
            }
            else
            {
                widthInput.Text = selectedWidth;
                heightInput.Text = selectedHeight;
                int userIndex = profilesTable["Profile"].RowList.FindIndex(x => x.Equals(user));
                usersInFile.GetColumn("Width").ColumnData[userIndex] = widthInput.Text;
                usersInFile.GetColumn("Height").ColumnData[userIndex] = heightInput.Text;

                File.WriteAllLines(OldProfilesFile, usersInFile.TableToCsv());
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
                widthInput.Text = DefaultWidth.ToString();
                heightInput.Text = DefaultHeight.ToString();
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
