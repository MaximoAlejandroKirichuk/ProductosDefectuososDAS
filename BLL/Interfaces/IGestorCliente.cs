using BE.actores;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IGestorCliente : IAbm<Cliente>
    {
        DataTable ObtenerSeguimientoTicket(int codigo);
       
    }
}
