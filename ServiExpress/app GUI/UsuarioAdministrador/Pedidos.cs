using ServiExpress.controlador;
using ServiExpress.WebServiceAdministrador;
using System;
using System.Windows.Forms;

namespace ServiExpress.app_GUI.UsuarioAdministrador
{
    public partial class Pedidos : Form
    {
        ControladorAdministrador controladorAdministrador;
        bool filtroSeleccionarTodosLosPedidos = false;
        bool filtroBuscar = false;
        bool filtroEstado = false;
        string tipoDeBusqueda;
        string valorFiltro;

        public Pedidos(ControladorAdministrador controladorAdministrador)
        {
            this.controladorAdministrador = controladorAdministrador;
            InitializeComponent();
        }

        private void BtnGenerarPedido_Click(object sender, EventArgs e)
        {
            GenerarPedido generarPedido = new GenerarPedido(this.controladorAdministrador);
            generarPedido.ShowDialog();
            ActualizarOrdenesDePedido(filtroSeleccionarTodosLosPedidos, filtroBuscar, filtroEstado, this.tipoDeBusqueda, this.valorFiltro);
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            filtroSeleccionarTodosLosPedidos = true;
            filtroBuscar = false;
            filtroEstado = false;
            ActualizarOrdenesDePedido(filtroSeleccionarTodosLosPedidos, filtroBuscar, filtroEstado, null, null);
        }

        private void ActualizarOrdenesDePedido(bool filtroSeleccionarTodosLosPedidos,bool filtroBuscar,bool filtroEstado,string tipoDeBusqueda, string valorFiltro)
        {
            ordenDePedido[] ordenesDePedido = controladorAdministrador.GetOrdenesDePedido(filtroSeleccionarTodosLosPedidos, filtroBuscar, filtroEstado, tipoDeBusqueda, valorFiltro);
            DgvOrdenesDePedido.Rows.Clear();
            try
            {
                if (ordenesDePedido == null) {
                    DgvOrdenesDePedido.Rows.Clear();
                }
                else
                {
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
            }
            catch(Exception ex) {
                    MessageBox.Show("Error \n" + ex.Message);                
            }
        }

        private void DgvOrdenesDePedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvOrdenesDePedido.Rows[DgvOrdenesDePedido.CurrentRow.Index].Cells[0].ColumnIndex.Equals(e.ColumnIndex))
            {
                VerOrdenDePedido verOrdenDePedido = new VerOrdenDePedido(controladorAdministrador, int.Parse(DgvOrdenesDePedido.CurrentRow.Cells[1].Value.ToString()));
                verOrdenDePedido.ShowDialog();
                ActualizarOrdenesDePedido(filtroSeleccionarTodosLosPedidos,filtroBuscar,filtroEstado,this.tipoDeBusqueda, this.valorFiltro);
            }
        }

        private void BtnSeleccionarTodosLosPedidos_Click(object sender, EventArgs e)
        {
            filtroSeleccionarTodosLosPedidos = true;
            filtroBuscar = false;
            filtroEstado = false;
            ActualizarOrdenesDePedido(filtroSeleccionarTodosLosPedidos, filtroBuscar, filtroEstado, null,null);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (RdbIdOrdenDePedido.Checked.Equals(true) || RdbProveedor.Checked.Equals(true) || RdbFechaDePedido.Checked.Equals(true))
            {
                if (TxtBuscar.Text.Equals(string.Empty)) {
                    MessageBox.Show("No se ha ingresado ningún valor");
                }
                else {
                    filtroSeleccionarTodosLosPedidos = false;
                    filtroBuscar = true;
                    filtroEstado = false;
                    this.valorFiltro = TxtBuscar.Text;
                    ActualizarOrdenesDePedido(filtroSeleccionarTodosLosPedidos, filtroBuscar, filtroEstado, this.tipoDeBusqueda, this.valorFiltro);
                }
            }
            else {
                MessageBox.Show("Seleccione un tipo de búsqueda");
            }
        }

        private void CmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbEstado.SelectedItem == null)
            {
                MessageBox.Show("No se ha seleccionado un estado");
            }
            else {
                filtroSeleccionarTodosLosPedidos = false;
                filtroBuscar = false;
                filtroEstado = true;
                this.valorFiltro = CmbEstado.SelectedItem.ToString();
                ActualizarOrdenesDePedido(filtroSeleccionarTodosLosPedidos, filtroBuscar, filtroEstado, null, this.valorFiltro);
            }
        }

        private void RdbIdOrdenDePedido_CheckedChanged(object sender, EventArgs e)
        {
            this.tipoDeBusqueda = RdbIdOrdenDePedido.Text;
            TxtBuscar.Enabled = true;
        }

        private void RdbProveedor_CheckedChanged(object sender, EventArgs e)
        {
            this.tipoDeBusqueda = RdbProveedor.Text;
            TxtBuscar.Enabled = true;
        }

        private void RdbFechaDePedido_CheckedChanged(object sender, EventArgs e)
        {
            this.tipoDeBusqueda = RdbFechaDePedido.Text;
            TxtBuscar.Enabled = true;
        }
    }
}
