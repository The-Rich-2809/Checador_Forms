using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checador_Forms.Clases
{
    internal class Checador_SQL
    {
        public DataTable Mostrar_Empleados()
        {
            DataTable dt = new DataTable();

            string sql = "SELECT * From empleados";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.Parameters.AddWithValue("idSite", Datos.IdSite);
                dt.Load(comando.ExecuteReader());

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al buscar " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
            return dt;
        }

        public DataTable Mostrar_EmpleadoSite()
        {
            DataTable dt = new DataTable();

            string sql = "SELECT * From empleadosite Where idSite = @idSite";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.Parameters.AddWithValue("idSite", Datos.IdSite);
                dt.Load(comando.ExecuteReader());

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al buscar " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
            return dt;
        }
        public bool RegistroChecar()
        {
            DataTable dt = new DataTable();

            string sql = "Insert Into registros (idEmpleado, idSite, idEncargado, registro) values (@idEmpleado, @idSite, @idEncargado ,@registro)";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.Parameters.AddWithValue("idEmpleado", Datos.IdEmpleado);
                comando.Parameters.AddWithValue("idSite", Datos.IdSite);
                comando.Parameters.AddWithValue("idEncargado", Datos.IdEncargado);
                comando.Parameters.AddWithValue("registro", Datos.Registro);
                comando.ExecuteNonQuery();
                conexionBD.Close();
                return true;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al buscar " + ex.Message);
                conexionBD.Close();
                return false;
            }
        }

    }
}
