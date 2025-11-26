using BE;
using UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _0_ProyectoDAS;
using BLL;
using BE.actores;


namespace UI
{
    public partial class FormRegistroProductos : BaseForm
    {
        public FormRegistroProductos()
        {
            InitializeComponent();
            
            //entonces aca cuando se FileNameuse el delegado utiliza la messagebox 
            Notificador = mensaje => { MessageBox.Show(mensaje); this.Close(); };
        }

        private GestorProductosBLL gestorProductosBLL = new GestorProductosBLL();
        private GestorClienteBLL gestorClientesBLL = new GestorClienteBLL();
        //declaramos el delegado 
        public delegate void NotificarProductoCreado(string mensaje);
        //declaramos un objeto notificarproductocreado
        public NotificarProductoCreado Notificador;


        private void FormRegistroProductos_Load(object sender, EventArgs e)
        {
            //esto hace que en el combobox aparezcan los clientes que tenemos en la BD. 
            comboBoxCliente.DataSource = null;
            comboBoxCliente.DataSource = gestorClientesBLL.ObtenerClientes();            
            comboBoxCliente.DisplayMember = "NombreCompleto";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string respuesta = comboBoxCondicionProducto.SelectedItem.ToString();

            if (respuesta == "Desechado")
            {
                numericUpDownCostoPerdidaMateriaPrima.Enabled = true;
                numericUpDownCostoManoObra.Enabled = false;
                numericUpDownCostoManoObra.Value = 0;
            }
            else {
                numericUpDownCostoManoObra.Enabled = true;
                numericUpDownCostoPerdidaMateriaPrima.Enabled = false;
                numericUpDownCostoPerdidaMateriaPrima.Value = 0;
            }
        }

        public List<Seguimiento> ObtenerSeguimiento()
        {

            ////Generar seguimiento
            return listBox1.Items.Cast<Seguimiento>().ToList();

        }
       
        public Producto ObtenerDatos()
        {
            try
            {
                ////Generar producto Defectuoso
                string nombreProducto = txtNombreProducto.Text;
                decimal costoProducto = Convert.ToDecimal(txtCostoProducto.Text);
                string problemaEntrada = txtProblemaEntrada.Text;
                Producto nuevo = new Producto
                {
                    NombreProducto = nombreProducto,
                    CostoProducto = costoProducto,
                    ProblemaEntrada = problemaEntrada
                };
                return nuevo;
            }
            catch (Exception)
            {
                throw new Exception("Ocurrio un error al obtener los datos del producto");
            }

        }
        public Dimensiones ObtenerDimensiones()
        {
            try
            {
                decimal alto = numericUpDownAlto.Value;
                decimal ancho = numericUpDownAncho.Value;
                decimal largo = numericUpDownLargo.Value;
                Dimensiones dimensiones = new Dimensiones(ancho, largo, alto);
                return dimensiones;
            }
            catch (Exception)
            {
                throw new Exception("Ocurrio un error al obtener las dimensiones del producto");
            }
            
        }
        public CondicionProducto ObtenerCondicionProducto()
        {
            try
            {
                CondicionProducto condicion;
                Enum.TryParse(comboBoxCondicionProducto.SelectedItem.ToString(), out condicion);
                return condicion;
            }
            catch (Exception)
            {

                throw new Exception("Ocurrio un error al obtener la condicion del producto");
            }
            
        }
        public Cliente ObtenerCliente()
        {
            try
            {
                var cliente = (Cliente)comboBoxCliente.SelectedItem;
               
                return cliente;
            }
            catch (Exception)
            {

                throw new Exception("Ocurrio un error al obtener el cliente asociado al producto");
            }
            
        }
        public void ingresarDatos()
        {
            try
            {
                //Obtener Datos Producto
                var productoNuevo = ObtenerDatos();
                //Obtener dimensiones
                productoNuevo.Dimensiones = ObtenerDimensiones();
                //Obtener Estado Producto
                productoNuevo.CondicionProducto = ObtenerCondicionProducto();
                productoNuevo.CostoPerdidaMateriaPrima = Convert.ToInt32(numericUpDownCostoPerdidaMateriaPrima.Value);
                productoNuevo.CostoManoObra = Convert.ToInt32(numericUpDownCostoManoObra.Value);
                ////Obtener seguimiento
                productoNuevo.ListaSeguimiento = ObtenerSeguimiento();
                // Obtener Cliente asociado
                productoNuevo.Cliente = ObtenerCliente();
                // Obtener Fechas
                productoNuevo.FechaRecibidaProducto = dateTimePickerFechaRecibida.Value;
                productoNuevo.FechaEstimadaDevolucion = dateTimePickerFechaEstimadaDevolucion.Value;

                gestorProductosBLL.Agregar(productoNuevo);

                //Producto nuevoProductoDefectuoso = new Producto(codigoProducto, nombreProducto, costoProducto, gastoGeneradoAntesDefectuoso, cantidadProductoDañada, problemaEntrada, personaResponsable, ubicacionProducto, estadoProducto, seguimiento, area);                ////utilizamos el objeto delegado.
                Notificador?.Invoke("Se creó un nuevo Producto Defectuoso con éxito");

                //ListadoProductoDefectuosos.Instancia.agregarProducto(nuevoProductoDefectuoso);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al generar la carga: " + ex.Message + "  " + ex.Source );
            }
        }
        private void btnTerminarCarga_Click(object sender, EventArgs e)
        {
            ingresarDatos();
            
        }
        
        private void btnAgregarPaso_Click(object sender, EventArgs e)
        {
            //DateTime dia = dateTimePickerFecha.Value;
            //string mensaje = txtAgregarPaso.Text;
            //string creadorSeguimiento = SessionManager.Instancia.UsuarioActivo.Fullname;
            //string codigo = txtCodigoProducto.Text;
            //Seguimiento nuevo = new Seguimiento(dia, mensaje, creadorSeguimiento, codigo);

            //listBox1.Items.Add(nuevo);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormABMCliente abm = new FormABMCliente();
            abm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
