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
        
    }
}
