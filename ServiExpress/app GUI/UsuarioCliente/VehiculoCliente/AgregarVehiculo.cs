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
            if (TxtPatente.Text.Equals(string.Empty) || TxtMarca.Text.Equals(string.Empty) || TxtModelo.Text.Equals(string.Empty) || TxtAño.Text.Equals(string.Empty) || CmbTipoDeVehiculo.SelectedItem == null) {
                MessageBox.Show("Faltan datos por ingresar");
            }
            else {
                if (TxtAño.Text.Length <4 || int.Parse(TxtAño.Text) < 1975 || int.Parse(TxtAño.Text) > DateTime.Now.Year) {
                    MessageBox.Show("El año no es correcto");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("¿Registrar vehículo?", "Nuevo vehículo", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        int idTipoDeVehiculo = int.Parse(CmbTipoDeVehiculo.SelectedItem.ToString().Substring(0, CmbTipoDeVehiculo.SelectedItem.ToString().IndexOf("-")).Trim());
                        string[] resultado = controladorCliente.RegistrarNuevoVehiculo(TxtPatente.Text, TxtMarca.Text, TxtModelo.Text, TxtAño.Text, idTipoDeVehiculo, controladorCliente.login[0]);
                        if (resultado[0] != "false")
                        {
                            LimpiarFormulario();
                            MessageBox.Show(resultado[1]);
                        }
                        else
                        {
                            MessageBox.Show(resultado[1]);
                        }
                    }
                }               
            }           
        }

        private void LimpiarFormulario()
        {
            TxtModelo.Clear();
            TxtMarca.Clear();
            TxtPatente.Clear();
        }

        private void TxtPatente_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionEntradas.ValidarModelo(e);
        }

        private void TxtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionEntradas.ValidarString(e);
        }

        private void TxtAño_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionEntradas.ValidarAño(e);
        }
    }
}
