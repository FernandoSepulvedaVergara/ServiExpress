using ServiExpress.controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiExpress.app_GUI.UsuarioCliente
{
    public partial class GlosarioDePagos : Form
    {
        ControladorCliente controladorCliente;
        public GlosarioDePagos(ControladorCliente controladorCliente)
        {
            this.controladorCliente = controladorCliente;
            InitializeComponent();
        }

        private void GlosarioDePagos_Load(object sender, EventArgs e)
        {
            controladorCliente.SetDataGridView(DgvVentas);            
        }
    }
}
