using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BE
{
    internal class Administrador : Usuario
    {
        public Administrador(string nombreCompleto, string nomUsuario, string email, string contrasenia, RolesUsuarios rol) : base(nombreCompleto, nomUsuario, email, contrasenia, rol)
        {
        }
    }
}
