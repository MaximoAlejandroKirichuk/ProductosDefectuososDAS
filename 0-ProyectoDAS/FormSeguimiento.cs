using _0_ProyectoDAS;
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
        private readonly GestorSeguimientoBLL gestorSeguimientoBLL = new GestorSeguimientoBLL();
        private readonly GestorProductosBLL gestorProductosBLL = new GestorProductosBLL();
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
        private void ActualizarListaSeguimientoPorCodigo(int codigoProducto)
        {   
            DGVSeguimientos.DataSource = null;
            DGVSeguimientos.DataSource = gestorSeguimientoBLL.ObtenerSeguimientosPorProducto(codigoProducto);
        }
        private void CargarListadoProductos()
        {
          
            DGVProductos.DataSource = null;
            DGVProductos.DataSource = gestorProductosBLL.ObtenerTodos();
        }
        private void FormSeguimiento_Load(object sender, EventArgs e)
        {
            CargarListadoProductos();
        }
        
        private void Producto_EstadoProductoCambiado(Producto producto, string estadoAnterior, string estadoNuevo)
        {
            MessageBox.Show($"El estado del producto {producto.CodigoProducto} cambió de {estadoAnterior} a {estadoNuevo}");
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
                DataGridViewRow fila = DGVProductos.CurrentRow;
                int codigoProducto = Convert.ToInt32(fila.Cells["CodigoProducto"].Value); 


                Seguimiento nuevo = new Seguimiento(
                    fecha,
                    mensaje,
                    Usuario,
                    codigoProducto,
                    checkBox1.Checked ? Seguimiento.Visibilidad.Publica : Seguimiento.Visibilidad.Privada
                );

                listBox1.Items.Add(nuevo);
                MessageBox.Show("Seguimiento agregado correctamente.");
            }
        }


        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            //DataGridViewRow fila = dataGridViewListadoProductosDefectuosos.CurrentRow;
            //int codigoProducto = Convert.ToInt32(fila.Cells["CodigoProducto"].Value);  // "CodigoProducto" es el nombre de la columna, o usa índice
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
                    DataGridViewRow fila = DGVProductos.CurrentRow;
                    int codigoProducto = Convert.ToInt32(fila.Cells["CodigoProducto"].Value);
                    ActualizarListaSeguimientoPorCodigo(codigoProducto);
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

        private void DGVProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = DGVProductos.Rows[e.RowIndex];

                var codigoProducto = fila.Cells["CodigoProducto"].Value;
                int codigo = Convert.ToInt32(codigoProducto);

                ActualizarListaSeguimientoPorCodigo(codigo);
            }
        }
        private void dataGridViewSeguimientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que se haya hecho clic en una fila valida
            if (e.RowIndex < 0 || e.RowIndex >= DGVSeguimientos.Rows.Count)
                return;

            // Obtener el índice real de la fila seleccionada
            int indice = e.RowIndex;

            try
            {
                Seguimiento s = (Seguimiento)DGVSeguimientos.Rows[e.RowIndex].DataBoundItem;
                FormModificarSeguimiento form = new FormModificarSeguimiento(s);
                form.Show();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al mostrar los datos: " + ex.Message);
            }
        }

        private void btnCambiarCondicionProducto_Click(object sender, EventArgs e)
        {
            if (DGVProductos.CurrentRow != null)
            {
                // Obtener el objeto Producto de la fila seleccionada
                Producto prod = (Producto)DGVProductos.CurrentRow.DataBoundItem;

                FormNotificarCondicionProducto form = new FormNotificarCondicionProducto(prod);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, seleccioná un producto primero.");
            }
        }
    }
}