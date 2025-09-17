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

namespace _0_ProyectoDAS
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        public void CargarGrid(int codigoProducto)
        {
            GestorSeguimientoBLL gestor = new GestorSeguimientoBLL();
            List<Seguimiento> lista = gestor.ObtenerSeguimientosPublicosPorProducto(codigoProducto);

            DgvSeguimiento.DataSource = lista.Select(s => new
            {
                s.Mensaje,
                Fecha = s.FechaRegistro,
                Responsable = s.Responsable.NombreCompleto
            }).ToList();

            DgvSeguimiento.Columns["Mensaje"].HeaderText = "Seguimiento";
            DgvSeguimiento.Columns["Fecha"].HeaderText = "Fecha";
            DgvSeguimiento.Columns["Responsable"].HeaderText = "Empleado";
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        
        private void FormCliente_Load(object sender, EventArgs e)
        {
            int codigoProducto = 1; //reemplazá con el producto que quieras mostrar
            CargarGrid(codigoProducto);
        }
    }
}
