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
    public partial class FormConsulta : Form
    {
        private vetPetEntities db = new vetPetEntities();
        int idDetalle = 0;
        public FormConsulta()
        {
            InitializeComponent();
        }
        private void Guardar()
        {
            Detalle_consulta d = new Detalle_consulta();
            d.peso = txtPeso.Text.Trim();
            d.observación = txtObs.Text.Trim();
            d.diagnostico = txtDiag.Text.Trim();
            d.receta = txtReceta.Text.Trim();

            db.Detalle_consulta.Add(d);
            db.SaveChanges();
        }
        private void limpiar()
        {
            idDetalle = 0;
            txtPeso.Text = "";
            txtObs.Text = "";
            txtDiag.Text = "";
            txtReceta.Text = "";
            dgvDetalle.ClearSelection();
            btnEliminar.Enabled = false;
        }
        private void cargarDetalles()
        {
            var listaDetalles = db.Detalle_consulta.ToList();
            dgvDetalle.DataSource = listaDetalles;
            
        }
        private string Validar()
        {
            string msj = "";
            if (string.IsNullOrEmpty(txtPeso.Text.Trim()))
                msj = "Debe definir un peso \n";
            if (string.IsNullOrEmpty(txtObs.Text.Trim()))
                msj = "Debe agregar observaciones \n";
            if (string.IsNullOrEmpty(txtDiag.Text.Trim()))
                msj = "Debe agregar un diagnostico \n";
            if (string.IsNullOrEmpty(txtReceta.Text.Trim()))
                msj = "Debe agregar una receta \n";
            return msj;
        }
        private void dgvDetalle_MouseClick(object sender, MouseEventArgs e)
        {

            idDetalle = int.Parse(dgvDetalle.CurrentRow.Cells[0].Value.ToString());
            txtPeso.Text = dgvDetalle.CurrentRow.Cells[1].Value.ToString();
            txtObs.Text = dgvDetalle.CurrentRow.Cells[2].Value.ToString();
            txtDiag.Text = dgvDetalle.CurrentRow.Cells[3].Value.ToString();
            txtReceta.Text = dgvDetalle.CurrentRow.Cells[4].Value.ToString();

            btnEliminar.Enabled = true;
        }
        private void btnGuardarConsulta_Click(object sender, EventArgs e)
        {

            string error = Validar();
            if (error != "")
            {
                MessageBox.Show(error, "Falta datos");
            }
            else
            {
                if (idDetalle == 0)
                {
                    Guardar();
                }

                MessageBox.Show("EL registro se ha guardado con éxito");
               
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idDetalle > 0)
            {
                Detalle_consulta detalle = db.Detalle_consulta.Find(idDetalle);

                if (detalle != null)
                {
                    db.Detalle_consulta.Remove(detalle);
                    db.SaveChanges();
                    MessageBox.Show("Eliminado con éxito!");
                    limpiar();
                    
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
