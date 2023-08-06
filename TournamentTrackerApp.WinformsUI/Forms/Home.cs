using TournamentTrackerApp.WinformsUI.Factory;
using TrackerLibrary;
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
        playersListView.Items.Clear();
        teamsListView.Items.Clear();
        tournamentsListView.Items.Clear();

        Players = _playerData.GetAll().Result;
        Teams = _teamData.GetAll().Result;
        Tournaments = _tournamentData.GetAll().Result;

        foreach (var player in Players)
        {
            playersListView.Items.Add(player.FirstName + " " + player.LastName + "\n");
        }
        foreach (var team in Teams)
        {
            teamsListView.Items.Add(team.Name);
        }
        foreach (var tournament in Tournaments)
        {
            tournamentsListView.Items.Add(tournament.Name);
        }
    }

    private void addPlayerButton_Click(object sender, EventArgs e)
    {
        FormFactory.CreateAddPlayerForm().Show();
    }
}
