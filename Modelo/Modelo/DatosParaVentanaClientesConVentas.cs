using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Modelo.Modelo
{
    public class DatosParaVentanaClientesConVentas : ConectaBaseDeDatos
    {
        //guardamos el resultado de la consulta para mostrar los asesores para capturar clientes con venta
        private static SqlDataReader datosDeasesores;
        //guardamos el numero de asesores que vamos a trabajar
        private static SqlDataReader numeroRenglones;
        //preparamos datos para enviarlos a la pantalla de presentacion, aqui guardamo una lista de zona y nombre asesor
        private static List<String[]> listaDeDatos = new List<string[]>();
        //arreglo para guardar la zona y nombre de asesor
        private static String[] asesores;
        //numero de asesores
        private static int numero = 0;

        
        //llenamos la lista de datos en el constructor
        public DatosParaVentanaClientesConVentas() 
        {
            extraerAsesores();

            while (datosDeasesores.Read()) 
            {
                asesores = new String[3];

                asesores[0] = datosDeasesores["Zona"].ToString();
                asesores[1] = datosDeasesores["Nombre"].ToString();
                asesores[2] = datosDeasesores["foto"].ToString();

                listaDeDatos.Add(asesores);

                numero++;
            }
        
        }
        
        //colsultamos la base de datos para extraer datos
        private void extraerAsesores() 
        {
            datosDeasesores = ejecutaConsultaSQL("select Zona,Nombre,foto from Usuario where gerente = 0");
            numeroRenglones = ejecutaConsultaSQL("select count(id) from Usuario where gerente = 0");
                             
        }

        //regresamos el valor de la lista de datos ya llena
        public List<String[]> listaDeClientes() 
        {
            return listaDeDatos;        
        }

        public int numeroDeAsesores() 
        {
            return numero;
        }


    }
}
