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

namespace ServiExpress.app_GUI.UsuarioEmpleado
{
    public partial class Info : Form
    {
        ControladorEmpleado controladorEmpleado;
        public Info(ControladorEmpleado controladorEmpleado)
        {
            this.controladorEmpleado = controladorEmpleado;
            InitializeComponent();
        }

        private void Info_Load(object sender, EventArgs e)
        {
            GetInfoUsuario();
        }

        private void GetInfoUsuario()
        {
            usuario resultado = controladorEmpleado.GetInfoUsuario(this.controladorEmpleado.login[0]);
            if (resultado != null)
            {
                TxtRut.Text = resultado.rut;
                TxtPrimerNombre.Text = resultado.primerNombre;
                TxtSegundoNombre.Text = resultado.segundoNombre;
                TxtApellidoPaterno.Text = resultado.apellidoPaterno;
                TxtApellidoMaterno.Text = resultado.apellidoMaterno;
                TxtTelefono.Text = resultado.telefono.ToString();
                TxtEmail.Text = resultado.email;
                TxtDireccion.Text = resultado.direccion;
                TxtNombreUsuario.Text = resultado.nombreUsuario;
                TxtContraseña.Text = resultado.contraseña;
                TxtComuna.Text = resultado.comuna.comuna1;
                TxtRegion.Text = resultado.region.region1;
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
                TxtPrimerNombre.Enabled = opcion;
                TxtSegundoNombre.Enabled = opcion;
                TxtApellidoPaterno.Enabled = opcion;
                TxtApellidoMaterno.Enabled = opcion;
                TxtTelefono.Enabled = opcion;
                TxtEmail.Enabled = opcion;
                TxtDireccion.Enabled = opcion;
                TxtContraseña.Enabled = opcion;
                TxtNombreUsuario.Enabled = opcion;
                CmbComuna.Visible = opcion;
                CmbRegion.Visible = opcion;
            }
            else if (opcion.Equals(false))
            {
                TxtPrimerNombre.Enabled = opcion;
                TxtSegundoNombre.Enabled = opcion;
                TxtApellidoPaterno.Enabled = opcion;
                TxtApellidoMaterno.Enabled = opcion;
                TxtTelefono.Enabled = opcion;
                TxtEmail.Enabled = opcion;
                TxtDireccion.Enabled = opcion;
                TxtComuna.Enabled = opcion;
                TxtRegion.Enabled = opcion;
                TxtContraseña.Enabled = opcion;
                TxtNombreUsuario.Enabled = opcion;
                CmbComuna.Visible = opcion;
                CmbRegion.Visible = opcion;
            }
        }

        private void BtnActualizarCancelar_Click(object sender, EventArgs e)
        {
            if (BtnActualizarCancelar.Text.Equals("Actualizar datos"))
            {
                CmbComuna.Items.Clear();
                region[] regiones = controladorEmpleado.GetRegiones();
                CmbRegion.Items.Clear();
                foreach (region region in regiones)
                {
                    CmbRegion.Items.Add(string.Format("{0} - {1}", region.idRegion, region.region1));
                }
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
                GetInfoUsuario();
            }
        }

        private void CmbRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idRegion = int.Parse(CmbRegion.SelectedItem.ToString().Substring(0, CmbRegion.SelectedItem.ToString().IndexOf("-")).Trim());
            comuna[] comunas = controladorEmpleado.GetComunas(idRegion);
            CmbComuna.Items.Clear();
            foreach (comuna comuna in comunas)
            {
                CmbComuna.Items.Add(string.Format("{0} - {1}", comuna.idComuna, comuna.comuna1));
            }
        }

        private void BtnGuardarDatos_Click(object sender, EventArgs e)
        {
            if (TxtPrimerNombre.Text.Equals(string.Empty) || TxtSegundoNombre.Text.Equals(string.Empty) || TxtApellidoPaterno.Text.Equals(string.Empty) || TxtApellidoMaterno.Text.Equals(string.Empty) || TxtEmail.Text.Equals(string.Empty) ||
                TxtTelefono.Text.Equals(string.Empty) || TxtDireccion.Text.Equals(string.Empty) || CmbComuna.SelectedItem == null || CmbRegion.SelectedItem == null || TxtNombreUsuario.Text.Equals(string.Empty) || TxtContraseña.Text.Equals(string.Empty))
            {
                MessageBox.Show("Faltan datos por ingresar");
            }
            else
            {
                int idComuna = int.Parse(CmbComuna.SelectedItem.ToString().Substring(0, CmbComuna.SelectedItem.ToString().IndexOf("-")).Trim());
                usuario actualizarUsuario = new usuario();
                actualizarUsuario.primerNombre = TxtPrimerNombre.Text;
                actualizarUsuario.segundoNombre = TxtSegundoNombre.Text;
                actualizarUsuario.apellidoPaterno = TxtApellidoPaterno.Text;
                actualizarUsuario.apellidoMaterno = TxtApellidoMaterno.Text;
                actualizarUsuario.telefono = int.Parse(TxtTelefono.Text);
                actualizarUsuario.email = TxtEmail.Text;
                actualizarUsuario.direccion = TxtDireccion.Text;
                actualizarUsuario.nombreUsuario = TxtNombreUsuario.Text;
                actualizarUsuario.contraseña = TxtContraseña.Text;
                comuna comuna = new comuna();
                comuna.idComuna = idComuna;
                actualizarUsuario.comuna = comuna;

                try
                {
                    DialogResult dialogResult = MessageBox.Show("¿Actualizar datos?", "Actualización de datos", MessageBoxButtons.YesNo);

                    if (dialogResult.Equals(DialogResult.Yes))
                    {
                        string[] resultado = controladorEmpleado.ActualizarUsuario(actualizarUsuario);
                        if (bool.Parse(resultado[0]))
                        {
                            MessageBox.Show(resultado[1]);
                            BtnActualizarCancelar.Text = "Actualizar datos";
                            HabilitarDeshabilitarEdicion(false);
                            BtnGuardarDatos.Visible = false;
                            ControladorLoginUsuario controladorLoginUsuario = new ControladorLoginUsuario();
                            string[] login = controladorLoginUsuario.ValidarUsuario(actualizarUsuario.nombreUsuario, actualizarUsuario.contraseña);
                            controladorEmpleado.login = login;
                            GetInfoUsuario();

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
        }
    }
}
