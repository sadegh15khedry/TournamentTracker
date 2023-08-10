using TournamentTrackerLibrary.Models;

namespace DataAccessLibrary.Data
{
    public interface IMatchData
    {
        ISqlDataAccess _db { get; }

        Task<Match> Delete(int id);
        Task<IEnumerable<Match>> GetAll();
        Task<Match> GetById(int id);
        Task<Match> Insert(Match match);
        Task<Match> Update(Match match);
    }
}