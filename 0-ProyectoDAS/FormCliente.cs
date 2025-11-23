using BE;
using BLL;
using System;
using System.CodeDom.Compiler;
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
    public partial class FormCliente : BaseForm
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        public void CargarGrid(int codigoProducto)
        {
            GestorSeguimientoBLL gestor = new GestorSeguimientoBLL();
            List<Seguimiento> lista = gestor.ObtenerSeguimientosPublicosPorProducto(codigoProducto);

            dataGridViewSeguimientos.DataSource = lista.Select(s => new
            {
                s.Mensaje,
                Fecha = s.FechaRegistro,
                Responsable = s.Responsable.NombreCompleto
            }).ToList();

            dataGridViewSeguimientos.Columns["Mensaje"].HeaderText = "Seguimiento";
            dataGridViewSeguimientos.Columns["Fecha"].HeaderText = "Fecha";
            dataGridViewSeguimientos.Columns["Responsable"].HeaderText = "Empleado";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nroDocumento = txtNroCuilCuit.Text.Trim();
            GestorClienteBLL cliente = new GestorClienteBLL();
            GestorProductosBLL productoBLL = new GestorProductosBLL();
            GestorSeguimientoBLL seguimientoBLL = new GestorSeguimientoBLL();
            try
            {
                int idCliente = cliente.ObtenerIdClientePorDocumento(nroDocumento);
                if (idCliente == -1)
                {
                    MessageBox.Show("Cliente no encontrado.");
                    return;
                }
                // Cargar productos del cliente
                DataTable dtProductos = productoBLL.ObtenerProductosPorCliente(idCliente);
                dataGridViewProductos.DataSource = dtProductos;
                // Limpiar seguimientos
                dataGridViewSeguimientos.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message);
            }
           
           
        }
        
       

        private void FormCliente_Load(object sender, EventArgs e)
        {
            
            //CargarGrid(codigoProducto);
        }
    }
}
