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
        public List<Log> Listar()
        {
            List<Log> logs = new List<Log>();

            using (SqlConnection conn = new SqlConnection(connection))
            {
                string query = "SELECT * FROM Log";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    logs.Add(new Log
                    {
                        Id = Convert.ToInt32(dr["NumeroLog"]),
                        UsuarioId = dr["IdEmpleado"] == DBNull.Value ? null : (int?)Convert.ToInt32(dr["IdEmpleado"]),
                        FechaEvento = Convert.ToDateTime(dr["FechaEvento"]),
                        NivelLog = (NivelLog)Enum.Parse(typeof(NivelLog), dr["NivelLog"].ToString()),
                        ModuloInvolucrado = (ModuloSistema)Enum.Parse(typeof(ModuloSistema), dr["ModuloInvolucrado"].ToString()),
                        Criticidad = (Criticidad)Enum.Parse(typeof(Criticidad), dr["Criticidad"].ToString()),
                        AccionRealizada = dr["AccionRealizada"].ToString()
                    });
                }
                return logs;
            }
        }

    }
}
