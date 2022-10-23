using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CajeroAutomatico;
using CajeroAutomatico.classAux;

namespace WindowsFormsAppASTERISK {
    public partial class registrarUsuario : Form {
        public registrarUsuario() {
            InitializeComponent();
        }

        ConstructorUsuarios agregar = new ConstructorUsuarios();

        private void buttonGuardar_Click(object sender, EventArgs e) {

            if (verificarEmptyTextBoxes(1)) {
                MessageBox.Show("Debe rellenar todos los cuadros!", "Aviso");

            } 
            else {
                int datos = 0;
                string[] nombresUsuarios = new string[10];

                if(verificarSyntaxTextBox()) {
                    agregar.apellido = textBoxApellido.Text;
                    agregar.extension = int.Parse(textBoxExtension.Text);
                    agregar.cargo = comboBoxCargos.Text;
                    agregar.clave = textBoxContrasenia.Text+'_'+agregar.extension;
                    agregar.numIdentificacion = textBoxIdusuario.Text;

                    datos = Funciones.agregar(agregar);
                }
                else {
                    MessageBox.Show("Formato Incorrecto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (datos > 0) {
                    MessageBox.Show("Datos ingresados");
                    limpiar();
                }
                else {
                    MessageBox.Show("Datos no ingresados");
                }
            }

        }

        private void buttonObtenerId_Click_1(object sender, EventArgs e) {
            Random random = new Random();
            int numAleatorio;
            while (true) {
                numAleatorio = random.Next(200000000, 299999999);
                int dato = Funciones.operarObtenerNumId(numAleatorio);
                if (dato > 0) {
                    break;
                }
            }
            textBoxIdusuario.Text = numAleatorio.ToString();
        }


        private void buttonObtenerExt_Click(object sender, EventArgs e) {

            string[] nombre1 = new string[30];
            string[] nombre2 = new string[30];
            string[] nombres = new string[30];

            if (!verificarEmptyTextBoxes(2)) {
                textBoxExtension.Text = Funciones.obtenerNumExt().ToString();
                if (verificarSyntaxTextBox() && textBoxExtension.Text != "0") {

                    try {
                        agregar.nombresCompletos = textBoxNombre.Text;
                        agregar.extension = int.Parse(textBoxExtension.Text);

                        if (Funciones.verificarDosNombres(agregar.nombresCompletos)) {
                            Funciones.obtenerNombresUsuarios(agregar.nombresCompletos, nombre1, nombre2, agregar.extension.ToString(), nombres);

                            agregar.nombre1 = nombres[0];
                            agregar.nombre2 = nombres[1];

                            elegirNombreId elegirNombre = new elegirNombreId();
                            elegirNombre.buttonNombre1.Text = agregar.nombre1;
                            elegirNombre.buttonNombre2.Text = agregar.nombre2;
                            elegirNombre.ShowDialog();

                            if (elegirNombre.DialogResult == DialogResult.Cancel)
                                textBoxExtension.Clear();
                            else
                                agregar.nombreIdUsuario = elegirNombre.nombreIdUsuario;

                        }
                        else {
                            agregar.nombreIdUsuario = agregar.nombresCompletos + agregar.extension;
                        }
                        textBoxNombreID.Text = agregar.nombreIdUsuario;

                    }
                    catch (Exception ex) {
                        MessageBox.Show("Se le escapó un espaciado (Campo Nombre), bórrelo por favor...","Aviso");
                    }
                }
            }
            else {
                MessageBox.Show("Rellene el campo NOMBRE por favor...", "AVISO");
            }
        }

        //Funciones Varias O_o
        public bool verificarSyntaxTextBox() {
            if (!(Funciones.CustomMethod(textBoxNombre.Text, 2)) && !(Funciones.CustomMethod(textBoxApellido.Text, 2)))
                return true;
            else
                return false;
        }

        public bool verificarEmptyTextBoxes(int opc) {
            if (opc==1 && (String.IsNullOrEmpty(textBoxNombre.Text) || String.IsNullOrEmpty(textBoxApellido.Text) ||
                String.IsNullOrEmpty(textBoxExtension.Text) || String.IsNullOrEmpty(textBoxContrasenia.Text) ||
                String.IsNullOrEmpty(textBoxIdusuario.Text) || String.IsNullOrEmpty(comboBoxCargos.Text)))
                return true;
            else if (opc == 2 && String.IsNullOrEmpty(textBoxNombre.Text) )
                return true;
            else
                return false;
        }

        public void limpiar() {
            textBoxNombre.Clear(); textBoxApellido.Clear(); textBoxExtension.Clear();
            textBoxExtension.Clear(); textBoxNombreID.Clear(); textBoxContrasenia.Clear();
            textBoxIdusuario.Clear();
        }
    }
}