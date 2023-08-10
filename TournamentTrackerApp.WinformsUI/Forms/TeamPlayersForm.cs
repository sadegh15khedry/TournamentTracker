using TournamentTrackerApp.WinformsUI.Factory;
using TournamentTrackerLibrary.Models;
using UI.DataAccess.Refit.InterFaces;

namespace TournamentTrackerApp.WinformsUI.Forms;

public partial class TeamPlayersForm : Form
{
    private readonly IPlayerData _playerData;
    private readonly ITeamData _teamData;
    private Team SelectedTeam;
    private List<Player> TeamPlayers;
    private List<Player> FreeAgentPlayers;


    public TeamPlayersForm(IPlayerData playerData, ITeamData teamData, int teamId)
    {
        InitializeComponent();
        _playerData = playerData;
        _teamData = teamData;
        SelectedTeam = _teamData.GetById(teamId).Result;
        titleLabel.Text = SelectedTeam.Name + " Team";

        PageRefresh();
    }

    /*    private void goToAddPlayerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            F.ShowDialog();
        }*/

    private void doneButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        FormFactory.CreateTeamDetailsForm(SelectedTeam.Id).Show();
    }
    public void PageRefresh()
    {
        playersComboBox.Items.Clear();
        selectedPlayersListBox.Items.Clear();

        FreeAgentPlayers = _playerData.GetFreeAgentPlayers().Result;
        TeamPlayers = _playerData.GetTeamPlayers(SelectedTeam.Id).Result;

        foreach (var player in FreeAgentPlayers)
        {
            playersComboBox.Items.Add(player.Id.ToString() + " " + player.FirstName + " " + player.LastName);
        }

        foreach (var player in TeamPlayers)
        {
            selectedPlayersListBox.Items.Add(player.Id.ToString() + " " + player.FirstName + " " + player.LastName);
        }
    }

    private void addPlayerToTeamButton_Click(object sender, EventArgs e)
    {
        var player = FreeAgentPlayers.ElementAtOrDefault(playersComboBox.SelectedIndex);
        _playerData.SignedWithTeam(player.Id, SelectedTeam.Id);
        this.Hide();
        Thread.Sleep(100);
        FormFactory.CreateTeamPlayerForm(SelectedTeam.Id).Show();
        PageRefresh();

    }

    private void removeSelectedFromListButton_Click(object sender, EventArgs e)
    {
        var player = TeamPlayers.ElementAtOrDefault(selectedPlayersListBox.SelectedIndex);
        _playerData.CanceledContract(player.Id);
        this.Hide();
        Thread.Sleep(100);
        FormFactory.CreateTeamPlayerForm(SelectedTeam.Id).Show();
        PageRefresh();
    }

    private void backButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        FormFactory.CreateTeamDetailsForm(SelectedTeam.Id).Show();
    }
}
