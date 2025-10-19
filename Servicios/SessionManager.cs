using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class SessionManager
    {
        private static SessionManager _instancia;

        public Usuario UsuarioActivo { get; private set; }

        private SessionManager() { }

        public static SessionManager Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new SessionManager();
                }
                return _instancia;
            }
        }
        //public bool CambiarIdioma(string idioma)
        //{
        //    return true;
        //}

        //public bool LogIn()
        //{
        //    return true;
        //}

        //public bool LogOut()
        //{
        //    return true;
        //}

        //public bool CambiarContrasenia()
        //{
              
        //}

    }
}
