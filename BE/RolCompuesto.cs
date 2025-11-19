using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    // Compuesto (rol con subroles)
    public class RolCompuesto : RolComponent
    {
        private List<RolComponent> _subRoles = new List<RolComponent>();

        public RolCompuesto(string nombre) : base(nombre) { }

        public void Agregar(RolComponent rol)
        {
            _subRoles.Add(rol);
        }

        public override List<ModuloSistema> ObtenerModulos()
        {
            List<ModuloSistema> modulos = new List<ModuloSistema>();
            foreach (var rol in _subRoles)
                modulos.AddRange(rol.ObtenerModulos());
            return modulos;
        }

        public override void MostrarEstructura(int nivel = 0)
        {
            Console.WriteLine(new string('-', nivel) + Nombre);
            foreach (var rol in _subRoles)
                rol.MostrarEstructura(nivel + 2);
        }
    }
}
