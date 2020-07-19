using ServiExpress.controlador;
using ServiExpress.WebServiceAdministrador;
using System;
using System.Windows.Forms;

namespace ServiExpress.app_GUI.UsuarioAdministrador
{
    public partial class GestionarUsuario : Form
    {
        ControladorAdministrador controladorAdministrador;
        string rut;
        public GestionarUsuario(ControladorAdministrador controladorAdministrador, string rut)
        {
            this.rut = rut;
            this.controladorAdministrador = controladorAdministrador;
            InitializeComponent();
            GetInfoUsuario();
        }

        private void GetInfoUsuario() {
            usuario resultado = controladorAdministrador.GetInfoUsuario(this.rut);
            if (resultado != null) {

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
                TxtTipoDeUsuario.Text = resultado.tipoUsuario.tipoDeUsuario1;
                TxtComuna.Text = resultado.comuna.comuna1;
                TxtRegion.Text = resultado.region.region1;
                ChbEstadoDeUsuario.Text = resultado.estadoDeUsuario.estadoDeUsuario1;
                if (resultado.estadoDeUsuario.idEstadoDeUsuario.Equals(1)) {
                    ChbEstadoDeUsuario.Checked = true;
                }
                else {
                    ChbEstadoDeUsuario.Checked = false;
                }
            }
            else {
                MessageBox.Show("Error al cargar los datos");
                this.Dispose();
            }
        }

        private void ChbEstadoDeUsuario_Click(object sender, EventArgs e)
        {
            if (ChbEstadoDeUsuario.Checked)
            {
                DialogResult dialogResult = MessageBox.Show(string.Format("¿Deshabilitar usuario?"), "Actualizar estado de usuario", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (controladorAdministrador.ActualizarEstadoDeUsuario(TxtRut.Text,2))
                    {                        
                        MessageBox.Show("Usuario deshabilitado");
                        ChbEstadoDeUsuario.Checked = false;
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar estado");
                        ChbEstadoDeUsuario.Checked = true;
                    }
                }
            }
            else if (ChbEstadoDeUsuario.Checked.Equals(false))
            {
                DialogResult dialogResult = MessageBox.Show(string.Format("¿Habilitar usuario?"), "Actualizar estado de usuario", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (controladorAdministrador.ActualizarEstadoDeUsuario(TxtRut.Text, 1))
                    {
                        MessageBox.Show("Usuario habilitado");
                        ChbEstadoDeUsuario.Checked = true;
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar estado");
                        ChbEstadoDeUsuario.Checked = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Error al validar checkbox");
            }
            GetInfoUsuario();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            TxtContraseña.PasswordChar = '\0';
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            TxtContraseña.PasswordChar = '*';
        }

        private void GestionarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ChbEstadoDeUsuario_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
