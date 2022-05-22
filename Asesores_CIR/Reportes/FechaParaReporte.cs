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

namespace Asesores_CIR.Reportes
{
    public partial class FechaParaReporte : Form
    {
        public FechaParaReporte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reportes.ReporteFacturacion reporte = new ReporteFacturacion(Fecha());
            reporte.Visible = true;
            this.Close();            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Controlador datos = new Controlador();
            datos.borrarFechasConDatos("VentasDiarias",Fecha());
        }

        private String Fecha() 
        {
            return dateTimePicker1.Value.Year.ToString() + "-" + dateTimePicker1.Value.Month.ToString() + "-" + dateTimePicker1.Value.Day.ToString();
        }
    }
}
