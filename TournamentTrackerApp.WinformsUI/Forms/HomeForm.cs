using TournamentTrackerApp.WinformsUI.Factory;
using TournamentTrackerLibrary.Models;
using UI.DataAccess.Refit.InterFaces;

namespace TournamentTrackerApp.WinformsUI;

public partial class HomeForm : Form
{
    private readonly ITournamentData _tournamentData;
    private readonly ITeamData _teamData;
    private readonly IPlayerData _playerData;
    public List<Tournament> Tournaments { get; set; }
    public List<Team> Teams { get; set; }
    public List<Player> Players { get; set; }

    public HomeForm(ITournamentData tournamentData, ITeamData teamData, IPlayerData playerData)
    {
        InitializeComponent();
        _tournamentData = tournamentData;
        _teamData = teamData;
        _playerData = playerData;

        PageListsSetup();
    }

    private void PageListsSetup()
    {
        playersListBox.Items.Clear();
        teamsListBox.Items.Clear();
        tournamentsListBox.Items.Clear();

        Players = _playerData.GetAll().Result;
        Teams = _teamData.GetAll().Result;
        Tournaments = _tournamentData.GetAll().Result;

        foreach (var player in Players)
        {
            playersListBox.Items.Add(player.FirstName + " " + player.LastName + "\n");
        }
        foreach (var team in Teams)
        {
            teamsListBox.Items.Add(team.Name);
        }
        foreach (var tournament in Tournaments)
        {
            tournamentsListBox.Items.Add(tournament.Name);
        }
    }

    private void addPlayerButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        FormFactory.CreateAddPlayerForm().Show();
    }

    private void addTeamButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        FormFactory.CreateAddTeamForm().Show();
    }

    private void addTournamentButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        FormFactory.CreateAddTournamentForm().Show();
    }

    private void goToPlayerButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        int selectedPlayerIndex = playersListBox.SelectedIndex;
        var player = Players.ElementAtOrDefault(selectedPlayerIndex);
        FormFactory.CreatePlayerDetailForm(player.Id).Show();

    }

    private void goToTeamButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        int selectedTeamIndex = teamsListBox.SelectedIndex;
        var team = Teams.ElementAtOrDefault(selectedTeamIndex);
        FormFactory.CreateTeamDetailsForm(team.Id).Show();
    }

    private void goToTournamentButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        int selectedTournamentIndex = tournamentsListBox.SelectedIndex;
        var tournament = Tournaments.ElementAtOrDefault(selectedTournamentIndex);
        FormFactory.CreateTournamentDetails(tournament.Id).Show();
    }


}
