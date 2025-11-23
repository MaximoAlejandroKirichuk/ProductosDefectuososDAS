namespace _0_ProyectoDAS
{
    partial class FormAdmin
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
            this.dgvLogs = new System.Windows.Forms.DataGridView();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrarCriticidad = new System.Windows.Forms.Button();
            this.cmbCriticidad = new System.Windows.Forms.ComboBox();
            this.btnChart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLogs
            // 
            this.dgvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogs.Location = new System.Drawing.Point(25, 65);
            this.dgvLogs.Name = "dgvLogs";
            this.dgvLogs.Size = new System.Drawing.Size(720, 276);
            this.dgvLogs.TabIndex = 0;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(173, 13);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Desde esta fecha:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(379, 14);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(603, 400);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(102, 23);
            this.btnExportar.TabIndex = 4;
            this.btnExportar.Text = "Exportar a csv";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hasta esta fecha:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(173, 39);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 5;
            // 
            // btnFiltrarCriticidad
            // 
            this.btnFiltrarCriticidad.Location = new System.Drawing.Point(25, 387);
            this.btnFiltrarCriticidad.Name = "btnFiltrarCriticidad";
            this.btnFiltrarCriticidad.Size = new System.Drawing.Size(130, 23);
            this.btnFiltrarCriticidad.TabIndex = 7;
            this.btnFiltrarCriticidad.Text = "Filtrar por crticidad";
            this.btnFiltrarCriticidad.UseVisualStyleBackColor = true;
            this.btnFiltrarCriticidad.Click += new System.EventHandler(this.btnFiltrarCriticidad_Click);
            // 
            // cmbCriticidad
            // 
            this.cmbCriticidad.FormattingEnabled = true;
            this.cmbCriticidad.Items.AddRange(new object[] {
            "Baja",
            "Media",
            "Alta"});
            this.cmbCriticidad.Location = new System.Drawing.Point(25, 360);
            this.cmbCriticidad.Name = "cmbCriticidad";
            this.cmbCriticidad.Size = new System.Drawing.Size(266, 21);
            this.cmbCriticidad.TabIndex = 8;
            // 
            // btnChart
            // 
            this.btnChart.Location = new System.Drawing.Point(603, 371);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(102, 23);
            this.btnChart.TabIndex = 9;
            this.btnChart.Text = "Observar Chart";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChart);
            this.Controls.Add(this.cmbCriticidad);
            this.Controls.Add(this.btnFiltrarCriticidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.dgvLogs);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLogs;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button btnFiltrarCriticidad;
        private System.Windows.Forms.ComboBox cmbCriticidad;
        private System.Windows.Forms.Button btnChart;
    }
}