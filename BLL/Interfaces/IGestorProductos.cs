
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
namespace BBL
{
    public interface IGestorProductos
    {
        void AgregarProducto(Producto nuevoProducto);
        void BorrarProducto(Producto borrarProducto);
        void ModificarProducto(Producto productoModificado);
    }
}
