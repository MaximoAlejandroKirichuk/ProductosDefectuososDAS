namespace UI
{
    partial class FormListadoProductos
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxProblemaEntrada = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDownCostoProducto = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewListadoProductosDefectuosos = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownAlto = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAncho = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLargo = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxCondicionProducto = new System.Windows.Forms.ComboBox();
            this.numericUpDownCostoPerdidaMateriaPrima = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownCostoManoObra = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaEstimadaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaRecibida = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCostoProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadoProductosDefectuosos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAncho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLargo)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCostoPerdidaMateriaPrima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCostoManoObra)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1008, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 43);
            this.button1.TabIndex = 1;
            this.button1.Tag = "F_ListadoProductos_Btn_Actualizar";
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(1008, 45);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(137, 43);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Tag = "F_ListadoProductos_Btn_Modificar";
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(1008, 147);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(137, 43);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Tag = "F_ListadoProductos_Btn_Eliminar";
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 4;
            this.label1.Tag = "F_ListadoProductos_Lbl_CodigoProducto";
            this.label1.Text = "Codigo Producto";
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProducto.Location = new System.Drawing.Point(39, 62);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(186, 26);
            this.txtCodigoProducto.TabIndex = 5;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(40, 133);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(186, 26);
            this.txtNombreProducto.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 6;
            this.label2.Tag = "F_ListadoProductos_Lbl_NombreProducto";
            this.label2.Text = "Nombre Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 8;
            this.label3.Tag = "F_ListadoProductos_Lbl_CostoProducto";
            this.label3.Text = "Costo Producto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(49, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 20);
            this.label10.TabIndex = 14;
            this.label10.Tag = "F_ListadoProductos_Lbl_ProblemaDeEntrada";
            this.label10.Text = "Problema de Entrada";
            // 
            // comboBoxProblemaEntrada
            // 
            this.comboBoxProblemaEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProblemaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProblemaEntrada.FormattingEnabled = true;
            this.comboBoxProblemaEntrada.Items.AddRange(new object[] {
            "Manufactura",
            "Deteriodo de almacen",
            "Accidente de tránsito"});
            this.comboBoxProblemaEntrada.Location = new System.Drawing.Point(40, 275);
            this.comboBoxProblemaEntrada.Name = "comboBoxProblemaEntrada";
            this.comboBoxProblemaEntrada.Size = new System.Drawing.Size(186, 28);
            this.comboBoxProblemaEntrada.TabIndex = 33;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDownCostoProducto);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBoxProblemaEntrada);
            this.groupBox2.Controls.Add(this.txtNombreProducto);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtCodigoProducto);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(282, 340);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 322);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Tag = "F_ListadoProductos_GroupBox_InformacionProducto";
            this.groupBox2.Text = "Información Producto";
            // 
            // numericUpDownCostoProducto
            // 
            this.numericUpDownCostoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownCostoProducto.Location = new System.Drawing.Point(40, 201);
            this.numericUpDownCostoProducto.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.numericUpDownCostoProducto.Name = "numericUpDownCostoProducto";
            this.numericUpDownCostoProducto.Size = new System.Drawing.Size(185, 26);
            this.numericUpDownCostoProducto.TabIndex = 36;
            // 
            // dataGridViewListadoProductosDefectuosos
            // 
            this.dataGridViewListadoProductosDefectuosos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListadoProductosDefectuosos.Location = new System.Drawing.Point(12, 9);
            this.dataGridViewListadoProductosDefectuosos.Name = "dataGridViewListadoProductosDefectuosos";
            this.dataGridViewListadoProductosDefectuosos.Size = new System.Drawing.Size(974, 325);
            this.dataGridViewListadoProductosDefectuosos.TabIndex = 36;
            this.dataGridViewListadoProductosDefectuosos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListadoProductosDefectuosos_CellClick);
            this.dataGridViewListadoProductosDefectuosos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListadoProductosDefectuosos_CellContentClick);
            this.dataGridViewListadoProductosDefectuosos.SelectionChanged += new System.EventHandler(this.dataGridViewListadoProductosDefectuosos_SelectionChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(20, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 20);
            this.label12.TabIndex = 12;
            this.label12.Tag = "F_ListadoProductos_Lbl_Alto";
            this.label12.Text = "Alto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(20, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 20);
            this.label11.TabIndex = 14;
            this.label11.Tag = "F_ListadoProductos_Lbl_Ancho";
            this.label11.Text = "Ancho";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(20, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 15;
            this.label6.Tag = "F_ListadoProductos_Lbl_Largo";
            this.label6.Text = "Largo";
            // 
            // numericUpDownAlto
            // 
            this.numericUpDownAlto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownAlto.Location = new System.Drawing.Point(118, 66);
            this.numericUpDownAlto.Name = "numericUpDownAlto";
            this.numericUpDownAlto.Size = new System.Drawing.Size(140, 22);
            this.numericUpDownAlto.TabIndex = 21;
            // 
            // numericUpDownAncho
            // 
            this.numericUpDownAncho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownAncho.Location = new System.Drawing.Point(118, 131);
            this.numericUpDownAncho.Name = "numericUpDownAncho";
            this.numericUpDownAncho.Size = new System.Drawing.Size(140, 22);
            this.numericUpDownAncho.TabIndex = 22;
            // 
            // numericUpDownLargo
            // 
            this.numericUpDownLargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownLargo.Location = new System.Drawing.Point(118, 201);
            this.numericUpDownLargo.Name = "numericUpDownLargo";
            this.numericUpDownLargo.Size = new System.Drawing.Size(140, 22);
            this.numericUpDownLargo.TabIndex = 23;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDownLargo);
            this.groupBox3.Controls.Add(this.numericUpDownAlto);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.numericUpDownAncho);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 340);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 322);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Tag = "F_ListadoProductos_GroupBox_Dimensiones";
            this.groupBox3.Text = "Dimensiones";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBoxCondicionProducto);
            this.groupBox1.Controls.Add(this.numericUpDownCostoPerdidaMateriaPrima);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.numericUpDownCostoManoObra);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(805, 340);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 322);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "F_ListadoProductos_GroupBox_EstadoDelProducto";
            this.groupBox1.Text = "Estado del producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(13, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(334, 20);
            this.label7.TabIndex = 11;
            this.label7.Tag = "F_ListadoProductos_Lbl_CostoDeManoDeObraParaRecuperar";
            this.label7.Text = "Costo de mano de obra para recuperar";
            // 
            // comboBoxCondicionProducto
            // 
            this.comboBoxCondicionProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCondicionProducto.FormattingEnabled = true;
            this.comboBoxCondicionProducto.Items.AddRange(new object[] {
            "Nuevo",
            "Defectuoso",
            "EnReparacion",
            "Reparado",
            "Desechado",
            "",
            ""});
            this.comboBoxCondicionProducto.Location = new System.Drawing.Point(110, 66);
            this.comboBoxCondicionProducto.Name = "comboBoxCondicionProducto";
            this.comboBoxCondicionProducto.Size = new System.Drawing.Size(140, 28);
            this.comboBoxCondicionProducto.TabIndex = 6;
            // 
            // numericUpDownCostoPerdidaMateriaPrima
            // 
            this.numericUpDownCostoPerdidaMateriaPrima.Enabled = false;
            this.numericUpDownCostoPerdidaMateriaPrima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownCostoPerdidaMateriaPrima.Location = new System.Drawing.Point(110, 162);
            this.numericUpDownCostoPerdidaMateriaPrima.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.numericUpDownCostoPerdidaMateriaPrima.Name = "numericUpDownCostoPerdidaMateriaPrima";
            this.numericUpDownCostoPerdidaMateriaPrima.Size = new System.Drawing.Size(140, 26);
            this.numericUpDownCostoPerdidaMateriaPrima.TabIndex = 9;
            this.numericUpDownCostoPerdidaMateriaPrima.ValueChanged += new System.EventHandler(this.numericUpDownCostoPerdidaMateriaPrima_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(13, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(336, 20);
            this.label8.TabIndex = 8;
            this.label8.Tag = "F_ListadoProductos_Lbl_CostoDeMateriaPrimaParaRecuperar";
            this.label8.Text = "Costo de materia prima para recuperar";
            // 
            // numericUpDownCostoManoObra
            // 
            this.numericUpDownCostoManoObra.Enabled = false;
            this.numericUpDownCostoManoObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownCostoManoObra.Location = new System.Drawing.Point(110, 256);
            this.numericUpDownCostoManoObra.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.numericUpDownCostoManoObra.Name = "numericUpDownCostoManoObra";
            this.numericUpDownCostoManoObra.Size = new System.Drawing.Size(140, 26);
            this.numericUpDownCostoManoObra.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(79, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(202, 20);
            this.label13.TabIndex = 7;
            this.label13.Tag = "F_ListadoProductos_Lbl_CondicionDelProducto";
            this.label13.Text = "Condicion del producto";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.dateTimePickerFechaEstimadaDevolucion);
            this.groupBox4.Controls.Add(this.comboBoxCliente);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.dateTimePickerFechaRecibida);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(552, 340);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(247, 322);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 20);
            this.label4.TabIndex = 45;
            this.label4.Tag = "F_ListadoProductos_Lbl_FechaEstimadaDevolucion";
            this.label4.Text = "Fecha estimada devolucion";
            // 
            // dateTimePickerFechaEstimadaDevolucion
            // 
            this.dateTimePickerFechaEstimadaDevolucion.Location = new System.Drawing.Point(21, 247);
            this.dateTimePickerFechaEstimadaDevolucion.MaxDate = new System.DateTime(2040, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFechaEstimadaDevolucion.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFechaEstimadaDevolucion.Name = "dateTimePickerFechaEstimadaDevolucion";
            this.dateTimePickerFechaEstimadaDevolucion.Size = new System.Drawing.Size(204, 21);
            this.dateTimePickerFechaEstimadaDevolucion.TabIndex = 44;
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(21, 85);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(204, 28);
            this.comboBoxCliente.TabIndex = 41;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(26, 33);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(195, 40);
            this.label18.TabIndex = 40;
            this.label18.Tag = "F_ListadoProductos_Lbl_ClienteAlQueLePertence";
            this.label18.Text = "Cliente al que pertenece \r\nel producto\r\n";
            // 
            // dateTimePickerFechaRecibida
            // 
            this.dateTimePickerFechaRecibida.Location = new System.Drawing.Point(21, 162);
            this.dateTimePickerFechaRecibida.MaxDate = new System.DateTime(2040, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFechaRecibida.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFechaRecibida.Name = "dateTimePickerFechaRecibida";
            this.dateTimePickerFechaRecibida.Size = new System.Drawing.Size(204, 21);
            this.dateTimePickerFechaRecibida.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(64, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 20);
            this.label9.TabIndex = 43;
            this.label9.Tag = "F_ListadoProductos_Lbl_FechaRecibida";
            this.label9.Text = "Fecha recibida";
            // 
            // FormListadoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1178, 666);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dataGridViewListadoProductosDefectuosos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormListadoProductos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormListadoProductos_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormListadoProductos_FormClosed);
            this.Load += new System.EventHandler(this.FormListadoProductos_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCostoProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadoProductosDefectuosos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAncho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLargo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCostoPerdidaMateriaPrima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCostoManoObra)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxProblemaEntrada;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewListadoProductosDefectuosos;
        private System.Windows.Forms.NumericUpDown numericUpDownCostoProducto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownAlto;
        private System.Windows.Forms.NumericUpDown numericUpDownAncho;
        private System.Windows.Forms.NumericUpDown numericUpDownLargo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownCostoPerdidaMateriaPrima;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxCondicionProducto;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaEstimadaDevolucion;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaRecibida;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDownCostoManoObra;
    }
}