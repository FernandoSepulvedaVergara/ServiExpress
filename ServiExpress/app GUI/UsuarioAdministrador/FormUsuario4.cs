using ServiExpress.app_GUI.UsuarioAdministrador;
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

namespace ServiExpress.app_GUI
{
    public partial class FormUsuario4 : Form
    {
        ControladorAdministrador controladorAdministrador;
        
        public FormUsuario4(string[] login)
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
    }
}
