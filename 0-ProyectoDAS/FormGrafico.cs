using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using UI;

namespace _0_ProyectoDAS
{
    public partial class FormGrafico : BaseForm
    {
 
        public FormGrafico(List<LogEstadistica> datos)
        {
            InitializeComponent();
            ConfigurarChart(datos);
        }

        private void ConfigurarChart(List<LogEstadistica> datos)
        {
            // Limpiamos configuración previa
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Titles.Add("Distribución por Criticidad");

            // Creamos la serie
            Series serie = new Series("Criticidad");
            serie.ChartType = SeriesChartType.Pie;
            serie.IsValueShownAsLabel = true;

            chart1.Series.Add(serie);

            foreach (var item in datos)
            {
                // Convertimos el Enum a String para que sirva de etiqueta
                int indexPunto = serie.Points.AddXY(item.Criticidad.ToString(), item.Cantidad);

                switch (item.Criticidad)
                {
                    case Criticidad.Baja:
                        serie.Points[indexPunto].Color = Color.Green;
                        break;
                    case Criticidad.Media:
                        serie.Points[indexPunto].Color = Color.Orange;
                        break;
                    case Criticidad.Alta:
                        serie.Points[indexPunto].Color = Color.Red;
                        break;
                }
            }
        }
    }
}
