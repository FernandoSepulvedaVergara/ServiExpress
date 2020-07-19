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
            this.BtnSeleccionarTodosLosUsuarios = new System.Windows.Forms.Button();
            this.BtnNuevoUsuario = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtBuscarRut
            // 
            this.TxtBuscarRut.Location = new System.Drawing.Point(112, 9);
            this.TxtBuscarRut.Name = "TxtBuscarRut";
            this.TxtBuscarRut.Size = new System.Drawing.Size(100, 22);
            this.TxtBuscarRut.TabIndex = 0;
            this.TxtBuscarRut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscarRut_KeyPress);
            // 
            // ChbCliente
            // 
            this.ChbCliente.AutoSize = true;
            this.ChbCliente.Location = new System.Drawing.Point(135, 13);
            this.ChbCliente.Name = "ChbCliente";
            this.ChbCliente.Size = new System.Drawing.Size(68, 20);
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
            this.DgvUsuarios.Location = new System.Drawing.Point(8, 19);
            this.DgvUsuarios.MultiSelect = false;
            this.DgvUsuarios.Name = "DgvUsuarios";
            this.DgvUsuarios.ReadOnly = true;
            this.DgvUsuarios.RowHeadersVisible = false;
            this.DgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvUsuarios.Size = new System.Drawing.Size(827, 339);
            this.DgvUsuarios.TabIndex = 4;
            this.DgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsuarios_CellClick);
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
            this.ChbAdministrador.Location = new System.Drawing.Point(135, 59);
            this.ChbAdministrador.Name = "ChbAdministrador";
            this.ChbAdministrador.Size = new System.Drawing.Size(110, 20);
            this.ChbAdministrador.TabIndex = 5;
            this.ChbAdministrador.Text = "Administrador";
            this.ChbAdministrador.UseVisualStyleBackColor = true;
            this.ChbAdministrador.CheckedChanged += new System.EventHandler(this.ChbAdministrador_CheckedChanged);
            // 
            // ChbEmpleado
            // 
            this.ChbEmpleado.AutoSize = true;
            this.ChbEmpleado.Location = new System.Drawing.Point(135, 36);
            this.ChbEmpleado.Name = "ChbEmpleado";
            this.ChbEmpleado.Size = new System.Drawing.Size(90, 20);
            this.ChbEmpleado.TabIndex = 6;
            this.ChbEmpleado.Text = "Empleado";
            this.ChbEmpleado.UseVisualStyleBackColor = true;
            this.ChbEmpleado.CheckedChanged += new System.EventHandler(this.ChbEmpleado_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Buscar por usuario :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Buscar por rut :";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(112, 35);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(100, 28);
            this.BtnBuscar.TabIndex = 10;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnSeleccionarTodosLosUsuarios
            // 
            this.BtnSeleccionarTodosLosUsuarios.Location = new System.Drawing.Point(21, 5);
            this.BtnSeleccionarTodosLosUsuarios.Name = "BtnSeleccionarTodosLosUsuarios";
            this.BtnSeleccionarTodosLosUsuarios.Size = new System.Drawing.Size(172, 41);
            this.BtnSeleccionarTodosLosUsuarios.TabIndex = 12;
            this.BtnSeleccionarTodosLosUsuarios.Text = "Seleccionar todos los usuarios";
            this.BtnSeleccionarTodosLosUsuarios.UseVisualStyleBackColor = true;
            this.BtnSeleccionarTodosLosUsuarios.Click += new System.EventHandler(this.BtnSeleccionarTodosLosUsuarios_Click);
            // 
            // BtnNuevoUsuario
            // 
            this.BtnNuevoUsuario.Location = new System.Drawing.Point(35, 69);
            this.BtnNuevoUsuario.Name = "BtnNuevoUsuario";
            this.BtnNuevoUsuario.Size = new System.Drawing.Size(136, 30);
            this.BtnNuevoUsuario.TabIndex = 13;
            this.BtnNuevoUsuario.Text = "Nuevo usuario";
            this.BtnNuevoUsuario.UseVisualStyleBackColor = true;
            this.BtnNuevoUsuario.Click += new System.EventHandler(this.BtnNuevoUsuario_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnSeleccionarTodosLosUsuarios);
            this.panel1.Controls.Add(this.BtnNuevoUsuario);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 106);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BtnBuscar);
            this.panel2.Controls.Add(this.TxtBuscarRut);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(271, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 106);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.ChbCliente);
            this.panel3.Controls.Add(this.ChbAdministrador);
            this.panel3.Controls.Add(this.ChbEmpleado);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(542, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(254, 106);
            this.panel3.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DgvUsuarios);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(-4, 121);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(850, 389);
            this.panel4.TabIndex = 17;
            // 
            // AdministrarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(843, 522);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdministrarUsuarios";
            this.ShowIcon = false;
            this.Text = "AdministrarUsuarios";
            this.Load += new System.EventHandler(this.AdministrarUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button BtnSeleccionarTodosLosUsuarios;
        private System.Windows.Forms.Button BtnNuevoUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}