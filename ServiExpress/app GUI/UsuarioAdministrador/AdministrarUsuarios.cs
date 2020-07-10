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
        public AdministrarUsuarios(ControladorAdministrador controladorAdministrador)
        {
            this.controladorAdministrador = controladorAdministrador;
            InitializeComponent();
        }

        private void AdministrarUsuarios_Load(object sender, EventArgs e)
        {
            ActualizarUsuarios();
        }

        private void ActualizarUsuarios()
        {
            usuarios[] usuarios = controladorAdministrador.GetUsuarios();
            DgvUsuarios.Rows.Clear();
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

        private void ChbCliente_CheckedChanged(object sender, EventArgs e)
        {
            FiltrarPorUsuario();
        }

        private void ChbEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            FiltrarPorUsuario();
        }

        private void ChbAdministrador_CheckedChanged(object sender, EventArgs e)
        {
            FiltrarPorUsuario();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            controladorAdministrador.FiltrarPorRut(TxtBuscarRut.Text);
        }
    }
}
