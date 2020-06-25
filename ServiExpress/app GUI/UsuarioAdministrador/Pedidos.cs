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
            DgvOrdenesDePedido.Rows.Clear();
            ActualizarOrdenesDePedido();
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            ActualizarOrdenesDePedido();
        }

        private void ActualizarOrdenesDePedido()
        {
            ordenDePedido[] ordenesDePedido = controladorAdministrador.GetOrdenesDePedido();
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
                    dataGridViewButtonCell.Value = "En camino";
                }
                else if (ordenDePedido.estadoDePedido.idEstadoPedido.Equals(4))
                {
                    dataGridViewButtonCell.Value = "Entregado";
                }
                else
                {
                    dataGridViewButtonCell.Value = "Cancelado";
                }
                dataGridViewRow.Cells[0] = dataGridViewButtonCell;
                dataGridViewRow.Cells[1].Value = ordenDePedido.idOrdenPedido;
                dataGridViewRow.Cells[2].Value = ordenDePedido.fechaDePedido;
                dataGridViewRow.Cells[3].Value = ordenDePedido.total;
                dataGridViewRow.Cells[4].Value = ordenDePedido.usuarioRut;
                DgvOrdenesDePedido.Rows.Add(dataGridViewRow);
            }
        }

        private void DgvOrdenesDePedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvOrdenesDePedido.Rows[DgvOrdenesDePedido.CurrentRow.Index].Cells[0].ColumnIndex.Equals(e.ColumnIndex))
            {
                VerOrdenDePedido verOrdenDePedido = new VerOrdenDePedido(controladorAdministrador, int.Parse(DgvOrdenesDePedido.CurrentRow.Cells[1].Value.ToString()));
                verOrdenDePedido.ShowDialog();
            }
        }
    }
}
