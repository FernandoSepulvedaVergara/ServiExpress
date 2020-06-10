using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiExpress.controlador
{
    public static class ControladorLoginUsuario
    {      

        public static string[] ValidarUsuario(string username, string password) 
        {
            string _username = null;
            string _password = null;
            WebServiceLoginUsuario.WebServiceLoginClient webLogin = new WebServiceLoginUsuario.WebServiceLoginClient();
            string[] login = webLogin.ValidarLogin(username,password);

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
    }
}
