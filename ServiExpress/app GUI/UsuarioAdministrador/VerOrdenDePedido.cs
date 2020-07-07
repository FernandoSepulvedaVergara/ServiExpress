using ServiExpress.controlador;
using ServiExpress.WebServiceAdministrador;
using System;
using System.Windows.Forms;

namespace ServiExpress.app_GUI.UsuarioAdministrador
{
    public partial class VerOrdenDePedido : Form
    {
        ControladorAdministrador controladorAdministrador;
        int idOrdenPedido;
        public VerOrdenDePedido(ControladorAdministrador controladorAdministrador,int idOrdenPedido)
        {
            InitializeComponent();
            this.controladorAdministrador = controladorAdministrador;
            this.idOrdenPedido = idOrdenPedido;
            InfoOrdenDePedido(idOrdenPedido);
        }

        private void InfoOrdenDePedido(int idOrdenDePedido)
        {
            ordenDePedido ordenDePedido = this.controladorAdministrador.GetOrdenDePedido(idOrdenPedido);
            pedidos[] pedidos = this.controladorAdministrador.GetPedidos(idOrdenDePedido);
            TxtIdOrdenDePedido.Text = ordenDePedido.idOrdenPedido.ToString();
            TxtTotal.Text = ordenDePedido.total.ToString();
            TxtAdministrador.Text = ordenDePedido.usuarioRut;
            TxtEstado.Text = ordenDePedido.estadoDePedido.estado;
            TxtFechaDePedido.Text = ordenDePedido.fechaDePedido;
            TxtProveedor.Text = ordenDePedido.rutProveedor;

            if (ordenDePedido.estadoDePedido.idEstadoPedido.Equals(1) || ordenDePedido.estadoDePedido.idEstadoPedido.Equals(2))
            {
                CmbCambiarEstado.Items.Add("Cancelar");
            }
            else if (ordenDePedido.estadoDePedido.idEstadoPedido.Equals(4))
            {
                CmbCambiarEstado.Items.Add("Registrar entrega");
                CmbCambiarEstado.Items.Add("Cancelar");
            }
            else
            {
                CmbCambiarEstado.Items.Clear();
                CmbCambiarEstado.Visible = false;
                LblActualizarEstado.Visible = false;
            }
            DgvPedidos.Rows.Clear();
            foreach (pedidos pedido in pedidos)
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

        private void CmbCambiarEstado_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string actualizarEstado = CmbCambiarEstado.SelectedItem.ToString();
            DialogResult dialogResult = MessageBox.Show(string.Format("¿{0}?",CmbCambiarEstado.SelectedItem.ToString()), "Actualizar estado", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (actualizarEstado.Equals("Registrar entrega")) {
                    if (controladorAdministrador.ActualizarEstadoPedido(int.Parse(TxtIdOrdenDePedido.Text), 5)) {

                        string[] actualizarProductosEntregarPedido = controladorAdministrador.ActualizarProductosEntregarPedido(int.Parse(TxtIdOrdenDePedido.Text));
                        if (bool.Parse(actualizarProductosEntregarPedido[0]))
                        {
                            MessageBox.Show(actualizarProductosEntregarPedido[1]);
                            InfoOrdenDePedido(this.idOrdenPedido);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo registrar la entrega");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar");
                    }
                }
                else if (actualizarEstado.Equals("Cancelar")) {
                    if (TxtEstado.Text.Equals("Aprobado") || TxtEstado.Text.Equals("En camino"))
                    { 
                        if (controladorAdministrador.ActualizarEstadoPedido(int.Parse(TxtIdOrdenDePedido.Text), 6))
                        {
                            bool actualizarProductosCancelarPedidos = controladorAdministrador.ActualizarProductosCancelarPedido(DgvPedidos.Rows);
                            if (actualizarProductosCancelarPedidos)
                            {
                                MessageBox.Show("Orden de pedido se ha actualizado correctamente");
                                InfoOrdenDePedido(this.idOrdenPedido);
                            }
                            else {
                                MessageBox.Show("No se pudieron actualizar los productos del proveedor");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar");
                        }
                    }
                    else {
                        if (controladorAdministrador.ActualizarEstadoPedido(int.Parse(TxtIdOrdenDePedido.Text), 6)){
                            MessageBox.Show("Orden de pedido se ha actualizado correctamente");
                            InfoOrdenDePedido(this.idOrdenPedido);
                        }
                        else{
                            MessageBox.Show("No se pudo actualizar");
                        }
                    }
                }
            }
        }

        private void VerOrdenDePedido_Load(object sender, EventArgs e)
        {

        }
    }
}
