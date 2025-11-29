namespace _0_ProyectoDAS
{
    partial class FormCliente
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
            this.txtNroCuilCuit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewSeguimientos = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExportarSeguimiento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeguimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNroCuilCuit
            // 
            this.txtNroCuilCuit.Location = new System.Drawing.Point(33, 68);
            this.txtNroCuilCuit.Name = "txtNroCuilCuit";
            this.txtNroCuilCuit.Size = new System.Drawing.Size(100, 20);
            this.txtNroCuilCuit.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Tag = "F_Cliente_Lbl_Cuil/Cuit";
            this.label1.Text = "Cuil/Cuit";
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Location = new System.Drawing.Point(34, 148);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.Size = new System.Drawing.Size(721, 150);
            this.dataGridViewProductos.TabIndex = 2;
            this.dataGridViewProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductos_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Tag = "F_Cliente_Lbl_Productos";
            this.label2.Text = "Productos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Tag = "F_Cliente_Lbl_Seguimiento";
            this.label3.Text = "Seguimiento";
            // 
            // dataGridViewSeguimientos
            // 
            this.dataGridViewSeguimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSeguimientos.Location = new System.Drawing.Point(33, 338);
            this.dataGridViewSeguimientos.Name = "dataGridViewSeguimientos";
            this.dataGridViewSeguimientos.Size = new System.Drawing.Size(721, 150);
            this.dataGridViewSeguimientos.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 8;
            this.label5.Tag = "F_Cliente_Lbl_IngreseDatosABuscar";
            this.label5.Text = "Ingrese datos a buscar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Tag = "F_Cliente_Btn_Buscar";
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExportarSeguimiento
            // 
            this.btnExportarSeguimiento.Enabled = false;
            this.btnExportarSeguimiento.Location = new System.Drawing.Point(661, 525);
            this.btnExportarSeguimiento.Name = "btnExportarSeguimiento";
            this.btnExportarSeguimiento.Size = new System.Drawing.Size(94, 37);
            this.btnExportarSeguimiento.TabIndex = 10;
            this.btnExportarSeguimiento.Tag = "F_Cliente_Btn_Buscar";
            this.btnExportarSeguimiento.Text = "Exportar seguimiento";
            this.btnExportarSeguimiento.UseVisualStyleBackColor = true;
            this.btnExportarSeguimiento.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(884, 648);
            this.Controls.Add(this.btnExportarSeguimiento);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewSeguimientos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewProductos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNroCuilCuit);
            this.Name = "FormCliente";
            this.Text = "FormCliente";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeguimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNroCuilCuit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewSeguimientos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExportarSeguimiento;
    }
}