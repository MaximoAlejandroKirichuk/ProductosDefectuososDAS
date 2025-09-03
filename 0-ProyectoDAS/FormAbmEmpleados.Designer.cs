namespace _0_ProyectoDAS
{
    partial class FormAbmEmpleados
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComboBoxRol = new System.Windows.Forms.ComboBox();
            this.LRol = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.LEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.LContraseña = new System.Windows.Forms.Label();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.DgvEmpleados = new System.Windows.Forms.DataGridView();
            this.btnModificarEmpleado = new System.Windows.Forms.Button();
            this.btnBorrarEmpleado = new System.Windows.Forms.Button();
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ComboBoxRol);
            this.groupBox1.Controls.Add(this.LRol);
            this.groupBox1.Controls.Add(this.LNombre);
            this.groupBox1.Controls.Add(this.txtNombreCompleto);
            this.groupBox1.Controls.Add(this.LEmail);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.LContraseña);
            this.groupBox1.Controls.Add(this.TxtContraseña);
            this.groupBox1.Location = new System.Drawing.Point(104, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 252);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Propiedades";
            // 
            // ComboBoxRol
            // 
            this.ComboBoxRol.FormattingEnabled = true;
            this.ComboBoxRol.Location = new System.Drawing.Point(41, 208);
            this.ComboBoxRol.Name = "ComboBoxRol";
            this.ComboBoxRol.Size = new System.Drawing.Size(100, 21);
            this.ComboBoxRol.TabIndex = 11;
            // 
            // LRol
            // 
            this.LRol.AutoSize = true;
            this.LRol.Location = new System.Drawing.Point(38, 192);
            this.LRol.Name = "LRol";
            this.LRol.Size = new System.Drawing.Size(23, 13);
            this.LRol.TabIndex = 10;
            this.LRol.Text = "Rol";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(38, 18);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(90, 13);
            this.LNombre.TabIndex = 0;
            this.LNombre.Text = "Nombre completo";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(41, 35);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCompleto.TabIndex = 1;
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Location = new System.Drawing.Point(38, 77);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(32, 13);
            this.LEmail.TabIndex = 2;
            this.LEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(41, 94);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // LContraseña
            // 
            this.LContraseña.AutoSize = true;
            this.LContraseña.Location = new System.Drawing.Point(38, 134);
            this.LContraseña.Name = "LContraseña";
            this.LContraseña.Size = new System.Drawing.Size(61, 13);
            this.LContraseña.TabIndex = 8;
            this.LContraseña.Text = "Contraseña";
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Location = new System.Drawing.Point(41, 150);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(100, 20);
            this.TxtContraseña.TabIndex = 9;
            // 
            // DgvEmpleados
            // 
            this.DgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEmpleados.Location = new System.Drawing.Point(323, 49);
            this.DgvEmpleados.Name = "DgvEmpleados";
            this.DgvEmpleados.Size = new System.Drawing.Size(509, 441);
            this.DgvEmpleados.TabIndex = 23;
            // 
            // btnModificarEmpleado
            // 
            this.btnModificarEmpleado.Location = new System.Drawing.Point(137, 386);
            this.btnModificarEmpleado.Name = "btnModificarEmpleado";
            this.btnModificarEmpleado.Size = new System.Drawing.Size(108, 23);
            this.btnModificarEmpleado.TabIndex = 22;
            this.btnModificarEmpleado.Text = "Modificar empleado";
            this.btnModificarEmpleado.UseVisualStyleBackColor = true;
            // 
            // btnBorrarEmpleado
            // 
            this.btnBorrarEmpleado.Location = new System.Drawing.Point(137, 357);
            this.btnBorrarEmpleado.Name = "btnBorrarEmpleado";
            this.btnBorrarEmpleado.Size = new System.Drawing.Size(108, 23);
            this.btnBorrarEmpleado.TabIndex = 21;
            this.btnBorrarEmpleado.Text = "Borrar empleado";
            this.btnBorrarEmpleado.UseVisualStyleBackColor = true;
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(137, 328);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(108, 23);
            this.btnAgregarEmpleado.TabIndex = 20;
            this.btnAgregarEmpleado.Text = "Agregar empleado";
            this.btnAgregarEmpleado.UseVisualStyleBackColor = true;
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.btnAgregarEmpleado_Click);
            // 
            // FormAbmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 555);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvEmpleados);
            this.Controls.Add(this.btnModificarEmpleado);
            this.Controls.Add(this.btnBorrarEmpleado);
            this.Controls.Add(this.btnAgregarEmpleado);
            this.Name = "FormAbmEmpleados";
            this.Text = "FormAbmEmpleados";
            this.Load += new System.EventHandler(this.FormAbmEmpleados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label LEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label LContraseña;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.DataGridView DgvEmpleados;
        private System.Windows.Forms.Button btnModificarEmpleado;
        private System.Windows.Forms.Button btnBorrarEmpleado;
        private System.Windows.Forms.Button btnAgregarEmpleado;
        private System.Windows.Forms.Label LRol;
        private System.Windows.Forms.ComboBox ComboBoxRol;
    }
}