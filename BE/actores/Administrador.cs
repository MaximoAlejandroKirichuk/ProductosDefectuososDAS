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
        
        public Administrador(string nombreCompleto, string usuarioNombreCuenta, string mail, string password, string rol)
        {
            this.Username = usuarioNombreCuenta;
            this.Fullname = nombreCompleto;
            this.Mail = mail;
            this.Password = password;
            this.Rol = rol;
        }
        

    }
}
