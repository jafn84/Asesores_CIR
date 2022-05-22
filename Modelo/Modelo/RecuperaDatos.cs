using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace Modelo.Modelo
{
    public class RecuperaDatos
    {
        private static SqlConnection conecta;
        private static SqlCommand datos;
        private static SqlDataReader lector;
        private static List<String> zonas = new List<string>();
        
        public void conectaBaseDatos() 
        {
            
        }


        public static void conectando() 
        {
            conecta = new SqlConnection("Data Source=.;Initial Catalog=CIR;Integrated Security=True");
            conecta.Open();            
        }


        public static List<String> dameLasZonasDeTrabajo() 
        {
            conectando();
            ejecutaConsulta("select Zona from Usuario");
            lector = datos.ExecuteReader();

            while (lector.Read()) 
            {
                zonas.Add(lector["Zona"].ToString());            
            }

            return zonas;

        }



        public static void ejecutaConsulta(String consultaPa) 
        {
            datos = new SqlCommand(consultaPa, conecta);
        }


        public List<String[]> facturacionReporte(String fechaArg) 
        {
            conectando();

            ejecutaConsulta("select Zonas.Estado,Zonas.NombreZona,usuario.Territorio,Objetivos.Facturacion, VentasDiarias.cantidad, VentasDiarias.fecha, Usuario.Nombre, Usuario.Zona, Usuario.Foto, VentasDiarias.Backlog from Usuario inner join VentasDiarias on Usuario.Zona = VentasDiarias.zonaVenta inner join Objetivos on VentasDiarias.zonaVenta = Objetivos.zona inner join Zonas on Usuario.Zona = Zonas.NumeroZona where fecha = '"+ fechaArg +"'");

            
            List<String[]> baseDatos = new List<String[]>();
            String[] renglon; 

            lector = datos.ExecuteReader();

            while (lector.Read())
            {
                renglon = new String[9];

                                
                renglon[0] = lector["cantidad"].ToString().Replace(".0000",string.Empty);
                renglon[1] = lector["fecha"].ToString();
                renglon[2] = lector["Nombre"].ToString();
                renglon[3] = lector["Zona"].ToString();
                renglon[4] = lector["Foto"].ToString();
                renglon[5] = lector["Facturacion"].ToString();
                renglon[6] = lector["Backlog"].ToString();
                renglon[7] = lector["Estado"].ToString();
                renglon[8] = lector["NombreZona"].ToString();

                baseDatos.Add(renglon);
            }

            conecta.Close();

            conectando();

            ejecutaConsulta("select *from Usuario inner join Zonas on Usuario.Zona = Zonas.NumeroZona and Usuario.gerente = 1");

            lector = datos.ExecuteReader();

            while (lector.Read())
            {
                renglon = new String[9];

                renglon[0] = "0";
                renglon[1] = "esGerente";
                renglon[2] = lector["Nombre"].ToString();
                renglon[3] = lector["Zona"].ToString();
                renglon[4] = lector["Foto"].ToString();
                renglon[5] = "0";
                renglon[6] = "0";
                renglon[7] = lector["Estado"].ToString();
                renglon[8] = lector["NombreZona"].ToString();

                baseDatos.Add(renglon);
            }


            return baseDatos;

        }

        public List<String[]> ClientesConVentaReporte(String fechaArg)
        {
            conectando();

            ejecutaConsulta("select Zonas.Estado,Zonas.NombreZona,usuario.Territorio, ClientesConVentaDarios.cantidad, ClientesConVentaDarios.Fecha, Usuario.Nombre, Usuario.Zona, Usuario.Foto from Usuario inner join ClientesConVentaDarios on Usuario.Zona = ClientesConVentaDarios.zonaVenta inner join Zonas on Usuario.Zona = Zonas.NumeroZona where fecha = '" + fechaArg + "'");


            List<String[]> baseDatos = new List<String[]>();
            String[] renglon;

            lector = datos.ExecuteReader();

            while (lector.Read())
            {
                renglon = new String[9];


                renglon[0] = lector["cantidad"].ToString();
                renglon[1] = lector["fecha"].ToString();
                renglon[2] = lector["Nombre"].ToString();
                renglon[3] = lector["Zona"].ToString();
                renglon[4] = lector["Foto"].ToString();
                renglon[5] = /*lector["Facturacion"].ToString()*/"";
                renglon[6] = /*lector["Backlog"].ToString()*/"";
                renglon[7] = lector["Estado"].ToString();
                renglon[8] = lector["NombreZona"].ToString();

                baseDatos.Add(renglon);
            }

            conecta.Close();

            conectando();

            ejecutaConsulta("select *from Usuario inner join Zonas on Usuario.Zona = Zonas.NumeroZona and Usuario.gerente = 1");

            lector = datos.ExecuteReader();

            while (lector.Read())
            {
                renglon = new String[9];

                renglon[0] = "0";
                renglon[1] = "esGerente";
                renglon[2] = lector["Nombre"].ToString();
                renglon[3] = lector["Zona"].ToString();
                renglon[4] = lector["Foto"].ToString();
                renglon[5] = "0";
                renglon[6] = "0";
                renglon[7] = lector["Estado"].ToString();
                renglon[8] = lector["NombreZona"].ToString();

                baseDatos.Add(renglon);
            }


            return baseDatos;

        }



        public List<String> zonasDeVentas() 
        {
            List<String> zonas = new List<string>();

            conectando();
            ejecutaConsulta("select *from Zonas");

            lector = datos.ExecuteReader();

            while (lector.Read()) { zonas.Add(lector["NumeroZona"].ToString()); }

            return zonas;
        
        }





    }
}
