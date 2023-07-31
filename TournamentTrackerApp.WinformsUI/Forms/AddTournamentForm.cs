namespace TournamentTrackerApp.WinformsUI
{
    public partial class AddTournamentForm : Form
    {
        public AddTournamentForm()
        {
            InitializeComponent();
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TournamentTeamSelectionForm().ShowDialog();
        }
    }
}
