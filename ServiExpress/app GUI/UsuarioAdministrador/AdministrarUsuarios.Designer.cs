namespace ServiExpress.app_GUI.UsuarioAdministrador
{
    partial class AdministrarUsuarios
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
            this.TxtBuscarRut = new System.Windows.Forms.TextBox();
            this.ChbCliente = new System.Windows.Forms.CheckBox();
            this.DgvUsuarios = new System.Windows.Forms.DataGridView();
            this.VerUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDeUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoDeUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChbAdministrador = new System.Windows.Forms.CheckBox();
            this.ChbEmpleado = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBuscarRut
            // 
            this.TxtBuscarRut.Location = new System.Drawing.Point(152, 9);
            this.TxtBuscarRut.Name = "TxtBuscarRut";
            this.TxtBuscarRut.Size = new System.Drawing.Size(100, 20);
            this.TxtBuscarRut.TabIndex = 0;
            // 
            // ChbCliente
            // 
            this.ChbCliente.AutoSize = true;
            this.ChbCliente.Location = new System.Drawing.Point(519, 11);
            this.ChbCliente.Name = "ChbCliente";
            this.ChbCliente.Size = new System.Drawing.Size(58, 17);
            this.ChbCliente.TabIndex = 1;
            this.ChbCliente.Text = "Cliente";
            this.ChbCliente.UseVisualStyleBackColor = true;
            this.ChbCliente.CheckedChanged += new System.EventHandler(this.ChbCliente_CheckedChanged);
            // 
            // DgvUsuarios
            // 
            this.DgvUsuarios.AllowUserToAddRows = false;
            this.DgvUsuarios.AllowUserToDeleteRows = false;
            this.DgvUsuarios.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VerUsuario,
            this.TipoDeUsuario,
            this.Rut,
            this.Nombre,
            this.ApellidoPaterno,
            this.ApellidoMaterno,
            this.EstadoDeUsuario});
            this.DgvUsuarios.Location = new System.Drawing.Point(12, 117);
            this.DgvUsuarios.MultiSelect = false;
            this.DgvUsuarios.Name = "DgvUsuarios";
            this.DgvUsuarios.ReadOnly = true;
            this.DgvUsuarios.RowHeadersVisible = false;
            this.DgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvUsuarios.Size = new System.Drawing.Size(776, 321);
            this.DgvUsuarios.TabIndex = 4;
            // 
            // VerUsuario
            // 
            this.VerUsuario.HeaderText = "";
            this.VerUsuario.Name = "VerUsuario";
            this.VerUsuario.ReadOnly = true;
            // 
            // TipoDeUsuario
            // 
            this.TipoDeUsuario.HeaderText = "Tipo de usuario";
            this.TipoDeUsuario.Name = "TipoDeUsuario";
            this.TipoDeUsuario.ReadOnly = true;
            // 
            // Rut
            // 
            this.Rut.HeaderText = "Rut";
            this.Rut.Name = "Rut";
            this.Rut.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // ApellidoPaterno
            // 
            this.ApellidoPaterno.HeaderText = "Apellido paterno";
            this.ApellidoPaterno.Name = "ApellidoPaterno";
            this.ApellidoPaterno.ReadOnly = true;
            // 
            // ApellidoMaterno
            // 
            this.ApellidoMaterno.HeaderText = "Apellido materno";
            this.ApellidoMaterno.Name = "ApellidoMaterno";
            this.ApellidoMaterno.ReadOnly = true;
            // 
            // EstadoDeUsuario
            // 
            this.EstadoDeUsuario.HeaderText = "Estado de usuario";
            this.EstadoDeUsuario.Name = "EstadoDeUsuario";
            this.EstadoDeUsuario.ReadOnly = true;
            // 
            // ChbAdministrador
            // 
            this.ChbAdministrador.AutoSize = true;
            this.ChbAdministrador.Location = new System.Drawing.Point(519, 57);
            this.ChbAdministrador.Name = "ChbAdministrador";
            this.ChbAdministrador.Size = new System.Drawing.Size(89, 17);
            this.ChbAdministrador.TabIndex = 5;
            this.ChbAdministrador.Text = "Administrador";
            this.ChbAdministrador.UseVisualStyleBackColor = true;
            this.ChbAdministrador.CheckedChanged += new System.EventHandler(this.ChbAdministrador_CheckedChanged);
            // 
            // ChbEmpleado
            // 
            this.ChbEmpleado.AutoSize = true;
            this.ChbEmpleado.Location = new System.Drawing.Point(519, 34);
            this.ChbEmpleado.Name = "ChbEmpleado";
            this.ChbEmpleado.Size = new System.Drawing.Size(73, 17);
            this.ChbEmpleado.TabIndex = 6;
            this.ChbEmpleado.Text = "Empleado";
            this.ChbEmpleado.UseVisualStyleBackColor = true;
            this.ChbEmpleado.CheckedChanged += new System.EventHandler(this.ChbEmpleado_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Buscar por usuario :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Buscar por rut :";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(152, 35);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(100, 28);
            this.BtnBuscar.TabIndex = 10;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // AdministrarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChbEmpleado);
            this.Controls.Add(this.ChbAdministrador);
            this.Controls.Add(this.DgvUsuarios);
            this.Controls.Add(this.ChbCliente);
            this.Controls.Add(this.TxtBuscarRut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdministrarUsuarios";
            this.ShowIcon = false;
            this.Text = "AdministrarUsuarios";
            this.Load += new System.EventHandler(this.AdministrarUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBuscarRut;
        private System.Windows.Forms.CheckBox ChbCliente;
        private System.Windows.Forms.DataGridView DgvUsuarios;
        private System.Windows.Forms.CheckBox ChbAdministrador;
        private System.Windows.Forms.CheckBox ChbEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn VerUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDeUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoDeUsuario;
    }
}