namespace TournamentTrackerApp.WinformsUI;

partial class LoginForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
        loginButton = new Button();
        emailTextBox = new TextBox();
        emailLabel = new Label();
        passwordLabel = new Label();
        passwordTextBox = new TextBox();
        forgotPasswordLabel = new Label();
        forgotPasswordButton = new Label();
        toSignupButton = new Label();
        titleLabel = new Label();
        SuspendLayout();
        // 
        // loginButton
        // 
        loginButton.ForeColor = Color.Black;
        loginButton.Location = new Point(813, 440);
        loginButton.Margin = new Padding(5);
        loginButton.Name = "loginButton";
        loginButton.Size = new Size(202, 61);
        loginButton.TabIndex = 1;
        loginButton.Text = "Login";
        loginButton.UseVisualStyleBackColor = true;
        loginButton.Click += loginButton_Click;
        // 
        // emailTextBox
        // 
        emailTextBox.Location = new Point(648, 232);
        emailTextBox.Margin = new Padding(5);
        emailTextBox.Name = "emailTextBox";
        emailTextBox.Size = new Size(656, 50);
        emailTextBox.TabIndex = 2;
        // 
        // emailLabel
        // 
        emailLabel.AutoSize = true;
        emailLabel.Location = new Point(353, 232);
        emailLabel.Margin = new Padding(5, 0, 5, 0);
        emailLabel.Name = "emailLabel";
        emailLabel.Size = new Size(112, 45);
        emailLabel.TabIndex = 4;
        emailLabel.Text = "Email :";
        // 
        // passwordLabel
        // 
        passwordLabel.AutoSize = true;
        passwordLabel.Location = new Point(353, 321);
        passwordLabel.Margin = new Padding(5, 0, 5, 0);
        passwordLabel.Name = "passwordLabel";
        passwordLabel.Size = new Size(169, 45);
        passwordLabel.TabIndex = 5;
        passwordLabel.Text = "Password :";
        // 
        // passwordTextBox
        // 
        passwordTextBox.Location = new Point(648, 321);
        passwordTextBox.Margin = new Padding(5);
        passwordTextBox.Name = "passwordTextBox";
        passwordTextBox.PasswordChar = '*';
        passwordTextBox.Size = new Size(656, 50);
        passwordTextBox.TabIndex = 3;
        // 
        // forgotPasswordLabel
        // 
        forgotPasswordLabel.AutoSize = true;
        forgotPasswordLabel.Location = new Point(648, 559);
        forgotPasswordLabel.Margin = new Padding(5, 0, 5, 0);
        forgotPasswordLabel.Name = "forgotPasswordLabel";
        forgotPasswordLabel.Size = new Size(425, 45);
        forgotPasswordLabel.TabIndex = 6;
        forgotPasswordLabel.Text = "Forgot your password ? click";
        // 
        // forgotPasswordButton
        // 
        forgotPasswordButton.AutoSize = true;
        forgotPasswordButton.Location = new Point(1070, 559);
        forgotPasswordButton.Margin = new Padding(5, 0, 5, 0);
        forgotPasswordButton.Name = "forgotPasswordButton";
        forgotPasswordButton.Size = new Size(88, 45);
        forgotPasswordButton.TabIndex = 7;
        forgotPasswordButton.Text = "Here";
        // 
        // toSignupButton
        // 
        toSignupButton.AutoSize = true;
        toSignupButton.Location = new Point(843, 656);
        toSignupButton.Margin = new Padding(5, 0, 5, 0);
        toSignupButton.Name = "toSignupButton";
        toSignupButton.Size = new Size(119, 45);
        toSignupButton.TabIndex = 8;
        toSignupButton.Text = "Signup";
        toSignupButton.Click += toSignupButton_Click;
        // 
        // titleLabel
        // 
        titleLabel.AutoSize = true;
        titleLabel.Font = new Font("Segoe UI", 40F, FontStyle.Bold, GraphicsUnit.Point);
        titleLabel.ForeColor = Color.White;
        titleLabel.Location = new Point(798, 53);
        titleLabel.Margin = new Padding(5, 0, 5, 0);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(256, 106);
        titleLabel.TabIndex = 9;
        titleLabel.Text = "Login";
        // 
        // Login
        // 
        AutoScaleDimensions = new SizeF(18F, 45F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(2012, 963);
        Controls.Add(titleLabel);
        Controls.Add(toSignupButton);
        Controls.Add(forgotPasswordButton);
        Controls.Add(forgotPasswordLabel);
        Controls.Add(passwordLabel);
        Controls.Add(emailLabel);
        Controls.Add(passwordTextBox);
        Controls.Add(emailTextBox);
        Controls.Add(loginButton);
        Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
        ForeColor = Color.White;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(5);
        Name = "Login";
        Text = "Login";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Button loginButton;
    private TextBox emailTextBox;
    private Label emailLabel;
    private Label passwordLabel;
    private TextBox passwordTextBox;
    private Label forgotPasswordLabel;
    private Label forgotPasswordButton;
    private Label toSignupButton;
    private Label titleLabel;
}
