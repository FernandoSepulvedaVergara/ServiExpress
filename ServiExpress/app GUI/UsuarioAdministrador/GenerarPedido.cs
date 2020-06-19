using ServiExpress.controlador;
using ServiExpress.WebServiceAdministrador;
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
    public partial class GenerarPedido : Form
    {
        ControladorAdministrador controladorAdministrador;
        public GenerarPedido(ControladorAdministrador controladorAdministrador)
        {
            this.controladorAdministrador = controladorAdministrador;
            InitializeComponent();
        }

        private void GenerarPedido_Load(object sender, EventArgs e)
        {
            proveedor[] proveedores = controladorAdministrador.GetProveedores();

            foreach (var proveedor in proveedores) {
                CmbProveedores.Items.Add(string.Format("{0} - {1}", proveedor.rutProveedor, proveedor.razonSocial));
            } 
        }
    }
}
