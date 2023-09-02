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

    public static void SetSeriesWinInfo(Series series)
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
        if (firstTeamWins > secondTeamWins)
        {
            series.WinnerTeam = series.FirstTeam;
        }
        else if (firstTeamWins < secondTeamWins)
        {
            series.WinnerTeam = series.SecondTeam;
        }
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

    public static bool IsNextRoundSeriesGenerationsNeeded(Tournament tournament)
    {
        if (tournament.IsFinished == true)
        {
            return false;
        }
        else if (TournamentLogic.IsAllAvailableSeriesEnded(tournament) == false
            || tournament.IsStarted == false)
        {
            return false;
        }
        return true;

    }

    public static List<Series> GenerateNextRoundSeries(Tournament tournament)
    {
        int latestRoundNumber = GetLatestRoundNumber(tournament);
        int nextRoundNumber = latestRoundNumber - 1;
        int nextRoundPlaceInRound = 1;
        List<Series> latestRoundSeries = tournament.Series
            .Where(s => s.Round == latestRoundNumber).OrderBy(d => d.PlaceInRound).ToList();
        List<Series> nextRoundSeries = new List<Series>();

        for (int i = 0; i < latestRoundNumber; i += 2)
        {
            nextRoundSeries.Add(new Series()
            {
                TournamentId = tournament.Id,
                Round = nextRoundNumber,
                PlaceInRound = nextRoundPlaceInRound,

                FirstTeamId = latestRoundSeries.ElementAt(i).WinnerTeam.Id,
                SecondTeamId = latestRoundSeries.ElementAt(i + 1).WinnerTeam.Id,

                FirstTeam = latestRoundSeries.ElementAt(i).WinnerTeam,
                SecondTeam = latestRoundSeries.ElementAt(i + 1).WinnerTeam


            }); ;
        }
        return nextRoundSeries;
    }

    private static int GetLatestRoundNumber(Tournament tournament)
    {
        int latestRoundNumber = int.MaxValue;
        foreach (var series in tournament.Series)
        {
            if (series.Round < latestRoundNumber)
            {
                latestRoundNumber = series.Round;
            }
        }
        return latestRoundNumber;
    }

    public static bool IsTournamentEnded(Tournament tournament)
    {
        int latestRoundNumber = GetLatestRoundNumber(tournament);
        if (latestRoundNumber == 0)
        {
            return true;
        }
        return false;
    }

    /*    public static int GetUserIdByRequest(string refreshToken)
        {
            //var refreshToken = Request.Cookies["refreshToken"];
            int id = 0;
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            if (identity == null)
            {
                return 0;
            }
            IEnumerable<Claim> claims = identity.Claims;
            id = Int32.Parse(claims.ElementAtOrDefault(2).Value);
            return id;
        }*/
}
