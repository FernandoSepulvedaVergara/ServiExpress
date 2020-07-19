namespace ServiExpress.app_GUI.UsuarioAdministrador
{
    partial class AdministrarProveedores
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtBuscarRut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSeleccionarTodosLosUsuarios = new System.Windows.Forms.Button();
            this.BtnNuevoUsuario = new System.Windows.Forms.Button();
            this.DgvUsuarios = new System.Windows.Forms.DataGridView();
            this.VerUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDeUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RutProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BtnBuscar);
            this.panel2.Controls.Add(this.TxtBuscarRut);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(290, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 106);
            this.panel2.TabIndex = 18;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(114, 38);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(113, 28);
            this.BtnBuscar.TabIndex = 10;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtBuscarRut
            // 
            this.TxtBuscarRut.Location = new System.Drawing.Point(114, 10);
            this.TxtBuscarRut.Name = "TxtBuscarRut";
            this.TxtBuscarRut.Size = new System.Drawing.Size(113, 22);
            this.TxtBuscarRut.TabIndex = 0;
            this.TxtBuscarRut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscarRut_KeyPress);
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnSeleccionarTodosLosUsuarios);
            this.panel1.Controls.Add(this.BtnNuevoUsuario);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(31, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 106);
            this.panel1.TabIndex = 17;
            // 
            // BtnSeleccionarTodosLosUsuarios
            // 
            this.BtnSeleccionarTodosLosUsuarios.Location = new System.Drawing.Point(21, 5);
            this.BtnSeleccionarTodosLosUsuarios.Name = "BtnSeleccionarTodosLosUsuarios";
            this.BtnSeleccionarTodosLosUsuarios.Size = new System.Drawing.Size(173, 42);
            this.BtnSeleccionarTodosLosUsuarios.TabIndex = 12;
            this.BtnSeleccionarTodosLosUsuarios.Text = "Seleccionar todos los proveedores";
            this.BtnSeleccionarTodosLosUsuarios.UseVisualStyleBackColor = true;
            this.BtnSeleccionarTodosLosUsuarios.Click += new System.EventHandler(this.BtnSeleccionarTodosLosUsuarios_Click);
            // 
            // BtnNuevoUsuario
            // 
            this.BtnNuevoUsuario.Location = new System.Drawing.Point(35, 69);
            this.BtnNuevoUsuario.Name = "BtnNuevoUsuario";
            this.BtnNuevoUsuario.Size = new System.Drawing.Size(136, 30);
            this.BtnNuevoUsuario.TabIndex = 13;
            this.BtnNuevoUsuario.Text = "Nuevo proveedor";
            this.BtnNuevoUsuario.UseVisualStyleBackColor = true;
            this.BtnNuevoUsuario.Click += new System.EventHandler(this.BtnNuevoUsuario_Click);
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
            this.RutProveedor,
            this.RazonSocial,
            this.Telefono,
            this.Email});
            this.DgvUsuarios.Location = new System.Drawing.Point(18, 3);
            this.DgvUsuarios.MultiSelect = false;
            this.DgvUsuarios.Name = "DgvUsuarios";
            this.DgvUsuarios.ReadOnly = true;
            this.DgvUsuarios.RowHeadersVisible = false;
            this.DgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvUsuarios.Size = new System.Drawing.Size(788, 336);
            this.DgvUsuarios.TabIndex = 16;
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
            // RutProveedor
            // 
            this.RutProveedor.HeaderText = "Rut proveedor";
            this.RutProveedor.Name = "RutProveedor";
            this.RutProveedor.ReadOnly = true;
            // 
            // RazonSocial
            // 
            this.RazonSocial.HeaderText = "Razón social";
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DgvUsuarios);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(3, 124);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(873, 342);
            this.panel3.TabIndex = 19;
            // 
            // AdministrarProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(877, 478);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdministrarProveedores";
            this.Text = "AdministrarProveedores";
            this.Load += new System.EventHandler(this.AdministrarProveedores_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBuscarRut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSeleccionarTodosLosUsuarios;
        private System.Windows.Forms.Button BtnNuevoUsuario;
        private System.Windows.Forms.DataGridView DgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn VerUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDeUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn RutProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.Panel panel3;
    }
}