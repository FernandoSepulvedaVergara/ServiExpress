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
    public partial class NuevoUsuario : Form
    {
        ControladorAdministrador controladorAdministrador;
        public NuevoUsuario(ControladorAdministrador controladorAdministrador)
        {
            this.controladorAdministrador = controladorAdministrador;
            InitializeComponent();
        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {
            ConfigurarNuevoUsuario();
        }

        public void ConfigurarNuevoUsuario() {
            try
            {
                region[] regiones = controladorAdministrador.GetRegiones();
                tipoDeUsuario[] tiposDeUsuario = controladorAdministrador.GetTipoDeUsuario();

                if (regiones.Equals(null) || tiposDeUsuario.Equals(null))
                {
                    MessageBox.Show("Error al cargar recursos");
                    this.Close();
                }
                else
                {
                    foreach (region region in regiones)
                    {
                        CmbRegion.Items.Add(string.Format("{0} - {1}", region.idRegion, region.region1));
                    }
                    foreach (tipoDeUsuario tipoDeUsuario in tiposDeUsuario)
                    {
                        CmbTipoDeUsuario.Items.Add(string.Format("{0} - {1}", tipoDeUsuario.idTipoDeUsuario, tipoDeUsuario.tipoDeUsuario1));
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error de configuración \n" + ex.Message);
            }
        }

        private void CmbRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                int idRegion = int.Parse(CmbRegion.SelectedItem.ToString().Substring(0, CmbRegion.SelectedItem.ToString().IndexOf("-")).Trim());
                CmbComuna.Items.Clear();
                comuna[] comunas = controladorAdministrador.GetComunas(idRegion);
                if (comunas.Equals(null))
                {
                    MessageBox.Show("Error al cargar recursos");
                    this.Close();
                }
                else
                {
                    foreach (comuna comuna in comunas)
                    {
                        CmbComuna.Items.Add(string.Format("{0} - {1}", comuna.idComuna, comuna.comuna1));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de configuración \n" + ex.Message);
            }
        }

        private void BtnGuardarNuevoUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtPrimerNombre.Text.Equals(string.Empty) || TxtSegundoNombre.Text.Equals(string.Empty) || TxtApellidoPaterno.Text.Equals(string.Empty) || TxtApellidoMaterno.Text.Equals(string.Empty) || TxtEmail.Text.Equals(string.Empty) ||
                    TxtTelefono.Text.Equals(string.Empty) || TxtDireccion.Text.Equals(string.Empty) || CmbComuna.SelectedItem == null || CmbRegion.SelectedItem == null || CmbTipoDeUsuario.SelectedItem == null || TxtNombreUsuario.Text.Equals(string.Empty) || TxtContraseña.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Faltan datos por ingresar");
                }
                else
                {
                    int idComuna = int.Parse(CmbComuna.SelectedItem.ToString().Substring(0, CmbComuna.SelectedItem.ToString().IndexOf("-")).Trim());
                    int idTipoDeUsuario = int.Parse(CmbTipoDeUsuario.SelectedItem.ToString().Substring(0, CmbTipoDeUsuario.SelectedItem.ToString().IndexOf("-")).Trim());
                    usuario nuevoUsuario = new usuario();
                    nuevoUsuario.rut = TxtRut.Text;
                    nuevoUsuario.primerNombre = TxtPrimerNombre.Text;
                    nuevoUsuario.segundoNombre = TxtSegundoNombre.Text;
                    nuevoUsuario.apellidoPaterno = TxtApellidoPaterno.Text;
                    nuevoUsuario.apellidoMaterno = TxtApellidoMaterno.Text;
                    nuevoUsuario.telefono = int.Parse(TxtTelefono.Text);
                    nuevoUsuario.email = TxtEmail.Text;
                    nuevoUsuario.direccion = TxtDireccion.Text;
                    nuevoUsuario.nombreUsuario = TxtNombreUsuario.Text;
                    nuevoUsuario.contraseña = TxtContraseña.Text;
                    tipoDeUsuario tipoDeUsuario = new tipoDeUsuario();
                    tipoDeUsuario.idTipoDeUsuario = idTipoDeUsuario;
                    nuevoUsuario.tipoUsuario = tipoDeUsuario;
                    comuna comuna = new comuna();
                    comuna.idComuna = idComuna;
                    nuevoUsuario.comuna = comuna;
                    estadoDeUsuario estadoDeUsuario = new estadoDeUsuario();
                    estadoDeUsuario.idEstadoDeUsuario = 1;
                    nuevoUsuario.estadoDeUsuario = estadoDeUsuario;

                    string[] resultado = controladorAdministrador.RegistrarNuevoUsuario(nuevoUsuario);
                    if (bool.Parse(resultado[0])) {
                        MessageBox.Show(resultado[1]);
                        Limpiar();
                    }
                    else if (bool.Parse(resultado[0]) == false) {
                        MessageBox.Show(resultado[1]);
                    }
                    else {
                        MessageBox.Show("Error, resultado no devolicó true ni false");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de configuración \n" + ex.Message);
            }
        }
        private void Limpiar() {
            TxtRut.Clear();
            TxtPrimerNombre.Clear();
            TxtSegundoNombre.Clear();
            TxtApellidoPaterno.Clear();
            TxtApellidoMaterno.Clear();
            TxtTelefono.Clear();
            TxtEmail.Clear();
            TxtDireccion.Clear();
            TxtNombreUsuario.Clear();
            TxtContraseña.Clear();
        }
    }
}
