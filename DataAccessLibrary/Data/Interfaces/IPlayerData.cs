using TournamentTrackerLibrary.Models;

namespace DataAccessLibrary.Data.Interfaces;

public interface IPlayerData
{
    ISqlDataAccess _db { get; }

    Task<Player> CanceledContract(int playerId, int userId);
    Task<Player> SignedWithTeam(int playerId, int teamId, int userId);
    Task<Team> GetPlayerTeam(int teamId, int userId);
    Task<Player> Delete(int id, int userId);
    Task<IEnumerable<Player>> GetAll(int userId);
    Task<Player> GetById(int id, int userId);
    Task<Player> Insert(Player player);
    Task<Player> Update(Player player);
    Task<IEnumerable<Player>> GetFreeAgentPlayers(int userId);
    Task<IEnumerable<Player>> GetTeamPlayers(int teamId, int userId);
}