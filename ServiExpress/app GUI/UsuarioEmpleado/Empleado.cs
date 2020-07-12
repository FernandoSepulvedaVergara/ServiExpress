using ServiExpress.app_GUI.UsuarioEmpleado;
using ServiExpress.controlador;
using ServiExpress.WebServiceEmpleado;
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
    public partial class Empleado : Form
    {
        private ControladorEmpleado controladorEmpleado;
        public Empleado(string[] login)
        {
            InitializeComponent();
            this.controladorEmpleado = new ControladorEmpleado(login);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnReservasDeAtencion_Click(object sender, EventArgs e)
        {
            if (panel1.Controls.Count > 0)
            {
                panel1.Controls.Clear();
            }
            ReservasDeHora reservasDeHora = new ReservasDeHora(controladorEmpleado);
            reservasDeHora.TopLevel = false;
            reservasDeHora.Dock = DockStyle.Fill;
            panel1.Controls.Add(reservasDeHora);
            reservasDeHora.Show();
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            if (panel1.Controls.Count > 0)
            {
                panel1.Controls.Clear();
            }
            Ventas ventas = new Ventas(controladorEmpleado);
            ventas.TopLevel = false;
            ventas.Dock = DockStyle.Fill;
            panel1.Controls.Add(ventas);
            ventas.Show();
        }

        private void FormUsuario3_Load(object sender, EventArgs e)
        {

        }

        private void FormUsuario3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
