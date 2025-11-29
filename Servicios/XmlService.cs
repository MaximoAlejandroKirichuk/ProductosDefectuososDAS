using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class XmlService
    {
        public void ExportarDataTableAXml(DataTable dt, string rutaArchivo)
        {
            dt.WriteXml(rutaArchivo, XmlWriteMode.WriteSchema);
        }
    }
}
