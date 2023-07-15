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
    }
}
