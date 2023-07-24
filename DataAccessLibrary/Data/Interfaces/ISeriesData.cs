using TrackerLibrary;

namespace DataAccessLibrary.Data.Interfaces
{
    public interface ISeriesData
    {
        ISqlDataAccess _db { get; }

        Task Delete(int id);
        Task<IEnumerable<Series>> GetAll();
        Task<Series> GetById(int id);
        Task Insert(Series series);
        Task Update(Series series);
    }
}