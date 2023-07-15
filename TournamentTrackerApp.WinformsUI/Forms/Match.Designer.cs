namespace TournamentTrackerApp.WinformsUI.Forms
{
    partial class Match
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
            lastnameTextBox = new TextBox();
            lastnameLabel = new Label();
            createPlayerButton = new Button();
            firstnameTextBox = new TextBox();
            firstnameLabel = new Label();
            titleLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // lastnameTextBox
            // 
            lastnameTextBox.Location = new Point(1143, 441);
            lastnameTextBox.Margin = new Padding(5);
            lastnameTextBox.Name = "lastnameTextBox";
            lastnameTextBox.Size = new Size(172, 50);
            lastnameTextBox.TabIndex = 48;
            // 
            // lastnameLabel
            // 
            lastnameLabel.AutoSize = true;
            lastnameLabel.Location = new Point(1143, 347);
            lastnameLabel.Name = "lastnameLabel";
            lastnameLabel.Size = new Size(125, 45);
            lastnameLabel.TabIndex = 47;
            lastnameLabel.Text = "Team A";
            // 
            // createPlayerButton
            // 
            createPlayerButton.ForeColor = Color.Black;
            createPlayerButton.Location = new Point(1279, 589);
            createPlayerButton.Name = "createPlayerButton";
            createPlayerButton.Size = new Size(235, 92);
            createPlayerButton.TabIndex = 46;
            createPlayerButton.Text = "Submit";
            createPlayerButton.UseVisualStyleBackColor = true;
            // 
            // firstnameTextBox
            // 
            firstnameTextBox.Location = new Point(1435, 441);
            firstnameTextBox.Margin = new Padding(5);
            firstnameTextBox.Name = "firstnameTextBox";
            firstnameTextBox.Size = new Size(172, 50);
            firstnameTextBox.TabIndex = 43;
            // 
            // firstnameLabel
            // 
            firstnameLabel.AutoSize = true;
            firstnameLabel.Location = new Point(1435, 347);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new Size(122, 45);
            firstnameLabel.TabIndex = 40;
            firstnameLabel.Text = "Team B";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 40F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(810, 69);
            titleLabel.Margin = new Padding(5, 0, 5, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(282, 106);
            titleLabel.TabIndex = 39;
            titleLabel.Text = "Match";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(200, 293);
            label1.Name = "label1";
            label1.Size = new Size(206, 45);
            label1.TabIndex = 49;
            label1.Text = "Tournament :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(202, 441);
            label2.Name = "label2";
            label2.Size = new Size(128, 45);
            label2.TabIndex = 50;
            label2.Text = "Round :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(208, 666);
            label3.Name = "label3";
            label3.Size = new Size(418, 45);
            label3.TabIndex = 51;
            label3.Text = "Number OF Mach In Series :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(437, 293);
            label4.Name = "label4";
            label4.Size = new Size(323, 45);
            label4.TabIndex = 52;
            label4.Text = "@nameOfTounament";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(365, 444);
            label5.Name = "label5";
            label5.Size = new Size(253, 45);
            label5.TabIndex = 53;
            label5.Text = "@roundNumber";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(648, 666);
            label6.Name = "label6";
            label6.Size = new Size(285, 45);
            label6.TabIndex = 54;
            label6.Text = "@numberOfMatch";
            // 
            // Match
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1859, 1211);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lastnameTextBox);
            Controls.Add(lastnameLabel);
            Controls.Add(createPlayerButton);
            Controls.Add(firstnameTextBox);
            Controls.Add(firstnameLabel);
            Controls.Add(titleLabel);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            Margin = new Padding(5, 5, 5, 5);
            Name = "Match";
            Text = "Match";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox lastnameTextBox;
        private Label lastnameLabel;
        private Button createPlayerButton;
        private TextBox firstnameTextBox;
        private Label firstnameLabel;
        private Label titleLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}