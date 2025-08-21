using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE

{
    public class ListadoEmpleados
    {
        private static ListadoEmpleados instancia = null;
        public static ListadoEmpleados Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new ListadoEmpleados();
                return instancia;
            }
        }

        public List<Usuario> Empleados { get; set; }

        private ListadoEmpleados()
        {
            Empleados = new List<Usuario>(); 
        }

    }
}
