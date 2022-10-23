using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renci.SshNet;
using CajeroAutomatico;
using CajeroAutomatico.classAux;
using WindowsFormsAppASTERISK;

namespace WindowsFormsAppASTERISK.classAux {

    internal class FuncionesServidor {
        //Servidor Virtual
        static string ipServerVirtual = "192.168.184.25";
        static string userServerVirtual = "root";
        static string passwdServerVirtual = "12345678";

        //Operaciones para registrar al usuario dentro de los archivos de configuracion de Asterisk
        public static void registrarUsuarioAsterisk(ConstructorUsuarios add) {
            string nameExt = add.nombreIdUsuario;
            string sipFileServer = string.Format("echo '[{0}](usuario)\nusername={1}\nsecret={2}\nport=5061\n' >> /etc/asterisk/sip.conf", nameExt, nameExt, add.clave);
            string extensionsFileServer = string.Format("echo 'exten => {0},1,Dial(SIP/{1})' >> /etc/asterisk/extensions.conf", add.extension, nameExt);

            using (SshClient client = new SshClient(ipServerVirtual, userServerVirtual, passwdServerVirtual)) {
                client.Connect();
                client.RunCommand(sipFileServer);
                client.RunCommand(extensionsFileServer);
                client.RunCommand("service asterisk reload");    //Recargando el asterisk con su nueva configuracion
                client.Disconnect();
            }
        }

        public static void actualizarUsuarioAsterisk(Funciones func, string newNameId, string newClave) {
            MessageBox.Show(func.oldNombreId);
            MessageBox.Show(newNameId);
            string actualizarUserNameSIP = string.Format("sed -i 's/{0}/{1}/g' '/etc/asterisk/sip.conf'", func.oldNombreId, newNameId);
            string actualizarPasswd = string.Format("sed -i 's/{0}/{1}/g' '/etc/asterisk/sip.conf'", func.oldClave, newClave);
            string actualizarUserNameEXT = string.Format("sed -i 's/{0}/{1}/g' '/etc/asterisk/extensions.conf'", func.oldNombreId, newNameId);

            using (SshClient client = new SshClient(ipServerVirtual, userServerVirtual, passwdServerVirtual)) {
                client.Connect();
                client.RunCommand(actualizarUserNameSIP);
                client.RunCommand(actualizarPasswd);
                client.RunCommand(actualizarUserNameEXT);
                client.RunCommand("service asterisk reload");    //Recargando el asterisk con su nueva configuracion
                client.Disconnect();
            }
        }

        public static void eliminarUsuarioAsterisk(Funciones func, string[] extension, string passwd) {
            string ext = string.Join("_", extension);
            string extenNormal = string.Join("", extension);

            passwd = passwd + '_' + extenNormal;

            string deleteUserSIP = string.Format("sed -i 's/{0}/Unknown{1}/g'  '/etc/asterisk/sip.conf'", func.oldNombreId, ext);
            string deleteUserPasswdSIP = string.Format("sed -i 's/{0}/Unknown{1}{2}/g'  '/etc/asterisk/sip.conf'", passwd, "Passwd", ext);
            string deleteUserEXT = string.Format("sed -i 's/{0}/Unknown{1}/g' '/etc/asterisk/extensions.conf'", func.oldNombreId, ext);
            string deleteUserExtenEXT = string.Format("sed -i 's/{0}/UnknownExt{1}/g' '/etc/asterisk/extensions.conf'", extenNormal, ext);

            using (SshClient client = new SshClient(ipServerVirtual, userServerVirtual, passwdServerVirtual)) {
                client.Connect();
                client.RunCommand(deleteUserSIP);
                client.RunCommand(deleteUserPasswdSIP);
                client.RunCommand(deleteUserEXT);
                client.RunCommand(deleteUserExtenEXT);
                client.RunCommand("service asterisk reload");    //Recargando el asterisk con su nueva configuracion
                client.Disconnect();
            }
        }
    }


}
