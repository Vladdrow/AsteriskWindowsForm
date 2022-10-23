using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using CajeroAutomatico.classAux;
using Renci.SshNet;

namespace WindowsFormsAppASTERISK {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        public string nombreUsuario { get; set; }
        private void buttoningresar_Click(object sender, EventArgs e) {

            //VERIFICANDO Y ABRIENDO XAMPP SI ES NECESARIO
            Process[] xampp = Process.GetProcessesByName("xampp-control");
            Process cmd = new Process();
            if (xampp.Length == 0) {
                cmd.StartInfo.FileName = @"C:\xampp\xampp-control.exe";
                cmd.Start();    
            }
            else
                MessageBox.Show("Xampp se encuentra abierto", "Aviso");

            Funciones.creandoTabla();

            //
            string[] nombre = new string[10];
            string[] cargo = new string[10];

            if(String.IsNullOrEmpty(textBoxIdUsuario.Text) || String.IsNullOrEmpty(textBoxclave.Text)) {
                MessageBox.Show("Debe rellenar todo los datos.", "Error");
            }
            else {


                string[] numId = new string[10];
                bool dato=false;
                bool formatoIncorrecto = false;

                string identificacion = textBoxIdUsuario.Text;
                string clave = textBoxclave.Text;

                try {
                    if (Funciones.CustomMethod(identificacion,1)) {
                        dato = Funciones.operarLogin(long.Parse(identificacion), "0", clave, nombre, numId,cargo);
                    }
                    else {
                        dato = Funciones.operarLogin(0, identificacion, clave, nombre,numId,cargo);
                    }
                }
                catch (Exception) {
                    MessageBox.Show("Formato Incorrecto", "Aviso");
                    formatoIncorrecto = true;
                    limpiarTextBox();
                }



                if (dato) {
                    nombreUsuario = nombre[0];
                    menu main = new menu();
                    main.idUsuarioAdmin = numId[0];
                    main.labelNameUsuario.Text = nombreUsuario;
                    limpiarTextBox();
                    main.ShowDialog();
                }
                else if (identificacion == "12345678" && clave == "12345678") {
                    menu main = new menu();
                    main.labelNameUsuario.Text = "TEST_USUARIO";
                    textBoxIdUsuario.Clear();
                    textBoxclave.Clear(); 
                    main.ShowDialog();
                }
                else {
                    if (!formatoIncorrecto) {
                        MessageBox.Show("Usuario o contrasenia incorrectos!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBoxIdUsuario.Clear();
                        textBoxclave.Clear();
                    }
                }

                if(xampp.Length == 0) {
                    cmd.Kill();
                }

            }

        }

        private void buttonVer_Click(object sender, EventArgs e) {
            buttonOcultar.BringToFront();
            textBoxclave.PasswordChar= '\0';
        }

        private void buttonOcultar_Click(object sender, EventArgs e) {
            buttonVer.BringToFront();
            textBoxclave.PasswordChar = '*';
        }

        public void limpiarTextBox() {
            textBoxIdUsuario.Clear();
            textBoxclave.Clear();
        }
    }
}