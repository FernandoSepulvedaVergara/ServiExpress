using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiExpress.app_GUI.Usuario1
{
    public partial class ReservaDeAtencion : Form
    {
        public ReservaDeAtencion()
        {
            InitializeComponent();
        }

        private void ReservaDeAtencion_Load(object sender, EventArgs e)
        {
            DateTime localdate = DateTime.Now;
            this.monthCalendar.MinDate = localdate;
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            string fecha = monthCalendar.SelectionStart.Date.ToString().Substring(0, 8);
        }
    }
}
