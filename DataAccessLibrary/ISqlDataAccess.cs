namespace DataAccessLibrary;

public interface ISqlDataAccess
{
    string ConnectionStirng { get; set; }

    Task<List<T>> LoadData<T, U>(string sql, U parameters);

    Task SaveData<T>(string sql, T parameters);


}