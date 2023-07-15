using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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

        //Creando metodo de validacion
        public static Boolean ValidarFormulario(Control ObjetoError , ErrorProvider ErrorProvider)
        {
            //Por defecto no hay errores
            Boolean SiError = false;

            //recorriendo cada campo que vayamos a validaro , que son los textbox
            //Verifica por cada campo , si el campo es un error de ErrortxBox
            foreach(Control campo in ObjetoError.Controls)
            {
                if (campo is ErrortxBox)
                {
                    ErrortxBox objeto = (ErrortxBox)campo;

                    if(objeto.Validar == true)
                    {
                        //Si esta vacia
                        if (string.IsNullOrEmpty(objeto.Text.Trim()))
                        {
                            ErrorProvider.SetError(objeto , "Los campos no pueden estar vacios");
                            //Que si hay campos vacios
                            SiError = true;
                        }
                    }
                    if (objeto.ValidarNumeros == true)
                    {
                        int contador = 0 , EncontrarLetras = 0;

                        //Utilizando foreachr para recorrer si los campos contienen letras o no

                        //Contrar los caracteres que se estan recorriendo
                        
                        foreach (char letra in objeto.Text.Trim())
                        {
                            if (char.IsLetter(objeto.Text.Trim() , contador))
                            {
                                //
                                EncontrarLetras++;
                            }
                            //Para que no se quede en la primera posicion , si no para que recorra los demas textBox
                            contador++;
                        }
                        /*Lo que hacemos aqui es:
                         * Supongamos que en el campo ID el usuario ingresa numeros:
                         * 123456
                         * hasta el momento todo bien , ya que ese campo sera exclusivamente de numeros.
                         * Pero si se llegara a introducir una letra , el if de arriba incrementara la 
                         * variable EncontrarLetras , lo cual hara que mande una alerta diciendo
                         * que solo se admiten numeros.
                         */
                        if (EncontrarLetras !=0 )
                        {
                            SiError = true;
                            ErrorProvider.SetError(objeto, "Solo se aceptan numeros");
                        }

                    }

                }
            }//Fin del foreach
            return SiError;
        }//Fin del metodo
    }
}
