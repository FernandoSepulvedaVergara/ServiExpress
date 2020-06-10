using Microsoft.VisualBasic.Logging;
using ServiExpress.WebServiceCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiExpress.controlador
{
    public class ControladorProveedor : ControladorPrincipal
    {
        public string[] login { get; set; }

        public ControladorProveedor(string[] login)
        {
            this.login = login;
        }

        public override string[] GetInfo()
        {
            return null;
        }

        public override DataGridView SetDataGridView(DataGridView Dgv)
        {
            return null;
        }

        public tipoDeServicio[] GetTipoDeServicios() 
        {
            return null;
        }
    }
}
