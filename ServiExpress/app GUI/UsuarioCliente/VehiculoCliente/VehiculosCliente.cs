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
            if (DgvVehiculosCliente.Rows.Count == 0)
            {
                BtnEliminarVehiculo.Visible = false;
            }
        }

        private void VehiculosCliente_Load(object sender, EventArgs e)
        {
            controladorCliente.SetDataGridView(DgvVehiculosCliente);
            if (DgvVehiculosCliente.Rows.Count == 0) {
                BtnEliminarVehiculo.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DgvVehiculosCliente.SelectedRows.Count == 0) {
                MessageBox.Show("Seleccione un vehículo para eliminar");
            }
            else {
                DialogResult dialogResult = MessageBox.Show("¿Eliminar vehículo?","Vehículo", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes) {
                    string patente = DgvVehiculosCliente.Rows[DgvVehiculosCliente.CurrentRow.Index].Cells[0].Value.ToString();
                    string[] resultado = controladorCliente.EliminarVehiculo(patente);
                    MessageBox.Show(resultado[1]);
                    controladorCliente.SetDataGridView(DgvVehiculosCliente);
                    if (DgvVehiculosCliente.Rows.Count == 0)
                    {
                        BtnEliminarVehiculo.Visible = false;
                    }
                }
                
            } 
        }
    }
}
