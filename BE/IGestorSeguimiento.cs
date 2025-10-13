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
        bool AgregarSeguimientos(List<Seguimiento> nuevosSeguimientos);
        bool BorrarSeguimiento(Seguimiento seguimientoABorrar);
        bool ModificarSeguimiento(Seguimiento seguimientoModificado);
        bool ModificarEstadoSeguimiento(); 
        List<Seguimiento> ObtenerSeguimientosPorProducto(int codigoProducto);

    }
}
