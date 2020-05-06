using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiExpress.controlador
{
    public class ControladorCliente : ControladorPrincipal
    {
        private string[] login;

        public ControladorCliente(string[] login)
        {
            this.login = login;
        }

        
        public override string[] GetInfo() 
        {
            WebServiceCliente.WebServiceClienteClient webCliente = new WebServiceCliente.WebServiceClienteClient();
            string[] resultado = webCliente.GetInfoCliente(login[0]);
            return resultado;
        }
    }
}
