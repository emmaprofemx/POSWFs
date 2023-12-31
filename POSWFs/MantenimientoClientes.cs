﻿using System;
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
    public partial class MantenimientoClientes : Mantenimiento
    {
        public MantenimientoClientes()
        {
            InitializeComponent();
        }

        //**********************************************************

        public override Boolean Guardar()
        {
            
            if (Biblioteca.ValidarFormulario(this,errorProvider1)==false)
            {
                try
                {
                    //Ejecutando el procedimiento almacenado sp_ActualizarClientes

                    /*En este apartado , se manda a llamar el procedimiento almacenado sp_ActualizarClientes
                     * usando arrays dentro de las comillas dobles para pasarle como parametros , los datos
                     * que se vayan ingresando en los txt de la ventana Mantenimiento productos.
                     * 
                     * Usamos nuestra liberia la cual nos ayudara a realizar la peticion a la BD , osea
                     * insertamos los datos , despues con la ayuda de la liberia esta se conecta a la BD.
                     * Si todo sale bien , se despliega un MessageBox.Show
                     * 
                     * Tenemos que darle compilar al proyecto para que se apliquen los cambios.
                     */
                    string insertar_cliente = string.Format("EXEC sp_ActualizarClientes '{0}','{1}','{2}'", txtId_Cliente.Text.Trim(), txtNombre_Cliente.Text.Trim(), txtApellido_Cliente.Text.Trim());
                    Biblioteca.Herramientas(insertar_cliente);
                    MessageBox.Show("¡Cliente guardado correctamente!");
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

        //**********************************************************

        public override void Eliminar()
        {
            try
            {
                //Ejecutando el procedimiento almacenado sp_EliminarClientes

                /*Se manda a llamar el procedimiento almacenado sp_EliminarClientes
                 * usando una posicion , la cual hace referencia al Id que estaremos ingresando
                 * en el txt , el cual se lee y se manda a la sentencia SQL donde eliminara el 
                 * producto el cual tenga el id que se ingreso.
                 * 
                 * Usamos nuestra liberia la cual nos ayudara a realizar la peticion a la BD.
                 * Tenemos que darle compilar al proyecto para que se apliquen los cambios.
                 */
                string eliminar_cliente = string.Format("EXEC sp_EliminarClientes '{0}'", txtId_Cliente.Text.Trim());
                Biblioteca.Herramientas(eliminar_cliente);
                MessageBox.Show("¡Cliente eliminado correctamente!");
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error: " + error);
            }
        }

        //**********************************************************

        private void MantenimientoClientes_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtId_Cliente_TextChanged(object sender, EventArgs e)
        {
            //Cuando el usuario vuelva a escribir , el errorProvider se limpiara
            errorProvider1.Clear();
        }

        private void btnMGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnMNuevo_Click(object sender, EventArgs e)
        {
            //Estableciendo que los cuadros esten en blanco.
            txtId_Cliente.Text = "";
            txtNombre_Cliente.Text = "";
            txtApellido_Cliente.Text = "";
        }

        private void btnMConsultar_Click(object sender, EventArgs e)
        {
            ConsultarCliente consulCli = new ConsultarCliente();
           // consulCli.MdiParent = this;
            consulCli.Show();
        }
    }
}
