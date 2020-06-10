using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiExpress.app_GUI.UsuarioEmpleado.ReservarsDehora
{
    public partial class SeleccionarCantidad : Form
    {
        public int cantidad { get; set; }
        public int cantidadActual { get; set; }
        public int stock { get; set; }
        public int precioUnitario { get; set; }

        public SeleccionarCantidad(int cantidadActual, int stock, int precioUnitario)
        {
            this.cantidadActual = cantidadActual;
            this.stock = stock;
            this.precioUnitario = precioUnitario;
            InitializeComponent();
        }

        private void BtnGuardarCantidad_Click(object sender, EventArgs e)
        {
            this.cantidad = int.Parse(NudCantidad.Value.ToString());
            this.Close();
        }

        private void SeleccionarCantidad_Load(object sender, EventArgs e)
        {
            NudCantidad.Maximum = this.stock;
            LblStock.Text = this.stock.ToString();
            LblPrecioUnitario.Text = this.precioUnitario.ToString();
            NudCantidad.Value = this.cantidadActual;
            LblTotal.Text = (NudCantidad.Value * this.precioUnitario).ToString();
        }

        private void NudCantidad_ValueChanged(object sender, EventArgs e)
        {
            LblTotal.Text = (NudCantidad.Value * this.precioUnitario).ToString();
        }
    }
}
