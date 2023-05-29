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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.profileSettingsTab = new System.Windows.Forms.TabPage();
            this.closeAllLauncherButton = new System.Windows.Forms.Button();
            this.windowSettingsTab = new System.Windows.Forms.TabPage();
            this.adaptScreenSizeButton = new System.Windows.Forms.Button();
            this.fullScreenCheckBox = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.profileSettingsTab.SuspendLayout();
            this.windowSettingsTab.SuspendLayout();
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
            this.selectUserInput.TextChanged += new System.EventHandler(this.selectUserInput_TextChanged);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.profileSettingsTab);
            this.tabControl1.Controls.Add(this.windowSettingsTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(301, 294);
            this.tabControl1.TabIndex = 4;
            // 
            // profileSettingsTab
            // 
            this.profileSettingsTab.Controls.Add(this.closeAllLauncherButton);
            this.profileSettingsTab.Controls.Add(this.selectUserInput);
            this.profileSettingsTab.Controls.Add(this.selectUserLabel);
            this.profileSettingsTab.Controls.Add(this.playButton);
            this.profileSettingsTab.Location = new System.Drawing.Point(4, 24);
            this.profileSettingsTab.Name = "profileSettingsTab";
            this.profileSettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.profileSettingsTab.Size = new System.Drawing.Size(293, 266);
            this.profileSettingsTab.TabIndex = 0;
            this.profileSettingsTab.Text = "Profile Settings";
            this.profileSettingsTab.UseVisualStyleBackColor = true;
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
            // DimMultiClientLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 317);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DimMultiClientLauncher";
            this.Text = "DIM MultiClient - ";
            this.tabControl1.ResumeLayout(false);
            this.profileSettingsTab.ResumeLayout(false);
            this.profileSettingsTab.PerformLayout();
            this.windowSettingsTab.ResumeLayout(false);
            this.windowSettingsTab.PerformLayout();
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
        private TabControl tabControl1;
        private TabPage profileSettingsTab;
        private TabPage windowSettingsTab;
        private Button closeAllLauncherButton;
        private Button adaptScreenSizeButton;
        private CheckBox fullScreenCheckBox;
    }
}