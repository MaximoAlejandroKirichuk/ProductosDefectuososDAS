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
        string stringConnection = StringConnection.stringConnection;
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
        
        public bool CambiarContrasenia(string contrasenia, int idEmpleado)
        {
            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                string query = @"UPDATE Empleado 
                            SET Contrasena = @Contrasena
                            WHERE IdEmpleado = @IdEmpleado";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
                    cmd.Parameters.AddWithValue("@Contrasena", contrasenia);

                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        //TODO AUTOINCREMENTAR SI SE EQUIVOCA EL CONTADOR
    }
}
