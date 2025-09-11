using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Dimensiones
    {
        public decimal Ancho { get; set; }
        public decimal Alto { get; set; }
        public decimal Largo { get; set; }

        public Dimensiones(decimal ancho, decimal largo, decimal alto)
        {
            Ancho = ancho;
            Largo = largo;
            Alto = alto;
        }

        public Dimensiones()
        {
        }

        public override string ToString()
        {
            return $"Ancho:{Ancho}xLargo{Largo}xAlto{Alto}";
        }
    }
}
