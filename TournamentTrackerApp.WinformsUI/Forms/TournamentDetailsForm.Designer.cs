namespace TournamentTrackerApp.WinformsUI;

partial class TournamentDetailsForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerDetailsForm));
        titleLabel = new Label();
        idLabel = new Label();
        SSNLabel = new Label();
        firstNameLabel = new Label();
        lastNameLabel = new Label();
        emailLabel = new Label();
        phoneLabel = new Label();
        teamLabel = new Label();
        idValueLabel = new Label();
        firstNameValueLabel = new Label();
        lastNameValueLabel = new Label();
        SSNValueLabel = new Label();
        teamValueLabel = new Label();
        phoneValueLabel = new Label();
        emailValueLabel = new Label();
        editPlayerButton = new Button();
        backButton = new Label();
        SuspendLayout();
        // 
        // titleLabel
        // 
        titleLabel.AutoSize = true;
        titleLabel.Font = new Font("Segoe UI", 40F, FontStyle.Bold, GraphicsUnit.Point);
        titleLabel.ForeColor = Color.White;
        titleLabel.Location = new Point(727, 39);
        titleLabel.Margin = new Padding(5, 0, 5, 0);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(482, 106);
        titleLabel.TabIndex = 9;
        titleLabel.Text = "Player Page";
        // 
        // idLabel
        // 
        idLabel.AutoSize = true;
        idLabel.Location = new Point(187, 328);
        idLabel.Name = "idLabel";
        idLabel.Size = new Size(64, 45);
        idLabel.TabIndex = 10;
        idLabel.Text = "Id :";
        // 
        // SSNLabel
        // 
        SSNLabel.AutoSize = true;
        SSNLabel.Location = new Point(1656, 328);
        SSNLabel.Name = "SSNLabel";
        SSNLabel.Size = new Size(103, 45);
        SSNLabel.TabIndex = 11;
        SSNLabel.Text = "SSN : ";
        // 
        // firstNameLabel
        // 
        firstNameLabel.AutoSize = true;
        firstNameLabel.Location = new Point(521, 328);
        firstNameLabel.Name = "firstNameLabel";
        firstNameLabel.Size = new Size(190, 45);
        firstNameLabel.TabIndex = 12;
        firstNameLabel.Text = "First Name :";
        // 
        // lastNameLabel
        // 
        lastNameLabel.AutoSize = true;
        lastNameLabel.Location = new Point(1131, 328);
        lastNameLabel.Name = "lastNameLabel";
        lastNameLabel.Size = new Size(186, 45);
        lastNameLabel.TabIndex = 13;
        lastNameLabel.Text = "Last Name :";
        // 
        // emailLabel
        // 
        emailLabel.AutoSize = true;
        emailLabel.Location = new Point(1351, 476);
        emailLabel.Name = "emailLabel";
        emailLabel.Size = new Size(112, 45);
        emailLabel.TabIndex = 17;
        emailLabel.Text = "Email :";
        // 
        // phoneLabel
        // 
        phoneLabel.AutoSize = true;
        phoneLabel.Location = new Point(860, 476);
        phoneLabel.Name = "phoneLabel";
        phoneLabel.Size = new Size(126, 45);
        phoneLabel.TabIndex = 16;
        phoneLabel.Text = "Phone :";
        // 
        // teamLabel
        // 
        teamLabel.AutoSize = true;
        teamLabel.Location = new Point(432, 476);
        teamLabel.Name = "teamLabel";
        teamLabel.Size = new Size(111, 45);
        teamLabel.TabIndex = 14;
        teamLabel.Text = "Team :";
        // 
        // idValueLabel
        // 
        idValueLabel.AutoSize = true;
        idValueLabel.Location = new Point(274, 328);
        idValueLabel.Name = "idValueLabel";
        idValueLabel.Size = new Size(124, 45);
        idValueLabel.TabIndex = 18;
        idValueLabel.Text = "idValue";
        // 
        // firstNameValueLabel
        // 
        firstNameValueLabel.AutoSize = true;
        firstNameValueLabel.Location = new Point(727, 328);
        firstNameValueLabel.Name = "firstNameValueLabel";
        firstNameValueLabel.Size = new Size(230, 45);
        firstNameValueLabel.TabIndex = 19;
        firstNameValueLabel.Text = "firstnameValue";
        // 
        // lastNameValueLabel
        // 
        lastNameValueLabel.AutoSize = true;
        lastNameValueLabel.Location = new Point(1323, 328);
        lastNameValueLabel.Name = "lastNameValueLabel";
        lastNameValueLabel.Size = new Size(225, 45);
        lastNameValueLabel.TabIndex = 20;
        lastNameValueLabel.Text = "lastnameValue";
        // 
        // SSNValueLabel
        // 
        SSNValueLabel.AutoSize = true;
        SSNValueLabel.Location = new Point(1749, 328);
        SSNValueLabel.Name = "SSNValueLabel";
        SSNValueLabel.Size = new Size(155, 45);
        SSNValueLabel.TabIndex = 21;
        SSNValueLabel.Text = "SSNValue";
        // 
        // teamValueLabel
        // 
        teamValueLabel.AutoSize = true;
        teamValueLabel.Location = new Point(549, 476);
        teamValueLabel.Name = "teamValueLabel";
        teamValueLabel.Size = new Size(172, 45);
        teamValueLabel.TabIndex = 22;
        teamValueLabel.Text = "TeamValue";
        // 
        // phoneValueLabel
        // 
        phoneValueLabel.AutoSize = true;
        phoneValueLabel.Location = new Point(980, 476);
        phoneValueLabel.Name = "phoneValueLabel";
        phoneValueLabel.Size = new Size(187, 45);
        phoneValueLabel.TabIndex = 23;
        phoneValueLabel.Text = "PhoneValue";
        // 
        // emailValueLabel
        // 
        emailValueLabel.AutoSize = true;
        emailValueLabel.Location = new Point(1469, 476);
        emailValueLabel.Name = "emailValueLabel";
        emailValueLabel.Size = new Size(173, 45);
        emailValueLabel.TabIndex = 24;
        emailValueLabel.Text = "EmailValue";
        // 
        // editPlayerButton
        // 
        editPlayerButton.BackColor = Color.White;
        editPlayerButton.ForeColor = Color.Black;
        editPlayerButton.Location = new Point(889, 729);
        editPlayerButton.Name = "editPlayerButton";
        editPlayerButton.Size = new Size(196, 80);
        editPlayerButton.TabIndex = 25;
        editPlayerButton.Text = "Edit";
        editPlayerButton.UseVisualStyleBackColor = false;
        editPlayerButton.Click += editPlayerButton_Click;
        // 
        // backButton
        // 
        backButton.AutoSize = true;
        backButton.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
        backButton.Location = new Point(38, 39);
        backButton.Name = "backButton";
        backButton.Size = new Size(87, 81);
        backButton.TabIndex = 26;
        backButton.Text = "←";
        backButton.Click += backButton_Click;
        // 
        // PlayerDetailsForm
        // 
        AutoScaleDimensions = new SizeF(18F, 45F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(2012, 1036);
        Controls.Add(backButton);
        Controls.Add(editPlayerButton);
        Controls.Add(emailValueLabel);
        Controls.Add(phoneValueLabel);
        Controls.Add(teamValueLabel);
        Controls.Add(SSNValueLabel);
        Controls.Add(lastNameValueLabel);
        Controls.Add(firstNameValueLabel);
        Controls.Add(idValueLabel);
        Controls.Add(emailLabel);
        Controls.Add(phoneLabel);
        Controls.Add(teamLabel);
        Controls.Add(lastNameLabel);
        Controls.Add(firstNameLabel);
        Controls.Add(SSNLabel);
        Controls.Add(idLabel);
        Controls.Add(titleLabel);
        Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
        ForeColor = Color.White;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(5);
        Name = "PlayerDetailsForm";
        Text = "Login";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label titleLabel;
    private Label idLabel;
    private Label SSNLabel;
    private Label firstNameLabel;
    private Label lastNameLabel;
    private Label emailLabel;
    private Label phoneLabel;
    private Label teamLabel;
    private Label idValueLabel;
    private Label firstNameValueLabel;
    private Label lastNameValueLabel;
    private Label SSNValueLabel;
    private Label teamValueLabel;
    private Label phoneValueLabel;
    private Label emailValueLabel;
    private Button editPlayerButton;
    private Label backButton;
}
