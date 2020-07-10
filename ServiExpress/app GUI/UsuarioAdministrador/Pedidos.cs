﻿using ServiExpress.controlador;
using ServiExpress.WebServiceAdministrador;
using System;
using System.Windows.Forms;

namespace ServiExpress.app_GUI.UsuarioAdministrador
{
    public partial class Pedidos : Form
    {
        ControladorAdministrador controladorAdministrador;

        public Pedidos(ControladorAdministrador controladorAdministrador)
        {
            this.controladorAdministrador = controladorAdministrador;
            InitializeComponent();
        }

        private void BtnGenerarPedido_Click(object sender, EventArgs e)
        {
            GenerarPedido generarPedido = new GenerarPedido(this.controladorAdministrador);
            generarPedido.ShowDialog();
            ActualizarOrdenesDePedido();
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            ActualizarOrdenesDePedido();
        }

        private void ActualizarOrdenesDePedido()
        {
            ordenDePedido[] ordenesDePedido = controladorAdministrador.GetOrdenesDePedido();
            DgvOrdenesDePedido.Rows.Clear();
            foreach (var ordenDePedido in ordenesDePedido)
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                DataGridViewButtonCell dataGridViewButtonCell = new DataGridViewButtonCell();
                dataGridViewRow.CreateCells(DgvOrdenesDePedido);
                if (ordenDePedido.estadoDePedido.idEstadoPedido.Equals(1))
                {
                    dataGridViewButtonCell.Value = "Generado";
                }
                else if (ordenDePedido.estadoDePedido.idEstadoPedido.Equals(2))
                {
                    dataGridViewButtonCell.Value = "Aprobado";
                }
                else if (ordenDePedido.estadoDePedido.idEstadoPedido.Equals(3))
                {
                    dataGridViewButtonCell.Value = "Rechazado";
                }
                else if (ordenDePedido.estadoDePedido.idEstadoPedido.Equals(4))
                {
                    dataGridViewButtonCell.Value = "En camino";
                }
                else if (ordenDePedido.estadoDePedido.idEstadoPedido.Equals(5))
                {
                    dataGridViewButtonCell.Value = "Entregado";
                }
                else if (ordenDePedido.estadoDePedido.idEstadoPedido.Equals(6))
                {
                    dataGridViewButtonCell.Value = "Cancelado";
                }
                else
                {
                    dataGridViewButtonCell.Value = "Error estado";
                }
                dataGridViewRow.Cells[0] = dataGridViewButtonCell;
                dataGridViewRow.Cells[1].Value = ordenDePedido.idOrdenPedido;
                dataGridViewRow.Cells[2].Value = ordenDePedido.fechaDePedido;
                dataGridViewRow.Cells[3].Value = ordenDePedido.total;
                dataGridViewRow.Cells[4].Value = ordenDePedido.usuarioRut;
                dataGridViewRow.Cells[5].Value = ordenDePedido.rutProveedor;
                DgvOrdenesDePedido.Rows.Add(dataGridViewRow);
            }
        }

        private void DgvOrdenesDePedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvOrdenesDePedido.Rows[DgvOrdenesDePedido.CurrentRow.Index].Cells[0].ColumnIndex.Equals(e.ColumnIndex))
            {
                VerOrdenDePedido verOrdenDePedido = new VerOrdenDePedido(controladorAdministrador, int.Parse(DgvOrdenesDePedido.CurrentRow.Cells[1].Value.ToString()));
                verOrdenDePedido.ShowDialog();
                ActualizarOrdenesDePedido();
            }
        }
    }
}
