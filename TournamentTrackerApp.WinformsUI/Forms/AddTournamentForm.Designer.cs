namespace TournamentTrackerApp.WinformsUI;

partial class AddTournamentForm
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
        descriptionTextBox = new TextBox();
        locationTextBox = new TextBox();
        nameTextBox = new TextBox();
        descriptionLabel = new Label();
        locationLabel = new Label();
        nameLabel = new Label();
        createTournamentButton = new Button();
        SuspendLayout();
        // 
        // titleLabel
        // 
        titleLabel.AutoSize = true;
        titleLabel.Font = new Font("Segoe UI", 40F, FontStyle.Bold, GraphicsUnit.Point);
        titleLabel.ForeColor = Color.White;
        titleLabel.Location = new Point(455, 75);
        titleLabel.Margin = new Padding(5, 0, 5, 0);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(842, 106);
        titleLabel.TabIndex = 10;
        titleLabel.Text = "Create A Tournament";
        // 
        // descriptionTextBox
        // 
        descriptionTextBox.Location = new Point(651, 480);
        descriptionTextBox.Margin = new Padding(5);
        descriptionTextBox.Name = "descriptionTextBox";
        descriptionTextBox.Size = new Size(656, 50);
        descriptionTextBox.TabIndex = 19;
        // 
        // locationTextBox
        // 
        locationTextBox.Location = new Point(651, 391);
        locationTextBox.Margin = new Padding(5);
        locationTextBox.Name = "locationTextBox";
        locationTextBox.Size = new Size(656, 50);
        locationTextBox.TabIndex = 18;
        // 
        // nameTextBox
        // 
        nameTextBox.Location = new Point(651, 308);
        nameTextBox.Margin = new Padding(5);
        nameTextBox.Name = "nameTextBox";
        nameTextBox.Size = new Size(656, 50);
        nameTextBox.TabIndex = 17;
        nameTextBox.Tag = "";
        // 
        // descriptionLabel
        // 
        descriptionLabel.AutoSize = true;
        descriptionLabel.Location = new Point(349, 485);
        descriptionLabel.Name = "descriptionLabel";
        descriptionLabel.Size = new Size(198, 45);
        descriptionLabel.TabIndex = 16;
        descriptionLabel.Text = "Description :";
        // 
        // locationLabel
        // 
        locationLabel.AutoSize = true;
        locationLabel.Location = new Point(390, 396);
        locationLabel.Name = "locationLabel";
        locationLabel.Size = new Size(157, 45);
        locationLabel.TabIndex = 15;
        locationLabel.Text = "Location :";
        // 
        // nameLabel
        // 
        nameLabel.AutoSize = true;
        nameLabel.Location = new Point(414, 308);
        nameLabel.Name = "nameLabel";
        nameLabel.Size = new Size(121, 45);
        nameLabel.TabIndex = 14;
        nameLabel.Text = "Name :";
        // 
        // createTournamentButton
        // 
        createTournamentButton.ForeColor = Color.Black;
        createTournamentButton.Location = new Point(823, 635);
        createTournamentButton.Name = "createTournamentButton";
        createTournamentButton.Size = new Size(235, 92);
        createTournamentButton.TabIndex = 20;
        createTournamentButton.Text = "Create";
        createTournamentButton.UseVisualStyleBackColor = true;
        createTournamentButton.Click += createTournamentButton_Click;
        // 
        // AddTournamentForm
        // 
        AutoScaleDimensions = new SizeF(18F, 45F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(1858, 994);
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
        Name = "AddTournamentForm";
        Text = "AddTournament";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label titleLabel;
    private TextBox descriptionTextBox;
    private TextBox locationTextBox;
    private TextBox nameTextBox;
    private Label descriptionLabel;
    private Label locationLabel;
    private Label nameLabel;
    private Button createTournamentButton;
}