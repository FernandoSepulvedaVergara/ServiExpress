using ServiExpress.controlador;
using ServiExpress.WebServiceAdministrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiExpress.app_GUI.UsuarioAdministrador
{
    public partial class NuevoProveedor : Form
    {
        ControladorAdministrador controladorAdministrador;
        public NuevoProveedor(ControladorAdministrador controladorAdministrador)
        {
            this.controladorAdministrador = controladorAdministrador;
            InitializeComponent();
        }

        private void BtnGuardarNuevoUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtRutProveedor.Text.Equals(string.Empty) || TxtRazonSocial.Text.Equals(string.Empty) || TxtTelefono.Text.Equals(string.Empty) || TxtEmail.Text.Equals(string.Empty) ||
                    TxtNombreUsuario.Text.Equals(string.Empty) || TxtContraseña.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Faltan datos por ingresar");
                }
                else
                {
                    if (ValidacionEntradas.ValidarRut(TxtRutProveedor.Text)) {
                        if (ValidacionEntradas.ValidarEmail(TxtEmail))
                        {
                            proveedor nuevoProveedor = new proveedor();
                            nuevoProveedor.rutProveedor = TxtRutProveedor.Text;
                            nuevoProveedor.razonSocial = TxtRazonSocial.Text;
                            nuevoProveedor.telefono = int.Parse(TxtTelefono.Text);
                            nuevoProveedor.email = TxtEmail.Text;
                            nuevoProveedor.nombreUsuario = TxtNombreUsuario.Text;
                            nuevoProveedor.contraseña = TxtContraseña.Text;
                            tipoDeUsuario tipoDeUsuario = new tipoDeUsuario();
                            tipoDeUsuario.idTipoDeUsuario = 2;
                            nuevoProveedor.tipoDeUsuario = tipoDeUsuario;
                            estadoDeUsuario estadoDeUsuario = new estadoDeUsuario();
                            estadoDeUsuario.idEstadoDeUsuario = 1;
                            nuevoProveedor.estadoDeUsuario = estadoDeUsuario;

                            string[] resultado = controladorAdministrador.RegistrarNuevoProveedor(nuevoProveedor);
                            if (bool.Parse(resultado[0]))
                            {
                                MessageBox.Show(resultado[1]);
                                Limpiar();
                            }
                            else if (bool.Parse(resultado[0]) == false)
                            {
                                MessageBox.Show(resultado[1]);
                            }
                            else
                            {
                                MessageBox.Show("Error, resultado no devolvió true ni false");
                            }
                        }
                        else
                        {
                            MessageBox.Show("El email es incorrecto");
                        }
                    }
                    else {
                        MessageBox.Show("El rut es incorrecto");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de configuración \n" + ex.Message);
            }
        }

        private void Limpiar() {
            TxtRutProveedor.Clear();
            TxtRazonSocial.Clear();
            TxtTelefono.Clear();
            TxtEmail.Clear();
            TxtNombreUsuario.Clear();
            TxtContraseña.Clear();
        }

        private void TxtRazonSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionEntradas.ValidarRazonSocial(e);
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionEntradas.ValidarNumeros(e);
        }

        private void TxtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionEntradas.NombreUsuarioContraseña(e);
        }
    }
}
