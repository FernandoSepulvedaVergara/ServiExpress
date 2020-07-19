namespace ServiExpress.app_GUI.UsuarioAdministrador
{
    partial class Pedidos
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
            this.BtnGenerarPedido = new System.Windows.Forms.Button();
            this.DgvOrdenesDePedido = new System.Windows.Forms.DataGridView();
            this.EstadoDePedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdOrdenPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDePedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Administrador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSeleccionarTodosLosPedidos = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.RdbIdOrdenDePedido = new System.Windows.Forms.RadioButton();
            this.RdbFechaDePedido = new System.Windows.Forms.RadioButton();
            this.RdbProveedor = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrdenesDePedido)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnGenerarPedido
            // 
            this.BtnGenerarPedido.Location = new System.Drawing.Point(33, 71);
            this.BtnGenerarPedido.Name = "BtnGenerarPedido";
            this.BtnGenerarPedido.Size = new System.Drawing.Size(128, 39);
            this.BtnGenerarPedido.TabIndex = 0;
            this.BtnGenerarPedido.Text = "Generar pedido";
            this.BtnGenerarPedido.UseVisualStyleBackColor = true;
            this.BtnGenerarPedido.Click += new System.EventHandler(this.BtnGenerarPedido_Click);
            // 
            // DgvOrdenesDePedido
            // 
            this.DgvOrdenesDePedido.AllowUserToAddRows = false;
            this.DgvOrdenesDePedido.AllowUserToDeleteRows = false;
            this.DgvOrdenesDePedido.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvOrdenesDePedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOrdenesDePedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EstadoDePedido,
            this.IdOrdenPedido,
            this.FechaDePedido,
            this.Total,
            this.Administrador,
            this.Proveedor});
            this.DgvOrdenesDePedido.Location = new System.Drawing.Point(16, 3);
            this.DgvOrdenesDePedido.MultiSelect = false;
            this.DgvOrdenesDePedido.Name = "DgvOrdenesDePedido";
            this.DgvOrdenesDePedido.ReadOnly = true;
            this.DgvOrdenesDePedido.RowHeadersVisible = false;
            this.DgvOrdenesDePedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvOrdenesDePedido.Size = new System.Drawing.Size(822, 349);
            this.DgvOrdenesDePedido.TabIndex = 1;
            this.DgvOrdenesDePedido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOrdenesDePedido_CellClick);
            // 
            // EstadoDePedido
            // 
            this.EstadoDePedido.HeaderText = "Estado de pedido";
            this.EstadoDePedido.Name = "EstadoDePedido";
            this.EstadoDePedido.ReadOnly = true;
            // 
            // IdOrdenPedido
            // 
            this.IdOrdenPedido.HeaderText = "Id orden de pedido";
            this.IdOrdenPedido.Name = "IdOrdenPedido";
            this.IdOrdenPedido.ReadOnly = true;
            // 
            // FechaDePedido
            // 
            this.FechaDePedido.HeaderText = "Fecha de pedido";
            this.FechaDePedido.Name = "FechaDePedido";
            this.FechaDePedido.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Administrador
            // 
            this.Administrador.HeaderText = "Administrador";
            this.Administrador.Name = "Administrador";
            this.Administrador.ReadOnly = true;
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.ReadOnly = true;
            // 
            // BtnSeleccionarTodosLosPedidos
            // 
            this.BtnSeleccionarTodosLosPedidos.Location = new System.Drawing.Point(14, 15);
            this.BtnSeleccionarTodosLosPedidos.Name = "BtnSeleccionarTodosLosPedidos";
            this.BtnSeleccionarTodosLosPedidos.Size = new System.Drawing.Size(173, 42);
            this.BtnSeleccionarTodosLosPedidos.TabIndex = 20;
            this.BtnSeleccionarTodosLosPedidos.Text = "Seleccionar todos los pedidos";
            this.BtnSeleccionarTodosLosPedidos.UseVisualStyleBackColor = true;
            this.BtnSeleccionarTodosLosPedidos.Click += new System.EventHandler(this.BtnSeleccionarTodosLosPedidos_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(242, 50);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(112, 28);
            this.BtnBuscar.TabIndex = 19;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Buscar por  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Buscar por estado :";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Enabled = false;
            this.TxtBuscar.Location = new System.Drawing.Point(242, 24);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(112, 22);
            this.TxtBuscar.TabIndex = 13;
            this.TxtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);
            this.TxtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBuscar_KeyUp);
            // 
            // RdbIdOrdenDePedido
            // 
            this.RdbIdOrdenDePedido.AutoSize = true;
            this.RdbIdOrdenDePedido.Location = new System.Drawing.Point(96, 25);
            this.RdbIdOrdenDePedido.Name = "RdbIdOrdenDePedido";
            this.RdbIdOrdenDePedido.Size = new System.Drawing.Size(140, 20);
            this.RdbIdOrdenDePedido.TabIndex = 21;
            this.RdbIdOrdenDePedido.TabStop = true;
            this.RdbIdOrdenDePedido.Text = "Id orden de pedido";
            this.RdbIdOrdenDePedido.UseVisualStyleBackColor = true;
            this.RdbIdOrdenDePedido.CheckedChanged += new System.EventHandler(this.RdbIdOrdenDePedido_CheckedChanged);
            // 
            // RdbFechaDePedido
            // 
            this.RdbFechaDePedido.AutoSize = true;
            this.RdbFechaDePedido.Location = new System.Drawing.Point(96, 71);
            this.RdbFechaDePedido.Name = "RdbFechaDePedido";
            this.RdbFechaDePedido.Size = new System.Drawing.Size(129, 20);
            this.RdbFechaDePedido.TabIndex = 23;
            this.RdbFechaDePedido.TabStop = true;
            this.RdbFechaDePedido.Text = "Fecha de pedido";
            this.RdbFechaDePedido.UseVisualStyleBackColor = true;
            this.RdbFechaDePedido.CheckedChanged += new System.EventHandler(this.RdbFechaDePedido_CheckedChanged);
            // 
            // RdbProveedor
            // 
            this.RdbProveedor.AutoSize = true;
            this.RdbProveedor.Location = new System.Drawing.Point(96, 49);
            this.RdbProveedor.Name = "RdbProveedor";
            this.RdbProveedor.Size = new System.Drawing.Size(90, 20);
            this.RdbProveedor.TabIndex = 24;
            this.RdbProveedor.TabStop = true;
            this.RdbProveedor.Text = "Proveedor";
            this.RdbProveedor.UseVisualStyleBackColor = true;
            this.RdbProveedor.CheckedChanged += new System.EventHandler(this.RdbProveedor_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnGenerarPedido);
            this.panel1.Controls.Add(this.BtnSeleccionarTodosLosPedidos);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(13, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 122);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.RdbFechaDePedido);
            this.panel2.Controls.Add(this.TxtBuscar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.RdbProveedor);
            this.panel2.Controls.Add(this.BtnBuscar);
            this.panel2.Controls.Add(this.RdbIdOrdenDePedido);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(276, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 122);
            this.panel2.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.CmbEstado);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(669, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(302, 122);
            this.panel3.TabIndex = 27;
            // 
            // CmbEstado
            // 
            this.CmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Items.AddRange(new object[] {
            "Generado",
            "Aprobado",
            "Rechazado",
            "En camino",
            "Entregado",
            "Cancelado"});
            this.CmbEstado.Location = new System.Drawing.Point(133, 22);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(155, 24);
            this.CmbEstado.TabIndex = 18;
            this.CmbEstado.SelectedIndexChanged += new System.EventHandler(this.CmbEstado_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DgvOrdenesDePedido);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(12, 156);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(920, 362);
            this.panel4.TabIndex = 28;
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1015, 530);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrdenesDePedido)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGenerarPedido;
        private System.Windows.Forms.DataGridView DgvOrdenesDePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoDePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOrdenPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Administrador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.Button BtnSeleccionarTodosLosPedidos;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.RadioButton RdbIdOrdenDePedido;
        private System.Windows.Forms.RadioButton RdbFechaDePedido;
        private System.Windows.Forms.RadioButton RdbProveedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox CmbEstado;
        private System.Windows.Forms.Panel panel4;
    }
}