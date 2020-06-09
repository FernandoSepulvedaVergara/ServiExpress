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

namespace ServiExpress.app_GUI.UsuarioEmpleado.ReservarsDehora
{
    public partial class VerAtención : Form
    {
        ControladorEmpleado controladorEmpleado;
        DataGridViewRow dataGridViewRow;
        public VerAtención(ControladorEmpleado controladorEmpleado, DataGridViewRow dataGridViewRow)
        {
            this.controladorEmpleado = controladorEmpleado;
            this.dataGridViewRow = dataGridViewRow;
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void VerAtención_Load(object sender, EventArgs e)
        {
            atencion verAtencion = controladorEmpleado.GetAtencion(int.Parse(dataGridViewRow.Cells[5].Value.ToString()));

            TxtIdAtencion.Text = verAtencion.id_atencion.ToString();
            TxtEstadoDeAtencion.Text = verAtencion.estado_de_atencion.estado;
            TxtIdReservaDeAtencion.Text = verAtencion.id_reserva.ToString();
            TxtRutCliente.Text = dataGridViewRow.Cells[3].Value.ToString();
            TxtFechaAtencion.Text = verAtencion.fecha_atencion;
            TxtHoraAtencion.Text = verAtencion.hora_atencion;
            TxtServicioRealizado.Text = verAtencion.tipo_de_servicio.servicio;
        }
    }
}
