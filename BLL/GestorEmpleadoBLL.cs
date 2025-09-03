using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GestorEmpleadoBLL : IABM<Empleado>
    {
        private EmpleadosMPP mppEmpleado = new EmpleadosMPP();
        public bool Agregar(Empleado objeto)
        {
            return mppEmpleado.Agregar(objeto);
        }

        public bool Borrar(int id)
        {
            return mppEmpleado.Borrar(id);
        }

        public bool Modificar(Empleado objeto)
        {
            return mppEmpleado.Modificar(objeto);
        }
        public List<Empleado> ObtenerTodos()
        {
            return mppEmpleado.ObtenerTodos();
        }
    }
}
