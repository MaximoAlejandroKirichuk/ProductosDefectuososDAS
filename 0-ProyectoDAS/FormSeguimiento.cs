using _0_ProyectoDAS.Idiomas;
using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI;
using static System.Net.WebRequestMethods;


namespace UI
{
    public partial class FormSeguimiento : Form
    {
        public FormSeguimiento(int idioma)
        {
            InitializeComponent();

            AplicarIdioma(idioma);

        }
        GestorSeguimientoBLL gestorSeguimientoBLL = new GestorSeguimientoBLL();
        GestorProductosBLL gestorProductosBLL = new GestorProductosBLL();
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
            groupBox1.Text = Res_español.Seguimiento;

            label13.Text = Res_español.Paso_al_seguimiento; 

        }
        public void gettextingles()
        {
            groupBox1.Text = Res_ingles.Follow_up;

            label13.Text = Res_ingles.Steps_of_Follow_up;
        }
        public void gettextportugues()
        {
            groupBox1.Text = Res_portugues.Acompanhamento;

            label13.Text = Res_portugues.steps_Acompanhamento;
        }


        private void ActualizarLista(int codigoProducto)
        {
            //TODO: HARDCODEADO 

            dataGridViewListadoProductosDefectuosos.DataSource = null;
            dataGridViewListadoProductosDefectuosos.DataSource = gestorSeguimientoBLL.ObtenerSeguimientosPorProducto(codigoProducto);
        }
        private void CargarListadoProductos()
        {
            //TODO: HARDCODEADO 

            DGVProductos.DataSource = null;
            DGVProductos.DataSource = gestorProductosBLL.ObtenerTodos();
        }
        private void FormSeguimiento_Load(object sender, EventArgs e)
        {
            //TODO: HARDCODEADO 
            CargarListadoProductos();
            ActualizarLista(1);
        }



       

        private void dataGridViewListadoProductosDefectuosos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que se haya hecho clic en una fila valida
            if (e.RowIndex < 0 || e.RowIndex >= dataGridViewListadoProductosDefectuosos.Rows.Count)
                return;

            // Obtener el índice real de la fila seleccionada
            int indice = e.RowIndex;

            // Validación extra por seguridad
            //if (indice >= 0 && indice < ListadoProductoDefectuosos.Instancia.ProductosDefectuosos.Count)
            //{

            //}
            //else
            //{
            //    MessageBox.Show("Índice fuera de rango o lista vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        

        private void dataGridViewSeguimiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que se haya hecho clic en una fila valida
            if (e.RowIndex < 0 || e.RowIndex >= dataGridViewListadoProductosDefectuosos.Rows.Count)
                return;

            // Obtener el índice real de la fila seleccionada
            int indice = e.RowIndex;

            // Validación extra por seguridad
            try
            {
                Seguimiento s = (Seguimiento)dataGridViewListadoProductosDefectuosos.Rows[e.RowIndex].DataBoundItem;

                // Mostrar detalles en controles auxiliares
                DateTime fecha = s.FechaRegistro;
                string mensaje = s.Mensaje;
                listBox1.DataSource = new List<string> { s.ToString() }; ;
                dateTimePickerFecha.Value = fecha;
                txtAgregarPaso.Text = mensaje;
                
                MessageBox.Show("Se cargo correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al mostrar los datos: " + ex.Message);
            }
       
        }
        private void btnAgregarPaso_Click(object sender, EventArgs e)
        {
            //GESTOR CLASE
            try
            {  
                
                MessageBox.Show("Paso agregado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar paso: " + ex.Message);
            }
            
        }

       
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Paso modificado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar paso: " + ex.Message);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Paso eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al borrar paso: " + ex.Message);
            }
        }
        public void CargarSeguimientosEnProducto(Producto producto)
        {
            
        }
        private void btnModificarSeguimiento_Click(object sender, EventArgs e)
        {
            //    string codigoProducto = txtCodigoProducto.Text;
            //    Producto p = ListadoProductoDefectuosos.Instancia.filtarProductoId(codigoProducto);

            //    //  SUSCRIPCIÓN AL EVENTO 
            //    p.EstadoProductoCambiado -= Producto_EstadoProductoCambiado; 
            //    p.EstadoProductoCambiado += Producto_EstadoProductoCambiado;

            //    string valorSeleccionado = comboBoxEstadoProducto.SelectedItem.ToString();

            //    if (Enum.TryParse(valorSeleccionado, out EstadoProducto.TipoEstado estadoActual))
            //    {
            //        // si ya tenés un objeto y solo cambiás el estado interno lo cual genere el evento
            //        p.EstadoProducto.Estado = estadoActual.ToString();
            //        p.EstadoProducto.CostoPerdida = p.EstadoProducto.CostoPerdida;
            //        p.EstadoProducto.CostoManoObra = p.EstadoProducto.CostoManoObra;

            //    }
            //    else
            //    {
            //        MessageBox.Show("El estado seleccionado no es válido.");
            //    }
        }

        private void Producto_EstadoProductoCambiado(Producto producto, string estadoAnterior, string estadoNuevo)
        {
            MessageBox.Show($"El estado del producto {producto.CodigoProducto} cambió de {estadoAnterior} a {estadoNuevo}");
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
        private void FormSeguimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que querés cerrar este formulario?", "Confirmar salida",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Warning
            );

            if (resultado == DialogResult.No)
            {
                e.Cancel = true; // esto cancela el cierre del formulario
            }
            if(resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (DGVProductos.SelectedRows.Count > 0)
            {
                DateTime fecha = dateTimePickerFecha.Value;
                string mensaje = txtAgregarPaso.Text;

                // Responsable = usuario actual
                Usuario Usuario = (Usuario)SesionActiva.Instancia.UsuarioActivo;

                // Código producto
                DataGridViewRow fila = dataGridViewListadoProductosDefectuosos.CurrentRow;

                //TODO: HARDCODEADO
                int codigoProducto = 1;

                Seguimiento nuevo = new Seguimiento(fecha, mensaje, Usuario, codigoProducto);

                listBox1.Items.Add(nuevo);
                MessageBox.Show("Seguimiento agregado correctamente.");

        }
    }
        

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

            int codigoProducto = Convert.ToInt32("1"); //TODO: HARDCODEADO
            List<Seguimiento> lista = new List<Seguimiento>();

            foreach (Seguimiento s in listBox1.Items)
            {
                lista.Add(s);
            }

            try
            {
                bool ok = gestorSeguimientoBLL.AgregarSeguimientos(lista);
                if (ok)
                {
                    MessageBox.Show("Seguimientos guardados correctamente.");
                    listBox1.Items.Clear();
                    this.Close();
                }
                else
                {
                    throw new Exception("Error al guardar seguimientos.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}


