using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibreriaDLL
{
    public class Biblioteca
    {
        public static DataSet Herramientas(string cmd)
        {
            SqlConnection conexx = new SqlConnection();
            string servidor = "localhost";
            string bd = "Sistema";
            string usuario = "sa";
            string password = "123456789";
            string puerto = "51170";

            string cadenaConexion = "Data Source=" + servidor + "," + puerto + ";" +
                "user id=" + usuario + ";" + "password=" + password + ";" +
                "Initial Catalog=" + bd + ";" + "Persist Security Info=true";
            conexx.ConnectionString = cadenaConexion;
            conexx.Open();

            //Almacenamos en la cache , temporalmente guardaremos los datos
            DataSet dll = new DataSet();
            SqlDataAdapter dll1 = new SqlDataAdapter(cmd , conexx);

            dll1.Fill(dll);

            conexx.Close();

            return dll;
        }
    }
}
