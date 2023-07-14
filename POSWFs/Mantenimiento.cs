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
    public partial class Mantenimiento : FormBase
    {
        public Mantenimiento()
        {
            InitializeComponent();
        }

        private void btnMConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnMNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btnMEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
    }
}
