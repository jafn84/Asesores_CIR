using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using estructuras;



namespace Modelo.Modelo
{
    public class escribeDatos
    {
        SqlCommand escribir;
        SqlConnection conecta;


        public void BorraDatosDeUnaFechaMaetsra(String ordenAr) 
        {
            conecta.Open();
          
            escribir = new SqlCommand(ordenAr,conecta);
            escribir.ExecuteNonQuery();
        }

        public escribeDatos() 
        {
           conecta = new SqlConnection("Data Source=.;Initial Catalog=CIR;Integrated Security=True");
            
        }
        
        public void guardaDatos(List<TextBox> datos,List<ComboBox> combo,PictureBox pictureAr)
        {
            string cadena="";
            conecta.Open();
            SaveFileDialog guardar = new SaveFileDialog();

            string fechaNacimiento = datos[8].Text + "-" + datos[9].Text + "-" + datos[10].Text;
            string fechaContratacion = datos[11].Text + "-" + datos[12].Text + "-" + datos[13].Text;
            string fechaLiberacion = datos[14].Text + "-" + datos[15].Text + "-" + datos[16].Text;

            

            cadena = "insert into Usuario(Puesto,Correo_Electronico,Telefono,Fecha_Contratacion,Fecha_Liberacion,Quien_Contrata,Automovil,Fecha_Nacimiento,nombre,zona,No_Empleado,apellido_P,apellido_M,foto,gerente)values('"+datos[4].Text+"','" +
                datos[5].Text + "','" + datos[7].Text + "','" + fechaContratacion + "','" + fechaLiberacion + "','" + datos[6].Text + "','" + combo[1].Text + "','" + fechaNacimiento + "','" +
                datos[1].Text  + "','"+ combo[0].Text + "','" + datos[0].Text + "','" + datos[2].Text + "','"+ datos[3].Text + "','"+ pictureAr.ImageLocation + "','" + datos[17].Text + "')";

           

            escribir = new SqlCommand(cadena,conecta);
            escribir.ExecuteNonQuery();

            

        }

        public void guardaDatos(Estructurando.DatosVentaDiaria[] datosAr)
        {
            string cadena = "";
            conecta.Open();


            foreach (Estructurando.DatosVentaDiaria dato in datosAr)
            {
                cadena = "insert into VentasDiarias(fecha,cantidad,zonaVenta,Backlog)values('" + dato.fecha +"','" + dato.cantidad +"','" + dato.zonaVenta +"','"+dato.backlog+"')";

                escribir = new SqlCommand(cadena, conecta);
                escribir.ExecuteNonQuery();

            }


        }



        public void GuardarDatosClientesConVentaDiario(Estructurando.DatosVentaDiaria[] datosAr) 
        {
            string cadena = "";
            conecta.Open();

            

            foreach (Estructurando.DatosVentaDiaria dato in datosAr)
            {

                

                cadena = "insert into ClientesConVentaDarios(fecha,cantidad,zonaVenta)values('" + dato.fecha + "','" + dato.cantidad + "','" + dato.zonaVenta + "')";

                escribir = new SqlCommand(cadena, conecta);
                escribir.ExecuteNonQuery();

            }

        }



        




        public void guardaDatosObjetivos(List<String> datosAr) 
        {
            String cadena = "";
            
            
            conecta.Open();
            cadena = "insert into Objetivos(Facturacion,ClientesConVenta,Vpp,Alianzas,Pnc,Exhibiciones,Examen,zona)values('" + datosAr[0] + "','" + datosAr[1] + "','" + datosAr[2] + "', '"+ datosAr[3] +"','" + datosAr[4] +"','" + datosAr[5] + "','"+ datosAr[6] + "','" + datosAr[7] + "')";

            escribir = new SqlCommand(cadena, conecta);
            escribir.ExecuteNonQuery();

            MessageBox.Show("Datos Guardados correctamente");
            conecta.Close();
        }


    }
}
