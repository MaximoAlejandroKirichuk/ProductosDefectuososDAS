using BE;
using MPP;
using Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GestorSeguimientoBLL : IGestorSeguimiento
    {

        private SeguimientoMPP seguimientoMPP = new SeguimientoMPP();
        private ServicioNotificacion _servicioNotificacion;

        public GestorSeguimientoBLL()
        {

        }

        public List<Seguimiento> ObtenerSeguimientosPublicosPorProducto(int codigoProducto)
        {
            return seguimientoMPP.ObtenerSeguimientosPublicosPorProducto(codigoProducto);
        }

        public bool AgregarSeguimientos(List<Seguimiento> nuevosSeguimientos)
        {
            return seguimientoMPP.AgregarSeguimientos(nuevosSeguimientos);
        }

        public bool BorrarSeguimiento(Seguimiento seguimientoABorrar)
        {
            return seguimientoMPP.BorrarSeguimiento(seguimientoABorrar);
        }

        public bool ModificarSeguimiento(Seguimiento seguimientoModificado)
        {
            return seguimientoMPP.ModificarSeguimiento(seguimientoModificado);
        }

        public List<Seguimiento> ObtenerSeguimientosPorProducto(int codigoProducto)
        {
            var lista = seguimientoMPP.ObtenerSeguimientosPorProducto(codigoProducto);

            return lista;
        }

        public bool ActualizarCondicionProducto(Producto producto, CondicionProducto nuevaCondicion, Usuario empleado, string mensaje)
        {
            if (producto.CondicionProducto == nuevaCondicion)
                throw new Exception("La condición del producto no puede ser igual a la actual.");

            var exito = seguimientoMPP.ActualizarCondicionProducto(producto, nuevaCondicion);
            if (!exito) throw new Exception("Error al actualizar producto.");

            producto.ModificarCondicionProducto(nuevaCondicion);

            // Notificar al administrador
            var admin = ObtenerAdministradorResponsable();
            ServicioNotificacion servicio = new ServicioNotificacion();

            string mensajeCompleto = $"El empleado {empleado.NombreCompleto} modificó la condición del producto {producto.NombreProducto} a {nuevaCondicion}.\nMensaje: {mensaje}";
            servicio.Enviar(empleado, admin, mensajeCompleto);

            return true;
        }



        private Administrador ObtenerAdministradorResponsable()
        {
            // Esto seria porque siempre hay un solo administrador

            return new Administrador {NombreCompleto = "Máximo Kirichuk", IdUsuario=1 };
        }



    }
}
