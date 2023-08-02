namespace TournamentTrackerApp.WinformsUI.Forms;

partial class AddTeamForm
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
        ownerTextBox = new TextBox();
        cityTextBox = new TextBox();
        nameTextBox = new TextBox();
        ownerLabel = new Label();
        cityLabel = new Label();
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
        // ownerTextBox
        // 
        ownerTextBox.Location = new Point(741, 522);
        ownerTextBox.Margin = new Padding(5);
        ownerTextBox.Name = "ownerTextBox";
        ownerTextBox.Size = new Size(656, 50);
        ownerTextBox.TabIndex = 27;
        // 
        // cityTextBox
        // 
        cityTextBox.Location = new Point(741, 433);
        cityTextBox.Margin = new Padding(5);
        cityTextBox.Name = "cityTextBox";
        cityTextBox.Size = new Size(656, 50);
        cityTextBox.TabIndex = 26;
        // 
        // nameTextBox
        // 
        nameTextBox.Location = new Point(741, 350);
        nameTextBox.Margin = new Padding(5);
        nameTextBox.Name = "nameTextBox";
        nameTextBox.Size = new Size(656, 50);
        nameTextBox.TabIndex = 25;
        // 
        // ownerLabel
        // 
        ownerLabel.AutoSize = true;
        ownerLabel.Location = new Point(439, 527);
        ownerLabel.Name = "ownerLabel";
        ownerLabel.Size = new Size(138, 45);
        ownerLabel.TabIndex = 24;
        ownerLabel.Text = "Owner  :";
        // 
        // cityLabel
        // 
        cityLabel.AutoSize = true;
        cityLabel.Location = new Point(523, 438);
        cityLabel.Name = "cityLabel";
        cityLabel.Size = new Size(90, 45);
        cityLabel.TabIndex = 23;
        cityLabel.Text = "City :";
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
        // AddTeamForm
        // 
        AutoScaleDimensions = new SizeF(18F, 45F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(1846, 1001);
        Controls.Add(createTournamentButton);
        Controls.Add(ownerTextBox);
        Controls.Add(cityTextBox);
        Controls.Add(nameTextBox);
        Controls.Add(ownerLabel);
        Controls.Add(cityLabel);
        Controls.Add(nameLabel);
        Controls.Add(titleLabel);
        Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
        ForeColor = Color.White;
        Margin = new Padding(5);
        Name = "AddTeamForm";
        Text = "AddTeam";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button createTournamentButton;
    private TextBox ownerTextBox;
    private TextBox cityTextBox;
    private TextBox nameTextBox;
    private Label ownerLabel;
    private Label cityLabel;
    private Label nameLabel;
    private Label titleLabel;
}