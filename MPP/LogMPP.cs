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
        private LogDAL dal = new LogDAL();
        public bool AgregarNuevoLog(Log log)
        {
            return dal.Insertar(log);
        }


        public List<Log> Listar()
        {
            return dal.Listar();
        }

        public List<Log> FiltrarPorFecha(DateTime desde, DateTime hasta)
        {
            return dal.Listar()
                      .Where(l => l.FechaEvento >= desde && l.FechaEvento <= hasta)
                      .ToList();
        }

        //LINQ
        public List<Log> FiltrarPorCriticidad(Criticidad criticidad)
        {
            var logs = dal.Listar();

            var query =
                from l in logs
                where l.Criticidad == criticidad
                orderby l.FechaEvento descending
                select l;

            return query.ToList();
        }




    }

}

