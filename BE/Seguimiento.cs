using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Seguimiento
    {
        public int CodigoSeguimiento { get; set; }
        public int CodigoProducto { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Mensaje { get; set; }
        public Empleado Responsable { get; set; }
        

        public Seguimiento(DateTime fecha, string mensaje, Empleado responsable, int codigoProducto)
        {
            this.FechaRegistro = fecha;
            this.Mensaje = mensaje;
            this.Responsable = responsable;
            this.CodigoProducto = codigoProducto;
        }

        // Constructor sin parámetros para compatibilidad con la deserialización, si es necesario.
        public Seguimiento(){}

        public override string ToString()
        {
            return $"Fecha: {FechaRegistro:yyyy-MM-dd HH:mm:ss} | Mensaje: {Mensaje} | Responsable: {Responsable} | Código Producto: {CodigoProducto}";
        }

        public object Clone()
        {
            return new Seguimiento
            {
                FechaRegistro = this.FechaRegistro,
                Mensaje = this.Mensaje,
                Responsable = this.Responsable,
                CodigoProducto = this.CodigoProducto
            };
        }
    }
}