using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace Louer.Infra
{
    public class SimentaQConnection
    {
        [Inject]
        private static IConnectionService connectionService { get; set; }

        private static MySqlConnection _connection;

        private static MySqlConnection _connectionBeta;

        private static ConnectionOracle currentConnection;

        public static ConnectionOracle CurrentConnection { get { return currentConnection; } }

        private static string connStr;

        public static string ConnStr { get { return connStr; } }

        private static MySqlConnection GetConnection()
        {
            var factory = DbProviderFactories.GetFactory("Oracle.ManagedDataAccess.Client");

            connectionService = CompositionRoot.Resolve<IConnectionService>();
            currentConnection = connectionService.GetCurrentConnection();
            connStr = currentConnection.ConnectionString;

            var connection = (MySqlConnection)factory.CreateConnection();
            if (connection != null) connection.ConnectionString = connStr;

            return connection;
        }

        public static DbConnection GetDbConnection()
        {
            if (_connection != null) return _connection;

            _connection = GetConnection();

            return _connection;
        }

        public static MySqlConnection GetMySqlConnection()
        {
            if (_connection != null) return _connection;

            return (MySqlConnection)GetDbConnection();
        }

        public static DbConnection GetDbConnectionBeta()
        {
            if (_connectionBeta != null) return _connectionBeta;

            _connectionBeta = GetConnection();

            return _connectionBeta;
        }

    }
}
