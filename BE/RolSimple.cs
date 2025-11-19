using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class RolSimple : RolComponent
    {
        private List<ModuloSistema> _modulos = new List<ModuloSistema>();

        public RolSimple(string nombre) : base(nombre) { }

        public void AgregarModulo(ModuloSistema  modulo)
        {
            _modulos.Add(modulo);
        }

        public override List<ModuloSistema> ObtenerModulos()
        {
            return _modulos;
        }

        public override void MostrarEstructura(int nivel = 0)
        {
            Console.WriteLine(new string('-', nivel) + Nombre);
        }
    }
}
