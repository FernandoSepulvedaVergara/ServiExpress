using ServiExpress.WebServiceCliente;
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
        WebServiceCliente.WebServiceClienteClient webCliente = new WebServiceCliente.WebServiceClienteClient();

        public ControladorCliente(string[] login)
        {
            this.login = login;
        }

        
        public override string[] GetInfo() 
        {            
            string[] resultado = webCliente.GetInfoCliente(login[0]);
            return resultado;
        }

        public servicio[] GetServicios()
        {
            ServiExpress.WebServiceCliente.servicio[] resultado = webCliente.GetServicios();
            return resultado;
        }
    }
}
