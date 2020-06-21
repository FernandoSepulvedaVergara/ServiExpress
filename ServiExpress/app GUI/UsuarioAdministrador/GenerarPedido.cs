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
        }

        private void GenerarPedido_Load(object sender, EventArgs e)
        {
            proveedor[] proveedores = controladorAdministrador.GetProveedores();
            foreach (var proveedor in proveedores) {
                CmbProveedores.Items.Add(string.Format("{0} - {1}", proveedor.rutProveedor, proveedor.razonSocial));
            }
        }

        private void CmbProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoDeProducto[] tipoDeProductos = controladorAdministrador.GetTipoDeProductos();
            foreach (var tipoDeProducto in tipoDeProductos)
            {
                CmbTipoDeProducto.Items.Add(string.Format("{0} - {1}", tipoDeProducto.idTipoDeProducto, tipoDeProducto.producto));
            }
        }

        private void CmbTipoDeProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbProductos.Items.Clear();
            string rutProveedor = CmbProveedores.SelectedItem.ToString().Substring(0, CmbProveedores.SelectedItem.ToString().IndexOf("-")).Trim();
            int idTipoDeProducto = int.Parse(CmbTipoDeProducto.SelectedItem.ToString().Substring(0, CmbTipoDeProducto.SelectedItem.ToString().IndexOf("-")).Trim());
            productoProveedor[] tipoDeProductos = controladorAdministrador.GetProductosProveedor(idTipoDeProducto, rutProveedor);
            foreach (var tipoDeProducto in tipoDeProductos)
            {
                CmbProductos.Items.Add(string.Format("{0} - {1}", tipoDeProducto.idProducto, tipoDeProducto.descripcion));
            }
        }
    }
}
