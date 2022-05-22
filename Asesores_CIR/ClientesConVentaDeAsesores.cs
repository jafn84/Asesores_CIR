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
using RutinasTel;
using estructuras;

namespace Asesores_CIR
{
    public partial class ClientesConVentaDeAsesores : Form
    {
        private static TextBox numClientesVendidos;
        private static Label palabraNumerodeZona;
        private static Label palabraNombredeAsesor;
        private static PictureBox foto;
        private static int puntero=0,mueveY=0;
        private static Controlador datos = new Controlador();
        private static String[] zonasAcomodadas = new String[datos.DatosPantallaClientesConVentasDeAsesores.numeroDeAsesores()];
        private static int apunta = 0;
        private static Estructurando.DatosVentaDiaria[] datosVentas;
        
        
        private static List<String[]> datosDeAsesores =  new List<String[]>();

        //guardamos textbox para registrar clientes con venta con rutina en automatico 
        private static List<TextBox> textboxZonas = new List<TextBox>();

       
        public ClientesConVentaDeAsesores()
        {
            InitializeComponent();

            panelAsesores.Controls.Clear();

            datosVentas = new Estructurando.DatosVentaDiaria[datos.DatosPantallaClientesConVentasDeAsesores.numeroDeAsesores()];

            labelDia.Text = DateTime.Now.Day.ToString();
            labelMes.Text = DateTime.Now.Month.ToString();
            labelYear.Text = DateTime.Now.Year.ToString();


            foreach (string[] datosPuntero in datos.DatosPantallaClientesConVentasDeAsesores.listaDeClientes()) 
            {


                creaRegistroDinamico(datosPuntero[1],datosPuntero[2],datosPuntero[0]);
                zonasAcomodadas[apunta] = datosPuntero[0];
                datosVentas[apunta].zonaVenta = datosPuntero[0];
                apunta++;
            }

            apunta = 0;
            
            mueveY = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p = 0;
            int apunta = 0;
            for (p = 0; p < datosVentas.Length; p++)
            {
                datosVentas[p].cantidad = Convert.ToInt32(textboxZonas[apunta].Text);

                datosVentas[p].fecha = labelYear.Text + "-" + labelMes.Text + "-" + labelDia.Text;

                apunta++;
            }


            datos.enviaDatosClientesConVenta(datosVentas);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClientesConVenta automatizacionClientesConVenta = new ClientesConVenta(zonasAcomodadas);
            
            foreach (String[] datosDeZona in automatizacionClientesConVenta.clientesConVentalaSemana())
            {
                
                textboxZonas[apunta].Text = datosDeZona[1];
                apunta++;
            }

            apunta = 0;

        }

        private void creaRegistroDinamico(String nombreAr, String fotoAr, String zonaAr) 
        {
            numClientesVendidos = new TextBox();
            palabraNombredeAsesor = new Label();
            palabraNumerodeZona = new Label();
            foto = new PictureBox();
                       
            numClientesVendidos.Name = "textBoxClientesVendidos"+"-"+zonaAr;
            palabraNombredeAsesor.Name = "labelNombreAsesor";
            palabraNumerodeZona.Name = "labelNombreZona";

            panelAsesores.Controls.Add(numClientesVendidos);
            panelAsesores.Controls.Add(palabraNombredeAsesor);
            panelAsesores.Controls.Add(palabraNumerodeZona);
            panelAsesores.Controls.Add(foto);
            textboxZonas.Add(numClientesVendidos);

            foto.Size = new System.Drawing.Size(91, 110);
            foto.Location = new System.Drawing.Point(10, 10 + mueveY);
            foto.BorderStyle = BorderStyle.FixedSingle;

            palabraNumerodeZona.Location = new System.Drawing.Point(110, 10 + mueveY);

            palabraNombredeAsesor.Location = new System.Drawing.Point(110, 35 + mueveY);

            numClientesVendidos.Location = new System.Drawing.Point(110, 60 + mueveY);
            
            palabraNumerodeZona.Text = zonaAr;
            palabraNombredeAsesor.Text = nombreAr;
            numClientesVendidos.Text = "";
            foto.ImageLocation = fotoAr;
            
            mueveY += 150;
            
        }
    }
}
