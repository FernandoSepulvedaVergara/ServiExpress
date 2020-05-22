using System.Windows.Forms;

namespace ServiExpress.controlador
{
    public abstract class ControladorPrincipal
    {
        public abstract string[] GetInfo();
        public abstract DataGridView SetDataGridView(DataGridView Dgv);
    }
}
