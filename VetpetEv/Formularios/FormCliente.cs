using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetpetEv.Models;

namespace VetpetEv
{
    public partial class FormCliente : Form
    {
        private vetPetEntities db = new vetPetEntities();
        int idCliente = 0;
        public FormCliente()
        {
            InitializeComponent();
        }

        private void Guardar()
        {
            Cliente p = new Cliente();
            p.nombre_cliente = txtDueño.Text.Trim();
            p.rut = txtRut.Text.Trim();
            p.contacto = txtContacto.Text.Trim();

            db.Cliente.Add(p);
            db.SaveChanges();
        }
        private string Validar()
        {
            string msj = "";
            if (string.IsNullOrEmpty(txtDueño.Text.Trim()))
                msj = "Debe escribir un nombre \n";
            if (string.IsNullOrEmpty(txtRut.Text.Trim()))
                msj = "Debe escribir un rut \n";
            if (string.IsNullOrEmpty(txtContacto.Text.Trim()))
                msj = "Debe escribir un número de contacto \n";
            return msj;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string error = Validar();
            if (error != "")
            {
                MessageBox.Show(error, "Falta datos");
            }
            else
            {
                if (idCliente == 0)
                {
                    Guardar();
                    
                }
                
                MessageBox.Show("EL registro se ha guardado con éxito");
                this.Hide();
                FormMascota ventana = new FormMascota();
                ventana.Show();
            }
    }
}
}
