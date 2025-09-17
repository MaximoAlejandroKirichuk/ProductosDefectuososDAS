using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BE.Seguimiento;

namespace BE
{
    public class Seguimiento
    {
        public int CodigoSeguimiento { get; set; }
        public int CodigoProducto { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Mensaje { get; set; }
        public Usuario Responsable { get; set; }
        public enum Visibilidad
        {
            Publica = 0,
            Privada = 1
        }
        public Visibilidad TipoVisibilidad { get; set; }  


        public Seguimiento(DateTime fecha, string mensaje, Usuario responsable, int codigoProducto, Visibilidad visibilidad)
        {
            this.FechaRegistro = fecha;
            this.Mensaje = mensaje;
            this.Responsable = responsable;
            this.CodigoProducto = codigoProducto;
            this.TipoVisibilidad = visibilidad;

        }

        // Constructor sin parámetros para compatibilidad con la deserialización, si es necesario.
        public Seguimiento(){}

        public override string ToString()
        {
            return $"Fecha: {FechaRegistro:yyyy-MM-dd HH:mm:ss} | Mensaje: {Mensaje} | Responsable: {Responsable.IdUsuario} | Código Producto: {CodigoProducto}| Visibilidad: {TipoVisibilidad} ";
        }

        public object Clone()
        {
            return new Seguimiento
            {
                FechaRegistro = this.FechaRegistro,
                Mensaje = this.Mensaje,
                Responsable = this.Responsable,
                CodigoProducto = this.CodigoProducto,
                TipoVisibilidad = this.TipoVisibilidad
            };
        }
    }
}