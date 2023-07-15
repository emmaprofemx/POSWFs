using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaDLL;
namespace POSWFs
{
    public partial class ConsultarCliente : Consultas
    {
        public ConsultarCliente()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConsultar.Text.Trim()) == false)
            {
                try
                {
                    //dataGridView1.DataSource = BuscarArticulo("Articulos").Tables[0];
                    dataGridView1.DataSource = BuscarClientes("Clientes").Tables[0];
                }
                catch (Exception error)
                {
                    MessageBox.Show("No se puede conectar , Error: " + error.Message);
                }
            }
        }

        private void ConsultarCliente_Load(object sender, EventArgs e)
        {
            //Obtenemos la informacion de la base de datos , de nuestra tabla Clientes
            dataGridView1.DataSource = MostrarInfoDG("Clientes").Tables[0];
        }
    }
}
