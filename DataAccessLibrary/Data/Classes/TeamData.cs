using DataAccessLibrary.Data.Interfaces;
using TrackerLibrary;

namespace DataAccessLibrary.Data.Classes;

public class TeamData : ITeamData
{
    public ISqlDataAccess _db { get; }

    public TeamData(ISqlDataAccess db)
    {
        _db = db;
    }

    public async Task LeftTournament(int teamId, int tournamentId)
    {
        await _db.SaveData("dbo.spTournamentTeam_Delete", new { TeamId = teamId, TournamentId = tournamentId });

    }

    public async Task JoinedTournament(int teamId, int tournamentId)
    {
        await _db.SaveData("SpTournamentTeam_Insert", new { TeamId = teamId, TournamentId = tournamentId });

    }

    public async Task<IEnumerable<Team>> GetAll()
    {
        return await _db.LoadData<Team, dynamic>("dbo.spTeam_GetAll", new { });
    }

    public async Task<Team> GetById(int id)
    {
        var results = await _db.LoadData<Team, dynamic>("dbo.spTeam_GetByID", new { Id = id });
        return results.FirstOrDefault();
    }

    public async Task<Team> Insert(Team team)
    {
        var result = await _db.LoadData<Team, dynamic>("dbo.spTeam_Insert", new
        {

            team.Name,
            team.City,
            team.Owner
        });
        return result.FirstOrDefault();
    }

    public async Task Update(Team team)
    {
        await _db.SaveData("dbo.spTeam_Update", new
        {
            team.Id,
            team.Name,
            team.City,
            team.Owner
        });

    }

    public async Task Delete(int id)
    {
        await _db.SaveData("dbo.spTeam_Delete", new { id });
    }

}
