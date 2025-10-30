
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public interface ISujeto
    {
        void AgregarObservador(IObservador observador);
        void QuitarObservador(IObservador observador);
        void NotificarObservadores(string mensaje);
    }

}
