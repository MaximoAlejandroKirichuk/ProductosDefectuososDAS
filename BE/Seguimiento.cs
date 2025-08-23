using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Seguimiento
    {
        public DateTime Fecha { get; set; }
        public string Mensaje { get; set; }
        public string Responsable { get; set; }
        public int CodigoProducto { get; set; }

        public Seguimiento(DateTime fecha, string mensaje, string responsable, int codigoProducto)
        {
            this.Fecha = fecha;
            this.Mensaje = mensaje;
            this.Responsable = responsable;
            this.CodigoProducto = codigoProducto;
        }

        // Constructor sin parámetros para compatibilidad con la deserialización, si es necesario.
        public Seguimiento(){}

        public override string ToString()
        {
            return $"Fecha: {Fecha:yyyy-MM-dd HH:mm:ss} | Mensaje: {Mensaje} | Responsable: {Responsable} | Código Producto: {CodigoProducto}";
        }

        public object Clone()
        {
            return new Seguimiento
            {
                Fecha = this.Fecha,
                Mensaje = this.Mensaje,
                Responsable = this.Responsable,
                CodigoProducto = this.CodigoProducto
            };
        }
    }
}