namespace ServiExpress.app_GUI.UsuarioProveedor
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
            this.DgvOrdenesDePedido = new System.Windows.Forms.DataGridView();
            this.EstadoDePedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdOrdenPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDePedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Administrador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RdbFechaDePedido = new System.Windows.Forms.RadioButton();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.RdbIdOrdenDePedido = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSeleccionarTodosLosPedidos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrdenesDePedido)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.Administrador});
            this.DgvOrdenesDePedido.Location = new System.Drawing.Point(12, 152);
            this.DgvOrdenesDePedido.MultiSelect = false;
            this.DgvOrdenesDePedido.Name = "DgvOrdenesDePedido";
            this.DgvOrdenesDePedido.ReadOnly = true;
            this.DgvOrdenesDePedido.RowHeadersVisible = false;
            this.DgvOrdenesDePedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvOrdenesDePedido.Size = new System.Drawing.Size(776, 297);
            this.DgvOrdenesDePedido.TabIndex = 3;
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
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.CmbEstado);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(668, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(263, 122);
            this.panel3.TabIndex = 30;
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
            this.CmbEstado.Location = new System.Drawing.Point(108, 23);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(140, 21);
            this.CmbEstado.TabIndex = 18;
            this.CmbEstado.SelectedIndexChanged += new System.EventHandler(this.CmbEstado_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Buscar por estado :";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.RdbFechaDePedido);
            this.panel2.Controls.Add(this.TxtBuscar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.BtnBuscar);
            this.panel2.Controls.Add(this.RdbIdOrdenDePedido);
            this.panel2.Location = new System.Drawing.Point(275, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 122);
            this.panel2.TabIndex = 29;
            // 
            // RdbFechaDePedido
            // 
            this.RdbFechaDePedido.AutoSize = true;
            this.RdbFechaDePedido.Location = new System.Drawing.Point(96, 56);
            this.RdbFechaDePedido.Name = "RdbFechaDePedido";
            this.RdbFechaDePedido.Size = new System.Drawing.Size(105, 17);
            this.RdbFechaDePedido.TabIndex = 23;
            this.RdbFechaDePedido.TabStop = true;
            this.RdbFechaDePedido.Text = "Fecha de pedido";
            this.RdbFechaDePedido.UseVisualStyleBackColor = true;
            this.RdbFechaDePedido.CheckedChanged += new System.EventHandler(this.RdbFechaDePedido_CheckedChanged);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Enabled = false;
            this.TxtBuscar.Location = new System.Drawing.Point(220, 24);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(100, 20);
            this.TxtBuscar.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Buscar por  :";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(220, 50);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(100, 28);
            this.BtnBuscar.TabIndex = 19;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // RdbIdOrdenDePedido
            // 
            this.RdbIdOrdenDePedido.AutoSize = true;
            this.RdbIdOrdenDePedido.Location = new System.Drawing.Point(96, 25);
            this.RdbIdOrdenDePedido.Name = "RdbIdOrdenDePedido";
            this.RdbIdOrdenDePedido.Size = new System.Drawing.Size(114, 17);
            this.RdbIdOrdenDePedido.TabIndex = 21;
            this.RdbIdOrdenDePedido.TabStop = true;
            this.RdbIdOrdenDePedido.Text = "Id orden de pedido";
            this.RdbIdOrdenDePedido.UseVisualStyleBackColor = true;
            this.RdbIdOrdenDePedido.CheckedChanged += new System.EventHandler(this.RdbIdOrdenDePedido_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnSeleccionarTodosLosPedidos);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 122);
            this.panel1.TabIndex = 28;
            // 
            // BtnSeleccionarTodosLosPedidos
            // 
            this.BtnSeleccionarTodosLosPedidos.Location = new System.Drawing.Point(14, 15);
            this.BtnSeleccionarTodosLosPedidos.Name = "BtnSeleccionarTodosLosPedidos";
            this.BtnSeleccionarTodosLosPedidos.Size = new System.Drawing.Size(168, 37);
            this.BtnSeleccionarTodosLosPedidos.TabIndex = 20;
            this.BtnSeleccionarTodosLosPedidos.Text = "Seleccionar todos los pedidos";
            this.BtnSeleccionarTodosLosPedidos.UseVisualStyleBackColor = true;
            this.BtnSeleccionarTodosLosPedidos.Click += new System.EventHandler(this.BtnSeleccionarTodosLosPedidos_Click);
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(955, 509);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DgvOrdenesDePedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrdenesDePedido)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvOrdenesDePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoDePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOrdenPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Administrador;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox CmbEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton RdbFechaDePedido;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.RadioButton RdbIdOrdenDePedido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSeleccionarTodosLosPedidos;
    }
}