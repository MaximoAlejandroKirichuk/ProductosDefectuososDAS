using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP
{
    public class ProductoMPP : IABM<Producto>
    {
        private ProductoDAL dalProducto = new ProductoDAL();
        public bool Agregar(Producto objeto)
        {
            return dalProducto.Insertar(objeto);
        }

        public bool Borrar(int id)
        {
            return dalProducto.Delete(id);
        }

        public bool Modificar(Producto objeto)
        {
            return dalProducto.Update(objeto);
        }
    }
}
