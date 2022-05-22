using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asesores_CIR.Reportes
{
    public partial class FechaParaReporteClientesConVenta : Form
    {
        public FechaParaReporteClientesConVenta()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reportes.ReporteClientesConVenta reporte = new ReporteClientesConVenta(dateTimePicker1.Value.Year.ToString() + "-" + dateTimePicker1.Value.Month.ToString() + "-" + dateTimePicker1.Value.Day.ToString());
            reporte.Visible = true;
            this.Close();

        }

    }
}
