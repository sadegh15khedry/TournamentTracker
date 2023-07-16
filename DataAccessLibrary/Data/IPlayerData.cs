using TrackerLibrary;

namespace DataAccessLibrary
{
    public interface IPlayerData
    {
        ISqlDataAccess _db { get; }

        Task<List<Player>> GetPlayers();
        Task InsertPlayer(Player person);
    }
}