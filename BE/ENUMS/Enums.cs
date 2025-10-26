using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public enum Idioma
    {
        Ingles,
        Español,
        Portugues
    }
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

    //BITACORA
    public enum NivelLog
    {
        Informacion,
        Alerta,
        Error
    }

    public enum ModuloSistema
    {
        Login,
        Seguimientos,
        Clientes,
        Productos,
        Reportes
    }
    public enum Criticidad
    {
        Baja,
        Media,
        Alta
    }

}
