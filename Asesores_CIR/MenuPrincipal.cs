using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asesores_CIR
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaDeAsesores Asesores = new AltaDeAsesores();
            Asesores.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ZonasDeVenta Zonas = new ZonasDeVenta();
            Zonas.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VentaDeAsesores Ventas = new VentaDeAsesores();
            Ventas.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reportes.FechaParaReporte VentasDiario = new Reportes.FechaParaReporte();
            VentasDiario.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AltaDeObjetivo objetivos = new AltaDeObjetivo();
            objetivos.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ClientesConVentaDeAsesores clientesConVentasPantalla = new ClientesConVentaDeAsesores();
            clientesConVentasPantalla.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            Reportes.FechaParaReporteClientesConVenta a = new Reportes.FechaParaReporteClientesConVenta();
            a.Visible = true;

        }
    }
}
