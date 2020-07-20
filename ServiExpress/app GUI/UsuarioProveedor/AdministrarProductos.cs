using ServiExpress.controlador;
using ServiExpress.WebServiceProveedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiExpress.app_GUI.UsuarioProveedor
{
    public partial class AdministrarProductos : Form
    {
        ControladorProveedor controladorProveedor;
        string fechaDeVencimiento = null;
        public AdministrarProductos(ControladorProveedor controladorProveedor)
        {
            this.controladorProveedor = controladorProveedor;
            InitializeComponent();
        }

        private void AdministrarProductos_Load(object sender, EventArgs e)
        {
            tipoDeProducto[] resultado = controladorProveedor.GetTipoDeProducto();

            foreach (var tipoDeProducto in resultado)
            {
                CmbSeleccionarTipoDeProducto.Items.Add(string.Format("{0} - {1}", tipoDeProducto.idTipoDeProducto, tipoDeProducto.producto));
            }
        }

        private void CmbProductosProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarInfo();
        }



        private void CmbSeleccionarTipoDeProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idTipoDeProducto = int.Parse(CmbSeleccionarTipoDeProducto.SelectedItem.ToString().Substring(0, CmbSeleccionarTipoDeProducto.SelectedItem.ToString().IndexOf("-")).Trim());
            WebServiceProveedor.productoProveedor[] resultado = controladorProveedor.GetProductosProveedor(idTipoDeProducto);

            CmbProductosProveedor.Items.Clear();
            foreach (var productoProveedor in resultado)
            {
                CmbProductosProveedor.Items.Add(string.Format("{0} - {1}", productoProveedor.idProducto, productoProveedor.descripcion));
            }
        }

        private void ActualizarInfo()
        {
            int idProductoProveedor = int.Parse(CmbProductosProveedor.SelectedItem.ToString().Substring(0, CmbProductosProveedor.SelectedItem.ToString().IndexOf("-")).Trim());
            WebServiceProveedor.productoProveedor resultado = controladorProveedor.GetInfoProductoProveedor(idProductoProveedor);

            TxtIdProducto.Text = resultado.idProducto.ToString();
            TxtDescripcion.Text = resultado.descripcion;
            TxtMarca.Text = resultado.marca;
            if (resultado.fechaDeVencimiento != null)
            {
                TxtFechaDeVencimiento.Text = resultado.fechaDeVencimiento;
            }
            else
            {
                TxtFechaDeVencimiento.Text = "Sin fecha de vencimiento";
            }
            TxtPrecioDeCompra.Text = resultado.precioDeCompra.ToString();
            if (resultado.stock <= 20)
            {
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }
            TxtStock.Text = resultado.stock.ToString();
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
                    if (controladorProveedor.ActualizarEstadoProductoProveedor(int.Parse(TxtIdProducto.Text), 2))
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
                    if (controladorProveedor.ActualizarEstadoProductoProveedor(int.Parse(TxtIdProducto.Text), 1))
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

        private void BtnActualizarProducto_Click(object sender, EventArgs e)
        {
            TxtFechaDeVencimiento.Enabled = true;
            this.fechaDeVencimiento = TxtFechaDeVencimiento.Text;
            TxtFechaDeVencimiento.Clear();
            TxtStock.Visible = false;
            TxtPrecioDeCompra.Enabled = true;
            NumStock.Visible = true;
            NumStock.Value = int.Parse(TxtStock.Text);
            BtmGuardar.Visible = true;
            BtnCancelar.Visible = true;
            BtnActualizarProducto.Visible = false;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtFechaDeVencimiento.Enabled = false;
            TxtFechaDeVencimiento.Text = this.fechaDeVencimiento;
            TxtStock.Visible = true;
            TxtPrecioDeCompra.Enabled = false;
            NumStock.Visible = false;
            NumStock.Value = int.Parse(TxtStock.Text);
            BtmGuardar.Visible = false;
            BtnCancelar.Visible = false;
            BtnActualizarProducto.Visible = true;
        }

        private void BtmGuardar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(string.Format("¿{0}?", "Actualizar producto"), "Actualizar producto", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                string[] resultado = controladorProveedor.ActualizarProductoProveedor(int.Parse(TxtIdProducto.Text), TxtFechaDeVencimiento.Text, int.Parse(NumStock.Value.ToString()), int.Parse(TxtPrecioDeCompra.Text));
                MessageBox.Show(string.Format("{0}", resultado[1]));
                TxtFechaDeVencimiento.Enabled = false;
                TxtStock.Visible = true;
                TxtPrecioDeCompra.Enabled = false;
                NumStock.Visible = false;
                NumStock.Value = int.Parse(TxtStock.Text);
                BtmGuardar.Visible = false;
                BtnCancelar.Visible = false;
                BtnActualizarProducto.Visible = true;
                ActualizarInfo();
            }            
        }

        private void BtnAgregarNuevoProducto_Click(object sender, EventArgs e)
        {
            AgregarNuevoProducto agregarNuevoProducto = new AgregarNuevoProducto(controladorProveedor);
            agregarNuevoProducto.ShowDialog();
            CmbSeleccionarTipoDeProducto.Items.Clear();
            tipoDeProducto[] resultado = controladorProveedor.GetTipoDeProducto();
            foreach (var tipoDeProducto in resultado)
            {
                CmbSeleccionarTipoDeProducto.Items.Add(string.Format("{0} - {1}", tipoDeProducto.idTipoDeProducto, tipoDeProducto.producto));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarNuevoTipoDeProducto agregarNuevoTipoDeProducto = new AgregarNuevoTipoDeProducto(controladorProveedor);
            agregarNuevoTipoDeProducto.ShowDialog();
            CmbSeleccionarTipoDeProducto.Items.Clear();
            tipoDeProducto[] resultado = controladorProveedor.GetTipoDeProducto();
            foreach (var tipoDeProducto in resultado)
            {
                CmbSeleccionarTipoDeProducto.Items.Add(string.Format("{0} - {1}", tipoDeProducto.idTipoDeProducto, tipoDeProducto.producto));
            }
        }

        private void TxtFechaDeVencimiento_KeyUp(object sender, KeyEventArgs e)
        {
            ValidacionEntradas.ValidarFormatoFecha(TxtFechaDeVencimiento, 3);
        }

        private void TxtFechaDeVencimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionEntradas.ValidarFecha(e, TxtFechaDeVencimiento);
        }

        private void TxtPrecioDeCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionEntradas.ValidarNumeros(e);
        }
    }
}
