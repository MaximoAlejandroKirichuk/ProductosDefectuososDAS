using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BE
{
    public class Administrador : Usuario
    {
        public Administrador(string nombreCompleto, string email, string contrasenia, RolesUsuarios rol) : base(nombreCompleto, email, contrasenia, rol)
        {
        }
        public Administrador() { }
    }
}
