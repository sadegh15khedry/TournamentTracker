using UI.DataAccess.Refit.InterFaces;

namespace TournamentTrackerApp.WinformsUI;

public partial class Tournaments
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
        tournamentsComboBox = new ComboBox();
        goToTournamentButton = new Button();
        goToAddTournamentButton = new Label();
        SuspendLayout();
        // 
        // titleLabel
        // 
        titleLabel.AutoSize = true;
        titleLabel.Font = new Font("Segoe UI", 40F, FontStyle.Bold, GraphicsUnit.Point);
        titleLabel.ForeColor = Color.White;
        titleLabel.Location = new Point(393, 73);
        titleLabel.Margin = new Padding(5, 0, 5, 0);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(823, 106);
        titleLabel.TabIndex = 11;
        titleLabel.Text = "Select A Tournament";
        // 
        // tournamentsComboBox
        // 
        tournamentsComboBox.BackColor = Color.White;
        tournamentsComboBox.FormattingEnabled = true;
        tournamentsComboBox.Location = new Point(487, 303);
        tournamentsComboBox.Name = "tournamentsComboBox";
        tournamentsComboBox.Size = new Size(653, 53);
        tournamentsComboBox.TabIndex = 12;
        tournamentsComboBox.Text = "Choose a Tournament";
        // 
        // goToTournamentButton
        // 
        goToTournamentButton.ForeColor = Color.Black;
        goToTournamentButton.Location = new Point(711, 408);
        goToTournamentButton.Margin = new Padding(5);
        goToTournamentButton.Name = "goToTournamentButton";
        goToTournamentButton.Size = new Size(202, 61);
        goToTournamentButton.TabIndex = 13;
        goToTournamentButton.Text = "Go";
        goToTournamentButton.UseVisualStyleBackColor = true;
        goToTournamentButton.Click += goToTournamentButton_Click;
        // 
        // goToAddTournamentButton
        // 
        goToAddTournamentButton.AutoSize = true;
        goToAddTournamentButton.Location = new Point(668, 506);
        goToAddTournamentButton.Name = "goToAddTournamentButton";
        goToAddTournamentButton.Size = new Size(288, 45);
        goToAddTournamentButton.TabIndex = 14;
        goToAddTournamentButton.Text = "Add A Tournament";
        goToAddTournamentButton.Click += goToAddTournamentButton_Click;
        // 
        // Tournaments
        // 
        AutoScaleDimensions = new SizeF(18F, 45F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(1653, 885);
        Controls.Add(goToAddTournamentButton);
        Controls.Add(goToTournamentButton);
        Controls.Add(tournamentsComboBox);
        Controls.Add(titleLabel);
        Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
        ForeColor = Color.White;
        Margin = new Padding(5);
        Name = "Tournaments";
        Text = "Tournaments";
        Load += Tournaments_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion




    private Label titleLabel;
    private ComboBox tournamentsComboBox;
    private Button goToTournamentButton;
    private Label goToAddTournamentButton;

    /*    private void ReconcilerConsoleWindow_Load(object sender, EventArgs e)
        {
            MessageBox mb = new MessageBox(_tournamentData.GetAll().Result.ToString());

        }*/
}