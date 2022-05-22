using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using RutinasTel;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Windows.Forms;

namespace RutinasTel
{
    
    public class Facturacion : RutinasSelenium
    {
        private static String[,] zonaYventa;
        private static List<String[,]> listaZonaYventa = new List<string[,]>();

        public Facturacion(String[] zonas)
        {

            EntrarATel();
           
            Thread.Sleep(2000);

            seleccionarDropBox("vista", "fact");

            Thread.Sleep(2000);

            //revisamos facturacion de cada zona
            revisaZonas(zonas);

            ClickEnElemento("/html/body/table/tbody/tr[1]/td[2]/table/tbody/tr/td[2]/a/img");

            
            
           // listaZonaYventa.Add(zonaYventa);
            

          //  cierraTel();                      


        }



        private static void revisaZonas(String[] zonasAr)
        {
            bool entreSM = false;

            int num=0;
            foreach (String cadena in zonasAr)
            {
                if (entreSM) { Thread.Sleep(1000); EntrarATel(); Thread.Sleep(2000); seleccionarDropBox("vista", "fact"); Thread.Sleep(2000); entreSM = false; }

                if (cadena != "BE01")
                {
                    zonaYventa = new string[1, 3];
                    zonaYventa[0, 0] = cadena;
                    zonaYventa[0, 1] = ObtenerDatoDeElemento("//*[@id='ROW_" + cadena + "']/td[8]").Replace("$",string.Empty);
                    zonaYventa[0, 2] = ObtenerDatoDeElemento("//*[@id='ROW_" + cadena + "']/td[4]").Replace("$", string.Empty);

                    listaZonaYventa.Add(zonaYventa);
                }
                else
                {
                    entreSM = true;

                    ClickEnElemento("/html/body/table/tbody/tr[1]/td[2]/table/tbody/tr/td[2]/a/img");
                    
                    Thread.Sleep(1000);

                    datosDeSuperMostrador();

                    Thread.Sleep(2000);

                    zonaYventa = new string[1, 3];
                    zonaYventa[0, 0] = cadena;
                    zonaYventa[0, 1] = ObtenerDatoDeElemento("/html/body/table[2]/tbody/tr/td/table/tbody/tr[1]/td/table/tbody/tr[7]/td[3]").Replace("$", string.Empty);


                    int valorBO;


                    //Facturacion tota de Mayo
                    int facturacionSM = Convert.ToInt32(ObtenerDatoDeElemento("/html/body/table[2]/tbody/tr/td/table/tbody/tr[1]/td/table/tbody/tr[3]/td[9]").Replace("$", string.Empty).Replace(",", string.Empty));

                    
                    //Total de ordenes de Mayo
                    int backlog2 = Convert.ToInt32(ObtenerDatoDeElemento("/html/body/table[2]/tbody/tr/td/table/tbody/tr[1]/td/table/tbody/tr[3]/td[2]/b").Replace("$", string.Empty).Replace(",", string.Empty));

                    valorBO = backlog2;

                    if (facturacionSM <= 0)
                    {
                        //backorder cancelado
                        int backLog1 = Convert.ToInt32(ObtenerDatoDeElemento("/html/body/table[2]/tbody/tr/td/table/tbody/tr[1]/td/table/tbody/tr[7]/td[3]").Replace("$", string.Empty).Replace(",", string.Empty));

                        valorBO = (facturacionSM - backLog1) - backlog2;
                    }
                    else 
                    {
                        valorBO = facturacionSM - backlog2;
                    }

                    zonaYventa[0, 2] = valorBO.ToString("0,0");

                    listaZonaYventa.Add(zonaYventa);

                    ClickEnElemento("/html/body/table/tbody/tr[1]/td[2]/table/tbody/tr/td[2]/a/img");

                }

            }

        }


        public List<String[,]> arregloDeZonaVenta() 
        {
            return listaZonaYventa;
        }



    }


}
