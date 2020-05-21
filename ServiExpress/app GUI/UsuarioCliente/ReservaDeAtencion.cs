using Clases.ApiRest;
using ServiExpress.controlador;
using System;
using System.Windows.Forms;

namespace ServiExpress.app_GUI.Usuario1
{
    public partial class ReservaDeAtencion : Form
    {
        ControladorCliente controladorCliente;
        public ReservaDeAtencion(ControladorCliente controladorCliente)
        {
            InitializeComponent();
            this.controladorCliente = controladorCliente;
        }

        private void ReservaDeAtencion_Load(object sender, EventArgs e)
        {
            ConfigurarReservaDeHora();
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            string fechaSeleccionada = monthCalendar.SelectionStart.Date.ToString().Substring(0, 8).Replace("/", "");
            DateTime fechaSeleccionadaDateTime = new DateTime(int.Parse(fechaSeleccionada.Substring(4, 2)), int.Parse(fechaSeleccionada.Substring(2, 2)), int.Parse(fechaSeleccionada.Substring(0, 2)));
            string fechaSeleccionadaLbl = null;
            foreach (var r in monthCalendar.BoldedDates)
            {
                if (r.Date.ToString().Equals(fechaSeleccionadaDateTime.Date.ToString()))
                {
                    MessageBox.Show("No se puede seleccionar fecha por día festivo");
                    fechaSeleccionada = "";
                    LblFechaSeleccionada.Text = null;
                    fechaSeleccionadaLbl = null;
                    break;
                }
                else
                {
                    fechaSeleccionadaLbl = monthCalendar.SelectionStart.Date.ToString().Substring(0, 8);                    
                }
            }
            LblFechaSeleccionada.Text = fechaSeleccionadaLbl;
        }

        private void ConfigurarReservaDeHora()
        {
            MessageBox.Show("Configurando reserva de hora");
            DateTime localdate = DateTime.Now;
            this.monthCalendar.MinDate = localdate;
            CmbSeleccionarHoras.DataSource = Horas.GetHoras();
            try {
                ApiFeriados apiFeriados = new ApiFeriados();
                dynamic respuesta = apiFeriados.Get("https://apis.digital.gob.cl/fl/feriados/2020");
                DateTime[] feriados = new DateTime[respuesta.Count];

                for (int i = 0; i < respuesta.Count; i++)
                {
                    string fechaReplace = respuesta[i].fecha.ToString().Replace("-", "");
                    DateTime feriado = new DateTime(int.Parse(fechaReplace.Substring(0, 4)), int.Parse(fechaReplace.Substring(4, 2)), int.Parse(fechaReplace.Substring(6, 2)));
                    feriados[i] = feriado;
                }
                monthCalendar.BoldedDates = feriados;
                try
                {
                    CmbSeleccionarServicios.Items.Clear();
                    CmbSeleccionarVehículo.Items.Clear();
                    CmbSeleccionarSucursal.Items.Clear();
                    foreach (var r in this.controladorCliente.GetTipoDeServicios())
                    {
                        CmbSeleccionarServicios.Items.Add(String.Format("{0} - {1}", r.id_servicio,r.servicio));
                    }
                    foreach (var r in this.controladorCliente.GetVehiculos())
                    {
                        CmbSeleccionarVehículo.Items.Add(String.Format("{0} - {1}", r.patente, r.tipoDeVehiculo.tipo_de_vehiculo));
                    }
                    foreach (var r in this.controladorCliente.GetSucursales())
                    {
                        CmbSeleccionarSucursal.Items.Add(String.Format("{0} - {1}", r.id_sucursal, r.sucursal1));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de configuración \n" + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error conexión API \n " + ex.Message);
            }

        }        

        private void CmbSeleccionarServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblServicioSeleccionado.Text= CmbSeleccionarServicios.SelectedItem.ToString();
        }

        private void CmbSeleccionarVehículo_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblVehículoSeleccionado.Text = CmbSeleccionarVehículo.SelectedItem.ToString();
        }

        private void CmbSeleccionarHoras_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblHoraSeleccionada.Text = CmbSeleccionarHoras.SelectedItem.ToString();
        }

        private void CmbSeleccionarSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblSucursalSeleccionado.Text = CmbSeleccionarSucursal.SelectedItem.ToString();
        }

        private void BtnReservarAtención_Click(object sender, EventArgs e)
        {
            string fechaSeleccionada = LblFechaSeleccionada.Text;
            string horaSeleccionada = LblHoraSeleccionada.Text;
            string servicioSeleccionado = LblServicioSeleccionado.Text.Substring(0, LblServicioSeleccionado.Text.IndexOf("-")).Trim();
            string vehículoSeleccionado = LblVehículoSeleccionado.Text.Substring(0, LblVehículoSeleccionado.Text.IndexOf("-")).Trim();
            string sucursalIdSeleccionada = LblSucursalSeleccionado.Text.Substring(0, LblSucursalSeleccionado.Text.IndexOf("-")).Trim();

            //controladorCliente.RegistrarReservaDeHora();
        }
    }
}
