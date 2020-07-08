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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CmbFiltro = new System.Windows.Forms.ComboBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrdenesDePedido)).BeginInit();
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
            this.DgvOrdenesDePedido.Location = new System.Drawing.Point(71, 147);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 20);
            this.textBox1.TabIndex = 4;
            // 
            // CmbFiltro
            // 
            this.CmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFiltro.FormattingEnabled = true;
            this.CmbFiltro.Location = new System.Drawing.Point(66, 42);
            this.CmbFiltro.Name = "CmbFiltro";
            this.CmbFiltro.Size = new System.Drawing.Size(121, 21);
            this.CmbFiltro.TabIndex = 5;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(264, 67);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(98, 23);
            this.BtnBuscar.TabIndex = 6;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(918, 509);
            this.ControlBox = false;
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.CmbFiltro);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DgvOrdenesDePedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrdenesDePedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvOrdenesDePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoDePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOrdenPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Administrador;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox CmbFiltro;
        private System.Windows.Forms.Button BtnBuscar;
    }
}