﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using _02_ProductosDefectuosos.Modelos;
using _02_ProductosDefectuosos.Servicios;
using static _02_ProductosDefectuosos.Modelos.EstadoProducto;

namespace UI
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
            ServiciosUsuariosCSV.CrearCSV();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            Login formLogin = new Login();
            formLogin.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombreCompleto = txtFullName.Text.Trim();
            string usuario = txtUserName.Text.Trim();
            string mail = txtMail.Text.Trim();
            
            string password = ServiciosUsuariosCSV.HashPassword(txtPassword.Text.Trim());
            string rolTexto = "Empleado"; //el empleado puede crear una cuenta

            //manejar los errores por si no completan un txt.
            if (string.IsNullOrWhiteSpace(nombreCompleto) || string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(mail) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(rolTexto))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }
 
            try
            {
                Empleado nuevoEmpleado = new Empleado(nombreCompleto, usuario, mail, password, rolTexto);
                ServiciosUsuariosCSV.GuardarUsuarioCSV(nuevoEmpleado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al crear el usuario con rol empleado: " + ex.Message);
            }

            MessageBox.Show("Usuario registrado con éxito.");

            //te manda a login cuando te registras
            Login login = new Login();
            login.Show();
            this.Hide();
        }


    }
}
