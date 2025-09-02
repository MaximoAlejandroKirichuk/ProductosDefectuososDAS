using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP.Interfaces
{
    internal interface IMapeableUno<T>
    {
        T Mapear(DataRow row);

    }
}
