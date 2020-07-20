using ServiExpress.controlador;
using ServiExpress.WebServiceProveedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiExpress.app_GUI.UsuarioProveedor
{
    public partial class Info : Form
    {
        ControladorProveedor controladoProveedor;
        public Info(ControladorProveedor controladoProveedor)
        {
            this.controladoProveedor = controladoProveedor;
            InitializeComponent();
        }

        private void BtnActualizarCancelar_Click(object sender, EventArgs e)
        {
            if (BtnActualizarCancelar.Text.Equals("Actualizar datos"))
            {
                TxtContraseña.PasswordChar = '\0';
                BtnActualizarCancelar.Text = "Cancelar";
                HabilitarDeshabilitarEdicion(true);
                BtnGuardarDatos.Visible = true;

            }
            else if (BtnActualizarCancelar.Text.Equals("Cancelar"))
            {
                TxtContraseña.PasswordChar = '*';
                BtnActualizarCancelar.Text = "Actualizar datos";
                HabilitarDeshabilitarEdicion(false);
                BtnGuardarDatos.Visible = false;
                GetInfoUsuarioProveedor();
            }
        }

        private void GetInfoUsuarioProveedor()
        {
            proveedor resultado = controladoProveedor.GetInfoUsuarioProveedor();
            if (resultado != null)
            {
                TxtRutProveedor.Text = resultado.rutProveedor;
                TxtRazonSocial.Text = resultado.razonSocial;
                TxtTelefono.Text = resultado.telefono.ToString();
                TxtEmail.Text = resultado.email;
                TxtTipoDeUsuario.Text = resultado.tipoDeUsuario.tipoDeUsuario1;
                TxtNombreUsuario.Text = resultado.nombreUsuario;
                TxtContraseña.Text = resultado.contraseña;

            }
            else
            {
                MessageBox.Show("Error al cargar los datos");
                this.Dispose();
            }
        }

        private void HabilitarDeshabilitarEdicion(bool opcion)
        {
            if (opcion.Equals(true))
            {
                TxtRazonSocial.Enabled = opcion;
                TxtTelefono.Enabled = opcion;
                TxtEmail.Enabled = opcion;
                TxtNombreUsuario.Enabled = opcion;
                TxtContraseña.Enabled = opcion;
            }
            else if (opcion.Equals(false))
            {
                TxtRazonSocial.Enabled = opcion;
                TxtTelefono.Enabled = opcion;
                TxtEmail.Enabled = opcion;
                TxtNombreUsuario.Enabled = opcion;
                TxtContraseña.Enabled = opcion;
            }
        }

        private void Info_Load(object sender, EventArgs e)
        {
            GetInfoUsuarioProveedor();
        }

        private void BtnGuardarDatos_Click(object sender, EventArgs e)
        {
            if (TxtRazonSocial.Text.Equals(string.Empty) || TxtTelefono.Text.Equals(string.Empty) || TxtEmail.Text.Equals(string.Empty) || TxtNombreUsuario.Text.Equals(string.Empty) || TxtContraseña.Text.Equals(string.Empty))
            {
                MessageBox.Show("Faltan datos por ingresar");
            }
            else
            {
                if (ValidacionEntradas.ValidarEmail(TxtEmail)) {
                    proveedor actualizarUsuarioProveedor = new proveedor();
                    actualizarUsuarioProveedor.rutProveedor = TxtRutProveedor.Text;
                    actualizarUsuarioProveedor.razonSocial = TxtRazonSocial.Text;
                    actualizarUsuarioProveedor.telefono = int.Parse(TxtTelefono.Text);
                    actualizarUsuarioProveedor.email = TxtEmail.Text;
                    actualizarUsuarioProveedor.nombreUsuario = TxtNombreUsuario.Text;
                    actualizarUsuarioProveedor.contraseña = TxtContraseña.Text;
                    try
                    {
                        DialogResult dialogResult = MessageBox.Show("¿Actualizar datos?", "Actualización de datos", MessageBoxButtons.YesNo);

                        if (dialogResult.Equals(DialogResult.Yes))
                        {
                            string[] resultado = controladoProveedor.ActualizarUsuarioProveedor(actualizarUsuarioProveedor);
                            if (bool.Parse(resultado[0]))
                            {
                                MessageBox.Show(resultado[1]);
                                BtnActualizarCancelar.Text = "Actualizar datos";
                                HabilitarDeshabilitarEdicion(false);
                                BtnGuardarDatos.Visible = false;
                                ControladorLoginUsuario controladorLoginUsuario = new ControladorLoginUsuario();
                                string[] login = controladorLoginUsuario.ValidarUsuarioProveedor(actualizarUsuarioProveedor.nombreUsuario, actualizarUsuarioProveedor.contraseña);
                                controladoProveedor.login = login;
                                GetInfoUsuarioProveedor();

                            }
                            else if (bool.Parse(resultado[0]).Equals(false))
                            {
                                MessageBox.Show(resultado[1]);
                            }
                            else
                            {
                                MessageBox.Show("Actualización de usuario no devolvió true ni false", "Error inesperado");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar datos \n" + ex.Message);
                    }
                }
                else {
                    MessageBox.Show("El email es incorrecto");
                }
            }
        }

        private void TxtNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionEntradas.NombreUsuarioContraseña(e);
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionEntradas.ValidarNumeros(e);
        }

        private void TxtRazonSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionEntradas.ValidarRazonSocial(e);
        }
    }
}
