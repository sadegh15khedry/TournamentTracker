namespace TournamentTrackerApp.WinformsUI.Forms;

partial class AddTeam
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
        createTournamentButton = new Button();
        descriptionTextBox = new TextBox();
        locationTextBox = new TextBox();
        nameTextBox = new TextBox();
        descriptionLabel = new Label();
        locationLabel = new Label();
        nameLabel = new Label();
        titleLabel = new Label();
        SuspendLayout();
        // 
        // createTournamentButton
        // 
        createTournamentButton.ForeColor = Color.Black;
        createTournamentButton.Location = new Point(913, 677);
        createTournamentButton.Name = "createTournamentButton";
        createTournamentButton.Size = new Size(235, 92);
        createTournamentButton.TabIndex = 28;
        createTournamentButton.Text = "Create";
        createTournamentButton.UseVisualStyleBackColor = true;
        createTournamentButton.Click += createTeamButton_Click;
        // 
        // descriptionTextBox
        // 
        descriptionTextBox.Location = new Point(741, 522);
        descriptionTextBox.Margin = new Padding(5);
        descriptionTextBox.Name = "descriptionTextBox";
        descriptionTextBox.Size = new Size(656, 50);
        descriptionTextBox.TabIndex = 27;
        // 
        // locationTextBox
        // 
        locationTextBox.Location = new Point(741, 433);
        locationTextBox.Margin = new Padding(5);
        locationTextBox.Name = "locationTextBox";
        locationTextBox.Size = new Size(656, 50);
        locationTextBox.TabIndex = 26;
        // 
        // nameTextBox
        // 
        nameTextBox.Location = new Point(741, 350);
        nameTextBox.Margin = new Padding(5);
        nameTextBox.Name = "nameTextBox";
        nameTextBox.Size = new Size(656, 50);
        nameTextBox.TabIndex = 25;
        // 
        // descriptionLabel
        // 
        descriptionLabel.AutoSize = true;
        descriptionLabel.Location = new Point(439, 527);
        descriptionLabel.Name = "descriptionLabel";
        descriptionLabel.Size = new Size(198, 45);
        descriptionLabel.TabIndex = 24;
        descriptionLabel.Text = "Description :";
        // 
        // locationLabel
        // 
        locationLabel.AutoSize = true;
        locationLabel.Location = new Point(480, 438);
        locationLabel.Name = "locationLabel";
        locationLabel.Size = new Size(157, 45);
        locationLabel.TabIndex = 23;
        locationLabel.Text = "Location :";
        // 
        // nameLabel
        // 
        nameLabel.AutoSize = true;
        nameLabel.Location = new Point(504, 350);
        nameLabel.Name = "nameLabel";
        nameLabel.Size = new Size(121, 45);
        nameLabel.TabIndex = 22;
        nameLabel.Text = "Name :";
        // 
        // titleLabel
        // 
        titleLabel.AutoSize = true;
        titleLabel.Font = new Font("Segoe UI", 40F, FontStyle.Bold, GraphicsUnit.Point);
        titleLabel.ForeColor = Color.White;
        titleLabel.Location = new Point(622, 87);
        titleLabel.Margin = new Padding(5, 0, 5, 0);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(586, 106);
        titleLabel.TabIndex = 21;
        titleLabel.Text = "Create A Team";
        // 
        // AddTeam
        // 
        AutoScaleDimensions = new SizeF(18F, 45F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(1846, 1001);
        Controls.Add(createTournamentButton);
        Controls.Add(descriptionTextBox);
        Controls.Add(locationTextBox);
        Controls.Add(nameTextBox);
        Controls.Add(descriptionLabel);
        Controls.Add(locationLabel);
        Controls.Add(nameLabel);
        Controls.Add(titleLabel);
        Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
        ForeColor = Color.White;
        Margin = new Padding(5);
        Name = "AddTeam";
        Text = "AddTeam";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button createTournamentButton;
    private TextBox descriptionTextBox;
    private TextBox locationTextBox;
    private TextBox nameTextBox;
    private Label descriptionLabel;
    private Label locationLabel;
    private Label nameLabel;
    private Label titleLabel;
}