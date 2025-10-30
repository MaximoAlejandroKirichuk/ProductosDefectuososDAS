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

        public bool ActualizarCondicionProducto(Producto producto, CondicionProducto nuevaCondicion)
        {
            return seguimientoDAL.ActualizarCondicionProducto(producto.CodigoProducto, nuevaCondicion);
        }


        public bool ModificarSeguimiento(Seguimiento seguimientoModificado)
        {
            return seguimientoDAL.ModificarSeguimiento(seguimientoModificado);
        }

        public List<Seguimiento> ObtenerSeguimientosPorProducto(int codigoProducto)
        {
            // Obtenemos el DataSet del DAL
            DataSet ds = seguimientoDAL.ObtenerSeguimientoPorProductos(codigoProducto);
            List<Seguimiento> lista = new List<Seguimiento>();

            // Nos aseguramos de que exista la tabla y tenga filas
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables["Seguimiento"].Rows)
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
            }

            return lista;
        }

        public List<Seguimiento> ObtenerSeguimientosPublicosPorProducto(int codigoProducto)
        {
            DataSet ds = seguimientoDAL.ObtenerSeguimientoPorProductos(codigoProducto);
            List<Seguimiento> lista = new List<Seguimiento>();

            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables["Seguimiento"].Rows)
                {
                    // Solo agregamos los que sean públicos
                    if ((Seguimiento.Visibilidad)Convert.ToInt32(row["Visibilidad"]) == Seguimiento.Visibilidad.Publica)
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
                        )
                        {
                            CodigoSeguimiento = Convert.ToInt32(row["CodigoSeguimiento"])
                        };

                        lista.Add(s);
                    }
                }
            }

            return lista;
        }

    }
}
