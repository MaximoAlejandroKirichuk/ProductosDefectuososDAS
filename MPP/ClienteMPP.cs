using BE;
using BE.actores;
using DAL;
using DAL.Interfaces; // Asegúrate que ClienteDAL esté aquí
using MPP.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP
{
    public class ClienteMPP : IMapeableTodos<Cliente>, IABM<Cliente>
    {
        private ClienteDAL dalCliente = new ClienteDAL();

       
        public bool ExisteCliente(string NroDocumento) // Antes era 'int'
        {
            return dalCliente.ExisteCliente(NroDocumento); // Pasa el 'string'
        }
        // 

        public bool Agregar(Cliente objeto)
        {
            return dalCliente.Insertar(objeto);
        }

        public bool Borrar(int id)
        {
            return dalCliente.Delete(id);
        }

        public bool Modificar(Cliente objeto)
        {
            return dalCliente.Update(objeto);
        }

        public List<Cliente> ObtenerTodos()
        {
            DataTable dt = dalCliente.ObtenerTodos();
            return MapearTodos(dt);
        }

        public List<Cliente> MapearTodos(DataTable dt)
        {
            List<Cliente> clientes = new List<Cliente>();

            foreach (DataRow row in dt.Rows)
            {
                TipoDocumentoCliente tipoDoc;
                Enum.TryParse(row["TipoDocumento"].ToString(), out tipoDoc);

                var cliente = new Cliente
                {
                    IdCliente = Convert.ToInt32(row["IdCliente"]),
                    NombreCompleto = row["NombreCompleto"].ToString(),
                    Email = row["Email"].ToString(),
                    TipoDocumento = tipoDoc,
                    Direccion = row["Direccion"].ToString(),
                    DeudaTotal = Convert.ToDecimal(row["DeudaTotal"]),

                    // --- CAMBIO AQUÍ ---
                    // Lee el NroDocumento de la BD como un 'string'
                    NroDocumento = row["NroDocumento"].ToString() // Antes era Convert.ToInt32
                    // --- FIN CAMBIO ---
                };

                clientes.Add(cliente);
            }

            return clientes;
        }

        public int ObtenerIdClientePorDocumento(string nroDocumento)
        {
            // Este método ya estaba bien (aceptaba string),
            // pero es una buena práctica definir el tipo de parámetro.
            using (SqlConnection con = new SqlConnection(StringConnection.stringConnection))
            {
                string query = "SELECT IdCliente FROM Cliente WHERE NroDocumento = @NroDocumento";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // --- MEJORA DE CÓDIGO ---
                    // Definir el tipo y tamaño es mejor que AddWithValue para strings
                    SqlParameter param = new SqlParameter("@NroDocumento", SqlDbType.VarChar, 11);
                    param.Value = nroDocumento;
                    cmd.Parameters.Add(param);
                    // --- FIN MEJORA ---

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