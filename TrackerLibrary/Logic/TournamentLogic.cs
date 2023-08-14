using TournamentTrackerLibrary.Models;
using Match = TournamentTrackerLibrary.Models.Match;

namespace TournamentTrackerLibrary.Logic;

public static class TournamentLogic
{
    public static List<Series> GetInitialTournamentSeries(Tournament tournament)
    {
        tournament.Teams = tournament.Teams.OrderBy(s => Guid.NewGuid()).ToList();

        int round = GetTournamentSeriesRound(tournament.Teams.Count() / 2);
        int placeInRound = 1;
        List<Series> result = new List<Series>();


        for (int i = 0; i < tournament.Teams.Count(); i += 2)
        {
            Series series = new Series()
            {
                TournamentId = tournament.Id,
                FirstTeamId = tournament.Teams.ElementAt(i).Id,
                SecondTeamId = tournament.Teams.ElementAt(i + 1).Id,
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

    public static bool IsAllAvailableSeriesEnded(Tournament tournament)
    {
        bool output = true;
        foreach (var series in tournament.Series)
        {
            if (series.IsSeriesEnded == false)
            {
                output = false;
                break;
            }
        }
        return output;
    }

    public static void SetSeriesWins(Series series)
    {
        int firstTeamWins = 0;
        int secondTeamWins = 0;
        foreach (var match in series.Matches)
        {
            if (match.Outcome == 1)
            {
                firstTeamWins++;
            }
            else if (match.Outcome == 2)
            {
                secondTeamWins++;
            }
        }
        series.FirstTeamWins = firstTeamWins;
        series.SecondTeamWins = secondTeamWins;
    }


    public static List<Series> GetNextRoundSeries(Tournament tournament)
    {
        if (tournament.Series.Count == 0)
        {
            return GetInitialTournamentSeries(tournament);
        }
        return new List<Series>();

    }

    public static bool IsTournamentNumberOfTeamsValid(Tournament tournament)
    {
        int tournamentNumberOfTeams = tournament.Teams.Count();
        if (tournamentNumberOfTeams == 4 || tournamentNumberOfTeams == 6 ||
            tournamentNumberOfTeams == 8 || tournamentNumberOfTeams == 16)
        {
            return true;
        }
        return false;
    }
}
