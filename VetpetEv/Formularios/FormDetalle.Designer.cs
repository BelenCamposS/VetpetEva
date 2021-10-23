
namespace VetpetEv
{
    partial class FormConsulta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtDiag = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtReceta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // txtObs
            // 
            this.txtObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObs.Location = new System.Drawing.Point(400, 274);
            this.txtObs.Margin = new System.Windows.Forms.Padding(4);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(591, 136);
            this.txtObs.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(77, 448);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 31);
            this.label5.TabIndex = 22;
            this.label5.Text = "Diagnóstico:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(77, 278);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 31);
            this.label6.TabIndex = 21;
            this.label6.Text = "Observación:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(77, 223);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 31);
            this.label7.TabIndex = 20;
            this.label7.Text = "Peso:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 42);
            this.label1.TabIndex = 28;
            this.label1.Text = "Detalle consulta";
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(400, 219);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(4);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(591, 37);
            this.txtPeso.TabIndex = 29;
            // 
            // txtDiag
            // 
            this.txtDiag.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiag.Location = new System.Drawing.Point(400, 444);
            this.txtDiag.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiag.Multiline = true;
            this.txtDiag.Name = "txtDiag";
            this.txtDiag.Size = new System.Drawing.Size(591, 80);
            this.txtDiag.TabIndex = 30;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtReceta
            // 
            this.txtReceta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceta.Location = new System.Drawing.Point(400, 555);
            this.txtReceta.Margin = new System.Windows.Forms.Padding(4);
            this.txtReceta.Multiline = true;
            this.txtReceta.Name = "txtReceta";
            this.txtReceta.Size = new System.Drawing.Size(591, 117);
            this.txtReceta.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 559);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 31);
            this.label2.TabIndex = 31;
            this.label2.Text = "Receta:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(1111, 361);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(184, 62);
            this.btnGuardar.TabIndex = 33;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardarConsulta_Click);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(83, 756);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.RowHeadersWidth = 51;
            this.dgvDetalle.RowTemplate.Height = 24;
            this.dgvDetalle.Size = new System.Drawing.Size(1117, 150);
            this.dgvDetalle.TabIndex = 34;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(1111, 462);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(184, 62);
            this.btnEliminar.TabIndex = 35;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(1111, 559);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(184, 62);
            this.btnLimpiar.TabIndex = 36;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FormConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(1299, 991);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtReceta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDiag);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormConsulta";
            this.Text = "FormConsulta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtDiag;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtReceta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}