
namespace VetpetEv
{
    partial class FormCliente
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
            this.btnGuardarEspecie = new System.Windows.Forms.Button();
            this.txtDueño = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuardarEspecie
            // 
            this.btnGuardarEspecie.Location = new System.Drawing.Point(0, 0);
            this.btnGuardarEspecie.Name = "btnGuardarEspecie";
            this.btnGuardarEspecie.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarEspecie.TabIndex = 19;
            // 
            // txtDueño
            // 
            this.txtDueño.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDueño.Location = new System.Drawing.Point(363, 160);
            this.txtDueño.Margin = new System.Windows.Forms.Padding(4);
            this.txtDueño.Name = "txtDueño";
            this.txtDueño.Size = new System.Drawing.Size(487, 37);
            this.txtDueño.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombre cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 42);
            this.label1.TabIndex = 11;
            this.label1.Text = "Registro Cliente";
            // 
            // txtRut
            // 
            this.txtRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRut.Location = new System.Drawing.Point(363, 220);
            this.txtRut.Margin = new System.Windows.Forms.Padding(4);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(487, 37);
            this.txtRut.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 224);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 31);
            this.label2.TabIndex = 15;
            this.label2.Text = "Rut:";
            // 
            // txtContacto
            // 
            this.txtContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContacto.Location = new System.Drawing.Point(363, 284);
            this.txtContacto.Margin = new System.Windows.Forms.Padding(4);
            this.txtContacto.MaxLength = 12;
            this.txtContacto.MinimumSize = new System.Drawing.Size(9, 4);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(487, 37);
            this.txtContacto.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(128, 288);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 31);
            this.label4.TabIndex = 17;
            this.label4.Text = "Contacto:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(488, 380);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(210, 69);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtContacto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGuardarEspecie);
            this.Controls.Add(this.txtDueño);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCliente";
            this.Text = "FormHora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarEspecie;
        private System.Windows.Forms.TextBox txtDueño;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardar;
    }
}