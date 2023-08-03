using TournamentTrackerApp.WinformsUI.Factory;

namespace TournamentTrackerApp.WinformsUI.Forms;

public partial class AddPlayerForm : Form
{
    public AddPlayerForm()
    {
        InitializeComponent();
    }

    private void createPlayerButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        FormFactory.CreateTeamPlayerForm(FormFactory.SelectedTeamId).Show();
    }
}
