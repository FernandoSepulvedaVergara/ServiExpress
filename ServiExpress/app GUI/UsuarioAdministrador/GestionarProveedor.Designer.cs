namespace ServiExpress.app_GUI.UsuarioAdministrador
{
    partial class GestionarProveedor
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
            this.button1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtTipoDeUsuario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtNombreUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txttelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtRazonSocial = new System.Windows.Forms.TextBox();
            this.ChbEstadoDeProveedor = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtRut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(849, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 29);
            this.button1.TabIndex = 74;
            this.button1.Text = "Ver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(120, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(224, 18);
            this.label14.TabIndex = 73;
            this.label14.Text = "Actualizar estado de proveedor : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(535, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 18);
            this.label11.TabIndex = 72;
            this.label11.Text = "Tipo de usuario : ";
            // 
            // TxtTipoDeUsuario
            // 
            this.TxtTipoDeUsuario.Enabled = false;
            this.TxtTipoDeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTipoDeUsuario.Location = new System.Drawing.Point(663, 183);
            this.TxtTipoDeUsuario.Name = "TxtTipoDeUsuario";
            this.TxtTipoDeUsuario.ReadOnly = true;
            this.TxtTipoDeUsuario.Size = new System.Drawing.Size(180, 24);
            this.TxtTipoDeUsuario.TabIndex = 71;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(560, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 18);
            this.label10.TabIndex = 70;
            this.label10.Text = "Contraseña : ";
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Enabled = false;
            this.TxtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContraseña.Location = new System.Drawing.Point(663, 157);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.PasswordChar = '*';
            this.TxtContraseña.ReadOnly = true;
            this.TxtContraseña.Size = new System.Drawing.Size(180, 24);
            this.TxtContraseña.TabIndex = 69;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(510, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 18);
            this.label9.TabIndex = 68;
            this.label9.Text = "Nombre de usuario : ";
            // 
            // TxtNombreUsuario
            // 
            this.TxtNombreUsuario.Enabled = false;
            this.TxtNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreUsuario.Location = new System.Drawing.Point(663, 131);
            this.TxtNombreUsuario.Name = "TxtNombreUsuario";
            this.TxtNombreUsuario.ReadOnly = true;
            this.TxtNombreUsuario.Size = new System.Drawing.Size(180, 24);
            this.TxtNombreUsuario.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 66;
            this.label4.Text = "Email : ";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Enabled = false;
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(208, 209);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.ReadOnly = true;
            this.TxtEmail.Size = new System.Drawing.Size(254, 24);
            this.TxtEmail.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 64;
            this.label3.Text = "Teléfono : ";
            // 
            // Txttelefono
            // 
            this.Txttelefono.Enabled = false;
            this.Txttelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txttelefono.Location = new System.Drawing.Point(208, 183);
            this.Txttelefono.Name = "Txttelefono";
            this.Txttelefono.ReadOnly = true;
            this.Txttelefono.Size = new System.Drawing.Size(147, 24);
            this.Txttelefono.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 62;
            this.label2.Text = "Razón social : ";
            // 
            // TxtRazonSocial
            // 
            this.TxtRazonSocial.Enabled = false;
            this.TxtRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRazonSocial.Location = new System.Drawing.Point(208, 157);
            this.TxtRazonSocial.Name = "TxtRazonSocial";
            this.TxtRazonSocial.ReadOnly = true;
            this.TxtRazonSocial.Size = new System.Drawing.Size(254, 24);
            this.TxtRazonSocial.TabIndex = 61;
            // 
            // ChbEstadoDeProveedor
            // 
            this.ChbEstadoDeProveedor.AutoCheck = false;
            this.ChbEstadoDeProveedor.AutoSize = true;
            this.ChbEstadoDeProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChbEstadoDeProveedor.Location = new System.Drawing.Point(361, 41);
            this.ChbEstadoDeProveedor.Name = "ChbEstadoDeProveedor";
            this.ChbEstadoDeProveedor.Size = new System.Drawing.Size(116, 22);
            this.ChbEstadoDeProveedor.TabIndex = 60;
            this.ChbEstadoDeProveedor.Text = "Deshabilitado";
            this.ChbEstadoDeProveedor.UseVisualStyleBackColor = true;
            this.ChbEstadoDeProveedor.CheckedChanged += new System.EventHandler(this.ChbEstadoDeUsuario_CheckedChanged);
            this.ChbEstadoDeProveedor.Click += new System.EventHandler(this.ChbEstadoDeProveedor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 59;
            this.label1.Text = "Rut proveedor : ";
            // 
            // TxtRut
            // 
            this.TxtRut.Enabled = false;
            this.TxtRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRut.Location = new System.Drawing.Point(208, 131);
            this.TxtRut.Name = "TxtRut";
            this.TxtRut.ReadOnly = true;
            this.TxtRut.Size = new System.Drawing.Size(111, 24);
            this.TxtRut.TabIndex = 58;
            // 
            // GestionarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(930, 440);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtTipoDeUsuario);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtNombreUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txttelefono);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtRazonSocial);
            this.Controls.Add(this.ChbEstadoDeProveedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtRut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GestionarProveedor";
            this.ShowIcon = false;
            this.Text = "Gestionar proveedor";
            this.Load += new System.EventHandler(this.GestionarProveedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtTipoDeUsuario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtNombreUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txttelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtRazonSocial;
        private System.Windows.Forms.CheckBox ChbEstadoDeProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtRut;
    }
}