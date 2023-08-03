using TrackerLibrary;
using UI.DataAccess.Refit.InterFaces;

namespace TournamentTrackerApp.WinformsUI.Forms;

public partial class TeamPlayersForm : Form
{
    private readonly IPlayerData _playerData;
    private readonly ITeamData _teamData;
    private readonly Team _selectedTeam;

    public TeamPlayersForm(IPlayerData playerData, ITeamData teamData, int teamId)
    {
        InitializeComponent();
        _playerData = playerData;
        _teamData = teamData;
        _selectedTeam = _teamData.GetById(teamId).Result;
        titleLabel.Text = _selectedTeam.Name + " Team";
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
