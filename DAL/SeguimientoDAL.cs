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
                            cmd.Parameters.AddWithValue("@Visibilidad", (int)s.TipoVisibilidad); 


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
                //VOLVER A PONER ESTO O BORRARLO SINO FUNCIONAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
                //string query = "SELECT * FROM Seguimiento WHERE CodigoProducto = @CodigoProducto";
                string query = @"SELECT s.CodigoSeguimiento,
                                 s.CodigoProducto,
                                 s.Mensaje,
                                 s.FechaRegistro,
                                 s.IDPersonalResponsable,
                                 s.Visibilidad,
                                 e.NombreCompleto AS NombreResponsable
                                 FROM Seguimiento s
                                 INNER JOIN Empleado e ON s.IDPersonalResponsable = e.IdEmpleado
                                 WHERE s.CodigoProducto = @CodigoProducto";

                //esto lo escribe luki no gpt
                //la parte donde dice: e.NombreCompleto AS NombreResponsable ; lo que hace es agarrar de la tabla e. osea empleado trae 
                //el nombre del empleado y le ponemos como nombre NombreResponsable. por eso le pone el AS 
                //por que dice traete el nombre de la tabla e. COMO/AS NombreResponsable.



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
        public DataTable ObtenerSeguimientosPublicosPorProducto(int codigoProducto)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                conn.Open();
                string query = @"
                                SELECT s.CodigoSeguimiento,
                                       s.CodigoProducto,
                                       s.Mensaje,
                                       s.FechaRegistro,
                                       s.IDPersonalResponsable,
                                       s.Visibilidad,
                                       e.NombreCompleto AS NombreResponsable
                                FROM Seguimiento s
                                INNER JOIN Empleado e ON s.IDPersonalResponsable = e.IdEmpleado
                                WHERE s.CodigoProducto = @CodigoProducto
                                  AND s.Visibilidad = 0"; // 0 = Publica

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CodigoProducto", codigoProducto);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public int ObtenerIdClientePorDocumento(string nroDocumento)
        {
            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                string query = "SELECT IdCliente FROM Cliente WHERE NroDocumento = @NroDocumento";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@NroDocumento", nroDocumento);
                    con.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int idCliente))
                    {
                        return idCliente;
                    }
                    else
                    {
                        return -1; // o lanzar excepción o manejar error según convenga
                    }
                }
            }
        }
    }
}
