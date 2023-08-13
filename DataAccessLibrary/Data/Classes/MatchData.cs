using Match = TournamentTrackerLibrary.Models.Match;

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

    public async Task<Match> Insert(Match match)
    {
        var result = await _db.LoadData<Match, dynamic>("dbo.spMatch_Insert", new
        {
            match.Outcome,
            match.FirstTeamScore,
            match.SecondTeamScore,
            match.SeriesId
        });

        return result.FirstOrDefault();
    }
    public async Task<Match> Update(Match match)
    {
        var result = await _db.LoadData<Match, dynamic>("dbo.spMatch_Update", new
        {
            match.Id,
            match.Outcome,
            match.FirstTeamScore,
            match.SecondTeamScore,
            match.SeriesId
        });
        return result.FirstOrDefault();

    }
    public async Task<Match> Delete(int id)
    {
        var result = await _db.LoadData<Match, dynamic>("dbo.spMatch_Delete", new { id });
        return result.FirstOrDefault();

    }


}
