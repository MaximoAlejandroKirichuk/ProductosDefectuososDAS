using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    internal interface IDAL<T>
    {
        bool Insertar(T objeto);
        bool Delete(int id);
        bool Update(T objeto);
        DataTable ObtenerTodos();
    }
}
