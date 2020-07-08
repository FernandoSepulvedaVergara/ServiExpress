using ServiExpress.controlador;
using ServiExpress.WebServiceProveedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiExpress.app_GUI.UsuarioProveedor
{
    public partial class Pedidos : Form
    {
        ControladorProveedor controladorProveedor;
        public Pedidos(ControladorProveedor controladorProveedor)
        {
            this.controladorProveedor = controladorProveedor;
            InitializeComponent();
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            ActualizarOrdenesDePedido();
        }

        private void ActualizarOrdenesDePedido()
        {
            {
                ordenDePedido[] ordenesDePedido = controladorProveedor.GetOrdenesDePedidoProveedor();
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
                    DgvOrdenesDePedido.Rows.Add(dataGridViewRow);                
                }
            }
        }

        private void DgvOrdenesDePedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvOrdenesDePedido.Rows[DgvOrdenesDePedido.CurrentRow.Index].Cells[0].ColumnIndex.Equals(e.ColumnIndex))
            {
                VerPedido verOrdenDePedido = new VerPedido(controladorProveedor, int.Parse(DgvOrdenesDePedido.CurrentRow.Cells[1].Value.ToString()));
                verOrdenDePedido.ShowDialog();
                ActualizarOrdenesDePedido();
            }
        }
    }
}
