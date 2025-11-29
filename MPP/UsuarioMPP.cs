using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using MPP.Interfaces;
namespace MPP
{
    public class UsuarioMPP : IMapeableUno<Usuario>
    {
        private DALUsuario dalUsuario = new DALUsuario();

        public Usuario BuscarUsuarioPorMail(string email)
        {
            DataRow row = dalUsuario.BuscarUsuarioPorMail(email);

            if (row == null) return null;
            return Mapear(row);

        }

        public Usuario Mapear(DataRow row)
        {
            RolesUsuarios rol;
            Enum.TryParse(row["Rol"].ToString(), out rol);

            // Mapeo de campos comunes a todos los usuarios
            int idUsuario = Convert.ToInt32(row["IdEmpleado"]);
            string nombreCompleto = row["NombreCompleto"].ToString();
            string email = row["Email"].ToString();
            string contrasena = row["Contrasena"].ToString();

            int intentosFallidos = row.Table.Columns.Contains("IntentosFallidos") && row["IntentosFallidos"] != DBNull.Value
                ? Convert.ToInt32(row["IntentosFallidos"])
                : 0;

            bool bloqueado = row.Table.Columns.Contains("Bloqueado") && row["Bloqueado"] != DBNull.Value
                ? Convert.ToBoolean(row["Bloqueado"])
                : false;

            DateTime? ultimoIntento = null;
            if (row.Table.Columns.Contains("UltimoIntento") && row["UltimoIntento"] != DBNull.Value)
            {
                ultimoIntento = Convert.ToDateTime(row["UltimoIntento"]);
            }

            switch (rol)
            {
                case RolesUsuarios.Admin:
                    return new Administrador
                    {
                        IdUsuario = idUsuario,
                        NombreCompleto = nombreCompleto,
                        Email = email,
                        Contrasenia = contrasena,
                        Rol = rol,
                        IntentosFallidos = intentosFallidos,
                        Bloqueado = bloqueado,
                        UltimoIntento = ultimoIntento
                    };

                case RolesUsuarios.EmpleadoReparacion:
                    return new Empleado
                    {
                        IdUsuario = idUsuario,
                        NombreCompleto = nombreCompleto,
                        Email = email,
                        Contrasenia = contrasena,
                        Rol = rol,
                        IntentosFallidos = intentosFallidos,
                        Bloqueado = bloqueado,
                        UltimoIntento = ultimoIntento
                    };

                case RolesUsuarios.JefeReparacion:
                    return new Empleado
                    {
                        IdUsuario = idUsuario,
                        NombreCompleto = nombreCompleto,
                        Email = email,
                        Contrasenia = contrasena,
                        Rol = rol,
                        IntentosFallidos = intentosFallidos,
                        Bloqueado = bloqueado,
                        UltimoIntento = ultimoIntento
                    };

                case RolesUsuarios.Vendedor:
                    return new Empleado
                    {
                        IdUsuario = idUsuario,
                        NombreCompleto = nombreCompleto,
                        Email = email,
                        Contrasenia = contrasena,
                        Rol = rol,
                        IntentosFallidos = intentosFallidos,
                        Bloqueado = bloqueado,
                        UltimoIntento = ultimoIntento
                    };

                default:
                    return null;
            }
        }
        public bool ActualizarIntentos(Usuario u)
        {
            return dalUsuario.ActualizarIntentosFallidos(u.IdUsuario, u.IntentosFallidos);
        }

        public bool Bloquear(Usuario u)
        {
            return dalUsuario.BloquearUsuario(u.IdUsuario);
        }

        public bool ReiniciarIntentos(Usuario u)
        {
            return dalUsuario.ReiniciarIntentos(u.IdUsuario);
        }

        public bool Desbloquear(Usuario usuario, string nuevaContrasena)
        {
            return dalUsuario.DesbloquearUsuario(usuario.IdUsuario, nuevaContrasena);
        }

    }
}
