using TournamentTrackerApp.WinformsUI.Factory;
using TrackerLibrary;
using UI.DataAccess.Refit.InterFaces;

namespace TournamentTrackerApp.WinformsUI.Forms;

public partial class AddTeamForm : Form
{
    private readonly ITeamData _teamData;

    public AddTeamForm(ITeamData teamData)
    {
        InitializeComponent();
        _teamData = teamData;
    }

    private void createTeamButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        Team team = new Team()
        {
            Name = nameTextBox.Text,
            City = cityTextBox.Text,
            Owner = ownerTextBox.Text
        };
        _teamData.Insert(team);
        Thread.Sleep(100);
        FormFactory.CreateTournamentTeamSelectForm(FormFactory.SelectedTournamentId).Show();
    }
}
