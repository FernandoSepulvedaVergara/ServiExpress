using ServiExpress.app_GUI;
using ServiExpress.controlador;
using ServiExpress.Informes;
using System;
using System.Windows.Forms;

namespace ServiExpress
{
    public partial class formLoginUsuario : Form
    {
        private ControladorLoginUsuario controladorLoginUsuario = new ControladorLoginUsuario();

        public formLoginUsuario(ControladorLoginUsuario controladorLoginUsuario)
        {
            this.controladorLoginUsuario = controladorLoginUsuario;
            InitializeComponent();
        }

        private void BtnIngresarUsuario_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Equals(null) || txtContraseñaUsuario.Text.Equals(null))
            {
                MessageBox.Show("Debe proporcionar todos los datos para ingresar");
            }
            else
            {
                string[] login = controladorLoginUsuario.ValidarUsuario(txtUserName.Text.Trim(), txtContraseñaUsuario.Text.Trim());
                if (login != null)
                {
                    if (int.Parse(login[3]) == 1)
                    {
                        Cliente usuario1 = new Cliente(login);
                        this.Hide();
                        usuario1.Show();
                    }

                    else if (int.Parse(login[3]) == 3)
                    {
                        Empleado usuario3 = new Empleado(login);
                        this.Hide();
                        usuario3.Show();
                    }

                    else if (int.Parse(login[3]) == 4)
                    {
                        Administrador usuario4 = new Administrador(login);
                        this.Hide();
                        usuario4.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecta");
                }
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

        private void BtnIngresoProveedores_Click(object sender, EventArgs e)
        {
            if (BtnIngresoProveedores.Text.Equals("Ingreso proveedores"))
            {
                panel2.Visible = true;
                panel2.Visible = true;
                btnRegistroUsuario.Visible = false;
                BtnIngresoProveedores.Text = "Ingreso usuarios";
            }
            else
            {
                panel1.Visible = true;
                panel2.Visible = false;
                btnRegistroUsuario.Visible = true;
                BtnIngresoProveedores.Text = "Ingreso proveedores";
            }
        }

        private void BtnSalirProveedor_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnIngresarProveedor_Click(object sender, EventArgs e)
        {
            if (TxtNombreUsuarioProveedor.Text.Equals(string.Empty) || TxtContraseñaProveedor.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe proporcionar todos los datos para ingresar");
            }
            else
            {
                string[] login = controladorLoginUsuario.ValidarUsuarioProveedor(TxtNombreUsuarioProveedor.Text, TxtContraseñaProveedor.Text);
                if (login[0] == null)
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecta");
                }
                else
                {
                    Proveedor usuario2 = new Proveedor(login);
                    this.Hide();
                    usuario2.Show();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
