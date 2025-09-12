using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class StringConnection
    {
        //Pruebas en local
        //public static string stringConnection = "Server=.;Database=ProductosDefectuosos;Trusted_Connection=True;";

        // Leer variables de entorno
        private readonly static string dbUser = Environment.GetEnvironmentVariable("DB_USER");
        private readonly static string dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD");

        public static string stringConnection
        {
            get
            {
                if (string.IsNullOrEmpty(dbUser) || string.IsNullOrEmpty(dbPassword))
                    throw new InvalidOperationException(
                        "Las variables de entorno DB_USER o DB_PASSWORD no están definidas."
                    );

                return
                    $"Server=tcp:das-proyecto.database.windows.net,1433;" +
                    "Initial Catalog=BaseDatos;" +
                    "Persist Security Info=False;" +
                    $"User ID={dbUser};" +
                    $"Password={dbPassword};" +
                    "MultipleActiveResultSets=False;" +
                    "Encrypt=True;" +
                    "TrustServerCertificate=False;" +
                    "Connection Timeout=30;";
            }
        }

    }
}