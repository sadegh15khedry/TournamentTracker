namespace TournamentTrackerApp.WinformsUI;

partial class HomeForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
        titleLabel = new Label();
        addTournamentButton = new Button();
        addTeamButton = new Button();
        addPlayerButton = new Button();
        goToPlayerButton = new Button();
        goToTeamButton = new Button();
        goToTournamentButton = new Button();
        playersListBox = new ListBox();
        teamsListBox = new ListBox();
        tournamentsListBox = new ListBox();
        playersLabel = new Label();
        teamsLabel = new Label();
        tournamentsLabel = new Label();
        SuspendLayout();
        // 
        // titleLabel
        // 
        titleLabel.AutoSize = true;
        titleLabel.Font = new Font("Segoe UI", 40F, FontStyle.Bold, GraphicsUnit.Point);
        titleLabel.ForeColor = Color.White;
        titleLabel.Location = new Point(794, 39);
        titleLabel.Margin = new Padding(5, 0, 5, 0);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(271, 106);
        titleLabel.TabIndex = 9;
        titleLabel.Text = "Home";
        // 
        // addTournamentButton
        // 
        addTournamentButton.BackColor = Color.White;
        addTournamentButton.FlatAppearance.BorderSize = 0;
        addTournamentButton.ForeColor = Color.Black;
        addTournamentButton.Location = new Point(153, 884);
        addTournamentButton.Name = "addTournamentButton";
        addTournamentButton.Size = new Size(442, 57);
        addTournamentButton.TabIndex = 13;
        addTournamentButton.Text = "Add a Tournament";
        addTournamentButton.UseVisualStyleBackColor = false;
        addTournamentButton.Click += addTournamentButton_Click;
        // 
        // addTeamButton
        // 
        addTeamButton.BackColor = Color.White;
        addTeamButton.FlatAppearance.BorderSize = 0;
        addTeamButton.ForeColor = Color.Black;
        addTeamButton.Location = new Point(805, 884);
        addTeamButton.Name = "addTeamButton";
        addTeamButton.Size = new Size(307, 57);
        addTeamButton.TabIndex = 14;
        addTeamButton.Text = "Add a Team";
        addTeamButton.UseVisualStyleBackColor = false;
        addTeamButton.Click += addTeamButton_Click;
        // 
        // addPlayerButton
        // 
        addPlayerButton.BackColor = Color.White;
        addPlayerButton.FlatAppearance.BorderSize = 0;
        addPlayerButton.ForeColor = Color.Black;
        addPlayerButton.Location = new Point(1375, 875);
        addPlayerButton.Name = "addPlayerButton";
        addPlayerButton.Size = new Size(314, 57);
        addPlayerButton.TabIndex = 15;
        addPlayerButton.Text = "Add a Player";
        addPlayerButton.UseVisualStyleBackColor = false;
        addPlayerButton.Click += addPlayerButton_Click;
        // 
        // goToPlayerButton
        // 
        goToPlayerButton.BackColor = Color.White;
        goToPlayerButton.FlatAppearance.BorderSize = 0;
        goToPlayerButton.ForeColor = Color.Black;
        goToPlayerButton.Location = new Point(1375, 771);
        goToPlayerButton.Name = "goToPlayerButton";
        goToPlayerButton.Size = new Size(314, 57);
        goToPlayerButton.TabIndex = 19;
        goToPlayerButton.Text = "Go To Player";
        goToPlayerButton.UseVisualStyleBackColor = false;
        goToPlayerButton.Click += goToPlayerButton_Click;
        // 
        // goToTeamButton
        // 
        goToTeamButton.BackColor = Color.White;
        goToTeamButton.FlatAppearance.BorderSize = 0;
        goToTeamButton.ForeColor = Color.Black;
        goToTeamButton.Location = new Point(805, 780);
        goToTeamButton.Name = "goToTeamButton";
        goToTeamButton.Size = new Size(307, 57);
        goToTeamButton.TabIndex = 18;
        goToTeamButton.Text = "Go To Team";
        goToTeamButton.UseVisualStyleBackColor = false;
        goToTeamButton.Click += goToTeamButton_Click;
        // 
        // goToTournamentButton
        // 
        goToTournamentButton.BackColor = Color.White;
        goToTournamentButton.FlatAppearance.BorderSize = 0;
        goToTournamentButton.ForeColor = Color.Black;
        goToTournamentButton.Location = new Point(153, 780);
        goToTournamentButton.Name = "goToTournamentButton";
        goToTournamentButton.Size = new Size(442, 57);
        goToTournamentButton.TabIndex = 17;
        goToTournamentButton.Text = "Go To Tournament";
        goToTournamentButton.UseVisualStyleBackColor = false;
        goToTournamentButton.Click += goToTournamentButton_Click;
        // 
        // playersListBox
        // 
        playersListBox.FormattingEnabled = true;
        playersListBox.ItemHeight = 45;
        playersListBox.Location = new Point(1295, 283);
        playersListBox.Name = "playersListBox";
        playersListBox.Size = new Size(507, 454);
        playersListBox.TabIndex = 20;
        // 
        // teamsListBox
        // 
        teamsListBox.FormattingEnabled = true;
        teamsListBox.ItemHeight = 45;
        teamsListBox.Location = new Point(690, 283);
        teamsListBox.Name = "teamsListBox";
        teamsListBox.Size = new Size(565, 454);
        teamsListBox.TabIndex = 21;
        // 
        // tournamentsListBox
        // 
        tournamentsListBox.FormattingEnabled = true;
        tournamentsListBox.ItemHeight = 45;
        tournamentsListBox.Location = new Point(94, 283);
        tournamentsListBox.Name = "tournamentsListBox";
        tournamentsListBox.Size = new Size(565, 454);
        tournamentsListBox.TabIndex = 22;
        // 
        // playersLabel
        // 
        playersLabel.AutoSize = true;
        playersLabel.Location = new Point(1498, 191);
        playersLabel.Name = "playersLabel";
        playersLabel.Size = new Size(119, 45);
        playersLabel.TabIndex = 23;
        playersLabel.Text = "Players";
        // 
        // teamsLabel
        // 
        teamsLabel.AutoSize = true;
        teamsLabel.Location = new Point(907, 191);
        teamsLabel.Name = "teamsLabel";
        teamsLabel.Size = new Size(109, 45);
        teamsLabel.TabIndex = 24;
        teamsLabel.Text = "Teams";
        // 
        // tournamentsLabel
        // 
        tournamentsLabel.AutoSize = true;
        tournamentsLabel.Location = new Point(254, 191);
        tournamentsLabel.Name = "tournamentsLabel";
        tournamentsLabel.Size = new Size(204, 45);
        tournamentsLabel.TabIndex = 25;
        tournamentsLabel.Text = "Tournaments";
        // 
        // HomeForm
        // 
        AutoScaleDimensions = new SizeF(18F, 45F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(2012, 1036);
        Controls.Add(tournamentsLabel);
        Controls.Add(teamsLabel);
        Controls.Add(playersLabel);
        Controls.Add(tournamentsListBox);
        Controls.Add(teamsListBox);
        Controls.Add(playersListBox);
        Controls.Add(goToPlayerButton);
        Controls.Add(goToTeamButton);
        Controls.Add(goToTournamentButton);
        Controls.Add(addPlayerButton);
        Controls.Add(addTeamButton);
        Controls.Add(addTournamentButton);
        Controls.Add(titleLabel);
        Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
        ForeColor = Color.White;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(5);
        Name = "HomeForm";
        Text = "Login";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label titleLabel;
    private Button addTournamentButton;
    private Button addTeamButton;
    private Button addPlayerButton;
    private Button goToPlayerButton;
    private Button goToTeamButton;
    private Button goToTournamentButton;
    private ListBox playersListBox;
    private ListBox teamsListBox;
    private ListBox tournamentsListBox;
    private Label playersLabel;
    private Label teamsLabel;
    private Label tournamentsLabel;
}
