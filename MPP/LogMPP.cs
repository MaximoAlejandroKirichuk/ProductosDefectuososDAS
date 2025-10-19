using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP
{
    public class LogMPP
    {
        private LogDAL logDAL = new LogDAL();
        public bool AgregarNuevoLog(Log log)
        {
            return logDAL.Insertar(log);
        }
    }
}
