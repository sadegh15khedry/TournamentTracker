using TrackerLibrary;

namespace DataAccessLibrary.Data
{
    public interface IMatchData
    {
        ISqlDataAccess _db { get; }

        Task Delete(int id);
        Task<IEnumerable<Match>> GetAll();
        Task<Match> GetById(int id);
        Task Insert(Match match);
        Task Update(Match match);
    }
}