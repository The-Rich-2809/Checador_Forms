using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Checador_Forms.Clases;

namespace Checador_Forms.Clases
{
    internal class Login_SQL
    {
        public bool Ingresar (string Correo, string Contrasena)
        {
            MySqlDataReader reader = null;


            string sql = "SELECT * From sites WHERE Correo = @Correo AND Contrasena = @Contrasena LIMIT 1";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.Parameters.AddWithValue("Correo", Correo);
                comando.Parameters.AddWithValue("Contrasena", Contrasena);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Datos.IdSite = reader.GetInt32(0);
                        Datos.NombreSite = reader.GetString(1);
                    }
                        
                    return true;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al buscar " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
            return false;

            
        }
    }
}
