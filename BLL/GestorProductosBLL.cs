using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GestorProductosBLL : IABM<Producto>
    {
        private ProductoMPP productoMPP = new ProductoMPP();
        public bool Agregar(Producto objeto)
        {
            return productoMPP.Agregar(objeto);
        }

        public bool Borrar(int id)
        {
            return productoMPP.Borrar(id);
        }

        public bool Modificar(Producto objeto)
        {
            return productoMPP.Modificar(objeto);
        }
    }
}
