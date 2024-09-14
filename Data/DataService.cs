using System;
using Dapper;
using MySql.Data.MySqlClient;

namespace Registrar;

public class DataService(string connectionString)
{
    private readonly string connectionString = connectionString;

    public async Task<List<T>> LoadData<T, U>(string sql, U parameters)
    {
        using (var connection = new MySqlConnection(connectionString))
        {
            var rows = await connection.QueryAsync<T>(sql, parameters);
            return rows.ToList();
        }
    }

    public async Task SaveData<T>(string sql, T parameters)
    {
        using (var connection = new MySqlConnection(connectionString))
        {
            await connection.ExecuteAsync(sql, parameters);
        }
    }
}