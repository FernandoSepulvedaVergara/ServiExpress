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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
