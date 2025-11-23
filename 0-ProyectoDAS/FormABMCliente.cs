using BE;
using BE.actores;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI;

namespace _0_ProyectoDAS
{
    public partial class FormABMCliente : BaseForm
    {
        public FormABMCliente()
        {
            InitializeComponent();
        }
        private GestorClienteBLL gestorClienteBLL = new GestorClienteBLL();
        private void FormABMCliente_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreCompleto = txtNombreCompleto.Text;
                string email = txtEmail.Text;
                string direccion = txtDireccion.Text;
                TipoDocumentoCliente tipoDocumentoCliente;
                Enum.TryParse(comboBoxTipoDocumento.SelectedItem.ToString(), out tipoDocumentoCliente);

                string nroDocumento = txtNroDocumento.Text.Trim(); // AHORA

                var deudaTotal = Convert.ToDecimal(txtDeudaTotal.Text);

                
                var nuevoCliente = new Cliente(nombreCompleto, tipoDocumentoCliente, nroDocumento, direccion, deudaTotal, email);

                // Si la BLL falla (ej. CUIL inválido), saltará al CATCH
                gestorClienteBLL.Agregar(nuevoCliente);

                MessageBox.Show("Se agrego correctamente el usuario", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarClientes();
            }
            catch (Exception ex)
            {
                // Esto atrapará el error de la BLL (ej. "Ingrese correctamente el cuil...")
                MessageBox.Show(ex.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBorrarCliente_Click(object sender, EventArgs e)
        {
            // ... (Este método está bien, usa IdCliente) ...
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    DataGridViewRow fila = dataGridView1.CurrentRow;
                    int idCliente = Convert.ToInt32(fila.Cells["IdCliente"].Value);
                    gestorClienteBLL.Borrar(idCliente);
                    MessageBox.Show("Cliente borrado correctamente");
                    CargarClientes();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un cliente de la lista");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al borrar cliente: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    DataGridViewRow fila = dataGridView1.CurrentRow;

                    int idCliente = Convert.ToInt32(fila.Cells["IdCliente"].Value);
                    string nombreCompleto = txtNombreCompleto.Text;
                    string email = txtEmail.Text;
                    string direccion = txtDireccion.Text;
                    TipoDocumentoCliente tipoDocumentoCliente;
                    Enum.TryParse(comboBoxTipoDocumento.SelectedItem.ToString(), out tipoDocumentoCliente);

                    // --- CAMBIO AQUÍ ---
                    // int nroDocumento = Convert.ToInt32(txtNroDocumento.Text); // ANTES
                    string nroDocumento = txtNroDocumento.Text.Trim(); // AHORA

                    var deudaTotal = Convert.ToDecimal(txtDeudaTotal.Text);

                    var clienteModificado = new Cliente(nombreCompleto, tipoDocumentoCliente, nroDocumento, direccion, deudaTotal, email);
                    clienteModificado.IdCliente = idCliente;

                    // La BLL lanzará una excepción si el CUIL es inválido
                    gestorClienteBLL.Modificar(clienteModificado);

                    MessageBox.Show("Cliente modificado correctamente");
                    CargarClientes();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un cliente de la lista");
                }
            }
            catch (Exception ex)
            {
                // Esto atrapará el error de la BLL
                MessageBox.Show(ex.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarClientes()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gestorClienteBLL.ObtenerClientes();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Este método ya estaba bien, porque .ToString() funciona
            // tanto para int como para string.
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                txtNombreCompleto.Text = fila.Cells["NombreCompleto"].Value.ToString();
                txtEmail.Text = fila.Cells["Email"].Value.ToString();
                txtDireccion.Text = fila.Cells["Direccion"].Value.ToString();
                txtNroDocumento.Text = fila.Cells["NroDocumento"].Value.ToString();
                txtDeudaTotal.Text = fila.Cells["DeudaTotal"].Value.ToString();

                string tipoDoc = fila.Cells["TipoDocumento"].Value.ToString();
                comboBoxTipoDocumento.SelectedItem = tipoDoc;
            }
        }
    }
}
