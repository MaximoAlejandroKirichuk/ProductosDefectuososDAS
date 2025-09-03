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
        void AgregarSeguimiento(int codigoProducto, Seguimiento nuevoSeguimiento);
        bool BorrarSeguimiento(int codigoProducto, Seguimiento seguimientoABorrar);
        bool ModificarSeguimiento(int codigoProducto, DateTime fechaOriginal, Seguimiento seguimientoModificado);
        void ModificarEstadoSeguimiento(); 
        List<Seguimiento> ObtenerSeguimientosPorProducto(int codigoProducto);
    }
}
