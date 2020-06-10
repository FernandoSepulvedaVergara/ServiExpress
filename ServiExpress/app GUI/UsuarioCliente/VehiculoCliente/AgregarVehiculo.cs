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

namespace ServiExpress.app_GUI.Usuario1.VehiculoCliente
{
    public partial class AgregarVehiculo : Form
    {
        ControladorCliente controladorCliente;
        public AgregarVehiculo(ControladorCliente controladorCliente)
        {
            this.controladorCliente = controladorCliente;
            InitializeComponent();
        }

        private void BtnCerrarAgregarVehiculo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgregarVehiculo_Load(object sender, EventArgs e)
        {
            foreach (var r in controladorCliente.GetTipoVehiculos())
            {
                CmbTipoDeVehiculo.Items.Add(String.Format("{0} - {1}", r.id_tipo_de_vehiculo, r.tipo_de_vehiculo));
            }
        }

        private void BtnGuardarAgregarVehiculo_Click(object sender, EventArgs e)
        {
            int idTipoDeVehiculo = int.Parse(CmbTipoDeVehiculo.SelectedItem.ToString().Substring(0, CmbTipoDeVehiculo.SelectedItem.ToString().IndexOf("-")).Trim());
            string[] resultado = controladorCliente.RegistrarNuevoVehiculo(TxtPatente.Text, int.Parse(TxtNumeroMotor.Text), TxtNumeroChasis.Text, idTipoDeVehiculo, controladorCliente.login[0]);
            if (resultado[0] != "false")
            {
                LimpiarFormulario();
                MessageBox.Show("Vehículo guardado con éxito");
            }
            else 
            {
                MessageBox.Show("No se pudo agregar, verifique todos los datos");
            }
        }

        private void LimpiarFormulario() 
        {
            TxtNumeroChasis.Clear();
            TxtNumeroMotor.Clear();
            TxtPatente.Clear();
        }
    }
}
