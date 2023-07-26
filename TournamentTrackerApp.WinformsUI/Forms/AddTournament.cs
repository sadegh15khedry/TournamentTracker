namespace TournamentTrackerApp.WinformsUI
{
    public partial class AddTournament : Form
    {
        public AddTournament()
        {
            InitializeComponent();
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TournamentTeamSelection().ShowDialog();
        }
    }
}
