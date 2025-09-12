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
    public partial class FormListadoProductos : Form
    {
        public FormListadoProductos(int idioma)
        {
            InitializeComponent();
            AplicarIdioma(idioma);
        }

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
            btnEliminar.Text = Res_español.Borrar;
            btnModificar.Text = Res_español.Modificar;
            button1.Text = Res_español.Actualizar;

            groupBox2.Text = Res_español.informacion_producto;
            label1.Text = Res_español.codigo_producto;
            label2.Text = Res_español.nombre_producto;
            label3.Text = Res_español.Costo_producto_;
            label4.Text = Res_español.Gasto_adicional;
            label10.Text = Res_español.problema_de_entrada;
            label9.Text = Res_español.persona_responsable;

            label13.Text = Res_español.Deposito_almacenado;
            label12.Text = Res_español.Estante;
            label11.Text = Res_español.Nivel_de_estante;
            label6.Text = Res_español.Columna;

            groupBox1.Text = Res_español.Estado_del_producto;
            label8.Text = Res_español.Costo_de_mano_de_obra;
        }
        public void gettextingles()
        {
            btnEliminar.Text = Res_ingles.Delete;
            btnModificar.Text = Res_ingles.Modify;
            button1.Text = Res_ingles.Update;

            groupBox2.Text = Res_ingles.Product_information;
            label1.Text = Res_ingles.Product_code;
            label2.Text = Res_ingles.Product_name;
            label3.Text = Res_ingles.Product_Cost_;
            label4.Text = Res_ingles.Additional_expense;
            label10.Text = Res_ingles.Reported_Issue_;
            label9.Text = Res_ingles.Responsible_person;

            label13.Text = Res_ingles.Storage_bin;
            label12.Text = Res_ingles.Shelf;
            label11.Text = Res_ingles.Shelf_level;
            label6.Text = Res_ingles.Column;

            groupBox1.Text = Res_ingles.Product_Status_;

            label8.Text = Res_ingles.Labor_cost;
        }
        public void gettextportugues()
        {
            btnEliminar.Text = Res_portugues.Deletar;
            btnModificar.Text = Res_portugues.Modificar;
            button1.Text = Res_portugues.Atualizar;

            groupBox2.Text = Res_portugues.Informações_do_produto;
            label1.Text = Res_portugues.Condição_do_produto;
            label2.Text = Res_portugues.Nome_do_Produto;
            label3.Text = Res_portugues.Custo_da_mão_de_obra;
            label4.Text = Res_portugues.Adicionar;
            label10.Text = Res_portugues.Problema_de_entrada;
            label9.Text = Res_portugues.Responsável;

            label13.Text = Res_portugues.Caixa_de_armazenamento;
            label12.Text = Res_portugues.Prateleira;
            label11.Text = Res_portugues.Nível_da_prateleira;
            label6.Text = Res_portugues.Coluna;

            groupBox1.Text = Res_portugues.Estado_do_Produto;
            label8.Text = Res_portugues.Custo_da_mão_de_obra;
        }


        private void FormListadoProductos_Load(object sender, EventArgs e)
        {
            actualizarLista();
            //comboBoxPersonaResponsable.DataSource = ListadoEmpleados.Instancia.Empleados;
            //comboBoxPersonaResponsable.DisplayMember = "NombreCompleto";
            //if (ListadoEmpleados.Instancia.Empleados.Count > 0) return;
            //Servicios.ServiciosUsuariosCSV.EmpleadosActivos();
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
            if (resultado == DialogResult.Yes)
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
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

                comboBoxCliente.SelectedValue = new Cliente()
                {
                    IdCliente = Convert.ToInt32(comboBoxCliente.SelectedValue)
                };
            }
        }

        private void numericUpDownCostoPerdidaMateriaPrima_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

