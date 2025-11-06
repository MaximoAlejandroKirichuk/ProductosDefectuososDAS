using BE;
using DAL;
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
        private DALUsuario daLUsuario = new DALUsuario();
        private UsuarioMPP usuarioMPP = new UsuarioMPP();
        private readonly LogsBLL logger = new LogsBLL();
        private readonly BLLPermiso permisoBLL = new BLLPermiso();
        public bool IniciarSesion(string email, string contrasena)
        {
            try
            {
                // Validación de parámetros
                if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(contrasena))
                    throw new ArgumentException("El email y la contraseña son obligatorios.");

                // Buscar usuario por email
                Usuario usuario = BuscarUsuarioPorMail(email);
                if (usuario == null)
                    throw new InvalidOperationException("Usuario inexistente.");

                var hashContrasena = HashContrasena(contrasena);

                if (usuario.Contrasenia == hashContrasena)
                {
                    SesionActiva.Instancia.IniciarSesion(usuario);
                    
                    // Cargar jerarquía de permisos (Composite)
                    usuario.Permisos = permisoBLL.ObtenerPermisosPorRol(usuario.Rol);

                    // Log de login exitoso
                    logger.RegistrarEvento(usuario.IdUsuario, NivelLog.Informacion, ModuloSistema.Login,
                        $"Inicio de sesión exitoso para usuario '{usuario.Email}'", Criticidad.Baja);

                    return true;
                }

                // Log de intento de contraseña incorrecta
                logger.RegistrarEvento(usuario.IdUsuario, NivelLog.Error, ModuloSistema.Login,
                    $"Intento de inicio de sesión fallido - Contraseña incorrecta", Criticidad.Media);
                // (aca incrementar los intentos fallidos)
                    return false;
                
            }
            catch (Exception ex)
            {
                

                throw new Exception(ex.Message); ;
            }
        }

        public bool CambiarContrasenia(Usuario usuario, string nuevaContrasenia)
        {
            var nuevaContraseniaHasheada = HashContrasena(nuevaContrasenia);

            if (usuario.Contrasenia == nuevaContraseniaHasheada)
            {
                logger.RegistrarEvento(
                    SesionActiva.Instancia.UsuarioActivo.IdUsuario,
                    NivelLog.Error,
                    ModuloSistema.Login,
                    "Error en el cambio de contraseña - La nueva contraseña es igual a la anterior",
                    Criticidad.Media
                );
                throw new InvalidOperationException("La nueva contraseña no puede ser igual a la anterior.");
            }

            var exito = daLUsuario.CambiarContrasenia(nuevaContraseniaHasheada, usuario.IdUsuario);

            logger.RegistrarEvento(
                SesionActiva.Instancia.UsuarioActivo.IdUsuario,
                exito ? NivelLog.Informacion : NivelLog.Error,
                ModuloSistema.Login,
                exito ? "Cambio de contraseña exitoso" : "Error en el cambio de contraseña",
                exito ? Criticidad.Baja : Criticidad.Alta
            );

            return exito;
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
