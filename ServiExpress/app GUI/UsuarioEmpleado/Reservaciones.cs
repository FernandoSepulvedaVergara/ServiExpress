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

namespace ServiExpress.app_GUI.UsuarioEmpleado
{
    public partial class Reservaciones : Form
    {
        ControladorCliente controladorCliente;
        public Reservaciones(ControladorCliente controladorCliente)
        {
            this.controladorCliente = controladorCliente;
            InitializeComponent();
        }

        private void Reservaciones_Load(object sender, EventArgs e)
        {
            controladorCliente.SetDataGridView(DgvReservaciones);
        }
    }
}
