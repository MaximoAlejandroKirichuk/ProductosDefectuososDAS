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
    public partial class FormCambiarContrasenia : Form
    {
        public FormCambiarContrasenia()
        {
            InitializeComponent();
        }

        GestorUsuarioBLL usuarioBLL = new GestorUsuarioBLL();
        private void FormCambiarContrasenia_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text;
                string contraseniaActual = txtContraseniaActual.Text;
                string contraseniaNueva = txtContraseniaNueva.Text;

                var respuesta = usuarioBLL.CambiarContrasenia(SesionActiva.Instancia.UsuarioActivo, contraseniaNueva);

                if (!respuesta) throw new Exception("Ocurrio un error al cambiar la contraseña");
                MessageBox.Show("Se logro cambiar correctamente la contraseña");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un erorr al cambiar la contraseña: " + ex.Message);
                Close();
            }
        }
    }
}
