using BE;
using BLL;
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
    public partial class FormAbmEmpleados : Form
    {
        public FormAbmEmpleados()
        {
            InitializeComponent();
        }
        private GestorUsuarioBLL gestorUsuarioBLL = new GestorUsuarioBLL();
        private GestorEmpleadoBLL gestorEmpleadoBLL = new GestorEmpleadoBLL();
        private void FormAbmEmpleados_Load(object sender, EventArgs e)
        {
            ActualizarData();
        }

        public void ActualizarData()
        {
            DgvEmpleados.DataSource = null;
            //DgvEmpleados.DataSource = null;

        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreCompleto = txtNombreCompleto.Text;
                string email = txtEmail.Text;
                string contrasena = TxtContraseña.Text;
                if(gestorUsuarioBLL.BuscarUsuarioPorMail(email) != null) throw new Exception("Ya hiciste un mail asociado a esta cuenta");

                var nuevoEmpleado = new Empleado(nombreCompleto, email, contrasena, RolesUsuarios.Empleado);
                var respuesta = gestorEmpleadoBLL.Agregar(nuevoEmpleado);
                if (!respuesta) throw new Exception("Ocurrio un error al agregar");
                MessageBox.Show("Se pudo agregar el empleado");
                ActualizarData();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo agregar el empleado");
            }
        }
    }
}
