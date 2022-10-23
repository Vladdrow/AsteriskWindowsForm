using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CajeroAutomatico.classAux;

namespace WindowsFormsAppASTERISK {
    public partial class eliminarUsuario : Form {
        public eliminarUsuario() {  //Actualizar Usuario
            InitializeComponent();
        }
        //Nombre del usuario adminitrador actual
        public string nombreUsuarioAdmin { get; set; }
        public string idUsuarioAdmin { get; set; }
        //Auxiliar de la extension
        string extension;

        Funciones func = new Funciones();

        //################## Boton para buscar al usuario usando su numero ID ##################################
        private void buttonBuscar_Click(object sender, EventArgs e) {

            if (string.IsNullOrEmpty(textBoxIdUsuario.Text)) {      /////
                MessageBox.Show("Debe rellenar el recuadro.", "Error");
            }
            else {
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;

                long idUser = long.Parse(textBoxIdUsuario.Text);

                MySqlDataReader consulta = Funciones.obtenerUserData(idUser);

                while (consulta.Read()) {                    
                    string idUser1 = consulta.GetString(0); func.idUserTabla = idUser1;

                    //MessageBox.Show(consulta.GetString(0));
                    textBoxNombre.Text = consulta.GetString(1); func.oldName = textBoxNombre.Text;
                    textBoxApellido.Text = consulta.GetString(2); func.oldApellido = textBoxApellido.Text;
                    textBoxExtension.Text = consulta.GetString(3); func.oldExtension = textBoxExtension.Text;
                    extension = textBoxExtension.Text;
                    comboBoxCargos.Text = consulta.GetString(4); func.oldCargo = comboBoxCargos.Text;
                    textBoxNombreID.Text = consulta.GetString(6); func.oldNombreId = textBoxNombreID.Text;
                    string clave = Funciones.limpiarContrasenia(consulta.GetString(7));
                    textBoxClave.Text = clave; func.oldClave = consulta.GetString(7);
                }
            }
        }
        //########################################################################################################

        private void buttonAceptar_Click(object sender, EventArgs e) {
            if (!verificarEmptyTextBoxes(1) && auxMainAutenticarAdmin()) {
                if(Funciones.actualizandoDatos(textBoxNombre.Text, textBoxApellido.Text, textBoxNombreID.Text,
                    comboBoxCargos.Text, textBoxClave.Text+'_'+extension, func)) {
                    MessageBox.Show("Actualizado exitosamente", "Aviso");
                    limpiar();
                }
                
            }
            else {
                MessageBox.Show("Cuadros vacios.\nIngrese número ID de usuario.", "Aviso");
            }
        }
        private void buttonEliminar_Click(object sender, EventArgs e) {
            if (auxMainAutenticarAdmin()) {
                long numID = long.Parse(textBoxIdUsuario.Text);
                int extension = int.Parse(textBoxExtension.Text);
                string passwd = textBoxClave.Text;

                if (Funciones.eliminarUsuarioTabla(numID, extension, passwd, func)) {
                    MessageBox.Show("Usuario eliminado", "Aviso");
                    limpiar();
                }
            }
        }


        private void buttonCambiarCargo_Click(object sender, EventArgs e) {
            if(auxMainAutenticarAdmin())
                comboBoxCargos.Enabled = true;
            
            
        }


        private void buttonCambiar_Click(object sender, EventArgs e) {
            string[] nombre1 = new string[30];
            string[] nombre2 = new string[30];
            string[] nombres = new string[30];

            if (!verificarEmptyTextBoxes(2) && verificarSyntaxTextBox()) {

                string nombresCompletos = textBoxNombre.Text;
                int extension = int.Parse(textBoxExtension.Text);

                if (Funciones.verificarDosNombres(nombresCompletos)) {
                    Funciones.obtenerNombresUsuarios(nombresCompletos, nombre1, nombre2, extension.ToString(), nombres);

                    string name = nombres[0];
                    string name2 = nombres[1];

                    elegirNombreId elegirNombre = new elegirNombreId();
                    elegirNombre.buttonNombre1.Text = name;
                    elegirNombre.buttonNombre2.Text = name2;
                    elegirNombre.ShowDialog();

                    textBoxNombreID.Text = elegirNombre.nombreIdUsuario;

                }
                else {
                    textBoxNombreID.Text = nombresCompletos + extension;
                }
                    //textBoxNombreID.Text = nombreIdUsuario;
            }
            else {
                MessageBox.Show("Rellene el campo NOMBRE por favor...", "AVISO");
            }
        }


        //############## Mostrar-Ocultar contrasenias ###################
        private void buttonVer_Click(object sender, EventArgs e) {
            buttonOcultar.BringToFront();
            textBoxClave.PasswordChar = '\0';
            textBoxClave.Enabled = true;
        }

        private void buttonOcultar_Click(object sender, EventArgs e) {
            buttonVer.BringToFront();
            textBoxClave.PasswordChar = '*';
            textBoxClave.Enabled = false;
        }
        //##################################################################

        

        public bool verificarSyntaxTextBox() {
            if (!(Funciones.CustomMethod(textBoxNombre.Text, 2)) && !(Funciones.CustomMethod(textBoxApellido.Text, 2)))
                return true;
            else
                return false;
        }

        public bool verificarEmptyTextBoxes(int opc) {
            if (opc == 1 && (String.IsNullOrEmpty(textBoxNombre.Text) || String.IsNullOrEmpty(textBoxApellido.Text) ||
                String.IsNullOrEmpty(textBoxExtension.Text) || String.IsNullOrEmpty(textBoxClave.Text) ||
                String.IsNullOrEmpty(textBoxIdUsuario.Text) || String.IsNullOrEmpty(comboBoxCargos.Text)))
                return true;
            else if (opc == 2 && String.IsNullOrEmpty(textBoxNombre.Text))
                return true;
            else
                return false;
        }

        //Abriendo la ventana de autenticacion del administrador
        public bool auxMainAutenticarAdmin() {
            autenticarAdmin formAutenticar = new autenticarAdmin();
            formAutenticar.labelNameUsuario.Text = nombreUsuarioAdmin;
            formAutenticar.idUser = idUsuarioAdmin;
            formAutenticar.ShowDialog();
            return formAutenticar.DialogResult == DialogResult.OK && formAutenticar.autenticarUsuario;
        }

        public void limpiar() {
            textBoxNombre.Clear();
            textBoxApellido.Clear();
            textBoxExtension.Clear();
            textBoxNombreID.Clear();
            textBoxClave.Clear();
        }
    }
}
