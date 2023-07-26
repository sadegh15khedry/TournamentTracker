using TournamentTrackerApp.WinformsUI.Forms;

namespace TournamentTrackerApp.WinformsUI
{
    public partial class TournamentTeamSelection : Form
    {
        public TournamentTeamSelection()
        {
            InitializeComponent();
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void goToTournamentButton_Click(object sender, EventArgs e)
        {
        }

        private void tournamentsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void goToAddTeamButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddTeam().ShowDialog();
        }

        private void removeSelectedFromListButton_Click(object sender, EventArgs e)
        {

        }

        private void startTournamentButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TournamentChart().ShowDialog();
        }
    }
}
