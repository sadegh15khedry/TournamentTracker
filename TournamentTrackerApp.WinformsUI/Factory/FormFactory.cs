using TournamentTrackerApp.WinformsUI.Forms;
using UI.DataAccess.Refit.InterFaces;

namespace TournamentTrackerApp.WinformsUI.Factory;

public static class FormFactory
{
    public static ITeamData? _teamData { set; get; }
    public static ITournamentData? _tournamentData { set; get; }
    public static ISeriesData? _seriesData { get; set; }
    public static IPlayerData? _playerData { get; set; }
    public static IMatchData? _matchData { get; set; }
    public static int SelectedTournamentId { get; set; }
    public static int SelectedTeamId { get; set; }

    public static LoginForm CreateLoginForm()
    {
        return new LoginForm();
    }
    public static TournamentsForm CreateTournamentsForm()
    {
        return new TournamentsForm(_tournamentData);
    }
    public static AddTournamentForm CreateAddTournamentForm()
    {
        return new AddTournamentForm(_tournamentData);
    }
    public static SignupForm CreateSignupForm()
    {
        return new SignupForm();
    }
    public static AddTeamForm CreateAddTeamForm()
    {
        return new AddTeamForm(_teamData);
    }
    public static TournamentTeamSelectionForm CreateTournamentTeamSelectForm(int tournamentId)
    {
        SelectedTournamentId = tournamentId;
        return new TournamentTeamSelectionForm(tournamentId, _tournamentData, _teamData);
    }
    public static TeamPlayersForm CreateTeamPlayerForm(int teamId)
    {
        SelectedTeamId = teamId;
        return new TeamPlayersForm(_playerData, _teamData, teamId);
    }

    public static HomeForm CreateHomeForm()
    {
        return new HomeForm(_tournamentData, _teamData, _playerData);
    }

    public static AddPlayerForm CreateAddPlayerForm()
    {
        return new AddPlayerForm(_playerData);
    }

    public static PlayerDetailsForm CreatePlayerDetailForm(int playerId)
    {
        return new PlayerDetailsForm(_playerData, playerId);


    }
    public static EditPlayerForm CreateEditPlayerForm(int playerId)
    {
        return new EditPlayerForm(_playerData, playerId);
    }

    public static TournamentDetailsForm CreateTournamentDetails(int tournamentId)
    {
        return new TournamentDetailsForm(_tournamentData, tournamentId);

    }

    public static TeamDetailsForm CreateTeamDetailsForm(int teamId)
    {
        return new TeamDetailsForm(_teamData, teamId);
    }

    public static EditTeamForm CreateEditTeamForm(int teamId)
    {
        return new EditTeamForm(_teamData, teamId);
    }

    public static EditTournamentForm CreateEditTournamentForm(int tournamentId)
    {
        return new EditTournamentForm(_tournamentData, tournamentId);
    }

    public static TournamentChartForm CreateTournamentChart(int tournamentId)
    {
        return new TournamentChartForm(_tournamentData, tournamentId);
    }

    public static SeriesDetailsForm CreateSeriesDetailsForm(int seriesId)
    {
        return new SeriesDetailsForm(_matchData, _seriesData, seriesId);
    }
}
