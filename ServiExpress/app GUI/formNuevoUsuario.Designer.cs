namespace ServiExpress.app_GUI
{
    partial class FormNuevoUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNuevoUsuario));
            this.btnGuardarUsuario = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbxRegion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbxComuna = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.txtDv = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuardarUsuario
            // 
            this.btnGuardarUsuario.BackColor = System.Drawing.Color.Yellow;
            this.btnGuardarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarUsuario.Location = new System.Drawing.Point(750, 672);
            this.btnGuardarUsuario.Name = "btnGuardarUsuario";
            this.btnGuardarUsuario.Size = new System.Drawing.Size(631, 85);
            this.btnGuardarUsuario.TabIndex = 14;
            this.btnGuardarUsuario.Text = "Guardar";
            this.btnGuardarUsuario.UseVisualStyleBackColor = false;
            this.btnGuardarUsuario.Click += new System.EventHandler(this.btnGuardarUsuario_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Red;
            this.btnAtras.Location = new System.Drawing.Point(30, 704);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(139, 34);
            this.btnAtras.TabIndex = 15;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Location = new System.Drawing.Point(25, 136);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(144, 20);
            this.txtPrimerNombre.TabIndex = 3;
            this.txtPrimerNombre.Tag = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(23, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Primer nombre";
            // 
            // cmbxRegion
            // 
            this.cmbxRegion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxRegion.FormattingEnabled = true;
            this.cmbxRegion.Location = new System.Drawing.Point(242, 303);
            this.cmbxRegion.Name = "cmbxRegion";
            this.cmbxRegion.Size = new System.Drawing.Size(143, 21);
            this.cmbxRegion.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(21, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Segundo nombre";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(24, 462);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(149, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.Location = new System.Drawing.Point(24, 218);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(144, 20);
            this.txtSegundoNombre.TabIndex = 4;
            this.txtSegundoNombre.Tag = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(21, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Apellido materno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(22, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Apellido paterno";
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Location = new System.Drawing.Point(24, 303);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(144, 20);
            this.txtApellidoPaterno.TabIndex = 5;
            this.txtApellidoPaterno.Tag = "3";
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Location = new System.Drawing.Point(24, 382);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(149, 20);
            this.txtApellidoMaterno.TabIndex = 6;
            this.txtApellidoMaterno.Tag = "4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(239, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Teléfono";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(240, 136);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(143, 20);
            this.txtTelefono.TabIndex = 8;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(23, 446);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(244, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Región";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(237, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Comuna";
            // 
            // cmbxComuna
            // 
            this.cmbxComuna.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxComuna.FormattingEnabled = true;
            this.cmbxComuna.Location = new System.Drawing.Point(240, 381);
            this.cmbxComuna.Name = "cmbxComuna";
            this.cmbxComuna.Size = new System.Drawing.Size(143, 21);
            this.cmbxComuna.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(237, 445);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Nombre de usuario";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(237, 521);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(240, 537);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(143, 20);
            this.txtContraseña.TabIndex = 13;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(240, 462);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(143, 20);
            this.txtNombreUsuario.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(23, 521);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Rut";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(24, 537);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(121, 20);
            this.txtRut.TabIndex = 1;
            this.txtRut.TextChanged += new System.EventHandler(this.txtRut_TextChanged);
            // 
            // txtDv
            // 
            this.txtDv.Location = new System.Drawing.Point(151, 537);
            this.txtDv.Name = "txtDv";
            this.txtDv.Size = new System.Drawing.Size(22, 20);
            this.txtDv.TabIndex = 2;
            this.txtDv.TextChanged += new System.EventHandler(this.txtDv_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(237, 202);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Dirección";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(240, 218);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(143, 20);
            this.txtDireccion.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(-5, -1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(468, 61);
            this.label11.TabIndex = 28;
            this.label11.Text = "Registrate con nosotros";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Georgia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(147, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(301, 18);
            this.label14.TabIndex = 29;
            this.label14.Text = "TRAE TU VEHICULO CON EXPERTOS";
            // 
            // FormNuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtDv);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtRut);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbxComuna);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrimerNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardarUsuario);
            this.Controls.Add(this.txtSegundoNombre);
            this.Controls.Add(this.txtApellidoPaterno);
            this.Controls.Add(this.cmbxRegion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtApellidoMaterno);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtEmail);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNuevoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formNuevoUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarUsuario;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbxRegion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbxComuna;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.TextBox txtDv;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
    }
}