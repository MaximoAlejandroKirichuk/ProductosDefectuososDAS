using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Log
    {
        public int Id { get; set; }

        // Usuario relacionado, nullable si el log es del sistema
        public int? UsuarioId { get; set; }
        public DateTime FechaEvento { get; set; } = DateTime.Now;

        // Nivel de log (INFO, ERROR, etc)
        public NivelLog NivelLog { get; set; }

        // Módulo del sistema donde ocurrió el evento
        public ModuloSistema ModuloInvolucrado { get; set; }
        public Criticidad Criticidad { get; set; }
        public string AccionRealizada { get; set; }
        
        // Constructor vacío
        public Log() { }

        // Constructor con parámetros
        public Log(int? usuarioId, NivelLog nivel, ModuloSistema modulo, string accion)
        {
            UsuarioId = usuarioId;
            FechaEvento = DateTime.Now;
            NivelLog = nivel;
            ModuloInvolucrado = modulo;
            AccionRealizada = accion;
        }
    }
}
