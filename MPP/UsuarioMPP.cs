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


            switch (rol)
            {
                case RolesUsuarios.Admin:
                    return new Administrador
                    {
                        IdUsuario = Convert.ToInt32(row["IdEmpleado"]),
                        NombreCompleto = row["NombreCompleto"].ToString(),
                        Email = row["Email"].ToString(),
                        Contrasenia = row["Contrasena"].ToString(),
                        Rol = rol
                    };
                case RolesUsuarios.Empleado:
                    return new Empleado
                    {
                        IdUsuario = Convert.ToInt32(row["IdEmpleado"]),
                        NombreCompleto = row["NombreCompleto"].ToString(),
                        Email = row["Email"].ToString(),
                        Contrasenia = row["Contrasena"].ToString(),
                        Rol = rol
                    };
                default: return null;
            }

        }
    }
}
