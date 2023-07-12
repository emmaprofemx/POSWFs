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

namespace POSWFs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* try
             {
                 //Creando conexion a la bd
                 SqlConnection conexion = new SqlConnection("Data Source=localhost;Initial Catalog=Sistema;Integrated Security=True");
                 conexion.Open();
                 MessageBox.Show("Conexion Exitosa");
             } catch(Exception error)
             {
                 MessageBox.Show("Ha ocurrido un error. Intente nuevamente " + error.Message);
             }*/

            Clases.CConexion objetoConexion = new Clases.CConexion();
            objetoConexion.establecerConexion();
        }
    }
}
