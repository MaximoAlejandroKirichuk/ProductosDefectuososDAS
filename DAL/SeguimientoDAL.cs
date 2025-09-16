using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SeguimientoDAL
    {
        private readonly string stringConnection = StringConnection.stringConnection;

        public bool GuardarSeguimiento(List<Seguimiento> seguimientos)
        {
            using(SqlConnection conn = new SqlConnection(stringConnection))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    foreach (var s in seguimientos)
                    {
                        using(SqlCommand cmd = new SqlCommand("Seguimiento_Insertar", conn, transaction))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@CodigoProducto", s.CodigoProducto);
                            cmd.Parameters.AddWithValue("@IDPersonalResponsable", s.Responsable.IdUsuario);
                            cmd.Parameters.AddWithValue("@Mensaje", s.Mensaje);
                            cmd.Parameters.AddWithValue("@FechaRegistro", s.FechaRegistro);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    //Si salio todo bien 
                    transaction.Commit();
                    return true;
                }
                catch (Exception)
                {
                    //Volvemos para atras
                    transaction.Rollback();
                    return false;
                }
            }
        }
        public DataTable ObtenerSeguimientoPorProductos(int id)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                conn.Open();
                string query = "SELECT * FROM Seguimiento WHERE CodigoProducto = @CodigoProducto";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CodigoProducto", id);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }


    }
}
