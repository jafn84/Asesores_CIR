using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RutinasTel;
using Modelo.Modelo;
using System.Threading;



namespace RutinasTel
{
    public class ClientesConVenta:RutinasSelenium
    {
        
        //accedemos a la clase RecuperaDatos del Modelo, instanciando el objeto zonas
        private static bool devolverUnaSemana = true;
        private static List<String[]> DatosDeClientesConVenta = new List<string[]>();
        private static String[] zonaYdato;


        public ClientesConVenta(String[] zonasAr) 
        {
            EntrarATel();

            cicloDeZonas(zonasAr);          
        
        }

        private static void cicloDeZonas(String[] zonasVerAr)
        {
            bool entreSM = false;

            //comenzamos a recorrer las zonas en el arreglo zonas del objeto zonas de la clase RecuperaDatos
            foreach (String zonaT in zonasVerAr)
            {
                zonaYdato = new String[2];

                if (entreSM) { Thread.Sleep(1000); EntrarATel(); entreSM = false; }

                if (zonaT != "BE01")
                {
                    //esperamos a que cargue pagina
                    Thread.Sleep(2000);

                    //click en zona del asesor en la vista del gerente
                    ClickEnElemento("//*[@id='" + "ROW_" + zonaT + "']/td[2]/table/tbody/tr[1]/td[2]/b/a");

                    //click en calendario caratula del asesor
                    ClickEnElemento("/html/body/table[2]/tbody/tr/td/table/tbody/tr[1]/td/table/tbody/tr[3]/td[1]/table/tbody/tr[5]/td[1]/a/img");

                    //Click en la semana anterior para ver como cerro clientes con venta
                    if (devolverUnaSemana)
                    {
                        ClickEnElemento("/html/body/table[3]/tbody/tr[1]/td[5]/a/b");
                        Thread.Sleep(1000);
                    }

                    zonaYdato[0] = zonaT;
                    zonaYdato[1] = ObtenerDatoDeElemento("/html/body/table[2]/tbody/tr[3]/td[4]/b");

                    DatosDeClientesConVenta.Add(zonaYdato);

                    //Nos devolvemos a vista principal del gerente
                    ClickEnElemento("/html/body/table[1]/tbody/tr[2]/td/a");
                }
                else 
                {
                    entreSM = true;

                    ClickEnElemento("/html/body/table/tbody/tr[1]/td[2]/table/tbody/tr/td[2]/a/img");

                    Thread.Sleep(1000);

                    datosDeSuperMostrador();

                    Thread.Sleep(2000);

                    //click en calendario caratula del asesor
                    ClickEnElemento("/html/body/table[2]/tbody/tr/td/table/tbody/tr[1]/td/table/tbody/tr[3]/td[1]/table/tbody/tr[5]/td[1]/a/img");
                                    
                    Thread.Sleep(2000);

                    zonaYdato[0] = zonaT;
                    zonaYdato[1] = ObtenerDatoDeElemento("/html/body/table[2]/tbody/tr[3]/td[4]/b");

                    DatosDeClientesConVenta.Add(zonaYdato);

                    Thread.Sleep(1000);

                    ClickEnElemento("/html/body/table[1]/tbody/tr[1]/td[2]/a/img");
                                     
                }
            }

        }


        public List<String[]> clientesConVentalaSemana() 
        {
            return DatosDeClientesConVenta;       
        }




    }
}
