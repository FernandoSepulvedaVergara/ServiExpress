using ServiExpress.app_GUI.Usuario1.VehiculoCliente;
using ServiExpress.controlador;
using ServiExpress.WebServiceCliente;
using System;
using System.Collections.Generic;
using System.Reflection;
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
            controladorCliente.SetDataGridView(DgvVehiculosCliente);
        }

        private void VehiculosCliente_Load(object sender, EventArgs e)
        {
            controladorCliente.SetDataGridView(DgvVehiculosCliente);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
