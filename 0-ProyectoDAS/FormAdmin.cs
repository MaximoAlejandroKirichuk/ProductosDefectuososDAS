using BE;
using BLL.BLL;
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

namespace _0_ProyectoDAS
{
    public partial class FormAdmin : Form
    {
        private readonly LogsBLL _bll = new LogsBLL();
        private List<Log> _logsCache = new List<Log>();

        public FormAdmin()
        {
            InitializeComponent();
            _bll.ExportacionFinalizada += RutaExportada;
            CargarTodos();

        }
        private void RutaExportada(string ruta)
        {
            MessageBox.Show("Exportación completada: " + ruta);
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            var logsParaExportar = dgvLogs.DataSource as List<Log> ?? _logsCache;

            using (SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "CSV|*.csv",
                FileName = "logs_export.csv"
            })
            {
                if (sfd.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    // El usuario eligió la ruta entonces Creamos el FileStream 
                    using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create))
                    {
                        // El BLL ahora recibe el stream, NO la ruta
                        _bll.ExportarLogsConStream(logsParaExportar, fs);
                    }

                    MessageBox.Show($"Archivo exportado correctamente.\nUbicación: {sfd.FileName}",
                                    "Exportación completa",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar: " + ex.Message,
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }
       


        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime desde = dtpDesde.Value.Date;
            DateTime hasta = dtpHasta.Value.Date.AddDays(1).AddTicks(-1); // hasta fin del día
            if (desde > hasta)
            {
                MessageBox.Show("La fecha 'Desde' no puede ser mayor que la fecha 'Hasta'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // salir o cancelar la operación
            }
            var filtrados = _bll.ObtenerPorFecha(desde, hasta);
            dgvLogs.DataSource = null;
            dgvLogs.DataSource = filtrados;
        }
        private void CargarTodos()
        {
            _logsCache = _bll.ObtenerTodos();
            dgvLogs.DataSource = null;
            dgvLogs.DataSource = _logsCache;
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
        }

        private void btnFiltrarCriticidad_Click(object sender, EventArgs e)
        {
            if (cmbCriticidad.SelectedIndex == -1)
            {
                // Ninguna criticidad seleccionada → mostrar todos
                dgvLogs.DataSource = _logsCache;
                return;
            }

            // Obtener el valor seleccionado como string
            string seleccionado = cmbCriticidad.SelectedItem.ToString();
            Criticidad seleccion;

            // Intentar convertir el string a enum
            if (!Enum.TryParse(seleccionado, out seleccion))
            {
                MessageBox.Show("Criticidad no válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Filtrar usando tu método BLL
            var filtrados = _bll.ObtenerPorCriticidad(seleccion);

            // Mostrar en el DataGridView
            dgvLogs.DataSource = null;
            dgvLogs.DataSource = filtrados;
        }


    }
}