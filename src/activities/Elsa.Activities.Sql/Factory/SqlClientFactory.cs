using Elsa.Activities.Sql.Client;
using Elsa.Activities.Sql.Client.PostgreSqlClient;
using Elsa.Activities.Sql.Models;
using System;

namespace Elsa.Activities.Sql.Factory
{
    public class SqlClientFactory : ISqlClientFactory
    {
        public ISqlClient CreateClient(CreateSqlClientModel createSqlClient)
        {
            switch (createSqlClient.Database)
            {
                case SupportedDatabases.MSSQLServer:
                    return new SqlServerClient(createSqlClient.ConnectionString);
                case SupportedDatabases.PostgreSql:
                    return new PostgreSqlClient(createSqlClient.ConnectionString);
                default:
                    throw new ArgumentException($"Unsupported database type: {createSqlClient.Database}");
            }
            
        }
    }
}
