using BE;
using BE.actores;
using DAL;
using MPP.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP
{
    public class EmpleadosMPP : IABM<Empleado>, IMapeableTodos<Empleado>
    {
        private EmpleadoDAL empleadoDAL = new EmpleadoDAL();
        public bool Agregar(Empleado objeto)
        {
            return empleadoDAL.Insertar(objeto);
        }

        public bool Borrar(int id)
        {
            return empleadoDAL.Delete(id);
        }
        public List<Empleado> ObtenerTodos()
        {
            DataTable dt = empleadoDAL.ObtenerTodos();
            return MapearTodos(dt);
        }
        public List<Empleado> MapearTodos(DataTable dt)
        {
            List<Empleado> empleados = new List<Empleado>();

            foreach (DataRow row in dt.Rows)
            {
                // Parse del rol solo una vez
                var rol = (RolesUsuarios)Enum.Parse(typeof(RolesUsuarios), row["Rol"].ToString());

                // Saltar admins
                if (rol == RolesUsuarios.Admin) continue;

                var empleado = new Empleado
                {
                    IdUsuario = Convert.ToInt32(row["IdEmpleado"]),

                    NombreCompleto = row["NombreCompleto"].ToString(),
                    Email = row["Email"].ToString(),
                    Contrasenia = row["Contrasena"].ToString(),

                    Rol = rol,

                    Bloqueado = row["Bloqueado"] != DBNull.Value && Convert.ToBoolean(row["Bloqueado"]),
                    IntentosFallidos = row["IntentosFallidos"] != DBNull.Value ? Convert.ToInt32(row["IntentosFallidos"]) : 0,
                    UltimoIntento = row["UltimoIntento"] != DBNull.Value ? Convert.ToDateTime(row["UltimoIntento"]) : (DateTime?)null
                };

                empleados.Add(empleado);
            }

            return empleados;
        }


        public bool Modificar(Empleado objeto)
        {
            return empleadoDAL.Update(objeto);
        }

        
    }
}
