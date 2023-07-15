namespace TournamentTrackerApp.WinformsUI.Forms
{
    partial class TeamPlayers
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
            doneButton = new Button();
            removeSelectedFromListButton = new Button();
            selectedPlayersListBox = new ListBox();
            goToAddPlayerButton = new Label();
            addPlayerButton = new Button();
            playersComboBox = new ComboBox();
            titleLabel = new Label();
            SuspendLayout();
            // 
            // doneButton
            // 
            doneButton.ForeColor = Color.Black;
            doneButton.Location = new Point(724, 867);
            doneButton.Margin = new Padding(5);
            doneButton.Name = "doneButton";
            doneButton.Size = new Size(436, 61);
            doneButton.TabIndex = 28;
            doneButton.Text = "Done";
            doneButton.UseVisualStyleBackColor = true;
            // 
            // removeSelectedFromListButton
            // 
            removeSelectedFromListButton.ForeColor = Color.Black;
            removeSelectedFromListButton.Location = new Point(1251, 747);
            removeSelectedFromListButton.Margin = new Padding(5);
            removeSelectedFromListButton.Name = "removeSelectedFromListButton";
            removeSelectedFromListButton.Size = new Size(202, 61);
            removeSelectedFromListButton.TabIndex = 27;
            removeSelectedFromListButton.Text = "Remove";
            removeSelectedFromListButton.UseVisualStyleBackColor = true;
            // 
            // selectedPlayersListBox
            // 
            selectedPlayersListBox.FormattingEnabled = true;
            selectedPlayersListBox.ItemHeight = 45;
            selectedPlayersListBox.Location = new Point(977, 260);
            selectedPlayersListBox.Name = "selectedPlayersListBox";
            selectedPlayersListBox.Size = new Size(746, 454);
            selectedPlayersListBox.TabIndex = 26;
            // 
            // goToAddPlayerButton
            // 
            goToAddPlayerButton.AutoSize = true;
            goToAddPlayerButton.Location = new Point(360, 535);
            goToAddPlayerButton.Name = "goToAddPlayerButton";
            goToAddPlayerButton.Size = new Size(236, 45);
            goToAddPlayerButton.TabIndex = 25;
            goToAddPlayerButton.Text = "Create A Player";
            // 
            // addPlayerButton
            // 
            addPlayerButton.ForeColor = Color.Black;
            addPlayerButton.Location = new Point(371, 434);
            addPlayerButton.Margin = new Padding(5);
            addPlayerButton.Name = "addPlayerButton";
            addPlayerButton.Size = new Size(202, 61);
            addPlayerButton.TabIndex = 24;
            addPlayerButton.Text = "Add";
            addPlayerButton.UseVisualStyleBackColor = true;
            // 
            // playersComboBox
            // 
            playersComboBox.BackColor = Color.White;
            playersComboBox.FormattingEnabled = true;
            playersComboBox.Location = new Point(175, 330);
            playersComboBox.Name = "playersComboBox";
            playersComboBox.Size = new Size(653, 53);
            playersComboBox.TabIndex = 23;
            playersComboBox.Text = "Choose a Player";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 40F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(532, 91);
            titleLabel.Margin = new Padding(5, 0, 5, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(619, 106);
            titleLabel.TabIndex = 22;
            titleLabel.Text = "@nameOfTeam\r\n";
            // 
            // TeamPlayers
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1899, 1019);
            Controls.Add(doneButton);
            Controls.Add(removeSelectedFromListButton);
            Controls.Add(selectedPlayersListBox);
            Controls.Add(goToAddPlayerButton);
            Controls.Add(addPlayerButton);
            Controls.Add(playersComboBox);
            Controls.Add(titleLabel);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            Margin = new Padding(5, 5, 5, 5);
            Name = "TeamPlayers";
            Text = "TeamPlayers";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button doneButton;
        private Button removeSelectedFromListButton;
        private ListBox selectedPlayersListBox;
        private Label goToAddPlayerButton;
        private Button addPlayerButton;
        private ComboBox playersComboBox;
        private Label titleLabel;
    }
}