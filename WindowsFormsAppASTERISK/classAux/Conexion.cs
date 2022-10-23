using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Renci.SshNet;

namespace CajeroAutomatico
{
    //internal
    class Conexion
    {
        public static MySqlConnection obtenerConexion()
        {
            string connectionString = "server=localhost; uid=root; pwd=; database=asterisk; sslmode=None;";
            
            MySqlConnection con = new MySqlConnection(connectionString);

            try
            {
                con.Open();
                //MessageBox.Show("Conexion exitosa");
                return con;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hubo un error de conexion" + ex,"Error de Conexion con DDBB");
                return con;
            }
        }
    }
}
