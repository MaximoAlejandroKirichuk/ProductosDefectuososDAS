using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
namespace DAL
{
    public class NotificacionDAL
    {
        private string cadenaConexion = StringConnection.stringConnection;

        public bool Insertar(Notificacion notificacion)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                string sql = "INSERT INTO Notificaciones (RemitenteId, DestinatarioId, Mensaje, Fecha, Leida) " +
                             "VALUES (@RemitenteId, @DestinatarioId, @Mensaje, @Fecha, @Leida)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@RemitenteId", notificacion.RemitenteId);
                cmd.Parameters.AddWithValue("@DestinatarioId", notificacion.DestinatarioId);
                cmd.Parameters.AddWithValue("@Mensaje", notificacion.Mensaje);
                cmd.Parameters.AddWithValue("@Fecha", notificacion.Fecha);
                cmd.Parameters.AddWithValue("@Leida", notificacion.Leida);

                conn.Open();
                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
        }

        public List<Notificacion> ObtenerPendientesPorUsuario(int usuarioId)
        {
            List<Notificacion> lista = new List<Notificacion>();
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                string sql = "SELECT * FROM Notificaciones WHERE DestinatarioId = @UsuarioId AND Leida = 0";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Notificacion
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        RemitenteId = Convert.ToInt32(reader["RemitenteId"]),
                        DestinatarioId = Convert.ToInt32(reader["DestinatarioId"]),
                        Mensaje = reader["Mensaje"].ToString(),
                        Fecha = Convert.ToDateTime(reader["Fecha"]),
                        Leida = Convert.ToBoolean(reader["Leida"])
                    });
                }
            }
            return lista;
        }

        public bool MarcarComoLeida(int usuarioId)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                string sql = "UPDATE Notificaciones SET Leida = 1 WHERE DestinatarioId = @UsuarioId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);

                conn.Open();
                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
        }
    }
}
