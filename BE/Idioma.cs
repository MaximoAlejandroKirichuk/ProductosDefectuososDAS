using BE.ObserverIdioma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Idioma : IIdioma
    {
        public string Nombre { get; set; }
        public string Id { get; set; }

        // TRUCO: Sobrescribir ToString() hace que el ComboBox muestre el Nombre automáticamente
        public override string ToString()
        {
            return Nombre;
        }
    }
}