using DataAccessLibrary.Data.Interfaces;
using TournamentTrackerLibrary.Models;

namespace DataAccessLibrary.Data.Classes;

public class TeamData : ITeamData
{
    public ISqlDataAccess _db { get; }

    public TeamData(ISqlDataAccess db)
    {
        _db = db;
    }



    public async Task<IEnumerable<Team>> GetAll(int userId)
    {
        return await _db.LoadData<Team, dynamic>("dbo.spTeam_GetAll", new { UserId = userId });
    }

    public async Task<Team> GetById(int id, int userId)
    {
        var results = await _db.LoadData<Team, dynamic>("dbo.spTeam_GetByID",
            new { Id = id, UserId = userId });
        return results.FirstOrDefault();
    }

    public async Task<Team> Insert(Team team)
    {
        var result = await _db.LoadData<Team, dynamic>("dbo.spTeam_Insert", new
        {

            team.Name,
            team.City,
            team.Owner,
            team.UserId
        });
        return result.FirstOrDefault();
    }

    public async Task<Team> Update(Team team)
    {
        var result = await _db.LoadData<Team, dynamic>("dbo.spTeam_Update", new
        {
            team.Id,
            team.Name,
            team.City,
            team.Owner,
            team.UserId

        });
        return result.FirstOrDefault();

    }

    public async Task<Team> Delete(int id, int userId)
    {
        var result = await _db.LoadData<Team, dynamic>("dbo.spTeam_Delete",
            new { Id = id, UserId = userId });
        return result.FirstOrDefault();
    }

}
