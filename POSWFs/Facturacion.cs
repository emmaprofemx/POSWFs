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

        private void evaluarNumeros(KeyPressEventArgs e)
        {
            try
            {
                // Verificar si la tecla presionada es un número o la tecla de retroceso (Backspace)
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    // Si no es un número ni Backspace, cancelar la tecla pulsada para que no aparezca en el TextBox.
                    e.Handled = true;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("No se admiten letras! " + error.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //validando si campos estan nulos
                if (string.IsNullOrEmpty(txtCodigoCliente.Text.Trim()) == false)
                {
                    //comandos esenciales por consola
                    //Extraera el campo y lo convierte a string para posteriormente agregarlo en el label
                    string cmd = string.Format("Select Nombre_cliente , Apellido_cliente from Clientes where id_clientes= '{0}'", txtCodigoCliente.Text.Trim());
                    DataSet ds = Biblioteca.Herramientas(cmd);

                    //Agregando el nombre y apllido en el label
                    string nombreCliente = ds.Tables[0].Rows[0]["Nombre_cliente"].ToString().Trim();
                    string apellidoCliente = ds.Tables[0].Rows[0]["Apellido_cliente"].ToString().Trim();
                    txtCliente.Text = $"{nombreCliente} {apellidoCliente}";

                    txtCodigoProducto.Focus();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error " + error.Message);
            }
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            evaluarNumeros(e);
        }

        private void txtCodigoCliente_TextChanged(object sender, EventArgs e)
        {
           // evaluarNumeros();
        }

        private void txtCodigoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            evaluarNumeros(e);
        }
    }
}
