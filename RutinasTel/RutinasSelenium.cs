using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SpreadsheetLight;
using System.Threading;


namespace RutinasTel
{
    public class RutinasSelenium
    {
        
        public static IWebDriver ControladorWebChrome = new ChromeDriver();
        public static IWebElement elemento;
        public static SelectElement selecDropBox;
        public static SLDocument excelD;
        
        


        public static void abrirPagina(String paginaAr)
        {
            ControladorWebChrome.Navigate().GoToUrl(paginaAr);
            ControladorWebChrome.Manage().Window.Maximize();
        }


        public static void abrirExcel(String archivoAr)
        {
            excelD = new SLDocument(archivoAr);
        }

        public static void ClickEnElemento(String elementoAr)
        {
            elemento = ControladorWebChrome.FindElement(By.XPath(elementoAr));
            elemento.Click();
        }


        public static void IntroducirDatoEnElementoConId(String elementoAr, String datoAr, bool clickAr)
        {
            elemento = ControladorWebChrome.FindElement(By.Id(elementoAr));
            elemento.SendKeys(datoAr);

            if (clickAr) { elemento.SendKeys(Keys.Enter); }
        }

        public static String ObtenerDatoDeElemento(String elementoAr)
        {
            elemento = ControladorWebChrome.FindElement(By.XPath(elementoAr));
            return elemento.Text;
        }

        public static void seleccionarDropBox(String elementoAr, String opcion)
        {
            elemento = ControladorWebChrome.FindElement(By.Name(elementoAr));
            elemento.Click();
            selecDropBox = new SelectElement(elemento);
            selecDropBox.SelectByValue(opcion);
        }

        public static void seleccionarDropBoxDeMes(String elementoAr, String opcion)
        {
            Console.WriteLine(opcion);
            elemento = ControladorWebChrome.FindElement(By.Id(elementoAr));
            elemento.Click();
            selecDropBox = new SelectElement(elemento);
            selecDropBox.SelectByText(opcion);
        }



        public static void EntrarATel()
        {
            //Abrimos pagina TEL
            abrirPagina("https://www.truperenlinea.com/reng/index.jsp?sch=ssl&idpc=null");
            // abrirPagina("https://www.mercadolibre.com.mx/");

            //Entramos a TEL
            IntroducirDatoEnElementoConId("userTF", "SHERHG03", false);
            IntroducirDatoEnElementoConId("pwdTF", "Soporte2021", true);

        }

        public static void cierraTel()
        {
            ClickEnElemento("/html/body/table/tbody/tr[1]/td[2]/table/tbody/tr/td[2]/a/img");
        }

        public static void datosDeSuperMostrador()
        {

            IntroducirDatoEnElementoConId("userTF", "SHEREM15BE01", false);

            IntroducirDatoEnElementoConId("pwdTF", "Soporte2021", true);

        }

        public static void datosDeMostrador()
        {

            IntroducirDatoEnElementoConId("userTF", "SHERHG03", false);

            IntroducirDatoEnElementoConId("pwdTF", "Soporte2021", true);

        }

    }
}
