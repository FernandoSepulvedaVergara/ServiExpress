using ServiExpress.app_GUI.Usuario1;
using ServiExpress.app_GUI.UsuarioCliente;
using ServiExpress.app_GUI.UsuarioEmpleado;
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
            ReservaDeAtencion1 reservaDeAtencion = new ReservaDeAtencion1(controladorCliente);
            reservaDeAtencion.TopLevel = false;
            reservaDeAtencion.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(reservaDeAtencion);
            try { reservaDeAtencion.Show(); }
            catch 
            {
                this.BtnVehículos.Click += new System.EventHandler(this.BtnVehículos_Click);
            }
        }

        private void BtnVehículos_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2.Controls.Count > 0)
            {
                splitContainer1.Panel2.Controls.Clear();
            }
            VehiculosCliente vehiculosCliente = new VehiculosCliente(controladorCliente);
            vehiculosCliente.TopLevel = false;
            vehiculosCliente.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(vehiculosCliente);
            vehiculosCliente.Show();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGlosarioPago_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2.Controls.Count > 0)
            {
                splitContainer1.Panel2.Controls.Clear();
            }
            GlosarioDePagos glosarioDePagos = new GlosarioDePagos(controladorCliente);
            glosarioDePagos.TopLevel = false;
            glosarioDePagos.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(glosarioDePagos);
            glosarioDePagos.Show();
        }

        private void BtnDatosPersonales_Click(object sender, EventArgs e)
        {

        }

        private void BtnReservaciones_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2.Controls.Count > 0)
            {
                splitContainer1.Panel2.Controls.Clear();
            }
            Reservaciones reservaciones = new Reservaciones(controladorCliente);
            reservaciones.TopLevel = false;
            reservaciones.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(reservaciones);
            reservaciones.Show();
        }
    }
}
