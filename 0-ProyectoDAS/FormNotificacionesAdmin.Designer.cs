using System;
using System.Windows.Forms;
using System.Drawing;

namespace _0_ProyectoDAS
{
    partial class FormNotificacionesAdmin
    {
        private System.ComponentModel.IContainer components = null;
        private FlowLayoutPanel panelNotificaciones;
        private Label lblTitulo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelNotificaciones = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = DockStyle.Top;
            this.lblTitulo.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = Color.FromArgb(45, 45, 45);
            this.lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            this.lblTitulo.Text = "Notificaciones del Sistema";
            this.lblTitulo.Height = 60;
            this.lblTitulo.BackColor = Color.FromArgb(240, 240, 240);
            this.lblTitulo.Padding = new Padding(0, 10, 0, 10);

            // 
            // panelNotificaciones
            // 
            this.panelNotificaciones.AutoScroll = true;
            this.panelNotificaciones.Dock = DockStyle.Fill;
            this.panelNotificaciones.FlowDirection = FlowDirection.TopDown;
            this.panelNotificaciones.Padding = new Padding(20);
            this.panelNotificaciones.WrapContents = false;
            this.panelNotificaciones.BackColor = Color.WhiteSmoke;

            // 
            // FormNotificacionesAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.panelNotificaciones);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNotificacionesAdmin";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Centro de Notificaciones";
            this.ResumeLayout(false);
        }

        #endregion
    }
}
