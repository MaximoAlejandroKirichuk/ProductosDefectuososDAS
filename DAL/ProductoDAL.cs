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
    public class ProductoDAL : IDAL<Producto>
    {
        string stringConnection = StringConnection.stringConnection;
        public bool Delete(int id)
        {
            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                //TODO: VERIFICAR QUERY
                string query = "DELETE FROM Producto WHERE CodigoProducto = @CodigoProducto";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@CodigoProducto", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Insertar(Producto objeto)
        {
            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                //TODO QUERY
                string query = @"INSERT INTO Producto ;";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public DataTable ObtenerTodos()
        {
            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                string query = "SELECT * FROM Producto";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool Update(Producto objeto)
        {
            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                string query = @"UPDATE Producto 
                            SET NombreCompleto = @NombreCompleto
                            WHERE CodigoProducto = @CodigoProducto";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                   
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
