using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class RolBLL
    {
        public RolComponent ObtenerEstructuraRoles()
        {
            // Roles simples
            var vendedor = new RolSimple("Vendedor");
            vendedor.AgregarModulo(ModuloSistema.Productos);
            vendedor.AgregarModulo(ModuloSistema.Clientes);
            vendedor.AgregarModulo(ModuloSistema.Login);

            var empleado = new RolSimple("Empleado de Reparación");
            empleado.AgregarModulo(ModuloSistema.Seguimientos);
            empleado.AgregarModulo(ModuloSistema.Login);

            var jefe = new RolSimple("Jefe de Reparación");
            jefe.AgregarModulo(ModuloSistema.Seguimientos);
            jefe.AgregarModulo(ModuloSistema.Reportes);
            jefe.AgregarModulo(ModuloSistema.Login);

            var administrador = new RolCompuesto("Administrador General");
            administrador.Agregar(vendedor);
            administrador.Agregar(empleado);
            administrador.Agregar(jefe);

            return administrador;
        }

        public List<ModuloSistema> ObtenerModulosPorRol(RolComponent rol)
        {
            return rol.ObtenerModulos();
        }
    }
}
