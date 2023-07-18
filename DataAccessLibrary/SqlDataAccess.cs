using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLibrary;

public class SqlDataAccess : ISqlDataAccess
{
    private readonly IConfiguration _config;


    public SqlDataAccess(IConfiguration config)
    {
        _config = config;
    }

    public async Task<IEnumerable<T>> LoadData<T, U>(string storedProcedures,
        U parameters, string connectionId = "Default")
    {

        using (IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId)))
        {
            return await connection.QueryAsync<T>(storedProcedures,
                parameters, commandType: CommandType.StoredProcedure);
        }

    }

    public async Task SaveData<T>(string storedProcedures, T parameters,
        string connectionId = "Default")
    {


        using (IDbConnection connection = new SqlConnection(
            _config.GetConnectionString(connectionId)))
        {
            await connection.ExecuteAsync(storedProcedures, parameters, commandType: CommandType.StoredProcedure);
        }
    }


}
