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
    public partial class FormEspecie : Form
    {
        private vetPetEntities db = new vetPetEntities();
        int idEspecie = 0;
        public FormEspecie()
        {
            InitializeComponent();
            cargarEspecies();
        }

        //METODOS
        private bool buscarNombre(string nombre)
        {
            var q = db.Especie.FirstOrDefault(m => m.nombre_especie == nombre);
            if (q != null)
            {
                return false;
            }
            return true;
        }
        private void cargarEspecies()
        {
            var listaEspecies = db.Especie.ToList();
            dgvEspecie.DataSource = listaEspecies;
            dgvEspecie.Columns[2].Visible = false;
        }
        private void limpiar()
        {
            idEspecie = 0;
            txtNombre.Text = "";
            dgvEspecie.ClearSelection();
            btnEliminar.Enabled = false;
        }
        private void dgvEspecie_MouseClick(object sender, MouseEventArgs e)
        {

            idEspecie = int.Parse(dgvEspecie.CurrentRow.Cells[0].Value.ToString());
            txtNombre.Text = dgvEspecie.CurrentRow.Cells[1].Value.ToString();

            btnEliminar.Enabled = true;
        }
        //METODOS


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() != "")
            {
                if (idEspecie == 0)
                {
                    if (buscarNombre(txtNombre.Text.Trim()))
                    {
                        Especie especie = new Especie();
                        especie.nombre_especie = txtNombre.Text.Trim();
                        db.Especie.Add(especie);
                        //Error por bd al no declarar la id como Identity
                        db.SaveChanges();
                        limpiar();
                        cargarEspecies();
                    }
                    else
                    {
                        MessageBox.Show("La especie ya está registrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (buscarNombre(txtNombre.Text.Trim()))
                    {
                        var especie = db.Especie.Find(idEspecie);
                        if (especie != null)
                        {
                            especie.nombre_especie = txtNombre.Text;
                            db.SaveChanges();
                            limpiar();
                            cargarEspecies();
                        }
                    }
                    else
                    {
                        MessageBox.Show("La especie ya está registrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe ingrese un nombre de especie");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idEspecie > 0)
            {
                Especie especie = db.Especie.Find(idEspecie);

                if (especie != null)
                {
                    db.Especie.Remove(especie);
                    db.SaveChanges();
                    MessageBox.Show("Eliminado con éxito!");
                    limpiar();
                    cargarEspecies();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
