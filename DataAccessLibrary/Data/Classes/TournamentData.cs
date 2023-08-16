using DataAccessLibrary.Data.Interfaces;
using TournamentTrackerLibrary.Logic;
using TournamentTrackerLibrary.Models;

namespace DataAccessLibrary.Data.Classes;

public class TournamentData : ITournamentData
{
    public ISqlDataAccess _db { get; }

    public TournamentData(ISqlDataAccess db)
    {
        _db = db;
    }

    public async Task<IEnumerable<Team>> GetTeamsNotInTournament(int tournamentId)
    {
        return await _db.LoadData<Team, dynamic>("spTournament_GetTeamsNotInTournament",
            new { TournamentId = tournamentId });
    }

    public async Task<IEnumerable<Team>> GetTournamentTeams(int tournamentId)
    {
        var result = await _db.LoadData<Team, dynamic>("dbo.spTournament_GetTeams",
            new { TournamentId = tournamentId });
        return result;
    }

    public async Task<IEnumerable<Tournament>> GetAll()
    {
        var result = await _db.LoadData<Tournament, dynamic>("dbo.spTournament_GetAll", new { });
        var tournaments = result.ToList();

        foreach (var tournament in tournaments)
        {
            await SetTournamentAdditionalInfoAsync(tournament);
        }

        return tournaments;
    }

    public async Task<Tournament> GetById(int id)
    {
        var results = await _db.LoadData<Tournament, dynamic>
            ("dbo.spTournament_GetByID", new { Id = id });

        Tournament tournament = results.FirstOrDefault();
        await SetTournamentAdditionalInfoAsync(tournament);

        return tournament;
    }

    private async Task SetTournamentAdditionalInfoAsync(Tournament tournament)
    {
        var teams = await GetTournamentTeams(tournament.Id);
        tournament.Teams = teams.ToList();

        await SetTournamentSeriesInfo(tournament);

        if (TournamentLogic.IsNextRoundSeriesGenerationsNeeded(tournament) == false)
        {
            return;
        }
        List<Series> nextRoundSeries = TournamentLogic.GenerateNextRoundSeries(tournament);
        foreach (var series in nextRoundSeries)
        {
            await InsertSeries(series);
        }
    }

    public async Task<Tournament> Insert(Tournament tournament)
    {
        var result = await _db.LoadData<Tournament, dynamic>("dbo.spTournament_Insert", new
        {
            tournament.Name,
            tournament.Location,
            tournament.Description
        });
        return result.FirstOrDefault();
    }

    public async Task<Tournament> SetToFinished(int id)
    {
        var result = await _db.LoadData<Tournament, dynamic>("spTournament_SetToFinished", new { Id = id });
        return result.FirstOrDefault();
    }
    public async Task<Tournament> SetToStarted(int id)
    {
        var result = await _db.LoadData<Tournament, dynamic>("[spTournament_SetToStarted]", new { Id = id });

        var tournament = await GetById(id);
        List<Series> initialSeries = TournamentLogic.GetInitialTournamentSeries(tournament);
        foreach (Series series in initialSeries)
        {
            //tournament.Series.Add(series);
            InsertSeries(series);
        }
        tournament = await GetById(tournament.Id);
        return tournament;
    }

    public async Task<Tournament> Update(Tournament tournament)
    {
        var result = await _db.LoadData<Tournament, dynamic>("dbo.spTournament_Update", new
        {
            tournament.Id,
            tournament.Name,
            tournament.Location,
            tournament.Description,
            tournament.IsFinished,
            tournament.IsStarted
        });
        return result.FirstOrDefault();
    }

    public async Task<Tournament> Delete(int id)
    {
        var result = await _db.LoadData<Tournament, dynamic>("dbo.spTournament_Delete", new { id });
        return result.FirstOrDefault();
    }

    private async Task SetTournamentSeriesInfo(Tournament tournament)
    {
        var result = await _db.LoadData<Series, dynamic>("spSeries_GetByTournamentId",
            new { TournamentId = tournament.Id });

        tournament.Series = result.ToList();
        foreach (var series in tournament.Series)
        {
            series.FirstTeam = tournament.Teams
                .Where(s => s.Id == series.FirstTeamId).First();

            series.SecondTeam = tournament.Teams
                .Where(s => s.Id == series.SecondTeamId).First();

            var matches = await _db.LoadData<Match, dynamic>("spMatch_GetBySeriesId",
            new { SeriesId = series.Id });
            series.Matches = matches.ToList();

            TournamentLogic.SetSeriesWinInfo(series);
        }
        return;

    }


    public async Task<TournamentTeam> AddTeamToTournament(int teamId, int tournamentId)
    {
        var result = await _db.LoadData<TournamentTeam, dynamic>("SpTournamentTeam_Insert",
            new { TeamId = teamId, TournamentId = tournamentId });
        return result.FirstOrDefault();
    }

    public async Task<TournamentTeam> RemoveTeamFromTournament(int teamId, int tournamentId)
    {
        var result = await _db.LoadData<TournamentTeam, dynamic>("dbo.spTournamentTeam_Delete",
            new { TeamId = teamId, TournamentId = tournamentId });
        return result.FirstOrDefault();
    }

    private async Task InsertSeries(Series series)
    {
        var result = await _db.LoadData<Series, dynamic>("dbo.spSeries_Insert", new
        {
            series.Round,
            series.PlaceInRound,
            series.FirstTeamId,
            series.SecondTeamId,
            series.TournamentId
        });

    }
}
