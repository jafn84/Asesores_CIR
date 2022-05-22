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
    public partial class ReporteFacturacion : Form
    {

        RecuperaDatos dd = new RecuperaDatos();
        private static Label zona, nombreAsesor,meta,vendido,palabraFacturacion,palabraActual,palabraObjetivo,nombreTerritorio,backlog,palabraBacklog,NombreZona;
        
        public static string fechaDeReporte = "";

        private static PictureBox foto;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public ReporteFacturacion(String fechaAr)
        {
            InitializeComponent();


            int corX=10, corY=110, incX=0, incY=0;
            int cuentaTres = 0;

            decimal sumadorFaturacionTotal=0,sumadorBacklogTotal=0,sumadorMetaTotal=0;

            foreach (String[] datos in dd.facturacionReporte(fechaAr)) 
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
                decimal forMeta = Convert.ToInt32(datos[5]);
                decimal forBacklog = Convert.ToInt32(datos[6]);


                foto.Size = new System.Drawing.Size(91, 110);
                foto.Location = new System.Drawing.Point(corX + incX, corY + incY);
                foto.BorderStyle = BorderStyle.FixedSingle;

                if (datos[1] != "esGerente")
                {
                    if (datos[3] != "BE01")
                    {
                        sumadorFaturacionTotal += forFact;
                        sumadorMetaTotal += forMeta;
                        sumadorBacklogTotal += forBacklog;
                    }

                    foto.ImageLocation = datos[4];
                    zona.Text = datos[3];
                    nombreAsesor.Text = datos[2];
                    meta.Text = forMeta.ToString("$0,0");
                    vendido.Text = forFact.ToString("$0,0");
                    backlog.Text = forBacklog.ToString("$0,0");
                    palabraFacturacion.Text = "     Facturacion";
                    palabraActual.Text = "  Actual";
                    palabraObjetivo.Text = "Objetivo";
                    nombreTerritorio.Text = datos[7];
                    palabraBacklog.Text = "     Backlog: ";
                    NombreZona.Text = datos[8];



                    // Formato de resultados de asesor normal
                    zona.Font = new Font("Arial", 12);
                    zona.Size = new System.Drawing.Size(80, 18);
                    zona.Location = new System.Drawing.Point(110 + incX, corY + incY);
                    zona.BackColor = Color.DeepSkyBlue;

                    nombreAsesor.Location = new System.Drawing.Point(10 + incX, 112 + corY + incY);
                    nombreAsesor.Font = new Font("Arial", 12);
                    nombreAsesor.Size = new System.Drawing.Size(91, 20);
                    nombreAsesor.BackColor = Color.DeepSkyBlue;

                    nombreTerritorio.Location = new System.Drawing.Point(110 + incX, 18 + corY + incY);
                    nombreTerritorio.Font = new Font("Arial", 12);
                    nombreTerritorio.Size = new System.Drawing.Size(60, 20);
                    nombreTerritorio.BackColor = Color.DeepSkyBlue;

                    NombreZona.Location = new System.Drawing.Point(167 + incX, 18 + corY + incY);
                    NombreZona.Font = new Font("Arial", 12);
                    NombreZona.Size = new System.Drawing.Size(126, 20);
                    NombreZona.BackColor = Color.DeepSkyBlue;


                    palabraFacturacion.Font = new Font("Arial", 15);
                    palabraFacturacion.Size = new System.Drawing.Size(183, 23);
                    palabraFacturacion.Location = new System.Drawing.Point(110 + incX, 41 + corY + incY);
                    palabraFacturacion.BackColor = Color.DeepSkyBlue;
                    palabraFacturacion.Margin = new Padding(100, 0, 0, 0);


                    palabraObjetivo.Font = new Font("Arial", 14);
                    palabraObjetivo.Size = new System.Drawing.Size(90, 20);
                    palabraObjetivo.Location = new System.Drawing.Point(110 + incX, 66 + corY + incY);
                    palabraObjetivo.BackColor = Color.Cyan;

                    meta.Font = new Font("Arial", 13);
                    meta.Size = new System.Drawing.Size(90, 22);
                    meta.Location = new System.Drawing.Point(110 + incX, 86 + corY + incY);
                    meta.BackColor = Color.WhiteSmoke;

                    palabraActual.Font = new Font("Arial", 14);
                    palabraActual.Size = new System.Drawing.Size(90, 20);
                    palabraActual.Location = new System.Drawing.Point(203 + incX, 66 + corY + incY);
                    palabraActual.BackColor = Color.Aqua;

                    vendido.Font = new Font("Arial", 13);
                    vendido.Size = new System.Drawing.Size(90, 22);
                    vendido.Location = new System.Drawing.Point(203 + incX, 86 + corY + incY);
                    vendido.BackColor = Color.White;

                    backlog.Font = new Font("Arial", 12);
                    backlog.Size = new System.Drawing.Size(90, 20);
                    backlog.Location = new System.Drawing.Point(203 + incX, 112 + corY + incY);
                    backlog.BackColor = Color.Aqua;

                    palabraBacklog.Font = new Font("Arial", 12);
                    palabraBacklog.Size = new System.Drawing.Size(93, 20);
                    palabraBacklog.Location = new System.Drawing.Point(110 + incX, 112 + corY + incY);
                    palabraBacklog.BackColor = Color.Aqua;
                    //cierra formato de asesor normal
                }
                else 
                {

                    foto.ImageLocation = datos[4];
                    zona.Text = "     " + datos[8]; 
                    nombreAsesor.Text = datos[2];
                    meta.Text = sumadorMetaTotal.ToString("$0,0");
                    vendido.Text = sumadorFaturacionTotal.ToString("$0,0");
                    backlog.Text = sumadorBacklogTotal.ToString("$0,0");
                    palabraFacturacion.Text = "     Facturacion";
                    palabraActual.Text = "  Actual";
                    palabraObjetivo.Text = "Objetivo";
                    nombreTerritorio.Text = "   "+datos[7];
                    palabraBacklog.Text = "     Backlog: ";
                    NombreZona.Text = "  "+datos[3]; ;


                    zona.Font = new Font("Arial", 18);
                    zona.Size = new System.Drawing.Size(183, 26);
                    zona.Location = new System.Drawing.Point(110 + incX, corY + incY);
                    zona.BackColor = Color.Aqua;

                    nombreAsesor.Location = new System.Drawing.Point(10 + incX, 112 + corY + incY);
                    nombreAsesor.Font = new Font("Arial", 12);
                    nombreAsesor.Size = new System.Drawing.Size(91, 20);
                    nombreAsesor.BackColor = Color.Aqua;

                    nombreTerritorio.Location = new System.Drawing.Point(110 + incX, 26 + corY + incY);
                    nombreTerritorio.Font = new Font("Arial", 15);
                    nombreTerritorio.Size = new System.Drawing.Size(95, 22);
                    nombreTerritorio.BackColor = Color.Aqua;

                    NombreZona.Location = new System.Drawing.Point(200 + incX, 26 + corY + incY);
                    NombreZona.Font = new Font("Arial", 15);
                    NombreZona.Size = new System.Drawing.Size(93, 22);
                    NombreZona.BackColor = Color.Aqua;


                    palabraFacturacion.Font = new Font("Arial", 17);
                    palabraFacturacion.Size = new System.Drawing.Size(183, 28);
                    palabraFacturacion.Location = new System.Drawing.Point(110 + incX, 51 + corY + incY);
                    palabraFacturacion.BackColor = Color.Aqua;
                    palabraFacturacion.Margin = new Padding(100, 0, 0, 0);


                    palabraObjetivo.Font = new Font("Arial", 15);
                    palabraObjetivo.Size = new System.Drawing.Size(90, 22);
                    palabraObjetivo.Location = new System.Drawing.Point(110 + incX, 81 + corY + incY);
                    palabraObjetivo.BackColor = Color.DeepSkyBlue;

                    meta.Font = new Font("Arial", 13);
                    meta.Size = new System.Drawing.Size(90, 22);
                    meta.Location = new System.Drawing.Point(110 + incX, 103 + corY + incY);
                    meta.BackColor = Color.WhiteSmoke;

                    palabraActual.Font = new Font("Arial", 15);
                    palabraActual.Size = new System.Drawing.Size(90, 22);
                    palabraActual.Location = new System.Drawing.Point(203 + incX, 81 + corY + incY);
                    palabraActual.BackColor = Color.DeepSkyBlue;

                    vendido.Font = new Font("Arial", 13);
                    vendido.Size = new System.Drawing.Size(90, 22);
                    vendido.Location = new System.Drawing.Point(203 + incX, 103 + corY + incY);
                    vendido.BackColor = Color.White;

                    backlog.Font = new Font("Arial", 12);
                    backlog.Size = new System.Drawing.Size(90, 20);
                    backlog.Location = new System.Drawing.Point(203 + incX, 125 + corY + incY);
                    backlog.BackColor = Color.Aqua;

                    palabraBacklog.Font = new Font("Arial", 12);
                    palabraBacklog.Size = new System.Drawing.Size(93, 20);
                    palabraBacklog.Location = new System.Drawing.Point(110 + incX, 125 + corY + incY);
                    palabraBacklog.BackColor = Color.Aqua;

                }
                incX += 300;



                if (cuentaTres > 2) { incX = 0; incY += 190; cuentaTres = 0; }

            }
                

        
        
        }
 private void ReporteFacturacion_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
