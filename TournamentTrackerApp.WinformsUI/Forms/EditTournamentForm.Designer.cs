namespace TournamentTrackerApp.WinformsUI;

partial class EditTournamentForm
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
        submitButton = new Button();
        backButton = new Label();
        nameTextBox = new TextBox();
        locationTextBox = new TextBox();
        descriptionTextBox = new TextBox();
        SuspendLayout();
        // 
        // titleLabel
        // 
        titleLabel.AutoSize = true;
        titleLabel.Font = new Font("Segoe UI", 40F, FontStyle.Bold, GraphicsUnit.Point);
        titleLabel.ForeColor = Color.White;
        titleLabel.Location = new Point(576, 75);
        titleLabel.Margin = new Padding(5, 0, 5, 0);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(669, 106);
        titleLabel.TabIndex = 10;
        titleLabel.Text = "Edit Tournament";
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
        // submitButton
        // 
        submitButton.ForeColor = Color.Black;
        submitButton.Location = new Point(823, 635);
        submitButton.Name = "submitButton";
        submitButton.Size = new Size(235, 92);
        submitButton.TabIndex = 20;
        submitButton.Text = "Submit";
        submitButton.UseVisualStyleBackColor = true;
        submitButton.Click += editTournamentButton_Click;
        // 
        // backButton
        // 
        backButton.AutoSize = true;
        backButton.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
        backButton.Location = new Point(69, 75);
        backButton.Name = "backButton";
        backButton.Size = new Size(87, 81);
        backButton.TabIndex = 42;
        backButton.Text = "←";
        backButton.Click += backButton_Click;
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
        // locationTextBox
        // 
        locationTextBox.Location = new Point(651, 391);
        locationTextBox.Margin = new Padding(5);
        locationTextBox.Name = "locationTextBox";
        locationTextBox.Size = new Size(656, 50);
        locationTextBox.TabIndex = 18;
        // 
        // descriptionTextBox
        // 
        descriptionTextBox.Location = new Point(651, 480);
        descriptionTextBox.Margin = new Padding(5);
        descriptionTextBox.Name = "descriptionTextBox";
        descriptionTextBox.Size = new Size(656, 50);
        descriptionTextBox.TabIndex = 19;
        // 
        // AddTournamentForm
        // 
        AutoScaleDimensions = new SizeF(18F, 45F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(1858, 994);
        Controls.Add(backButton);
        Controls.Add(submitButton);
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
    private Label descriptionLabel;
    private Label locationLabel;
    private Label nameLabel;
    private Button submitButton;
    private Label backButton;
    private TextBox nameTextBox;
    private TextBox locationTextBox;
    private TextBox descriptionTextBox;
}