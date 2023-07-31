namespace TournamentTrackerApp.WinformsUI.Forms
{
    partial class AddPlayerForm
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
            createPlayerButton = new Button();
            phoneTextBox = new TextBox();
            ssnTextBox = new TextBox();
            firstnameTextBox = new TextBox();
            phoneLabel = new Label();
            ssnLabel = new Label();
            firstnameLabel = new Label();
            titleLabel = new Label();
            lastnameTextBox = new TextBox();
            lastnameLabel = new Label();
            SuspendLayout();
            // 
            // createPlayerButton
            // 
            createPlayerButton.ForeColor = Color.Black;
            createPlayerButton.Location = new Point(912, 807);
            createPlayerButton.Name = "createPlayerButton";
            createPlayerButton.Size = new Size(235, 92);
            createPlayerButton.TabIndex = 36;
            createPlayerButton.Text = "Create";
            createPlayerButton.UseVisualStyleBackColor = true;
            createPlayerButton.Click += createPlayerButton_Click;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(740, 652);
            phoneTextBox.Margin = new Padding(5);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(656, 50);
            phoneTextBox.TabIndex = 35;
            // 
            // ssnTextBox
            // 
            ssnTextBox.Location = new Point(740, 563);
            ssnTextBox.Margin = new Padding(5);
            ssnTextBox.Name = "ssnTextBox";
            ssnTextBox.Size = new Size(656, 50);
            ssnTextBox.TabIndex = 34;
            // 
            // firstnameTextBox
            // 
            firstnameTextBox.Location = new Point(740, 390);
            firstnameTextBox.Margin = new Padding(5);
            firstnameTextBox.Name = "firstnameTextBox";
            firstnameTextBox.Size = new Size(656, 50);
            firstnameTextBox.TabIndex = 33;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(552, 652);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(127, 45);
            phoneLabel.TabIndex = 32;
            phoneLabel.Text = "phone :";
            // 
            // ssnLabel
            // 
            ssnLabel.AutoSize = true;
            ssnLabel.Location = new Point(323, 563);
            ssnLabel.Name = "ssnLabel";
            ssnLabel.Size = new Size(366, 45);
            ssnLabel.TabIndex = 31;
            ssnLabel.Text = "Social Security Number :";
            // 
            // firstnameLabel
            // 
            firstnameLabel.AutoSize = true;
            firstnameLabel.Location = new Point(503, 390);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new Size(190, 45);
            firstnameLabel.TabIndex = 30;
            firstnameLabel.Text = "First Name :";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 40F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(621, 127);
            titleLabel.Margin = new Padding(5, 0, 5, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(619, 106);
            titleLabel.TabIndex = 29;
            titleLabel.Text = "Create A Player";
            // 
            // lastnameTextBox
            // 
            lastnameTextBox.Location = new Point(740, 480);
            lastnameTextBox.Margin = new Padding(5);
            lastnameTextBox.Name = "lastnameTextBox";
            lastnameTextBox.Size = new Size(656, 50);
            lastnameTextBox.TabIndex = 38;
            // 
            // lastnameLabel
            // 
            lastnameLabel.AutoSize = true;
            lastnameLabel.Location = new Point(503, 471);
            lastnameLabel.Name = "lastnameLabel";
            lastnameLabel.Size = new Size(186, 45);
            lastnameLabel.TabIndex = 37;
            lastnameLabel.Text = "Last Name :";
            // 
            // AddPlayer
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1911, 1093);
            Controls.Add(lastnameTextBox);
            Controls.Add(lastnameLabel);
            Controls.Add(createPlayerButton);
            Controls.Add(phoneTextBox);
            Controls.Add(ssnTextBox);
            Controls.Add(firstnameTextBox);
            Controls.Add(phoneLabel);
            Controls.Add(ssnLabel);
            Controls.Add(firstnameLabel);
            Controls.Add(titleLabel);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            Margin = new Padding(5);
            Name = "AddPlayer";
            Text = "AddPlayer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createPlayerButton;
        private TextBox phoneTextBox;
        private TextBox ssnTextBox;
        private TextBox firstnameTextBox;
        private Label phoneLabel;
        private Label ssnLabel;
        private Label firstnameLabel;
        private Label titleLabel;
        private TextBox lastnameTextBox;
        private Label lastnameLabel;
    }
}