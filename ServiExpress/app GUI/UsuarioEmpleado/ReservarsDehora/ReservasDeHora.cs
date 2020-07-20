using ServiExpress.app_GUI.UsuarioEmpleado.ReservarsDehora;
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

namespace ServiExpress.app_GUI.UsuarioEmpleado
{
    public partial class ReservasDeHora : Form
    {
        ControladorEmpleado controladorEmpleado;
        string id_sucursal = null;
        string filtro = null;
        string valorFiltro = null;
        int validarTextbox = 0;
        public ReservasDeHora(ControladorEmpleado controladorEmpleado)
        {
            this.controladorEmpleado = controladorEmpleado;
            InitializeComponent();
        }

        private void ReservasDeHora_Load(object sender, EventArgs e)
        {
            string fechaHoy = DateTime.Now.ToString().Substring(0, 8);
            controladorEmpleado.SetDataGridView(DgvReservasDeHora, "1", "Fecha", fechaHoy);
            this.id_sucursal = "1";
            this.filtro = "Fecha";
            this.valorFiltro = fechaHoy;
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            if (CmbFiltros.SelectedItem == null)
            {
                MessageBox.Show("No se ha seleccionado el tipo de filtro");
            }
            else if (CmbFiltros.SelectedItem.ToString() == "Sucursal")
            {
                if (CmbSucursales.SelectedItem == null)
                {
                    MessageBox.Show("No se ha seleccionado una sucursal");
                }
                else
                {
                    controladorEmpleado.SetDataGridView(DgvReservasDeHora, CmbFiltros.SelectedItem.ToString(), CmbSucursales.SelectedItem.ToString().Substring(0, CmbSucursales.SelectedItem.ToString().IndexOf("-")).Trim(), TxtValorFiltro.Text.Trim());
                    this.id_sucursal = CmbFiltros.SelectedItem.ToString();
                    this.filtro = CmbSucursales.SelectedItem.ToString().Substring(0, CmbSucursales.SelectedItem.ToString().IndexOf("-")).Trim();
                    this.valorFiltro = TxtValorFiltro.Text.Trim();
                }
            }
            else if (TxtValorFiltro.Text == "")
            {
                MessageBox.Show("No se ha dado ningún valor para filtrar");
            }
            else
            {
                controladorEmpleado.SetDataGridView(DgvReservasDeHora, "1", CmbFiltros.SelectedItem.ToString(), TxtValorFiltro.Text.Trim());
                this.id_sucursal = "1";
                this.filtro = CmbFiltros.SelectedItem.ToString();
                this.valorFiltro = TxtValorFiltro.Text.Trim();
            }
        }

        private void RdbSeleccionarHoy_CheckedChanged(object sender, EventArgs e)
        {
            PanelFiltrar.Enabled = false;
        }

        private void RdbFiltrar_CheckedChanged(object sender, EventArgs e)
        {
            PanelFiltrar.Enabled = true;
        }

        private void CmbFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbFiltros.SelectedItem.Equals("Sucursal"))
            {
                CmbSucursales.Visible = true;
                CmbSucursales.Enabled = true;
            }
            else
            {
                CmbSucursales.Visible = false;
                CmbSucursales.Enabled = false;
            }

            if (CmbFiltros.SelectedItem.Equals("Fecha"))
            {
                this.validarTextbox = 3;
                TxtValorFiltro.MaxLength = 8;
                TxtValorFiltro.Clear();
            }
            else if (CmbFiltros.SelectedItem.Equals("Rut"))
            {
                this.validarTextbox = 1;
                TxtValorFiltro.MaxLength = 9;
                TxtValorFiltro.Clear();
            }
            else if (CmbFiltros.SelectedItem.Equals("Patente"))
            {
                this.validarTextbox = 2;
                TxtValorFiltro.MaxLength = 9;
                TxtValorFiltro.Clear();
            }
            else if (CmbFiltros.SelectedItem.Equals("Id reservación"))
            {
                this.validarTextbox = 4;
                TxtValorFiltro.MaxLength = 9;
                TxtValorFiltro.Clear();
            }
        }

        private void DgvReservasDeHora_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvReservasDeHora.Rows[DgvReservasDeHora.CurrentRow.Index].Cells[0].ColumnIndex.Equals(e.ColumnIndex))
            {
                object objeto = DgvReservasDeHora.Rows[DgvReservasDeHora.CurrentRow.Index].Cells[0].Value;
                DataGridViewRow fila = DgvReservasDeHora.CurrentRow;
                if (objeto.ToString().Equals("Realizar atención"))
                {
                    try
                    {
                        RealizarRegistroDeAtencion realizarReservaDeAtencion = new RealizarRegistroDeAtencion(controladorEmpleado, fila);
                        realizarReservaDeAtencion.ShowDialog();
                    }
                    catch 
                    {
                        MessageBox.Show("No se puede abrir el formulario");
                    }
                }
                else if (objeto.ToString().Equals("Ver atención"))
                {
                    try
                    {
                        VerAtención verAtención = new VerAtención(this.controladorEmpleado, fila);
                        verAtención.ShowDialog();
                    }
                    catch
                    {
                        MessageBox.Show("No se puede visualizar la atención");
                    }
                }
                else if (objeto.ToString().Equals("Cancelado"))
                {
                    try
                    {
                        VerAtención verAtención = new VerAtención(this.controladorEmpleado, fila);
                        verAtención.ShowDialog();
                    }
                    catch
                    {
                        MessageBox.Show("No se puede visualizar la atención");
                    }
                }
                else 
                {
                    MessageBox.Show("Error");
                }
                controladorEmpleado.SetDataGridView(DgvReservasDeHora, this.id_sucursal, this.filtro, this.valorFiltro);
            }           
        }

        private void TxtValorFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionEntradas.ValidarReservaciones(e,this.validarTextbox , TxtValorFiltro);
        }

        private void TxtValorFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            ValidacionEntradas.ValidarFormatoFecha(TxtValorFiltro,this.validarTextbox);
        }
    }
}
