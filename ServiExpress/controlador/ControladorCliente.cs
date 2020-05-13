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
        public string[] login { get; set; }
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

        public tipoDeServicio[] GetTipoDeServicios()
        {
            ServiExpress.WebServiceCliente.tipoDeServicio[] resultado = webCliente.GetTipoDeServicios();
            return resultado;
        }

        public tipoDeVehiculo[] GetTipoVehiculos()
        {
            ServiExpress.WebServiceCliente.tipoDeVehiculo[] resultado = webCliente.GetTipoDeVehiculo();
            return resultado;
        }
    }
}
