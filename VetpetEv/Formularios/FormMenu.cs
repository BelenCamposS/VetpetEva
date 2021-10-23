using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetpetEv.Formularios;

namespace VetpetEv.Formularios
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnHora_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCliente ventana = new FormCliente();
            ventana.Show();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormConsulta ventana = new FormConsulta();
            ventana.Show();
        }

        private void btnEspecie_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEspecie ventana = new FormEspecie();
            ventana.Show();
        }

        private void btnRaza_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRaza ventana = new FormRaza();
            ventana.Show();
        }
    }
}
