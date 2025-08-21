using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL

{
    public interface IGestorSeguimiento
    {
        void AgregarSeguimiento(string codigoProducto, Seguimiento nuevoSeguimiento);
        bool BorrarSeguimiento(string codigoProducto, Seguimiento seguimientoABorrar);
        bool ModificarSeguimiento(string codigoProducto, DateTime fechaOriginal, Seguimiento seguimientoModificado);
        void ModificarEstadoSeguimiento(); 
        List<Seguimiento> ObtenerSeguimientosPorProducto(string codigoProducto);
    }
}
