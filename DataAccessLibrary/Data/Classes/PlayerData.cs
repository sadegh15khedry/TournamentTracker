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


    public async Task<IEnumerable<Player>> GetAll(int userId)
    {
        var result = await _db.LoadData<Player, dynamic>("dbo.spPlayer_GetAll",
            new { UserId = userId });
        var players = result.ToList();

        foreach (var player in players)
        {
            player.Team = GetPlayerTeam(player.Id, userId).Result;
        }

        return players;
    }

    public async Task<Player> GetById(int id, int userId)
    {
        var results = await _db.LoadData<Player, dynamic>("dbo.spPlayer_GetById",
            new { Id = id, UserId = userId });
        var player = results.FirstOrDefault();

        player.Team = GetPlayerTeam(player.Id, userId).Result;

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
            player.Email,
            player.UserId
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
            player.Email,
            player.UserId
        });
        return result.FirstOrDefault();


    }

    public async Task<Player> Delete(int id, int userId)
    {
        var result = await _db.LoadData<Player, dynamic>("dbo.spPlayer_Delete",
            new { Id = id, UserId = userId });
        return result.FirstOrDefault();
    }

    public async Task<IEnumerable<Player>> GetFreeAgentPlayers(int userId)
    {
        return await _db.LoadData<Player, dynamic>("dbo.spPlayer_GetFreeAgentPlayers",
            new { UserId = userId });
    }
    public async Task<IEnumerable<Player>> GetTeamPlayers(int teamId, int userId)
    {
        return await _db.LoadData<Player, dynamic>("dbo.spPlayer_GetTeamPlayers",
            new { TeamId = teamId, UserId = userId });
    }
    public async Task<Player> CanceledContract(int playerId, int userId)
    {
        var result = await _db.LoadData<Player, dynamic>("dbo.spPlayer_CanceledContract",
            new { Id = playerId, UserId = userId });
        return result.FirstOrDefault();
    }

    public async Task<Player> SignedWithTeam(int playerId, int teamId, int userId)
    {
        var result = await _db.LoadData<Player, dynamic>("dbo.spPlayer_SignedWithTeam",
            new { playerId, teamId, UserId = userId });
        return result.FirstOrDefault();

    }
    public async Task<Team> GetPlayerTeam(int teamId, int userId)
    {
        var results = await _db.LoadData<Team, dynamic>
            ("spPlayer_GetPlayerTeam", new { TeamId = teamId, UserId = userId });
        return results.FirstOrDefault();
    }


}
