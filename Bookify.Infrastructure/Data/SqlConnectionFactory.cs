using Bookify.Application.Abstractions.Data;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Bookify.Infrastructure.Data;

internal sealed class SqlConnectionFactory(string connectionString) : ISqlConnectionFactory
{
    private readonly string _connectionString = connectionString;
    public IDbConnection CreateConnection()
    {
        var connection = new SqlConnection(_connectionString);
        connection.Open();

        return connection;
    }
}
