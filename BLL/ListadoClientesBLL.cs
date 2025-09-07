using BE;
using BE.actores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ListadoClientesBLL
    {
        private static ListadoClientesBLL instancia = null;
        public static ListadoClientesBLL Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new ListadoClientesBLL();
                return instancia;
            }
        }

        public List<Cliente> Clientes { get; set; }

        private ListadoClientesBLL()
        {
            Clientes = new List<Cliente>();
        }
    }
}
