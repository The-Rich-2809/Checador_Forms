using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checador_Forms.Clases
{
    internal class Conexion
    {
        public static MySqlConnection conexion()
        {
            string cadenaConexion = "";
            //cadenaConexion = "datasource=192.168.100.10; username=checador; password=300920; database=checador";
            cadenaConexion = "Server=MYSQL1001.site4now.net; Database=db_ab6528_checado; Uid=ab6528_checado; Pwd=Intervalo2024;";

            try
            {
                MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);

                return conexionBD;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
    }
}
