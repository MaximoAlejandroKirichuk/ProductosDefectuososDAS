﻿using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FormReportesUbicacion : Form
    {
        public FormReportesUbicacion()
        {
            InitializeComponent();
        }

        private void FormReportesUbicacion_Load(object sender, EventArgs e)
        {
            //MostrarReportePorUbicacion(ListadoProductoDefectuosos.Instancia.ProductosDefectuosos);
        }
        private void MostrarReportePorUbicacion(List<Producto> productosOriginal)
        {
            //    flowLayoutPanelUbicaciones.Controls.Clear();

            //    //Clonar para proteger la lista original
            //    var productos = productosOriginal.Select(p => (Producto)p.Clone()).ToList();

            //    // Ordenar usando IComparable<Producto> (por costo total descendente), el metodo esta generado en producto
            //    productos.Sort();

            //    // Agrupar productos por depósito y calcular métricas
            //    var reporte = productos
            //        .GroupBy(p => p.UbicacionProducto.DepositoAlmacenado) //Agrupa por depositos
            //        .Select(g => new
            //        {
            //            Deposito = g.Key,
            //            CantidadProductos = g.Count(),
            //            CantidadDaniadaTotal = g.Sum(p => p.CantidadDaniada),
            //            CostoTotal = g.Sum(p => p.CostoProducto + p.GastoAdicionalAntesDefecto),
            //            Reacondicionables = g.Count(p => p.EstadoProducto.Estado == "Reacondicionable"),
            //            Desechados = g.Count(p => p.EstadoProducto.Estado == "Desechado"),
            //            ProblemaMasComun = g.GroupBy(p => p.ProblemaEntrada)
            //                                .OrderByDescending(pg => pg.Count())
            //                                .First().Key
            //        })
            //        .OrderByDescending(r => r.CantidadProductos)
            //        .ToList();

            //    // Mostrar reporte en el FlowLayoutPanel
            //    foreach (var r in reporte)
            //    {
            //        GroupBox gb = new GroupBox();
            //        gb.Text = r.Deposito;
            //        gb.Width = 330;
            //        gb.Height = 200;

            //        var lblCantidad = new Label()
            //        {
            //            Text = $"📦 Productos defectuosos: {r.CantidadProductos}",
            //            AutoSize = true,
            //            Top = 20,
            //            Left = 10,
            //            ForeColor = r.CantidadProductos > 3 ? Color.Red : Color.DarkBlue
            //        };

            //        var lblDaniados = new Label()
            //        {
            //            Text = $"🗃️ Unidades dañadas: {r.CantidadDaniadaTotal}",
            //            AutoSize = true,
            //            Top = 40,
            //            Left = 10
            //        };

            //        var lblCosto = new Label()
            //        {
            //            Text = $"💸 Costo total: {r.CostoTotal:C}",
            //            AutoSize = true,
            //            Top = 60,
            //            Left = 10,
            //            ForeColor = Color.DarkGreen
            //        };

            //        var lblReac = new Label()
            //        {
            //            Text = $"🔄 Reacondicionables: {r.Reacondicionables}",
            //            AutoSize = true,
            //            Top = 80,
            //            Left = 10,
            //            ForeColor = Color.DarkOliveGreen
            //        };

            //        var lblDes = new Label()
            //        {
            //            Text = $"🗑️ Desechados: {r.Desechados}",
            //            AutoSize = true,
            //            Top = 100,
            //            Left = 10,
            //            ForeColor = Color.Maroon
            //        };

            //        var lblProblema = new Label()
            //        {
            //            Text = $"🔎 Problema común: {r.ProblemaMasComun}",
            //            AutoSize = true,
            //            Top = 120,
            //            Left = 10,
            //            ForeColor = Color.DarkSlateGray
            //        };

            //        if (r.ProblemaMasComun == "Accidente de tránsito")
            //            lblProblema.Text += " 🚚";
            //        else if (r.ProblemaMasComun == "Deteriodo de almacen")
            //            lblProblema.Text += " 🏚️";
            //        else if (r.ProblemaMasComun == "Manufactura")
            //            lblProblema.Text += " 🏭";

            //        gb.Controls.Add(lblCantidad);
            //        gb.Controls.Add(lblDaniados);
            //        gb.Controls.Add(lblCosto);
            //        gb.Controls.Add(lblReac);
            //        gb.Controls.Add(lblDes);
            //        gb.Controls.Add(lblProblema);

            //        flowLayoutPanelUbicaciones.Controls.Add(gb);
            //    }
        }

    }
}
