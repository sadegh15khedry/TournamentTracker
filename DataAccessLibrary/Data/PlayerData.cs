using TrackerLibrary;

namespace DataAccessLibrary;

public class PlayerData : IPlayerData
{
    public ISqlDataAccess _db { get; }

    public PlayerData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<List<Player>> GetPlayers()
    {
        string sql = "select * from dbo.Player";
        return _db.LoadData<Player, dynamic>(sql, new { });
    }

    public Task InsertPlayer(Player person)
    {
        string sql = @"insert into dbo.Person (FirstName, LastName)
                        values (@FirstName, @LastName);";

        return _db.SaveData<Player>(sql, person);
    }

}
