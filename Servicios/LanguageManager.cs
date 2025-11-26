using BE.ObserverIdioma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class LanguageManager : ISujetoIdioma
    {
        private static LanguageManager _instance;
        
        private List<IObservadorIdioma> _observadores = new List<IObservadorIdioma>();

        public IIdioma IdiomaActual { get; private set; }

        private LanguageManager() { }

        public static LanguageManager Instance
        {
            get { return _instance ?? (_instance = new LanguageManager()); }
        }

        public void CambiarIdioma(IIdioma nuevoIdioma)
        {
            IdiomaActual = nuevoIdioma;
            Notificar();
        }

        // --- Implementación de la interfaz ESPECÍFICA ---

        public void Suscribir(IObservadorIdioma observador)
        {
            if (!_observadores.Contains(observador))
            {
                _observadores.Add(observador);
                if (IdiomaActual != null)
                    observador.ActualizarIdioma(IdiomaActual);
            }
        }

        public void Desuscribir(IObservadorIdioma observador)
        {
            if (_observadores.Contains(observador))
            {
                _observadores.Remove(observador);
            }
        }

        public void Notificar()
        {
            if (IdiomaActual != null)
            {
                foreach (var obs in _observadores)
                {
                    obs.ActualizarIdioma(IdiomaActual);
                }
            }
        }
    }
}

