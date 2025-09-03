using BE.actores;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public class ClienteDAL : IDAL<Cliente>
    {
        string stringConnection = StringConnection.stringConnection;
        public bool Delete(int id)
        {
            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                //TODO: VERIFICAR QUERY
                string query = "DELETE FROM Cliente WHERE IdCliente = @IdCliente";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("IdCliente", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Insertar(Cliente objeto)
        {
            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                //TODO: VERIFICAR QUERY
                string query = @"INSERT INTO Cliente 
                (NombreCompleto, Email, TipoDocumento, Direccion, DeudaTotal, NroDocumento) 
                VALUES (@NombreCompleto, @Email, @TipoDocumento, @Direccion, @DeudaTotal, @NroDocumento)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@NombreCompleto", objeto.NombreCompleto);
                    cmd.Parameters.AddWithValue("@Email", objeto.Email);
                    cmd.Parameters.AddWithValue("@TipoDocumento", objeto.TipoDocumento.ToString());
                    cmd.Parameters.AddWithValue("@Direccion", objeto.Direccion);
                    cmd.Parameters.AddWithValue("@DeudaTotal", objeto.DeudaTotal);
                    cmd.Parameters.AddWithValue("@NroDocumento", objeto.NroDocumento);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public DataTable ObtenerTodos()
        {
            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                string query = "SELECT * FROM Cliente";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool Update(Cliente objeto)
        {
            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                string query = @"UPDATE Cliente 
                            SET NombreCompleto = @NombreCompleto,
                                Email = @Email,
                                TipoDocumento = @TipoDocumento,
                                Direccion = @Direccion,
                                DeudaTotal = @DeudaTotal,
                                NroDocumento = @NroDocumento
                            WHERE IdCliente = @IdCliente";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@IdCliente", objeto.IdCliente);
                    cmd.Parameters.AddWithValue("@NombreCompleto", objeto.NombreCompleto);
                    cmd.Parameters.AddWithValue("@Email", objeto.Email);
                    cmd.Parameters.AddWithValue("@TipoDocumento", objeto.TipoDocumento.ToString());
                    cmd.Parameters.AddWithValue("@Direccion", objeto.Direccion);
                    cmd.Parameters.AddWithValue("@DeudaTotal", objeto.DeudaTotal);
                    cmd.Parameters.AddWithValue("@NroDocumento", objeto.NroDocumento);

                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
