using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//Usando la libreria que creamos
using LibreriaDLL;
namespace POSWFs
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Biblioteca.Herramientas("Select * FROM Clientes where id = 1");
            try
            {
                string validar = string.Format("Select * FROM Usuarios WHERE account='{0}' AND password='{1}'",txtUsuario.Text.Trim(),txtPass.Text.Trim());
                DataSet conectar = Biblioteca.Herramientas(validar);

                //Creacion de dos variables tratando como matrices
                string cuenta = conectar.Tables[0].Rows[0]["account"].ToString().Trim();
                string contrasena = conectar.Tables[0].Rows[0]["password"].ToString().Trim();

                if (cuenta == txtUsuario.Text.Trim() && contrasena == txtPass.Text.Trim())
                {//Si la cadena la cual esta en el campo validar == 1 (true) , entonces entramos a la ventana Administrador
                    if (Convert.ToBoolean(conectar.Tables[0].Rows[0]["validar_admin"].ToString().Trim()) == true)
                    {
                        //Se escondera la ventana de login y abrira la de administrador
                        Administrador admin = new Administrador();
                        this.Hide();
                        admin.Show();
                    }
                    else
                    {
                        Usuario user = new Usuario();
                        this.Hide();
                        user.Show();

                    }
                   // MessageBox.Show("Inicio de sesion correcto");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Usuario o contrasena invalidos" + error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Esta linea sirve para terminar la ejecucion del programa
            Application.Exit();
        }
    }
}
