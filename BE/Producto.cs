using BE.actores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Producto : ICloneable, IComparable<Producto>
    {

        public int CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public decimal CostoProducto { get; set; }
        public decimal GastoAdicionalAntesDefecto { get; set; } 
        public int CantidadDaniada { get; set; }
        public string ProblemaEntrada { get; set; }
        public Cliente Cliente { get; set; }
        public Usuario PersonaResponsable { get; set; }
        public Ubicacion UbicacionProducto { get; set; }
        public AreaResponsable AreaDevolver { get; set; }
        public List<Seguimiento> ListaSeguimiento { get; set; } = new List<Seguimiento>();

        // Usamos una enumeración para el estado, es más seguro que un string.
        public CondicionProducto EstadoActual { get; set; }

        public Producto() { }

        
        public Producto(int codigoProducto, string nombreProducto, decimal costoProducto, Cliente cliente)
        {
            this.CodigoProducto = codigoProducto;
            this.NombreProducto = nombreProducto;
            this.CostoProducto = costoProducto;
            this.Cliente = cliente;
            this.EstadoActual = CondicionProducto.Normal; // Un producto nuevo inicia como normal.
        }

        public void MarcarComoDefectuoso(string problema, int cantidadDaniada, decimal gastoAdicional, Ubicacion ubicacion)
        {
            this.EstadoActual = CondicionProducto.Defectuoso;
            this.ProblemaEntrada = problema;
            this.CantidadDaniada = cantidadDaniada;
            this.GastoAdicionalAntesDefecto = gastoAdicional;
            this.UbicacionProducto = ubicacion;
            
            this.AgregarSeguimiento("Producto marcado como defectuoso.");
        }

        public void AgregarSeguimiento(string mensaje,)
        {
            this.ListaSeguimiento.Add(new Seguimiento(DateTime.Now, mensaje,responsable,codigoProducto));
        }

        // Métodos ICloneable e IComparable
        public object Clone()
        {
            return new Producto
            {
                CodigoProducto = this.CodigoProducto,
                NombreProducto = this.NombreProducto,
                CostoProducto = this.CostoProducto,
                GastoAdicionalAntesDefecto = this.GastoAdicionalAntesDefecto,
                CantidadDaniada = this.CantidadDaniada,
                ProblemaEntrada = this.ProblemaEntrada,
                Cliente = this.Cliente, // Se asume que Cliente es inmutable 
                PersonaResponsable = this.PersonaResponsable, // Idem
                UbicacionProducto = this.UbicacionProducto, // Idem
                EstadoActual = this.EstadoActual,
                AreaDevolver = this.AreaDevolver,
                ListaSeguimiento = new List<Seguimiento>(this.ListaSeguimiento.Select(s => (Seguimiento)s.Clone())) // Clonación profunda si la clase Seguimiento tiene Clone
            };
        }

        public int CompareTo(Producto other)
        {
            if (other == null) return 1;
            decimal thisTotal = this.CostoProducto + this.GastoAdicionalAntesDefecto;
            decimal otherTotal = other.CostoProducto + other.GastoAdicionalAntesDefecto;
            return otherTotal.CompareTo(thisTotal); 
        }

        public override string ToString()
        {
            return $"{CodigoProducto};{NombreProducto};{CostoProducto};{GastoAdicionalAntesDefecto};{CantidadDaniada};{ProblemaEntrada};{EstadoActual};{UbicacionProducto?.DepositoAlmacenado}";
        }
    }


}