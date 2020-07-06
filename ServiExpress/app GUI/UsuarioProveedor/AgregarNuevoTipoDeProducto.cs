using ServiExpress.controlador;
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
    public partial class AgregarNuevoTipoDeProducto : Form
    {
        ControladorProveedor controladorProveedor;
        public AgregarNuevoTipoDeProducto(ControladorProveedor controladorProveedor)
        {
            this.controladorProveedor = controladorProveedor;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] resultado = controladorProveedor.AgregarNuevoTipoDeProducto(TxtNuevoTipoDeProducto.Text);
            MessageBox.Show(string.Format("{0}",resultado[1]));
        }
    }
}
