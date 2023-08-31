using TournamentTrackerLibrary.Models;

namespace DataAccessLibrary.Data.Interfaces
{
    public interface ITeamData
    {
        ISqlDataAccess _db { get; }

        Task<Team> Delete(int id, int userId);
        Task<IEnumerable<Team>> GetAll(int userId);
        Task<Team> GetById(int id, int userId);
        Task<Team> Insert(Team team);
        Task<Team> Update(Team team);
    }
}