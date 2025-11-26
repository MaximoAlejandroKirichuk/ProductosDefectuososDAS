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
            // panelNotificaciones
            // 
            this.panelNotificaciones.AutoScroll = true;
            this.panelNotificaciones.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelNotificaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNotificaciones.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelNotificaciones.Location = new System.Drawing.Point(0, 52);
            this.panelNotificaciones.Name = "panelNotificaciones";
            this.panelNotificaciones.Padding = new System.Windows.Forms.Padding(17);
            this.panelNotificaciones.Size = new System.Drawing.Size(729, 381);
            this.panelNotificaciones.TabIndex = 0;
            this.panelNotificaciones.WrapContents = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(0, 9, 0, 9);
            this.lblTitulo.Size = new System.Drawing.Size(729, 52);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Tag = "F_NotificacionesAdmin_Lbl_NotificacionesDelSistema";
            this.lblTitulo.Text = "Notificaciones del Sistema";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormNotificacionesAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(729, 433);
            this.Controls.Add(this.panelNotificaciones);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNotificacionesAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centro de Notificaciones";
            this.Load += new System.EventHandler(this.FormNotificacionesAdmin_Load_1);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
