using ServiExpress.controlador;
using System;
using System.Windows.Forms;

namespace ServiExpress.app_GUI
{
    public partial class FormNuevoUsuario : Form
    {
        ControladorUsuario controladorUsuario = new ControladorUsuario();
        public FormNuevoUsuario()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtRut_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtDv_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtPrimerNombre.Text.Equals(string.Empty) || TxtSegundoNombre.Text.Equals(string.Empty) || TxtApellidoPaterno.Text.Equals(string.Empty) || TxtApellidoMaterno.Text.Equals(string.Empty) || TxtEmail.Text.Equals(string.Empty) ||
                        TxtTelefono.Text.Equals(string.Empty) || TxtDireccion.Text.Equals(string.Empty) || CmbComuna.SelectedItem == null || CmbRegion.SelectedItem == null  || TxtNombreUsuario.Text.Equals(string.Empty) || TxtContraseña.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Faltan datos por ingresar");
                }
                else
                {
                    int idComuna = int.Parse(CmbComuna.SelectedItem.ToString().Substring(0, CmbComuna.SelectedItem.ToString().IndexOf("-")).Trim());
                    string[] resultado = controladorUsuario.NuevoUsuario(TxtRut.Text,TxtPrimerNombre.Text,TxtSegundoNombre.Text,TxtApellidoPaterno.Text,TxtApellidoMaterno.Text, int.Parse(TxtTelefono.Text.ToString()), TxtEmail.Text,TxtDireccion.Text,idComuna,TxtNombreUsuario.Text,1,TxtContraseña.Text,1);
                    if (bool.Parse(resultado[0]))
                    {
                        MessageBox.Show(resultado[1],"Nuevo usuario");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(resultado[1], "Nuevo usuario");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de configuración \n" + ex.Message);
            }
        }

        private void FormNuevoUsuario_Load(object sender, EventArgs e)
        {
            WebServiceUsuario.region[] regiones = controladorUsuario.GetRegiones();

            if (regiones == null)
            {
                MessageBox.Show("Error al cargar recursos");
                this.Close();
            }
            else
            {
                foreach (WebServiceUsuario.region region in regiones)
                {
                    CmbRegion.Items.Add(string.Format("{0} - {1}", region.idRegion, region.region1));
                }
            }
        }

        private void cmbxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int idRegion = int.Parse(CmbRegion.SelectedItem.ToString().Substring(0, CmbRegion.SelectedItem.ToString().IndexOf("-")).Trim());
                CmbComuna.Items.Clear();
                WebServiceUsuario.comuna[] comunas = controladorUsuario.GetComunas(idRegion);
                if (comunas == null)
                {
                    MessageBox.Show("Error al cargar recursos");
                    this.Close();
                }
                else
                {
                    foreach (WebServiceUsuario.comuna comuna in comunas)
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
    }
}
