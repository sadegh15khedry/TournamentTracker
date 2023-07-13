namespace TournamentTrackerApp.WinformsUI
{
    partial class Signup
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
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            emailLabel = new Label();
            ssnLabel = new Label();
            phoneLabel = new Label();
            passwordLabel = new Label();
            tologinButton = new Label();
            forgotPasswordLabel = new Label();
            firstnameTextBox = new TextBox();
            lastnameTextBox = new TextBox();
            emailTextBox = new TextBox();
            ssnTextBox = new TextBox();
            phoneTextBox = new TextBox();
            passwordTextBox = new TextBox();
            signupButton = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 40F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(781, 66);
            titleLabel.Margin = new Padding(5, 0, 5, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(743, 106);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Create An Account";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(609, 257);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(190, 45);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "First Name :";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(609, 340);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(186, 45);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "Last Name :";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(687, 423);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(112, 45);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "Email :";
            // 
            // ssnLabel
            // 
            ssnLabel.AutoSize = true;
            ssnLabel.Location = new Point(443, 504);
            ssnLabel.Name = "ssnLabel";
            ssnLabel.Size = new Size(356, 45);
            ssnLabel.TabIndex = 4;
            ssnLabel.Text = "Social Security Nunber :";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(538, 588);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(261, 45);
            phoneLabel.TabIndex = 5;
            phoneLabel.Text = "Phone Number : ";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(617, 670);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(178, 45);
            passwordLabel.TabIndex = 6;
            passwordLabel.Text = "Password : ";
            // 
            // tologinButton
            // 
            tologinButton.AutoSize = true;
            tologinButton.Location = new Point(1291, 888);
            tologinButton.Margin = new Padding(5, 0, 5, 0);
            tologinButton.Name = "tologinButton";
            tologinButton.Size = new Size(88, 45);
            tologinButton.TabIndex = 9;
            tologinButton.Text = "Here";
            // 
            // forgotPasswordLabel
            // 
            forgotPasswordLabel.AutoSize = true;
            forgotPasswordLabel.Location = new Point(833, 888);
            forgotPasswordLabel.Margin = new Padding(5, 0, 5, 0);
            forgotPasswordLabel.Name = "forgotPasswordLabel";
            forgotPasswordLabel.Size = new Size(461, 45);
            forgotPasswordLabel.TabIndex = 8;
            forgotPasswordLabel.Text = "Already Have an Account? click";
            // 
            // firstnameTextBox
            // 
            firstnameTextBox.Location = new Point(821, 257);
            firstnameTextBox.Margin = new Padding(5);
            firstnameTextBox.Name = "firstnameTextBox";
            firstnameTextBox.Size = new Size(656, 50);
            firstnameTextBox.TabIndex = 11;
            // 
            // lastnameTextBox
            // 
            lastnameTextBox.Location = new Point(819, 335);
            lastnameTextBox.Margin = new Padding(5);
            lastnameTextBox.Name = "lastnameTextBox";
            lastnameTextBox.Size = new Size(656, 50);
            lastnameTextBox.TabIndex = 12;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(821, 418);
            emailTextBox.Margin = new Padding(5);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(656, 50);
            emailTextBox.TabIndex = 13;
            // 
            // ssnTextBox
            // 
            ssnTextBox.Location = new Point(819, 504);
            ssnTextBox.Margin = new Padding(5);
            ssnTextBox.Name = "ssnTextBox";
            ssnTextBox.Size = new Size(656, 50);
            ssnTextBox.TabIndex = 14;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(819, 588);
            phoneTextBox.Margin = new Padding(5);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(656, 50);
            phoneTextBox.TabIndex = 15;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(819, 670);
            passwordTextBox.Margin = new Padding(5);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(656, 50);
            passwordTextBox.TabIndex = 16;
            // 
            // signupButton
            // 
            signupButton.ForeColor = Color.Black;
            signupButton.Location = new Point(1023, 778);
            signupButton.Margin = new Padding(5);
            signupButton.Name = "signupButton";
            signupButton.Size = new Size(202, 61);
            signupButton.TabIndex = 10;
            signupButton.Text = "Signup";
            signupButton.UseVisualStyleBackColor = true;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(2294, 1059);
            Controls.Add(passwordTextBox);
            Controls.Add(phoneTextBox);
            Controls.Add(ssnTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(lastnameTextBox);
            Controls.Add(firstnameTextBox);
            Controls.Add(signupButton);
            Controls.Add(tologinButton);
            Controls.Add(forgotPasswordLabel);
            Controls.Add(passwordLabel);
            Controls.Add(phoneLabel);
            Controls.Add(ssnLabel);
            Controls.Add(emailLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Controls.Add(titleLabel);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            Margin = new Padding(5);
            Name = "Signup";
            Text = "Signup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label emailLabel;
        private Label ssnLabel;
        private Label phoneLabel;
        private Label passwordLabel;
        private Label tologinButton;
        private Label forgotPasswordLabel;
        private TextBox firstnameTextBox;
        private TextBox lastnameTextBox;
        private TextBox emailTextBox;
        private TextBox ssnTextBox;
        private TextBox phoneTextBox;
        private TextBox passwordTextBox;
        private Button signupButton;
    }
}