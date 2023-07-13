using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace POSWFs.Clases
{
   public class CConexion
    {
        SqlConnection conex = new SqlConnection();
        static string servidor = "localhost";
        static string bd = "Sistema";
        static string usuario = "sa";
        static string password = "123456789";
        static string puerto = "51170";

        string cadenaConexion = "Data Source=" + servidor + "," + puerto+";"+ 
            "user id=" + usuario + ";" + "password=" + password + ";" + 
            "Initial Catalog=" + bd + ";" + "Persist Security Info=true";

        public SqlConnection establecerConexion()
        {
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                MessageBox.Show("Conexion establecida a la base de datos");
            }catch(SqlException e)
            {
                MessageBox.Show("Error al conectar " + e.ToString());
            }

            return conex;
        }
    }
}
