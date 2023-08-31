using DataAccessLibrary.Data.Interfaces;
using TournamentTrackerLibrary.Logic;
using TournamentTrackerLibrary.Models;

namespace DataAccessLibrary.Data.Classes;

public class SeriesData : ISeriesData
{
    public ISqlDataAccess _db { get; }

    public SeriesData(ISqlDataAccess db)
    {
        _db = db;
    }

    public async Task<IEnumerable<Series>> GetAll(int userId)
    {
        var result = await _db.LoadData<Series, dynamic>("dbo.spSeries_GetAll", new { UserId = userId });
        result = result.ToList();

        foreach (Series series in result)
        {
            await SetSeriesAdditionalInfo(series, userId);
        }

        return result;

    }

    public async Task<Series> GetById(int id, int userId)
    {
        var results = await _db.LoadData<Series, dynamic>("dbo.spSeries_GetByID",
            new { Id = id, UserId = userId });
        var series = results.FirstOrDefault();

        await SetSeriesAdditionalInfo(series, userId);

        return series;
    }

    private async Task SetSeriesAdditionalInfo(Series? series, int userId)
    {


        var firstTeam = await _db.LoadData<Team, dynamic>
            ("dbo.spTeam_GetById", new { Id = series.FirstTeamId, UserId = userId });
        var secondTeam = await _db.LoadData<Team, dynamic>
            ("dbo.spTeam_GetById", new { Id = series.SecondTeamId, UserId = userId });
        var matches = await _db.LoadData<Match, dynamic>
            ("spMatch_GetBySeriesId", new { SeriesId = series.Id, UserId = userId });

        /*        int firstTeamWins = 0;
                int secondTeamWins = 0;
                foreach (var match in matches)
                {
                    if (match.Outcome == 1)
                    {
                        firstTeamWins++;
                    }
                    else if (match.Outcome == 2)
                    {
                        secondTeamWins++;
                    }
                }*/

        series.FirstTeam = firstTeam.FirstOrDefault();
        series.SecondTeam = secondTeam.FirstOrDefault();
        series.Matches = matches.ToList();

        TournamentLogic.SetSeriesWinInfo(series);

        /*        series.FirstTeamWins = firstTeamWins;
                series.SecondTeamWins = secondTeamWins;*/
    }

    public async Task<Series> Insert(Series series)
    {
        var result = await _db.LoadData<Series, dynamic>("dbo.spSeries_Insert", new
        {
            series.Round,
            series.PlaceInRound,
            series.FirstTeamId,
            series.SecondTeamId,
            series.TournamentId,
            series.UserId
        });
        return result.FirstOrDefault();
    }
    public async Task<Series> Update(Series series)
    {
        var result = await _db.LoadData<Series, dynamic>("dbo.spSeries_Update", new
        {
            Id = series.Id,
            IsSeriesFinished = series.IsSeriesEnded,
            Round = series.Round,
            PlaceInRound = series.PlaceInRound,
            FirstTeamId = series.FirstTeamId,
            SecondTeamId = series.SecondTeamId,
            TournamentId = series.TournamentId,
            UserId = series.UserId
        });
        return result.FirstOrDefault();
    }
    public async Task<Series> SetToFinished(int seriesId, int userId)
    {
        var result = await _db.LoadData<Series, dynamic>("dbo.spSeries_SetToFinished", new
        {
            SeriesId = seriesId,
            UserId = userId
        });
        return result.FirstOrDefault();
    }

    public async Task<Series> Delete(int id, int userId)
    {
        var result = await _db.LoadData<Series, dynamic>("dbo.spSeries_Delete",
            new { Id = id, UserId = userId });
        return result.FirstOrDefault();
    }

}
