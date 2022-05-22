using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Modelo.Modelo
{

   
    public abstract class ConectaBaseDeDatos
    {
        private static SqlConnection conecta;
        private static SqlCommand datos;
        private static SqlDataReader lecturaDeDatos;
        private static List<String> ListaDeZonas = new List<string>();

        private void conectaAbase() 
        {
            conecta = new SqlConnection("Data Source=.;Initial Catalog=CIR;Integrated Security=True");
            conecta.Open();
        }

        public List<String> zonasDeTrabajo() 
        {
            
            conectaAbase();
            ejecutaConsultaSQL("select NumeroZona from zonas inner join Usuario on Usuario.Zona = Zonas.NumeroZona where gerente = 0");

            while (lecturaDeDatos.Read())
            {
                ListaDeZonas.Add(lecturaDeDatos["NumeroZona"].ToString());
            }

            return ListaDeZonas;
        }  


        public SqlDataReader ejecutaConsultaSQL(String consultaAr) 
        {
            conectaAbase();
            datos = new SqlCommand(consultaAr,conecta);
            lecturaDeDatos = datos.ExecuteReader();
            

            return lecturaDeDatos;
        }
        

    }
}
