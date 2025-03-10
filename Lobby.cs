using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Checador_Forms.Clases;

namespace Checador_Forms
{
    public partial class Lobby : MaterialSkin.Controls.MaterialForm
    {
        public Lobby()
        {
            InitializeComponent();
        }

        private void ChecadorBtn_Click(object sender, EventArgs e)
        {
            Checador checador = new Checador();
            checador.Text = "Checador de " + Datos.NombreSite;
            checador.ShowDialog();
        }

        private void RegistrarBtn_Click(object sender, EventArgs e)
        {
            Registros registros = new Registros();
            registros.Text = "Registros de " + Datos.NombreSite;
            registros.ShowDialog();
        }
    }
}
