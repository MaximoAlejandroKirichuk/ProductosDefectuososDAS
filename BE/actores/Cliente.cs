using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.actores
{
    public class Cliente  
    {
        public int IdCliente { get; set; }
        public TipoDocumentoCliente TipoDocumento { get; set; }
        public int NroDocumento { get; set; }//cuil o cuit nro
        public string Direccion { get; set; }
        public List<Producto> ProductosComprados { get; set; }
        public decimal DeudaTotal { get; set; }
    }
}
