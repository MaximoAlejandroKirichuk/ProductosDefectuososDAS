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
            
        }

        private void CargarNotificaciones(List<Notificacion> pendientes)
        {
            panelNotificaciones.Controls.Clear();
            panelNotificaciones.AutoScroll = true;
            panelNotificaciones.BackColor = Color.White;

            if (pendientes == null || pendientes.Count == 0)
            {
                Label lblVacio = new Label
                {
                    Text = "No hay notificaciones pendientes",
                    AutoSize = true,
                    Font = new Font("Segoe UI", 11, FontStyle.Italic),
                    ForeColor = Color.Gray,
                };

                // Centrado manual
                lblVacio.Location = new Point(
                    (panelNotificaciones.Width - lblVacio.Width) / 2,
                    (panelNotificaciones.Height - lblVacio.Height) / 2
                );

                lblVacio.Anchor = AnchorStyles.None;

                panelNotificaciones.Controls.Add(lblVacio);
                panelNotificaciones.Resize += (s, e) =>
                {
                    // Recalcula el centrado al redimensionar
                    lblVacio.Location = new Point(
                        (panelNotificaciones.Width - lblVacio.Width) / 2,
                        (panelNotificaciones.Height - lblVacio.Height) / 2
                    );
                };

                return;
            }

            // Caso normal con notificaciones
            foreach (var notificacion in pendientes)
            {
                var control = new UserControl1();
                control.SetNotificacion(notificacion);
                control.Margin = new Padding(10);
                panelNotificaciones.Controls.Add(control);
            }
        }


        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            servicio.MarcarTodasComoLeidas(admin);
        }

        private void FormNotificacionesAdmin_Load_1(object sender, EventArgs e)
        {
            try
            {
                List<Notificacion> pendientes = servicio.ObtenerPendientes(admin);
                CargarNotificaciones(pendientes);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar notificaciones: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
