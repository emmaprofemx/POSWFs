using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSWFs
{
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Muestra una ventana de dialogo para confirmar si queremos salir.
            if (MessageBox.Show("Desea salir? " , "Aviso" , MessageBoxButtons.YesNo , MessageBoxIcon.Question , MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                //Cierra el programa
                this.Close();
            }
        }

        //Creacion de metodos

        public virtual void Eliminar()
        {

        }

        public virtual void Nuevo()
        {

        }

        public virtual void Consultar()
        {

        }

        public virtual Boolean Guardar()
        {

            return false;
        }

    }
}
