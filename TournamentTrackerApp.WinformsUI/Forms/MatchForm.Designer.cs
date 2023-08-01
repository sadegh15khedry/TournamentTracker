namespace TournamentTrackerApp.WinformsUI.Forms;

partial class MatchForm
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
        teamAScoreTextBox = new TextBox();
        teanALabel = new Label();
        matchSubmitButton = new Button();
        teamBScoreTextBox = new TextBox();
        teamBLabel = new Label();
        titleLabel = new Label();
        tournamentLabel = new Label();
        roundLabel = new Label();
        matchNumberLabel = new Label();
        tournamentValueLabel = new Label();
        roundNumberValueLabel = new Label();
        machNumberValueLabel = new Label();
        SuspendLayout();
        // 
        // teamAScoreTextBox
        // 
        teamAScoreTextBox.Location = new Point(1143, 441);
        teamAScoreTextBox.Margin = new Padding(5);
        teamAScoreTextBox.Name = "teamAScoreTextBox";
        teamAScoreTextBox.Size = new Size(172, 50);
        teamAScoreTextBox.TabIndex = 48;
        // 
        // teanALabel
        // 
        teanALabel.AutoSize = true;
        teanALabel.Location = new Point(1143, 347);
        teanALabel.Name = "teanALabel";
        teanALabel.Size = new Size(125, 45);
        teanALabel.TabIndex = 47;
        teanALabel.Text = "Team A";
        // 
        // matchSubmitButton
        // 
        matchSubmitButton.ForeColor = Color.Black;
        matchSubmitButton.Location = new Point(1279, 589);
        matchSubmitButton.Name = "matchSubmitButton";
        matchSubmitButton.Size = new Size(235, 92);
        matchSubmitButton.TabIndex = 46;
        matchSubmitButton.Text = "Submit";
        matchSubmitButton.UseVisualStyleBackColor = true;
        matchSubmitButton.Click += matchSubmitButton_Click;
        // 
        // teamBScoreTextBox
        // 
        teamBScoreTextBox.Location = new Point(1435, 441);
        teamBScoreTextBox.Margin = new Padding(5);
        teamBScoreTextBox.Name = "teamBScoreTextBox";
        teamBScoreTextBox.Size = new Size(172, 50);
        teamBScoreTextBox.TabIndex = 43;
        // 
        // teamBLabel
        // 
        teamBLabel.AutoSize = true;
        teamBLabel.Location = new Point(1435, 347);
        teamBLabel.Name = "teamBLabel";
        teamBLabel.Size = new Size(122, 45);
        teamBLabel.TabIndex = 40;
        teamBLabel.Text = "Team B";
        // 
        // titleLabel
        // 
        titleLabel.AutoSize = true;
        titleLabel.Font = new Font("Segoe UI", 40F, FontStyle.Bold, GraphicsUnit.Point);
        titleLabel.ForeColor = Color.White;
        titleLabel.Location = new Point(810, 69);
        titleLabel.Margin = new Padding(5, 0, 5, 0);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(282, 106);
        titleLabel.TabIndex = 39;
        titleLabel.Text = "Match";
        // 
        // tournamentLabel
        // 
        tournamentLabel.AutoSize = true;
        tournamentLabel.Location = new Point(200, 293);
        tournamentLabel.Name = "tournamentLabel";
        tournamentLabel.Size = new Size(206, 45);
        tournamentLabel.TabIndex = 49;
        tournamentLabel.Text = "Tournament :";
        // 
        // roundLabel
        // 
        roundLabel.AutoSize = true;
        roundLabel.Location = new Point(202, 441);
        roundLabel.Name = "roundLabel";
        roundLabel.Size = new Size(128, 45);
        roundLabel.TabIndex = 50;
        roundLabel.Text = "Round :";
        roundLabel.Click += label2_Click;
        // 
        // matchNumberLabel
        // 
        matchNumberLabel.AutoSize = true;
        matchNumberLabel.Location = new Point(208, 666);
        matchNumberLabel.Name = "matchNumberLabel";
        matchNumberLabel.Size = new Size(418, 45);
        matchNumberLabel.TabIndex = 51;
        matchNumberLabel.Text = "Number OF Mach In Series :";
        // 
        // tournamentValueLabel
        // 
        tournamentValueLabel.AutoSize = true;
        tournamentValueLabel.Location = new Point(437, 293);
        tournamentValueLabel.Name = "tournamentValueLabel";
        tournamentValueLabel.Size = new Size(323, 45);
        tournamentValueLabel.TabIndex = 52;
        tournamentValueLabel.Text = "@nameOfTounament";
        // 
        // roundNumberValueLabel
        // 
        roundNumberValueLabel.AutoSize = true;
        roundNumberValueLabel.Location = new Point(365, 444);
        roundNumberValueLabel.Name = "roundNumberValueLabel";
        roundNumberValueLabel.Size = new Size(253, 45);
        roundNumberValueLabel.TabIndex = 53;
        roundNumberValueLabel.Text = "@roundNumber";
        // 
        // machNumberValueLabel
        // 
        machNumberValueLabel.AutoSize = true;
        machNumberValueLabel.Location = new Point(648, 666);
        machNumberValueLabel.Name = "machNumberValueLabel";
        machNumberValueLabel.Size = new Size(285, 45);
        machNumberValueLabel.TabIndex = 54;
        machNumberValueLabel.Text = "@numberOfMatch";
        // 
        // Match
        // 
        AutoScaleDimensions = new SizeF(18F, 45F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(1859, 1211);
        Controls.Add(machNumberValueLabel);
        Controls.Add(roundNumberValueLabel);
        Controls.Add(tournamentValueLabel);
        Controls.Add(matchNumberLabel);
        Controls.Add(roundLabel);
        Controls.Add(tournamentLabel);
        Controls.Add(teamAScoreTextBox);
        Controls.Add(teanALabel);
        Controls.Add(matchSubmitButton);
        Controls.Add(teamBScoreTextBox);
        Controls.Add(teamBLabel);
        Controls.Add(titleLabel);
        Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
        ForeColor = Color.White;
        Margin = new Padding(5);
        Name = "Match";
        Text = "Match";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox teamAScoreTextBox;
    private Label teanALabel;
    private Button matchSubmitButton;
    private TextBox teamBScoreTextBox;
    private Label teamBLabel;
    private Label titleLabel;
    private Label tournamentLabel;
    private Label roundLabel;
    private Label matchNumberLabel;
    private Label tournamentValueLabel;
    private Label roundNumberValueLabel;
    private Label machNumberValueLabel;
}