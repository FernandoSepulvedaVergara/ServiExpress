using ServiExpress.WebServiceCliente;
using ServiExpress.WebServiceEmpleado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tipoDeServicio = ServiExpress.WebServiceEmpleado.tipoDeServicio;

namespace ServiExpress.controlador
{
    public class ControladorEmpleado : ControladorPrincipal
    {
        public string[] login { get; set; }
        WebServiceEmpleadoClient webEmpleado = new WebServiceEmpleadoClient();

        public ControladorEmpleado(string[] login)
        {
            this.login = login;
        }

        public override string[] GetInfo()
        {
            return null;
        }

        public override DataGridView SetDataGridView(DataGridView Dgv)
        {
            return null;
        }

        public DataGridView SetDataGridView(DataGridView Dgv, string id_sucursal, string filtro, string valorFiltro)
        {
            Dgv.Rows.Clear();
            atenciones[] resultado = GetAtenciones(id_sucursal, filtro, valorFiltro);
            List<string> listaTemporal = new List<string>();

            if (resultado != null)
            {
                foreach (var r in resultado)
                {
                    DataGridViewButtonCell dataGridViewButtonCell = new DataGridViewButtonCell();
                    if (r.id_estado == 1)
                    {
                        dataGridViewButtonCell.Value = "Ver atención";
                    }
                    else if (r.id_estado == 3) 
                    {
                        dataGridViewButtonCell.Value = "Cancelado";
                    }
                    else
                    {
                        dataGridViewButtonCell.Value = "Realizar atención";
                    }

                    listaTemporal.Add(r.hora_reserva);
                    listaTemporal.Add(r.fecha_reserva);
                    listaTemporal.Add(r.usuario_rut);
                    listaTemporal.Add(r.patente);
                    listaTemporal.Add(r.id_reserva.ToString());
                    listaTemporal.Add(r.sucursal);

                    DataGridViewRow fila = new DataGridViewRow();
                    fila.CreateCells(Dgv);
                    for (int i = 0; i < listaTemporal.Count + 1; i++)
                    {
                        if (i == 0)
                        {
                            fila.Cells[i] = dataGridViewButtonCell;
                        }
                        else
                        {
                            fila.Cells[i].Value = listaTemporal[i - 1].ToString();
                        }
                    }
                    Dgv.Rows.Add(fila);
                    listaTemporal.Clear();
                }
            }
            return Dgv;
        }

        public atenciones[] GetAtenciones(string id_sucursal, string filtro, string valorFiltro)
        {
            atenciones[] atenciones;
            atenciones = webEmpleado.GetAtenciones(id_sucursal, filtro, valorFiltro);
            return atenciones;
        }

        public tipoDeServicio[] GetTipoDeServicios()
        {
            tipoDeServicio[] resultado = webEmpleado.GetTipoDeServicios();
            return resultado;
        }

        public string[] RegistrarAtencion(string fechaAtencion, string horaAtencion, int idTipoServicio, int idReserva, int idEstadoDeAtencion) 
        {
            string[] resultado = webEmpleado.RegistrarAtencion(fechaAtencion,horaAtencion,idTipoServicio,idReserva,idEstadoDeAtencion);
            return resultado;
        }
    }
}
