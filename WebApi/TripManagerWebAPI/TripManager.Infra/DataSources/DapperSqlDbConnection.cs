using Dapper;

namespace TripManager.Infra.DataSources;

public class DapperSqlDbConnection
{
    protected readonly SqlDbConnectionFactory _connections;

    public DapperSqlDbConnection(SqlDbConnectionFactory connections)
    {
        _connections = connections;
    }
    
    public async Task<int> ExecuteAsync(string sql, object? param = null)
    {
        using var con = await _connections.GetOpenConnectionAsync().ConfigureAwait(false);
        return await con.ExecuteAsync(sql, param).ConfigureAwait(false);
    }

    public async Task<T?> ExecuteScalarAsync<T>(string sql, object? param = null)
    {
        using var con = await _connections.GetOpenConnectionAsync().ConfigureAwait(false);
        return await con.ExecuteScalarAsync<T>(sql, param).ConfigureAwait(false);
    }

    public async Task<IEnumerable<T>> QueryAsync<T>(string sql, object? param = null)
    {
        using var con = await _connections.GetOpenConnectionAsync().ConfigureAwait(false);
        return await con.QueryAsync<T>(sql, param).ConfigureAwait(false);
    }

    public async Task<T?> QuerySingleAsync<T>(string sql, object? param = null)
    {
        using var con = await _connections.GetOpenConnectionAsync().ConfigureAwait(false);
        return await con.QuerySingleOrDefaultAsync<T>(sql, param).ConfigureAwait(false);
    }

    public async Task<T?> QueryFirstAsync<T>(string sql, object? param = null)
    {
        using var con = await _connections.GetOpenConnectionAsync().ConfigureAwait(false);
        return await con.QueryFirstOrDefaultAsync<T>(sql, param).ConfigureAwait(false);
    }
}