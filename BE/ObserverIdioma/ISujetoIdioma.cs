using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.ObserverIdioma
{
    public interface ISujetoIdioma
    {
        void Suscribir(IObservadorIdioma observador);
        void Desuscribir(IObservadorIdioma observador);
        void Notificar();
    }
}
