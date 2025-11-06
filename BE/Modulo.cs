using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Modulo
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public Modulo(string nombre, string descripcion = "")
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }
    }
}
