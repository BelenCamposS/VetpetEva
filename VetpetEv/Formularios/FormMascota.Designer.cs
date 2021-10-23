
namespace VetpetEv
{
    partial class FormMascota
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombremascota = new System.Windows.Forms.TextBox();
            this.dgvRegistroMasc = new System.Windows.Forms.DataGridView();
            this.mascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroMasc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro Mascota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre mascota:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Especie:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(71, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha de nacimiento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(71, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Sexo:";
            // 
            // txtNombremascota
            // 
            this.txtNombremascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombremascota.Location = new System.Drawing.Point(313, 179);
            this.txtNombremascota.Name = "txtNombremascota";
            this.txtNombremascota.Size = new System.Drawing.Size(444, 31);
            this.txtNombremascota.TabIndex = 8;
            // 
            // dgvRegistroMasc
            // 
            this.dgvRegistroMasc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroMasc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mascota,
            this.sexo,
            this.Fecha,
            this.Especie});
            this.dgvRegistroMasc.Location = new System.Drawing.Point(325, 389);
            this.dgvRegistroMasc.Name = "dgvRegistroMasc";
            this.dgvRegistroMasc.RowHeadersWidth = 51;
            this.dgvRegistroMasc.Size = new System.Drawing.Size(542, 196);
            this.dgvRegistroMasc.TabIndex = 12;
            // 
            // mascota
            // 
            this.mascota.HeaderText = "Nombre mascota";
            this.mascota.MinimumWidth = 6;
            this.mascota.Name = "mascota";
            this.mascota.Width = 125;
            // 
            // sexo
            // 
            this.sexo.HeaderText = "Sexo";
            this.sexo.MinimumWidth = 6;
            this.sexo.Name = "sexo";
            this.sexo.Width = 125;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha de nacimiento";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 125;
            // 
            // Especie
            // 
            this.Especie.HeaderText = "Especie";
            this.Especie.MinimumWidth = 6;
            this.Especie.Name = "Especie";
            this.Especie.Width = 125;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(958, 136);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(157, 45);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(958, 207);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(157, 45);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(958, 272);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(157, 45);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cbSexo
            // 
            this.cbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Location = new System.Drawing.Point(313, 224);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(444, 33);
            this.cbSexo.TabIndex = 16;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNac.Location = new System.Drawing.Point(313, 267);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(444, 31);
            this.dtpFechaNac.TabIndex = 18;
            // 
            // txtEspecie
            // 
            this.txtEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspecie.Location = new System.Drawing.Point(313, 314);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(444, 31);
            this.txtEspecie.TabIndex = 19;
            // 
            // FormMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1280, 627);
            this.Controls.Add(this.txtEspecie);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvRegistroMasc);
            this.Controls.Add(this.txtNombremascota);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "FormMascota";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroMasc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombremascota;
        private System.Windows.Forms.DataGridView dgvRegistroMasc;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn mascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especie;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.TextBox txtEspecie;
    }
}

