namespace ServiExpress
{
    partial class formLoginUsuario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLoginUsuario));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegistroUsuario = new System.Windows.Forms.Button();
            this.btnIngresarUsuario = new System.Windows.Forms.Button();
            this.txtContraseñaUsuario = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnIngresoProveedores = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtContraseñaProveedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSalirProveedor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNombreUsuarioProveedor = new System.Windows.Forms.TextBox();
            this.BtnIngresarProveedor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(124, 181);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 28);
            this.btnSalir.TabIndex = 22;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnRegistroUsuario
            // 
            this.btnRegistroUsuario.BackColor = System.Drawing.Color.Yellow;
            this.btnRegistroUsuario.Location = new System.Drawing.Point(40, 225);
            this.btnRegistroUsuario.Name = "btnRegistroUsuario";
            this.btnRegistroUsuario.Size = new System.Drawing.Size(75, 28);
            this.btnRegistroUsuario.TabIndex = 21;
            this.btnRegistroUsuario.Text = "Registrarse";
            this.btnRegistroUsuario.UseVisualStyleBackColor = false;
            this.btnRegistroUsuario.Click += new System.EventHandler(this.BtnRegistroUsuario_Click);
            // 
            // btnIngresarUsuario
            // 
            this.btnIngresarUsuario.BackColor = System.Drawing.Color.Yellow;
            this.btnIngresarUsuario.Location = new System.Drawing.Point(28, 181);
            this.btnIngresarUsuario.Name = "btnIngresarUsuario";
            this.btnIngresarUsuario.Size = new System.Drawing.Size(75, 28);
            this.btnIngresarUsuario.TabIndex = 20;
            this.btnIngresarUsuario.Text = "Ingresar";
            this.btnIngresarUsuario.UseVisualStyleBackColor = false;
            this.btnIngresarUsuario.Click += new System.EventHandler(this.BtnIngresarUsuario_Click);
            // 
            // txtContraseñaUsuario
            // 
            this.txtContraseñaUsuario.Location = new System.Drawing.Point(28, 129);
            this.txtContraseñaUsuario.MaxLength = 25;
            this.txtContraseñaUsuario.Name = "txtContraseñaUsuario";
            this.txtContraseñaUsuario.PasswordChar = '*';
            this.txtContraseñaUsuario.Size = new System.Drawing.Size(137, 20);
            this.txtContraseñaUsuario.TabIndex = 19;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(28, 59);
            this.txtUserName.MaxLength = 20;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(137, 20);
            this.txtUserName.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre de usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // BtnIngresoProveedores
            // 
            this.BtnIngresoProveedores.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.BtnIngresoProveedores.Location = new System.Drawing.Point(12, 12);
            this.BtnIngresoProveedores.Name = "BtnIngresoProveedores";
            this.BtnIngresoProveedores.Size = new System.Drawing.Size(132, 28);
            this.BtnIngresoProveedores.TabIndex = 23;
            this.BtnIngresoProveedores.Text = "Ingreso proveedores";
            this.BtnIngresoProveedores.UseVisualStyleBackColor = false;
            this.BtnIngresoProveedores.Click += new System.EventHandler(this.BtnIngresoProveedores_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtContraseñaUsuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.btnIngresarUsuario);
            this.panel1.Location = new System.Drawing.Point(218, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 243);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TxtContraseñaProveedor);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.BtnSalirProveedor);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.TxtNombreUsuarioProveedor);
            this.panel2.Controls.Add(this.BtnIngresarProveedor);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 243);
            this.panel2.TabIndex = 25;
            this.panel2.Visible = false;
            // 
            // TxtContraseñaProveedor
            // 
            this.TxtContraseñaProveedor.Location = new System.Drawing.Point(28, 129);
            this.TxtContraseñaProveedor.MaxLength = 25;
            this.TxtContraseñaProveedor.Name = "TxtContraseñaProveedor";
            this.TxtContraseñaProveedor.PasswordChar = '*';
            this.TxtContraseñaProveedor.Size = new System.Drawing.Size(137, 20);
            this.TxtContraseñaProveedor.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Proovedor";
            // 
            // BtnSalirProveedor
            // 
            this.BtnSalirProveedor.BackColor = System.Drawing.Color.Red;
            this.BtnSalirProveedor.Location = new System.Drawing.Point(124, 181);
            this.BtnSalirProveedor.Name = "BtnSalirProveedor";
            this.BtnSalirProveedor.Size = new System.Drawing.Size(75, 28);
            this.BtnSalirProveedor.TabIndex = 22;
            this.BtnSalirProveedor.Text = "Salir";
            this.BtnSalirProveedor.UseVisualStyleBackColor = false;
            this.BtnSalirProveedor.Click += new System.EventHandler(this.BtnSalirProveedor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Contraseña";
            // 
            // TxtNombreUsuarioProveedor
            // 
            this.TxtNombreUsuarioProveedor.Location = new System.Drawing.Point(28, 59);
            this.TxtNombreUsuarioProveedor.MaxLength = 20;
            this.TxtNombreUsuarioProveedor.Name = "TxtNombreUsuarioProveedor";
            this.TxtNombreUsuarioProveedor.Size = new System.Drawing.Size(137, 20);
            this.TxtNombreUsuarioProveedor.TabIndex = 18;
            // 
            // BtnIngresarProveedor
            // 
            this.BtnIngresarProveedor.BackColor = System.Drawing.Color.Yellow;
            this.BtnIngresarProveedor.Location = new System.Drawing.Point(28, 181);
            this.BtnIngresarProveedor.Name = "BtnIngresarProveedor";
            this.BtnIngresarProveedor.Size = new System.Drawing.Size(75, 28);
            this.BtnIngresarProveedor.TabIndex = 20;
            this.BtnIngresarProveedor.Text = "Ingresar";
            this.BtnIngresarProveedor.UseVisualStyleBackColor = false;
            this.BtnIngresarProveedor.Click += new System.EventHandler(this.BtnIngresarProveedor_Click);
            // 
            // formLoginUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(176)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(430, 278);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnIngresoProveedores);
            this.Controls.Add(this.btnRegistroUsuario);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formLoginUsuario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso usuario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLoginUsuario_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegistroUsuario;
        private System.Windows.Forms.Button btnIngresarUsuario;
        private System.Windows.Forms.TextBox txtContraseñaUsuario;
        public System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnIngresoProveedores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtContraseñaProveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSalirProveedor;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TxtNombreUsuarioProveedor;
        private System.Windows.Forms.Button BtnIngresarProveedor;
    }
}

