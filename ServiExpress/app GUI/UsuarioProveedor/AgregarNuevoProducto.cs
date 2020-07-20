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
    public partial class AgregarNuevoProducto : Form
    {
        ControladorProveedor controladorProveedor;
        public AgregarNuevoProducto(ControladorProveedor controladorProveedor)
        {
            this.controladorProveedor = controladorProveedor;
            InitializeComponent();
        }

        private void AgregarNuevoProducto_Load(object sender, EventArgs e)
        {
            CmbTipoDeProducto.Items.Clear();
            tipoDeProducto[] resultado = controladorProveedor.GetTipoDeProducto();
            foreach (var tipoDeProducto in resultado)
            {
                CmbTipoDeProducto.Items.Add(string.Format("{0} - {1}", tipoDeProducto.idTipoDeProducto, tipoDeProducto.producto));
            }
        }

        private void BtnGuardarProducto_Click(object sender, EventArgs e)
        {
            if (CmbTipoDeProducto.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar el tipo de producto");
            }
            else {
                DialogResult dialogResult = MessageBox.Show(string.Format("¿{0}?", "Registrar producto"), "Registrar nuevo producto", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int idTipoDeProducto = int.Parse(CmbTipoDeProducto.SelectedItem.ToString().Substring(0, CmbTipoDeProducto.SelectedItem.ToString().IndexOf("-")).Trim());
                    string[] resultado = controladorProveedor.RegistrarNuevoProductoProveedor(TxtDescripcion.Text, TxtMarca.Text, TxtFechaDeVencimiento.Text, int.Parse(TxtPrecioDeCompra.Text), int.Parse(TxtStock.Text), idTipoDeProducto, 2);
                    MessageBox.Show(resultado[1]);
                }
            }
        }

        private void TxtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionEntradas.ValidarModelo(e);
        }

        private void TxtFechaDeVencimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionEntradas.ValidarFecha(e, TxtFechaDeVencimiento);
        }

        private void TxtFechaDeVencimiento_KeyUp(object sender, KeyEventArgs e)
        {
            ValidacionEntradas.ValidarFormatoFecha(TxtFechaDeVencimiento,3);
        }

        private void TxtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionEntradas.ValidarNumeros(e);
        }
    }
}
