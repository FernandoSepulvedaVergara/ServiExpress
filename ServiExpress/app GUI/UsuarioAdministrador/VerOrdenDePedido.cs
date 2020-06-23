using ServiExpress.controlador;
using ServiExpress.WebServiceAdministrador;
using System.Windows.Forms;

namespace ServiExpress.app_GUI.UsuarioAdministrador
{
    public partial class VerOrdenDePedido : Form
    {
        ControladorAdministrador controladorAdministrador;
        public VerOrdenDePedido(ControladorAdministrador controladorAdministrador,int idOrdenDePedido)
        {
            this.controladorAdministrador = controladorAdministrador;
            ordenDePedido ordenDePedido = this.controladorAdministrador.GetOrdenDePedido(idOrdenDePedido);
            pedidos[] pedidos = this.controladorAdministrador.GetPedidos(idOrdenDePedido);
            InitializeComponent();
            TxtIdOrdenDePedido.Text = ordenDePedido.idOrdenPedido.ToString();
            TxtTotal.Text = ordenDePedido.total.ToString();
            TxtAdministrador.Text = ordenDePedido.usuarioRut;
            TxtEstado.Text = ordenDePedido.estadoDePedido.estado;

            foreach (pedidos pedido in pedidos){
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(DgvPedidos);
                dataGridViewRow.Cells[0].Value = pedido.idPedido;
                dataGridViewRow.Cells[1].Value = pedido.cantidad;
                dataGridViewRow.Cells[2].Value = pedido.precioCompra;
                dataGridViewRow.Cells[3].Value = pedido.totalAPagar;
                dataGridViewRow.Cells[4].Value = pedido.idPedido;
                dataGridViewRow.Cells[5].Value = pedido.descripcion;
                dataGridViewRow.Cells[6].Value = pedido.marca;
                dataGridViewRow.Cells[7].Value = pedido.fechaDeVencimiento;
                DgvPedidos.Rows.Add(dataGridViewRow);
            }
        }
    }
}
