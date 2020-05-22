using ServiExpress.app_GUI;
using ServiExpress.controlador;
using ServiExpress.WebServiceUsuario;
using System;
using System.Windows.Forms;

namespace ServiExpress
{
    public partial class formLoginUsuario : Form
    {
        public formLoginUsuario()
        {            
            InitializeComponent();
        }

        private void BtnIngresarUsuario_Click(object sender, EventArgs e)
        {
            string[] login = ControladorLoginUsuario.ValidarUsuario(txtUserName.Text.Trim(),txtContraseñaUsuario.Text.Trim());
            if (login != null)
            {
                if (int.Parse(login[3]) == 1)
                {
                    FormUsuario1 usuario1 = new FormUsuario1(login);
                    this.Hide();
                    usuario1.Show();
                }

                else if(int.Parse(login[3]) == 2)
                {
                    FormUsuario2 usuario2 = new FormUsuario2();
                    this.Hide();
                    usuario2.Show();
                }

                else if (int.Parse(login[3]) == 3)
                {
                    FormUsuario3 usuario3 = new FormUsuario3();
                    this.Hide();
                    usuario3.Show();
                }

                else if (int.Parse(login[3]) == 4)
                {
                    FormUsuario4 usuario4 = new FormUsuario4();
                    this.Hide();
                    usuario4.Show();
                }
            }
            else
            {
                MessageBox.Show("Usuario no existe");
            }
        }

        private void FormLoginUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnRegistroUsuario_Click(object sender, EventArgs e)
        {
            FormNuevoUsuario nuevoUsuario = new FormNuevoUsuario();
            nuevoUsuario.ShowDialog();
        }
    }
}
