using ServiExpress.controlador;
using ServiExpress.WebServiceEmpleado;
using System;
using System.Windows.Forms;

namespace ServiExpress.app_GUI.UsuarioEmpleado.ReservarsDehora
{
    public partial class RealizarReservaDeAtencion : Form
    {
        ControladorEmpleado controladorEmpleado;
        DataGridViewRow dataGridViewRow;
        public RealizarReservaDeAtencion(ControladorEmpleado controladorEmpleado, DataGridViewRow dataGridViewRow)
        {
            this.controladorEmpleado = controladorEmpleado;
            this.dataGridViewRow = dataGridViewRow;
            InitializeComponent();
        }

        private void RealizarReservaDeAtencion_Load(object sender, EventArgs e)
        {
            tipoDeServicio[] tipoDeServicios = controladorEmpleado.GetTipoDeServicios();
            if (tipoDeServicios != null) 
            {
                foreach (var objeto in tipoDeServicios) 
                {
                    CmbTipoDeServicios.Items.Add(string.Format("{0} - {1}",objeto.id_servicio,objeto.servicio));
                }
            }
            string fechaActual = DateTime.Now.ToString();
            TxtFechaAtencion.Text = fechaActual.Substring(0,8);
            TxtHoraAtencion.Text = fechaActual.Substring(9, 5);
            TxtIdReservaDeAtencion.Text = this.dataGridViewRow.Cells[5].Value.ToString();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnRegistrarAtencion_Click(object sender, EventArgs e)
        {
            if (true) {
                if (CmbTipoDeServicios.SelectedItem != null)
                {

                    int servicioRealizado = int.Parse(CmbTipoDeServicios.SelectedItem.ToString().Substring(0, CmbTipoDeServicios.SelectedItem.ToString().IndexOf("-")).Trim());
                    string[] resultado = controladorEmpleado.RegistrarAtencion(TxtFechaAtencion.Text, TxtHoraAtencion.Text, servicioRealizado, int.Parse(this.dataGridViewRow.Cells[5].Value.ToString()), 1);
                    MessageBox.Show(string.Format("{0}", resultado[1]));
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Seleccione el servicio realizado");
                } 
            }
        }

        private void BtnCancelarAtencion_Click(object sender, EventArgs e)
        {
            if (CmbTipoDeServicios.SelectedItem != null)
            {
                int servicioRealizado = int.Parse(CmbTipoDeServicios.SelectedItem.ToString().Substring(0, CmbTipoDeServicios.SelectedItem.ToString().IndexOf("-")).Trim());
                string[] resultado = controladorEmpleado.RegistrarAtencion(TxtFechaAtencion.Text, TxtHoraAtencion.Text, servicioRealizado, int.Parse(this.dataGridViewRow.Cells[5].Value.ToString()), 3);

                MessageBox.Show(string.Format("{0}", resultado[1]));
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione el servicio realizado");
            }
        }
    }
}
