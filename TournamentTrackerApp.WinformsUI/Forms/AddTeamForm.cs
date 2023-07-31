namespace TournamentTrackerApp.WinformsUI.Forms
{
    public partial class AddTeamForm : Form
    {
        public AddTeamForm()
        {
            InitializeComponent();
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TeamPlayersForm().ShowDialog();
        }
    }
}
