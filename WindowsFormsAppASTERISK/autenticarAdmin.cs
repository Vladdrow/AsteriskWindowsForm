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
    public partial class autenticarAdmin : Form {
        public autenticarAdmin() {
            InitializeComponent();
        }
        
        public bool autenticarUsuario { get; set; }
        public string idUser { get; set; }
        private void buttonAceptar_Click(object sender, EventArgs e) {
            bool dato;
            if (textBoxClave.Text == "") {
                MessageBox.Show("Debe rellenar el recuadro.", "Aviso");
            }
            else {

                string clave = textBoxClave.Text;
                dato = Funciones.autenticarOperacionesAdmin(idUser, clave);

                if (dato) {
                    //MessageBox.Show("Autenticador funcionando");
                    autenticarUsuario = dato;
    }
                else {
                    autenticarUsuario = dato;
                    MessageBox.Show("Contrasenia Incorrecta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }
}
