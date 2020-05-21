using ServiExpress.WebServiceCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiExpress.controlador
{
    public abstract class ControladorPrincipal
    {
        public abstract string[] GetInfo();
        public abstract DataGridView SetDataGridView(DataGridView Dgv);
    }
}
