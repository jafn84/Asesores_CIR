using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Asesores_CIR
{
    public partial class ZonasDeVenta : Form
    {
        public ZonasDeVenta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conecta = new SqlConnection("Data Source=.;Initial Catalog=CIR;Integrated Security=True");
            conecta.Open();

            SqlCommand escribir = new SqlCommand("insert into zonas(NombreZona,Estado,Municipio,NumeroZona)values('"+textBoxZona.Text+"','"+textBoxEstado.Text+"','"+textBoxMunicipio.Text+"','"+textBoxNumeroDeZona.Text+"')",conecta);

            escribir.ExecuteNonQuery();

            conecta.Close();

            MessageBox.Show("Zona Guardada con exito");

        }
    }
}
