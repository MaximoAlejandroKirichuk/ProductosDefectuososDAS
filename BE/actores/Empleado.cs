using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BE
{
    public class Empleado : Usuario
    {

        public Empleado(string nombreCompleto, string email, string contrasenia, RolesUsuarios rol) : base(nombreCompleto, email, contrasenia, rol)
        {
        }
        public Empleado() { }
    }
}
