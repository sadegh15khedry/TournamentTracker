namespace TournamentTrackerApp.WinformsUI
{
    public partial class Tournaments : Form
    {
        public Tournaments()
        {
            InitializeComponent();
        }

        private void goToAddTournamentButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddTournament().ShowDialog();
        }

        private void goToTournamentButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TournamentTeamSelection().ShowDialog();
        }
    }
}
