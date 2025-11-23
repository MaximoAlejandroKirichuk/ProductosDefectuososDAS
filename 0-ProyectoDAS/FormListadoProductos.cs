using _0_ProyectoDAS.Idiomas;
using BE;
using BE.actores;
using BLL;
using System;
using System.Linq;
using System.Windows.Forms;
using UI;

namespace UI
{
    public partial class FormListadoProductos : BaseForm
    {
        public FormListadoProductos()
        {
            InitializeComponent();
        }
        private GestorClienteBLL gestorClientesBLL = new GestorClienteBLL();

     

        
        private void FormListadoProductos_Load(object sender, EventArgs e)
        {
            actualizarLista();
            //esto hace que en el combobox aparezcan los clientes que tenemos en la BD. 
            comboBoxCliente.DataSource = null;
            comboBoxCliente.DataSource = gestorClientesBLL.ObtenerClientes();
            comboBoxCliente.DisplayMember = "NombreCompleto";
            //borrar sino sirve
            comboBoxCliente.ValueMember = "IdCliente";
        }

        private GestorProductosBLL gestorProductoBLL = new GestorProductosBLL();

        private void actualizarLista()
        {
            dataGridViewListadoProductosDefectuosos.DataSource = null;
            dataGridViewListadoProductosDefectuosos.DataSource = gestorProductoBLL.ObtenerTodos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            actualizarLista();
        }



        private void dataGridViewListadoProductosDefectuosos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //// Verifica que se haya hecho clic en una fila valida
            //if (e.RowIndex < 0 || e.RowIndex >= dataGridViewListadoProductosDefectuosos.Rows.Count)
            //    return;

            //// Obtener el índice real de la fila seleccionada
            //int indice = e.RowIndex;

            //// Validación extra por seguridad

            //if (indice >= 0 && indice < ListadoProductoDefectuosos.Instancia.ProductosDefectuosos.Count)
            //{
            //    Producto p = ListadoProductoDefectuosos.Instancia.ProductosDefectuosos[indice];
            //    try
            //    {

            //        //INFORMACION PRODUCTO
            //        txtCodigoProducto.Text = p.CodigoProducto;
            //        txtNombreProducto.Text = p.NombreProducto;
            //        numericUpDownCostoProducto.Value = p.CostoProducto;
            //        numericUpDownGastoAdicional.Value = p.GastoAdicionalAntesDefecto;
            //        txtCantidadDaniada.Text = p.CantidadDaniada.ToString();
            //        comboBoxProblemaEntrada.Text = p.ProblemaEntrada.ToString();
            //        comboBoxPersonaResponsable.Text = p.PersonaResponsable.Fullname;
            //        //UBICACION
            //        comboBoxDepositoAlmacenado.Text = p.UbicacionProducto.DepositoAlmacenado.ToString();
            //        numericUpDownEstante.Value = p.UbicacionProducto.NumeroEstante;
            //        numericUpDownNivelEstante.Value = p.UbicacionProducto.NivelEstante;
            //        numericUpDownColumna.Value = p.UbicacionProducto.NumeroColumna;

            //        //ESTADO
            //        comboBoxEstadoProducto.Text = p.EstadoProducto.Estado;
            //        numericUpDownCostoManoObra.Value = p.EstadoProducto.CostoManoObra;
            //        numericUpDownCostoPerdidaMateriaPrima.Value = p.EstadoProducto.CostoPerdida;

            //    }
            //    catch (Exception )
            //    {
            //        MessageBox.Show("Ocurrio un error al mostrar los datos del producto: " + p.NombreProducto );
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("Índice fuera de rango o lista vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewListadoProductosDefectuosos.SelectedRows.Count > 0)
            {
                try
                {
                    // fila actual
                    DataGridViewRow fila = dataGridViewListadoProductosDefectuosos.CurrentRow;

                    // código del producto
                    int codigoProducto = Convert.ToInt32(fila.Cells["CodigoProducto"].Value);

                    bool respuesta = gestorProductoBLL.Borrar(codigoProducto);

                    if (!respuesta)
                    {
                        throw new Exception("Ocurrió un error al eliminar el producto.");
                    }

                    MessageBox.Show("El producto fue eliminado con éxito.");
                    actualizarLista();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el producto: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para eliminar.");
            }
        }
        private CondicionProducto ObtenerCondicionProductoSeleccionada()
        {
            string seleccion = comboBoxCondicionProducto.SelectedItem?.ToString();

            if (!string.IsNullOrWhiteSpace(seleccion) && Enum.TryParse(seleccion, out CondicionProducto condicion))
            {
                return condicion;
            }

            throw new InvalidOperationException("Debe seleccionar una condición válida del producto.");
        }

        private Producto ObtenerProductoDesdeFormulario()
        {
            var fila = dataGridViewListadoProductosDefectuosos.CurrentRow;

            int codigoProducto = Convert.ToInt32(fila.Cells["CodigoProducto"].Value);
            string problemaSeleccionado = comboBoxProblemaEntrada.SelectedItem?.ToString() ?? "";

            int idCliente = comboBoxCliente.SelectedItem.ToString() != null
                ? Convert.ToInt32(comboBoxCliente.SelectedItem.ToString())
                : 0;

            return new Producto
            {
                CodigoProducto = codigoProducto,
                NombreProducto = txtNombreProducto.Text,
                CostoProducto = numericUpDownCostoProducto.Value,
                CondicionProducto = ObtenerCondicionProductoSeleccionada(),
                ProblemaEntrada = problemaSeleccionado,
                Cliente = new Cliente
                {
                    IdCliente = idCliente
                },
                CostoManoObra = numericUpDownCostoManoObra.Value,
                CostoPerdidaMateriaPrima = numericUpDownCostoPerdidaMateriaPrima.Value,
                Dimensiones = new Dimensiones
                {
                    Alto = numericUpDownAlto.Value,
                    Ancho = numericUpDownAncho.Value,
                    Largo = numericUpDownLargo.Value
                }
            };
        }

        private bool HayProductoSeleccionado()
        {
            return dataGridViewListadoProductosDefectuosos.SelectedRows.Count > 0;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!HayProductoSeleccionado())
            {
                MessageBox.Show("Seleccione un producto para modificar.");
                return;
            }
            try
            {
                Producto productoModificado = ObtenerProductoDesdeFormulario();
                bool respuesta = gestorProductoBLL.Modificar(productoModificado);

                if (!respuesta)
                    throw new Exception("Ocurrió un error al modificar el producto.");

                MessageBox.Show("El producto se modificó con éxito.");
                actualizarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el producto: " + ex.Message);
            }
        }

        private void comboBoxEstadoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string respuesta = comboBoxEstadoProducto.SelectedItem.ToString();

            //if (respuesta == "Desechado")
            //{
            //    numericUpDownCostoPerdidaMateriaPrima.Enabled = true;
            //    numericUpDownCostoManoObra.Enabled = false;
            //}
            //else
            //{
            //    numericUpDownCostoManoObra.Enabled = true;
            //    numericUpDownCostoPerdidaMateriaPrima.Enabled = false;
            //}
        }


        private void FormListadoProductos_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void FormListadoProductos_FormClosing(object sender, FormClosingEventArgs e)
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

        private void dataGridViewListadoProductosDefectuosos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewListadoProductosDefectuosos_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewListadoProductosDefectuosos.CurrentRow != null)
            {
                DataGridViewRow fila = dataGridViewListadoProductosDefectuosos.CurrentRow;

                txtCodigoProducto.Text = fila.Cells["CodigoProducto"].Value.ToString();
                txtNombreProducto.Text = fila.Cells["NombreProducto"].Value.ToString();

                numericUpDownCostoProducto.Value = Convert.ToDecimal(fila.Cells["CostoProducto"].Value);
                numericUpDownCostoManoObra.Value = Convert.ToDecimal(fila.Cells["CostoManoObra"].Value);
                numericUpDownCostoPerdidaMateriaPrima.Value = Convert.ToDecimal(fila.Cells["CostoPerdidaMateriaPrima"].Value);

                comboBoxCondicionProducto.SelectedItem = fila.Cells["CondicionProducto"].Value.ToString();
                comboBoxProblemaEntrada.SelectedItem = fila.Cells["ProblemaEntrada"].Value.ToString();

                Cliente clienteSeleccionado = fila.Cells["Cliente"].Value as Cliente;
                if (clienteSeleccionado != null)
                {
                    comboBoxCliente.SelectedValue = clienteSeleccionado.IdCliente;
                }
                else
                {
                    comboBoxCliente.SelectedIndex = -1; // si no hay cliente asignado
                }
            }
        }

        private void numericUpDownCostoPerdidaMateriaPrima_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

