using BE;
using System.Collections.Generic;

namespace BLL.Interfaces
{
    public interface IAbm<T>
    {
        void Agregar(T objeto);
        void Borrar(int id);
        void Modificar(T objeto);
        T ObtenerPorId(int id);
        List<T> ObtenerTodos();
        
    }
}