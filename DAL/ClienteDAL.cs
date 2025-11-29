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
    public class ClienteDAL 
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
        public bool ExisteCliente(string NroDocumento)
        {
            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                string query = "SELECT COUNT(*) FROM Cliente WHERE NroDocumento = @NroDocumento";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    {
                        // Ahora el parámetro se crea como VarChar EN STRING 
                        SqlParameter param = new SqlParameter("@NroDocumento", SqlDbType.VarChar, 11);
                        param.Value = NroDocumento;
                        cmd.Parameters.Add(param);

                        con.Open();
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
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

        public int ObtenerIdClientePorDoucmento(string nroDocumento)
        {
            using (SqlConnection con = new SqlConnection(StringConnection.stringConnection))
            {
                string query = "SELECT IdCliente FROM Cliente WHERE NroDocumento = @NroDocumento";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    
                    SqlParameter param = new SqlParameter("@NroDocumento", SqlDbType.VarChar, 13);
                    param.Value = nroDocumento;
                    cmd.Parameters.Add(param);
                    con.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int idCliente))
                    {
                        return idCliente;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
        }
    }
}
