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
    public partial class Consultas : FormBase
    {
        public Consultas()
        {
            InitializeComponent();
        }

       

        public DataSet MostrarInfoDG(string tabla)
        {
            /*En este apartado , se crea un metodo en el cual se pasa como parametro
             * cualquierr tabla que nosotros deseamos obtener en nuestro DataGridView.
             * Esto nos ayuda ahorrar tiempo y repetir codigo el cual , con la sentencia
             * de abajo solo con pasar el query y el nombre de la tabla , esta se conectara
             * a la BD y obtendra los datos con la ayuda de nuestra libreria.
             * 
             */
            DataSet DS;
            string cmd = string.Format("SELECT * FROM " + tabla);
            //Obtenemos los datos y se mostrara en la tabla que hemos creado.
            DS = Biblioteca.Herramientas(cmd);
            return DS;
        }

        //Metodo para el DataSet el cual buscaremos productos mediante la tabla que desemos

        public DataSet BuscarArticulo(string tabla2)
        {
            DataSet DS2;
            //string cmd = string.Format("SELECT * FROM " + tabla);
            string buscar_articulo = "Select * FROM " +tabla2+" WHERE Nombre_producto LIKE ('%" + txtConsultar.Text.Trim() + "%')";
            //Obtenemos los datos y se mostrara en la tabla que hemos creado.
            DS2 = Biblioteca.Herramientas(buscar_articulo);
            return DS2;
        }

        //Metodo para el DataSet para la busqueda de clientes.
        //Se hace el cambo a Nombre_cliente
        public DataSet BuscarClientes(string tabla3)
        {
            DataSet DS3;
            //string cmd = string.Format("SELECT * FROM " + tabla);
            string buscar_cliente = "Select * FROM " + tabla3 + " WHERE Nombre_cliente LIKE ('%" + txtConsultar.Text.Trim() + "%')";
            //Obtenemos los datos y se mostrara en la tabla que hemos creado.
            DS3 = Biblioteca.Herramientas(buscar_cliente);
            return DS3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
