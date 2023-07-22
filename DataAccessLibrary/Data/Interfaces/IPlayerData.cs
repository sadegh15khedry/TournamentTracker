using TrackerLibrary;

namespace DataAccessLibrary.Data.Interfaces
{
    public interface IPlayerData
    {
        ISqlDataAccess _db { get; }

        public Task SignedWithTeam(int playerId, int teamId);
        Task<Team> GetPlayerTeam(int teamId);
        Task Delete(int id);
        Task<IEnumerable<Player>> GetAll();
        Task<Player> GetById(int id);
        Task Insert(Player player);
        Task Update(Player match);
    }
}