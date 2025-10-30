using BE.actores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Producto : ICloneable, ISujeto//, IComparable<Producto>
    {
        private List<IObservador> _observadores = new List<IObservador>();

        public int CodigoProducto { get; set; }
        public decimal CostoProducto { get; set; }
        private CondicionProducto _condicionProducto;
        public CondicionProducto CondicionProducto
        {
            get => _condicionProducto;
            set
            {
                if (_condicionProducto != value)
                {
                    _condicionProducto = value;
                    // Notificar a los empleados
                    NotificarObservadores($"El producto {NombreProducto} cambió su condición a {_condicionProducto}");
                }
            }
        }
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
        public DateTime? FechaDevolucionReal { get; set; }

        public Producto() { }

        
        public Producto(int codigoProducto, string nombreProducto, decimal costoProducto, Cliente cliente)
        {
            this.CodigoProducto = codigoProducto;
            this.NombreProducto = nombreProducto;
            this.CostoProducto = costoProducto;
            this.Cliente = cliente;
            this.CondicionProducto = CondicionProducto.Defectuoso; // Un producto nuevo inicia como defectuoso.
            EstadoEntrega = EstadoEntraga.NoEntregado; // Se recibe
        }
        public void ModificarCondicionProducto(CondicionProducto nuevaCondicion)
        {
            if (CondicionProducto != nuevaCondicion)
            {
                CondicionProducto = nuevaCondicion;
                NotificarObservadores($"El producto {NombreProducto} cambió su condición a {nuevaCondicion}");
            }
        }
        // Implementación de ISujeto
        public void AgregarObservador(IObservador observador)
        {
            _observadores.Add(observador);
        }

        public void QuitarObservador(IObservador observador)
        {
            _observadores.Remove(observador);
        }

        public void NotificarObservadores(string mensaje)
        {
            foreach (var observador in _observadores)
            {
                observador.Actualizar(this, mensaje);
            }
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}