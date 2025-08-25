
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
        
        private string fullname;

        public string Fullname
        {
            get { return fullname; }
            set { fullname = value; }
        }

        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private string mail;

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string rol;

        public string Rol
        {
            get { return rol; }
            set { rol = value; }
        }



        


        //sobreescribir el metodo para guardarlo correctamente
        public override string ToString()
        {
            return $"{Fullname}";
        }
        public string DameUsuarioString()
        {
            //NombreCompleto; Email; Password; Rol; NombreCuenta
            return $"{Fullname};{Mail};{Password};{Rol};{Username}";
        }
        
    }
}
