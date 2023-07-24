using TrackerLibrary;

namespace DataAccessLibrary.Data.Interfaces
{
    public interface ITournamentData
    {
        ISqlDataAccess _db { get; }

        Task Delete(int id);
        Task<IEnumerable<Tournament>> GetAll();
        Task<Tournament> GetById(int id);
        Task Insert(Tournament tournament);
        Task SetToFinished(int id);
        Task Update(Tournament tournament);
    }
}