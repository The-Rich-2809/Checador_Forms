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
    internal class Empleados_SQL
    {
        public string Mensaje { get; set; }
        public DataTable Mostrar_Empleados()
        {
            DataTable dt = new DataTable();

            string sql = "SELECT idEmpleado, Nombre, 1erApellido, 2doApellido, TipoEmpleado, NombreEncargado, Hash From empleados Where idSite = @idSite";
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
        public DataTable Enviar_Manager()
        {
            DataTable dt = new DataTable();

            string sql = "SELECT idEmpleado, Nombre, 1erApellido From empleados WHERE idSite = @idSite and TipoEmpleado = 'Manager'";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.Parameters.AddWithValue("idSite", Datos.IdSite);
                dt.Load(comando.ExecuteReader());
                return dt;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al buscar " + ex.Message);
            }
            return dt;
        }
        public DataTable Mostrar_Sites(int id)
        {
            DataTable dt = new DataTable();

            string sql = "SELECT * From empleadosite WHERE idEmpleado = @id";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.Parameters.AddWithValue("id", id);
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

        public bool Agregar_Empleado()
        {
            DataTable dt = new DataTable();

            string sql = "Insert Into empleados (Nombre, 1erApellido, 2doApellido, Huella, idSite, TipoEmpleado, idEncargado, NombreEncargado, Hash) values (@Nombre,@1erApellido, @2doApellido,@Huella, @idSite,@TipoEmpleado ,@idEncargado ,@NombreEncargado, @Hash. @HoraEntrada, @HoraEntrada, @HoraSalida)";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.Parameters.AddWithValue("Nombre", Datos.NombreEmpleado);
                comando.Parameters.AddWithValue("1erApellido", Datos.Apellido1);
                comando.Parameters.AddWithValue("2doApellido", Datos.Apellido2);
                comando.Parameters.AddWithValue("Huella", Datos.HuellaSring);
                comando.Parameters.AddWithValue("idSite", Datos.IdSite);
                comando.Parameters.AddWithValue("TipoEmpleado", Datos.TipoUsuario);
                comando.Parameters.AddWithValue("idEncargado", Datos.IdEncargado);
                comando.Parameters.AddWithValue("NombreEncargado", Datos.Encargado);
                comando.Parameters.AddWithValue("Hash", Datos.Hash);
                comando.Parameters.AddWithValue("HoraEntrada", Datos.HoraEntrada);
                comando.Parameters.AddWithValue("HoraSalida", Datos.HoraSalida);
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
        public void Eliminar_Empleado(string hash)
        {
            string sql = "Delete From empleados Where hash = @Hash";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.Parameters.AddWithValue("Hash", hash);
                comando.ExecuteNonQuery();
                conexionBD.Close();
                Mensaje = "Empleado eliminado correctamente";
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al buscar " + ex.Message);
                conexionBD.Close();
                Mensaje = "Error al eliminar empleado";
            }
        }
        public bool Mod_Empleado(int id,int h)
        {
            string sql = "";
            if (h == 1)
                sql = "Update empleados Set Nombre = @Nombre, 1erApellido = @1erApellido, 2doApellido = @2doApellido, Huella = @Huella, TipoEmpleado = @TipoEmpleado, idEncargado = @idEncargado, NombreEncargado = @NombreEncargado, Hash = @Hash Where idEmpleado = @idEmpleado";
            else
                sql = "Update empleados Set Nombre = @Nombre, 1erApellido = @1erApellido, 2doApellido = @2doApellido, TipoEmpleado = @TipoEmpleado, idEncargado = @idEncargado, NombreEncargado = @NombreEncargado, Hash = @Hash Where idEmpleado = @idEmpleado";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.Parameters.AddWithValue("Nombre", Datos.NombreEmpleado);
                comando.Parameters.AddWithValue("1erApellido", Datos.Apellido1);
                comando.Parameters.AddWithValue("2doApellido", Datos.Apellido2);
                comando.Parameters.AddWithValue("Huella", Datos.HuellaSring);
                comando.Parameters.AddWithValue("TipoEmpleado", Datos.TipoUsuario);
                comando.Parameters.AddWithValue("idEncargado", Datos.IdEncargado);
                comando.Parameters.AddWithValue("NombreEncargado", Datos.Encargado);
                comando.Parameters.AddWithValue("Hash", Datos.Hash);
                comando.Parameters.AddWithValue("idEmpleado", id);
                comando.ExecuteNonQuery();
                conexionBD.Close();
                Mensaje = "Empleado modificado correctamente";
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
