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
        homeTabs = new TabControl();
        tournamentsTab = new TabPage();
        addTournamentButton = new Button();
        tournamentsListView = new ListView();
        teamsTab = new TabPage();
        addTeamButton = new Button();
        teamsListView = new ListView();
        playersTab = new TabPage();
        addPlayerButton = new Button();
        playersListView = new ListView();
        homeTabs.SuspendLayout();
        tournamentsTab.SuspendLayout();
        teamsTab.SuspendLayout();
        playersTab.SuspendLayout();
        SuspendLayout();
        // 
        // titleLabel
        // 
        titleLabel.AutoSize = true;
        titleLabel.Font = new Font("Segoe UI", 40F, FontStyle.Bold, GraphicsUnit.Point);
        titleLabel.ForeColor = Color.White;
        titleLabel.Location = new Point(798, 53);
        titleLabel.Margin = new Padding(5, 0, 5, 0);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(271, 106);
        titleLabel.TabIndex = 9;
        titleLabel.Text = "Home";
        // 
        // homeTabs
        // 
        homeTabs.Controls.Add(tournamentsTab);
        homeTabs.Controls.Add(teamsTab);
        homeTabs.Controls.Add(playersTab);
        homeTabs.Location = new Point(223, 162);
        homeTabs.Name = "homeTabs";
        homeTabs.SelectedIndex = 0;
        homeTabs.Size = new Size(1582, 749);
        homeTabs.TabIndex = 10;
        // 
        // tournamentsTab
        // 
        tournamentsTab.BackColor = Color.Black;
        tournamentsTab.Controls.Add(addTournamentButton);
        tournamentsTab.Controls.Add(tournamentsListView);
        tournamentsTab.Location = new Point(4, 54);
        tournamentsTab.Name = "tournamentsTab";
        tournamentsTab.Padding = new Padding(3);
        tournamentsTab.Size = new Size(1574, 691);
        tournamentsTab.TabIndex = 0;
        tournamentsTab.Text = "Tournaments";
        // 
        // addTournamentButton
        // 
        addTournamentButton.BackColor = Color.White;
        addTournamentButton.FlatAppearance.BorderSize = 0;
        addTournamentButton.ForeColor = Color.Black;
        addTournamentButton.Location = new Point(571, 610);
        addTournamentButton.Name = "addTournamentButton";
        addTournamentButton.Size = new Size(388, 57);
        addTournamentButton.TabIndex = 3;
        addTournamentButton.Text = "Add a Tournament";
        addTournamentButton.UseVisualStyleBackColor = false;
        // 
        // tournamentsListView
        // 
        tournamentsListView.BackColor = Color.Black;
        tournamentsListView.ForeColor = Color.White;
        tournamentsListView.Location = new Point(19, 18);
        tournamentsListView.Name = "tournamentsListView";
        tournamentsListView.Size = new Size(1537, 562);
        tournamentsListView.TabIndex = 1;
        tournamentsListView.UseCompatibleStateImageBehavior = false;
        // 
        // teamsTab
        // 
        teamsTab.BackColor = Color.Black;
        teamsTab.Controls.Add(addTeamButton);
        teamsTab.Controls.Add(teamsListView);
        teamsTab.Location = new Point(4, 34);
        teamsTab.Name = "teamsTab";
        teamsTab.Padding = new Padding(3);
        teamsTab.Size = new Size(1574, 711);
        teamsTab.TabIndex = 1;
        teamsTab.Text = "Teams";
        // 
        // addTeamButton
        // 
        addTeamButton.BackColor = Color.White;
        addTeamButton.FlatAppearance.BorderSize = 0;
        addTeamButton.ForeColor = Color.Black;
        addTeamButton.Location = new Point(654, 605);
        addTeamButton.Name = "addTeamButton";
        addTeamButton.Size = new Size(265, 57);
        addTeamButton.TabIndex = 2;
        addTeamButton.Text = "Add a Team";
        addTeamButton.UseVisualStyleBackColor = false;
        // 
        // teamsListView
        // 
        teamsListView.BackColor = Color.Black;
        teamsListView.ForeColor = Color.White;
        teamsListView.Location = new Point(19, 18);
        teamsListView.Name = "teamsListView";
        teamsListView.Size = new Size(1537, 562);
        teamsListView.TabIndex = 1;
        teamsListView.UseCompatibleStateImageBehavior = false;
        // 
        // playersTab
        // 
        playersTab.BackColor = Color.Black;
        playersTab.Controls.Add(addPlayerButton);
        playersTab.Controls.Add(playersListView);
        playersTab.Location = new Point(4, 54);
        playersTab.Name = "playersTab";
        playersTab.Padding = new Padding(3);
        playersTab.Size = new Size(1574, 691);
        playersTab.TabIndex = 2;
        playersTab.Text = "Players";
        // 
        // addPlayerButton
        // 
        addPlayerButton.BackColor = Color.White;
        addPlayerButton.FlatAppearance.BorderSize = 0;
        addPlayerButton.ForeColor = Color.Black;
        addPlayerButton.Location = new Point(643, 601);
        addPlayerButton.Name = "addPlayerButton";
        addPlayerButton.Size = new Size(265, 57);
        addPlayerButton.TabIndex = 1;
        addPlayerButton.Text = "Add a Player";
        addPlayerButton.UseVisualStyleBackColor = false;
        addPlayerButton.Click += addPlayerButton_Click;
        // 
        // playersListView
        // 
        playersListView.BackColor = Color.Black;
        playersListView.ForeColor = Color.White;
        playersListView.Location = new Point(18, 15);
        playersListView.MultiSelect = false;
        playersListView.Name = "playersListView";
        playersListView.Size = new Size(1537, 562);
        playersListView.TabIndex = 0;
        playersListView.UseCompatibleStateImageBehavior = false;
        // 
        // HomeForm
        // 
        AutoScaleDimensions = new SizeF(18F, 45F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(2012, 1036);
        Controls.Add(homeTabs);
        Controls.Add(titleLabel);
        Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
        ForeColor = Color.White;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(5);
        Name = "HomeForm";
        Text = "Login";
        homeTabs.ResumeLayout(false);
        tournamentsTab.ResumeLayout(false);
        teamsTab.ResumeLayout(false);
        playersTab.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label titleLabel;
    private TabControl homeTabs;
    private TabPage tournamentsTab;
    private TabPage teamsTab;
    private TabPage playersTab;
    private ListView playersListView;
    private ListView tournamentsListView;
    private ListView teamsListView;
    private Button addPlayerButton;
    private Button addTournamentButton;
    private Button addTeamButton;
}
