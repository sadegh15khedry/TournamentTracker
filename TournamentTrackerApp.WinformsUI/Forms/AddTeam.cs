namespace TournamentTrackerApp.WinformsUI.Forms
{
    public partial class AddTeam : Form
    {
        public AddTeam()
        {
            InitializeComponent();
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TeamPlayers().ShowDialog();
        }
    }
}
