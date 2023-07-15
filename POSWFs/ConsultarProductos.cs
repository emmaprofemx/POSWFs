using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Libreria para la conexion a la BD 
using LibreriaDLL;

namespace POSWFs
{
    public partial class ConsultarProductos : Consultas
    {
        public ConsultarProductos()
        {
            InitializeComponent();
        }

        private void ConsultarProductos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MostrarInfoDG("Articulos").Tables[0];
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            /*
             * if (string.IsNullOrEmpty(txtConsultar.Text.Trim()) == false)
            {
                try
                {
                    DataSet DS;
                    string buscar = "Select * from Articulos WHERE Nombre_producto LIKE ('%+"+txtConsultar.Text.Trim()+"%')";
                  
                    DS = Biblioteca.Herramientas(buscar);

                    dataGridView1.DataSource = DS.Tables[0];
                }
                catch (Exception error)
                {
                    MessageBox.Show("No se puede conectar , Error: " + error.Message);
                }
            }
            */

            if (string.IsNullOrEmpty(txtConsultar.Text.Trim()) == false)
            {
                try
                {
                    /* DataSet DS;
                     string buscar = "Select * from Articulos WHERE Nombre_producto LIKE ('%+" + txtConsultar.Text.Trim() + "%')";

                     DS = Biblioteca.Herramientas(buscar);

                     dataGridView1.DataSource = DS.Tables[0];*/
                    //dataGridView1.DataSource = MostrarInfoDG("Articulos").Tables[0];
                    dataGridView1.DataSource = BuscarArticulo("Articulos").Tables[0];
                }
                catch (Exception error)
                {
                    MessageBox.Show("No se puede conectar , Error: " + error.Message);
                }
            }
        }
    }
}
