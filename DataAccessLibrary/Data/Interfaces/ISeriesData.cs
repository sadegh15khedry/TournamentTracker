using TournamentTrackerLibrary.Models;

namespace DataAccessLibrary.Data.Interfaces;

public interface ISeriesData
{
    ISqlDataAccess _db { get; }

    Task<Series> Delete(int id, int userId);
    Task<IEnumerable<Series>> GetAll(int userId);
    Task<Series> GetById(int id, int userId);
    Task<Series> Insert(Series series);
    Task<Series> Update(Series series);
    Task<Series> SetToFinished(int seriesId, int userId);
}