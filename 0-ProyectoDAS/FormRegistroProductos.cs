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
using _0_ProyectoDAS.Idiomas;
using _0_ProyectoDAS;
using BLL;
using BE.actores;


namespace UI
{
    public partial class FormRegistroProductos : Form
    {
        public FormRegistroProductos(int idioma)
        {
            InitializeComponent();

            AplicarIdioma(idioma);

            //entonces aca cuando se FileNameuse el delegado utiliza la messagebox 
            Notificador = mensaje => { MessageBox.Show(mensaje); this.Close(); };
        }

        private GestorProductosBLL gestorProductosBLL = new GestorProductosBLL();
        public void AplicarIdioma(int idiomanuevo)
        {
            if (idiomanuevo == 1)
                gettextespañol();
            else if (idiomanuevo == 2)
                gettextingles();
            else if (idiomanuevo == 3)
                gettextportugues();
        }


        public void gettextespañol()
        {
            label3.Text = Res_español.nombre_producto;
            label4.Text = Res_español.Costo_producto_;
            
            label15.Text = Res_español.Problema_por_el_que_llega_;

            tabPage1.Text = Res_español.Datos_del_Producto_;
            tabPage2.Text = Res_español.Ubicación_Geográfica;
            tabPage3.Text = Res_español.Estado_del_producto;
            tabPage4.Text = Res_español.Seguimiento;
            tabPage5.Text = Res_español.Finalizar_formulario_;

            label8.Text = Res_español.Nivel_de_estante;
            label7.Text = Res_español.Columna;

            label6.Text = Res_español.Estado_del_producto;
            label11.Text = Res_español.Costo_de_perdida_de_materia_prima;
            label12.Text = Res_español.Costo_de_mano_de_obra;
            label13.Text = Res_español.Paso_al_seguimiento;

            btnAgregarPaso.Text = Res_español.Agregar;
            btnTerminarCarga.Text = Res_español.Terminar_Carga;
        }
        public void gettextingles()
        {
            label3.Text = Res_ingles.Product_name;
            label4.Text = Res_ingles.Product_Cost_;
           
            label15.Text = Res_ingles.Input_problem;

            tabPage1.Text = Res_ingles.Product_information;
            tabPage2.Text = Res_ingles.Geographical_Location_;
            tabPage3.Text = Res_ingles.Product_Status_;
            tabPage4.Text = Res_ingles.Follow_up;
            tabPage5.Text = Res_ingles.finish_upload;

            label8.Text = Res_ingles.Shelf_level;
            label7.Text = Res_ingles.Column;

            label6.Text = Res_ingles.product_condition;
            label11.Text = Res_ingles.cost_of_raw_material_loss;
            label12.Text = Res_ingles.Labor_cost;
            label13.Text = Res_ingles.Steps_of_Follow_up;

            btnAgregarPaso.Text = Res_ingles.Add;
            btnTerminarCarga.Text = Res_ingles.finish_upload;
        }
        public void gettextportugues()
        {
            label3.Text = Res_portugues.Nome_do_Produto;
            label4.Text = Res_portugues.Custo_do_Produto;
            
            label15.Text = Res_portugues.Problema_de_entrada;

            tabPage1.Text = Res_portugues.Dados_do_Produto;
            tabPage2.Text = Res_portugues.Localização_Geográfica;
            tabPage3.Text = Res_portugues.Estado_do_Produto;
            tabPage4.Text = Res_portugues.Acompanhamento;
            tabPage5.Text = Res_portugues.Finalizar_Formulário;

            label8.Text = Res_portugues.Nível_da_prateleira;
            label7.Text = Res_portugues.Coluna;

            label6.Text = Res_portugues.Estado_do_Produto;
            label11.Text = Res_portugues.Custo_da_perda_de_matéria_prima;
            label12.Text = Res_portugues.Custo_da_mão_de_obra;
            label13.Text = Res_portugues.Adicionar_etapas_ao_rastreamento;

            btnAgregarPaso.Text = Res_portugues.Adicionar;
            btnTerminarCarga.Text = Res_portugues.Finalizar_Formulário;
        }

        //declaramos el delegado 
        //declaramos un objeto notificarproductocreado
        public delegate void NotificarProductoCreado(string mensaje);
        public NotificarProductoCreado Notificador;


        private void FormRegistroProductos_Load(object sender, EventArgs e)
        {
            //comboBoxPersonaResponsable.DataSource = null;
            //comboBoxPersonaResponsable.DataSource = ListadoEmpleados.Instancia.Empleados;
            //comboBoxPersonaResponsable.DisplayMember = "NombreCompleto";
            
            //TODO: ESTA HARDCODEADO AHORA EL COMBOBOX
            //aca va a ir nuestro cliente 
            //comboBoxCliente.DataSource = null;
            //comboBoxCliente.DataSource = ListadoClientesBLL.Instancia;
            //comboBoxCliente.DisplayMember = "NombreCompleto";

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
                int idCliente = Convert.ToInt32(comboBoxCliente.SelectedItem);
                var cliente = new Cliente
                {
                    IdCliente = idCliente
                };
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
            //string creadorSeguimiento = SesionActiva.Instancia.UsuarioActivo.Fullname;
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
