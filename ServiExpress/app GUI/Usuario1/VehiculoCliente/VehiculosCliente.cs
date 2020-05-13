using ServiExpress.app_GUI.Usuario1.VehiculoCliente;
using ServiExpress.controlador;
using ServiExpress.WebServiceCliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiExpress.app_GUI.Usuario1
{
    public partial class VehiculosCliente : Form
    {
        ControladorCliente controladorCliente;
        public VehiculosCliente(ControladorCliente controladorCliente)
        {
            this.controladorCliente = controladorCliente;
            InitializeComponent();
        }

        private void BtnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            AgregarVehiculo agregarVehiculo = new AgregarVehiculo(controladorCliente);
            agregarVehiculo.ShowDialog();
        }

        private void VehiculosCliente_Load(object sender, EventArgs e)
        {
            WebServiceCliente.WebServiceClienteClient WebCliente = new WebServiceCliente.WebServiceClienteClient();
            vehiculo[] resultado = WebCliente.GetVehiculos(controladorCliente.login[0]);

            foreach (var r in resultado)
            {
                
            }
        }
    }
}
