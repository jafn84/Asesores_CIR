namespace Asesores_CIR
{
    partial class ZonasDeVenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxZona = new System.Windows.Forms.TextBox();
            this.textBoxEstado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMunicipio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxNumeroDeZona = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Zona";
            // 
            // textBoxZona
            // 
            this.textBoxZona.Location = new System.Drawing.Point(34, 106);
            this.textBoxZona.Name = "textBoxZona";
            this.textBoxZona.Size = new System.Drawing.Size(162, 20);
            this.textBoxZona.TabIndex = 1;
            // 
            // textBoxEstado
            // 
            this.textBoxEstado.Location = new System.Drawing.Point(34, 171);
            this.textBoxEstado.Name = "textBoxEstado";
            this.textBoxEstado.Size = new System.Drawing.Size(162, 20);
            this.textBoxEstado.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estado";
            // 
            // textBoxMunicipio
            // 
            this.textBoxMunicipio.Location = new System.Drawing.Point(34, 231);
            this.textBoxMunicipio.Name = "textBoxMunicipio";
            this.textBoxMunicipio.Size = new System.Drawing.Size(162, 20);
            this.textBoxMunicipio.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Municipio";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxNumeroDeZona
            // 
            this.textBoxNumeroDeZona.Location = new System.Drawing.Point(35, 39);
            this.textBoxNumeroDeZona.Name = "textBoxNumeroDeZona";
            this.textBoxNumeroDeZona.Size = new System.Drawing.Size(162, 20);
            this.textBoxNumeroDeZona.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Numero de Zona";
            // 
            // ZonasDeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 336);
            this.Controls.Add(this.textBoxNumeroDeZona);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxMunicipio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxZona);
            this.Controls.Add(this.label1);
            this.Name = "ZonasDeVenta";
            this.Text = "ZonasDeVenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxZona;
        private System.Windows.Forms.TextBox textBoxEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMunicipio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxNumeroDeZona;
        private System.Windows.Forms.Label label4;
    }
}