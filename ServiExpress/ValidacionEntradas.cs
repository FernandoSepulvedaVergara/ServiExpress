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

        public static void NombreUsuario() 
        {
        
        }
        public static void Contraseña()
        {
 
        }

        public static void Email() 
        {
            Regex regex = new Regex("");
            regex.IsMatch("");
        }
    }
}
