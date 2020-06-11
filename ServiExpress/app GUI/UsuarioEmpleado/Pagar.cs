using ServiExpress.controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiExpress.app_GUI.UsuarioEmpleado
{
    public partial class Pagar : Form
    {
        ControladorEmpleado controladorEmpleado;
        DataGridViewRow dataGridViewRow;
        public Pagar(ControladorEmpleado controladorEmpleado, DataGridViewRow dataGridViewRow)
        {
            InitializeComponent();
            this.controladorEmpleado = controladorEmpleado;
            this.dataGridViewRow = dataGridViewRow;
            LblMontoAPagar.Text = dataGridViewRow.Cells[2].Value.ToString();
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            if (TxtMontoPago.Text.Equals("") || TxtMontoPago.Text.Equals(null))
            {
                MessageBox.Show("Debe ingresar el monto a pagar");
            }
            else
            {
                if (LblMontoAPagar.Text.Equals(TxtMontoPago.Text.Trim()))
                {
                    string[] resultado = controladorEmpleado.Pagar(int.Parse(this.dataGridViewRow.Cells[1].Value.ToString()), int.Parse(this.dataGridViewRow.Cells[2].Value.ToString()));
                    MessageBox.Show(resultado[1]);
                }
                else
                {
                    MessageBox.Show("El monto ingresado no coincide con el total a pagar");
                }
            }
        }

        private void Pagar_Load(object sender, EventArgs e)
        {

        }
    }
}
