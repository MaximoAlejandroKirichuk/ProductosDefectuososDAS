using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    //Los empleados implementarán esta interfaz para recibir notificaciones.
    public interface IObservadorProducto
    {
        //me devuelve el mensaje de lo que se hizo
        string Actualizar(Producto producto, string mensaje);
    }

}
