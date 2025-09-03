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
                RolesUsuarios rol;
                Enum.TryParse(row["Rol"].ToString(), out rol);
                var cliente = new Empleado
                {
                    IdUsuario = Convert.ToInt32(row["IdEmpleado"]),
                    Email = row["Email"].ToString(),
                    Contrasenia = row["Contrasena"].ToString(),
                    NombreCompleto = row["NombreCompleto"].ToString(),
                    Rol = rol,
                };

                empleados.Add(cliente);
            }

            return empleados;
        }

        public bool Modificar(Empleado objeto)
        {
            return empleadoDAL.Update(objeto);
        }

        
    }
}
