using ServiExpress.app_GUI.Usuario1;
using ServiExpress.controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiExpress.app_GUI
{
    public partial class FormUsuario1 : Form
    {
        private ControladorCliente controladorCliente;
        public FormUsuario1(string[] login)
        {
            InitializeComponent();
            this.controladorCliente = new ControladorCliente(login);
            controladorCliente.GetInfo();
            controladorCliente.GetServicios();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void FormUsuario1_Load(object sender, EventArgs e)
        {
        
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnReservaAtencion_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2.Controls.Count >0) 
            {
                splitContainer1.Panel2.Controls.Clear();
            }
            ReservaDeAtencion reservaDeAtencion = new ReservaDeAtencion();
            reservaDeAtencion.TopLevel = false;
            reservaDeAtencion.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(reservaDeAtencion);            
            reservaDeAtencion.Show();
        }
    }
}
