using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo.Modelo;
using Control.Controlador;
using estructuras;

namespace Control.FuncionesControlador
{
    public class EnviarDatos
    {
        private static List<TextBox> componentesConDatos = new List<TextBox>();
        
        private static List<Object> componentesConDatosObjetos = new List<Object>();

        private static List<ComboBox> combo = new List<ComboBox>();
        
        private static PictureBox foto = new PictureBox();

        public escribeDatos escribe = new escribeDatos();




        public void borrarDatosDeUnaFecha(String tablaAr,String FechaAr) 
        {   
            String orden = "Delete from " +tablaAr+" where fecha = '"+FechaAr+"'";
            
            escribe.BorraDatosDeUnaFechaMaetsra(orden);

            MessageBox.Show("Los datos de la fecha "+FechaAr+" se borraro correctamente" );

        }
        



        public void EnviarDatosGuardar(List<TextBox> listaAr,List<ComboBox> comboAr, PictureBox pictureAr)
        {
            componentesConDatos = listaAr;
            combo = comboAr;
            foto = pictureAr;
            //revisaCampoVacio(listaAr,comboAr);
        }

       


       public void EnviarDatosfff(Estructurando.DatosVentaDiaria[] listaAr) 
        {
           revisaCampoVacioSinCombos(listaAr);
        }


        public void EnviarDatosDeVenta(Estructurando.DatosVentaDiaria[] listaAr)
        {
            escribe.GuardarDatosClientesConVentaDiario(listaAr);
        }

        public EnviarDatos()
        {
           
        }



        public void revisaCamposVaciosDeListaTextBox(List<TextBox>  textBoxesAr) 
        {
            bool vacio = false;
            string cadena = "Faltan los siguientes datos";

            foreach (TextBox boxCampo in textBoxesAr) 
            {

                if (boxCampo.Text=="") { vacio = true; cadena += "\n" + boxCampo.Text; }
            
            }

            if (vacio == true) { MessageBox.Show(cadena); }

        
        
        }





        public bool revisaCampoVacio()
        {
            bool vacio = false;
            string cadena= "Faltan los siguientes datos: \n\n";

            foreach (TextBox compon in componentesConDatos)
            {
                if (compon.TextLength == 0)
                {
                    vacio = true;
                    cadena += "-" + compon.Name + "\n";
                }
            }

            
            if (combo[1].Text == "Automóvil") { cadena += "-" + combo[1].Name; vacio = true; } else { if (combo[1].Text == "Sí") { combo[1].Text = "1"; } else { combo[1].Text = "0"; } }

            if (combo[0].Text == "") { cadena += "-" + combo[0].Name; vacio = true; } 


            if (foto.ImageLocation == "") { cadena += "-" + foto.Name; vacio = true; }



            if (vacio) 
            { 
                MessageBox.Show(cadena); return false;
            }
            else 
            { 
                escribe.guardaDatos(componentesConDatos,combo,foto);
                MessageBox.Show("Datos guardados correctamente");
                return true;
            }
          
        }



        public bool revisaCampoVacioSinCombos(Estructurando.DatosVentaDiaria[] componentesConDatosObjetos)
        {
            bool vacio = false;
            string cadena = "Faltan los siguientes datos: \n\n";
            int cuenta=0;
            
            if (vacio)
            {
                MessageBox.Show(cadena); return false;
            }
            else
            {
                escribe.guardaDatos(componentesConDatosObjetos);
                MessageBox.Show("Datos guardados correctamente");
                return true;
            }

        }

    }
}
