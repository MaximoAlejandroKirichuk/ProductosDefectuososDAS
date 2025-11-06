using BE;
using DAL.Interfaces;
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
    public class EmpleadoDAL : IDAL<Empleado>
    {
        private string stringConnection = StringConnection.stringConnection;
        public bool Delete(int id)
        {
            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                //TODO: VERIFICAR QUERY
                string query = "DELETE FROM Empleado WHERE IdEmpleado = @IdEmpleado";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("IdEmpleado", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Insertar(Empleado objeto)
        {
            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                string query = @"INSERT INTO Empleado (Email, Contrasena, NombreCompleto, Rol) 
                                VALUES (@email, @contrasena, @nombre, @rol);";
                using(SqlCommand cmd = new SqlCommand(query,con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@email", objeto.Email);
                    cmd.Parameters.AddWithValue("@contrasena", objeto.Contrasenia);
                    cmd.Parameters.AddWithValue("@nombre", objeto.NombreCompleto);
                    cmd.Parameters.AddWithValue("@rol", objeto.Rol.ToString());
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public DataTable ObtenerTodos()
        {
            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                string query = "SELECT * FROM Empleado";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool Update(Empleado objeto)
        {
            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                string query = @"UPDATE Empleado 
                            SET NombreCompleto = @NombreCompleto,
                                Contrasena = @Contrasena
                            WHERE IdEmpleado = @IdEmpleado";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@IdEmpleado", objeto.IdUsuario);
                    cmd.Parameters.AddWithValue("@NombreCompleto", objeto.NombreCompleto);
                    cmd.Parameters.AddWithValue("@Contrasena", objeto.Contrasenia);

                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
