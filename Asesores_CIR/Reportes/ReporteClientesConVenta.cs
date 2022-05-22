using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo.Modelo;
using System.Globalization;

namespace Asesores_CIR.Reportes
{
    public partial class ReporteClientesConVenta : Form
    {


        RecuperaDatos dd = new RecuperaDatos();
        private static Label zona, nombreAsesor, meta, vendido, palabraFacturacion, palabraActual, palabraObjetivo, nombreTerritorio, backlog, palabraBacklog, NombreZona;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public static string fechaDeReporte = "";

        private static PictureBox foto;
        public ReporteClientesConVenta(String fechaAr)
        {
            InitializeComponent();

            int corX = 10, corY = 110, incX = 0, incY = 0;
            int cuentaTres = 0;

            decimal sumadorFaturacionTotal = 0, sumadorBacklogTotal = 0, sumadorMetaTotal = 0;

            foreach (String[] datos in dd.ClientesConVentaReporte(fechaAr))
            {
                cuentaTres++;


                zona = new Label();
                nombreAsesor = new Label();
                meta = new Label();
                vendido = new Label();
                foto = new PictureBox();
                palabraFacturacion = new Label();
                palabraActual = new Label();
                palabraObjetivo = new Label();
                nombreTerritorio = new Label();
                palabraBacklog = new Label();
                backlog = new Label();
                NombreZona = new Label();


                panel1.Controls.Add(zona);
                panel1.Controls.Add(nombreAsesor);
                panel1.Controls.Add(meta);
                panel1.Controls.Add(vendido);
                panel1.Controls.Add(foto);
                panel1.Controls.Add(palabraFacturacion);
                panel1.Controls.Add(palabraActual);
                panel1.Controls.Add(palabraObjetivo);
                panel1.Controls.Add(nombreTerritorio);
                panel1.Controls.Add(palabraBacklog);
                panel1.Controls.Add(backlog);
                panel1.Controls.Add(NombreZona);



                decimal forFact = Convert.ToInt32(datos[0]);
                //decimal forMeta = Convert.ToInt32(datos[5]);
                //decimal forBacklog = Convert.ToInt32(datos[6]);


                foto.Size = new System.Drawing.Size(91, 110);
                foto.Location = new System.Drawing.Point(corX + incX, corY + incY);
                foto.BorderStyle = BorderStyle.FixedSingle;

                if (datos[1] != "esGerente")
                {
                    if (datos[3] != "BE01")
                    {
                        sumadorFaturacionTotal += forFact;
                        //sumadorMetaTotal += forMeta;
                        //sumadorBacklogTotal += forBacklog;
                    }

                    foto.ImageLocation = datos[4];
                    zona.Text = datos[3];
                    nombreAsesor.Text = datos[2];
                    meta.Text = datos[5];
                    vendido.Text = forFact.ToString();
                    backlog.Text = datos[6];
                    palabraFacturacion.Text = "Clientes con Venta";
                    palabraActual.Text = "  Actual";
                    palabraObjetivo.Text = "";
                    nombreTerritorio.Text = datos[7];
                    palabraBacklog.Text = "      ";
                    NombreZona.Text = datos[8];



                    // Formato de resultados de asesor normal
                    zona.Font = new Font("Arial", 12);
                    zona.Size = new System.Drawing.Size(80, 18);
                    zona.Location = new System.Drawing.Point(110 + incX, corY + incY);
                    zona.BackColor = Color.Salmon;

                    nombreAsesor.Location = new System.Drawing.Point(10 + incX, 112 + corY + incY);
                    nombreAsesor.Font = new Font("Arial", 12);
                    nombreAsesor.Size = new System.Drawing.Size(91, 20);
                    nombreAsesor.BackColor = Color.Salmon;

                    nombreTerritorio.Location = new System.Drawing.Point(110 + incX, 18 + corY + incY);
                    nombreTerritorio.Font = new Font("Arial", 12);
                    nombreTerritorio.Size = new System.Drawing.Size(60, 20);
                    nombreTerritorio.BackColor = Color.Salmon;

                    NombreZona.Location = new System.Drawing.Point(167 + incX, 18 + corY + incY);
                    NombreZona.Font = new Font("Arial", 12);
                    NombreZona.Size = new System.Drawing.Size(126, 20);
                    NombreZona.BackColor = Color.Salmon;


                    palabraFacturacion.Font = new Font("Arial", 15);
                    palabraFacturacion.Size = new System.Drawing.Size(183, 23);
                    palabraFacturacion.Location = new System.Drawing.Point(110 + incX, 41 + corY + incY);
                    palabraFacturacion.BackColor = Color.Salmon;
                    palabraFacturacion.Margin = new Padding(100, 0, 0, 0);


                    palabraObjetivo.Font = new Font("Arial", 14);
                    palabraObjetivo.Size = new System.Drawing.Size(90, 20);
                    palabraObjetivo.Location = new System.Drawing.Point(110 + incX, 66 + corY + incY);
                    palabraObjetivo.BackColor = Color.LightSalmon;

                    meta.Font = new Font("Arial", 13);
                    meta.Size = new System.Drawing.Size(90, 22);
                    meta.Location = new System.Drawing.Point(110 + incX, 86 + corY + incY);
                    meta.BackColor = Color.WhiteSmoke;

                    palabraActual.Font = new Font("Arial", 14);
                    palabraActual.Size = new System.Drawing.Size(90, 20);
                    palabraActual.Location = new System.Drawing.Point(203 + incX, 66 + corY + incY);
                    palabraActual.BackColor = Color.LightSalmon;

                    vendido.Font = new Font("Arial", 13);
                    vendido.Size = new System.Drawing.Size(90, 22);
                    vendido.Location = new System.Drawing.Point(203 + incX, 86 + corY + incY);
                    vendido.BackColor = Color.White;

                    backlog.Font = new Font("Arial", 12);
                    backlog.Size = new System.Drawing.Size(90, 20);
                    backlog.Location = new System.Drawing.Point(203 + incX, 112 + corY + incY);
                    backlog.BackColor = Color.LightSalmon;

                    palabraBacklog.Font = new Font("Arial", 12);
                    palabraBacklog.Size = new System.Drawing.Size(93, 20);
                    palabraBacklog.Location = new System.Drawing.Point(110 + incX, 112 + corY + incY);
                    palabraBacklog.BackColor = Color.LightSalmon;
                    //cierra formato de asesor normal
                }
                else
                {

                    foto.ImageLocation = datos[4];
                    zona.Text = "     " + datos[8];
                    nombreAsesor.Text = datos[2];
                    meta.Text = "";//sumadorMetaTotal.ToString("$0,0");
                    vendido.Text = sumadorFaturacionTotal.ToString();
                    backlog.Text = "";//sumadorBacklogTotal.ToString("$0,0");
                    palabraFacturacion.Text = " Clientes Total";
                    palabraActual.Text = "  Actual";
                    palabraObjetivo.Text = "Objetivo";
                    nombreTerritorio.Text = "   " + datos[7];
                    palabraBacklog.Text = "     ";
                    NombreZona.Text = "  " + datos[3]; ;


                    zona.Font = new Font("Arial", 18);
                    zona.Size = new System.Drawing.Size(183, 26);
                    zona.Location = new System.Drawing.Point(110 + incX, corY + incY);
                    zona.BackColor = Color.LightSalmon;

                    nombreAsesor.Location = new System.Drawing.Point(10 + incX, 112 + corY + incY);
                    nombreAsesor.Font = new Font("Arial", 12);
                    nombreAsesor.Size = new System.Drawing.Size(91, 20);
                    nombreAsesor.BackColor = Color.LightSalmon;

                    nombreTerritorio.Location = new System.Drawing.Point(110 + incX, 26 + corY + incY);
                    nombreTerritorio.Font = new Font("Arial", 15);
                    nombreTerritorio.Size = new System.Drawing.Size(95, 22);
                    nombreTerritorio.BackColor = Color.LightSalmon;

                    NombreZona.Location = new System.Drawing.Point(200 + incX, 26 + corY + incY);
                    NombreZona.Font = new Font("Arial", 15);
                    NombreZona.Size = new System.Drawing.Size(93, 22);
                    NombreZona.BackColor = Color.LightSalmon;


                    palabraFacturacion.Font = new Font("Arial", 17);
                    palabraFacturacion.Size = new System.Drawing.Size(183, 28);
                    palabraFacturacion.Location = new System.Drawing.Point(110 + incX, 51 + corY + incY);
                    palabraFacturacion.BackColor = Color.Salmon;
                    palabraFacturacion.Margin = new Padding(100, 0, 0, 0);


                    palabraObjetivo.Font = new Font("Arial", 15);
                    palabraObjetivo.Size = new System.Drawing.Size(90, 22);
                    palabraObjetivo.Location = new System.Drawing.Point(110 + incX, 81 + corY + incY);
                    palabraObjetivo.BackColor = Color.Salmon;

                    meta.Font = new Font("Arial", 13);
                    meta.Size = new System.Drawing.Size(90, 22);
                    meta.Location = new System.Drawing.Point(110 + incX, 103 + corY + incY);
                    meta.BackColor = Color.WhiteSmoke;

                    palabraActual.Font = new Font("Arial", 15);
                    palabraActual.Size = new System.Drawing.Size(90, 22);
                    palabraActual.Location = new System.Drawing.Point(203 + incX, 81 + corY + incY);
                    palabraActual.BackColor = Color.Salmon;

                    vendido.Font = new Font("Arial", 13);
                    vendido.Size = new System.Drawing.Size(90, 22);
                    vendido.Location = new System.Drawing.Point(203 + incX, 103 + corY + incY);
                    vendido.BackColor = Color.WhiteSmoke;

                    backlog.Font = new Font("Arial", 12);
                    backlog.Size = new System.Drawing.Size(90, 20);
                    backlog.Location = new System.Drawing.Point(203 + incX, 125 + corY + incY);
                    backlog.BackColor = Color.Salmon;

                    palabraBacklog.Font = new Font("Arial", 12);
                    palabraBacklog.Size = new System.Drawing.Size(93, 20);
                    palabraBacklog.Location = new System.Drawing.Point(110 + incX, 125 + corY + incY);
                    palabraBacklog.BackColor = Color.Salmon;

                }
                incX += 300;



                if (cuentaTres > 2) { incX = 0; incY += 190; cuentaTres = 0; }

            }

        }

        private void ReporteClientesConVenta_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


  