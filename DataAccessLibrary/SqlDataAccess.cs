using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLibrary;

public class SqlDataAccess : ISqlDataAccess
{
    private readonly IConfiguration _config;

    public string ConnectionStirng { get; set; } = "Default";

    public SqlDataAccess(IConfiguration config)
    {
        _config = config;
    }

    public async Task<List<T>> LoadData<T, U>(string storedProcedures, U parameters)
    {
        string connectionString = _config.GetConnectionString(ConnectionStirng);

        using (IDbConnection connection = new SqlConnection(connectionString))
        {
            var data = await connection.QueryAsync<T>(storedProcedures, parameters);
            return data.ToList();
        }

    }

    public async Task SaveData<T>(string storedProcedures, T parameters)
    {
        string connectionString = _config.GetConnectionString(ConnectionStirng);

        using (IDbConnection connection = new SqlConnection(connectionString))
        {
            await connection.ExecuteAsync(storedProcedures, parameters);
        }
    }


}
