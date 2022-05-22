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
using Modelo.Modelo;


namespace Asesores_CIR
{
    public partial class AltaDeObjetivo : Form
    {
        private static List<String> nombresDeComponentes = new List<string>();
        private static Controlador controlDeFunciones = new Controlador();
        private static TextBox caja;
        private static Label labelt;
        private static Panel panelUno = new Panel();
        private static ComboBox zonasBox = new ComboBox();
        private static RecuperaDatos traigoDatos = new RecuperaDatos();
        private static Button botonGuardar = new Button();
        private static Controlador valida = new Controlador();
        private static Modelo.Modelo.escribeDatos escribe = new escribeDatos();
        
        public AltaDeObjetivo()
        {
            List<String> datosAguardar = new List<string>();

            InitializeComponent();

            nombresDeComponentes.Add("facturacion");
            nombresDeComponentes.Add("clientesNuevos");
            nombresDeComponentes.Add("vpp");
            nombresDeComponentes.Add("alianzas");
            nombresDeComponentes.Add("pnc");
            nombresDeComponentes.Add("exhibiciones");
            nombresDeComponentes.Add("examen");

              this.Controls.Add(panelUno);
              panelUno.Location = new System.Drawing.Point(12, 12);
              panelUno.Size = new System.Drawing.Size(767, 720);
              
              textBoxConLabel(nombresDeComponentes);

            panelUno.Controls.Add(botonGuardar);
            botonGuardar.Text = "Guardar";
            botonGuardar.Location = new System.Drawing.Point(200,100);

            foreach (String zonaTexto in traigoDatos.zonasDeVentas())
            {
                zonasBox.Items.Add(zonaTexto);
            }

            botonGuardar.Click += delegate
            {

                foreach (TextBox cajaDeTexto in panelUno.Controls.OfType<TextBox>())
                {
                    datosAguardar.Add(cajaDeTexto.Text);
                }

                datosAguardar.Add(zonasBox.Text);

                escribe.guardaDatosObjetivos(datosAguardar);

                datosAguardar.Clear();

            };

        }

        private static void textBoxConLabel(List<String> lista) 
        {
            int xx=10, yy=10;
            

            foreach (String cadena in lista)
            {
                
                caja = new TextBox();
                labelt = new Label();
            
                panelUno.Controls.Add(labelt);
                panelUno.Controls.Add(caja);
                
                caja.Name = "TextBox" + cadena;
                labelt.Name = "Label" + cadena;

                panelUno.Controls.Add(zonasBox);

                zonasBox.Location = new System.Drawing.Point(200,23);
                caja.Location = new System.Drawing.Point(xx,yy+15);
                labelt.Location = new System.Drawing.Point(xx, yy);
                labelt.Size = new System.Drawing.Size(100,13);

                labelt.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(cadena);
         
                yy += 50;

            }

        }

        private void botonGuardar_Click(object sender, EventArgs e) 
        {
           

           

           


        }

        private void AltaDeObjetivo_Load(object sender, EventArgs e)
        {

        }
    }
}
