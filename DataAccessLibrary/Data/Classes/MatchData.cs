using TrackerLibrary;

namespace DataAccessLibrary.Data;

public class MatchData : IMatchData
{
    /// <summary>
    /// !imporatant
    ///
    /// </summary>
    public ISqlDataAccess _db { get; }

    public MatchData(ISqlDataAccess db)
    {
        _db = db;
    }

    public async Task<IEnumerable<Match>> GetAll()
    {
        return await _db.LoadData<Match, dynamic>("dbo.spMatch_GetAll", new { });
    }

    public async Task<Match> GetById(int id)
    {
        var results = await _db.LoadData<Match, dynamic>("dbo.spMatch_GetByID", new { Id = id });
        return results.FirstOrDefault();
    }

    public async Task Insert(Match match)
    {
        await _db.SaveData("dbo.spMatch_Insert", new
        {
            match.Outcome,
            match.FirstTeamScore,
            match.SecondTeamScore,
            match.SeriesId
        });
    }
    public async Task Update(Match match)
    {
        await _db.SaveData("dbo.spMatch_Update", match);
    }
    public async Task Delete(int id)
    {
        await _db.SaveData("dbo.spMatch_Delete", new { id });
    }


}
