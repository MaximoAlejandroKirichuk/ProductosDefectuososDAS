using BE.actores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Ticket
    {
        public int IdCompra { get; set; }
        public DateTime FechaRealizacion { get; set; }
        public Cliente Cliente { get; set; }
        public Producto Producto { get; set; }
        public TipoMedioPago MedioPago { get; set; }
        public decimal SaldoAbonado { get; set; }
        public decimal SaldoPendiente { get; set; }

    }
}
 