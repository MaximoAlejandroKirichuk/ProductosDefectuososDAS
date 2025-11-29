using BE;
using BE.actores;
using BLL;
using Servicios;
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
        GestorClienteBLL cliente = new GestorClienteBLL();
        GestorProductosBLL productoBLL = new GestorProductosBLL();
        GestorSeguimientoBLL seguimientoBLL = new GestorSeguimientoBLL();
        public void CargarGrid(int codigoProducto)
        {
            List<Seguimiento> lista = seguimientoBLL.ObtenerSeguimientosPublicosPorProducto(codigoProducto);
            if(lista.Count < 0)
            {
                MessageBox.Show("No hay seguimientos para este producto");
                return;
            }
            btnExportarSeguimiento.Enabled = true;
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

            try
            {
                int idCliente = cliente.ObtenerIdClientePorDocumento(nroDocumento);
                if (idCliente == -1)
                {
                    MessageBox.Show("Cliente no encontrado.");
                    return;
                }
                // Cargar productos del cliente
                ActualizarLista(idCliente);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message);
            }
           
           
        }
        
        private void ActualizarLista(int idCliente)
        {
            dataGridViewSeguimientos.DataSource = null;
            dataGridViewProductos.DataSource = productoBLL.ObtenerProductosPorCliente(idCliente); ;
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            
            //CargarGrid(codigoProducto);
        }

        private void dataGridViewProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }
            try
            {
                DataGridViewRow row = dataGridViewProductos.SelectedRows[0];
                int idCodigoProducto = Convert.ToInt32(row.Cells["CodigoProducto"].Value);

                CargarGrid(idCodigoProducto);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewSeguimientos.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Archivo XML|*.xml";
            saveFile.Title = "Guardar Seguimientos";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                // UI convierte la grilla a DataTable
                DataTable dt = ConvertirDataGridViewADataTable(dataGridViewSeguimientos);
                dt.TableName = "Seguimientos";
                // UI llama al servicio
                XmlService xmlService = new XmlService();
                xmlService.ExportarDataTableAXml(dt, saveFile.FileName);

                MessageBox.Show("XML exportado correctamente.");
            }
        }
        private DataTable ConvertirDataGridViewADataTable(DataGridView dgv)
        {
            DataTable dt = new DataTable();

            foreach (DataGridViewColumn col in dgv.Columns)
                dt.Columns.Add(col.HeaderText);

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                {
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < dgv.Columns.Count; i++)
                        dr[i] = row.Cells[i].Value ?? DBNull.Value;

                    dt.Rows.Add(dr);
                }
            }

            return dt;
        }

    }
}
