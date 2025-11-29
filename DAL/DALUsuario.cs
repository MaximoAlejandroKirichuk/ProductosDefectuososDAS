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
        public bool ActualizarIntentosFallidos(int idEmpleado, int nuevosIntentos)
        {
            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                string query = @"UPDATE Empleado 
                         SET IntentosFallidos = @IntentosFallidos,
                             UltimoIntento = GETDATE()
                         WHERE IdEmpleado = @IdEmpleado";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@IntentosFallidos", nuevosIntentos);
                    cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);

                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool BloquearUsuario(int idEmpleado)
        {
            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                string query = @"UPDATE Empleado 
                         SET Bloqueado = 1
                         WHERE IdEmpleado = @IdEmpleado";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool ReiniciarIntentos(int idEmpleado)
        {
            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                string query = @"UPDATE Empleado 
                         SET IntentosFallidos = 0
                         WHERE IdEmpleado = @IdEmpleado";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public bool DesbloquearUsuario(int idEmpleado, string nuevaContrasenaHash)
        {
            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                string query = @"UPDATE Empleado 
                         SET Bloqueado = 0,
                             IntentosFallidos = 0,
                             UltimoIntento = NULL,
                             Contrasena = @Contrasena
                         WHERE IdEmpleado = @IdEmpleado";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
                    cmd.Parameters.AddWithValue("@Contrasena", nuevaContrasenaHash);

                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

    }
}
