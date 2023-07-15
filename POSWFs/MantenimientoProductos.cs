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
    public partial class MantenimientoProductos : Mantenimiento
    {
        public MantenimientoProductos()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void MantenimientoProductos_Load(object sender, EventArgs e)
        {

        }

        public override Boolean Guardar()
        {
            if (Biblioteca.ValidarFormulario(this, errorProvider1) == false)
            {
                try
                {
                    //Ejecutando el procedimiento almacenado sp_ActualizarArticulos
                    /*En este apartado , se manda a llamar el procedimiento almacenado sp_ActualizarArticulos
                     * usando arrays dentro de las comillas dobles para pasarle como parametros , los datos
                     * que se vayan ingresando en los txt de la ventana Mantenimiento productos.
                     * 
                     * Usamos nuestra liberia la cual nos ayudara a realizar la peticion a la BD , osea
                     * insertamos los datos , despues con la ayuda de la liberia esta se conecta a la BD.
                     * Si todo sale bien , se despliega un MessageBox.Show
                     * 
                     * Tenemos que darle compilar al proyecto para que se apliquen los cambios.
                     */
                    string insertar = string.Format("EXEC sp_ActualizarArticulos '{0}','{1}','{2}'", txtId_Producto.Text.Trim(), txtDescripcion.Text.Trim(), txtPrecio.Text.Trim());
                    Biblioteca.Herramientas(insertar);
                    MessageBox.Show("¡Producto guardado correctamente!");
                    return true;
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error: " + error);
                    return false;
                }
            }
            else
            {
                return false;
            }
           
        }

        public override void Eliminar()
        {
            try
            {
                //Ejecutando el procedimiento almacenado sp_EliminarProductos
                /*Se manda a llamar el procedimiento almacenado sp_EliminarProductos
                 * usando una posicion , la cual hace referencia al Id que estaremos ingresando
                 * en el txt , el cual se lee y se manda a la sentencia SQL donde eliminara el 
                 * producto el cual tenga el id que se ingreso.
                 * 
                 * Usamos nuestra liberia la cual nos ayudara a realizar la peticion a la BD.
                 * Tenemos que darle compilar al proyecto para que se apliquen los cambios.
                 */
                string eliminar = string.Format("EXEC sp_EliminarProductos '{0}'", txtId_Producto.Text.Trim());
                Biblioteca.Herramientas(eliminar);
                MessageBox.Show("¡Producto eliminado correctamente!");
            }catch(Exception error)
            {
                MessageBox.Show("Ha ocurrido un error: " + error);
            }
           
        
        }

        private void txtId_Producto_TextChanged(object sender, EventArgs e)
        {
            //Cuando el usuario vuelva a escribir , el errorProvider se limpiara
            errorProvider1.Clear();
        }

        private void btnMNuevo_Click(object sender, EventArgs e)
        {
            //Estableciendo que los cuadros esten en blanco.
                txtId_Producto.Text = "";
                txtDescripcion.Text = "";
                txtPrecio.Text = "";
            
        }
    }
}
