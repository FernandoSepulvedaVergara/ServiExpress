using ServiExpress.app_GUI.UsuarioAdministrador;
using ServiExpress.controlador;
using System;
using System.Windows.Forms;

namespace ServiExpress.app_GUI
{
    public partial class Administrador : Form
    {
        ControladorAdministrador controladorAdministrador;
        
        public Administrador(string[] login)
        {
            InitializeComponent();
            this.controladorAdministrador = new ControladorAdministrador(login);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAdministrarProducto_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2.Controls.Count > 0)
            {
                splitContainer1.Panel2.Controls.Clear();
            }
            AdministrarProductos administrarProductos = new AdministrarProductos(controladorAdministrador);
            administrarProductos.TopLevel = false;
            administrarProductos.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(administrarProductos);
            administrarProductos.Show();
        }

        private void BtnPedidos_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2.Controls.Count > 0)
            {
                splitContainer1.Panel2.Controls.Clear();
            }
            Pedidos pedidos = new Pedidos(controladorAdministrador);
            pedidos.TopLevel = false;
            pedidos.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(pedidos);
            pedidos.Show();
        }

        private void FormUsuario4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnAdministrarUsuarios_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2.Controls.Count > 0)
            {
                splitContainer1.Panel2.Controls.Clear();
            }
            AdministrarUsuarios administrarUsuarios = new AdministrarUsuarios(controladorAdministrador);
            administrarUsuarios.TopLevel = false;
            administrarUsuarios.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(administrarUsuarios);
            administrarUsuarios.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2.Controls.Count > 0)
            {
                splitContainer1.Panel2.Controls.Clear();
            }
            Info info = new Info(controladorAdministrador);
            info.TopLevel = false;
            info.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(info);
            info.Show();
        }

        private void BtnAdministrarProveedores_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2.Controls.Count > 0)
            {
                splitContainer1.Panel2.Controls.Clear();
            }
            AdministrarProveedores administrarProveedores = new AdministrarProveedores(controladorAdministrador);
            administrarProveedores.TopLevel = false;
            administrarProveedores.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(administrarProveedores);
            administrarProveedores.Show();
        }

        private void BtnAdministrarSucursales_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2.Controls.Count > 0)
            {
                splitContainer1.Panel2.Controls.Clear();
            }
            AdministrarSucursales administrarSucursales = new AdministrarSucursales(controladorAdministrador);
            administrarSucursales.TopLevel = false;
            administrarSucursales.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(administrarSucursales);
            administrarSucursales.Show();
        }
    }
}
