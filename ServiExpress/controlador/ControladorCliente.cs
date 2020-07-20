using ServiExpress.WebServiceCliente;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ServiExpress.controlador
{
    public class ControladorCliente : ControladorPrincipal
    {
        public string[] login { get; set; }
        private WebServiceClienteClient webCliente = new WebServiceClienteClient();

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
            Dgv.Rows.Clear();
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
                        listaTemporal.Add(r.marca);
                        listaTemporal.Add(r.modelo);
                        listaTemporal.Add(r.año);

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
                ventas[] resultado = GetVentasCliente();
                List<string> listaTemporal = new List<string>();

                if (resultado != null)
                {
                    foreach (var r in resultado)
                    {
                        DataGridViewButtonCell dataGridViewButtonCell = new DataGridViewButtonCell();
                        dataGridViewButtonCell.Value = "Documento";
                        listaTemporal.Add(r.id_venta.ToString());
                        listaTemporal.Add(r.estadoDeVenta.estado);
                        listaTemporal.Add(r.montoAPagar.ToString());
                        listaTemporal.Add(r.montoPagado.ToString());
                        listaTemporal.Add(r.fecha);
                        listaTemporal.Add(r.idAtencion.ToString());

                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(Dgv);
                        for (int i = 0; i <= listaTemporal.Count; i++)
                        {
                            if (i == 6)
                            {
                                fila.Cells[i] = dataGridViewButtonCell;
                            }
                            else
                            {
                                fila.Cells[i].Value = listaTemporal[i].ToString();
                            }
                        }
                        Dgv.Rows.Add(fila);
                        listaTemporal.Clear();
                    }
                }
                return Dgv;
            }

            else if (Dgv.Name.Equals("DgvReservaciones"))
            {
                atenciones[] resultado = GetReservaciones(this.login[0]);
                List<string> listaTemporal = new List<string>();

                if (resultado != null)
                {
                    foreach (var r in resultado)
                    {
                        DataGridViewButtonCell dataGridViewButtonCell = new DataGridViewButtonCell();
                        if (r.id_estado == 1)
                        {
                            dataGridViewButtonCell.Style.ForeColor = Color.Green;
                            dataGridViewButtonCell.Value = "Ver atención";
                        }
                        else if (r.id_estado == 3)
                        {
                            dataGridViewButtonCell.Style.ForeColor = Color.LightBlue;
                            dataGridViewButtonCell.Value = "Cancelado";
                        }
                        else
                        {
                            dataGridViewButtonCell.Style.ForeColor = Color.Red;
                            dataGridViewButtonCell.Value = "No atendido";
                        }

                        listaTemporal.Add(r.hora_reserva);
                        listaTemporal.Add(r.fecha_reserva);
                        listaTemporal.Add(r.usuario_rut);
                        listaTemporal.Add(r.patente);
                        listaTemporal.Add(r.id_reserva.ToString());
                        listaTemporal.Add(r.sucursal);

                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(Dgv);
                        for (int i = 0; i < listaTemporal.Count +1; i++)
                        {
                            if (i == 0)
                            {
                                fila.Cells[i] = dataGridViewButtonCell;
                            }
                            else
                            {
                                fila.Cells[i].Value = listaTemporal[i-1].ToString();
                            }
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

        public ventas[] GetVentasCliente()
        {
            ventas[] resultado = webCliente.GetVentasCliente(login[0]);
            return resultado;
        }

        public string[] RegistrarReservaDeAtencion(string fecha_reserva,string hora_reserva, int id_sucursal, string rut, int id_tipo_de_servicio, string patente) 
        {
            string[] resultado = webCliente.RegistrarReservaDeAtencion(fecha_reserva, hora_reserva,id_sucursal,rut,id_tipo_de_servicio,patente);
            return resultado;
        }

        public string[] RegistrarNuevoVehiculo(string patente, string marca, string modelo, string año, int idTipoDeVehiculo, string rut)
        {
            string[] resultado = webCliente.IngresarVehiculo(patente, marca, modelo, año, idTipoDeVehiculo, rut);
            return resultado;
        }

        public atenciones[] GetReservaciones(string rut) 
        {
            atenciones[] resultado = webCliente.GetReservaciones(rut);
            return resultado;
        }

        public bool?[] ValidarDisponibilidad(string fecha, string hora, string rut) 
        {
            bool?[] resultado = webCliente.ValidarDisponibilidad(fecha, hora, rut);
            return resultado;
        }

        public usuario GetInfoUsuario(string rut)
        {
            return webCliente.GetInfoUsuario(rut);
        }

        public region[] GetRegiones()
        {
            return webCliente.GetRegiones();
        }

        public comuna[] GetComunas(int idRegion)
        {
            return webCliente.GetComunas(idRegion);
        }

        public string[] ActualizarUsuario(usuario actualizarUsuario)
        {
            return webCliente.ActualizarUsuario(actualizarUsuario, this.login[0], this.login[1]);
        }

        public string[] EliminarVehiculo(string patente)
        {
            return webCliente.EliminarVehiculo(patente,this.login[0]);
        }
    }
}
