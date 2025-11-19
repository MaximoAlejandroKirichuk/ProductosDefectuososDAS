namespace UI
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarSeguimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarIdiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.españolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inglesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portuguesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdministradortoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.MidnightBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.seguimientoToolStripMenuItem,
            this.ModificarToolStripMenuItem,
            this.ClientesToolStripMenuItem,
            this.cambiarIdiomaToolStripMenuItem,
            this.cambiarContraseñaToolStripMenuItem,
            this.empleadosToolStripMenuItem1,
            this.AdministradortoolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1207, 37);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray;
            this.registrarToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2);
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.registrarToolStripMenuItem.Text = "Registrar";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // seguimientoToolStripMenuItem
            // 
            this.seguimientoToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray;
            this.seguimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarSeguimientoToolStripMenuItem});
            this.seguimientoToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2);
            this.seguimientoToolStripMenuItem.Name = "seguimientoToolStripMenuItem";
            this.seguimientoToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.seguimientoToolStripMenuItem.Text = "Seguimiento";
            this.seguimientoToolStripMenuItem.Click += new System.EventHandler(this.seguimientoToolStripMenuItem_Click);
            // 
            // modificarSeguimientoToolStripMenuItem
            // 
            this.modificarSeguimientoToolStripMenuItem.Name = "modificarSeguimientoToolStripMenuItem";
            this.modificarSeguimientoToolStripMenuItem.Size = new System.Drawing.Size(250, 28);
            this.modificarSeguimientoToolStripMenuItem.Text = "Modificar seguimiento";
            this.modificarSeguimientoToolStripMenuItem.Click += new System.EventHandler(this.modificarSeguimientoToolStripMenuItem_Click);
            // 
            // ModificarToolStripMenuItem
            // 
            this.ModificarToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray;
            this.ModificarToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2);
            this.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem";
            this.ModificarToolStripMenuItem.Size = new System.Drawing.Size(175, 29);
            this.ModificarToolStripMenuItem.Text = "Modificar Productos";
            this.ModificarToolStripMenuItem.Click += new System.EventHandler(this.listadoToolStripMenuItem_Click);
            // 
            // ClientesToolStripMenuItem
            // 
            this.ClientesToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray;
            this.ClientesToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2);
            this.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem";
            this.ClientesToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
            this.ClientesToolStripMenuItem.Text = "Clientes";
            this.ClientesToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem1
            // 
            this.empleadosToolStripMenuItem1.BackColor = System.Drawing.Color.DarkGray;
            this.empleadosToolStripMenuItem1.Margin = new System.Windows.Forms.Padding(2);
            this.empleadosToolStripMenuItem1.Name = "empleadosToolStripMenuItem1";
            this.empleadosToolStripMenuItem1.Size = new System.Drawing.Size(105, 29);
            this.empleadosToolStripMenuItem1.Text = "Empleados";
            this.empleadosToolStripMenuItem1.Click += new System.EventHandler(this.empleadosToolStripMenuItem1_Click);
            // 
            // cambiarIdiomaToolStripMenuItem
            // 
            this.cambiarIdiomaToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray;
            this.cambiarIdiomaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.españolToolStripMenuItem,
            this.inglesToolStripMenuItem,
            this.portuguesToolStripMenuItem});
            this.cambiarIdiomaToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2);
            this.cambiarIdiomaToolStripMenuItem.Name = "cambiarIdiomaToolStripMenuItem";
            this.cambiarIdiomaToolStripMenuItem.Size = new System.Drawing.Size(144, 29);
            this.cambiarIdiomaToolStripMenuItem.Text = "Cambiar Idioma";
            this.cambiarIdiomaToolStripMenuItem.Click += new System.EventHandler(this.cambiarIdiomaToolStripMenuItem_Click);
            // 
            // españolToolStripMenuItem
            // 
            this.españolToolStripMenuItem.Name = "españolToolStripMenuItem";
            this.españolToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.españolToolStripMenuItem.Text = "Español";
            this.españolToolStripMenuItem.Click += new System.EventHandler(this.españolToolStripMenuItem_Click);
            // 
            // inglesToolStripMenuItem
            // 
            this.inglesToolStripMenuItem.Name = "inglesToolStripMenuItem";
            this.inglesToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.inglesToolStripMenuItem.Text = "Ingles";
            this.inglesToolStripMenuItem.Click += new System.EventHandler(this.inglesToolStripMenuItem_Click);
            // 
            // portuguesToolStripMenuItem
            // 
            this.portuguesToolStripMenuItem.Name = "portuguesToolStripMenuItem";
            this.portuguesToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.portuguesToolStripMenuItem.Text = "Portugues";
            this.portuguesToolStripMenuItem.Click += new System.EventHandler(this.portuguesToolStripMenuItem_Click);
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray;
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(175, 33);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar contraseña";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // AdministradortoolStripMenuItem
            // 
            this.AdministradortoolStripMenuItem.BackColor = System.Drawing.Color.DarkGray;
            this.AdministradortoolStripMenuItem.Margin = new System.Windows.Forms.Padding(2);
            this.AdministradortoolStripMenuItem.Name = "AdministradortoolStripMenuItem";
            this.AdministradortoolStripMenuItem.Size = new System.Drawing.Size(130, 29);
            this.AdministradortoolStripMenuItem.Text = "Administrador";
            this.AdministradortoolStripMenuItem.Click += new System.EventHandler(this.AdministradortoolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray;
            this.cerrarSesiónToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2);
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(123, 29);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray;
            this.ayudaToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2);
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(70, 29);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1207, 690);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarIdiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem españolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inglesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portuguesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarSeguimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdministradortoolStripMenuItem;
    }
}

