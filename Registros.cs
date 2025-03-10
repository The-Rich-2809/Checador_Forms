using Checador_Forms.Clases;
using DPFP;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checador_Forms
{
    public partial class Registros : MaterialSkin.Controls.MaterialForm
    {
        private DPFP.Template Template;
        Empleados_SQL empleados = new Empleados_SQL();
        Checador_SQL checador = new Checador_SQL();
        static int id = 0;
        static string boton = "";
        static int idEncargado = 0;
        public static DataTable Manager { get; set; }
        public Registros()
        {
            InitializeComponent();
        }

        private void Registros_Load(object sender, EventArgs e)
        {
            Limpiar();
        }
        public void Limpiar()
        {
            TablaEmpleadosDGV.Enabled = true;
            ControlesGB.Enabled = true;
            EditarGB.Enabled = false;
            TablaEmpleadosDGV.DataSource = empleados.Mostrar_Empleados();

            NombreText.Text = "";
            Apellido1Text.Text = "";
            Apellido2Text.Text = "";
            EncargadoCB.Text = "";
            TipoUsuarioCB.Text = "";
            HuellaText.Text = "";
            Template = null;

            EncargadoCB.Items.Clear();
            TipoUsuarioCB.Items.Clear();
        }
        private void OnTemplate(DPFP.Template template)
        {
            this.Invoke(new Function(delegate ()
            {
                Template = template;
                if(boton == "Agregar")
                {
                    AgregarRegistroBtn.Enabled = true;
                }
                if (Template != null)
                {
                    MessageBox.Show("The fingerprint template is ready for fingerprint verification.", "Fingerprint Enrollment");
                    HuellaText.Text = "Huella capturada correctamente";
                }
                else
                {
                    MessageBox.Show("The fingerprint template is not valid. Repeat fingerprint enrollment.", "Fingerprint Enrollment");
                }
            }));
        }
        static string GenerarSHA256Base64(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hashBytes);
            }
        }
        private void ActualizarBtn_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void TipoUsuarioCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TipoUsuarioCB.Text == "Empleado")
            {
                EncargadoCB.Enabled = true;
            }
            else
            {
                EncargadoCB.Enabled = false;
                EncargadoCB.Text = "";
            }
        }
        public void Registro()
        {
            Datos.HuellaSring = Template.Bytes;
            MandarDatos();
            DataTable dt = checador.Mostrar_Empleados();
            bool existe = true;

            foreach (DataRow row in dt.Rows)
            {
                if (Datos.Hash == row[9].ToString())
                {
                    MessageBox.Show("El empleado ya existe");
                    existe = false;
                }
            }

            if (existe)
            {
                if (empleados.Agregar_Empleado())
                {
                    MessageBox.Show("Empleado agregado correctamente");
                    Template = null;
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Error al agregar empleado");
                }
            }
        }
        public void MandarDatos()
        {
            Datos.NombreEmpleado = NombreText.Text;
            Datos.Apellido1 = Apellido1Text.Text;
            Datos.Apellido2 = Apellido2Text.Text;
            Datos.TipoUsuario = TipoUsuarioCB.Text;

            if (TipoUsuarioCB.Text == "Empleado")
            {
                Datos.Encargado = EncargadoCB.Text;
                foreach (DataRow row in Manager.Rows)
                {
                    if (Datos.Encargado == row[1].ToString() + " " + row[2].ToString())
                    {
                        Datos.IdEncargado = Convert.ToInt32(row[0]);
                        break;
                    }
                }
            }
            else
            {
                Datos.Encargado = TipoUsuarioCB.Text;
                Datos.IdEncargado = 0;
            }
            Datos.Hash = GenerarSHA256Base64(Datos.NombreEmpleado + Datos.Apellido1 + Datos.Apellido2 + Datos.TipoUsuario + Datos.Encargado);
        }
        private void AgregarHuellaBtn_Click(object sender, EventArgs e)
        {
            CapturarHuella capturarHuella = new CapturarHuella();
            capturarHuella.OnTemplate += this.OnTemplate;
            capturarHuella.ShowDialog();
        }


        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            Controles();
            boton = "Agregar";
            idEncargado = 0;
        }
        private void AgregarRegistroBtn_Click(object sender, EventArgs e)
        {
            if (TipoUsuarioCB.Text == "Administrador" || TipoUsuarioCB.Text == "Manager")
            {
                if (NombreText.Text == "" || Apellido1Text.Text == "" || Apellido2Text.Text == "" || TipoUsuarioCB.Text == "")
                {
                    MessageBox.Show("Favor de llenar todos los campos");
                }
                else
                {
                    Registro();
                }
            }
            else
            {
                if (NombreText.Text == "" || Apellido1Text.Text == "" || Apellido2Text.Text == "" || EncargadoCB.Text == "" || TipoUsuarioCB.Text == "")
                {
                    MessageBox.Show("Favor de llenar todos los campos");
                }
                else
                {
                    Registro();
                }
            }
        }

        private void ModificarBtn_Click(object sender, EventArgs e)
        {
            int renglon = TablaEmpleadosDGV.CurrentRow.Index;
            idEncargado = Convert.ToInt32(TablaEmpleadosDGV.Rows[renglon].Cells[0].Value);
            boton = "Modificar";
            Controles();
            ModificarRegistroBtn.Enabled = true;
            id = Convert.ToInt32(TablaEmpleadosDGV.Rows[renglon].Cells[0].Value);
            NombreText.Text = TablaEmpleadosDGV.Rows[renglon].Cells[1].Value.ToString();
            Apellido1Text.Text = TablaEmpleadosDGV.Rows[renglon].Cells[2].Value.ToString();
            Apellido2Text.Text = TablaEmpleadosDGV.Rows[renglon].Cells[3].Value.ToString();
            TipoUsuarioCB.Text = TablaEmpleadosDGV.Rows[renglon].Cells[4].Value.ToString();
            HuellaText.Text = "Huella capturada correctamente";

            if (TipoUsuarioCB.Text == "Empleado")
            {
                EncargadoCB.Text = TablaEmpleadosDGV.Rows[renglon].Cells[5].Value.ToString();
                EncargadoCB.Enabled = true;
            }
            else
            {
                EncargadoCB.Enabled = false;
                EncargadoCB.Text = "";
            }
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            int renglon = TablaEmpleadosDGV.CurrentRow.Index;
            string hash = TablaEmpleadosDGV.Rows[renglon].Cells[6].Value.ToString();

            DialogResult result = MessageBox.Show("¿Deseas eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                empleados.Eliminar_Empleado(hash);
                MessageBox.Show("Registro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
        }
        public void Controles()
        {
            ControlesGB.Enabled = false;
            EditarGB.Enabled = true;
            ModificarRegistroBtn.Enabled = false;
            TablaEmpleadosDGV.Enabled = false;
            AgregarRegistroBtn.Enabled = false;
            DataTable data = empleados.Enviar_Manager();
            Manager = data;

            foreach (DataRow row in data.Rows)
            {
                if(boton == "Modificar")
                {
                    if (Convert.ToInt32(row[0]) != idEncargado)
                    {
                        EncargadoCB.Items.Add(row[1].ToString() + " " + row[2].ToString());
                    }
                }
                else
                {
                    EncargadoCB.Items.Add(row[1].ToString() + " " + row[2].ToString());
                }
               
            }
            foreach (var i in Datos.Usuarios)
            {
                TipoUsuarioCB.Items.Add(i);
            }
            idEncargado = 0;
            boton = "";
        }

        private void ModificarRegistroBtn_Click(object sender, EventArgs e)
        {
            if (TipoUsuarioCB.Text == "Administrador" || TipoUsuarioCB.Text == "Manager")
            {
                if (NombreText.Text == "" || Apellido1Text.Text == "" || Apellido2Text.Text == "" || TipoUsuarioCB.Text == "")
                {
                    MessageBox.Show("Favor de llenar todos los campos");
                }
                else
                {
                    Modificar_Registro();
                }
            }
            else
            {
                if (NombreText.Text == "" || Apellido1Text.Text == "" || Apellido2Text.Text == "" || EncargadoCB.Text == "" || TipoUsuarioCB.Text == "")
                {
                    MessageBox.Show("Favor de llenar todos los campos");
                }
                else
                {
                    Modificar_Registro();
                }
            }
        }
        public void Modificar_Registro()
        {
            DataTable dt = checador.Mostrar_Empleados();
            bool existe = true;
            int h = 0;
            if (Template != null)
            {
                Datos.HuellaSring = Template.Bytes;
                h = 1;
            }
            MandarDatos();
            foreach (DataRow row in dt.Rows)
            {
                if (Datos.Hash == row[9].ToString())
                {
                    if (row[0].ToString() != id.ToString())
                    {
                        MessageBox.Show("El empleado ya existe");
                        existe = false;
                        break;
                    }
                }
            }
            if (existe)
            {
                if (empleados.Mod_Empleado(id, h))
                {
                    MessageBox.Show("Empleado modificado correctamente");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Error al agregar empleado");
                }
            }
        }
    }
}
