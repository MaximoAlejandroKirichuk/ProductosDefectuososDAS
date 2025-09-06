using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class StringConnection
    {
        private static string dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD");
        public static string stringConnection =
    "Server=tcp:das-proyecto.database.windows.net,1433;" +
    "Initial Catalog=BaseDatos;" +
    "Persist Security Info=False;" +
    "User ID=maxdas;" +
    $"Password={dbPassword};" +
    "MultipleActiveResultSets=False;" +
    "Encrypt=True;" +
    "TrustServerCertificate=False;" +
    "Connection Timeout=30;";
    }
}
