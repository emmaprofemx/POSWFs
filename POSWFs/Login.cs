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
                {
                    MessageBox.Show("Inicio de sesion correcto");
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
    }
}
