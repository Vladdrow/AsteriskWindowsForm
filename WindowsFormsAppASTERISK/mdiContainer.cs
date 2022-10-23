using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CajeroAutomatico.classAux;

namespace WindowsFormsAppASTERISK {
    public partial class mdiContainer : Form {
        public mdiContainer() {
            InitializeComponent();
        }

        //Mostrando a todos los usuarios
        private void todosLosUsuariosToolStripMenuItem_Click(object sender, EventArgs e) {
            mostrar(1, "Usuarios Registrados");
        }
        //Mostrando a usuarios administradores

        private void usuariosAdminToolStripMenuItem_Click(object sender, EventArgs e) {
            mostrar(2, "Usuarios Administradores");
        }

        //Mostrando a usuarios normales
        private void usuariosNormalesToolStripMenuItem_Click(object sender, EventArgs e) {
            mostrar(3, "Usuarios Normales") ;
        }

        public void mostrar(int opcMostrar, string textTitle) {
            DataSet ds = Funciones.LoadDataGridView(opcMostrar);
            tablaUsuarios tablaUsers = new tablaUsuarios();
            tablaUsers.MdiParent = this;
            tablaUsers.labelTitulo.Text = textTitle;
            tablaUsers.dataGridViewUsers.DataSource = ds.Tables[0].DefaultView;
            tablaUsers.Show();
        }
    }
}
