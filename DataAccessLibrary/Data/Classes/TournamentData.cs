using DataAccessLibrary.Data.Interfaces;
using TrackerLibrary;

namespace DataAccessLibrary.Data.Classes;

public class TournamentData : ITournamentData
{
    public ISqlDataAccess _db { get; }

    public TournamentData(ISqlDataAccess db)
    {
        _db = db;
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
        var results = await _db.LoadData<Tournament, dynamic>("dbo.spTournament_GetByID", new { Id = id });
        return results.FirstOrDefault();
    }

    public async Task Insert(Tournament tournament)
    {
        await _db.SaveData("dbo.spTournament_Insert", new
        {
            tournament.Name,
            tournament.Location,
            tournament.Description
        });
    }

    public async Task SetToFinished(int id)
    {
        await _db.SaveData("spTournament_SetToFinished", new { Id = id });
    }


    public async Task Update(Tournament tournament)
    {
        await _db.SaveData("dbo.spTournament_Update", new
        {
            tournament.Id,
            tournament.Name,
            tournament.Location,
            tournament.Description,
            tournament.IsFinished
        });

    }

    public async Task Delete(int id)
    {
        await _db.SaveData("dbo.spTournament_Delete", new { id });
    }

}
