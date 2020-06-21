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
        string[] login { get; set; }
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

        public proveedor[] GetProveedores() 
        {
            return webAdministrador.GetProveedores();
        }
    }
}
