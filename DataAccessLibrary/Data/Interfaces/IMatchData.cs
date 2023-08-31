using TournamentTrackerLibrary.Models;

namespace DataAccessLibrary.Data
{
    public interface IMatchData
    {
        ISqlDataAccess _db { get; }

        Task<Match> Delete(int id, int userId);
        Task<IEnumerable<Match>> GetAll(int userId);
        Task<Match> GetById(int id, int userId);
        Task<Match> Insert(Match match);
        Task<Match> Update(Match match);
    }
}