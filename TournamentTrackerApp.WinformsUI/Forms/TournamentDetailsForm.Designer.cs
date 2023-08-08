namespace TournamentTrackerApp.WinformsUI;

partial class TournamentDetailsForm
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
        descriptionLabel = new Label();
        locationLabel = new Label();
        nameLabel = new Label();
        EditTournamentButton = new Button();
        descriptionValueLabel = new Label();
        locationValueLabel = new Label();
        nameValueLabel = new Label();
        TournamentTeamsButton = new Button();
        startTournamentButton = new Button();
        backButton = new Label();
        SuspendLayout();
        // 
        // titleLabel
        // 
        titleLabel.AutoSize = true;
        titleLabel.Font = new Font("Segoe UI", 40F, FontStyle.Bold, GraphicsUnit.Point);
        titleLabel.ForeColor = Color.White;
        titleLabel.Location = new Point(601, 66);
        titleLabel.Margin = new Padding(5, 0, 5, 0);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(705, 106);
        titleLabel.TabIndex = 10;
        titleLabel.Text = "Tournament Page";
        // 
        // descriptionLabel
        // 
        descriptionLabel.AutoSize = true;
        descriptionLabel.Location = new Point(1253, 318);
        descriptionLabel.Name = "descriptionLabel";
        descriptionLabel.Size = new Size(198, 45);
        descriptionLabel.TabIndex = 16;
        descriptionLabel.Text = "Description :";
        // 
        // locationLabel
        // 
        locationLabel.AutoSize = true;
        locationLabel.Location = new Point(654, 318);
        locationLabel.Name = "locationLabel";
        locationLabel.Size = new Size(157, 45);
        locationLabel.TabIndex = 15;
        locationLabel.Text = "Location :";
        // 
        // nameLabel
        // 
        nameLabel.AutoSize = true;
        nameLabel.Location = new Point(160, 318);
        nameLabel.Name = "nameLabel";
        nameLabel.Size = new Size(121, 45);
        nameLabel.TabIndex = 14;
        nameLabel.Text = "Name :";
        // 
        // EditTournamentButton
        // 
        EditTournamentButton.ForeColor = Color.Black;
        EditTournamentButton.Location = new Point(1404, 682);
        EditTournamentButton.Name = "EditTournamentButton";
        EditTournamentButton.Size = new Size(235, 92);
        EditTournamentButton.TabIndex = 20;
        EditTournamentButton.Text = "Edit";
        EditTournamentButton.UseVisualStyleBackColor = true;
        EditTournamentButton.Click += EditTournamentButton_Click;
        // 
        // descriptionValueLabel
        // 
        descriptionValueLabel.AutoSize = true;
        descriptionValueLabel.Location = new Point(1468, 318);
        descriptionValueLabel.Name = "descriptionValueLabel";
        descriptionValueLabel.Size = new Size(331, 45);
        descriptionValueLabel.TabIndex = 23;
        descriptionValueLabel.Text = "descriptionValueLabel";
        // 
        // locationValueLabel
        // 
        locationValueLabel.AutoSize = true;
        locationValueLabel.Location = new Point(837, 318);
        locationValueLabel.Name = "locationValueLabel";
        locationValueLabel.Size = new Size(286, 45);
        locationValueLabel.TabIndex = 22;
        locationValueLabel.Text = "locationValueLabel";
        // 
        // nameValueLabel
        // 
        nameValueLabel.AutoSize = true;
        nameValueLabel.Location = new Point(287, 318);
        nameValueLabel.Name = "nameValueLabel";
        nameValueLabel.Size = new Size(251, 45);
        nameValueLabel.TabIndex = 21;
        nameValueLabel.Text = "nameValueLabel";
        // 
        // TournamentTeamsButton
        // 
        TournamentTeamsButton.ForeColor = Color.Black;
        TournamentTeamsButton.Location = new Point(780, 682);
        TournamentTeamsButton.Name = "TournamentTeamsButton";
        TournamentTeamsButton.Size = new Size(358, 92);
        TournamentTeamsButton.TabIndex = 24;
        TournamentTeamsButton.Text = "Tournament's Team";
        TournamentTeamsButton.UseVisualStyleBackColor = true;
        TournamentTeamsButton.Click += TournamentTeamsButton_Click;
        // 
        // startTournamentButton
        // 
        startTournamentButton.ForeColor = Color.Black;
        startTournamentButton.Location = new Point(192, 682);
        startTournamentButton.Name = "startTournamentButton";
        startTournamentButton.Size = new Size(358, 92);
        startTournamentButton.TabIndex = 25;
        startTournamentButton.Text = "Start";
        startTournamentButton.UseVisualStyleBackColor = true;
        // 
        // backButton
        // 
        backButton.AutoSize = true;
        backButton.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
        backButton.Location = new Point(52, 66);
        backButton.Name = "backButton";
        backButton.Size = new Size(87, 81);
        backButton.TabIndex = 42;
        backButton.Text = "←";
        backButton.Click += backButton_Click;
        // 
        // TournamentDetailsForm
        // 
        AutoScaleDimensions = new SizeF(18F, 45F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(1858, 994);
        Controls.Add(backButton);
        Controls.Add(startTournamentButton);
        Controls.Add(TournamentTeamsButton);
        Controls.Add(descriptionValueLabel);
        Controls.Add(locationValueLabel);
        Controls.Add(nameValueLabel);
        Controls.Add(EditTournamentButton);
        Controls.Add(descriptionLabel);
        Controls.Add(locationLabel);
        Controls.Add(nameLabel);
        Controls.Add(titleLabel);
        Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
        ForeColor = Color.White;
        Margin = new Padding(5);
        Name = "TournamentDetailsForm";
        Text = "AddTournament";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label titleLabel;
    private Label descriptionLabel;
    private Label locationLabel;
    private Label nameLabel;
    private Button EditTournamentButton;
    private Label descriptionValueLabel;
    private Label locationValueLabel;
    private Label nameValueLabel;
    private Button TournamentTeamsButton;
    private Button startTournamentButton;
    private Label backButton;
}