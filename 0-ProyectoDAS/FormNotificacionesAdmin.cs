using BE;
using BLL;
using Servicios;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace _0_ProyectoDAS
{
    public partial class FormNotificacionesAdmin : Form
    {
        private readonly ServicioNotificacion servicio;
        private readonly Usuario admin;

        public FormNotificacionesAdmin(Usuario admin)
        {
            InitializeComponent();
            this.admin = admin;
            this.servicio = new ServicioNotificacion();
            this.Text = "Notificaciones del sistema";
            this.Size = new Size(600, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        private void FormNotificacionesAdmin_Load(object sender, EventArgs e)
        {
            CargarNotificaciones();
        }

        private void CargarNotificaciones()
        {
            List<Notificacion> pendientes = servicio.ObtenerPendientes(admin);

            panelNotificaciones.Controls.Clear();

            if (pendientes.Count == 0)
            {
                Label lblVacio = new Label
                {
                    Text = "No hay notificaciones pendientes 😊",
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 11, FontStyle.Italic),
                    ForeColor = Color.Gray
                };
                panelNotificaciones.Controls.Add(lblVacio);
                return;
            }

            foreach (var notificacion in pendientes)
            {
                var control = new UserControl1();
                control.SetNotificacion(notificacion);
                panelNotificaciones.Controls.Add(control);
            }

            // Marcarlas como leídas después de mostrarlas
            servicio.MarcarTodasComoLeidas(admin);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            CargarNotificaciones();
        }
    }
}
