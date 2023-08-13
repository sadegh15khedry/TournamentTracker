namespace TournamentTrackerApp.WinformsUI.Forms;

partial class SeriesDetailsForm
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
        titleLabel = new Label();
        backButton = new Label();
        secondTeamScoreTextBox = new TextBox();
        firstTeamScoreTextBox = new TextBox();
        submitMatchButton = new Button();
        firstTeamNameLabel = new Label();
        secondTeamNameLabel = new Label();
        firstMatchSecondTeamScoreLabel = new Label();
        secondMatchSecondTeamScoreLabel = new Label();
        thirdMatchSecondTeamScoreLabel = new Label();
        thirdMatchFirstTeamScoreLabel = new Label();
        SecondMatchFirstTeamScoreLabel = new Label();
        firstMatchFirstTeamScoreLabel = new Label();
        firstMatchVsLabel = new Label();
        secondMatchVsLabel = new Label();
        thirdMatchVsLabel = new Label();
        secondTeamWinsLabel = new Label();
        firstTeamWinsLabel = new Label();
        SuspendLayout();
        // 
        // titleLabel
        // 
        titleLabel.AutoSize = true;
        titleLabel.Font = new Font("Segoe UI", 40F, FontStyle.Bold, GraphicsUnit.Point);
        titleLabel.ForeColor = Color.White;
        titleLabel.Location = new Point(768, 87);
        titleLabel.Margin = new Padding(5, 0, 5, 0);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(266, 106);
        titleLabel.TabIndex = 21;
        titleLabel.Text = "Series";
        // 
        // backButton
        // 
        backButton.AutoSize = true;
        backButton.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
        backButton.Location = new Point(71, 87);
        backButton.Name = "backButton";
        backButton.Size = new Size(87, 81);
        backButton.TabIndex = 42;
        backButton.Text = "←";
        backButton.Click += backButton_Click;
        // 
        // secondTeamScoreTextBox
        // 
        secondTeamScoreTextBox.Location = new Point(1079, 705);
        secondTeamScoreTextBox.Margin = new Padding(5);
        secondTeamScoreTextBox.Name = "secondTeamScoreTextBox";
        secondTeamScoreTextBox.Size = new Size(656, 50);
        secondTeamScoreTextBox.TabIndex = 26;
        // 
        // firstTeamScoreTextBox
        // 
        firstTeamScoreTextBox.Location = new Point(202, 705);
        firstTeamScoreTextBox.Margin = new Padding(5);
        firstTeamScoreTextBox.Name = "firstTeamScoreTextBox";
        firstTeamScoreTextBox.Size = new Size(656, 50);
        firstTeamScoreTextBox.TabIndex = 27;
        // 
        // submitMatchButton
        // 
        submitMatchButton.ForeColor = Color.Black;
        submitMatchButton.Location = new Point(843, 831);
        submitMatchButton.Name = "submitMatchButton";
        submitMatchButton.Size = new Size(235, 92);
        submitMatchButton.TabIndex = 28;
        submitMatchButton.Text = "submit";
        submitMatchButton.UseVisualStyleBackColor = true;
        submitMatchButton.Click += submitMatchButton_Click;
        // 
        // firstTeamNameLabel
        // 
        firstTeamNameLabel.AutoSize = true;
        firstTeamNameLabel.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
        firstTeamNameLabel.ForeColor = Color.White;
        firstTeamNameLabel.Location = new Point(211, 222);
        firstTeamNameLabel.Margin = new Padding(5, 0, 5, 0);
        firstTeamNameLabel.Name = "firstTeamNameLabel";
        firstTeamNameLabel.Size = new Size(513, 67);
        firstTeamNameLabel.TabIndex = 43;
        firstTeamNameLabel.Text = "firstTeamNameLabel";
        // 
        // secondTeamNameLabel
        // 
        secondTeamNameLabel.AutoSize = true;
        secondTeamNameLabel.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
        secondTeamNameLabel.ForeColor = Color.White;
        secondTeamNameLabel.Location = new Point(1229, 222);
        secondTeamNameLabel.Margin = new Padding(5, 0, 5, 0);
        secondTeamNameLabel.Name = "secondTeamNameLabel";
        secondTeamNameLabel.Size = new Size(584, 67);
        secondTeamNameLabel.TabIndex = 44;
        secondTeamNameLabel.Text = "secondTeamNameLabel";
        // 
        // firstMatchSecondTeamScoreLabel
        // 
        firstMatchSecondTeamScoreLabel.AutoSize = true;
        firstMatchSecondTeamScoreLabel.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
        firstMatchSecondTeamScoreLabel.ForeColor = Color.White;
        firstMatchSecondTeamScoreLabel.Location = new Point(1111, 337);
        firstMatchSecondTeamScoreLabel.Margin = new Padding(5, 0, 5, 0);
        firstMatchSecondTeamScoreLabel.Name = "firstMatchSecondTeamScoreLabel";
        firstMatchSecondTeamScoreLabel.Size = new Size(40, 46);
        firstMatchSecondTeamScoreLabel.TabIndex = 45;
        firstMatchSecondTeamScoreLabel.Text = "0";
        // 
        // secondMatchSecondTeamScoreLabel
        // 
        secondMatchSecondTeamScoreLabel.AutoSize = true;
        secondMatchSecondTeamScoreLabel.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
        secondMatchSecondTeamScoreLabel.ForeColor = Color.White;
        secondMatchSecondTeamScoreLabel.Location = new Point(1111, 448);
        secondMatchSecondTeamScoreLabel.Margin = new Padding(5, 0, 5, 0);
        secondMatchSecondTeamScoreLabel.Name = "secondMatchSecondTeamScoreLabel";
        secondMatchSecondTeamScoreLabel.Size = new Size(40, 46);
        secondMatchSecondTeamScoreLabel.TabIndex = 46;
        secondMatchSecondTeamScoreLabel.Text = "0";
        // 
        // thirdMatchSecondTeamScoreLabel
        // 
        thirdMatchSecondTeamScoreLabel.AutoSize = true;
        thirdMatchSecondTeamScoreLabel.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
        thirdMatchSecondTeamScoreLabel.ForeColor = Color.White;
        thirdMatchSecondTeamScoreLabel.Location = new Point(1111, 549);
        thirdMatchSecondTeamScoreLabel.Margin = new Padding(5, 0, 5, 0);
        thirdMatchSecondTeamScoreLabel.Name = "thirdMatchSecondTeamScoreLabel";
        thirdMatchSecondTeamScoreLabel.Size = new Size(40, 46);
        thirdMatchSecondTeamScoreLabel.TabIndex = 47;
        thirdMatchSecondTeamScoreLabel.Text = "0";
        // 
        // thirdMatchFirstTeamScoreLabel
        // 
        thirdMatchFirstTeamScoreLabel.AutoSize = true;
        thirdMatchFirstTeamScoreLabel.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
        thirdMatchFirstTeamScoreLabel.ForeColor = Color.White;
        thirdMatchFirstTeamScoreLabel.Location = new Point(833, 549);
        thirdMatchFirstTeamScoreLabel.Margin = new Padding(5, 0, 5, 0);
        thirdMatchFirstTeamScoreLabel.Name = "thirdMatchFirstTeamScoreLabel";
        thirdMatchFirstTeamScoreLabel.Size = new Size(40, 46);
        thirdMatchFirstTeamScoreLabel.TabIndex = 48;
        thirdMatchFirstTeamScoreLabel.Text = "0";
        // 
        // SecondMatchFirstTeamScoreLabel
        // 
        SecondMatchFirstTeamScoreLabel.AutoSize = true;
        SecondMatchFirstTeamScoreLabel.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
        SecondMatchFirstTeamScoreLabel.ForeColor = Color.White;
        SecondMatchFirstTeamScoreLabel.Location = new Point(833, 448);
        SecondMatchFirstTeamScoreLabel.Margin = new Padding(5, 0, 5, 0);
        SecondMatchFirstTeamScoreLabel.Name = "SecondMatchFirstTeamScoreLabel";
        SecondMatchFirstTeamScoreLabel.Size = new Size(40, 46);
        SecondMatchFirstTeamScoreLabel.TabIndex = 49;
        SecondMatchFirstTeamScoreLabel.Text = "0";
        // 
        // firstMatchFirstTeamScoreLabel
        // 
        firstMatchFirstTeamScoreLabel.AutoSize = true;
        firstMatchFirstTeamScoreLabel.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
        firstMatchFirstTeamScoreLabel.ForeColor = Color.White;
        firstMatchFirstTeamScoreLabel.Location = new Point(833, 337);
        firstMatchFirstTeamScoreLabel.Margin = new Padding(5, 0, 5, 0);
        firstMatchFirstTeamScoreLabel.Name = "firstMatchFirstTeamScoreLabel";
        firstMatchFirstTeamScoreLabel.Size = new Size(40, 46);
        firstMatchFirstTeamScoreLabel.TabIndex = 50;
        firstMatchFirstTeamScoreLabel.Text = "0";
        // 
        // firstMatchVsLabel
        // 
        firstMatchVsLabel.AutoSize = true;
        firstMatchVsLabel.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
        firstMatchVsLabel.ForeColor = Color.White;
        firstMatchVsLabel.Location = new Point(965, 337);
        firstMatchVsLabel.Margin = new Padding(5, 0, 5, 0);
        firstMatchVsLabel.Name = "firstMatchVsLabel";
        firstMatchVsLabel.Size = new Size(53, 46);
        firstMatchVsLabel.TabIndex = 51;
        firstMatchVsLabel.Text = "vs";
        // 
        // secondMatchVsLabel
        // 
        secondMatchVsLabel.AutoSize = true;
        secondMatchVsLabel.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
        secondMatchVsLabel.ForeColor = Color.White;
        secondMatchVsLabel.Location = new Point(965, 448);
        secondMatchVsLabel.Margin = new Padding(5, 0, 5, 0);
        secondMatchVsLabel.Name = "secondMatchVsLabel";
        secondMatchVsLabel.Size = new Size(53, 46);
        secondMatchVsLabel.TabIndex = 52;
        secondMatchVsLabel.Text = "vs";
        // 
        // thirdMatchVsLabel
        // 
        thirdMatchVsLabel.AutoSize = true;
        thirdMatchVsLabel.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
        thirdMatchVsLabel.ForeColor = Color.White;
        thirdMatchVsLabel.Location = new Point(965, 549);
        thirdMatchVsLabel.Margin = new Padding(5, 0, 5, 0);
        thirdMatchVsLabel.Name = "thirdMatchVsLabel";
        thirdMatchVsLabel.Size = new Size(53, 46);
        thirdMatchVsLabel.TabIndex = 53;
        thirdMatchVsLabel.Text = "vs";
        // 
        // secondTeamWinsLabel
        // 
        secondTeamWinsLabel.AutoSize = true;
        secondTeamWinsLabel.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
        secondTeamWinsLabel.ForeColor = Color.White;
        secondTeamWinsLabel.Location = new Point(1499, 337);
        secondTeamWinsLabel.Margin = new Padding(5, 0, 5, 0);
        secondTeamWinsLabel.Name = "secondTeamWinsLabel";
        secondTeamWinsLabel.Size = new Size(40, 46);
        secondTeamWinsLabel.TabIndex = 54;
        secondTeamWinsLabel.Text = "0";
        // 
        // firstTeamWinsLabel
        // 
        firstTeamWinsLabel.AutoSize = true;
        firstTeamWinsLabel.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
        firstTeamWinsLabel.ForeColor = Color.White;
        firstTeamWinsLabel.Location = new Point(424, 337);
        firstTeamWinsLabel.Margin = new Padding(5, 0, 5, 0);
        firstTeamWinsLabel.Name = "firstTeamWinsLabel";
        firstTeamWinsLabel.Size = new Size(40, 46);
        firstTeamWinsLabel.TabIndex = 55;
        firstTeamWinsLabel.Text = "0";
        // 
        // SeriesDetailsForm
        // 
        AutoScaleDimensions = new SizeF(18F, 45F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(1846, 1001);
        Controls.Add(firstTeamWinsLabel);
        Controls.Add(secondTeamWinsLabel);
        Controls.Add(thirdMatchVsLabel);
        Controls.Add(secondMatchVsLabel);
        Controls.Add(firstMatchVsLabel);
        Controls.Add(firstMatchFirstTeamScoreLabel);
        Controls.Add(SecondMatchFirstTeamScoreLabel);
        Controls.Add(thirdMatchFirstTeamScoreLabel);
        Controls.Add(thirdMatchSecondTeamScoreLabel);
        Controls.Add(secondMatchSecondTeamScoreLabel);
        Controls.Add(firstMatchSecondTeamScoreLabel);
        Controls.Add(secondTeamNameLabel);
        Controls.Add(firstTeamNameLabel);
        Controls.Add(backButton);
        Controls.Add(submitMatchButton);
        Controls.Add(firstTeamScoreTextBox);
        Controls.Add(secondTeamScoreTextBox);
        Controls.Add(titleLabel);
        Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
        ForeColor = Color.White;
        Margin = new Padding(5);
        Name = "SeriesDetailsForm";
        Text = "AddTeam";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button submitMatchButton;
    private Label titleLabel;
    private Label backButton;
    private Label firstTeamNameLabel;
    private Label secondTeamNameLabel;
    private Label firstMatchSecondTeamScoreLabel;
    private Label secondMatchSecondTeamScoreLabel;
    private Label thirdMatchSecondTeamScoreLabel;
    private Label thirdMatchFirstTeamScoreLabel;
    private Label SecondMatchFirstTeamScoreLabel;
    private Label firstMatchFirstTeamScoreLabel;
    private Label firstMatchVsLabel;
    private Label secondMatchVsLabel;
    private Label thirdMatchVsLabel;
    private TextBox secondTeamScoreTextBox;
    private TextBox firstTeamScoreTextBox;
    private Label secondTeamWinsLabel;
    private Label firstTeamWinsLabel;
}