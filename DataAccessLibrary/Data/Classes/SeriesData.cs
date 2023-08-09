using DataAccessLibrary.Data.Interfaces;
using TrackerLibrary;

namespace DataAccessLibrary.Data.Classes;

public class SeriesData : ISeriesData
{
    public ISqlDataAccess _db { get; }

    public SeriesData(ISqlDataAccess db)
    {
        _db = db;
    }

    public async Task<IEnumerable<Series>> GetAll()
    {
        return await _db.LoadData<Series, dynamic>("dbo.spSeries_GetAll", new { });
    }

    public async Task<Series> GetById(int id)
    {
        var results = await _db.LoadData<Series, dynamic>("dbo.spSeries_GetByID", new { Id = id });
        return results.FirstOrDefault();
    }

    public async Task Insert(Series series)
    {
        await _db.SaveData("dbo.spSeries_Insert", new
        {
            series.Round,
            series.PlaceInRound,
            series.FirstTeamId,
            series.SecondTeamId,
            series.TournamentId
        });
    }
    public async Task Update(Series series)
    {
        await _db.SaveData("dbo.spSeries_Update", new
        {
            series.Round,
            series.PlaceInRound,
            series.FirstTeamId,
            series.SecondTeamId,
            series.TournamentId
        });
    }

    public async Task Delete(int id)
    {
        await _db.SaveData("dbo.spSeries_Delete", new { id });
    }

}
