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
using Info = ServiExpress.app_GUI.UsuarioProveedor.Info;

namespace ServiExpress.app_GUI
{
    public partial class Proveedor : Form
    {
        private ControladorProveedor controladorProveedor;
        public Proveedor(string[] login)
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (splitContainer2.Panel2.Controls.Count > 0)
            {
                splitContainer2.Panel2.Controls.Clear();
            }
            UsuarioProveedor.Pedidos pedidos = new UsuarioProveedor.Pedidos(controladorProveedor);
            pedidos.TopLevel = false;
            pedidos.Dock = DockStyle.Fill;
            splitContainer2.Panel2.Controls.Add(pedidos);
            pedidos.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (splitContainer2.Panel2.Controls.Count > 0)
            {
                splitContainer2.Panel2.Controls.Clear();
            }
            Info info = new Info(controladorProveedor);
            info.TopLevel = false;
            info.Dock = DockStyle.Fill;
            splitContainer2.Panel2.Controls.Add(info);
            info.Show();
        }
    }
}
