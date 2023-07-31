using UI.DataAccess.Refit.InterFaces;

namespace TournamentTrackerApp.WinformsUI.Factory;

public static class FormFactory
{
    public static ITeamData _teamData { set; get; }
    public static ITournamentData _tournamentData { set; get; }


    public static LoginForm CreateLogin()
    {
        return new LoginForm();
    }

    public static TournamentsForm CreateTournaments()
    {
        return new TournamentsForm(_tournamentData);
    }

}
