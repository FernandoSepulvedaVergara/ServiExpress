using ServiExpress.controlador;
using ServiExpress.WebServiceAdministrador;
using ServiExpress.WebServiceEmpleado;
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
    public partial class AdministrarProductos : Form
    {
        private ControladorAdministrador controladorAdministrador;

        public AdministrarProductos(ControladorAdministrador controladorAdministrador)
        {
            this.controladorAdministrador = controladorAdministrador;
            InitializeComponent();
        }

        private void AdministrarProductos_Load(object sender, EventArgs e)
        {
            WebServiceAdministrador.tipoDeProducto[] resultado = controladorAdministrador.GetTipoDeProductos();

            foreach (var tipoDeProducto in resultado) 
            {
                CmbSeleccionarProducto.Items.Add(string.Format("{0} - {1}", tipoDeProducto.idTipoDeProducto, tipoDeProducto.producto));
            }
        }

        private void CmbSeleccionarProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idTipoDeProducto = int.Parse(CmbSeleccionarProducto.SelectedItem.ToString().Substring(0, CmbSeleccionarProducto.SelectedItem.ToString().IndexOf("-")).Trim());
            WebServiceAdministrador.producto[] resultado = controladorAdministrador.GetProductos(idTipoDeProducto);

            CmbProductos.Items.Clear();
            foreach (var producto in resultado)
            {
                CmbProductos.Items.Add(string.Format("{0} - {1}", producto.idProducto, producto.descripcion));
            }
        }

        private void CmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarInfo();
        }

        private void ActualizarInfo() {
            int idProducto = int.Parse(CmbProductos.SelectedItem.ToString().Substring(0, CmbProductos.SelectedItem.ToString().IndexOf("-")).Trim());
            WebServiceAdministrador.producto resultado = controladorAdministrador.GetInfoProducto(idProducto);

            TxtIdProducto.Text = resultado.idProducto.ToString();
            TxtDescripcion.Text = resultado.descripcion;
            TxtMarca.Text = resultado.marca;
            if (resultado.fechaVencimiento != null)
            {
                TxtFechaDeVencimiento.Text = resultado.fechaVencimiento;
            }
            else
            {
                TxtFechaDeVencimiento.Text = "Sin fecha de vencimiento";
            }
            TxtPrecioDeCompra.Text = resultado.precioCompra.ToString();
            TxtPrecioDeVenta.Text = resultado.precioVenta.ToString();
            if (resultado.stock <= resultado.stockCritico)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
            }
            else {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
            }
            TxtStock.Text = resultado.stock.ToString();
            TxtStockCritico.Text = resultado.stockCritico.ToString();
            TxtOrdenDePedido.Text = resultado.idOrdenDePedido.ToString();
            TxtProveedor.Text = resultado.rutProveedor;
            if (resultado.estadoDeProducto.idEstadoDeProducto.Equals(1))
            {
                ChbEstadoDeProducto.Checked = true;
                ChbEstadoDeProducto.Text = "Disponible";
            }
            else
            {
                ChbEstadoDeProducto.Checked = false;
                ChbEstadoDeProducto.Text = "No disponible";
            }
            panel1.Visible = true;
        }

        private void ChbEstadoDeProducto_Click(object sender, EventArgs e)
        {
            if (ChbEstadoDeProducto.Checked)
            {
                DialogResult dialogResult = MessageBox.Show(string.Format("¿Quitar stock de este producto?"), "Estado de producto", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (controladorAdministrador.ActualizarEstadoProducto(int.Parse(TxtIdProducto.Text), 2))
                    {
                        ChbEstadoDeProducto.Checked = false;
                        MessageBox.Show("Estado actualizado con éxito");
                    }
                    else
                    {
                        ChbEstadoDeProducto.Checked = true;
                        MessageBox.Show("Error al actualizar estado");
                    }
                }
            }
            else if (ChbEstadoDeProducto.Checked.Equals(false))
            {
                DialogResult dialogResult = MessageBox.Show(string.Format("¿Colocar en stock este producto?"), "Estado de producto", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (controladorAdministrador.ActualizarEstadoProducto(int.Parse(TxtIdProducto.Text), 1))
                    {
                        MessageBox.Show("Estado actualizado con éxito");
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar estado");
                    }
                }
            }
            else
            {
                MessageBox.Show("Error al validar checkbox");
            }
            ActualizarInfo();
        }

        private void ChbEstadoDeProducto_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
