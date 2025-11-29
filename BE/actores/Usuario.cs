
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using BE.actores;

namespace BE
{
    public class Usuario : Persona
    {
        public int IdUsuario { get; set; }
        public string Email { get; set; }
        public string Contrasenia { get; set; }
        public RolesUsuarios Rol { get; set; }
        public bool Bloqueado { get; set; }
        public RolComponent Permisos { get; set; }
        public int IntentosFallidos { get; set; }
        public DateTime? UltimoIntento { get; set; }
        protected Usuario(string nombreCompleto, string email, string contrasenia, RolesUsuarios rol)
        {
            NombreCompleto = nombreCompleto;
            Email = email;
            Contrasenia = contrasenia;
            Rol = rol;
            Bloqueado = false;
        }

        public Usuario() { }

        //sobreescribir el metodo para guardarlo correctamente
        public override string ToString()
        {
            return $"{NombreCompleto}";
        }
        public string DameUsuarioString()
        {
            //NombreCompleto; Email; Password; Rol; NombreCuenta
            return $"{NombreCompleto};{Email};{Contrasenia};{Rol}";
        }
        
    }
}
