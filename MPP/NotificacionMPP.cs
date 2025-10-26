using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;
namespace MPP
{
    public class NotificacionMPP
    {
        private NotificacionDAL dal = new NotificacionDAL();

        public bool Guardar(Notificacion notificacion) => dal.Insertar(notificacion);

        public List<Notificacion> ObtenerPendientes(int usuarioId) => dal.ObtenerPendientesPorUsuario(usuarioId);

        public bool MarcarComoLeidas(int usuarioId) => dal.MarcarComoLeida(usuarioId);
    }
}
