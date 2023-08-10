using TournamentTrackerLibrary.Models;

namespace DataAccessLibrary.Data.Interfaces;

public interface IPlayerData
{
    ISqlDataAccess _db { get; }

    Task<Player> CanceledContract(int playerId);
    Task<Player> SignedWithTeam(int playerId, int teamId);
    Task<Team> GetPlayerTeam(int teamId);
    Task<Player> Delete(int id);
    Task<IEnumerable<Player>> GetAll();
    Task<Player> GetById(int id);
    Task<Player> Insert(Player player);
    Task<Player> Update(Player match);
    Task<IEnumerable<Player>> GetFreeAgentPlayers();
    Task<IEnumerable<Player>> GetTeamPlayers(int teamId);
}