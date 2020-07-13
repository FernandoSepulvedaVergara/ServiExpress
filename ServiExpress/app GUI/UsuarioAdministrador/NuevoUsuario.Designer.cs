namespace ServiExpress.app_GUI.UsuarioAdministrador
{
    partial class NuevoUsuario
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
            this.CmbRegion = new System.Windows.Forms.ComboBox();
            this.CmbComuna = new System.Windows.Forms.ComboBox();
            this.BtnGuardarNuevoUsuario = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtNombreUsuario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSegundoNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPrimerNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtRut = new System.Windows.Forms.TextBox();
            this.CmbTipoDeUsuario = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmbRegion
            // 
            this.CmbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbRegion.FormattingEnabled = true;
            this.CmbRegion.Location = new System.Drawing.Point(509, 95);
            this.CmbRegion.Name = "CmbRegion";
            this.CmbRegion.Size = new System.Drawing.Size(222, 21);
            this.CmbRegion.TabIndex = 82;
            this.CmbRegion.SelectedIndexChanged += new System.EventHandler(this.CmbRegion_SelectedIndexChanged);
            // 
            // CmbComuna
            // 
            this.CmbComuna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbComuna.FormattingEnabled = true;
            this.CmbComuna.Location = new System.Drawing.Point(509, 124);
            this.CmbComuna.Name = "CmbComuna";
            this.CmbComuna.Size = new System.Drawing.Size(222, 21);
            this.CmbComuna.TabIndex = 81;
            // 
            // BtnGuardarNuevoUsuario
            // 
            this.BtnGuardarNuevoUsuario.Location = new System.Drawing.Point(509, 318);
            this.BtnGuardarNuevoUsuario.Name = "BtnGuardarNuevoUsuario";
            this.BtnGuardarNuevoUsuario.Size = new System.Drawing.Size(155, 38);
            this.BtnGuardarNuevoUsuario.TabIndex = 80;
            this.BtnGuardarNuevoUsuario.Text = "Guardar nuevo usuario";
            this.BtnGuardarNuevoUsuario.UseVisualStyleBackColor = true;
            this.BtnGuardarNuevoUsuario.Click += new System.EventHandler(this.BtnGuardarNuevoUsuario_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(453, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 78;
            this.label13.Text = "Región : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(448, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 76;
            this.label12.Text = "Comuna : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(433, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 74;
            this.label10.Text = "Contraseña : ";
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Location = new System.Drawing.Point(509, 247);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.PasswordChar = '*';
            this.TxtContraseña.Size = new System.Drawing.Size(180, 20);
            this.TxtContraseña.TabIndex = 73;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(398, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 13);
            this.label9.TabIndex = 72;
            this.label9.Text = "Nombre de usuario : ";
            // 
            // TxtNombreUsuario
            // 
            this.TxtNombreUsuario.Location = new System.Drawing.Point(509, 221);
            this.TxtNombreUsuario.Name = "TxtNombreUsuario";
            this.TxtNombreUsuario.Size = new System.Drawing.Size(180, 20);
            this.TxtNombreUsuario.TabIndex = 71;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(442, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 70;
            this.label8.Text = "Dirección : ";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(509, 69);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(222, 20);
            this.TxtDireccion.TabIndex = 69;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 68;
            this.label7.Text = "Email : ";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(128, 225);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(227, 20);
            this.TxtEmail.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "Teléfono : ";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(128, 199);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(111, 20);
            this.TxtTelefono.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "Apellido materno : ";
            // 
            // TxtApellidoMaterno
            // 
            this.TxtApellidoMaterno.Location = new System.Drawing.Point(128, 173);
            this.TxtApellidoMaterno.Name = "TxtApellidoMaterno";
            this.TxtApellidoMaterno.Size = new System.Drawing.Size(151, 20);
            this.TxtApellidoMaterno.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Apellido paterno : ";
            // 
            // TxtApellidoPaterno
            // 
            this.TxtApellidoPaterno.Location = new System.Drawing.Point(128, 147);
            this.TxtApellidoPaterno.Name = "TxtApellidoPaterno";
            this.TxtApellidoPaterno.Size = new System.Drawing.Size(151, 20);
            this.TxtApellidoPaterno.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Segundo nombre : ";
            // 
            // TxtSegundoNombre
            // 
            this.TxtSegundoNombre.Location = new System.Drawing.Point(128, 121);
            this.TxtSegundoNombre.Name = "TxtSegundoNombre";
            this.TxtSegundoNombre.Size = new System.Drawing.Size(151, 20);
            this.TxtSegundoNombre.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Primer nombre : ";
            // 
            // TxtPrimerNombre
            // 
            this.TxtPrimerNombre.Location = new System.Drawing.Point(128, 95);
            this.TxtPrimerNombre.Name = "TxtPrimerNombre";
            this.TxtPrimerNombre.Size = new System.Drawing.Size(151, 20);
            this.TxtPrimerNombre.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Rut : ";
            // 
            // TxtRut
            // 
            this.TxtRut.Location = new System.Drawing.Point(128, 69);
            this.TxtRut.Name = "TxtRut";
            this.TxtRut.Size = new System.Drawing.Size(111, 20);
            this.TxtRut.TabIndex = 55;
            // 
            // CmbTipoDeUsuario
            // 
            this.CmbTipoDeUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoDeUsuario.FormattingEnabled = true;
            this.CmbTipoDeUsuario.Location = new System.Drawing.Point(509, 151);
            this.CmbTipoDeUsuario.Name = "CmbTipoDeUsuario";
            this.CmbTipoDeUsuario.Size = new System.Drawing.Size(143, 21);
            this.CmbTipoDeUsuario.TabIndex = 84;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(414, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 83;
            this.label11.Text = "Tipo de usuario : ";
            // 
            // NuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(801, 406);
            this.Controls.Add(this.CmbTipoDeUsuario);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CmbRegion);
            this.Controls.Add(this.CmbComuna);
            this.Controls.Add(this.BtnGuardarNuevoUsuario);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtNombreUsuario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtApellidoMaterno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtApellidoPaterno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSegundoNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPrimerNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtRut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NuevoUsuario";
            this.Text = "Nuevo usuario";
            this.Load += new System.EventHandler(this.NuevoUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbRegion;
        private System.Windows.Forms.ComboBox CmbComuna;
        private System.Windows.Forms.Button BtnGuardarNuevoUsuario;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtNombreUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtApellidoMaterno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtApellidoPaterno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSegundoNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPrimerNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtRut;
        private System.Windows.Forms.ComboBox CmbTipoDeUsuario;
        private System.Windows.Forms.Label label11;
    }
}