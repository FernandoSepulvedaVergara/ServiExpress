using ServiExpress.controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiExpress.app_GUI.UsuarioEmpleado
{
    public partial class Ventas : Form
    {
        ControladorEmpleado controladorEmpleado;
        string filtro = null;
        string valorFiltro = null;
        int validarTextbox = 0;

        public Ventas(ControladorEmpleado controladorEmpleado)
        {
            this.controladorEmpleado = controladorEmpleado;
            InitializeComponent();
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            if (CmbFiltro.SelectedItem == null)
            {
                MessageBox.Show("No se ha seleccionado el tipo de filtro");
            }
            else if (TxtFiltro.Text == "")
            {
                MessageBox.Show("No se ha dado ningún valor para filtrar");
            }
            else
            {
                controladorEmpleado.SetDataGridViewVentas(DgvVentas, CmbFiltro.SelectedItem.ToString(), TxtFiltro.Text.Trim());
                this.filtro = CmbFiltro.SelectedItem.ToString();
                this.valorFiltro = TxtFiltro.Text.Trim();
            }
        }

        private void DgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvVentas.Rows[DgvVentas.CurrentRow.Index].Cells[0].ColumnIndex.Equals(e.ColumnIndex))
            {
                if (DgvVentas.Rows[DgvVentas.CurrentRow.Index].Cells[0].Value.Equals("Pagar"))
                {
                    Pagar pagar = new Pagar(this.controladorEmpleado, DgvVentas.Rows[DgvVentas.CurrentRow.Index]);
                    pagar.ShowDialog();
                    controladorEmpleado.SetDataGridViewVentas(DgvVentas,this.filtro, this.valorFiltro);
                }
            }
            else if (DgvVentas.Rows[DgvVentas.CurrentRow.Index].Cells[7].ColumnIndex.Equals(e.ColumnIndex))
            {
                MessageBox.Show("Documento");
            }
        }

        private void CmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbFiltro.SelectedItem.ToString() == "Id venta") {
                this.validarTextbox = 1;
                TxtFiltro.MaxLength = 9;
                TxtFiltro.Clear();
            }
            else if (CmbFiltro.SelectedItem.ToString() == "Rut")
            {
                this.validarTextbox = 2;
                TxtFiltro.MaxLength = 9;
                TxtFiltro.Clear();
            }
            else if (CmbFiltro.SelectedItem.ToString() == "Fecha venta")
            {
                this.validarTextbox = 3;
                TxtFiltro.MaxLength = 8;
                TxtFiltro.Clear();
            }
            else if (CmbFiltro.SelectedItem.ToString() == "Patente")
            {
                this.validarTextbox = 4;
                TxtFiltro.MaxLength = 9;
                TxtFiltro.Clear();
            }
        }

        private void TxtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionEntradas.ValidarVentas(e, this.validarTextbox,TxtFiltro);
        }

        private void TxtFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            ValidacionEntradas.ValidarFormatoFecha(TxtFiltro,this.validarTextbox);
        }
    }
}
