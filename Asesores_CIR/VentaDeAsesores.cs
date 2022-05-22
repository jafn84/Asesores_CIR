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
using Control.Controlador;
using Control.FuncionesControlador;
using estructuras;
using RutinasTel;

namespace Asesores_CIR
{
    public partial class VentaDeAsesores : Form
    {
        Controlador controlador = new Controlador();
        private static List<TextBox> textBoxDinamicos = new List<TextBox>();
        private static String[] zonasDeTrabajo;


        Estructurando.DatosVentaDiaria[] datosVentas;

       private static Label zona, nombreAsesor;
       private static TextBox vendido,Backlog;
       private static PictureBox foto;
       
        

        public VentaDeAsesores()
        {
            InitializeComponent();

            int puntero = 0;
                       

            labelDia.Text = Convert.ToString(DateTime.Today.Day);
            labelMes.Text = Convert.ToString(DateTime.Today.Month);
            labelYear.Text = Convert.ToString(DateTime.Today.Year);


            int mueveY=0;
           
            SqlConnection conecta = new SqlConnection("Data Source=.;Initial Catalog=CIR;Integrated Security=True");
            conecta.Open();

            SqlConnection conecta2 = new SqlConnection("Data Source=.;Initial Catalog=CIR;Integrated Security=True");
            conecta2.Open();

            SqlCommand datos = new SqlCommand("select *from Usuario where gerente = 0",conecta);
            SqlCommand filas = new SqlCommand("select count(id) from Usuario where gerente = 0", conecta2);
            SqlDataReader leerDatos = datos.ExecuteReader();

            datosVentas = new Estructurando.DatosVentaDiaria[Convert.ToInt32(filas.ExecuteScalar())];
            zonasDeTrabajo = new String[Convert.ToInt32(filas.ExecuteScalar())];

            while (leerDatos.Read()) 
            {
                zona = new Label();
                nombreAsesor = new Label();
                vendido = new TextBox();
                Backlog = new TextBox();
                foto = new PictureBox();

                zona.Name = "LabelZona-"+leerDatos["Zona"].ToString();
                nombreAsesor.Name = "LabelNombreAsesor-" + leerDatos["Zona"].ToString();
                vendido.Name = "inputTextVenta-" + leerDatos["Zona"].ToString();
                textBoxDinamicos.Add(vendido);
                textBoxDinamicos.Add(Backlog);
                foto.Name = "pictureBoxAsesor-" + leerDatos["Zona"].ToString();
                Backlog.Name = "Backlog-" + leerDatos["Zona"].ToString();
                                
                panelAsesores.Controls.Add(zona);
                panelAsesores.Controls.Add(nombreAsesor);
                panelAsesores.Controls.Add(vendido);
                panelAsesores.Controls.Add(foto);
                panelAsesores.Controls.Add(Backlog);


                datosVentas[puntero].zonaVenta = leerDatos["Zona"].ToString();
                zonasDeTrabajo[puntero] = leerDatos["Zona"].ToString();

                puntero++;
                
                foto.Size = new System.Drawing.Size(91,110);

                foto.Location = new System.Drawing.Point(10,10+mueveY);

                foto.BorderStyle = BorderStyle.FixedSingle;

                zona.Location = new System.Drawing.Point(110, 10+mueveY);

                nombreAsesor.Location = new System.Drawing.Point(110, 35+mueveY);

                vendido.Location = new System.Drawing.Point(110,60+mueveY);

                Backlog.Location = new System.Drawing.Point(110,95+mueveY);


                zona.Text = leerDatos["Zona"].ToString();
                nombreAsesor.Text = leerDatos["Nombre"].ToString();
                vendido.Text = "";
                Backlog.Text = "";
                foto.ImageLocation = leerDatos["Foto"].ToString();

                

                mueveY += 150;

            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            Facturacion clientesConVenta = new Facturacion(zonasDeTrabajo);
            int apunta = 0;
            int ini = 0;
            
                      
            foreach (String[,] venta in clientesConVenta.arregloDeZonaVenta()) 
            {
                    textBoxDinamicos[apunta].Text = venta[0, 1];
                   

                    apunta++;

                    textBoxDinamicos[apunta].Text = venta[0, 2];
                   

                    apunta++;
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p = 0;
            int apunta = 0;
            for (p = 0; p < datosVentas.Length; p++)
            {
                datosVentas[p].cantidad = Convert.ToDouble(textBoxDinamicos[apunta].Text);
                apunta++;
                datosVentas[p].backlog = Convert.ToDouble(textBoxDinamicos[apunta].Text);
                apunta++;

                datosVentas[p].fecha = labelYear.Text + "-" + labelMes.Text + "-" + labelDia.Text;
            }


            controlador.enviaDatos(datosVentas);




           

        }
    }
}
