using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GestorSeguimiento : IGestorSeguimiento
    {

        private List<Seguimiento> listaSeguimientos;

        public GestorSeguimiento()
        {
            listaSeguimientos = new List<Seguimiento>();
        }


        public void AgregarSeguimiento(int codigoProducto, Seguimiento nuevoSeguimiento)
        {
            if (nuevoSeguimiento == null)
                throw new ArgumentNullException(nameof(nuevoSeguimiento));

            nuevoSeguimiento.CodigoProducto = codigoProducto; // Asegurar código asignado

            listaSeguimientos.Add(nuevoSeguimiento);
        }

        // Borra un seguimiento dado el código de producto y las propiedades del seguimiento
        public bool BorrarSeguimiento(int codigoProducto, Seguimiento seguimientoABorrar)
        {
            var seguimientoExistente = listaSeguimientos.FirstOrDefault(s =>
                s.CodigoProducto == codigoProducto &&
                s.FechaRegistro == seguimientoABorrar.FechaRegistro &&
                s.Mensaje == seguimientoABorrar.Mensaje &&
                s.Responsable == seguimientoABorrar.Responsable);

            if (seguimientoExistente != null)
            {
                listaSeguimientos.Remove(seguimientoExistente);
                return true;
            }
            return false;
        }

        // Modifica un seguimiento buscando por código y FechaRegistro (asumiendo FechaRegistro como identificador único)
        public bool ModificarSeguimiento(int codigoProducto, DateTime FechaRegistroOriginal, Seguimiento seguimientoModificado)
        {
            var seguimientoExistente = listaSeguimientos.FirstOrDefault(s =>
                s.CodigoProducto == codigoProducto &&
                s.FechaRegistro == FechaRegistroOriginal);

            if (seguimientoExistente != null)
            {
                seguimientoExistente.FechaRegistro = seguimientoModificado.FechaRegistro;
                seguimientoExistente.Mensaje = seguimientoModificado.Mensaje;
                seguimientoExistente.Responsable = seguimientoModificado.Responsable;
                return true;
            }
            return false;
        }


        public void ModificarEstadoSeguimiento()
        {
        }

        // Retorna los seguimientos para un producto específico
        public List<Seguimiento> ObtenerSeguimientosPorProducto(int codigoProducto)
        {
            return listaSeguimientos
                .Where(s => s.CodigoProducto == codigoProducto)
                .OrderBy(s => s.FechaRegistro)
                .ToList();
        }

        // Método para cargar lista de seguimientos desde archivo, si hace falta
        public void CargarSeguimientosDesdeArchivo(List<Seguimiento> seguimientos)
        {
            listaSeguimientos = seguimientos ?? new List<Seguimiento>();
        }

        // Método para obtener la lista completa 
        public List<Seguimiento> ObtenerTodosLosSeguimientos()
        {
            return listaSeguimientos;
        }

        
    }
}
