using Checador_Forms.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checador_Forms
{
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {
        Login_SQL login = new Login_SQL();
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (login.Ingresar(CorreoText.Text, ContrasenaText.Text))
            {
                CorreoText.Text = "";
                ContrasenaText.Text = "";
                Lobby lobby = new Lobby();
                lobby.Text = "Bienvenido a " + Datos.NombreSite;
                lobby.ShowDialog();

            }
            else
            {
                MessageBox.Show("Usario y/o contraseña incorrectos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
