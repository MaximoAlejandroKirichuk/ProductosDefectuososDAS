using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public interface IABM<T>
    {
        bool Agregar(T objeto);
        bool Borrar(int id);
        bool Modificar(T objeto);
    }
}
