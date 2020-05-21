using ServiExpress.WebServiceCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public override DataGridView SetDataGridView(DataGridView DgvVehiculosCliente)
        {
            vehiculo[] resultado = GetVehiculos();
            List<string> listaTemporal = new List<string>();

            foreach (var r in resultado)
            {
                listaTemporal.Add(r.patente);
                listaTemporal.Add(r.tipoDeVehiculo.tipo_de_vehiculo);
                listaTemporal.Add(r.numero_motor.ToString());
                listaTemporal.Add(r.numero_chasis);

                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(DgvVehiculosCliente);
                for (int i = 0; i < listaTemporal.Count; i++)
                {
                    fila.Cells[i].Value = listaTemporal[i].ToString();
                }
                DgvVehiculosCliente.Rows.Add(fila);
                listaTemporal.Clear();
            }
            return DgvVehiculosCliente;
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
            if (resultado.Equals(null)) {
                return null;
            }
            else 
            {
                return resultado;
            }
        }

        public sucursal[] GetSucursales()
        {
            sucursal[] resultado = webCliente.GetSucursales();
            return resultado;
        }

        public string[] RegistrarReservaDeHora() 
        {
            //string[] resultado = webCliente.RegistrarReservaDeHora();
            return null;
        }
    }
}
