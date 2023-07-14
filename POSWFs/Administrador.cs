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
    public partial class Administrador : FormBase
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Administrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Esta linea sirve para terminar la ejecucion del programa
            Application.Exit();
        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            //Trayendo la informacion almacenada
            string consulta = "SELECT * FROM Usuarios WHERE id_usuario=" + Login.codigo;
            //Estamos almacenando la informacion en cache de la consulta de arriba
            DataSet data = Biblioteca.Herramientas(consulta);

            lblAdmin.Text = data.Tables[0].Rows[0]["userrname"].ToString();
            lblAdminUser.Text = data.Tables[0].Rows[0]["account"].ToString();
            lblAdminCodigo.Text = data.Tables[0].Rows[0]["id_usuario"].ToString();

            //Obteniendo la ruta de la imagen
            string imagen = data.Tables[0].Rows[0]["imagen"].ToString();
            pictureBox1.Image = Image.FromFile(imagen);

        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            //Codigo para pasarnos al Contenedor Principal del Sistema
            ContenedorPrincipal con_principal = new ContenedorPrincipal();
            //Ocultando administrador
            this.Hide();
            con_principal.Show();



        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }
    }
}
