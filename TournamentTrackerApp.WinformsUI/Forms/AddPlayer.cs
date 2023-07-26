namespace TournamentTrackerApp.WinformsUI.Forms;

public partial class AddPlayer : Form
{
    public AddPlayer()
    {
        InitializeComponent();
    }

    private void createPlayerButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        new TeamPlayers().ShowDialog();
    }
}
