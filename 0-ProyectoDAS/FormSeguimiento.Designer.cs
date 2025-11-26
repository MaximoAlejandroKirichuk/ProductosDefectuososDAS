namespace UI
{
    partial class FormSeguimiento
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
            this.DGVSeguimientos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.txtAgregarPaso = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.DGVProductos = new System.Windows.Forms.DataGridView();
            this.btnCondicionProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSeguimientos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVSeguimientos
            // 
            this.DGVSeguimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSeguimientos.Location = new System.Drawing.Point(12, 12);
            this.DGVSeguimientos.Name = "DGVSeguimientos";
            this.DGVSeguimientos.Size = new System.Drawing.Size(687, 212);
            this.DGVSeguimientos.TabIndex = 2;
            this.DGVSeguimientos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSeguimientos_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.BtnAgregar);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.dateTimePickerFecha);
            this.groupBox1.Controls.Add(this.txtAgregarPaso);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(12, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 390);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "F_Seguimiento_GroupBox_Seguimiento";
            this.groupBox1.Text = "Seguimiento ";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(242, 336);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(162, 22);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Tag = "F_Seguimiento_CheckBox_SeguimientoPublico";
            this.checkBox1.Text = "Seguimiento Publico";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(547, 325);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(89, 46);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Tag = "F_Seguimiento_Btn_Guardar";
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(453, 325);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(88, 46);
            this.BtnAgregar.TabIndex = 13;
            this.BtnAgregar.Tag = "F_Seguimiento_Btn_Agregar";
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.DarkGray;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(675, 184);
            this.listBox1.TabIndex = 9;
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFecha.Location = new System.Drawing.Point(10, 336);
            this.dateTimePickerFecha.MaxDate = new System.DateTime(2040, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFecha.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(226, 20);
            this.dateTimePickerFecha.TabIndex = 10;
            // 
            // txtAgregarPaso
            // 
            this.txtAgregarPaso.BackColor = System.Drawing.Color.DarkGray;
            this.txtAgregarPaso.Location = new System.Drawing.Point(10, 239);
            this.txtAgregarPaso.Multiline = true;
            this.txtAgregarPaso.Name = "txtAgregarPaso";
            this.txtAgregarPaso.Size = new System.Drawing.Size(671, 64);
            this.txtAgregarPaso.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 216);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(180, 20);
            this.label13.TabIndex = 7;
            this.label13.Tag = "F_Seguimiento_Lbl_PasoAlSeguimiento";
            this.label13.Text = "Paso al seguiemiento";
            // 
            // DGVProductos
            // 
            this.DGVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProductos.Location = new System.Drawing.Point(732, 12);
            this.DGVProductos.Name = "DGVProductos";
            this.DGVProductos.Size = new System.Drawing.Size(557, 421);
            this.DGVProductos.TabIndex = 13;
            this.DGVProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVProductos_CellClick);
            // 
            // btnCondicionProducto
            // 
            this.btnCondicionProducto.Location = new System.Drawing.Point(851, 540);
            this.btnCondicionProducto.Name = "btnCondicionProducto";
            this.btnCondicionProducto.Size = new System.Drawing.Size(158, 46);
            this.btnCondicionProducto.TabIndex = 14;
            this.btnCondicionProducto.Tag = "F_Seguimiento_Btn_CambiarCondicionDelProducto";
            this.btnCondicionProducto.Text = "Cambiar condicion del producto";
            this.btnCondicionProducto.UseVisualStyleBackColor = true;
            this.btnCondicionProducto.Click += new System.EventHandler(this.btnCambiarCondicionProducto_Click);
            // 
            // FormSeguimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1301, 632);
            this.Controls.Add(this.btnCondicionProducto);
            this.Controls.Add(this.DGVProductos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGVSeguimientos);
            this.Name = "FormSeguimiento";
            this.Text = "FormSeguimiento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSeguimiento_FormClosing);
            this.Load += new System.EventHandler(this.FormSeguimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSeguimientos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVSeguimientos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.TextBox txtAgregarPaso;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView DGVProductos;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnCondicionProducto;
    }
}