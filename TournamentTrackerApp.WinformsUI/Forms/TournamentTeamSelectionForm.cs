using DataModels;
using TournamentTrackerApp.WinformsUI.Factory;
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
        TeamsNotInTournament = _tournamentData
            .GetTeamsNotInTournament(SelectedTournament.Id).Result;
        TournamentTeamsSetup();
    }

    private void titleLabel_Click(object sender, EventArgs e)
    {

    }

    private void addTeamToTournamentButton_Click(object sender, EventArgs e)
    {

        Team team = TeamsNotInTournament.ElementAtOrDefault(teamsComboBox.SelectedIndex);

        MessageBox.Show(team.Id.ToString() + "  " + team.Name
            + "\n" + SelectedTournament.Id.ToString() + SelectedTournament.Name);
        var tournamentTeam = new TournamentTeam()
        {
            TeamId = team.Id,
            TournamentId = SelectedTournament.Id
        };

        MessageBox.Show(_teamData.JoinedTournament(tournamentTeam).Result);



        TournamentTeamsSetup();
        //Thread.Sleep(100);
        //this.Hide();
        //FormFactory.CreateTournamentTeamSelectForm(SelectedTournament.Id).Show();
    }

    private void tournamentsComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void goToAddTeamButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        FormFactory.CreateAddTeamForm().Show();
    }

    private void removeSelectedFromListButton_Click(object sender, EventArgs e)
    {

    }

    private void startTournamentButton_Click(object sender, EventArgs e)
    {
        this.Hide();

    }



    private void TournamentTeamsSetup()
    {
        selectedTeamsListBox.Items.Clear();
        teamsComboBox.Items.Clear();

        foreach (Team team in TeamsInTournament)
        {
            selectedTeamsListBox.Items.Add(team.Name);
        }
        foreach (Team team in TeamsNotInTournament)
        {
            teamsComboBox.Items.Add(team.Name);
        }
    }
}
