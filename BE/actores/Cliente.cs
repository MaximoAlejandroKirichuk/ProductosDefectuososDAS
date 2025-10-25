using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.actores
{
    public class Cliente: Persona
    {
        public int IdCliente { get; set; }
        public TipoDocumentoCliente TipoDocumento { get; set; }
        public string NroDocumento { get; set; }//cuil o cuit nro
        public string Direccion { get; set; }
        public List<Producto> ProductosComprados { get; set; }
        public decimal DeudaTotal { get; set; }
        public string Email  { get; set; }

        public Cliente()
        {
            
        }
        public Cliente(string nombreCompleto, TipoDocumentoCliente tipo, string nroDocumento, string direc, decimal deuda, string email)
        {
            NombreCompleto = nombreCompleto;
            TipoDocumento = tipo;
            NroDocumento = nroDocumento;
            Direccion = direc;
            DeudaTotal = deuda;
            Email = email;
        }
    }
}
