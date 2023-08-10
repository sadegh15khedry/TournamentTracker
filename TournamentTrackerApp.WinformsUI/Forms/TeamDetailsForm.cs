using TournamentTrackerApp.WinformsUI.Factory;
using TournamentTrackerLibrary.Models;
using UI.DataAccess.Refit.InterFaces;

namespace TournamentTrackerApp.WinformsUI;

public partial class TeamDetailsForm : Form
{

    private readonly ITeamData _teamData;
    public Team SelectedTeam { get; set; }

    public TeamDetailsForm(ITeamData teamData, int teamId)
    {
        InitializeComponent();
        _teamData = teamData;
        SelectedTeam = _teamData.GetById(teamId).Result;
        PageSetup();
    }

    public void PageSetup()
    {
        nameValueLabel.Text = SelectedTeam.Name;
        cityValueLabel.Text = SelectedTeam.City;
        ownerValueLabel.Text = SelectedTeam.Owner;
    }

    private void editPlayerButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        FormFactory.CreateEditTeamForm(SelectedTeam.Id).Show();
    }

    private void teamsPlayersButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        FormFactory.CreateTeamPlayerForm(SelectedTeam.Id).Show();
    }

    private void backButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        FormFactory.CreateHomeForm().Show();
    }


}
