using System;
using System.Drawing;
using System.Windows.Forms;

namespace _0_ProyectoDAS
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
            this.Cursor = Cursors.Hand;

            this.MouseEnter += (s, args) => this.BackColor = Color.LightYellow;
            this.MouseLeave += (s, args) => this.BackColor = Color.WhiteSmoke;
        }


        // Método para recibir y mostrar la notificación
        public void SetNotificacion(BE.Notificacion notificacion)
        {
            lblMensaje.Text = notificacion.Mensaje;
            lblFecha.Text = notificacion.Fecha.ToString("g");
        }
    }
}
