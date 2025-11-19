using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class LogExportadorCSV
    {
        public event ExportacionCSVHandler ExportacionCompletada;



        public void ExportarConStream(FileStream fs, List<Log> logs)
        {
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.WriteLine("Id,UsuarioId,Fecha,Nivel,Modulo,Criticidad,Accion");

                foreach (var l in logs)
                {
                    writer.WriteLine($"{l.Id},{l.UsuarioId},{l.FechaEvento},{l.NivelLog},{l.ModuloInvolucrado},{l.Criticidad},{l.AccionRealizada}");
                }
            }

            ExportacionCompletada?.Invoke("Exportación finalizada correctamente.");
        }


    }
}
