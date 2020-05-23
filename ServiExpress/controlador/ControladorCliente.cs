using ServiExpress.WebServiceCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ServiExpress.controlador
{
    public class ControladorCliente : ControladorPrincipal
    {
        public string[] login { get; set; }
        WebServiceClienteClient webCliente = new WebServiceClienteClient();

        public ControladorCliente(string[] login)
        {
            this.login = login;
        }

        public override string[] GetInfo()
        {
            string[] resultado = webCliente.GetInfoCliente(login[0]);
            return resultado;
        }

        public override DataGridView SetDataGridView(DataGridView Dgv)
        {
            if (Dgv.Name.Equals("DgvVehiculosCliente"))
            {
                vehiculo[] resultado = GetVehiculos();
                List<string> listaTemporal = new List<string>();

                if (resultado != null)
                {
                    foreach (var r in resultado)
                    {
                        listaTemporal.Add(r.patente);
                        listaTemporal.Add(r.tipoDeVehiculo.tipo_de_vehiculo);
                        listaTemporal.Add(r.numero_motor.ToString());
                        listaTemporal.Add(r.numero_chasis);

                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(Dgv);
                        for (int i = 0; i < listaTemporal.Count; i++)
                        {
                            fila.Cells[i].Value = listaTemporal[i].ToString();
                        }
                        Dgv.Rows.Add(fila);
                        listaTemporal.Clear();
                    }
                }
                return Dgv;
            }
            else if (Dgv.Name.Equals("DgvVentas"))
            {
                ventas[] resultado = GetVentas();
                List<string> listaTemporal = new List<string>();

                if (resultado != null)
                {
                    foreach (var r in resultado)
                    {
                        listaTemporal.Add(r.id_venta.ToString());
                        listaTemporal.Add(r.montoAPagar.ToString());
                        listaTemporal.Add(r.montoPagado.ToString());
                        listaTemporal.Add(r.fecha);
                        listaTemporal.Add(r.estadoDeVenta.estado);
                        listaTemporal.Add(r.idAtencion.ToString());

                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(Dgv);
                        for (int i = 0; i < listaTemporal.Count; i++)
                        {
                            fila.Cells[i].Value = listaTemporal[i].ToString();
                        }
                        Dgv.Rows.Add(fila);
                        listaTemporal.Clear();
                    }
                }
                return Dgv;
            }
            return Dgv;            
        }

        public tipoDeServicio[] GetTipoDeServicios()
        {
            tipoDeServicio[] resultado = webCliente.GetTipoDeServicios();
            return resultado;
        }

        public tipoDeVehiculo[] GetTipoVehiculos()
        {
            tipoDeVehiculo[] resultado = webCliente.GetTipoDeVehiculo();
            return resultado;
        }

        public vehiculo[] GetVehiculos()
        {
            vehiculo[] resultado = webCliente.GetVehiculos(this.login[0]);
            if (resultado != null) {
                return resultado;
            }
            else 
            {
                return null;
            }
        }

        public sucursal[] GetSucursales()
        {
            sucursal[] resultado = webCliente.GetSucursales();
            return resultado;
        }

        public ventas[] GetVentas()
        {
            ventas[] resultado = webCliente.GetVentas(login[0]);
            return resultado;
        }

        public string[] RegistrarReservaDeAtencion(string fecha_reserva,string hora_reserva, int id_sucursal, string rut, int id_tipo_de_servicio, string patente) 
        {
            string[] resultado = webCliente.RegistrarReservaDeAtencion(fecha_reserva, hora_reserva,id_sucursal,rut,id_tipo_de_servicio,patente);
            return resultado;
        }

        public string[] RegistrarNuevoVehiculo(string patente, int numeroMotor, string numeroChasis, int idTipoDeVehiculo, string rut)
        {
            string[] resultado = webCliente.IngresarVehiculo(patente, numeroMotor, numeroChasis, idTipoDeVehiculo, rut);
            return resultado;
        }
    }
}
