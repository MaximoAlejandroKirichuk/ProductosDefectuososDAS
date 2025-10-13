using BE;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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

        public bool ModificarSeguimiento(Seguimiento seguimiento)
        {
            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_modificar_seguimiento", conn, transaction))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CodigoSeguimiento", seguimiento.CodigoSeguimiento);
                        cmd.Parameters.AddWithValue("@CodigoProducto", seguimiento.CodigoProducto);
                        cmd.Parameters.AddWithValue("@IDPersonalResponsable", seguimiento.Responsable.IdUsuario);
                        cmd.Parameters.AddWithValue("@Mensaje", seguimiento.Mensaje);
                        cmd.Parameters.AddWithValue("@FechaRegistro", seguimiento.FechaRegistro);
                        cmd.Parameters.AddWithValue("@Visibilidad", (int)seguimiento.TipoVisibilidad);
                        cmd.ExecuteNonQuery();
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
    
    public bool GuardarSeguimiento(List<Seguimiento> seguimientos)
    {
        using (SqlConnection conn = new SqlConnection(stringConnection))
        {
            conn.Open();
            SqlTransaction transaction = conn.BeginTransaction();

            try
            {
                foreach (var s in seguimientos)
                {
                    using (SqlCommand cmd = new SqlCommand("Seguimiento_Insertar", conn, transaction))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@CodigoProducto", s.CodigoProducto);
                        cmd.Parameters.AddWithValue("@IDPersonalResponsable", s.Responsable.IdUsuario);
                        cmd.Parameters.AddWithValue("@Mensaje", s.Mensaje);
                        cmd.Parameters.AddWithValue("@FechaRegistro", s.FechaRegistro);
                        cmd.Parameters.AddWithValue("@Visibilidad", s.TipoVisibilidad);
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

            //esto lo escribe luki 
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
}
}
