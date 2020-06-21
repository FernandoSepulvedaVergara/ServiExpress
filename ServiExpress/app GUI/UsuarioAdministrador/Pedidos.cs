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

namespace ServiExpress.app_GUI.UsuarioAdministrador
{
    public partial class Pedidos : Form
    {
        ControladorAdministrador controladorAdministrador;

        public Pedidos(ControladorAdministrador controladorAdministrador)
        {
            this.controladorAdministrador = controladorAdministrador;
            InitializeComponent();
        }

        private void BtnGenerarPedido_Click(object sender, EventArgs e)
        {
            GenerarPedido generarPedido = new GenerarPedido(this.controladorAdministrador);
            generarPedido.ShowDialog();
        }
    }
}
