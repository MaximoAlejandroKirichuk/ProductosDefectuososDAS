using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MPP;
namespace Servicios
{
    public class ServicioNotificacion
    {
        private NotificacionMPP mpp = new NotificacionMPP();

        public void Enviar(Usuario remitente, Usuario destinatario, string mensaje)
        {
            Notificacion n = new Notificacion
            {
                RemitenteId = remitente.IdUsuario,
                DestinatarioId = destinatario.IdUsuario,
                Mensaje = mensaje,
                Fecha = DateTime.Now,
                Leida = false
            };
            mpp.Guardar(n);
        }

        public List<Notificacion> ObtenerPendientes(Usuario destinatario)
        {
            return mpp.ObtenerPendientes(destinatario.IdUsuario);
        }

        public void MarcarTodasComoLeidas(Usuario destinatario)
        {
            mpp.MarcarComoLeidas(destinatario.IdUsuario);
        }

    }
}
