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

namespace _0_ProyectoDAS
{
    public partial class FormABMCliente : Form
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
                int nroDocumento = Convert.ToInt32(txtNroDocumento.Text);
                var deudaTotal = Convert.ToDecimal(txtDeudaTotal.Text);

                var nuevoCliente = new Cliente(nombreCompleto, tipoDocumentoCliente, nroDocumento, direccion, deudaTotal, email);
                var respuesta = gestorClienteBLL.Agregar(nuevoCliente);
                if (!respuesta) throw new Exception("No se pudo agregar el nuevo usuario");
                MessageBox.Show("Se agrego correctamente el usuario"); 
                CargarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar el usuario: " + ex.Message);
            }

        }

        private void btnBorrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    DataGridViewRow fila = dataGridView1.CurrentRow;

                    int idCliente = Convert.ToInt32(fila.Cells["IdCliente"].Value);
      
                    var respuesta = gestorClienteBLL.Borrar(idCliente);
                    if (!respuesta) throw new Exception("No se pudo borrar el cliente");

                    MessageBox.Show("Cliente modificado correctamente");

                    // refrescar grilla
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
                    int nroDocumento = Convert.ToInt32(txtNroDocumento.Text);
                    var deudaTotal = Convert.ToDecimal(txtDeudaTotal.Text);

                    var clienteModificado = new Cliente(nombreCompleto, tipoDocumentoCliente, nroDocumento, direccion, deudaTotal, email);
                    clienteModificado.IdCliente = idCliente; // importante para que sepa cuál modificar

                    var respuesta = gestorClienteBLL.Modificar(clienteModificado);
                    if (!respuesta) throw new Exception("No se pudo modificar el cliente");

                    MessageBox.Show("Cliente modificado correctamente");

                    // refrescar grilla
                    CargarClientes();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un cliente de la lista");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar cliente: " + ex.Message);
            }
        }
        private void CargarClientes()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gestorClienteBLL.ObtenerClientes();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Para evitar el header
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                // Llenar los TextBox
                txtNombreCompleto.Text = fila.Cells["NombreCompleto"].Value.ToString();
                txtEmail.Text = fila.Cells["Email"].Value.ToString();
                txtDireccion.Text = fila.Cells["Direccion"].Value.ToString();
                txtNroDocumento.Text = fila.Cells["NroDocumento"].Value.ToString();
                txtDeudaTotal.Text = fila.Cells["DeudaTotal"].Value.ToString();

                // Llenar el ComboBox (suponiendo que en el grid tenés guardado el nombre del enum)
                string tipoDoc = fila.Cells["TipoDocumento"].Value.ToString();
                comboBoxTipoDocumento.SelectedItem = tipoDoc;
            }
        }

    }

}
