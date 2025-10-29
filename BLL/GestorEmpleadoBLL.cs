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
            //  INICIO DE VALIDACIONES BLL 

            if (objeto == null)
            {
                throw new Exception("Error al intentar agregar: El empleado es nulo.");
            }

            //  VALIDACIÓN DE GMAIL 
            string patronGmail = @"^[\w-\.]+@gmail\.com$";

            if (string.IsNullOrWhiteSpace(objeto.Email) || !Regex.IsMatch(objeto.Email.Trim(), patronGmail))
            {
                // Si NO es un email de @gmail.com válido, lanzamos la excepción
                throw new Exception("El email del empleado debe ser una cuenta de @gmail.com válida.");
            }

            //  Validación de Contraseña
            
            if (string.IsNullOrWhiteSpace(objeto.Contrasenia))
            {
                throw new Exception("La contraseña es obligatoria.");
            }

            // Si todas las validaciones pasan, se llama al MPP
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
 