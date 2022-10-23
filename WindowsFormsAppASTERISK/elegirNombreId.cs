using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppASTERISK {
    public partial class elegirNombreId : Form {
        public elegirNombreId() {
            InitializeComponent();
        }

        public string nombreIdUsuario { get; set; }
        private void buttonNombre1_Click(object sender, EventArgs e) {
            nombreIdUsuario = buttonNombre1.Text;
        }

        private void buttonNombre2_Click(object sender, EventArgs e) {
            nombreIdUsuario = buttonNombre2.Text;
        }
    }
}
