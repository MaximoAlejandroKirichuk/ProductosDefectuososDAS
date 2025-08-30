using BE.actores;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALUsuario
    {
        string stringConnection = StringConnection.connectionString;
        public DataRow BuscarUsuarioPorMail(string email)
        {
            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                string query = "SELECT TOP 1 * FROM Empleado WHERE Email = @Email";
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, con))
                {
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Email", email);
                    DataTable dt = new DataTable();
                    sqlDataAdapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                        return dt.Rows[0];
                    else 
                        return null;
                }
            }
        }
        //public bool InsertarClientes(Cliente c)
        //{
        //    using(SqlConnection sqlConnection = new SqlConnection(stringConnection))
        //    {
        //        string query = "insert into Cliente (NombreCompleto, Email, Contrasena,TipoDocumento, Direccion, DeudaTotal, FechaNacimiento, NroDocumento) Values(@nombreCompleto,@email,@contrasenia,@tipoDocumento,@direccion,@deudaTotal,@FechaNacimiento,@NroDocumento)";
        //        using(SqlCommand cmd = new SqlCommand(query, sqlConnection))
        //        {
        //            sqlConnection.Open();
        //            cmd.Parameters.AddWithValue("@nombreCompleto", c.NombreCompleto);
        //            cmd.Parameters.AddWithValue("@email", c.Email);
        //            cmd.Parameters.AddWithValue("@contrasenia", c.Contrasenia);
        //            cmd.Parameters.AddWithValue("@tipoDocumento", c.TipoDocumento.ToString());
        //            cmd.Parameters.AddWithValue("@direccion", c.Direccion);
        //            cmd.Parameters.AddWithValue("@deudaTotal", c.DeudaTotal);
        //            cmd.Parameters.AddWithValue("@FechaNacimiento", c.FechaNacimiento.ToShortDateString());
        //            cmd.Parameters.AddWithValue("@NroDocumento", c.NroDocumento);
        //            return cmd.ExecuteNonQuery() > 0;
        //        }
        //    }
        //}
    }
}
