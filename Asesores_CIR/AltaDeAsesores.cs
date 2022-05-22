using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control.Controlador;
using System.Data.SqlClient;


namespace Asesores_CIR
{
    public partial class AltaDeAsesores : Form
    {
        Controlador controlador = new Controlador();
        

        public AltaDeAsesores()
        {
            InitializeComponent();
            SqlConnection conecta = new SqlConnection("Data Source=.;Initial Catalog=CIR;Integrated Security=True");
            conecta.Open();

            SqlCommand toma = new SqlCommand("select *from zonas", conecta);

            SqlDataReader toma2 = toma.ExecuteReader();
            while (toma2.Read())
            {
                comboBoxZonas.Items.Add(toma2["NumeroZona"].ToString());
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            controlador.validaDatos.revisaEventoSoloLetras(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<TextBox> componentes = new List<TextBox>();
            List<ComboBox> combos = new List<ComboBox>();
            

            componentes.Add(TextBoxNumEmpleado);
            componentes.Add(textBoxNombre);
            componentes.Add(textBoxApellidoPat);
            componentes.Add(textBoxApellidoMat);
         // componentes.Add(textBoxTerritorio);
            componentes.Add(textBoxPuesto);
            componentes.Add(textBoxMail);
            componentes.Add(textBoxContratado);
            componentes.Add(textBoxCelular);
            componentes.Add(FechaA1);
            componentes.Add(FechaA2);
            componentes.Add(FechaA3);
            componentes.Add(textBoxFechaC1);
            componentes.Add(textBoxFechaC2);
            componentes.Add(textBoxFechaC3);
            componentes.Add(textBoxFechaL1);
            componentes.Add(textBoxFechaL2);
            componentes.Add(textBoxFechaL3);

            if (gerente.Checked)
            {
                textBox1gerente.Text = "1"; 
            }
            else 
            {
                textBox1gerente.Text = "0";
            }
            componentes.Add(textBox1gerente);

            combos.Add(comboBoxZonas);
            combos.Add(comboBoxAuto);

            controlador.enviaDatos(componentes,combos,pictureBoxFoto);

            foreach(TextBox box in componentes)
            {
                box.Text="";
            }

            comboBoxAuto.Text = "Automóvil";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            controlador.validaDatos.revisaEventoSoloNumeros(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            controlador.validaDatos.revisaEventoSoloLetras(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            controlador.validaDatos.revisaEventoSoloLetras(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            controlador.validaDatos.revisaEventoSoloLetras(e);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            controlador.validaDatos.revisaEventoSoloLetras(e);
        }

        private void textBox7_CursorChanged(object sender, EventArgs e)
        {
            controlador.validaDatos.validaMail(textBoxMail.Text);
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            controlador.validaDatos.validaMail(textBoxMail);
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            controlador.validaDatos.revisaEventoSoloLetras(e);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            controlador.validaDatos.revisaEventoTelefono(e);
        }

        private void FechaA1_KeyPress(object sender, KeyPressEventArgs e)
        {
            controlador.validaDatos.revisaEventoSoloNumeros(e);
        }

        private void FechaA2_KeyPress(object sender, KeyPressEventArgs e)
        {
            controlador.validaDatos.revisaEventoSoloNumeros(e);
        }

        private void FechaA3_KeyPress(object sender, KeyPressEventArgs e)
        {
            controlador.validaDatos.revisaEventoSoloNumeros(e);
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            controlador.validaDatos.revisaEventoSoloNumeros(e);
        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            controlador.validaDatos.revisaEventoSoloNumeros(e);
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            controlador.validaDatos.revisaEventoSoloNumeros(e);
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            controlador.validaDatos.revisaEventoSoloNumeros(e);
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            controlador.validaDatos.revisaEventoSoloNumeros(e);
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            controlador.validaDatos.revisaEventoSoloNumeros(e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBoxFoto.ImageLocation = controlador.validaDatos.cargaElemento(pictureBoxFoto);
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
