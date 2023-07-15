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
