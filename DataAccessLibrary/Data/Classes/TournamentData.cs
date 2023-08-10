using DataAccessLibrary.Data.Interfaces;
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
        return await _db.LoadData<Team, dynamic>("dbo.spTournament_GetTeams",
            new { TournamentId = tournamentId });
    }

    public async Task<IEnumerable<Tournament>> GetAll()
    {
        return await _db.LoadData<Tournament, dynamic>("dbo.spTournament_GetAll", new { });
    }

    public async Task<Tournament> GetById(int id)
    {
        var results = await _db.LoadData<Tournament, dynamic>
            ("dbo.spTournament_GetByID", new { Id = id });

        Tournament tournament = results.FirstOrDefault();
        tournament.Teams = GetTournamentTeams(id).Result.ToList();
        tournament.Series = GetTournamentSeries(id).Result.ToList();

        foreach (var series in tournament.Series)
        {
            series.FirstTeam = tournament.Teams.Where(s => s.Id == series.FirstTeamId).FirstOrDefault();
            series.SecondTeam = tournament.Teams.Where(s => s.Id == series.SecondTeamId).FirstOrDefault();

        }

        return tournament;
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

    public async Task<IEnumerable<Series>> GetTournamentSeries(int tournamentId)
    {
        return await _db.LoadData<Series, dynamic>("spSeries_GetByTournamentId",
            new { TournamentId = tournamentId });

    }
}
