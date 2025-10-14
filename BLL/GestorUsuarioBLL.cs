using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GestorUsuarioBLL
    {
        private UsuarioMPP usuarioMPP = new UsuarioMPP();
        public bool IniciarSesion(string email, string contrasena)
        {
            Usuario usuario = BuscarUsuarioPorMail(email);
            if (usuario == null) throw new Exception("Usuario inexistente");

            var hashContrasena = HashContrasena(contrasena);
            if (usuario.Contrasenia == hashContrasena)
            {
                SesionActiva.Instancia.IniciarSesion(usuario);
                return true;
            }
            return false;
        }
        public string HashContrasena(string contrasena)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(contrasena);
                byte[] hash = sha256.ComputeHash(bytes);
                StringBuilder result = new StringBuilder();
                foreach (byte b in hash)
                {
                    result.Append(b.ToString("x2")); // formato hexadecimal
                }
                return result.ToString();
            }
        }

        public Usuario BuscarUsuarioPorMail(string email)
        {
            return usuarioMPP.BuscarUsuarioPorMail(email);
        }

    }
}
