using Microsoft.VisualBasic.Logging;
using ServiExpress.WebServiceAdministrador;
using ServiExpress.WebServiceCliente;
using ServiExpress.WebServiceProveedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiExpress.controlador
{
    public class ControladorProveedor : ControladorPrincipal
    {
        public string[] login { get; set; }
        private WebServiceProveedorClient webProveedor = new WebServiceProveedorClient();

        public ControladorProveedor(string[] login)
        {
            this.login = login;
        }

        public override string[] GetInfo()
        {
            return null;
        }

        public override DataGridView SetDataGridView(DataGridView Dgv)
        {
            return null;
        }

        public WebServiceProveedor.tipoDeProducto[] GetTipoDeProducto()
        {
            return webProveedor.GetTipoDeProducto();
        }
        public WebServiceProveedor.productoProveedor[] GetProductosProveedor(int idTipoDeProducto)
        {
            return webProveedor.GetProductosProveedor(idTipoDeProducto,this.login[0]);
        }

        public WebServiceProveedor.productoProveedor GetInfoProductoProveedor(int idProductoProveedor)
        {
            return  webProveedor.ObtenerInfoProductoProveedor(idProductoProveedor,this.login[0]);
        }

        public bool ActualizarEstadoProductoProveedor(int idProducto, int idEstado)
        {
            return webProveedor.ActualizarEstadoProductoProveedor(idProducto, idEstado);
        }

        public string[] ActualizarProductoProveedor(int idProducto, string fechaDeVencimiento, int stock, int precioDeCompra)
        {
            return webProveedor.ActualizarProductoProveedor(idProducto, fechaDeVencimiento, stock, precioDeCompra);
        }

        public string[] AgregarNuevoTipoDeProducto(string tipoDeProducto)
        {
            return webProveedor.AgregarNuevoTipoDeProducto(tipoDeProducto);
        }

        public string[] RegistrarNuevoProductoProveedor(string descripcion, string marca, string fechaDeVencimiento, int precioDeCompra, int stock, int idTipoDeProducto, int idEstadoDeProducto)
        {
            return webProveedor.RegistrarNuevoProductoProveedor(descripcion, marca, fechaDeVencimiento, precioDeCompra, stock, idTipoDeProducto, this.login[0], idEstadoDeProducto);
        }

        public WebServiceProveedor.ordenDePedido[] GetOrdenesDePedidoProveedor(bool filtroSeleccionarTodosLosPedidos, bool filtroBuscar, bool filtroEstado, string tipoDeBusqueda, string valorFiltro) {
            return webProveedor.GetOrdenesDePedidoProveedor(filtroSeleccionarTodosLosPedidos, filtroBuscar, filtroEstado, tipoDeBusqueda, valorFiltro, login[0]);
        }
        
        public WebServiceProveedor.ordenDePedido GetOrdenDePedidoProveedor(int idOrdenDePedido)
        {
            return webProveedor.GetOrdenDePedidoProveedor(idOrdenDePedido);
        }

        public WebServiceProveedor.pedidos[] GetPedidosProveedor(int idOrdenDePedido)
        {
            return webProveedor.GetPedidosProveedor(idOrdenDePedido);
        }

        public bool ActualizarEstadoPedido(int idPedido, int idEstado)
        {
            return webProveedor.ActualizarEstadoPedido(idPedido, idEstado);
        }

        public bool ActualizarProductosAprobarPedido(DataGridViewRowCollection dataGridViewRows)
        {
            bool resultado = false;
            foreach (DataGridViewRow dataGridViewRow in dataGridViewRows)
            {
                string[] actualizarProductosAprobarPedido = webProveedor.ActualizarProductosAprobarPedido(int.Parse(dataGridViewRow.Cells[4].Value.ToString()), int.Parse(dataGridViewRow.Cells[1].Value.ToString()));

                if (bool.Parse(actualizarProductosAprobarPedido[0]))
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                    break;
                }
            }
            return resultado;
        }
    }
}
