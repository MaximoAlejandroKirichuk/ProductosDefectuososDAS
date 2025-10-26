using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public enum TipoCosto
    {
        Perdida,
        ManoObra
    }
    public enum CondicionProducto
    {
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
    public enum RolesUsuarios
    {
        Admin,
        Empleado
    }
    public enum TipoDocumentoCliente
    {
        CUIL,
        CUIT
    }
    public enum EstadoEntraga
    {
        Entregado,
        NoEntregado
    }
}
