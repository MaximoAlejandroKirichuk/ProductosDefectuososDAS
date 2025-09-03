using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP.Interfaces
{
    public interface IMapeableTodos<T>
    {
        List<T> MapearTodos(DataTable row);
    }
}
