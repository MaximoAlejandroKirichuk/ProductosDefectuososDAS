
using _0_ProyectoDAS.Idiomas;
using UI;
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
using _0_ProyectoDAS;
using BE;
using BLL;
using Servicios;
using BE.ObserverIdioma;

namespace UI
{
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        

        public int idioma;

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAyuda ventanaAyuda = new FormAyuda(idioma);
            ventanaAyuda.MdiParent = this;
            ventanaAyuda.WindowState = FormWindowState.Maximized;
            ventanaAyuda.Show();
        }



        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListadoProductos formListado = new FormListadoProductos();
            formListado.MdiParent = this; 
            formListado.WindowState = FormWindowState.Maximized;
            formListado.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }
       
        private void MainForm_Load(object sender, EventArgs e)
        {
            
            var usuario = SessionManager.Instancia.UsuarioActivo;

            // Validar usuario activo
            if (usuario == null)
            {
                MessageBox.Show("No hay un usuario activo. Inicie sesión nuevamente.");
                this.Close();
                return;
            }

            // Si es administrador debe cargar ventana de notificaciones
            if (usuario is Administrador admin)
            {
                FormNotificacionesAdmin frmNotif = new FormNotificacionesAdmin(admin);
                frmNotif.ShowDialog();
            }

            // Obtener los modulos permitidos desde su Composite
            var modulos = usuario.Permisos?.ObtenerModulos() ?? new List<ModuloSistema>();

            AplicarPermisos(modulos);
        }

        private void AplicarPermisos(List<ModuloSistema> modulos)
        {
            registrarToolStripMenuItem.Visible = modulos.Contains(ModuloSistema.Productos);
            seguimientoToolStripMenuItem.Visible = modulos.Contains(ModuloSistema.Seguimientos);
            ClientesToolStripMenuItem.Visible = modulos.Contains(ModuloSistema.Clientes);
            empleadosToolStripMenuItem1.Visible = modulos.Contains(ModuloSistema.Empleados);
            AdministradortoolStripMenuItem.Visible = modulos.Contains(ModuloSistema.Bitacora);
            //AccesibilidadToolStripMenuItem.Visible = true;
            ayudaToolStripMenuItem.Visible = true;
            cerrarSesiónToolStripMenuItem.Visible = true;
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
            SessionManager.Instancia.CerrarSesion();
            MessageBox.Show("Se cerro sesión");
            this.Close();
            Login form = new Login();
            form.Show();
        }

        

        private void seguimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSeguimiento f = new FormSeguimiento();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void reportePorUbicaciónGeográficaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // El ID "es" (o vacío) usará el archivo base Res.resx
            IIdioma idioma = new BE.Idioma { Nombre = "Español", Id = "es" };

            Servicios.LanguageManager.Instance.CambiarIdioma(idioma);
        }

        private void reporteFinancieroToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void españolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IIdioma idioma = new BE.Idioma { Nombre = "Español", Id = "es" };

            Servicios.LanguageManager.Instance.CambiarIdioma(idioma);
        }

        private void inglesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // objeto con el ID exacto que coincide con tu archivo Res.en.resx
            IIdioma idioma = new BE.Idioma { Nombre = "English", Id = "en" };

            Servicios.LanguageManager.Instance.CambiarIdioma(idioma);
        }

        private void portuguesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistroProductos formRegistro = new FormRegistroProductos();
            formRegistro.MdiParent = this;
            formRegistro.WindowState = FormWindowState.Maximized;
            formRegistro.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
          
        }

        private void cambiarIdiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormABMCliente form = new FormABMCliente();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAbmEmpleados form = new FormAbmEmpleados();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void modificarSeguimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCambiarContrasenia form = new FormCambiarContrasenia();
            form.ShowDialog();
        }

        private void AdministradortoolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdmin form = new FormAdmin();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }
    }
}
 