using ServiExpress.controlador;
using ServiExpress.WebServiceEmpleado;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ServiExpress.app_GUI.UsuarioEmpleado.ReservarsDehora
{
    public partial class RealizarRegistroDeAtencion : Form
    {
        ControladorEmpleado controladorEmpleado;
        DataGridViewRow dataGridViewRow;
        producto[] productos;

        public RealizarRegistroDeAtencion(ControladorEmpleado controladorEmpleado, DataGridViewRow dataGridViewRow)
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
                    CmbTipoDeServicios.Items.Add(string.Format("{0} - {1}", objeto.id_servicio, objeto.servicio));
                }
            }
            string fechaActual = DateTime.Now.ToString();
            TxtFechaAtencion.Text = fechaActual.Substring(0, 8);
            TxtHoraAtencion.Text = fechaActual.Substring(9, 5);
            TxtIdReservaDeAtencion.Text = this.dataGridViewRow.Cells[5].Value.ToString();
            TxtRutCliente.Text = this.dataGridViewRow.Cells[3].Value.ToString();

            tipoDeProducto[] tipoDeProductos = controladorEmpleado.GetTipoDeProducto();
            if (tipoDeProductos != null)
            {
                foreach (var objeto in tipoDeProductos)
                {
                    CmbTipoDeProducto.Items.Add(string.Format("{0} - {1}", objeto.idTipoDeProducto, objeto.producto));
                }
            }

            tipoDeDocumento[] tipoDeDocumento = controladorEmpleado.GetTipoDeDocumento();
            if (tipoDeDocumento != null)
            {
                foreach (var objeto in tipoDeDocumento)
                {
                    CmbTipoDeDocumento.Items.Add(string.Format("{0} - {1}", objeto.id_tipo_de_documento, objeto.documento));
                }
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnRegistrarAtencion_Click(object sender, EventArgs e)
        {
            bool resultadoRegistro = false;
            if (CmbTipoDeServicios.SelectedItem != null)
            {
                int servicioRealizado = int.Parse(CmbTipoDeServicios.SelectedItem.ToString().Substring(0, CmbTipoDeServicios.SelectedItem.ToString().IndexOf("-")).Trim());
                if (DgvProductos.Rows.Count != 0)
                {
                    if (CmbTipoDeDocumento.SelectedItem !=null) {
                        string[] registroAtencion = controladorEmpleado.RegistrarAtencion(TxtFechaAtencion.Text, TxtHoraAtencion.Text, servicioRealizado, int.Parse(this.dataGridViewRow.Cells[5].Value.ToString()), 1);
                        int idDocumento = int.Parse(CmbTipoDeDocumento.SelectedItem.ToString().Substring(0, CmbTipoDeDocumento.SelectedItem.ToString().IndexOf("-")).Trim());
                        if (registroAtencion[0] != "False")
                        {
                            string[] registroVenta = controladorEmpleado.RegistrarVenta(int.Parse(registroAtencion[2]), 0, int.Parse(LblMontoTotal.Text), 0, TxtFechaAtencion.Text, 1, TxtRutCliente.Text, idDocumento);
                            if (registroVenta[0] != "False")
                            {
                                foreach (DataGridViewRow dataGridViewRow in DgvProductos.Rows) 
                                {
                                    try
                                    {
                                        int montoAPagar = int.Parse(dataGridViewRow.Cells[4].Value.ToString()) * int.Parse(dataGridViewRow.Cells[6].Value.ToString());
                                        string[] actualizciónProductos = controladorEmpleado.ActualizarProductos(int.Parse(registroVenta[2]), 0, int.Parse(dataGridViewRow.Cells[6].Value.ToString()), montoAPagar, int.Parse(dataGridViewRow.Cells[0].Value.ToString()));
                                        resultadoRegistro = true;
                                    }
                                    catch 
                                    {
                                        resultadoRegistro = false;
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show(string.Format("{0} \n {1}", registroVenta[1], registroVenta[2]));
                            }
                        }
                        else
                        {
                            MessageBox.Show(string.Format("{0} \n {1}", registroAtencion[1], registroAtencion[2]));
                        }
                    }
                    else 
                    {
                        MessageBox.Show("Seleeccionar tipo de documento");
                    }
                }
                else 
                {
                    string[] resultado = controladorEmpleado.RegistrarAtencion(TxtFechaAtencion.Text, TxtHoraAtencion.Text, servicioRealizado, int.Parse(this.dataGridViewRow.Cells[5].Value.ToString()), 1);
                    MessageBox.Show(string.Format("{0}", resultado[1]));
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Seleccione el servicio realizado");
            }

            if (resultadoRegistro != false)
            {
                MessageBox.Show("Registro guardado con éxito");
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

        private void CmbTipoDeProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbProductos.Items.Clear();
            int idTipoDeProducto = int.Parse(CmbTipoDeProducto.SelectedItem.ToString().Substring(0, CmbTipoDeProducto.SelectedItem.ToString().IndexOf("-")).Trim());
            producto[] productos = controladorEmpleado.GetProductos(idTipoDeProducto);

            if (productos != null)
            {
                foreach (var objeto in productos)
                {
                    CmbProductos.Items.Add(string.Format("{0} - {1}", objeto.idProducto, objeto.descripcion));
                }
                this.productos = productos;
            }
        }

        private void CmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridViewRow dataGridViewRow = new DataGridViewRow();
            int idProducto = int.Parse(CmbProductos.SelectedItem.ToString().Substring(0, CmbProductos.SelectedItem.ToString().IndexOf("-")).Trim());
            dataGridViewRow.CreateCells(DgvProductos);
            if (DgvProductos.Rows.Count == 0)
            {
                foreach (var objeto in this.productos)
                {
                    if (objeto.idProducto == idProducto)
                    {
                        dataGridViewRow.Cells[0].Value = objeto.idProducto;
                        dataGridViewRow.Cells[1].Value = objeto.descripcion;
                        dataGridViewRow.Cells[2].Value = objeto.marca;
                        dataGridViewRow.Cells[3].Value = objeto.fechaVencimiento;
                        dataGridViewRow.Cells[4].Value = objeto.precioVenta;
                        dataGridViewRow.Cells[5].Value = objeto.stock;
                        dataGridViewRow.Cells[6].Value = 0;
                        DgvProductos.Rows.Add(dataGridViewRow);
                        break;
                    }
                }
            }
            else
            {
                bool validarProductoAgregado = false;
                foreach (DataGridViewRow objecto in DgvProductos.Rows)
                {
                    if (objecto.Cells[0].Value.Equals(idProducto))
                    {
                        validarProductoAgregado = true;
                        break;
                    }
                    else
                    {
                        validarProductoAgregado = false;
                    }
                }

                if (validarProductoAgregado != true)
                {
                    foreach (var objeto in this.productos)
                    {
                        if (objeto.idProducto == idProducto)
                        {
                            dataGridViewRow.Cells[0].Value = objeto.idProducto;
                            dataGridViewRow.Cells[1].Value = objeto.descripcion;
                            dataGridViewRow.Cells[2].Value = objeto.marca;
                            dataGridViewRow.Cells[3].Value = objeto.fechaVencimiento;
                            dataGridViewRow.Cells[4].Value = objeto.precioVenta;
                            dataGridViewRow.Cells[5].Value = objeto.stock;
                            dataGridViewRow.Cells[6].Value = 0;
                            DgvProductos.Rows.Add(dataGridViewRow);
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Producto ya esta agregado");
                }
            }
            ActualizarListaDeProductos(DgvProductos);
        }

        private void ActualizarListaDeProductos(DataGridView dgv)
        {
            int montoTotal = 0;
            foreach (DataGridViewRow fila in dgv.Rows)
            {
                montoTotal = montoTotal + (int.Parse(fila.Cells[4].Value.ToString()) * int.Parse(fila.Cells[6].Value.ToString()));
            }
            LblMontoTotal.Text = montoTotal.ToString();
        }

        private void BtnQuitarProducto_Click(object sender, EventArgs e)
        {
            if (DgvProductos.Rows.Count != 0)
            {
                int indiceRow = DgvProductos.CurrentRow.Index;
                DgvProductos.Rows.RemoveAt(indiceRow);
                ActualizarListaDeProductos(DgvProductos);
            }
        }

        private void DgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvProductos.Rows[DgvProductos.CurrentRow.Index].Cells[6].ColumnIndex.Equals(e.ColumnIndex))
            {
                int cantidadActual = Convert.ToInt32(DgvProductos.CurrentRow.Cells[6].Value);
                int stock = Convert.ToInt32(DgvProductos.CurrentRow.Cells[5].Value);
                int precioUnitario = Convert.ToInt32(DgvProductos.CurrentRow.Cells[4].Value);
                SeleccionarCantidad seleccionarCantidad = new SeleccionarCantidad(cantidadActual, stock, precioUnitario);
                seleccionarCantidad.ShowDialog();
                DgvProductos.CurrentRow.Cells[6].Value = seleccionarCantidad.cantidad;
                ActualizarListaDeProductos(DgvProductos);
            }
        }
    }
}
