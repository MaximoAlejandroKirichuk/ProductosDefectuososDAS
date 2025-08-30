using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.actores
{
    public class Cliente : Usuario 
    {
        public Cliente(string nombreCompleto, string nomUsuario, string email, string contrasenia, RolesUsuarios rol,TipoDocumentoCliente documento, int nroDocumento,string direccion,decimal deudaTotal) 
            : base(nombreCompleto, nomUsuario, email, contrasenia, rol)
        {

        }
        public TipoDocumentoCliente TipoDocumento { get; set; }
        public int NroDocumento { get; set; }
        public string Direccion { get; set; }
        public List<Producto> ProductosComprados { get; set; }
        public decimal DeudaTotal { get; set; }
    }
}
