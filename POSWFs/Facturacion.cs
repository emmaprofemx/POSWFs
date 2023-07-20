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
    public partial class Facturacion : Procesos
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            string vendedor = "Select * from Usuarios Where id_usuario = " + Login.codigo;
            
            DataSet ds;
            ds = Biblioteca.Herramientas(vendedor);

            //Extraemos el username de la BD al label de nuestra ventana de facturarion
            lblVendedor.Text = ds.Tables[0].Rows[0]["userrname"].ToString().Trim();
        
        }
    }
}
