using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Control.FuncionesControlador;
using estructuras;
using Modelo.Modelo;

namespace Control.Controlador
{   
 
    public class Controlador
    {
        
        public ValidacionDeDatos validaDatos = new ValidacionDeDatos();
        
        public EnviarDatos datos = new EnviarDatos();

        public RecuperaDatos datosParaReporte = new RecuperaDatos();

        public DatosParaVentanaClientesConVentas DatosPantallaClientesConVentasDeAsesores = new DatosParaVentanaClientesConVentas();

                
        public void enviaDatos(List<TextBox> componentesAr,List<ComboBox> combo,PictureBox pictureAr) 
        {
            
            datos.EnviarDatosGuardar(componentesAr, combo, pictureAr);
            
            if(datos.revisaCampoVacio())
            {
             
             
            }
            
        }

        public void enviaDatos(Estructurando.DatosVentaDiaria[] componentesAr)
        {
            datos = new EnviarDatos();
            datos.EnviarDatosfff(componentesAr);
         

        }

        public void enviaDatosClientesConVenta(Estructurando.DatosVentaDiaria[] componentesAr)
        {
            datos = new EnviarDatos();
            datos.EnviarDatosDeVenta(componentesAr);


        }

        public void borrarFechasConDatos(String tablaAr,String FechaAr) 
        {
            datos.borrarDatosDeUnaFecha(tablaAr,FechaAr);
        }


    }

    
}
