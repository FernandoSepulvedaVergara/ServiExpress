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
    }
}
