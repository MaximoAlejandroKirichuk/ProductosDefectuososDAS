using BE.actores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Producto : ICloneable //, IComparable<Producto>
    {

        public int CodigoProducto { get; set; }
        public decimal CostoProducto { get; set; }
        public CondicionProducto CondicionProducto { get; set; }
        public EstadoEntraga EstadoEntrega { get; set; }
        public string NombreProducto { get; set; }
        public List<Seguimiento> ListaSeguimiento { get; set; } = new List<Seguimiento>();
        public string ProblemaEntrada { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime FechaRecibidaProducto { get; set; }
        public DateTime FechaEstimadaDevolucion { get; set; }
        public Dimensiones Dimensiones { get; set; }
        public decimal CostoPerdidaMateriaPrima { get; set; }
        public decimal CostoManoObra { get; set; }
        public DateTime FechaDevolucionReal { get; set; }

        public Producto() { }

        
        public Producto(int codigoProducto, string nombreProducto, decimal costoProducto, Cliente cliente)
        {
            this.CodigoProducto = codigoProducto;
            this.NombreProducto = nombreProducto;
            this.CostoProducto = costoProducto;
            this.Cliente = cliente;
            this.CondicionProducto = CondicionProducto.Nuevo; // Un producto nuevo inicia como normal.
            EstadoEntrega = EstadoEntraga.NoEntregado; // Se recibe
        }

        //public void MarcarComoDefectuoso(string problema, int cantidadDaniada, decimal gastoAdicional, Ubicacion ubicacion)
        //{
        //    this.EstadoActual = CondicionProducto.Defectuoso;
        //    this.ProblemaEntrada = problema;
        //    this.CantidadDaniada = cantidadDaniada;
        //    this.GastoAdicionalAntesDefecto = gastoAdicional;
        //    this.UbicacionProducto = ubicacion;
            
        //    this.AgregarSeguimiento("Producto marcado como defectuoso.", this.PersonaResponsabl);
        //}

        //public void AgregarSeguimiento(string mensaje, Usuario responsable, int codigoProducto)
        //{
        //    this.ListaSeguimiento.Add(new Seguimiento(DateTime.Now, mensaje,responsable,codigoProducto));
        //}

        // Métodos ICloneable e IComparable
        public object Clone()
        {
            return new Producto
            {
                CodigoProducto = this.CodigoProducto,
                NombreProducto = this.NombreProducto,
                CostoProducto = this.CostoProducto,
                ProblemaEntrada = this.ProblemaEntrada,
                Cliente = this.Cliente, // Se asume que Cliente es inmutable 
                EstadoEntrega = this.EstadoEntrega,
                ListaSeguimiento = new List<Seguimiento>(this.ListaSeguimiento.Select(s => (Seguimiento)s.Clone())) // Clonación profunda si la clase Seguimiento tiene Clone
            };
        }

        //public int CompareTo(Producto other)
        //{
        //    if (other == null) return 1;
        //    //decimal thisTotal = this.CostoProducto + this.GastoAdicionalAntesDefecto;
        //    //decimal otherTotal = other.CostoProducto + other.GastoAdicionalAntesDefecto;
        //    return otherTotal.CompareTo(thisTotal); 
        //}

        
    }


}