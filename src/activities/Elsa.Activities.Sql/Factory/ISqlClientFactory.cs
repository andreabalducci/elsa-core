using Elsa.Activities.Sql.Client;
using Elsa.Activities.Sql.Models;

namespace Elsa.Activities.Sql.Factory
{
    public static class SupportedDatabases
    {
        public const string MSSQLServer = "MSSQLServer";
        public const string PostgreSql = "PostgreSql";
    }

    public interface ISqlClientFactory
    {
        ISqlClient CreateClient(CreateSqlClientModel createSqlClient);
    }
}
