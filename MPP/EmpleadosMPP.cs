using BE;
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
            throw new NotImplementedException();
        }

        public List<Empleado> MapearTodos(DataTable row)
        {
            throw new NotImplementedException();
        }

        public bool Modificar(Empleado objeto)
        {
            throw new NotImplementedException();
        }
    }
}
