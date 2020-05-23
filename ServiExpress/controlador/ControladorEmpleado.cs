using ServiExpress.WebServiceEmpleado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiExpress.controlador
{
    class ControladorEmpleado : ControladorPrincipal
    {
        public string[] login { get; set; }
        WebServiceEmpleadoClient webEmpleado = new WebServiceEmpleadoClient();

        public ControladorEmpleado(string[] login) 
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
    }
}
