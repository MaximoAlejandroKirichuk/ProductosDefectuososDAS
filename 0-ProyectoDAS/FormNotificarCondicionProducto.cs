using BE;
using BLL;
using Servicios;
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
    public partial class FormNotificarCondicionProducto : Form
    {
        public FormNotificarCondicionProducto(Producto ProductoActulizar)
        {
            InitializeComponent();
            // Llamada a la funcion para cargar el ComboBox al inicializar
            CargarCondiciones();
            productoActualizar = ProductoActulizar;

        }
        private Producto productoActualizar { get; set; }
        private GestorSeguimientoBLL gestorSeguimientoBLL = new GestorSeguimientoBLL();
        private void CargarCondiciones()
        {
            //Usa Enum.GetValues para obtener un arreglo de todos los valores del enum.
            Array valoresEnum = Enum.GetValues(typeof(CondicionProducto));

            // Asigna el arreglo de valores del enum como la fuente de datos del ComboBox.
            cmbCondicionProducto.DataSource = valoresEnum;

            // Seleccionar el primer elemento por defecto
            if (cmbCondicionProducto.Items.Count > 0)
            {
                cmbCondicionProducto.SelectedIndex = 0;
            }
        }

        private void FormNotificarCondicionProducto_Load(object sender, EventArgs e)
        {
            txtCondicionActual.Text = productoActualizar.CondicionProducto.ToString();
        }

        private void BtnNotificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la nueva condición seleccionada en el combo
                CondicionProducto nuevaCondicion = (CondicionProducto)cmbCondicionProducto.SelectedItem;
                string mensaje = txtMensajeNotificar.Text;
                // Llamar al método de negocio
                bool exito = gestorSeguimientoBLL.ActualizarCondicionProducto(productoActualizar, nuevaCondicion,(Empleado)SessionManager.Instancia.UsuarioActivo, mensaje);

                // Mostrar mensaje de éxito
                if (exito)
                {
                    MessageBox.Show(
                        $"El producto {productoActualizar.NombreProducto} fue actualizado a '{nuevaCondicion}'.\n" +
                        $"Se ha notificado al administrador correctamente.",
                        "Actualización exitosa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }
    }
}
