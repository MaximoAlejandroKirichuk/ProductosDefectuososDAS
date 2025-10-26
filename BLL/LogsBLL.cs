using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using MPP;
namespace BLL
{
    internal class LogsBLL
    {
        LogMPP logMPP = new LogMPP();
        internal void RegistrarEvento(int? usuarioId, NivelLog nivel, ModuloSistema modulo, string accion, Criticidad criticidad = Criticidad.Media)
        {
            var log = new Log(usuarioId, nivel, modulo, accion)
            {
                Criticidad = criticidad
            };

            logMPP.AgregarNuevoLog(log);
        }
    }
}
