using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class LogEstadistica
    {
        public Criticidad Criticidad { get; set; } // Ej: "Alta", "Baja"
        public int Cantidad { get; set; } //cantidad de logs por criticidad
    }
}
