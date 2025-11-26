
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public interface ISujeto
    {
        void AgregarObservador(IObservadorProducto observador);
        void QuitarObservador(IObservadorProducto observador);
        void NotificarObservadores(string mensaje);
    }

}
