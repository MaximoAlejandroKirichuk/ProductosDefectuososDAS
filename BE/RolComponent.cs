using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class RolComponent
    {
        public string Nombre { get; set; }

        public RolComponent(string nombre)
        {
            Nombre = nombre;
        }

        public abstract List<ModuloSistema> ObtenerModulos();
        public abstract void MostrarEstructura(int nivel = 0);
    }
}
