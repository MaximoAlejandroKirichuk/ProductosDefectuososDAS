using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class LogDAL
    {
        string connection = StringConnection.stringConnection;
        public bool Insertar(Log log)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                string query = @"INSERT INTO Log 
                                (IdEmpleado, FechaEvento, NivelLog, ModuloInvolucrado, Criticidad, AccionRealizada)
                                 VALUES (@IdEmpleado, @FechaEvento, @NivelLog, @ModuloInvolucrado, @Criticidad, @AccionRealizada)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdEmpleado",log.UsuarioId);
                cmd.Parameters.AddWithValue("@FechaEvento", log.FechaEvento);
                cmd.Parameters.AddWithValue("@NivelLog", log.NivelLog.ToString());
                cmd.Parameters.AddWithValue("@ModuloInvolucrado", log.ModuloInvolucrado.ToString());
                cmd.Parameters.AddWithValue("@Criticidad", log.Criticidad.ToString());
                cmd.Parameters.AddWithValue("@AccionRealizada", log.AccionRealizada);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

    }
}
