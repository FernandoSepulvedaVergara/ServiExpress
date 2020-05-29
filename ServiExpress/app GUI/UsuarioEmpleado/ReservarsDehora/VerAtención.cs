using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiExpress.app_GUI.UsuarioEmpleado.ReservarsDehora
{
    public partial class VerAtención : Form
    {
        DataGridViewRow dataGridViewRow;
        public VerAtención(DataGridViewRow dataGridViewRow)
        {
            this.dataGridViewRow = dataGridViewRow;
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void VerAtención_Load(object sender, EventArgs e)
        {

        }
    }
}
