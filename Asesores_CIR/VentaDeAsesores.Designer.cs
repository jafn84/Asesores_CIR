namespace Asesores_CIR
{
    partial class VentaDeAsesores
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
            this.panelAsesores = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelDia = new System.Windows.Forms.Label();
            this.labelMes = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelAsesores
            // 
            this.panelAsesores.AutoScroll = true;
            this.panelAsesores.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelAsesores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAsesores.Location = new System.Drawing.Point(29, 55);
            this.panelAsesores.Name = "panelAsesores";
            this.panelAsesores.Size = new System.Drawing.Size(317, 587);
            this.panelAsesores.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Venta Diaria Mes de Abril";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Guardar Datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(358, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Automatizado";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(358, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Borrar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // labelDia
            // 
            this.labelDia.AutoSize = true;
            this.labelDia.Location = new System.Drawing.Point(272, 13);
            this.labelDia.Name = "labelDia";
            this.labelDia.Size = new System.Drawing.Size(21, 13);
            this.labelDia.TabIndex = 5;
            this.labelDia.Text = "dia";
            // 
            // labelMes
            // 
            this.labelMes.AutoSize = true;
            this.labelMes.Location = new System.Drawing.Point(299, 13);
            this.labelMes.Name = "labelMes";
            this.labelMes.Size = new System.Drawing.Size(26, 13);
            this.labelMes.TabIndex = 6;
            this.labelMes.Text = "mes";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(331, 13);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(27, 13);
            this.labelYear.TabIndex = 7;
            this.labelYear.Text = "year";
            // 
            // VentaDeAsesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 725);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelMes);
            this.Controls.Add(this.labelDia);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelAsesores);
            this.Name = "VentaDeAsesores";
            this.Text = "VentaDeAsesores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAsesores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelDia;
        private System.Windows.Forms.Label labelMes;
        private System.Windows.Forms.Label labelYear;
    }
}