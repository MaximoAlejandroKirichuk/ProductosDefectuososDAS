using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public enum Enums
    {
        Administrador,
        Empleado
    }
    public enum TipoCosto
    {
        Perdida,
        ManoObra
    }
    public enum CondicionProducto
    {
        Normal,
        Defectuoso,
        EnReparacion,
        Reparado,
        Desechado
    }
    public enum TipoMedioPago
    {
        Efectivo,
        Credito
    }
}
