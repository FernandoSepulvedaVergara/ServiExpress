﻿using ServiExpress.controlador;
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
    public partial class AgregarNuevoProducto : Form
    {
        ControladorProveedor controladorProveedor;
        public AgregarNuevoProducto(ControladorProveedor controladorProveedor)
        {
            this.controladorProveedor = controladorProveedor;
            InitializeComponent();
        }
    }
}
