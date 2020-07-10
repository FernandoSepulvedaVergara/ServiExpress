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

            }
            else {
                MessageBox.Show("Error al cargar los datos");
                this.Dispose();
            }
        }
    }
}
