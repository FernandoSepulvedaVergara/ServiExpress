using ServiExpress.controlador;
using ServiExpress.WebServiceProveedor;
using System;
using System.Windows.Forms;

namespace ServiExpress.app_GUI.UsuarioProveedor
{
    public partial class VerPedido : Form
    {
        ControladorProveedor controladorProveedor;
        int idOrdenPedido;
        public VerPedido(ControladorProveedor controladorProveedor, int idOrdenPedido)
        {
            this.controladorProveedor = controladorProveedor;
            this.idOrdenPedido = idOrdenPedido;
            InitializeComponent();
            InfoOrdenDePedido(this.idOrdenPedido);
        }

        private void InfoOrdenDePedido(int idOrdenDePedido)
        {
            ordenDePedido ordenDePedidoProveedor = this.controladorProveedor.GetOrdenDePedidoProveedor(idOrdenPedido);
            pedidos[] pedidosProveedor = this.controladorProveedor.GetPedidosProveedor(idOrdenDePedido);
            TxtIdOrdenDePedido.Text = ordenDePedidoProveedor.idOrdenPedido.ToString();
            TxtTotal.Text = ordenDePedidoProveedor.total.ToString();
            TxtAdministrador.Text = ordenDePedidoProveedor.usuarioRut;
            TxtEstado.Text = ordenDePedidoProveedor.estadoDePedido.estado;
            TxtFechaDePedido.Text = ordenDePedidoProveedor.fechaDePedido;
            TxtProveedor.Text = ordenDePedidoProveedor.rutProveedor;

            CmbCambiarEstado.Items.Clear();
            if (ordenDePedidoProveedor.estadoDePedido.idEstadoPedido.Equals(1))
            {
                CmbCambiarEstado.Items.Add("Aprobar pedido");
                CmbCambiarEstado.Items.Add("Rechazar pedido");
            }
            else if (ordenDePedidoProveedor.estadoDePedido.idEstadoPedido.Equals(2))
            {
                CmbCambiarEstado.Items.Add("Enviar pedido");
            }
            else
            {
                CmbCambiarEstado.Items.Clear();
                CmbCambiarEstado.Visible = false;
                LblActualizarEstado.Visible = false;
            }
            DgvPedidos.Rows.Clear();
            foreach (pedidos pedido in pedidosProveedor)
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(DgvPedidos);
                dataGridViewRow.Cells[0].Value = pedido.idPedido;
                dataGridViewRow.Cells[1].Value = pedido.cantidad;
                dataGridViewRow.Cells[2].Value = pedido.precioCompra;
                dataGridViewRow.Cells[3].Value = pedido.totalAPagar;
                dataGridViewRow.Cells[4].Value = pedido.idProducto;
                dataGridViewRow.Cells[5].Value = pedido.descripcion;
                dataGridViewRow.Cells[6].Value = pedido.marca;
                dataGridViewRow.Cells[7].Value = pedido.fechaDeVencimiento;
                DgvPedidos.Rows.Add(dataGridViewRow);
            }
        }

        private void CmbCambiarEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            string actualizarEstado = CmbCambiarEstado.SelectedItem.ToString();
            DialogResult dialogResult = MessageBox.Show(string.Format("¿{0}?", CmbCambiarEstado.SelectedItem.ToString()), "Actualizar estado", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (actualizarEstado.Equals("Enviar pedido"))
                {
                    if (controladorProveedor.ActualizarEstadoPedido(int.Parse(TxtIdOrdenDePedido.Text), 4))
                    {
                        MessageBox.Show("Orden de pedido se ha actualizado correctamente");
                        InfoOrdenDePedido(this.idOrdenPedido);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar");
                    }
                }
                else if (actualizarEstado.Equals("Aprobar pedido"))
                {
                    if (controladorProveedor.ActualizarEstadoPedido(int.Parse(TxtIdOrdenDePedido.Text), 2))
                    {
                        bool actualizarProductosCancelarPedidos = controladorProveedor.ActualizarProductosAprobarPedido(DgvPedidos.Rows);
                        if (actualizarProductosCancelarPedidos)
                        {
                            MessageBox.Show("Orden de pedido se ha actualizado correctamente");
                            InfoOrdenDePedido(this.idOrdenPedido);
                        }
                        else
                        {
                            MessageBox.Show("No se pudieron actualizar los productos del proveedor");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar");
                    }
                }
            }
        }
    }
}
