﻿namespace ServiExpress.app_GUI.UsuarioCliente
{
    partial class Info
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
            this.BtnGuardarDatos = new System.Windows.Forms.Button();
            this.BtnActualizarCancelar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtRegion = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtComuna = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // CmbRegion
            // 
            this.CmbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbRegion.FormattingEnabled = true;
            this.CmbRegion.Location = new System.Drawing.Point(533, 115);
            this.CmbRegion.Name = "CmbRegion";
            this.CmbRegion.Size = new System.Drawing.Size(222, 21);
            this.CmbRegion.TabIndex = 82;
            this.CmbRegion.Visible = false;
            this.CmbRegion.SelectedIndexChanged += new System.EventHandler(this.CmbRegion_SelectedIndexChanged);
            // 
            // CmbComuna
            // 
            this.CmbComuna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbComuna.FormattingEnabled = true;
            this.CmbComuna.Location = new System.Drawing.Point(533, 144);
            this.CmbComuna.Name = "CmbComuna";
            this.CmbComuna.Size = new System.Drawing.Size(222, 21);
            this.CmbComuna.TabIndex = 81;
            this.CmbComuna.Visible = false;
            // 
            // BtnGuardarDatos
            // 
            this.BtnGuardarDatos.Location = new System.Drawing.Point(533, 322);
            this.BtnGuardarDatos.Name = "BtnGuardarDatos";
            this.BtnGuardarDatos.Size = new System.Drawing.Size(121, 38);
            this.BtnGuardarDatos.TabIndex = 80;
            this.BtnGuardarDatos.Text = "Guardar datos";
            this.BtnGuardarDatos.UseVisualStyleBackColor = true;
            this.BtnGuardarDatos.Visible = false;
            this.BtnGuardarDatos.Click += new System.EventHandler(this.BtnGuardarDatos_Click);
            // 
            // BtnActualizarCancelar
            // 
            this.BtnActualizarCancelar.Location = new System.Drawing.Point(303, 322);
            this.BtnActualizarCancelar.Name = "BtnActualizarCancelar";
            this.BtnActualizarCancelar.Size = new System.Drawing.Size(121, 38);
            this.BtnActualizarCancelar.TabIndex = 79;
            this.BtnActualizarCancelar.Text = "Actualizar datos";
            this.BtnActualizarCancelar.UseVisualStyleBackColor = true;
            this.BtnActualizarCancelar.Click += new System.EventHandler(this.BtnActualizarCancelar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(477, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 78;
            this.label13.Text = "Región : ";
            // 
            // TxtRegion
            // 
            this.TxtRegion.Enabled = false;
            this.TxtRegion.Location = new System.Drawing.Point(533, 116);
            this.TxtRegion.Name = "TxtRegion";
            this.TxtRegion.Size = new System.Drawing.Size(180, 20);
            this.TxtRegion.TabIndex = 77;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(472, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 76;
            this.label12.Text = "Comuna : ";
            // 
            // TxtComuna
            // 
            this.TxtComuna.Enabled = false;
            this.TxtComuna.Location = new System.Drawing.Point(533, 144);
            this.TxtComuna.Name = "TxtComuna";
            this.TxtComuna.Size = new System.Drawing.Size(180, 20);
            this.TxtComuna.TabIndex = 75;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(457, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 74;
            this.label10.Text = "Contraseña : ";
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Enabled = false;
            this.TxtContraseña.Location = new System.Drawing.Point(533, 197);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.PasswordChar = '*';
            this.TxtContraseña.Size = new System.Drawing.Size(180, 20);
            this.TxtContraseña.TabIndex = 73;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(422, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 13);
            this.label9.TabIndex = 72;
            this.label9.Text = "Nombre de usuario : ";
            // 
            // TxtNombreUsuario
            // 
            this.TxtNombreUsuario.Enabled = false;
            this.TxtNombreUsuario.Location = new System.Drawing.Point(533, 171);
            this.TxtNombreUsuario.Name = "TxtNombreUsuario";
            this.TxtNombreUsuario.Size = new System.Drawing.Size(180, 20);
            this.TxtNombreUsuario.TabIndex = 71;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(466, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 70;
            this.label8.Text = "Dirección : ";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Enabled = false;
            this.TxtDireccion.Location = new System.Drawing.Point(533, 90);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(180, 20);
            this.TxtDireccion.TabIndex = 69;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 68;
            this.label7.Text = "Email : ";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Enabled = false;
            this.TxtEmail.Location = new System.Drawing.Point(152, 246);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(227, 20);
            this.TxtEmail.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "Teléfono : ";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Enabled = false;
            this.TxtTelefono.Location = new System.Drawing.Point(152, 220);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(111, 20);
            this.TxtTelefono.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "Apellido materno : ";
            // 
            // TxtApellidoMaterno
            // 
            this.TxtApellidoMaterno.Enabled = false;
            this.TxtApellidoMaterno.Location = new System.Drawing.Point(152, 194);
            this.TxtApellidoMaterno.Name = "TxtApellidoMaterno";
            this.TxtApellidoMaterno.Size = new System.Drawing.Size(151, 20);
            this.TxtApellidoMaterno.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Apellido paterno : ";
            // 
            // TxtApellidoPaterno
            // 
            this.TxtApellidoPaterno.Enabled = false;
            this.TxtApellidoPaterno.Location = new System.Drawing.Point(152, 168);
            this.TxtApellidoPaterno.Name = "TxtApellidoPaterno";
            this.TxtApellidoPaterno.Size = new System.Drawing.Size(151, 20);
            this.TxtApellidoPaterno.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Segundo nombre : ";
            // 
            // TxtSegundoNombre
            // 
            this.TxtSegundoNombre.Enabled = false;
            this.TxtSegundoNombre.Location = new System.Drawing.Point(152, 142);
            this.TxtSegundoNombre.Name = "TxtSegundoNombre";
            this.TxtSegundoNombre.Size = new System.Drawing.Size(151, 20);
            this.TxtSegundoNombre.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Primer nombre : ";
            // 
            // TxtPrimerNombre
            // 
            this.TxtPrimerNombre.Enabled = false;
            this.TxtPrimerNombre.Location = new System.Drawing.Point(152, 116);
            this.TxtPrimerNombre.Name = "TxtPrimerNombre";
            this.TxtPrimerNombre.Size = new System.Drawing.Size(151, 20);
            this.TxtPrimerNombre.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Rut : ";
            // 
            // TxtRut
            // 
            this.TxtRut.Enabled = false;
            this.TxtRut.Location = new System.Drawing.Point(152, 90);
            this.TxtRut.Name = "TxtRut";
            this.TxtRut.Size = new System.Drawing.Size(111, 20);
            this.TxtRut.TabIndex = 55;
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.CmbRegion);
            this.Controls.Add(this.CmbComuna);
            this.Controls.Add(this.BtnGuardarDatos);
            this.Controls.Add(this.BtnActualizarCancelar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TxtRegion);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TxtComuna);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Info";
            this.Text = "Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbRegion;
        private System.Windows.Forms.ComboBox CmbComuna;
        private System.Windows.Forms.Button BtnGuardarDatos;
        private System.Windows.Forms.Button BtnActualizarCancelar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtRegion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtComuna;
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
    }
}