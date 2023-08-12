using TournamentTrackerLibrary.Models;

namespace DataAccessLibrary.Data.Interfaces
{
    public interface ITeamData
    {
        ISqlDataAccess _db { get; }

        Task<Team> Delete(int id);
        Task<IEnumerable<Team>> GetAll();
        Task<Team> GetById(int id);
        Task<Team> Insert(Team team);
        Task<Team> Update(Team team);
    }
}