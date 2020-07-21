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
    public partial class AgregarSucursal : Form
    {
        ControladorAdministrador controladorAdministrador;
        public AgregarSucursal(ControladorAdministrador controladorAdministrador)
        {
            this.controladorAdministrador = controladorAdministrador;
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionEntradas.ValidarModelo(e);
        }

        private void BtnGuardarSucursal_Click(object sender, EventArgs e)
        {
            if (TxtSucursal.Text.Equals(string.Empty) || TxtDireccionSucursal.Text.Equals(string.Empty)) {
                MessageBox.Show("Faltan datos por ingresar");
            }
            else {
                DialogResult dialogResult = MessageBox.Show("¿Guardar sucursal?","Agregar sucursal",MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes) {
                    sucursal sucursal = new sucursal();
                    sucursal.sucursal1 = TxtSucursal.Text;
                    sucursal.direccion = TxtDireccionSucursal.Text;

                    string[] resultado = controladorAdministrador.AgregarSucursal(sucursal);

                    if (bool.Parse(resultado[0]))
                    {
                        MessageBox.Show(resultado[1]);
                        this.Close();
                    }
                    else {
                        MessageBox.Show(resultado[1]);
                    }
                }
            }
        }
    }
}
