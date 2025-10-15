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
            try
            {
                using (SqlConnection conn = new SqlConnection(stringConnection))
                {
                    conn.Open();
                    DataSet ds = new DataSet();
                    string query = "SELECT * FROM Seguimiento WHERE 1 = 0";//siempre va a ser falso y eso solo trae los encabezados
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                    // genera automáticamente el INSERT, UPDATE, DELETE
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                    
                    adapter.Fill(ds, "Seguimiento");//nombre que le damos a la tabla dentro del DataSet
                    DataTable tabla = ds.Tables["Seguimiento"];

                    // Agregamos las filas al DataSet
                    foreach (var s in seguimientos)
                    {
                        DataRow row = tabla.NewRow();
                        row["CodigoProducto"] = s.CodigoProducto;
                        row["IDPersonalResponsable"] = s.Responsable.IdUsuario;
                        row["Mensaje"] = s.Mensaje;
                        row["FechaRegistro"] = s.FechaRegistro;
                        row["Visibilidad"] = (int)s.TipoVisibilidad;
                        tabla.Rows.Add(row);
                    }
                    // Actualizamos la base de datos de una sola vez
                    adapter.Update(ds, "Seguimiento");

                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }




        //ESTO LO QUE HARIAMOS EN VEZ DE USAR EL SqlCommandBuilder
        // Si no tendria el sqlCommandBuilder tendria que crear manualmente los comandos InsertCommand, UpdateCommand y DeleteCommand manualmente.

        //adapter.InsertCommand = new SqlCommand(
        //    "INSERT INTO Seguimiento (CodigoProducto, IDPersonalResponsable, Mensaje, FechaRegistro, Visibilidad) " +
        //    "VALUES (@CodigoProducto, @IDPersonalResponsable, @Mensaje, @FechaRegistro, @Visibilidad)", conn);
        //adapter.InsertCommand.Parameters.Add("@CodigoProducto", SqlDbType.Int, 0, "CodigoProducto");
        //adapter.InsertCommand.Parameters.Add("@IDPersonalResponsable", SqlDbType.Int, 0, "IDPersonalResponsable");
        //adapter.InsertCommand.Parameters.Add("@Mensaje", SqlDbType.NVarChar, 500, "Mensaje");
        //adapter.InsertCommand.Parameters.Add("@FechaRegistro", SqlDbType.DateTime, 0, "FechaRegistro");
        //adapter.InsertCommand.Parameters.Add("@Visibilidad", SqlDbType.Int, 0, "Visibilidad");

        public DataSet ObtenerSeguimientoPorProductos(int id)
        {
            // Creamos el DataSet
            DataSet ds = new DataSet();

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
            WHERE s.CodigoProducto = @CodigoProducto";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CodigoProducto", id);

                    
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        
                        da.Fill(ds, "Seguimiento");
                    }
                }
            }

            
            return ds;
        }
    }
}
