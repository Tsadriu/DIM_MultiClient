namespace DimMultiClient
{
    partial class DimMultiClientLauncher
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DimMultiClientLauncher));
            this.playButton = new System.Windows.Forms.Button();
            this.selectUserInput = new System.Windows.Forms.ComboBox();
            this.selectUserLabel = new System.Windows.Forms.Label();
            this.madeByLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.heightInput = new System.Windows.Forms.TextBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.launcherTabControl = new System.Windows.Forms.TabControl();
            this.launcherTab = new System.Windows.Forms.TabPage();
            this.closeAllLauncherButton = new System.Windows.Forms.Button();
            this.windowSettingsTab = new System.Windows.Forms.TabPage();
            this.adaptScreenSizeButton = new System.Windows.Forms.Button();
            this.fullScreenCheckBox = new System.Windows.Forms.CheckBox();
            this.manageProfilesTab = new System.Windows.Forms.TabPage();
            this.manageProfileHeightLabel = new System.Windows.Forms.Label();
            this.manageProfilesWidthLabel = new System.Windows.Forms.Label();
            this.manageProfileNameLabel = new System.Windows.Forms.Label();
            this.manageProfileDeleteAllButton = new System.Windows.Forms.Button();
            this.manageProfileDeleteButton = new System.Windows.Forms.Button();
            this.manageProfileSaveButton = new System.Windows.Forms.Button();
            this.manageProfileFullscreenCheckBox = new System.Windows.Forms.CheckBox();
            this.manageProfileHeightTextBox = new System.Windows.Forms.TextBox();
            this.manageProfileWidthTextBox = new System.Windows.Forms.TextBox();
            this.manageProfileNameTextBox = new System.Windows.Forms.TextBox();
            this.modifyProfileLabel = new System.Windows.Forms.Label();
            this.manageProfileComboBox = new System.Windows.Forms.ComboBox();
            this.launcherTabControl.SuspendLayout();
            this.launcherTab.SuspendLayout();
            this.windowSettingsTab.SuspendLayout();
            this.manageProfilesTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(6, 56);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(114, 23);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Launch DIM";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // selectUserInput
            // 
            this.selectUserInput.FormattingEnabled = true;
            this.selectUserInput.Location = new System.Drawing.Point(6, 27);
            this.selectUserInput.Name = "selectUserInput";
            this.selectUserInput.Size = new System.Drawing.Size(253, 23);
            this.selectUserInput.TabIndex = 1;
            this.selectUserInput.SelectedIndexChanged += new System.EventHandler(this.selectUserInput_SelectedIndexChanged);
            this.selectUserInput.SelectedValueChanged += new System.EventHandler(this.selectUserInput_TextChanged);
            // 
            // selectUserLabel
            // 
            this.selectUserLabel.AutoSize = true;
            this.selectUserLabel.Location = new System.Drawing.Point(6, 9);
            this.selectUserLabel.Name = "selectUserLabel";
            this.selectUserLabel.Size = new System.Drawing.Size(184, 15);
            this.selectUserLabel.TabIndex = 0;
            this.selectUserLabel.Text = "Select a profile or type a new one:";
            // 
            // madeByLabel
            // 
            this.madeByLabel.AutoSize = true;
            this.madeByLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.madeByLabel.Location = new System.Drawing.Point(21, 183);
            this.madeByLabel.Name = "madeByLabel";
            this.madeByLabel.Size = new System.Drawing.Size(99, 15);
            this.madeByLabel.TabIndex = 4;
            this.madeByLabel.Text = "Made by: Tsadriu";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(21, 80);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(43, 15);
            this.heightLabel.TabIndex = 3;
            this.heightLabel.Text = "Height";
            // 
            // heightInput
            // 
            this.heightInput.Location = new System.Drawing.Point(21, 105);
            this.heightInput.Name = "heightInput";
            this.heightInput.PlaceholderText = "600";
            this.heightInput.Size = new System.Drawing.Size(100, 23);
            this.heightInput.TabIndex = 2;
            this.heightInput.Text = "600";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(21, 16);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(39, 15);
            this.widthLabel.TabIndex = 1;
            this.widthLabel.Text = "Width";
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(21, 34);
            this.widthInput.Name = "widthInput";
            this.widthInput.PlaceholderText = "800";
            this.widthInput.Size = new System.Drawing.Size(100, 23);
            this.widthInput.TabIndex = 0;
            this.widthInput.Text = "800";
            // 
            // launcherTabControl
            // 
            this.launcherTabControl.Controls.Add(this.launcherTab);
            this.launcherTabControl.Controls.Add(this.windowSettingsTab);
            this.launcherTabControl.Controls.Add(this.manageProfilesTab);
            this.launcherTabControl.Location = new System.Drawing.Point(12, 12);
            this.launcherTabControl.Name = "launcherTabControl";
            this.launcherTabControl.SelectedIndex = 0;
            this.launcherTabControl.Size = new System.Drawing.Size(301, 294);
            this.launcherTabControl.TabIndex = 4;
            // 
            // launcherTab
            // 
            this.launcherTab.Controls.Add(this.closeAllLauncherButton);
            this.launcherTab.Controls.Add(this.selectUserInput);
            this.launcherTab.Controls.Add(this.selectUserLabel);
            this.launcherTab.Controls.Add(this.playButton);
            this.launcherTab.Location = new System.Drawing.Point(4, 24);
            this.launcherTab.Name = "launcherTab";
            this.launcherTab.Padding = new System.Windows.Forms.Padding(3);
            this.launcherTab.Size = new System.Drawing.Size(293, 266);
            this.launcherTab.TabIndex = 0;
            this.launcherTab.Text = "Launcher";
            this.launcherTab.UseVisualStyleBackColor = true;
            // 
            // closeAllLauncherButton
            // 
            this.closeAllLauncherButton.Location = new System.Drawing.Point(145, 56);
            this.closeAllLauncherButton.Name = "closeAllLauncherButton";
            this.closeAllLauncherButton.Size = new System.Drawing.Size(114, 23);
            this.closeAllLauncherButton.TabIndex = 3;
            this.closeAllLauncherButton.Text = "Close all launchers";
            this.closeAllLauncherButton.UseVisualStyleBackColor = true;
            this.closeAllLauncherButton.Click += new System.EventHandler(this.closeAllLauncherButton_Click);
            // 
            // windowSettingsTab
            // 
            this.windowSettingsTab.Controls.Add(this.adaptScreenSizeButton);
            this.windowSettingsTab.Controls.Add(this.fullScreenCheckBox);
            this.windowSettingsTab.Controls.Add(this.madeByLabel);
            this.windowSettingsTab.Controls.Add(this.widthLabel);
            this.windowSettingsTab.Controls.Add(this.heightInput);
            this.windowSettingsTab.Controls.Add(this.heightLabel);
            this.windowSettingsTab.Controls.Add(this.widthInput);
            this.windowSettingsTab.Location = new System.Drawing.Point(4, 24);
            this.windowSettingsTab.Name = "windowSettingsTab";
            this.windowSettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.windowSettingsTab.Size = new System.Drawing.Size(293, 266);
            this.windowSettingsTab.TabIndex = 1;
            this.windowSettingsTab.Text = "Window Settings";
            this.windowSettingsTab.UseVisualStyleBackColor = true;
            // 
            // adaptScreenSizeButton
            // 
            this.adaptScreenSizeButton.Location = new System.Drawing.Point(127, 25);
            this.adaptScreenSizeButton.Name = "adaptScreenSizeButton";
            this.adaptScreenSizeButton.Size = new System.Drawing.Size(88, 38);
            this.adaptScreenSizeButton.TabIndex = 6;
            this.adaptScreenSizeButton.Text = "Adapt to screen size";
            this.adaptScreenSizeButton.UseVisualStyleBackColor = true;
            this.adaptScreenSizeButton.Click += new System.EventHandler(this.adaptScreenSizeButton_Click);
            // 
            // fullScreenCheckBox
            // 
            this.fullScreenCheckBox.AutoSize = true;
            this.fullScreenCheckBox.Location = new System.Drawing.Point(127, 107);
            this.fullScreenCheckBox.Name = "fullScreenCheckBox";
            this.fullScreenCheckBox.Size = new System.Drawing.Size(84, 19);
            this.fullScreenCheckBox.TabIndex = 5;
            this.fullScreenCheckBox.Text = "Fullscreen?";
            this.fullScreenCheckBox.UseVisualStyleBackColor = true;
            // 
            // manageProfilesTab
            // 
            this.manageProfilesTab.Controls.Add(this.manageProfileHeightLabel);
            this.manageProfilesTab.Controls.Add(this.manageProfilesWidthLabel);
            this.manageProfilesTab.Controls.Add(this.manageProfileNameLabel);
            this.manageProfilesTab.Controls.Add(this.manageProfileDeleteAllButton);
            this.manageProfilesTab.Controls.Add(this.manageProfileDeleteButton);
            this.manageProfilesTab.Controls.Add(this.manageProfileSaveButton);
            this.manageProfilesTab.Controls.Add(this.manageProfileFullscreenCheckBox);
            this.manageProfilesTab.Controls.Add(this.manageProfileHeightTextBox);
            this.manageProfilesTab.Controls.Add(this.manageProfileWidthTextBox);
            this.manageProfilesTab.Controls.Add(this.manageProfileNameTextBox);
            this.manageProfilesTab.Controls.Add(this.modifyProfileLabel);
            this.manageProfilesTab.Controls.Add(this.manageProfileComboBox);
            this.manageProfilesTab.Location = new System.Drawing.Point(4, 24);
            this.manageProfilesTab.Name = "manageProfilesTab";
            this.manageProfilesTab.Padding = new System.Windows.Forms.Padding(3);
            this.manageProfilesTab.Size = new System.Drawing.Size(293, 266);
            this.manageProfilesTab.TabIndex = 2;
            this.manageProfilesTab.Text = "Manage Profiles";
            this.manageProfilesTab.UseVisualStyleBackColor = true;
            // 
            // manageProfileHeightLabel
            // 
            this.manageProfileHeightLabel.AutoSize = true;
            this.manageProfileHeightLabel.Location = new System.Drawing.Point(20, 169);
            this.manageProfileHeightLabel.Name = "manageProfileHeightLabel";
            this.manageProfileHeightLabel.Size = new System.Drawing.Size(92, 15);
            this.manageProfileHeightLabel.TabIndex = 13;
            this.manageProfileHeightLabel.Text = "Preferred height";
            // 
            // manageProfilesWidthLabel
            // 
            this.manageProfilesWidthLabel.AutoSize = true;
            this.manageProfilesWidthLabel.Location = new System.Drawing.Point(20, 125);
            this.manageProfilesWidthLabel.Name = "manageProfilesWidthLabel";
            this.manageProfilesWidthLabel.Size = new System.Drawing.Size(88, 15);
            this.manageProfilesWidthLabel.TabIndex = 12;
            this.manageProfilesWidthLabel.Text = "Preferred width";
            // 
            // manageProfileNameLabel
            // 
            this.manageProfileNameLabel.AutoSize = true;
            this.manageProfileNameLabel.Location = new System.Drawing.Point(20, 81);
            this.manageProfileNameLabel.Name = "manageProfileNameLabel";
            this.manageProfileNameLabel.Size = new System.Drawing.Size(74, 15);
            this.manageProfileNameLabel.TabIndex = 11;
            this.manageProfileNameLabel.Text = "Profile name";
            // 
            // manageProfileDeleteAllButton
            // 
            this.manageProfileDeleteAllButton.Location = new System.Drawing.Point(154, 237);
            this.manageProfileDeleteAllButton.Name = "manageProfileDeleteAllButton";
            this.manageProfileDeleteAllButton.Size = new System.Drawing.Size(119, 23);
            this.manageProfileDeleteAllButton.TabIndex = 10;
            this.manageProfileDeleteAllButton.Text = "Delete all profiles";
            this.manageProfileDeleteAllButton.UseVisualStyleBackColor = true;
            this.manageProfileDeleteAllButton.Click += new System.EventHandler(this.manageProfileDeleteAllButton_Click);
            // 
            // manageProfileDeleteButton
            // 
            this.manageProfileDeleteButton.Location = new System.Drawing.Point(154, 208);
            this.manageProfileDeleteButton.Name = "manageProfileDeleteButton";
            this.manageProfileDeleteButton.Size = new System.Drawing.Size(119, 23);
            this.manageProfileDeleteButton.TabIndex = 9;
            this.manageProfileDeleteButton.Text = "Delete this profile";
            this.manageProfileDeleteButton.UseVisualStyleBackColor = true;
            this.manageProfileDeleteButton.Click += new System.EventHandler(this.manageProfileDeleteButton_Click);
            // 
            // manageProfileSaveButton
            // 
            this.manageProfileSaveButton.Location = new System.Drawing.Point(154, 179);
            this.manageProfileSaveButton.Name = "manageProfileSaveButton";
            this.manageProfileSaveButton.Size = new System.Drawing.Size(119, 23);
            this.manageProfileSaveButton.TabIndex = 8;
            this.manageProfileSaveButton.Text = "Save changes";
            this.manageProfileSaveButton.UseVisualStyleBackColor = true;
            this.manageProfileSaveButton.Click += new System.EventHandler(this.manageProfileSaveButton_Click);
            // 
            // manageProfileFullscreenCheckBox
            // 
            this.manageProfileFullscreenCheckBox.AutoSize = true;
            this.manageProfileFullscreenCheckBox.Location = new System.Drawing.Point(154, 99);
            this.manageProfileFullscreenCheckBox.Name = "manageProfileFullscreenCheckBox";
            this.manageProfileFullscreenCheckBox.Size = new System.Drawing.Size(84, 19);
            this.manageProfileFullscreenCheckBox.TabIndex = 7;
            this.manageProfileFullscreenCheckBox.Text = "Fullscreen?";
            this.manageProfileFullscreenCheckBox.UseVisualStyleBackColor = true;
            // 
            // manageProfileHeightTextBox
            // 
            this.manageProfileHeightTextBox.Location = new System.Drawing.Point(20, 187);
            this.manageProfileHeightTextBox.Name = "manageProfileHeightTextBox";
            this.manageProfileHeightTextBox.Size = new System.Drawing.Size(100, 23);
            this.manageProfileHeightTextBox.TabIndex = 6;
            // 
            // manageProfileWidthTextBox
            // 
            this.manageProfileWidthTextBox.Location = new System.Drawing.Point(20, 143);
            this.manageProfileWidthTextBox.Name = "manageProfileWidthTextBox";
            this.manageProfileWidthTextBox.Size = new System.Drawing.Size(100, 23);
            this.manageProfileWidthTextBox.TabIndex = 5;
            // 
            // manageProfileNameTextBox
            // 
            this.manageProfileNameTextBox.Location = new System.Drawing.Point(20, 99);
            this.manageProfileNameTextBox.Name = "manageProfileNameTextBox";
            this.manageProfileNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.manageProfileNameTextBox.TabIndex = 4;
            // 
            // modifyProfileLabel
            // 
            this.modifyProfileLabel.AutoSize = true;
            this.modifyProfileLabel.Location = new System.Drawing.Point(20, 11);
            this.modifyProfileLabel.Name = "modifyProfileLabel";
            this.modifyProfileLabel.Size = new System.Drawing.Size(153, 15);
            this.modifyProfileLabel.TabIndex = 3;
            this.modifyProfileLabel.Text = "Select the profile to modify:";
            // 
            // manageProfileComboBox
            // 
            this.manageProfileComboBox.FormattingEnabled = true;
            this.manageProfileComboBox.Location = new System.Drawing.Point(20, 29);
            this.manageProfileComboBox.Name = "manageProfileComboBox";
            this.manageProfileComboBox.Size = new System.Drawing.Size(253, 23);
            this.manageProfileComboBox.TabIndex = 2;
            this.manageProfileComboBox.SelectedIndexChanged += new System.EventHandler(this.manageProfileComboBox_SelectedIndexChanged);
            // 
            // DimMultiClientLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 317);
            this.Controls.Add(this.launcherTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DimMultiClientLauncher";
            this.Text = "DIM MultiClient - ";
            this.launcherTabControl.ResumeLayout(false);
            this.launcherTab.ResumeLayout(false);
            this.launcherTab.PerformLayout();
            this.windowSettingsTab.ResumeLayout(false);
            this.windowSettingsTab.PerformLayout();
            this.manageProfilesTab.ResumeLayout(false);
            this.manageProfilesTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button playButton;
        private ComboBox selectUserInput;
        private Label selectUserLabel;
        private Label heightLabel;
        private TextBox heightInput;
        private Label widthLabel;
        private TextBox widthInput;
        private Label madeByLabel;
        private TabControl launcherTabControl;
        private TabPage launcherTab;
        private TabPage windowSettingsTab;
        private Button closeAllLauncherButton;
        private Button adaptScreenSizeButton;
        private CheckBox fullScreenCheckBox;
        private TabPage manageProfilesTab;
        private Label modifyProfileLabel;
        private ComboBox manageProfileComboBox;
        private Button manageProfileDeleteAllButton;
        private Button manageProfileDeleteButton;
        private Button manageProfileSaveButton;
        private CheckBox manageProfileFullscreenCheckBox;
        private TextBox manageProfileHeightTextBox;
        private TextBox manageProfileWidthTextBox;
        private TextBox manageProfileNameTextBox;
        private Label manageProfileHeightLabel;
        private Label manageProfilesWidthLabel;
        private Label manageProfileNameLabel;
    }
}