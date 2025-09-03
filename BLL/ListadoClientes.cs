using BE;
using BE.actores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    internal class ListadoClientes
    {
        private static ListadoClientes instancia = null;
        public static ListadoClientes Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new ListadoClientes();
                return instancia;
            }
        }

        public List<Cliente> Clientes { get; set; }

        private ListadoClientes()
        {
            Clientes = new List<Cliente>();
        }
    }
}
