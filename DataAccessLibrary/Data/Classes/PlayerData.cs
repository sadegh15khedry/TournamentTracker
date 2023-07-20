using DataAccessLibrary.Data.Interfaces;
using TrackerLibrary;

namespace DataAccessLibrary;

public class PlayerData : IPlayerData
{
    /// <summary>
    /// !imporatant
    ///
    /// </summary>
    public ISqlDataAccess _db { get; }

    public PlayerData(ISqlDataAccess db)
    {
        _db = db;
    }

    public async Task<IEnumerable<Player>> GetAll()
    {
        return await _db.LoadData<Player, dynamic>("dbo.spPlayer_GetAll", new { });
    }

    public async Task<Player> GetById(int id)
    {
        var results = await _db.LoadData<Player, dynamic>("dbo.spPlayer_GetByID", new { Id = id });
        return results.FirstOrDefault();
    }

    public async Task Insert(Player player)
    {
        await _db.SaveData("dbo.spPlayer_Insert", new
        {
            player.SSN,
            player.FirstName,
            player.LastName,
            player.Phone,
            player.Email
        });
    }
    public async Task Update(Player player)
    {
        await _db.SaveData("dbo.spPlayer_Update", player);
    }
    public async Task Delete(int id)
    {
        await _db.SaveData("dbo.spPlayer_Delete", new { id });
    }

}
