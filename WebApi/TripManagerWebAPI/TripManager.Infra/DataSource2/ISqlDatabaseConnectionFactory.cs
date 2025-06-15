using System.Data;

namespace TripManager.Infra.DataSource2;

public interface ISqlDatabaseConnectionFactory
{
    Task<IDbConnection> GetOpenConnectionAsync();

    IDbConnection GetOpenConnection();
}