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
                CmbTipoDeVehiculo.Items.Add(r.tipo_de_vehiculo);
            }
        }

        private void BtnGuardarAgregarVehiculo_Click(object sender, EventArgs e)
        {
            string item = CmbTipoDeVehiculo.SelectedItem.ToString();
            int id_tipoVehículo;
            tipoDeVehiculo[] result = controladorCliente.GetTipoVehiculos();

            foreach (var r in result) 
            {
                if (r.tipo_de_vehiculo.Contains(item)) 
                {
                    id_tipoVehículo = r.id_tipo_de_vehiculo;
                    WebServiceCliente.WebServiceClienteClient WebJava = new WebServiceClienteClient();
                    string[] resultado = WebJava.IngresarVehiculo(TxtPatente.Text,int.Parse(TxtNumeroMotor.Text),TxtNumeroChasis.Text,id_tipoVehículo,this.controladorCliente.login[0]);
                }
            }
        }
    }
}
