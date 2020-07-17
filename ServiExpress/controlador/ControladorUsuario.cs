using ServiExpress.WebServiceUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiExpress.controlador
{
    public class ControladorUsuario
    {
        private WebServiceUsuarioClient webUsuario = new WebServiceUsuarioClient();

        public region[] GetRegiones(){
            return webUsuario.GetRegiones();
        }

        public comuna[] GetComunas(int idRegion)
        {
            return webUsuario.GetComunas(idRegion);
        }

        public string[] NuevoUsuario(string rut, string primerNombre, string segundoNombre, string apellidoPaterno, string apellidoMaterno, int telefono, string email, string direccion, int idComuna, string nombreUsuario, int idTipoDeUsuario,string contraseña, int idEstadoUsuario) {
            return webUsuario.NuevoUsuario(rut, primerNombre, segundoNombre, apellidoPaterno, apellidoMaterno, telefono,email,direccion,idComuna,nombreUsuario,idTipoDeUsuario,contraseña, idEstadoUsuario);
        }
    }
}
