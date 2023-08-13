using TournamentTrackerLibrary.Models;

namespace DataAccessLibrary.Data.Interfaces;

public interface ISeriesData
{
    ISqlDataAccess _db { get; }

    Task<Series> Delete(int id);
    Task<IEnumerable<Series>> GetAll();
    Task<Series> GetById(int id);
    Task<Series> Insert(Series series);
    Task<Series> Update(Series series);
    Task<Series> SetToFinished(int seriesId);
}