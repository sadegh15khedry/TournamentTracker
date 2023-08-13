using TournamentTrackerLibrary.Models;

namespace TournamentTrackerLibrary.Logic;

public static class TournamentLogic
{
    public static List<Series> GenerateInitialTournamentSeries(List<Team> teams, int tournamentId)
    {
        teams = teams.OrderBy(s => Guid.NewGuid()).ToList();
        int round = GetTournamentSeriesRound(teams.Count() / 2);
        int placeInRound = 1;
        List<Series> result = new List<Series>();


        for (int i = 0; i < teams.Count(); i += 2)
        {
            Series series = new Series()
            {
                TournamentId = tournamentId,
                FirstTeamId = teams.ElementAt(i).Id,
                SecondTeamId = teams.ElementAt(i + 1).Id,
                IsSeriesEnded = false,
                Round = round,
                PlaceInRound = placeInRound
            };
            result.Add(series);

            placeInRound++;
        }
        return result;
    }
    private static int GetTournamentSeriesRound(int seriesCount)
    {
        if (seriesCount == 1)
        {
            return 0;
        }
        else if (seriesCount == 2)
        {
            return 1;
        }
        else if (seriesCount == 8)
        {
            return 3;
        }
        else
        {
            return -1;
        }
    }

    public static int GetMatchOutcome(Match match)
    {
        if (match.FirstTeamScore > match.SecondTeamScore)
            return 1;
        else if (match.FirstTeamScore < match.SecondTeamScore)
            return 2;
        else
            return 0;
    }

    public static bool IsSeriesEnded(Series series)
    {
        if (series.Matches.Count > 2)
        {
            return true;
        }
        return false;
    }
}
