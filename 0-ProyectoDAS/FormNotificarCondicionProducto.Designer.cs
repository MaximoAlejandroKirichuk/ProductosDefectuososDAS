namespace _0_ProyectoDAS
{
    partial class FormNotificarCondicionProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCondicionActual = new System.Windows.Forms.TextBox();
            this.cmbCondicionProducto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMensajeNotificar = new System.Windows.Forms.TextBox();
            this.BtnNotificar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSeguimientoActual = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCondicionActual);
            this.groupBox2.Controls.Add(this.cmbCondicionProducto);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtMensajeNotificar);
            this.groupBox2.Controls.Add(this.BtnNotificar);
            this.groupBox2.Location = new System.Drawing.Point(111, 347);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(599, 379);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Tag = "F_NotificarCondicionProducto_GroupBox_NotificarAlAdministradorLaCondicionDelProdu" +
    "cto";
            this.groupBox2.Text = "Notificar al administrador condicion de producto ";
            // 
            // txtCondicionActual
            // 
            this.txtCondicionActual.Enabled = false;
            this.txtCondicionActual.Location = new System.Drawing.Point(357, 36);
            this.txtCondicionActual.Name = "txtCondicionActual";
            this.txtCondicionActual.Size = new System.Drawing.Size(100, 20);
            this.txtCondicionActual.TabIndex = 31;
            // 
            // cmbCondicionProducto
            // 
            this.cmbCondicionProducto.FormattingEnabled = true;
            this.cmbCondicionProducto.Location = new System.Drawing.Point(10, 78);
            this.cmbCondicionProducto.Name = "cmbCondicionProducto";
            this.cmbCondicionProducto.Size = new System.Drawing.Size(240, 21);
            this.cmbCondicionProducto.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 20);
            this.label2.TabIndex = 29;
            this.label2.Tag = "F_NotificarCondicionProducto_Lbl_CambioDeCondicionDeProductoActual";
            this.label2.Text = "Cambio de condicion de producto actual:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 28;
            this.label3.Tag = "F_NotificarCondicionProducto_Lbl_MensajeANotificar";
            this.label3.Text = "Mensaje a notificar";
            // 
            // txtMensajeNotificar
            // 
            this.txtMensajeNotificar.BackColor = System.Drawing.Color.DarkGray;
            this.txtMensajeNotificar.Location = new System.Drawing.Point(10, 157);
            this.txtMensajeNotificar.Multiline = true;
            this.txtMensajeNotificar.Name = "txtMensajeNotificar";
            this.txtMensajeNotificar.Size = new System.Drawing.Size(573, 164);
            this.txtMensajeNotificar.TabIndex = 26;
            // 
            // BtnNotificar
            // 
            this.BtnNotificar.Location = new System.Drawing.Point(449, 327);
            this.BtnNotificar.Name = "BtnNotificar";
            this.BtnNotificar.Size = new System.Drawing.Size(134, 46);
            this.BtnNotificar.TabIndex = 23;
            this.BtnNotificar.Tag = "F_NotificarCondicionProducto_Btn_Notificar";
            this.BtnNotificar.Text = "Notificar";
            this.BtnNotificar.UseVisualStyleBackColor = true;
            this.BtnNotificar.Click += new System.EventHandler(this.BtnNotificar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSeguimientoActual);
            this.groupBox1.Location = new System.Drawing.Point(87, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 284);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "F_NotificarCondicionProducto_GroupBox_seguimiento";
            this.groupBox1.Text = "Seguimiento ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 20);
            this.label1.TabIndex = 17;
            this.label1.Tag = "F_NotificarCondicionProducto_Lbl_SeguimientoActualDelProducto";
            this.label1.Text = "Seguimiento actual del producto";
            // 
            // txtSeguimientoActual
            // 
            this.txtSeguimientoActual.BackColor = System.Drawing.Color.DarkGray;
            this.txtSeguimientoActual.Location = new System.Drawing.Point(10, 49);
            this.txtSeguimientoActual.Multiline = true;
            this.txtSeguimientoActual.Name = "txtSeguimientoActual";
            this.txtSeguimientoActual.Size = new System.Drawing.Size(697, 182);
            this.txtSeguimientoActual.TabIndex = 16;
            // 
            // FormNotificarCondicionProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(918, 797);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormNotificarCondicionProducto";
            this.Text = "FormNotificarCondicionProducto";
            this.Load += new System.EventHandler(this.FormNotificarCondicionProducto_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMensajeNotificar;
        private System.Windows.Forms.Button BtnNotificar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSeguimientoActual;
        private System.Windows.Forms.TextBox txtCondicionActual;
        private System.Windows.Forms.ComboBox cmbCondicionProducto;
        private System.Windows.Forms.Label label2;
    }
}