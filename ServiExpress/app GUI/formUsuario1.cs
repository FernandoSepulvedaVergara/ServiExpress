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
        public FormUsuario1(string[] login)
        {
            InitializeComponent();
            ControladorCliente controladorCliente = new ControladorCliente(login);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormUsuario1_Load(object sender, EventArgs e)
        {
            DateTime localdate = DateTime.Now;
            this.monthCalendar.MinDate =localdate;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            string fecha = monthCalendar.SelectionStart.Date.ToString().Substring(0,8);            
            
        }
    }
}
