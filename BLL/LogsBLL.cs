using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using MPP;
namespace BLL
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using BE;
    using MPP;
    using Servicios;

    namespace BLL
    {
        public class LogsBLL
        {
            private readonly LogMPP mpp = new LogMPP();
            private readonly LogExportadorCSV exportador = new LogExportadorCSV();

            // Evento expuesto a la UI
            public event ExportacionCSVHandler ExportacionFinalizada;

            public LogsBLL()
            {
                exportador.ExportacionCompletada += ruta =>
                {
                    ExportacionFinalizada?.Invoke(ruta);
                };
            }

            public void RegistrarEvento(int? usuarioId, NivelLog nivel, ModuloSistema modulo, string accion, Criticidad criticidad = Criticidad.Media)
            {
                var log = new Log(usuarioId, nivel, modulo, accion)
                {
                    Criticidad = criticidad
                };

                mpp.AgregarNuevoLog(log);
            }

            public List<Log> ObtenerTodos()
            {
                return mpp.Listar();
            }

            public List<Log> ObtenerPorFecha(DateTime desde, DateTime hasta)
            {
                return mpp.FiltrarPorFecha(desde, hasta);
            }

            public List<Log> ObtenerPorCriticidad(Criticidad c)
            {
                return mpp.FiltrarPorCriticidad(c);
            }


            public void ExportarLogsConStream(List<Log> logs, FileStream stream)
            {
                //  ordenar la colección antes de exportarla.
                logs.Sort();

                // Iclonable se usa para no modificar la lista que recibís desde la UI.
                var copiaSegura = logs.Select(l => (Log)l.Clone()).ToList();
                //clonación evita efectos secundarios.

                //Exportar la copia
                exportador.ExportarConStream(stream, copiaSegura);
                
            }

            public List<LogEstadistica> CalcularEstadisticas(List<Log> logsParaProcesar)
            {
                //LINQ para agrupar 
                return logsParaProcesar
                    .GroupBy(log => log.Criticidad) // Agrupamos por el Enum
                    .Select(grupo => new LogEstadistica
                    {
                        Criticidad = grupo.Key, // Convertimos el Enum a Texto
                        Cantidad = grupo.Count() // Contamos cuantos hay
                    })
                    .ToList();
            }

        }
    }
}
