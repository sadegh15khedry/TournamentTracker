using DataAccessLibrary.Data.Interfaces;
using TournamentTrackerLibrary.Models;

namespace DataAccessLibrary;

public class PlayerData : IPlayerData
{
    /// <summary>
    /// !imporatant
    ///
    /// </summary>
    public ISqlDataAccess _db { get; }

    public PlayerData(ISqlDataAccess db)
    {
        _db = db;
    }

    public async Task<Player> CanceledContract(int playerId)
    {
        var result = await _db.LoadData<Player, dynamic>("dbo.spPlayer_CanceledContract", new { Id = playerId });
        return result.FirstOrDefault();
    }

    public async Task<Player> SignedWithTeam(int playerId, int teamId)
    {
        var result = await _db.LoadData<Player, dynamic>("dbo.spPlayer_SignedWithTeam", new { playerId, teamId });
        return result.FirstOrDefault();

    }
    public async Task<Team> GetPlayerTeam(int teamId)
    {
        var results = await _db.LoadData<Team, dynamic>
            ("spPlayer_GetPlayerTeam", new { TeamId = teamId });
        return results.FirstOrDefault();
    }
    public async Task<IEnumerable<Player>> GetAll()
    {
        return await _db.LoadData<Player, dynamic>("dbo.spPlayer_GetAll", new { });
    }

    public async Task<Player> GetById(int id)
    {
        var results = await _db.LoadData<Player, dynamic>("dbo.spPlayer_GetByID", new { Id = id });
        return results.FirstOrDefault();
    }

    public async Task<Player> Insert(Player player)
    {
        var result = await _db.LoadData<Player, dynamic>("dbo.spPlayer_Insert", new
        {
            player.SSN,
            player.FirstName,
            player.LastName,
            player.Phone,
            player.Email
        });
        return result.FirstOrDefault();

    }

    public async Task<Player> Update(Player player)
    {
        var result = await _db.LoadData<Player, dynamic>("dbo.spPlayer_Update", new
        {
            player.Id,
            player.SSN,
            player.FirstName,
            player.LastName,
            player.Phone,
            player.Email
        });
        return result.FirstOrDefault();


    }

    public async Task<Player> Delete(int id)
    {
        var result = await _db.LoadData<Player, dynamic>("dbo.spPlayer_Delete", new { id });
        return result.FirstOrDefault();
    }

    public async Task<IEnumerable<Player>> GetFreeAgentPlayers()
    {
        return await _db.LoadData<Player, dynamic>("dbo.spPlayer_GetFreeAgentPlayers", new { });
    }
    public async Task<IEnumerable<Player>> GetTeamPlayers(int teamId)
    {
        return await _db.LoadData<Player, dynamic>("dbo.spPlayer_GetTeamPlayers", new { TeamId = teamId });
    }


}
