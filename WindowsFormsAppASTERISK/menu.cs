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
using WindowsFormsAppASTERISK;


namespace WindowsFormsAppASTERISK {
    public partial class menu : Form {
        public menu() {
            InitializeComponent();
        }

        public string idUsuarioAdmin { get; set; }

        private void buttonRegistrar_Click(object sender, EventArgs e) {
            registrarUsuario formRegistrarUsuario = new registrarUsuario();
            formRegistrarUsuario.ShowDialog();
        }

        private void buttonEliminar_Click(object sender, EventArgs e) {
            eliminarUsuario formEliminarUsuario = new eliminarUsuario();
            formEliminarUsuario.nombreUsuarioAdmin = labelNameUsuario.Text;
            formEliminarUsuario.idUsuarioAdmin = idUsuarioAdmin;
            formEliminarUsuario.ShowDialog();
        }

        private void buttonVerUsuarios_Click(object sender, EventArgs e) {
            mdiContainer container = new mdiContainer();
            mostrar(container);
            container.ShowDialog();

        }



        //Funciones varias
        public static void mostrar(mdiContainer container) {
            DataSet ds = Funciones.LoadDataGridView(1);
            tablaUsuarios tablaUsers = new tablaUsuarios();
            tablaUsers.MdiParent = container;
            tablaUsers.labelTitulo.Text = "Usuarios Registrados";
            tablaUsers.dataGridViewUsers.DataSource = ds.Tables[0].DefaultView;
            tablaUsers.Show();
        }
    }
}
