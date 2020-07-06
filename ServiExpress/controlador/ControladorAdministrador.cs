using ServiExpress.WebServiceAdministrador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiExpress.controlador
{
    public class ControladorAdministrador : ControladorPrincipal
    {
        public string[] login { get; set; }
        private WebServiceAdministradorClient webAdministrador = new WebServiceAdministradorClient();

        public ControladorAdministrador(string[] login)
        {
            this.login = login;
        }

        public override string[] GetInfo()
        {
            throw new NotImplementedException();
        }

        public override DataGridView SetDataGridView(DataGridView Dgv)
        {
            throw new NotImplementedException();
        }

        public tipoDeProducto[] GetTipoDeProductos() 
        {

            tipoDeProducto[] resultado =  webAdministrador.GetTipoDeProducto();
            return resultado;
        }

        public productoProveedor[] GetProductosProveedor(int idTipoDeProducto, string rutProveedor)
        {

            productoProveedor[] resultado = webAdministrador.GetProductosProveedor(idTipoDeProducto,rutProveedor);
            return resultado;
        }

        public producto[] GetProductos(int idTipoDeProducto)
        {
            return webAdministrador.GetProductos(idTipoDeProducto);
        }

        public producto GetInfoProducto(int idProducto)
        {
            return webAdministrador.GetInfoProducto(idProducto);
        }

        public productoProveedor GetInfoProductoProveedor(int idProductoProveedor, string rutProveedor)
        {
            return webAdministrador.GetInfoProductoProveedor(idProductoProveedor, rutProveedor);
        }

        public proveedor[] GetProveedores() 
        {
            return webAdministrador.GetProveedores();
        }

        public ordenDePedido[] GetOrdenesDePedido()
        {
            return webAdministrador.GetOrdenesDePedido();
        }

        public string[] RegistrarOrdenDePedido(string fechaDePedido, int total, string usuarioRut, int idEstadoPedido)
        {
            return webAdministrador.RegistrarOrdenDePedido(fechaDePedido,total, usuarioRut, idEstadoPedido);
        }

        public string[] RegistrarPedido(int cantidad, int totalAPagar,int idOrdenPedido,int idProductoProveedor) {

            return webAdministrador.RegistrarPedido(cantidad, totalAPagar, idOrdenPedido, idProductoProveedor);
        }

        public ordenDePedido GetOrdenDePedido(int idOrdenDePedido) 
        {
            return webAdministrador.GetOrdenDePedido(idOrdenDePedido);
        }

        public pedidos[] GetPedidos(int idOrdenDePedido)
        {
            return webAdministrador.GetPedidos(idOrdenDePedido);
        }

        public bool ActualizarEstadoPedido(int idPedido, int idEstado)
        {
            return webAdministrador.ActualizarEstadoPedido(idPedido, idEstado);
        }

        public bool ActualizarProductosCancelarPedido(DataGridViewRowCollection dataGridViewRows)
        {
            bool resultado = false;
            foreach (DataGridViewRow dataGridViewRow in dataGridViewRows) {
                string[] actualizarProductosCancelarPedido = webAdministrador.ActualizarProductosCancelarPedido(int.Parse(dataGridViewRow.Cells[4].Value.ToString()), int.Parse(dataGridViewRow.Cells[1].Value.ToString()));
                
                if (bool.Parse(actualizarProductosCancelarPedido[0])) {
                    resultado = true;
                }
                else {
                    resultado = false;
                    break;
                }
            }
            return resultado;
        }

        public string[] ActualizarProductosEntregarPedido(int idOrdenDePedido) {
            return webAdministrador.ActualizarProductosEntregarPedido(idOrdenDePedido);
        }

        public bool ActualizarEstadoProducto(int idProducto, int idEstado) {
            return webAdministrador.ActualizarEstadoProducto(idProducto, idEstado);
        }
    }
}
