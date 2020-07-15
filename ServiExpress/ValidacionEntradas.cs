using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ServiExpress
{
    public static class ValidacionEntradas
    {
        public static void ValidarString(KeyPressEventArgs e)
        {

            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }

            else
                e.Handled = true;
        }

        public static void NombreUsuarioContraseña(KeyPressEventArgs e) 
        {
            char punto = '.';
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (punto == e.KeyChar)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        public static void Email() 
        {
            Regex regex = new Regex("");
            regex.IsMatch("");
        }
    }
}
