using BE;
using BE.actores;

using MPP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GestorClienteBLL : IABM<Cliente>
    {
        private ClienteMPP clienteMPP = new ClienteMPP();
        public bool Agregar(Cliente objeto)
        {
            //TODO VALIDACIONES ACA
            return clienteMPP.Agregar(objeto);
        }

        public bool Borrar(int id)
        {
            return clienteMPP.Borrar(id);
        }

        public bool Modificar(Cliente objeto)
        {
            return clienteMPP.Modificar(objeto);
        }
        public DataTable ObtenerSeguimientoTicket(int codigo)
        {
            throw new NotImplementedException();
        }
        public List<Cliente> ObtenerClientes()
        {
            return clienteMPP.ObtenerTodos();
        }

        public int ObtenerIdClientePorDocumento(string nroDocumento)
        {
            return clienteMPP.ObtenerIdClientePorDocumento(nroDocumento);
        }
    }
    
}
