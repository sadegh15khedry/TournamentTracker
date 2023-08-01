using TournamentTrackerApp.WinformsUI.Forms;
using TrackerLibrary;
using UI.DataAccess.Refit.InterFaces;

namespace TournamentTrackerApp.WinformsUI;

public partial class TournamentTeamSelectionForm : Form
{
    private readonly ITournamentData _tournamentData;
    private readonly ITeamData _teamData;
    public Tournament SelectedTournament { get; set; }
    public List<Team> TeamsInTournament { get; set; } = new();
    public List<Team> TeamsNotInTournament { get; set; } = new();

    public TournamentTeamSelectionForm(int tournamentId, ITournamentData tournamentData
        , ITeamData teamData)
    {
        InitializeComponent();
        _teamData = teamData;
        _tournamentData = tournamentData;
        SelectedTournament = _tournamentData.GetById(tournamentId).Result;
        titleLabel.Text = SelectedTournament.Name + " Tournament";
        TeamsInTournament = _tournamentData.GetTournamentTeams(SelectedTournament.Id).Result;
        //MessageBox.Show(TeamsInTournament.Count.ToString());
        List<Team> allTeams = _teamData.GetAll().Result;
        foreach (var team in allTeams)
        {
            if (TeamsInTournament))
            {
                TeamsNotInTournament.Add(team);
            }
        }

        MessageBox.Show(TeamsInTournament.Count.ToString() + "  "
            + TeamsNotInTournament.Count.ToString());
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
        new AddTeamForm().ShowDialog();
    }

    private void removeSelectedFromListButton_Click(object sender, EventArgs e)
    {

    }

    private void startTournamentButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        new TournamentChartForm().ShowDialog();
    }
}
