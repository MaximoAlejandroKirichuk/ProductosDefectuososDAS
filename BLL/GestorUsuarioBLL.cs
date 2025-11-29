using BE;
using BLL.BLL;
using DAL;
using MPP;
using Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
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
            if (!Validador.ValidarGmail(email))
                throw new Exception("Ingrese un email valido");

            try
            {
                Usuario usuario = BuscarUsuarioPorMail(email) ?? throw new Exception("Usuario inexistente con ese email ");
                // SI ESTÁ BLOQUEADO
                if (usuario.Bloqueado)
                    throw new Exception("La cuenta está bloqueada. Contacte a un administrador.");
                
                var hashContrasena = Encriptador.HashContrasena(contrasena);
                if (usuario.Contrasenia != hashContrasena)
                {
                    usuario.IntentosFallidos++;
                    usuario.UltimoIntento = DateTime.Now;

                    // Actualizar intentos en DB
                    usuarioMPP.ActualizarIntentos(usuario);

                    logger.RegistrarEvento(usuario.IdUsuario, NivelLog.Error, ModuloSistema.Login,
                        $"Intento de inicio de sesión fallido - Contraseña incorrecta", Criticidad.Media);

                    // BLOQUEAR SI SUPERA 3 INTENTOS
                    if (usuario.IntentosFallidos >= 3)
                    {
                        usuario.Bloqueado = true;
                        usuarioMPP.Bloquear(usuario);

                        logger.RegistrarEvento(usuario.IdUsuario, NivelLog.Error, ModuloSistema.Login,
                            $"Usuario bloqueado por múltiples intentos fallidos", Criticidad.Alta);

                        throw new Exception("Cuenta bloqueada por seguridad.");
                    }

                    return false;
                }


                // LOGIN EXITOSO → RESET
                usuario.IntentosFallidos = 0;
                usuarioMPP.ReiniciarIntentos(usuario);
                SessionManager.Instancia.IniciarSesion(usuario);
                // Cargar jerarquía de permisos (Composite)
                usuario.Permisos = permisoBLL.ObtenerPermisosPorRol(usuario.Rol);

                logger.RegistrarEvento(
                    usuario.IdUsuario,
                    NivelLog.Informacion,
                    ModuloSistema.Login,
                    $"Inicio de sesión exitoso para usuario '{usuario.Email}'",
                    Criticidad.Baja
                );

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public bool CambiarContrasenia(Usuario usuario, string nuevaContrasenia)
        {
            var nuevaContraseniaHasheada = Encriptador.HashContrasena(nuevaContrasenia);

            if (usuario.Contrasenia == nuevaContraseniaHasheada)
            {
                logger.RegistrarEvento(
                    SessionManager.Instancia.UsuarioActivo.IdUsuario,
                    NivelLog.Error,
                    ModuloSistema.Login,
                    "Error en el cambio de contraseña - La nueva contraseña es igual a la anterior",
                    Criticidad.Media
                );
                throw new InvalidOperationException("La nueva contraseña no puede ser igual a la anterior.");
            }

            var exito = daLUsuario.CambiarContrasenia(nuevaContraseniaHasheada, usuario.IdUsuario);

            logger.RegistrarEvento(
                SessionManager.Instancia.UsuarioActivo.IdUsuario,
                exito ? NivelLog.Informacion : NivelLog.Error,
                ModuloSistema.Login,
                exito ? "Cambio de contraseña exitoso" : "Error en el cambio de contraseña",
                exito ? Criticidad.Baja : Criticidad.Alta
            );

            return exito;
        }
        public bool DesbloquearCuenta(string emailUsuario)
        {
            Usuario usuario = BuscarUsuarioPorMail(emailUsuario);

            if (usuario == null)
                throw new Exception("El usuario no existe.");

            if (!usuario.Bloqueado)
                throw new Exception("El usuario no está bloqueado.");

            string nuevaContrasena = Encriptador.HashContrasena("campichuelo1");
            bool ok = usuarioMPP.Desbloquear(usuario,nuevaContrasena);

            if (ok)
            {
                logger.RegistrarEvento(usuario.IdUsuario, NivelLog.Informacion,
                    ModuloSistema.Empleados,
                    "Cuenta desbloqueada y contraseña restaurada por un administrador");

                return true;
            }

            return false;
        }



        public Usuario BuscarUsuarioPorMail(string email)
        {
            return usuarioMPP.BuscarUsuarioPorMail(email);
        }

    }
}
