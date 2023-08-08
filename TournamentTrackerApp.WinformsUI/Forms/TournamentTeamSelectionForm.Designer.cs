namespace TournamentTrackerApp.WinformsUI;

partial class TournamentTeamSelectionForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        addTeamButton = new Button();
        teamsComboBox = new ComboBox();
        titleLabel = new Label();
        selectedTeamsListBox = new ListBox();
        removeSelectedFromListButton = new Button();
        DoneButton = new Button();
        backButton = new Label();
        SuspendLayout();
        // 
        // addTeamButton
        // 
        addTeamButton.ForeColor = Color.Black;
        addTeamButton.Location = new Point(293, 437);
        addTeamButton.Margin = new Padding(5);
        addTeamButton.Name = "addTeamButton";
        addTeamButton.Size = new Size(202, 61);
        addTeamButton.TabIndex = 17;
        addTeamButton.Text = "Add";
        addTeamButton.UseVisualStyleBackColor = true;
        addTeamButton.Click += addTeamToTournamentButton_Click;
        // 
        // teamsComboBox
        // 
        teamsComboBox.BackColor = Color.White;
        teamsComboBox.FormattingEnabled = true;
        teamsComboBox.Location = new Point(97, 333);
        teamsComboBox.Name = "teamsComboBox";
        teamsComboBox.Size = new Size(653, 53);
        teamsComboBox.TabIndex = 16;
        teamsComboBox.Text = "Choose a Team";
        // 
        // titleLabel
        // 
        titleLabel.AutoSize = true;
        titleLabel.Font = new Font("Segoe UI", 40F, FontStyle.Bold, GraphicsUnit.Point);
        titleLabel.ForeColor = Color.White;
        titleLabel.Location = new Point(454, 94);
        titleLabel.Margin = new Padding(5, 0, 5, 0);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(875, 106);
        titleLabel.TabIndex = 15;
        titleLabel.Text = "@nameOfTournament";
        // 
        // selectedTeamsListBox
        // 
        selectedTeamsListBox.FormattingEnabled = true;
        selectedTeamsListBox.ItemHeight = 45;
        selectedTeamsListBox.Location = new Point(899, 263);
        selectedTeamsListBox.Name = "selectedTeamsListBox";
        selectedTeamsListBox.Size = new Size(746, 454);
        selectedTeamsListBox.TabIndex = 19;
        // 
        // removeSelectedFromListButton
        // 
        removeSelectedFromListButton.ForeColor = Color.Black;
        removeSelectedFromListButton.Location = new Point(1173, 750);
        removeSelectedFromListButton.Margin = new Padding(5);
        removeSelectedFromListButton.Name = "removeSelectedFromListButton";
        removeSelectedFromListButton.Size = new Size(202, 61);
        removeSelectedFromListButton.TabIndex = 20;
        removeSelectedFromListButton.Text = "Remove";
        removeSelectedFromListButton.UseVisualStyleBackColor = true;
        removeSelectedFromListButton.Click += removeSelectedFromListButton_Click;
        // 
        // DoneButton
        // 
        DoneButton.ForeColor = Color.Black;
        DoneButton.Location = new Point(676, 870);
        DoneButton.Margin = new Padding(5);
        DoneButton.Name = "DoneButton";
        DoneButton.Size = new Size(436, 61);
        DoneButton.TabIndex = 21;
        DoneButton.Text = "Done";
        DoneButton.UseVisualStyleBackColor = true;
        DoneButton.Click += startTournamentButton_Click;
        // 
        // backButton
        // 
        backButton.AutoSize = true;
        backButton.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
        backButton.Location = new Point(63, 77);
        backButton.Name = "backButton";
        backButton.Size = new Size(87, 81);
        backButton.TabIndex = 43;
        backButton.Text = "←";
        backButton.Click += backButton_Click;
        // 
        // TournamentTeamSelectionForm
        // 
        AutoScaleDimensions = new SizeF(18F, 45F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(1752, 1032);
        Controls.Add(backButton);
        Controls.Add(DoneButton);
        Controls.Add(removeSelectedFromListButton);
        Controls.Add(selectedTeamsListBox);
        Controls.Add(addTeamButton);
        Controls.Add(teamsComboBox);
        Controls.Add(titleLabel);
        Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
        ForeColor = Color.White;
        Margin = new Padding(5);
        Name = "TournamentTeamSelectionForm";
        Text = "TournamentTeamSelection";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label goToAddTeamButton;
    private Button addTeamButton;
    private ComboBox teamsComboBox;
    private Label titleLabel;
    private ListBox selectedTeamsListBox;
    private Button removeSelectedFromListButton;
    private Button startTournametButton;
    private Button DoneButton;
    private Label backButton;
}