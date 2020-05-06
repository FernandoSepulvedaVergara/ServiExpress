using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiExpress.controlador
{
    public class ControladorCliente
    {
        private string[] login;

        public ControladorCliente(string[] login)
        {
            this.login = login;
        }

        public static string[] GetInfoCliente(string rut) 
        {
            WebServiceCliente.WebServiceClienteClient webCliente = new WebServiceCliente.WebServiceClienteClient();
            return webCliente.GetInfoCliente(rut);            
        }
    }
}
