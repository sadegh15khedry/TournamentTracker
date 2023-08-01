namespace TournamentTrackerApp.WinformsUI.Forms;

public partial class TeamPlayersForm : Form
{
    public TeamPlayersForm()
    {
        InitializeComponent();
    }

    private void goToAddPlayerButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        new AddPlayerForm().ShowDialog();
    }

    private void doneButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        //new TournamentTeamSelectionForm().ShowDialog();
    }
}
