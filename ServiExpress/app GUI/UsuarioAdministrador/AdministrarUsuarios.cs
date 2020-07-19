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
    public partial class AdministrarUsuarios : Form
    {
        ControladorAdministrador controladorAdministrador;
        bool filtroTodosLosUsuario = false;
        bool filtroRut = false;
        bool filtroUsuarios = false;
        public AdministrarUsuarios(ControladorAdministrador controladorAdministrador)
        {
            this.controladorAdministrador = controladorAdministrador;
            InitializeComponent();
        }

        private void AdministrarUsuarios_Load(object sender, EventArgs e)
        {
            SeleccionarTodosLosUsuarios();
            this.filtroTodosLosUsuario = true;
            this.filtroRut = false;
            this.filtroUsuarios = false;
        }       

        private void FiltrarPorUsuario()
        {
            bool filtroAdministrador = false;
            bool filtroCliente = false;
            bool filtroEmpleado = false;

            if (ChbAdministrador.Checked.Equals(true)) { filtroAdministrador = true; }
            if (ChbCliente.Checked.Equals(true)) { filtroCliente = true; }
            if (ChbEmpleado.Checked.Equals(true)) { filtroEmpleado = true; }

            usuarios[] usuarios = controladorAdministrador.FiltrarPorUsuario(filtroAdministrador, filtroCliente, filtroEmpleado);
            DgvUsuarios.Rows.Clear();
            if (usuarios != null)
            {
                foreach (var usuario in usuarios)
                {
                    DataGridViewRow dataGridViewRow = new DataGridViewRow();
                    DataGridViewButtonCell dataGridViewButtonCell = new DataGridViewButtonCell();
                    dataGridViewButtonCell.Value = "Gestionar usuario";
                    dataGridViewRow.CreateCells(DgvUsuarios);

                    dataGridViewRow.Cells[0] = dataGridViewButtonCell;
                    dataGridViewRow.Cells[1].Value = usuario.tipoDeUsuario.tipoDeUsuario1;
                    dataGridViewRow.Cells[2].Value = usuario.rut;
                    dataGridViewRow.Cells[3].Value = usuario.nombre;
                    dataGridViewRow.Cells[4].Value = usuario.apellidoPaterno;
                    dataGridViewRow.Cells[5].Value = usuario.apellidoMaterno;
                    dataGridViewRow.Cells[6].Value = usuario.estadoDeUsuario.estadoDeUsuario1;
                    DgvUsuarios.Rows.Add(dataGridViewRow);
                }
            }
            else {
                DgvUsuarios.Rows.Clear();
            }
        }

        private void FiltrarPorRut() {

            usuarios[] usuarios = controladorAdministrador.FiltrarPorRut(TxtBuscarRut.Text);
            DgvUsuarios.Rows.Clear();
            if (usuarios != null)
            {
                foreach (var usuario in usuarios)
                {
                    DataGridViewRow dataGridViewRow = new DataGridViewRow();
                    DataGridViewButtonCell dataGridViewButtonCell = new DataGridViewButtonCell();
                    dataGridViewButtonCell.Value = "Gestionar usuario";
                    dataGridViewRow.CreateCells(DgvUsuarios);

                    dataGridViewRow.Cells[0] = dataGridViewButtonCell;
                    dataGridViewRow.Cells[1].Value = usuario.tipoDeUsuario.tipoDeUsuario1;
                    dataGridViewRow.Cells[2].Value = usuario.rut;
                    dataGridViewRow.Cells[3].Value = usuario.nombre;
                    dataGridViewRow.Cells[4].Value = usuario.apellidoPaterno;
                    dataGridViewRow.Cells[5].Value = usuario.apellidoMaterno;
                    dataGridViewRow.Cells[6].Value = usuario.estadoDeUsuario.estadoDeUsuario1;
                    DgvUsuarios.Rows.Add(dataGridViewRow);
                }
            }
            else
            {
                DgvUsuarios.Rows.Clear();
            }
        }

        private void SeleccionarTodosLosUsuarios()
        {
            usuarios[] usuarios = controladorAdministrador.SeleccionarTodosLosUsuarios();
            DgvUsuarios.Rows.Clear();
            if (usuarios != null)
            {
                foreach (var usuario in usuarios)
                {
                    DataGridViewRow dataGridViewRow = new DataGridViewRow();
                    DataGridViewButtonCell dataGridViewButtonCell = new DataGridViewButtonCell();
                    dataGridViewButtonCell.Value = "Gestionar usuario";
                    dataGridViewRow.CreateCells(DgvUsuarios);

                    dataGridViewRow.Cells[0] = dataGridViewButtonCell;
                    dataGridViewRow.Cells[1].Value = usuario.tipoDeUsuario.tipoDeUsuario1;
                    dataGridViewRow.Cells[2].Value = usuario.rut;
                    dataGridViewRow.Cells[3].Value = usuario.nombre;
                    dataGridViewRow.Cells[4].Value = usuario.apellidoPaterno;
                    dataGridViewRow.Cells[5].Value = usuario.apellidoMaterno;
                    dataGridViewRow.Cells[6].Value = usuario.estadoDeUsuario.estadoDeUsuario1;
                    DgvUsuarios.Rows.Add(dataGridViewRow);
                }
            }
            else
            {
                DgvUsuarios.Rows.Clear();
            }
        }

        private void ChbCliente_CheckedChanged(object sender, EventArgs e)
        {
            this.filtroTodosLosUsuario = false;
            this.filtroRut = false;
            this.filtroUsuarios = true;
            FiltrarPorUsuario();
        }

        private void ChbEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            this.filtroTodosLosUsuario = false;
            this.filtroRut = false;
            this.filtroUsuarios = true;
            FiltrarPorUsuario();
        }

        private void ChbAdministrador_CheckedChanged(object sender, EventArgs e)
        {
            this.filtroTodosLosUsuario = false;
            this.filtroRut = false;
            this.filtroUsuarios = true;
            FiltrarPorUsuario();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtBuscarRut.Text.Equals(string.Empty)) {
                MessageBox.Show("No se ha dado ningún valor");
            }
            else {
                if (ValidacionEntradas.ValidarRut(TxtBuscarRut.Text)) {
                    this.filtroTodosLosUsuario = false;
                    this.filtroRut = true;
                    this.filtroUsuarios = false;
                    FiltrarPorRut();
                }
                else {
                    MessageBox.Show("El rut es incorrecto");
                }
            }
        }

        private void BtnSeleccionarTodosLosUsuarios_Click(object sender, EventArgs e)
        {
            SeleccionarTodosLosUsuarios();
            this.filtroTodosLosUsuario = true;
            this.filtroRut = false;
            this.filtroUsuarios = false;
        }

        private void DgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvUsuarios.Rows[DgvUsuarios.CurrentRow.Index].Cells[0].ColumnIndex.Equals(e.ColumnIndex))
            {
                GestionarUsuario gestionarUsuario = new GestionarUsuario(controladorAdministrador, DgvUsuarios.CurrentRow.Cells[2].Value.ToString());
                gestionarUsuario.ShowDialog();
                Filtrar();
            }
        }

        private void Filtrar() {
            if (this.filtroTodosLosUsuario.Equals(true)) {
                SeleccionarTodosLosUsuarios();
            }
            else if (this.filtroRut.Equals(true)) {
                FiltrarPorRut();
            }
            else if (this.filtroUsuarios.Equals(true)) {
                FiltrarPorUsuario();
            }
            else {
                MessageBox.Show("Error en cargar usuarios");
            }
        }

        private void BtnNuevoUsuario_Click(object sender, EventArgs e)
        {
            NuevoUsuario nuevoUsuario = new NuevoUsuario(controladorAdministrador);
            nuevoUsuario.ShowDialog();
            Filtrar();
        }

        private void TxtBuscarRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionEntradas.ValidarFormatoRut(TxtBuscarRut,e);
        }
    }
}
