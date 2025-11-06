using BE;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class BLLPermiso
    {
        // Devuelve un RolComponent (el árbol completo del rol)
        public RolComponent ObtenerPermisosPorRol(RolesUsuarios rol)
        {
            // El nodo raíz representa el rol principal
            RolCompuesto root = new RolCompuesto(rol.ToString());

            switch (rol)
            {
                case RolesUsuarios.Admin:
                    var admin = new RolSimple(RolesUsuarios.Admin.ToString());
                    admin.AgregarModulo(ModuloSistema.Login);
                    admin.AgregarModulo(ModuloSistema.Seguimientos);
                    admin.AgregarModulo(ModuloSistema.Clientes);
                    admin.AgregarModulo(ModuloSistema.Productos);
                    admin.AgregarModulo(ModuloSistema.Reportes);
                    admin.AgregarModulo(ModuloSistema.Empleados);

                    root.Agregar(admin);
                    break;

                case RolesUsuarios.JefeReparacion:
                    var jefe = new RolSimple(RolesUsuarios.JefeReparacion.ToString());
                    jefe.AgregarModulo(ModuloSistema.Login);
                    jefe.AgregarModulo(ModuloSistema.Seguimientos);
                    jefe.AgregarModulo(ModuloSistema.Productos);
                    jefe.AgregarModulo(ModuloSistema.Empleados);
                    root.Agregar(jefe);
                    break;

                case RolesUsuarios.EmpleadoReparacion:
                    var empleado = new RolSimple(RolesUsuarios.EmpleadoReparacion.ToString());
                    empleado.AgregarModulo(ModuloSistema.Login);
                    empleado.AgregarModulo(ModuloSistema.Seguimientos);
                    root.Agregar(empleado);
                    break;

                case RolesUsuarios.Vendedor:
                    var vendedor = new RolSimple(RolesUsuarios.Vendedor.ToString());
                    vendedor.AgregarModulo(ModuloSistema.Login);
                    vendedor.AgregarModulo(ModuloSistema.Clientes);
                    vendedor.AgregarModulo(ModuloSistema.Productos);
                    root.Agregar(vendedor);
                    break;
            }

            return root;
        }

        // Devuelve la lista simple de módulos que tiene un rol
        public List<ModuloSistema> ObtenerModulosDeRol(RolesUsuarios rol)
        {
            var permisos = ObtenerPermisosPorRol(rol);
            return permisos.ObtenerModulos();
        }

        // Verifica si el rol tiene acceso a un módulo específico
        public bool TienePermiso(RolesUsuarios rol, ModuloSistema modulo)
        {
            var modulos = ObtenerModulosDeRol(rol);
            return modulos.Contains(modulo);
        }
    }
}
