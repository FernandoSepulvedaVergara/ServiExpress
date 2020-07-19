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
    public partial class AdministrarProveedores : Form
    {
        ControladorAdministrador controladorAdministrador;
        bool filtroTodosLosProveedores = false;
        bool filtroRut = false;
        string valorFiltro;
        public AdministrarProveedores(ControladorAdministrador controladorAdministrador)
        {
            this.controladorAdministrador = controladorAdministrador;
            InitializeComponent();
        }

        private void AdministrarProveedores_Load(object sender, EventArgs e)
        {
            this.filtroTodosLosProveedores = true;
            this.filtroRut = false;
            this.valorFiltro = null;
            GetProveedores(filtroTodosLosProveedores, filtroRut, valorFiltro);            
        }

        private void DgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvUsuarios.Rows[DgvUsuarios.CurrentRow.Index].Cells[0].ColumnIndex.Equals(e.ColumnIndex))
            {
                GestionarProveedor gestionarProveedor = new GestionarProveedor(controladorAdministrador, DgvUsuarios.CurrentRow.Cells[2].Value.ToString());
                gestionarProveedor.ShowDialog();
                GetProveedores(filtroTodosLosProveedores, filtroRut, valorFiltro);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtBuscarRut.Text.Equals(string.Empty))
            {
                MessageBox.Show("No se ha dado ningún valor");
            }
            else
            {
                if (ValidacionEntradas.ValidarRut(TxtBuscarRut.Text))
                {
                    this.filtroTodosLosProveedores = false;
                    this.filtroRut = true;
                    this.valorFiltro = TxtBuscarRut.Text;
                    GetProveedores(filtroTodosLosProveedores, filtroRut, valorFiltro);
                }
                else {
                    MessageBox.Show("El rut es incorrecto");
                }
                
            }
        }

        private void BtnSeleccionarTodosLosUsuarios_Click(object sender, EventArgs e)
        {
            this.filtroTodosLosProveedores = true;
            this.filtroRut = false;
            this.valorFiltro = null;
            GetProveedores(filtroTodosLosProveedores, filtroRut, valorFiltro);
        }

        private void BtnNuevoUsuario_Click(object sender, EventArgs e)
        {
            NuevoProveedor nuevoProveedor = new NuevoProveedor(controladorAdministrador);
            nuevoProveedor.ShowDialog();
            GetProveedores(filtroTodosLosProveedores, filtroRut, valorFiltro);
        }

        private void GetProveedores(bool filtroTodosLosProveedores, bool filtroRut, string valorFiltro) {
            proveedor[] proveedores = controladorAdministrador.GetGestionarProveedores(filtroTodosLosProveedores, filtroRut, valorFiltro);
            DgvUsuarios.Rows.Clear();
            if (proveedores != null)
            {
                foreach (var proveedor in proveedores)
                {
                    DataGridViewRow dataGridViewRow = new DataGridViewRow();
                    DataGridViewButtonCell dataGridViewButtonCell = new DataGridViewButtonCell();
                    dataGridViewButtonCell.Value = "Gestionar proveedor";
                    dataGridViewRow.CreateCells(DgvUsuarios);

                    dataGridViewRow.Cells[0] = dataGridViewButtonCell;
                    dataGridViewRow.Cells[1].Value = proveedor.tipoDeUsuario.tipoDeUsuario1;
                    dataGridViewRow.Cells[2].Value = proveedor.rutProveedor;
                    dataGridViewRow.Cells[3].Value = proveedor.razonSocial;
                    dataGridViewRow.Cells[4].Value = proveedor.telefono;
                    dataGridViewRow.Cells[5].Value = proveedor.email;
                    DgvUsuarios.Rows.Add(dataGridViewRow);
                }
            }
            else
            {
                DgvUsuarios.Rows.Clear();
            }
        }

        private void TxtBuscarRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionEntradas.ValidarFormatoRut(TxtBuscarRut,e);
        }
    }
}
