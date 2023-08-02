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
}
