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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Biblioteca.Herramientas("Select * FROM Clientes where id = 1");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
