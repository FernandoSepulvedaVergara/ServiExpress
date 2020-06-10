namespace ServiExpress.app_GUI.UsuarioEmpleado
{
    partial class ReservasDeHora
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
            this.DgvReservasDeHora = new System.Windows.Forms.DataGridView();
            this.EstadoDeAtención = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RutCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdReservación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmbFiltros = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RdbSeleccionarHoy = new System.Windows.Forms.RadioButton();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.TxtValorFiltro = new System.Windows.Forms.TextBox();
            this.CmbSucursales = new System.Windows.Forms.ComboBox();
            this.PanelFiltrar = new System.Windows.Forms.Panel();
            this.RdbFiltrar = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReservasDeHora)).BeginInit();
            this.PanelFiltrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvReservasDeHora
            // 
            this.DgvReservasDeHora.AllowUserToAddRows = false;
            this.DgvReservasDeHora.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DgvReservasDeHora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvReservasDeHora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EstadoDeAtención,
            this.HoraReserva,
            this.FechaReserva,
            this.RutCliente,
            this.Patente,
            this.IdReservación,
            this.Sucursal});
            this.DgvReservasDeHora.Location = new System.Drawing.Point(12, 111);
            this.DgvReservasDeHora.MultiSelect = false;
            this.DgvReservasDeHora.Name = "DgvReservasDeHora";
            this.DgvReservasDeHora.ReadOnly = true;
            this.DgvReservasDeHora.RowHeadersVisible = false;
            this.DgvReservasDeHora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvReservasDeHora.Size = new System.Drawing.Size(780, 293);
            this.DgvReservasDeHora.TabIndex = 0;
            this.DgvReservasDeHora.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvReservasDeHora_CellClick);
            // 
            // EstadoDeAtención
            // 
            this.EstadoDeAtención.HeaderText = "Estado de atención";
            this.EstadoDeAtención.Name = "EstadoDeAtención";
            this.EstadoDeAtención.ReadOnly = true;
            // 
            // HoraReserva
            // 
            this.HoraReserva.HeaderText = "Hora de reservación";
            this.HoraReserva.Name = "HoraReserva";
            this.HoraReserva.ReadOnly = true;
            // 
            // FechaReserva
            // 
            this.FechaReserva.HeaderText = "Fecha de reservación";
            this.FechaReserva.Name = "FechaReserva";
            this.FechaReserva.ReadOnly = true;
            // 
            // RutCliente
            // 
            this.RutCliente.HeaderText = "Rut cliente";
            this.RutCliente.Name = "RutCliente";
            this.RutCliente.ReadOnly = true;
            // 
            // Patente
            // 
            this.Patente.HeaderText = "Patente";
            this.Patente.Name = "Patente";
            this.Patente.ReadOnly = true;
            // 
            // IdReservación
            // 
            this.IdReservación.HeaderText = "Id reservación";
            this.IdReservación.Name = "IdReservación";
            this.IdReservación.ReadOnly = true;
            // 
            // Sucursal
            // 
            this.Sucursal.HeaderText = "Sucursal";
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.ReadOnly = true;
            // 
            // CmbFiltros
            // 
            this.CmbFiltros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFiltros.FormattingEnabled = true;
            this.CmbFiltros.Items.AddRange(new object[] {
            "Fecha",
            "Rut",
            "Patente",
            "Id reservación",
            "Sucursal"});
            this.CmbFiltros.Location = new System.Drawing.Point(29, 21);
            this.CmbFiltros.Name = "CmbFiltros";
            this.CmbFiltros.Size = new System.Drawing.Size(148, 21);
            this.CmbFiltros.TabIndex = 1;
            this.CmbFiltros.SelectedIndexChanged += new System.EventHandler(this.CmbFiltros_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtrar por:";
            // 
            // RdbSeleccionarHoy
            // 
            this.RdbSeleccionarHoy.AutoSize = true;
            this.RdbSeleccionarHoy.Location = new System.Drawing.Point(62, 53);
            this.RdbSeleccionarHoy.Name = "RdbSeleccionarHoy";
            this.RdbSeleccionarHoy.Size = new System.Drawing.Size(101, 17);
            this.RdbSeleccionarHoy.TabIndex = 3;
            this.RdbSeleccionarHoy.TabStop = true;
            this.RdbSeleccionarHoy.Text = "Seleccionar hoy";
            this.RdbSeleccionarHoy.UseVisualStyleBackColor = true;
            this.RdbSeleccionarHoy.CheckedChanged += new System.EventHandler(this.RdbSeleccionarHoy_CheckedChanged);
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.BackColor = System.Drawing.Color.Yellow;
            this.BtnFiltrar.Location = new System.Drawing.Point(240, 30);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(87, 26);
            this.BtnFiltrar.TabIndex = 4;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = false;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // TxtValorFiltro
            // 
            this.TxtValorFiltro.Location = new System.Drawing.Point(29, 48);
            this.TxtValorFiltro.Name = "TxtValorFiltro";
            this.TxtValorFiltro.Size = new System.Drawing.Size(100, 20);
            this.TxtValorFiltro.TabIndex = 5;
            // 
            // CmbSucursales
            // 
            this.CmbSucursales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSucursales.Enabled = false;
            this.CmbSucursales.FormattingEnabled = true;
            this.CmbSucursales.Location = new System.Drawing.Point(29, 48);
            this.CmbSucursales.Name = "CmbSucursales";
            this.CmbSucursales.Size = new System.Drawing.Size(148, 21);
            this.CmbSucursales.TabIndex = 6;
            this.CmbSucursales.Visible = false;
            // 
            // PanelFiltrar
            // 
            this.PanelFiltrar.Controls.Add(this.CmbSucursales);
            this.PanelFiltrar.Controls.Add(this.BtnFiltrar);
            this.PanelFiltrar.Controls.Add(this.CmbFiltros);
            this.PanelFiltrar.Controls.Add(this.TxtValorFiltro);
            this.PanelFiltrar.Controls.Add(this.label1);
            this.PanelFiltrar.Enabled = false;
            this.PanelFiltrar.Location = new System.Drawing.Point(352, 5);
            this.PanelFiltrar.Name = "PanelFiltrar";
            this.PanelFiltrar.Size = new System.Drawing.Size(367, 100);
            this.PanelFiltrar.TabIndex = 7;
            // 
            // RdbFiltrar
            // 
            this.RdbFiltrar.AutoSize = true;
            this.RdbFiltrar.Location = new System.Drawing.Point(194, 54);
            this.RdbFiltrar.Name = "RdbFiltrar";
            this.RdbFiltrar.Size = new System.Drawing.Size(50, 17);
            this.RdbFiltrar.TabIndex = 8;
            this.RdbFiltrar.TabStop = true;
            this.RdbFiltrar.Text = "Filtrar";
            this.RdbFiltrar.UseVisualStyleBackColor = true;
            this.RdbFiltrar.CheckedChanged += new System.EventHandler(this.RdbFiltrar_CheckedChanged);
            // 
            // ReservasDeHora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(176)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.RdbFiltrar);
            this.Controls.Add(this.PanelFiltrar);
            this.Controls.Add(this.RdbSeleccionarHoy);
            this.Controls.Add(this.DgvReservasDeHora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReservasDeHora";
            this.Text = "ReservasDeHora";
            this.Load += new System.EventHandler(this.ReservasDeHora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvReservasDeHora)).EndInit();
            this.PanelFiltrar.ResumeLayout(false);
            this.PanelFiltrar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvReservasDeHora;
        private System.Windows.Forms.ComboBox CmbFiltros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RdbSeleccionarHoy;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.TextBox TxtValorFiltro;
        private System.Windows.Forms.ComboBox CmbSucursales;
        private System.Windows.Forms.Panel PanelFiltrar;
        private System.Windows.Forms.RadioButton RdbFiltrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoDeAtención;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn RutCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdReservación;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sucursal;
    }
}