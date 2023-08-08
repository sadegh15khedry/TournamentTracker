namespace TournamentTrackerApp.WinformsUI;

partial class TeamDetailsForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamDetailsForm));
        titleLabel = new Label();
        editTeamButton = new Button();
        backButton = new Label();
        ownerLabel = new Label();
        cityLabel = new Label();
        nameLabel = new Label();
        nameValueLabel = new Label();
        cityValueLabel = new Label();
        ownerValueLabel = new Label();
        teamsPlayersButton = new Button();
        SuspendLayout();
        // 
        // titleLabel
        // 
        titleLabel.AutoSize = true;
        titleLabel.Font = new Font("Segoe UI", 40F, FontStyle.Bold, GraphicsUnit.Point);
        titleLabel.ForeColor = Color.White;
        titleLabel.Location = new Point(727, 39);
        titleLabel.Margin = new Padding(5, 0, 5, 0);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(449, 106);
        titleLabel.TabIndex = 9;
        titleLabel.Text = "Team Page";
        // 
        // editTeamButton
        // 
        editTeamButton.BackColor = Color.White;
        editTeamButton.ForeColor = Color.Black;
        editTeamButton.Location = new Point(1099, 729);
        editTeamButton.Name = "editTeamButton";
        editTeamButton.Size = new Size(196, 80);
        editTeamButton.TabIndex = 25;
        editTeamButton.Text = "Edit";
        editTeamButton.UseVisualStyleBackColor = false;
        editTeamButton.Click += editPlayerButton_Click;
        // 
        // backButton
        // 
        backButton.AutoSize = true;
        backButton.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
        backButton.Location = new Point(38, 39);
        backButton.Name = "backButton";
        backButton.Size = new Size(87, 81);
        backButton.TabIndex = 26;
        backButton.Text = "←";
        backButton.Click += backButton_Click;
        // 
        // ownerLabel
        // 
        ownerLabel.AutoSize = true;
        ownerLabel.Location = new Point(1463, 313);
        ownerLabel.Name = "ownerLabel";
        ownerLabel.Size = new Size(138, 45);
        ownerLabel.TabIndex = 32;
        ownerLabel.Text = "Owner  :";
        // 
        // cityLabel
        // 
        cityLabel.AutoSize = true;
        cityLabel.Location = new Point(874, 313);
        cityLabel.Name = "cityLabel";
        cityLabel.Size = new Size(90, 45);
        cityLabel.TabIndex = 31;
        cityLabel.Text = "City :";
        // 
        // nameLabel
        // 
        nameLabel.AutoSize = true;
        nameLabel.Location = new Point(288, 313);
        nameLabel.Name = "nameLabel";
        nameLabel.Size = new Size(121, 45);
        nameLabel.TabIndex = 30;
        nameLabel.Text = "Name :";
        // 
        // nameValueLabel
        // 
        nameValueLabel.AutoSize = true;
        nameValueLabel.Location = new Point(447, 313);
        nameValueLabel.Name = "nameValueLabel";
        nameValueLabel.Size = new Size(176, 45);
        nameValueLabel.TabIndex = 33;
        nameValueLabel.Text = "nameValue";
        // 
        // cityValueLabel
        // 
        cityValueLabel.AutoSize = true;
        cityValueLabel.Location = new Point(999, 313);
        cityValueLabel.Name = "cityValueLabel";
        cityValueLabel.Size = new Size(221, 45);
        cityValueLabel.TabIndex = 34;
        cityValueLabel.Text = "cityValueLabel";
        // 
        // ownerValueLabel
        // 
        ownerValueLabel.AutoSize = true;
        ownerValueLabel.Location = new Point(1630, 313);
        ownerValueLabel.Name = "ownerValueLabel";
        ownerValueLabel.Size = new Size(260, 45);
        ownerValueLabel.TabIndex = 35;
        ownerValueLabel.Text = "ownerValueLabel";
        // 
        // teamsPlayersButton
        // 
        teamsPlayersButton.BackColor = Color.White;
        teamsPlayersButton.ForeColor = Color.Black;
        teamsPlayersButton.Location = new Point(639, 729);
        teamsPlayersButton.Name = "teamsPlayersButton";
        teamsPlayersButton.Size = new Size(299, 80);
        teamsPlayersButton.TabIndex = 36;
        teamsPlayersButton.Text = "Team's Players";
        teamsPlayersButton.UseVisualStyleBackColor = false;
        teamsPlayersButton.Click += teamsPlayersButton_Click;
        // 
        // TeamDetailsForm
        // 
        AutoScaleDimensions = new SizeF(18F, 45F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(2012, 1036);
        Controls.Add(teamsPlayersButton);
        Controls.Add(ownerValueLabel);
        Controls.Add(cityValueLabel);
        Controls.Add(nameValueLabel);
        Controls.Add(ownerLabel);
        Controls.Add(cityLabel);
        Controls.Add(nameLabel);
        Controls.Add(backButton);
        Controls.Add(editTeamButton);
        Controls.Add(titleLabel);
        Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
        ForeColor = Color.White;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(5);
        Name = "TeamDetailsForm";
        Text = "Login";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label titleLabel;
    private Label idLabel;
    private Label SSNLabel;
    private Label firstNameLabel;
    private Label lastNameLabel;
    private Label emailLabel;
    private Label phoneLabel;
    private Label teamLabel;
    private Label idValueLabel;
    private Label firstNameValueLabel;
    private Label lastNameValueLabel;
    private Label SSNValueLabel;
    private Label teamValueLabel;
    private Label phoneValueLabel;
    private Label emailValueLabel;
    private Button editTeamButton;
    private Label backButton;
    private Label ownerLabel;
    private Label cityLabel;
    private Label nameLabel;
    private Label nameValueLabel;
    private Label cityValueLabel;
    private Label ownerValueLabel;
    private Button teamsPlayersButton;
}
