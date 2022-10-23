using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Renci.SshNet;
using WindowsFormsAppASTERISK.classAux;

namespace CajeroAutomatico.classAux
{
    class Funciones
    {
        //Variables globales publicas
        public string idUserTabla { get; set; }
        public string oldName { get; set; }
        public string oldApellido { get; set; }
        public string oldExtension { get; set; }
        public string oldCargo { get; set; }
        public string oldNombreId { get; set; }
        public string oldClave { get; set; }

        //Servidor Fisico
        static string ipServer = "192.168.0.17";
        static string userServer = "root";
        static string passwdServer = "12345678";

        //Revisando la existencia de la tabla y/o creandola
        public static void creandoTabla() {
            string tableSql = "CREATE TABLE IF NOT EXISTS tablausuarios1(" +
                              "id_usuario INTEGER NOT NULL AUTO_INCREMENT PRIMARY KEY," +
                              "nombre VARCHAR(40) NOT NULL," +
                              "apellido VARCHAR(50) NOT NULL," +
                              "extension INTEGER(11)," +
                              "cargo VARCHAR(15) NOT NULL," +
                              "numIdUsuario INTEGER(11) NOT NULL," +
                              "nombreIdUsuario VARCHAR(20)," +
                              "contrasenia VARCHAR(11) NOT NULL," +
                              "fecha DATE NOT NULL ); ";
            MySqlCommand comando = new MySqlCommand(tableSql, Conexion.obtenerConexion());
            comando.ExecuteNonQuery();
        }

        //Verificando datos de autenticacion 
        public static bool operarLogin(long numId, string nombreIdUsuario,string clave, string[] nombre, string[] numIdObtain, string[] cargoUser) {
            try {
                bool retorno = false;

                MySqlCommand myCommand = new MySqlCommand(String.Format ("SELECT * FROM tablausuarios1 WHERE nombreIdUsuario='{0}' OR numIdUsuario={1} " +
                    "AND contrasenia='{2}'",nombreIdUsuario,numId,clave),Conexion.obtenerConexion());
                MySqlDataReader consultar;

                consultar = myCommand.ExecuteReader();

                while (consultar.Read()) {
                    string nombreCli = consultar.GetString(1);
                    string apellidoCli = consultar.GetString(2);
                    string cargo = consultar.GetString(4);
                    string numID = consultar.GetString(5);
                    string nombreID = consultar.GetString(6);
                    string clave1 = consultar.GetString(7);

                    if ((numId == int.Parse(numID) || nombreID == nombreIdUsuario) && clave == clave1 && cargo == "Administrador") {
                        cargoUser[0] = cargo;
                        numIdObtain[0] = numID;
                        nombre[0] = nombreCli + " " + apellidoCli;
                        retorno = true;
                        break;
                    }
                }
                return retorno;
            }
            catch (MySqlException ex) {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Anadiendo al nuevo usuario dentro de tablausuarios
        public static int agregar(ConstructorUsuarios add)
        {
            try {
                int retorno;

                MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO tablausuarios1" +
                    "(id_usuario, nombre, apellido, extension, cargo, numidusuario, nombreidusuario, contrasenia, fecha)" +
                    "VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", 
                    "NULL", add.nombresCompletos,add.apellido,add.extension, add.cargo, add.numIdentificacion, add.nombreIdUsuario, add.clave, 
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")), Conexion.obtenerConexion());
                retorno = comando.ExecuteNonQuery();

                FuncionesServidor.registrarUsuarioAsterisk(add);
                try {
                    return retorno;
                }
                catch(Exception ex){
                    MessageBox.Show("Ha ocurrido un error inesperado al ingresar el nuevo usuario, " + 
                        ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return retorno;
                }

            }
            catch (MySqlException ex) {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        //Get extension number
        public static int obtenerNumExt() {
            try {
                MySqlCommand myCommand = new MySqlCommand("SELECT extension FROM tablausuarios1 " +
                    "ORDER BY id_usuario DESC LIMIT 1", Conexion.obtenerConexion());
                MySqlDataReader consulta;

                consulta = myCommand.ExecuteReader();
                consulta.Read();
                int numExt = consulta.GetInt32(0);
                return ++numExt;
            }
            catch (MySqlException ex) {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        //Recogiendo los datos del usuario
        public static MySqlDataReader obtenerUserData(long idUser) {
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM tablausuarios1 WHERE numIdUsuario={0}",idUser),
                Conexion.obtenerConexion());
            MySqlDataReader consultar;
            consultar = command.ExecuteReader();               
            
            return consultar;
        }

        //Operate and obtain identificacion number
        public static int operarObtenerNumId(int numIdentificacion) {
            int retorno=1;

            MySqlCommand myCommand = new MySqlCommand("SELECT numidusuario FROM tablausuarios1",
                Conexion.obtenerConexion());
            MySqlDataReader consultar;
            consultar = myCommand.ExecuteReader();

            while (consultar.Read()) {
                string numID = consultar.GetString(0);

                if (numIdentificacion == int.Parse(numID)){
                    retorno = 0;
                    break;
                }
            }
            return retorno;
        }

        public static bool autenticarOperacionesAdmin(string idUser, string claveAdmin) {x`
            MySqlCommand myCommand = new MySqlCommand("SELECT numidusuario,contrasenia FROM tablausuarios1",
                Conexion.obtenerConexion());
            MySqlDataReader consultar = null;
            consultar = myCommand.ExecuteReader();

            while (consultar.Read()) {
                string numId = consultar.GetString(0);
                string clave = consultar.GetString(1);

                if (idUser.Equals(numId) && claveAdmin.Equals(clave)) {
                    return true;
                }
            }
            return false;
        }

        //Actualizando datos de los usuarios

        public static bool actualizandoDatos(string newName, string newApellido, string newNombreId, string newCargo, string newClave,Funciones func) {            

            try {
                MySqlCommand myCommand = new MySqlCommand(string.Format("UPDATE tablausuarios1 SET nombre='{0}', apellido='{1}', nombreidusuario='{2}'," +
                    "cargo='{3}',contrasenia='{4}' WHERE id_usuario={5}",newName,newApellido, newNombreId,newCargo,newClave,func.idUserTabla),
                    Conexion.obtenerConexion());
                myCommand.ExecuteNonQuery();
                FuncionesServidor.actualizarUsuarioAsterisk(func, newNombreId, newClave);

                return true;
            }
            catch (MySqlException ex) {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static bool eliminarUsuarioTabla(long numidUser, int extension,string passwd,Funciones func) {
            string auxExt = extension.ToString();
            string[] auxExtension = new string[3];
            for (int i = 0; i < 3; i++) {
                auxExtension[i] = auxExt[i].ToString();
            }

            try {
                MySqlCommand myCommand = new MySqlCommand(string.Format("DELETE FROM tablausuarios1 WHERE numidusuario={0}",numidUser),
                    Conexion.obtenerConexion());
                myCommand.ExecuteNonQuery();
                FuncionesServidor.eliminarUsuarioAsterisk(func, auxExtension, passwd);
                return true;
            }
            catch (MySqlException ex) {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        
        public static DataSet LoadDataGridView(int opc) {
            try {
                MySqlCommand myCommand;
                if (opc==1)
                    myCommand = new MySqlCommand("SELECT * FROM tablausuarios1", Conexion.obtenerConexion());
                else if(opc==2)
                    myCommand = new MySqlCommand("SELECT * FROM tablausuarios1 WHERE cargo='Administrador'", Conexion.obtenerConexion());
                else
                    myCommand = new MySqlCommand("SELECT * FROM tablausuarios1 WHERE cargo='Normal'", Conexion.obtenerConexion());

                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter(myCommand);
                DataSet myDataSet = new DataSet();
                myDataAdapter.Fill(myDataSet);
                return myDataSet;
            }
            catch (MySqlException ex) {
                MessageBox.Show(ex.Message, "AVISO");
                return null;
            }
        }


        


        //Validacion de cadenas
        public static bool CustomMethod(string validar, int opc) {
            for (int i = 0; i < validar.Length; i++) {
                if (validar[i] >= '0' && validar[i] <= '9') {
                    if (i == 0 && opc==1)
                        return true;
                }
            }
            return false;
        }
        
        //Verificando nombres del usuario
        public static bool verificarDosNombres(string nombre) {
            for (int i = 0; i < nombre.Length; i++) {
                if (nombre[i] == ' ' && nombre[i + 1] != ' ') {
                    return true;
                }
            }
            return false;
        }
        public static void obtenerNombresUsuarios(string nombreCompleto, string[] nombre1, string[] nombre2,
            string extension, string[] name) {
            int contador = 0;

            for (int i = 0; i < nombreCompleto.Length; i++) {
                if (nombreCompleto[i] != ' ') {
                    contador++;
                }
                else
                    break;
            }
            for (int i = 0; i < contador; i++) {
                nombre1[i] = nombreCompleto[i].ToString();
            }
            for (int i = contador; i < nombreCompleto.Length; i++) {
                if (nombreCompleto[i] != ' ') {
                    nombre2[i] = nombreCompleto[i].ToString();
                }
            }

            name[0] = (string.Join("", nombre1))+extension;
            name[1] = (string.Join("", nombre2))+extension;

        }

        //Limpiando contrasenia para mostrar
        public static string limpiarContrasenia(string passwd) {
            string[] passwd1 = new string[passwd.Length];
            for (int i = 0; i < passwd.Length; i++) {
                if (passwd[i] == '_' && passwd[i + 1] != '_') {
                    break;
                }
                passwd1[i] = passwd[i].ToString();
            }
            string passwdFull = string.Join("", passwd1);
            return passwdFull;
            
        }
    }
}
