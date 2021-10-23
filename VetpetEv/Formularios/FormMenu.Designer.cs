
namespace VetpetEv.Formularios
{
    partial class FormMenu
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
            this.Formularios = new System.Windows.Forms.Label();
            this.btnHora = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEspecie = new System.Windows.Forms.Button();
            this.btnRaza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Formularios
            // 
            this.Formularios.AutoSize = true;
            this.Formularios.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Formularios.Location = new System.Drawing.Point(204, 35);
            this.Formularios.Name = "Formularios";
            this.Formularios.Size = new System.Drawing.Size(142, 29);
            this.Formularios.TabIndex = 0;
            this.Formularios.Text = "Formularios";
            // 
            // btnHora
            // 
            this.btnHora.Location = new System.Drawing.Point(50, 119);
            this.btnHora.Name = "btnHora";
            this.btnHora.Size = new System.Drawing.Size(179, 96);
            this.btnHora.TabIndex = 1;
            this.btnHora.Text = "Registrar hora";
            this.btnHora.UseVisualStyleBackColor = true;
            this.btnHora.Click += new System.EventHandler(this.btnHora_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(321, 119);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(179, 96);
            this.btnDetalle.TabIndex = 2;
            this.btnDetalle.Text = "Detalles consulta";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Agregar";
            // 
            // btnEspecie
            // 
            this.btnEspecie.Location = new System.Drawing.Point(50, 328);
            this.btnEspecie.Name = "btnEspecie";
            this.btnEspecie.Size = new System.Drawing.Size(179, 96);
            this.btnEspecie.TabIndex = 4;
            this.btnEspecie.Text = "Especie";
            this.btnEspecie.UseVisualStyleBackColor = true;
            this.btnEspecie.Click += new System.EventHandler(this.btnEspecie_Click);
            // 
            // btnRaza
            // 
            this.btnRaza.Location = new System.Drawing.Point(321, 328);
            this.btnRaza.Name = "btnRaza";
            this.btnRaza.Size = new System.Drawing.Size(179, 96);
            this.btnRaza.TabIndex = 5;
            this.btnRaza.Text = "Raza";
            this.btnRaza.UseVisualStyleBackColor = true;
            this.btnRaza.Click += new System.EventHandler(this.btnRaza_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(611, 504);
            this.Controls.Add(this.btnRaza);
            this.Controls.Add(this.btnEspecie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnHora);
            this.Controls.Add(this.Formularios);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Formularios;
        private System.Windows.Forms.Button btnHora;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEspecie;
        private System.Windows.Forms.Button btnRaza;
    }
}