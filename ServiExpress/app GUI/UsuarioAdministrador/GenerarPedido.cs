using ServiExpress.app_GUI.UsuarioEmpleado.ReservarsDehora;
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
    public partial class GenerarPedido : Form
    {
        ControladorAdministrador controladorAdministrador;
        public GenerarPedido(ControladorAdministrador controladorAdministrador)
        {
            this.controladorAdministrador = controladorAdministrador;
            InitializeComponent();
            TxtFechaDePedido.Text = DateTime.Now.ToString().Substring(0, 8);
        }

        private void GenerarPedido_Load(object sender, EventArgs e)
        {
            DgvProductosProveedor.Rows.Clear();
            proveedor[] proveedores = controladorAdministrador.GetProveedores();
            foreach (var proveedor in proveedores)
            {
                CmbProveedores.Items.Add(string.Format("{0} - {1}", proveedor.rutProveedor, proveedor.razonSocial));
            }
        }

        private void CmbProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            DgvProductosProveedor.Rows.Clear();
            tipoDeProducto[] tipoDeProductos = controladorAdministrador.GetTipoDeProductos();
            foreach (var tipoDeProducto in tipoDeProductos)
            {
                CmbTipoDeProducto.Items.Add(string.Format("{0} - {1}", tipoDeProducto.idTipoDeProducto, tipoDeProducto.producto));
            }
            DgvProductosProveedor.Rows.Clear();
        }

        private void CmbTipoDeProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbProductos.Items.Clear();
            string rutProveedor = CmbProveedores.SelectedItem.ToString().Substring(0, CmbProveedores.SelectedItem.ToString().IndexOf("-")).Trim();
            int idTipoDeProducto = int.Parse(CmbTipoDeProducto.SelectedItem.ToString().Substring(0, CmbTipoDeProducto.SelectedItem.ToString().IndexOf("-")).Trim());
            productoProveedor[] productosProveedor = controladorAdministrador.GetProductosProveedor(idTipoDeProducto, rutProveedor);
            foreach (var producto in productosProveedor)
            {
                CmbProductos.Items.Add(string.Format("{0} - {1}", producto.idProducto, producto.descripcion));
            }
        }

        private void CmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idProductoProveedor = int.Parse(CmbProductos.SelectedItem.ToString().Substring(0, CmbProductos.SelectedItem.ToString().IndexOf("-")).Trim());
            string rutProveedor = CmbProveedores.SelectedItem.ToString().Substring(0, CmbProveedores.SelectedItem.ToString().IndexOf("-")).Trim();
            productoProveedor productoProveedor = controladorAdministrador.GetInfoProductoProveedor(idProductoProveedor, rutProveedor);
            DataGridViewRow dataGridViewRow = new DataGridViewRow();
            dataGridViewRow.CreateCells(DgvProductosProveedor);
            if (DgvProductosProveedor.Rows.Count == 0)
            {
                dataGridViewRow.Cells[0].Value = productoProveedor.idProducto;
                dataGridViewRow.Cells[1].Value = productoProveedor.descripcion;
                dataGridViewRow.Cells[2].Value = productoProveedor.marca;
                dataGridViewRow.Cells[3].Value = productoProveedor.rutProveedor;
                dataGridViewRow.Cells[4].Value = productoProveedor.fechaDeVencimiento;
                dataGridViewRow.Cells[5].Value = productoProveedor.precioDeCompra;
                dataGridViewRow.Cells[6].Value = productoProveedor.stock;
                dataGridViewRow.Cells[7].Value = 1;
                DgvProductosProveedor.Rows.Add(dataGridViewRow);
            }
            else
            {
                bool validarProductoAgregado = false;
                foreach (DataGridViewRow objecto in DgvProductosProveedor.Rows)
                {
                    if (objecto.Cells[0].Value.Equals(productoProveedor.idProducto))
                    {
                        validarProductoAgregado = true;
                        break;
                    }
                    else
                    {
                        validarProductoAgregado = false;
                    }
                }

                if (validarProductoAgregado != true)
                {
                    dataGridViewRow.Cells[0].Value = productoProveedor.idProducto;
                    dataGridViewRow.Cells[1].Value = productoProveedor.descripcion;
                    dataGridViewRow.Cells[2].Value = productoProveedor.marca;
                    dataGridViewRow.Cells[3].Value = productoProveedor.rutProveedor;
                    dataGridViewRow.Cells[4].Value = productoProveedor.fechaDeVencimiento;
                    dataGridViewRow.Cells[5].Value = productoProveedor.precioDeCompra;
                    dataGridViewRow.Cells[6].Value = productoProveedor.stock;
                    dataGridViewRow.Cells[7].Value = 1;
                    DgvProductosProveedor.Rows.Add(dataGridViewRow);
                }
                else
                {
                    MessageBox.Show("Producto ya esta agregado");
                }                
            }
            ActualizarProductosProveedor();
        }

        private void BtnQuitarProducto_Click(object sender, EventArgs e)
        {
            if (DgvProductosProveedor.Rows.Count != 0)
            {
                int indiceRow = DgvProductosProveedor.CurrentRow.Index;
                DgvProductosProveedor.Rows.RemoveAt(indiceRow);
                ActualizarProductosProveedor();
            }
        }

        private void ActualizarProductosProveedor()
        {
            int montoTotal = 0;
            foreach (DataGridViewRow fila in DgvProductosProveedor.Rows)
            {
                montoTotal += (int.Parse(fila.Cells[5].Value.ToString()) * int.Parse(fila.Cells[7].Value.ToString()));
            }
            LblMontoAPagar.Text = montoTotal.ToString();
        }

        private void DgvProductosProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvProductosProveedor.Rows[DgvProductosProveedor.CurrentRow.Index].Cells[7].ColumnIndex.Equals(e.ColumnIndex))
            {
                int cantidadActual = Convert.ToInt32(DgvProductosProveedor.CurrentRow.Cells[7].Value);
                int stock = Convert.ToInt32(DgvProductosProveedor.CurrentRow.Cells[6].Value);
                int precioUnitario = Convert.ToInt32(DgvProductosProveedor.CurrentRow.Cells[5].Value);
                SeleccionarCantidad seleccionarCantidad = new SeleccionarCantidad(cantidadActual, stock, precioUnitario);
                seleccionarCantidad.ShowDialog();
                DgvProductosProveedor.CurrentRow.Cells[7].Value = seleccionarCantidad.cantidad;
                ActualizarProductosProveedor();
            }
        }

        private void BtnRegistrarPedido_Click(object sender, EventArgs e)
        {
            if (DgvProductosProveedor.Rows.Count.Equals(0))
            {
                MessageBox.Show("No se ha agregado ningún producto");
            }
            else {
                string[] resultadoRegistrarOrdePedido = controladorAdministrador.RegistrarOrdenDePedido(TxtFechaDePedido.Text,int.Parse(LblMontoAPagar.Text), controladorAdministrador.login[0], 1);
                bool resultado = false;
                if (Convert.ToBoolean(resultadoRegistrarOrdePedido[0]))
                {
                    foreach (DataGridViewRow dataGridViewRow in DgvProductosProveedor.Rows){
                        int cantidad = int.Parse(dataGridViewRow.Cells[7].Value.ToString());
                        int totalAPagar = int.Parse(dataGridViewRow.Cells[5].Value.ToString()) * int.Parse(dataGridViewRow.Cells[7].Value.ToString());
                        int idOrdenPedido = int.Parse(resultadoRegistrarOrdePedido[2]);
                        int idProductoProveedor = int.Parse(dataGridViewRow.Cells[0].Value.ToString());

                        string[] resultadoRegistrarPedido = controladorAdministrador.RegistrarPedido(cantidad,totalAPagar,idOrdenPedido,idProductoProveedor);
                        if (Convert.ToBoolean(resultadoRegistrarPedido[0]))
                        {
                            resultado = true;
                        }
                        else 
                        {
                            resultado = false;
                        }                    
                    }
                    if (resultado != false)
                    {
                        MessageBox.Show("Orden de pedido guardado con éxito");
                        DgvProductosProveedor.Rows.Clear();
                    }
                    else 
                    {
                        MessageBox.Show("Error alguardar los datos");
                    }
                }                
                else {
                    MessageBox.Show(resultadoRegistrarOrdePedido[1]);
                }
            }
        }
    }
}
