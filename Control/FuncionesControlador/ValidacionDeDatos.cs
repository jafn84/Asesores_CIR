using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Control.FuncionesControlador
{
    public class ValidacionDeDatos
    {

        public void validaMail(Object objeto)
        {
            TextBox datos = (TextBox)objeto;

            Regex mail = new Regex(@"^[\w\.\s_-]+@[\w]+\.[a-zA-Z]{1,3}$");

            if (!mail.IsMatch(datos.Text)) { MessageBox.Show("Formato de Mail no correcto"); datos.Focus(); }

        }

        public void revisaEventoSoloLetras(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar)) { e.Handled = true; }

            if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }

            if (char.IsPunctuation(e.KeyChar)) { e.Handled = false; }

            if (e.KeyChar == 8) { e.Handled = false; }

        }

        public void revisaEventoSoloNumeros(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) { e.Handled = true; }

            if (e.KeyChar == 8) { e.Handled = false; }

        }

        public void revisaEventoTelefono(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) { e.Handled = true; }

            if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }

            if (e.KeyChar == 45 || e.KeyChar == 40 || e.KeyChar == 41) { e.Handled = false; }

            if (e.KeyChar == 8) { e.Handled = false; }

        }

        public String cargaElemento(PictureBox imagenAr)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            imagenAr.WaitOnLoad = true;
            archivo.Filter = "Todos(*.*)|*.*|Imagenes|*.jpg;*.gif;*.png;*.bmp";
            archivo.ShowDialog();

            return archivo.FileName;

        }



    }



}
