using BE;
using BE.actores;
using DAL.Interfaces;
using MPP.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP
{
    public class ClienteMPP : IMapeableTodos<Cliente>, IABM<Cliente>
    {
        private ClienteDAL dalCliente = new ClienteDAL();

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
                    NroDocumento = Convert.ToInt32(row["NroDocumento"]),
                };

                clientes.Add(cliente);
            }

            return clientes;
        }
    }

}
