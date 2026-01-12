using System.Data;
using Dapper;
using Npgsql;

namespace az_api.DataAccess;

public class SyainDataAccess
{
    private readonly NpgsqlConnection _connection;

    public SyainDataAccess(NpgsqlConnection connection)
    {
        _connection = connection;
    }

    public async Task<DataTable> GetSyainAsync(long id)
    {
        string sql = @"
            SELECT 
                id,
                syain_cd,
                syain_name
            FROM az.t_syain
            WHERE id = @id
        ";

        DataTable result = new DataTable();
        var reader = await _connection.ExecuteReaderAsync(sql, new { id });
        result.Load(reader);

        return result;
    }
}
