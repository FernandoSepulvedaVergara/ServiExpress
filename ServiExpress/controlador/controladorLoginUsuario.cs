using ServiExpress.WebServiceLoginUsuario;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiExpress.controlador
{
    public class ControladorLoginUsuario
    {
        private WebServiceLoginClient webLogin = new WebServiceLoginClient();

        public string[] ValidarUsuario(string username, string password)
        {
            string _username = null;
            string _password = null;
            string[] login = new string[4];
            try {
                login = webLogin.ValidarLogin(username, password);
                if (login != null)
                {
                    foreach (var l in login)
                    {
                        if (l == username)
                        {
                            _username = username;
                        }
                        if (l == password)
                        {
                            _password = password;
                        }
                    }

                    if (_username == username && _password == password)
                    {
                        return login;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch(Exception ex){
                login[0] = ex.HResult.ToString();
                login[1] = ex.Message;
                return login;
            }
        }

        public string[] ValidarUsuarioProveedor(string username, string password)
        {
            string _username = null;
            string _password = null;
            string[] login = new string[4];
            try
            {
                login = webLogin.ValidarLoginProveedor(username, password);
                if (login != null)
                {
                    foreach (var l in login)
                    {
                        if (l == username)
                        {
                            _username = username;
                        }
                        if (l == password)
                        {
                            _password = password;
                        }
                    }

                    if (_username == username && _password == password)
                    {
                        return login;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                login[0] = ex.HResult.ToString();
                login[1] = ex.Message;
                return login;
            }
        }
    }
}
