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

    public async Task<TournamentTeam> LeftTournament(int teamId, int tournamentId)
    {
        var result = await _db.LoadData<TournamentTeam, dynamic>("dbo.spTournamentTeam_Delete", new { TeamId = teamId, TournamentId = tournamentId });
        return result.FirstOrDefault();
    }

    public async Task<TournamentTeam> JoinedTournament(int teamId, int tournamentId)
    {
        var result = await _db.LoadData<TournamentTeam, dynamic>("SpTournamentTeam_Insert", new { TeamId = teamId, TournamentId = tournamentId });
        return result.FirstOrDefault();
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

    public async Task<Team> Update(Team team)
    {
        var result = await _db.LoadData<Team, dynamic>("dbo.spTeam_Update", new
        {
            team.Id,
            team.Name,
            team.City,
            team.Owner
        });
        return result.FirstOrDefault();

    }

    public async Task<Team> Delete(int id)
    {
        var result = await _db.LoadData<Team, dynamic>("dbo.spTeam_Delete", new { id });
        return result.FirstOrDefault();
    }

}
