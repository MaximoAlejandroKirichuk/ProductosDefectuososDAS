using BE; 
using MPP; 
using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions; 

namespace BLL
{
    public class GestorEmpleadoBLL : IABM<Empleado>
    {
        private EmpleadosMPP mppEmpleado = new EmpleadosMPP();
        public bool Agregar(Empleado objeto)
        {
            if (!Validador.ValidarGmail(objeto.Email)) throw new Exception("Ingrese correctamente el email"); 
            return mppEmpleado.Agregar(objeto);
        }

        public bool Borrar(int id)
        {
            return mppEmpleado.Borrar(id);
        }

        public bool Modificar(Empleado objeto)
        {
            // TODO: Deberías aplicar las mismas validaciones de 'Agregar' aquí
            // para asegurar que no se modifique a un email inválido.

            if (string.IsNullOrWhiteSpace(objeto.Email) || !Regex.IsMatch(objeto.Email.Trim(), @"^[\w-\.]+@gmail\.com$"))
            {
                throw new Exception("El email del empleado debe ser una cuenta de @gmail.com válida.");
            }

            return mppEmpleado.Modificar(objeto);
        }
        public List<Empleado> ObtenerTodos()
        {
            return mppEmpleado.ObtenerTodos();
        }
    }
}
 