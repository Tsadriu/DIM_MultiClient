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
            playButton = new Button();
            selectUserInput = new ComboBox();
            selectUserLabel = new Label();
            madeByLabel = new Label();
            heightLabel = new Label();
            heightInput = new TextBox();
            widthLabel = new Label();
            widthInput = new TextBox();
            launcherTabControl = new TabControl();
            launcherTab = new TabPage();
            closeAllLauncherButton = new Button();
            windowSettingsTab = new TabPage();
            adaptScreenSizeButton = new Button();
            fullScreenCheckBox = new CheckBox();
            manageProfilesTab = new TabPage();
            modifyProfileComboBox = new ComboBox();
            modifyProfileLabel = new Label();
            manageProfileNameTextBox = new TextBox();
            manageProfileWidthTextBox = new TextBox();
            manageProfileHeightTextBox = new TextBox();
            manageProfileFullscreenCheckBox = new CheckBox();
            manageProfileSaveButton = new Button();
            manageProfileDeleteButton = new Button();
            manageProfileDeleteAllButton = new Button();
            launcherTabControl.SuspendLayout();
            launcherTab.SuspendLayout();
            windowSettingsTab.SuspendLayout();
            manageProfilesTab.SuspendLayout();
            SuspendLayout();
            // 
            // playButton
            // 
            playButton.Location = new Point(6, 56);
            playButton.Name = "playButton";
            playButton.Size = new Size(114, 23);
            playButton.TabIndex = 1;
            playButton.Text = "Launch DIM";
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += playButton_Click;
            // 
            // selectUserInput
            // 
            selectUserInput.FormattingEnabled = true;
            selectUserInput.Location = new Point(6, 27);
            selectUserInput.Name = "selectUserInput";
            selectUserInput.Size = new Size(253, 23);
            selectUserInput.TabIndex = 1;
            selectUserInput.SelectedIndexChanged += selectUserInput_SelectedIndexChanged;
            selectUserInput.TextChanged += selectUserInput_TextChanged;
            // 
            // selectUserLabel
            // 
            selectUserLabel.AutoSize = true;
            selectUserLabel.Location = new Point(6, 9);
            selectUserLabel.Name = "selectUserLabel";
            selectUserLabel.Size = new Size(184, 15);
            selectUserLabel.TabIndex = 0;
            selectUserLabel.Text = "Select a profile or type a new one:";
            // 
            // madeByLabel
            // 
            madeByLabel.AutoSize = true;
            madeByLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            madeByLabel.Location = new Point(21, 183);
            madeByLabel.Name = "madeByLabel";
            madeByLabel.Size = new Size(99, 15);
            madeByLabel.TabIndex = 4;
            madeByLabel.Text = "Made by: Tsadriu";
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Location = new Point(21, 80);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new Size(43, 15);
            heightLabel.TabIndex = 3;
            heightLabel.Text = "Height";
            // 
            // heightInput
            // 
            heightInput.Location = new Point(21, 105);
            heightInput.Name = "heightInput";
            heightInput.PlaceholderText = "600";
            heightInput.Size = new Size(100, 23);
            heightInput.TabIndex = 2;
            heightInput.Text = "600";
            // 
            // widthLabel
            // 
            widthLabel.AutoSize = true;
            widthLabel.Location = new Point(21, 16);
            widthLabel.Name = "widthLabel";
            widthLabel.Size = new Size(39, 15);
            widthLabel.TabIndex = 1;
            widthLabel.Text = "Width";
            // 
            // widthInput
            // 
            widthInput.Location = new Point(21, 34);
            widthInput.Name = "widthInput";
            widthInput.PlaceholderText = "800";
            widthInput.Size = new Size(100, 23);
            widthInput.TabIndex = 0;
            widthInput.Text = "800";
            // 
            // launcherTabControl
            // 
            launcherTabControl.Controls.Add(launcherTab);
            launcherTabControl.Controls.Add(windowSettingsTab);
            launcherTabControl.Controls.Add(manageProfilesTab);
            launcherTabControl.Location = new Point(12, 12);
            launcherTabControl.Name = "launcherTabControl";
            launcherTabControl.SelectedIndex = 0;
            launcherTabControl.Size = new Size(301, 294);
            launcherTabControl.TabIndex = 4;
            // 
            // launcherTab
            // 
            launcherTab.Controls.Add(closeAllLauncherButton);
            launcherTab.Controls.Add(selectUserInput);
            launcherTab.Controls.Add(selectUserLabel);
            launcherTab.Controls.Add(playButton);
            launcherTab.Location = new Point(4, 24);
            launcherTab.Name = "launcherTab";
            launcherTab.Padding = new Padding(3);
            launcherTab.Size = new Size(293, 266);
            launcherTab.TabIndex = 0;
            launcherTab.Text = "Launcher";
            launcherTab.UseVisualStyleBackColor = true;
            // 
            // closeAllLauncherButton
            // 
            closeAllLauncherButton.Location = new Point(145, 56);
            closeAllLauncherButton.Name = "closeAllLauncherButton";
            closeAllLauncherButton.Size = new Size(114, 23);
            closeAllLauncherButton.TabIndex = 3;
            closeAllLauncherButton.Text = "Close all launchers";
            closeAllLauncherButton.UseVisualStyleBackColor = true;
            closeAllLauncherButton.Click += closeAllLauncherButton_Click;
            // 
            // windowSettingsTab
            // 
            windowSettingsTab.Controls.Add(adaptScreenSizeButton);
            windowSettingsTab.Controls.Add(fullScreenCheckBox);
            windowSettingsTab.Controls.Add(madeByLabel);
            windowSettingsTab.Controls.Add(widthLabel);
            windowSettingsTab.Controls.Add(heightInput);
            windowSettingsTab.Controls.Add(heightLabel);
            windowSettingsTab.Controls.Add(widthInput);
            windowSettingsTab.Location = new Point(4, 24);
            windowSettingsTab.Name = "windowSettingsTab";
            windowSettingsTab.Padding = new Padding(3);
            windowSettingsTab.Size = new Size(293, 266);
            windowSettingsTab.TabIndex = 1;
            windowSettingsTab.Text = "Window Settings";
            windowSettingsTab.UseVisualStyleBackColor = true;
            // 
            // adaptScreenSizeButton
            // 
            adaptScreenSizeButton.Location = new Point(127, 25);
            adaptScreenSizeButton.Name = "adaptScreenSizeButton";
            adaptScreenSizeButton.Size = new Size(88, 38);
            adaptScreenSizeButton.TabIndex = 6;
            adaptScreenSizeButton.Text = "Adapt to screen size";
            adaptScreenSizeButton.UseVisualStyleBackColor = true;
            adaptScreenSizeButton.Click += adaptScreenSizeButton_Click;
            // 
            // fullScreenCheckBox
            // 
            fullScreenCheckBox.AutoSize = true;
            fullScreenCheckBox.Location = new Point(127, 107);
            fullScreenCheckBox.Name = "fullScreenCheckBox";
            fullScreenCheckBox.Size = new Size(84, 19);
            fullScreenCheckBox.TabIndex = 5;
            fullScreenCheckBox.Text = "Fullscreen?";
            fullScreenCheckBox.UseVisualStyleBackColor = true;
            // 
            // manageProfilesTab
            // 
            manageProfilesTab.Controls.Add(manageProfileDeleteAllButton);
            manageProfilesTab.Controls.Add(manageProfileDeleteButton);
            manageProfilesTab.Controls.Add(manageProfileSaveButton);
            manageProfilesTab.Controls.Add(manageProfileFullscreenCheckBox);
            manageProfilesTab.Controls.Add(manageProfileHeightTextBox);
            manageProfilesTab.Controls.Add(manageProfileWidthTextBox);
            manageProfilesTab.Controls.Add(manageProfileNameTextBox);
            manageProfilesTab.Controls.Add(modifyProfileLabel);
            manageProfilesTab.Controls.Add(modifyProfileComboBox);
            manageProfilesTab.Location = new Point(4, 24);
            manageProfilesTab.Name = "manageProfilesTab";
            manageProfilesTab.Padding = new Padding(3);
            manageProfilesTab.Size = new Size(293, 266);
            manageProfilesTab.TabIndex = 2;
            manageProfilesTab.Text = "Manage Profiles";
            manageProfilesTab.UseVisualStyleBackColor = true;
            // 
            // modifyProfileComboBox
            // 
            modifyProfileComboBox.FormattingEnabled = true;
            modifyProfileComboBox.Location = new Point(20, 29);
            modifyProfileComboBox.Name = "modifyProfileComboBox";
            modifyProfileComboBox.Size = new Size(253, 23);
            modifyProfileComboBox.TabIndex = 2;
            // 
            // modifyProfileLabel
            // 
            modifyProfileLabel.AutoSize = true;
            modifyProfileLabel.Location = new Point(20, 11);
            modifyProfileLabel.Name = "modifyProfileLabel";
            modifyProfileLabel.Size = new Size(153, 15);
            modifyProfileLabel.TabIndex = 3;
            modifyProfileLabel.Text = "Select the profile to modify:";
            // 
            // manageProfileNameTextBox
            // 
            manageProfileNameTextBox.Location = new Point(20, 80);
            manageProfileNameTextBox.Name = "manageProfileNameTextBox";
            manageProfileNameTextBox.Size = new Size(100, 23);
            manageProfileNameTextBox.TabIndex = 4;
            // 
            // manageProfileWidthTextBox
            // 
            manageProfileWidthTextBox.Location = new Point(20, 131);
            manageProfileWidthTextBox.Name = "manageProfileWidthTextBox";
            manageProfileWidthTextBox.Size = new Size(100, 23);
            manageProfileWidthTextBox.TabIndex = 5;
            // 
            // manageProfileHeightTextBox
            // 
            manageProfileHeightTextBox.Location = new Point(20, 186);
            manageProfileHeightTextBox.Name = "manageProfileHeightTextBox";
            manageProfileHeightTextBox.Size = new Size(100, 23);
            manageProfileHeightTextBox.TabIndex = 6;
            // 
            // manageProfileFullscreenCheckBox
            // 
            manageProfileFullscreenCheckBox.AutoSize = true;
            manageProfileFullscreenCheckBox.Location = new Point(154, 82);
            manageProfileFullscreenCheckBox.Name = "manageProfileFullscreenCheckBox";
            manageProfileFullscreenCheckBox.Size = new Size(84, 19);
            manageProfileFullscreenCheckBox.TabIndex = 7;
            manageProfileFullscreenCheckBox.Text = "Fullscreen?";
            manageProfileFullscreenCheckBox.UseVisualStyleBackColor = true;
            // 
            // manageProfileSaveButton
            // 
            manageProfileSaveButton.Location = new Point(154, 128);
            manageProfileSaveButton.Name = "manageProfileSaveButton";
            manageProfileSaveButton.Size = new Size(119, 23);
            manageProfileSaveButton.TabIndex = 8;
            manageProfileSaveButton.Text = "Save changes";
            manageProfileSaveButton.UseVisualStyleBackColor = true;
            // 
            // manageProfileDeleteButton
            // 
            manageProfileDeleteButton.Location = new Point(154, 157);
            manageProfileDeleteButton.Name = "manageProfileDeleteButton";
            manageProfileDeleteButton.Size = new Size(119, 23);
            manageProfileDeleteButton.TabIndex = 9;
            manageProfileDeleteButton.Text = "Delete this profile";
            manageProfileDeleteButton.UseVisualStyleBackColor = true;
            // 
            // manageProfileDeleteAllButton
            // 
            manageProfileDeleteAllButton.Location = new Point(154, 186);
            manageProfileDeleteAllButton.Name = "manageProfileDeleteAllButton";
            manageProfileDeleteAllButton.Size = new Size(119, 23);
            manageProfileDeleteAllButton.TabIndex = 10;
            manageProfileDeleteAllButton.Text = "Delete all profiles";
            manageProfileDeleteAllButton.UseVisualStyleBackColor = true;
            // 
            // DimMultiClientLauncher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 317);
            Controls.Add(launcherTabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "DimMultiClientLauncher";
            Text = "DIM MultiClient - ";
            launcherTabControl.ResumeLayout(false);
            launcherTab.ResumeLayout(false);
            launcherTab.PerformLayout();
            windowSettingsTab.ResumeLayout(false);
            windowSettingsTab.PerformLayout();
            manageProfilesTab.ResumeLayout(false);
            manageProfilesTab.PerformLayout();
            ResumeLayout(false);
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
        private ComboBox modifyProfileComboBox;
        private Button manageProfileDeleteAllButton;
        private Button manageProfileDeleteButton;
        private Button manageProfileSaveButton;
        private CheckBox manageProfileFullscreenCheckBox;
        private TextBox manageProfileHeightTextBox;
        private TextBox manageProfileWidthTextBox;
        private TextBox manageProfileNameTextBox;
    }
}