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

        private void btnIngresarUsuario_Click(object sender, EventArgs e)
        {
            string[] login = controladorLoginUsuario.ValidarUsuario(txtUserName.Text.Trim(),txtContraseñaUsuario.Text.Trim());
            if (login != null)
            {
                if (int.Parse(login[3]) == 1)
                {
                    formUsuario1 usuario1 = new formUsuario1();
                    this.Hide();
                    usuario1.Show();
                }

                else if(int.Parse(login[3]) == 2)
                {
                    formUsuario2 usuario2 = new formUsuario2();
                    this.Hide();
                    usuario2.Show();
                }
            }
            else
            {
                MessageBox.Show("Usuario no existe");
            }
        }

        private void formLoginUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistroUsuario_Click(object sender, EventArgs e)
        {
            //formRegistroUsuario nuevoRegistroUsuario = new formRegistroUsuario();
            //nuevoRegistroUsuario.ShowDialog();

            WebServiceUsuario.WebServiceUsuarioClient webUsuario = new WebServiceUsuario.WebServiceUsuarioClient();
            string[] resultado = webUsuario.WebServiceNuevoUsuario("184799650","Katherinne","Alejandra","Sepúlveda","Arriagada",962847949,
                                              "sepulvedakatherinne@gmail.com","nuevo horizonte 781",2,"k.sepulveda",
                                              2,"kate123");
        }
    }
}
