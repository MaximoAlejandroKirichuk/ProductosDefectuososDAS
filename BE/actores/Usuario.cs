
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BE
{
    public abstract class Usuario
    {
        public string NombreCompleto { get; set; }
        public string NombreUsuario { get; set; }
        public string Email { get; set; }
        public string Contrasenia { get; set; }
        public RolesUsuarios Rol { get; set; }


        protected Usuario(string nombreCompleto,string nomUsuario, string email, string contrasenia, RolesUsuarios rol )
        {
            NombreCompleto = nombreCompleto;
            NombreUsuario = nomUsuario;
            Email = email;
            Contrasenia = contrasenia;
            Rol = rol;
        }



        //sobreescribir el metodo para guardarlo correctamente
        public override string ToString()
        {
            return $"{NombreCompleto}";
        }
        public string DameUsuarioString()
        {
            //NombreCompleto; Email; Password; Rol; NombreCuenta
            return $"{NombreCompleto};{Email};{Contrasenia};{Rol};{NombreUsuario}";
        }
        
    }
}
