using BE;
using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP
{
    public class SeguimientoMPP : IGestorSeguimiento
    {
        public SeguimientoDAL seguimientoDAL = new SeguimientoDAL();
        public bool AgregarSeguimientos(List<Seguimiento> nuevosSeguimientos)
        {
            return seguimientoDAL.GuardarSeguimiento(nuevosSeguimientos);
        }

        public bool BorrarSeguimiento(Seguimiento seguimientoABorrar)
        {
            throw new NotImplementedException();
        }

        public bool ModificarEstadoSeguimiento()
        {
            throw new NotImplementedException();
        }

        public bool ModificarSeguimiento(DateTime fechaOriginal, Seguimiento seguimientoModificado)
        {
            throw new NotImplementedException();
        }

        public List<Seguimiento> ObtenerSeguimientosPorProducto(int codigoProducto)
        {
            DataTable dt = seguimientoDAL.ObtenerSeguimientoPorProductos(codigoProducto);
            List<Seguimiento> lista = new List<Seguimiento>();

            foreach (DataRow row in dt.Rows)
            {
                Seguimiento s = new Seguimiento
                {
                    CodigoSeguimiento = Convert.ToInt32(row["CodigoSeguimiento"]),
                    CodigoProducto = Convert.ToInt32(row["CodigoProducto"]),
                    Mensaje = row["Mensaje"].ToString(),
                    Responsable = new Empleado
                    {
                        IdUsuario = Convert.ToInt32(row["IDPersonalResponsable"]),
                        NombreCompleto = row["NombreResponsable"].ToString()
                    },
                    FechaRegistro = Convert.ToDateTime(row["FechaRegistro"]),
                    TipoVisibilidad = (Seguimiento.Visibilidad)Convert.ToInt32(row["Visibilidad"])

                };
                lista.Add(s);
            }
            return lista;
        }
        public List<Seguimiento> ObtenerSeguimientosPublicosPorProducto(int codigoProducto)
        {
            DataTable dt = seguimientoDAL.ObtenerSeguimientosPublicosPorProducto(codigoProducto);
            List<Seguimiento> lista = new List<Seguimiento>();

            foreach (DataRow row in dt.Rows)
            {
                Seguimiento s = new Seguimiento(
                    Convert.ToDateTime(row["FechaRegistro"]),
                    row["Mensaje"].ToString(),
                    new Empleado
                    {
                        IdUsuario = Convert.ToInt32(row["IDPersonalResponsable"]),
                        NombreCompleto = row["NombreResponsable"].ToString()
                    },
                    Convert.ToInt32(row["CodigoProducto"]),
                    (Seguimiento.Visibilidad)Convert.ToInt32(row["Visibilidad"])
                );

                s.CodigoSeguimiento = Convert.ToInt32(row["CodigoSeguimiento"]);

                lista.Add(s);
            }

            return lista;
        }

    }
}
