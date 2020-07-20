using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ServiExpress
{
    public static class ValidacionEntradas
    {
        public static bool ValidarRut(string rut)
        {
            bool validacion = false;
            try
            {
                rut = rut.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));

                char dv = char.Parse(rut.Substring(rut.Length - 1, 1));

                int m = 0, s = 1;
                for (; rutAux != 0; rutAux /= 10)
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                }
                if (dv == (char)(s != 0 ? s + 47 : 75))
                {
                    validacion = true;
                }
            }
            catch (Exception)
            {
            }
            return validacion;
        }

        public static void ValidarFormatoRut(TextBox txt, KeyPressEventArgs e)
        {
            if (txt.Text.ToUpper().Contains("K"))
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (txt.Text.Length <= 6)
                {
                    if (char.IsNumber(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else if (char.IsControl(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    if (char.IsNumber(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else if (char.IsControl(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else if (char.IsLetter(e.KeyChar))
                    {
                        if (e.KeyChar == 'k' || e.KeyChar == 'K')
                        {
                            e.Handled = false;
                        }
                        else
                        {
                            e.Handled = true;
                        }
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

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

        public static void ValidarAño(KeyPressEventArgs e)
        {

            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        public static void ValidarModelo(KeyPressEventArgs e)
        {

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
            else
                e.Handled = true;
        }

        public static void ValidarRazonSocial(KeyPressEventArgs e)
        {

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

            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        public static void ValidarNumeros(KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public static void ValidarDireccion(KeyPressEventArgs e)
        {
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
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public static bool ValidarEmail(TextBox txt)
        {
            Regex rxEmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            if (rxEmail.IsMatch(txt.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
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

        public static void ValidarPedidos(KeyPressEventArgs e, int tipoDeFiltro, TextBox txt)
        {
            if (tipoDeFiltro == 1)
            {
                ValidarNumeros(e);
            }
            else if (tipoDeFiltro == 2)
            {
                ValidarFormatoRut(txt, e);
            }
            else if (tipoDeFiltro == 2)
            {
                ValidarFecha(e, txt);
            }
        }

        public static void ValidarVentas(KeyPressEventArgs e, int tipoDeFiltro, TextBox txt)
        {
            if (tipoDeFiltro == 1)
            {
                ValidarNumeros(e);
            }
            else if (tipoDeFiltro == 2)
            {
                ValidarFormatoRut(txt, e);
            }
            else if (tipoDeFiltro == 3)
            {
                ValidarFecha(e,txt);
            }
            else if (tipoDeFiltro == 4)
            {
                ValidarModelo(e);
            }
        }

        public static void ValidarPedidosProveedor(KeyPressEventArgs e, int tipoDeFiltro, TextBox txt)
        {
            if (tipoDeFiltro == 1)
            {
                ValidarNumeros(e);
            }
            else if (tipoDeFiltro == 3)
            {
                ValidarFecha(e, txt);
            }
        }

        public static void ValidarFecha(KeyPressEventArgs e, TextBox txt)
        {
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }
        public static void ValidarFormatoFecha(TextBox txt, int tipoDeFiltro)
        {
            if (tipoDeFiltro == 3)
            {
                if (txt.Text.Length == 6)
                {
                    string fecha = txt.Text;
                    string separador = "/";
                    fecha = fecha.Insert(2,separador);
                    fecha = fecha.Insert(5, separador);
                    txt.Clear();
                    txt.Text = fecha;
                }
                else if (txt.Text.Length <8)
                {
                    txt.Text = txt.Text.Replace("/","");
                }
            }
        }

        public static void ValidarReservaciones(KeyPressEventArgs e, int tipoDeFiltro, TextBox txt)
        {
            if (tipoDeFiltro == 1)
            {
                ValidarFormatoRut(txt,e);
            }
            else if (tipoDeFiltro == 2)
            {
                ValidarModelo(e);
            }
            else if (tipoDeFiltro == 4)
            {
                ValidarNumeros(e);
            }
        }
    }
}
