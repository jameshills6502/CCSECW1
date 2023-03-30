namespace MotoMotoMotors.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Dapper;
using MySql.Data.MySqlClient;

public class DataAccess : IDataAccess
{
    public async Task<List<T>> LoadData<T, U>(string sql, U parameters, string connectionString)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
                var rows = await connection.QueryAsync<T>(sql, parameters);
                return rows.ToList();
        }
    }
    public async Task SaveData<T>(string sql, T parameters, string connectionString)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            await connection.ExecuteAsync(sql, parameters);
        }
    }
}
