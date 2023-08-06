using DataAccessLibrary.Data.Interfaces;
using TrackerLibrary;

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

    public async Task CanceledContract(int playerId)
    {
        await _db.SaveData("dbo.spPlayer_CanceledContract", new { Id = playerId });

    }

    public async Task SignedWithTeam(int playerId, int teamId)
    {
        await _db.SaveData("dbo.spPlayer_SignedWithTeam", new { playerId, teamId });

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

    public async Task Insert(Player player)
    {
        await _db.SaveData("dbo.spPlayer_Insert", new
        {
            player.SSN,
            player.FirstName,
            player.LastName,
            player.Phone,
            player.Email
        });
    }

    public async Task Update(Player player)
    {
        await _db.SaveData("dbo.spPlayer_Update", new
        {
            player.Id,
            player.SSN,
            player.FirstName,
            player.LastName,
            player.Phone,
            player.Email
        });

    }

    public async Task Delete(int id)
    {
        await _db.SaveData("dbo.spPlayer_Delete", new { id });
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
