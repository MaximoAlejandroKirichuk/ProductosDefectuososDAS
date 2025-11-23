using BE;
using BLL;
using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI;
using static BE.Seguimiento;

namespace _0_ProyectoDAS
{
    public partial class FormModificarSeguimiento : BaseForm
    {
        public FormModificarSeguimiento(Seguimiento seguimientoElegido)
        {
            InitializeComponent();
            this.seguimientoElegido = seguimientoElegido;
        }
        public GestorSeguimientoBLL gestorSeguimientoBLL = new GestorSeguimientoBLL();
        private Seguimiento seguimientoElegido; 

        
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int CodigoProducto = seguimientoElegido.CodigoProducto;
                int CodigoSeguimiento = seguimientoElegido.CodigoSeguimiento;
                DateTime fecha = dateTimePickerFecha.Value;
                string mensaje = txtMensajeModificar.Text;
                Usuario responsable = SessionManager.Instancia.UsuarioActivo;
                Visibilidad tipoVisibilidad = checkBox1.Checked ? Seguimiento.Visibilidad.Publica : Seguimiento.Visibilidad.Privada;
               
                Seguimiento nuevo = new Seguimiento(
                    fecha,
                    mensaje,
                    responsable,
                    CodigoProducto,
                    tipoVisibilidad,
                    CodigoSeguimiento
                );

                var respuesta = gestorSeguimientoBLL.ModificarSeguimiento(nuevo);
                if (!respuesta) throw new Exception("Ocurrio un error al modificar el seguimiento");
                MessageBox.Show("Se modifico correctamente el seguimiento");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message);
            }
           
        }

        private void FormModificarSeguimiento_Load(object sender, EventArgs e)
        {
            txtSeguimientoActual.Text = seguimientoElegido.ToString();
            txtMensajeModificar.Text = seguimientoElegido.Mensaje;
            dateTimePickerFecha.Value = seguimientoElegido.FechaRegistro;

            if(seguimientoElegido.TipoVisibilidad == Seguimiento.Visibilidad.Publica)
            {
                checkBox1.Checked = true;
            }
            if (seguimientoElegido.TipoVisibilidad == Seguimiento.Visibilidad.Privada)
            {
                checkBox1.Checked = false;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
