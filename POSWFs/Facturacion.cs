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

        //Creando variable contador para contar cuantos articulos agregamos
        public static int contadorFila = 0;

        public static double total;

        private void btnColocar_Click(object sender, EventArgs e)
        {
            try
            {
                // Si el campo no está vacío
                if (Biblioteca.ValidarFormulario(this, errorProvider1) == false)
                {
                    // Validar que no se esté repitiendo un producto, admita artículo nuevo
                    bool existe = false;
                    // Esta variable nos sirve para arrancar desde la primera fila
                    int numeroFila = -1; // Inicializamos en -1 para detectar si encontramos la fila repetida.

                    // Recorremos todas las filas del DataGridView para verificar si el producto ya existe
                    foreach (DataGridViewRow fila in dataGridView1.Rows)
                    {
                        // Si el código del producto en la fila actual coincide con el que intentamos agregar
                        if (fila.Cells[0].Value.ToString() == txtCodigoProducto.Text)
                        {
                            existe = true;
                            numeroFila = fila.Index; // Obtenemos el índice de la fila que coincide
                            break; // Salimos del bucle, no necesitamos seguir buscando
                        }
                    }

                    if (existe)
                    {
                        // Actualizamos la cantidad del producto existente en lugar de agregar una nueva fila
                        dataGridView1.Rows[numeroFila].Cells[3].Value = (Convert.ToDouble(txtCantidad.Text) + Convert.ToDouble(dataGridView1.Rows[numeroFila].Cells[3].Value)).ToString();
                    }
                    else
                    {
                        // Agregamos una nueva fila al DataGridView
                        dataGridView1.Rows.Add(txtCodigoProducto.Text, txtDescripcion.Text, txtPrecio.Text, txtCantidad.Text);
                        numeroFila = dataGridView1.Rows.Count - 1; // Actualizamos el número de fila para la nueva entrada.
                        contadorFila++; // Incrementamos el contador de filas.
                    }

                    // Obtenemos el precio actualizado del producto ingresado
                    double precio = Convert.ToDouble(txtPrecio.Text);

                    // Realizando el cálculo del importe precio * cantidad
                    double importe = precio * Convert.ToDouble(dataGridView1.Rows[numeroFila].Cells[3].Value);
                    // Insertando el importe en nuestra columna 4 del dataGridView
                    dataGridView1.Rows[numeroFila].Cells[4].Value = importe;

                    total = 0;
                    // Recorremos todas las filas del DataGridView para verificar si el producto ya existe
                    foreach (DataGridViewRow fila in dataGridView1.Rows)
                    {
                        
                        /*Pasamos como parametro la celda 4 (importe) que es la que haremos la suma , que se mostrara 
                         * en el apartado del total.
                         */
                        total += Convert.ToDouble(fila.Cells[4].Value);
                       
                        // Si el código del producto en la fila actual coincide con el que intentamos agregar
                        if (fila.Cells[0].Value.ToString() == txtCodigoProducto.Text)
                        {
                            existe = true;
                            numeroFila = fila.Index; // Obtenemos el índice de la fila que coincide
                            break; // Salimos del bucle, no necesitamos seguir buscando
                        }
                    }//fin del foreach
                    lblTotal.Text = "$ " + total.ToString();
                }//fin de if
            }//fin de try
            catch (Exception error)
            {
                // Manejo de excepciones
                MessageBox.Show("Error " + error);
            }




        }
    }
}
