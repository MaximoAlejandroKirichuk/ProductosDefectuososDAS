
using _02_ProductosDefectuosos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.AxHost;

namespace UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public int idioma;

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAyuda ventanaAyuda = new FormAyuda(idioma);
            ventanaAyuda.ShowDialog();
        }



        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            FormListadoProductos formListado = new FormListadoProductos(idioma);
            formListado.ShowDialog();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        public void gettextespañol()
        {
            registrarToolStripMenuItem.Text = Res_español.Registrar;
            seguimientoToolStripMenuItem.Text = Res_español.Seguimiento;
            reportesToolStripMenuItem.Text = Res_español.Reporte;
            ModificarToolStripMenuItem.Text = Res_español.Modificar_Productos;
            ayudaToolStripMenuItem.Text = Res_español.Ayuda;
            cerrarSesiónToolStripMenuItem.Text = Res_español.Cerrar_Sesion_;
            cambiarIdiomaToolStripMenuItem.Text = Res_español.Cambiar_Idioma;
            reportePorResponsalbeGeográficaToolStripMenuItem.Text = Res_español.Reportes_por_responsable;
            reportePorUbicaciónGeográficaToolStripMenuItem.Text = Res_español.Reportes_por_ubicacion_geografica;
            reporteFinancieroToolStripMenuItem.Text = Res_español.Reportes_financieros;


            button1.Text = Res_español.Actualizar;
            btnGuardar.Text = Res_español.Guardar;


            //esto hay que ponerlo cuando el toolstrip tiene submenus.
            cambiarIdiomaToolStripMenuItem.DropDownItems[0].Text = "Español";
            cambiarIdiomaToolStripMenuItem.DropDownItems[1].Text = "English";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            gettextespañol();

        }

        public void GetTextIngles()
        {
            //form menu
            registrarToolStripMenuItem.Text = Res_ingles.Register;
            seguimientoToolStripMenuItem.Text = Res_ingles.Follow_up;
            reportesToolStripMenuItem.Text = Res_ingles.Report;
            ModificarToolStripMenuItem.Text = Res_ingles.Modify_Product;
            ayudaToolStripMenuItem.Text = Res_ingles.Help;
            cerrarSesiónToolStripMenuItem.Text = Res_ingles.Log_Out;
            cambiarIdiomaToolStripMenuItem.Text = Res_ingles.Change_Language;
            reportePorResponsalbeGeográficaToolStripMenuItem.Text = Res_ingles.Reports_by_Manager;
            reportePorUbicaciónGeográficaToolStripMenuItem.Text = Res_ingles.Reports_by_Geographic_Location;
            reporteFinancieroToolStripMenuItem.Text = Res_ingles.Financial_Reports;


            button1.Text = Res_ingles.Update;
            btnGuardar.Text = Res_ingles.Save;


            //esto hay que ponerlo cuando el toolstrip tiene submenus.
            cambiarIdiomaToolStripMenuItem.DropDownItems[0].Text = "Español";
            cambiarIdiomaToolStripMenuItem.DropDownItems[1].Text = "English";
        }

        public void GetTextPortugues()
        {
            registrarToolStripMenuItem.Text = Res_portugues.Registrar;
            seguimientoToolStripMenuItem.Text = Res_portugues.Acompanhamento;
            reportesToolStripMenuItem.Text = Res_portugues.Relatórios;
            ModificarToolStripMenuItem.Text = Res_portugues.Modificar_produto;
            ayudaToolStripMenuItem.Text = Res_portugues.Ajuda;
            cerrarSesiónToolStripMenuItem.Text = Res_portugues.Sair;
            cambiarIdiomaToolStripMenuItem.Text = Res_portugues.mudar_idioma;
            reportePorResponsalbeGeográficaToolStripMenuItem.Text = Res_portugues.Relatórios_por_Gerente;
            reportePorUbicaciónGeográficaToolStripMenuItem.Text = Res_portugues.Relatórios_por_Localização_Geográfica;
            reporteFinancieroToolStripMenuItem.Text = Res_portugues.Relatórios_Financeiros;

            button1.Text = Res_portugues.Atualizar;
            btnGuardar.Text = Res_portugues.Salvar;

            //esto hay que ponerlo cuando el toolstrip tiene submenus.
            cambiarIdiomaToolStripMenuItem.DropDownItems[0].Text = "Español";
            cambiarIdiomaToolStripMenuItem.DropDownItems[1].Text = "English";
        }




        private void btnGuardar_Click(object sender, EventArgs e)
        {
        }
       

        private void dataGridViewListadoProductosDefectuosos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        public void CargarDatosArchivosSeguimiento(string codigoProducto)
        {
        }
        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SesionActiva.Instancia.CerrarSesion();
            MessageBox.Show("Se cerro sesión");
            this.Close();
            Form form = new Login();
            form.Show();
        }

        

        private void seguimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FormSeguimiento f = new FormSeguimiento(idioma);
            f.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void reportePorUbicaciónGeográficaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportesUbicacion F = new FormReportesUbicacion();
            F.ShowDialog();

        }

        private void reporteFinancieroToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void españolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gettextespañol();

            idioma = 1; 
        }

        private void inglesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            GetTextIngles();
            idioma = 2;

            
        }

        private void portuguesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetTextPortugues();

            idioma = 3;

        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistroProductos formRegistro = new FormRegistroProductos(idioma);
            formRegistro.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //    if (comboBoxAreaResponsable.SelectedItem == null)
            //    {
            //        MessageBox.Show("Seleccione un área para buscar.");
            //        return;
            //    }

            //    try
            //    {
            //        // Intentar convertir el valor seleccionado en un valor del enum
            //        AreaResponsable.AreaPosibles areaEnum = (AreaResponsable.AreaPosibles)Enum.Parse(
            //            typeof(AreaResponsable.AreaPosibles),
            //            comboBoxAreaResponsable.SelectedItem.ToString()
            //        );

            //        // Validación personalizada (opcional)
            //        if (!Enum.IsDefined(typeof(AreaResponsable.AreaPosibles), areaEnum))
            //        {
            //            throw new AreaResponsableInexistenteExpeption(comboBoxAreaResponsable.SelectedItem.ToString());
            //        }

            //        // Crear objeto AreaResponsable a partir del enum
            //        AreaResponsable area = new AreaResponsable(areaEnum);

            //        // Mostrar productos filtrados
            //        dataGridViewListadoProductosDefectuosos.DataSource = null;
            //        dataGridViewListadoProductosDefectuosos.DataSource = ListadoProductoDefectuosos.Instancia.FiltrarPorArea(area);
            //    }
            //    catch (AreaResponsableInexistenteExpeption ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Ocurrió un error: " + ex.Message);
            //    }
        }

        private void cambiarIdiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
 