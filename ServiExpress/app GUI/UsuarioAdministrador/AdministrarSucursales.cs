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
    public partial class AdministrarSucursales : Form
    {
        ControladorAdministrador controladorAdministrador;
        public AdministrarSucursales(ControladorAdministrador controladorAdministrador)
        {
            this.controladorAdministrador = controladorAdministrador;
            InitializeComponent();
        }

        private void AdministrarSucursales_Load(object sender, EventArgs e)
        {
            GetSucursales();
        }

        private void GetSucursales() {
            DgvSucursales.Rows.Clear();
            sucursal[] resultado = controladorAdministrador.GetSucursales();
            foreach (sucursal sucursal in resultado) {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(DgvSucursales);
                dataGridViewRow.Cells[0].Value = sucursal.id_sucursal;
                dataGridViewRow.Cells[1].Value = sucursal.sucursal1;
                dataGridViewRow.Cells[2].Value = sucursal.direccion;
                DgvSucursales.Rows.Add(dataGridViewRow);
            }

            if (DgvSucursales.Rows.Count <1) {
                BtnEliminarSucursal.Visible = false;
            }
        }

        private void BtnAgregarSucursal_Click(object sender, EventArgs e)
        {
            AgregarSucursal agregarSucursal = new AgregarSucursal(controladorAdministrador);
            agregarSucursal.ShowDialog();
            GetSucursales();
        }

        private void BtnEliminarSucursal_Click(object sender, EventArgs e)
        {
            if (DgvSucursales.Rows.Count <=1) {
                MessageBox.Show("Debe haber al menos una sucursal");
            }
            else {
                DialogResult dialogResult = MessageBox.Show("¿Eliminar sucursal?","Eliminar sucursal",MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) {
                    int idSucursal = int.Parse(DgvSucursales.Rows[DgvSucursales.CurrentRow.Index].Cells[0].Value.ToString());
                    string[] resultado =  controladorAdministrador.EliminarSucursal(idSucursal);
                    if (bool.Parse(resultado[0])) {
                        MessageBox.Show(resultado[1]);
                        GetSucursales();
                    }
                    else {
                        MessageBox.Show(resultado[1]);
                    }
                }
            }
        }
    }
}
