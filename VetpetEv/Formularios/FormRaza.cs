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
    public partial class FormRaza : Form
    {
        private vetPetEntities db = new vetPetEntities();
        int idRaza = 0;
        public FormRaza()
        {
            InitializeComponent();
            cargarRazas();
        }

        //METODOS
        private bool buscarNombre(string nombre)
        {           
            var q = db.Raza.FirstOrDefault(m => m.nombre_raza == nombre);           
            if (q != null)
            {           
                return false;
            }           
            return true;
        }
        private void cargarRazas()
        {           
            var listaRazas = db.Raza.ToList();
            dgvRaza.DataSource = listaRazas;
            dgvRaza.Columns[2].Visible = false;
        }
        private void limpiar()
        {
            idRaza = 0;
            txtNombre.Text = "";            
            dgvRaza.ClearSelection();
            btnEliminar.Enabled = false;
        }
        private void dgvRaza_MouseClick(object sender, MouseEventArgs e)
        {
            
            idRaza = int.Parse(dgvRaza.CurrentRow.Cells[0].Value.ToString());
            txtNombre.Text = dgvRaza.CurrentRow.Cells[1].Value.ToString();

            btnEliminar.Enabled = true;
        }
        //METODOS

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() != "")
            {
                if (idRaza == 0)
                {
                    if (buscarNombre(txtNombre.Text.Trim()))
                    {                       
                        Raza raza = new Raza();                     
                        raza.nombre_raza = txtNombre.Text.Trim();
                        db.Raza.Add(raza);
                                          
                        db.SaveChanges();
                        limpiar();
                        cargarRazas();
                    }
                    else
                    {
                        MessageBox.Show("La raza ya está registrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (buscarNombre(txtNombre.Text.Trim()))
                    {                       
                        var raza = db.Raza.Find(idRaza);                        
                        if (raza != null)
                        {
                            raza.nombre_raza = txtNombre.Text;
                            db.SaveChanges();
                            limpiar();
                            cargarRazas();
                        }
                    }
                    else
                    {
                        MessageBox.Show("La raza ya está registrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe ingrese un nombre de raza");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idRaza > 0)
            {
                Raza raza = db.Raza.Find(idRaza);

                if (raza != null)
                {                    
                    db.Raza.Remove(raza);                    
                    db.SaveChanges();
                    MessageBox.Show("Eliminado con éxito!");
                    limpiar();
                    cargarRazas();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}