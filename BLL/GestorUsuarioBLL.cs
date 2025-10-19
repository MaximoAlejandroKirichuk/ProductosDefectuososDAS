﻿using BE;
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
        public bool IniciarSesion(string email, string contrasena)
        {
            try
            {
                Usuario usuario = BuscarUsuarioPorMail(email);

                if (usuario == null)
                {
                    // Log de intento de login con usuario inexistente
                    logger.RegistrarEvento(null, NivelLog.Alerta, ModuloSistema.Login,
                        $"Intento de inicio de sesión fallido - Usuario '{email}' inexistente");
                    throw new Exception("Usuario inexistente");
                }

                var hashContrasena = HashContrasena(contrasena);

                if (usuario.Contrasenia == hashContrasena)
                {
                    SesionActiva.Instancia.IniciarSesion(usuario);

                    // Log de login exitoso
                    logger.RegistrarEvento(usuario.IdUsuario, NivelLog.Informacion, ModuloSistema.Login,
                        $"Inicio de sesión exitoso para usuario '{usuario.Email}'", Criticidad.Baja);

                    return true;
                }
                else
                {
                    // Log de intento de contraseña incorrecta
                    logger.RegistrarEvento(usuario.IdUsuario, NivelLog.Error, ModuloSistema.Login,
                        $"Intento de inicio de sesión fallido - Contraseña incorrecta", Criticidad.Media);

                    // (acá podrías incrementar los intentos fallidos, etc.)
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Log de error interno del proceso de login
                logger.RegistrarEvento(null, NivelLog.Error, ModuloSistema.Login,
                    $"Error al iniciar sesión: {ex.Message}", Criticidad.Alta);

                throw;
            }
        }

        public bool CambiarContrasenia(Usuario usuario, string nuevaContrasenia)
        {
            nuevaContrasenia = HashContrasena(nuevaContrasenia);
            if (usuario.Contrasenia == nuevaContrasenia) throw new Exception("La contraseña es la misma");

            //TIENE QUE PASAR POR LA MPP????????
            return daLUsuario.CambiarContrasenia(nuevaContrasenia, usuario.IdUsuario);
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
