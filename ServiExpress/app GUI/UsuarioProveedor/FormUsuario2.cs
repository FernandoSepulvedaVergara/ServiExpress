using ServiExpress.app_GUI.UsuarioAdministrador;
using ServiExpress.app_GUI.UsuarioProveedor;
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
using AdministrarProductos = ServiExpress.app_GUI.UsuarioProveedor.AdministrarProductos;

namespace ServiExpress.app_GUI
{
    public partial class FormUsuario2 : Form
    {
        private ControladorProveedor controladorProveedor;
        public FormUsuario2(string[] login)
        {
            InitializeComponent();
            this.controladorProveedor = new ControladorProveedor(login);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormUsuario2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnAdministrarProducto_Click(object sender, EventArgs e)
        {
            if (splitContainer2.Panel2.Controls.Count > 0)
            {
                splitContainer2.Panel2.Controls.Clear();
            }
            AdministrarProductos administrarProductos = new AdministrarProductos(controladorProveedor);
            administrarProductos.TopLevel = false;
            administrarProductos.Dock = DockStyle.Fill;
            splitContainer2.Panel2.Controls.Add(administrarProductos);
            administrarProductos.Show();
        }
    }
}
