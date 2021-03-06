﻿using System.Data.Common;
using System.Threading.Tasks;

namespace ClickHouse.Client.Utility
{
    public static class ConnectionExtensions
    {
        public static async Task<int> ExecuteStatementAsync(this DbConnection connection, string sql)
        {
            using var command = connection.CreateCommand();
            command.CommandText = sql;
            return await command.ExecuteNonQueryAsync().ConfigureAwait(false);
        }

        public static async Task<object> ExecuteScalarAsync(this DbConnection connection, string sql)
        {
            using var command = connection.CreateCommand();
            command.CommandText = sql;
            return await command.ExecuteScalarAsync().ConfigureAwait(false);
        }

        public static async Task<DbDataReader> ExecuteReaderAsync(this DbConnection connection, string sql)
        {
            using var command = connection.CreateCommand();
            command.CommandText = sql;
            return await command.ExecuteReaderAsync().ConfigureAwait(false);
        }
    }
}
