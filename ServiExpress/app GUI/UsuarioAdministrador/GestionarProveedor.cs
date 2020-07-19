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
    public partial class GestionarProveedor : Form
    {
        ControladorAdministrador controladorAdministrador;
        string rut;
        public GestionarProveedor(ControladorAdministrador controladorAdministrador, string rut)
        {
            this.controladorAdministrador = controladorAdministrador;
            this.rut = rut;
            InitializeComponent();
        }

        private void GestionarProveedor_Load(object sender, EventArgs e)
        {
            GetProveedor(this.rut);
        }

        private void GetProveedor(string rut) {
            proveedor resultado = controladorAdministrador.GetProveedor(this.rut);
            if (resultado != null)
            {
                TxtRut.Text = resultado.rutProveedor;
                TxtRazonSocial.Text = resultado.razonSocial;
                Txttelefono.Text = resultado.telefono.ToString();
                TxtEmail.Text = resultado.email;
                TxtNombreUsuario.Text = resultado.nombreUsuario;
                TxtContraseña.Text = resultado.contraseña;
                TxtTipoDeUsuario.Text = resultado.tipoDeUsuario.tipoDeUsuario1;
                ChbEstadoDeProveedor.Text = resultado.estadoDeUsuario.estadoDeUsuario1;
                if (resultado.estadoDeUsuario.idEstadoDeUsuario.Equals(1))
                {
                    ChbEstadoDeProveedor.Checked = true;
                }
                else
                {
                    ChbEstadoDeProveedor.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("Error al cargar los datos");
                this.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            TxtContraseña.PasswordChar = '\0';
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            TxtContraseña.PasswordChar = '*';
        }

        private void ChbEstadoDeUsuario_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void ChbEstadoDeProveedor_Click(object sender, EventArgs e)
        {
            if (ChbEstadoDeProveedor.Checked)
            {
                DialogResult dialogResult = MessageBox.Show(string.Format("¿Deshabilitar proveedor?"), "Actualizar estado de proveedor", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (controladorAdministrador.ActualizarEstadoProveedor(this.rut, 2))
                    {
                        MessageBox.Show("Proveedor deshabilitado");
                        ChbEstadoDeProveedor.Checked = false;
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar estado");
                        ChbEstadoDeProveedor.Checked = true;
                    }
                }
            }
            else if (ChbEstadoDeProveedor.Checked.Equals(false))
            {
                DialogResult dialogResult = MessageBox.Show(string.Format("¿Habilitar proveedor?"), "Actualizar estado de proveedor", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (controladorAdministrador.ActualizarEstadoProveedor(this.rut, 1))
                    {
                        MessageBox.Show("Proveedor habilitado");
                        ChbEstadoDeProveedor.Checked = true;
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar estado");
                        ChbEstadoDeProveedor.Checked = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Error al validar checkbox");
            }
            GetProveedor(this.rut);
        }
    }
}
