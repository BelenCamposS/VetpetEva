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
    public partial class FormMascota : Form
    {
        private vetPetEntities db = new vetPetEntities();

        public FormMascota()
        {
            InitializeComponent();
        }
        private void Guardar()
        {
            Mascota m = new Mascota();
            m.nombre_mascota = txtNombremascota.Text.Trim();
            m.sexo = cbSexo.Text.Trim();
            m.fecha_nac = dtpFechaNac.Value;
            

            db.Mascota.Add(m);
            db.SaveChanges();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Validar();
            Guardar();
        }
        private string Validar()
        {
            string msj = "";
            if (string.IsNullOrEmpty(txtNombremascota.Text.Trim()))
                msj = "Debe agregar un nombre de mascota \n";
            if (string.IsNullOrEmpty(cbSexo.Text.Trim()))
                msj = "Debe agregar un sexo \n";
            if (string.IsNullOrEmpty(dtpFechaNac.Text.Trim()))
                msj = "Debe agregar una fecha \n";
            if (string.IsNullOrEmpty(txtEspecie.Text.Trim()))
                msj = "Debe agregar una especie \n";
            return msj;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            txtNombremascota.Text = "";
            cbSexo.Items.Clear();
            dtpFechaNac.Value = DateTime.Now;
            txtEspecie.Text = "";
            btnEliminar.Enabled = false;
        }

    }
}
