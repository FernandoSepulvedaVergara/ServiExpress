namespace ServiExpress.app_GUI.UsuarioAdministrador
{
    partial class GenerarPedido
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
            this.CmbProveedores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtFechaDePedido = new System.Windows.Forms.TextBox();
            this.CmbProductos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbTipoDeProducto = new System.Windows.Forms.ComboBox();
            this.BtnRegistrarPedido = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblMontoAPagar = new System.Windows.Forms.Label();
            this.BtnQuitarProducto = new System.Windows.Forms.Button();
            this.DgvProductosProveedor = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RutProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDeVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioDeCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductosProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbProveedores
            // 
            this.CmbProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbProveedores.FormattingEnabled = true;
            this.CmbProveedores.Location = new System.Drawing.Point(42, 33);
            this.CmbProveedores.Name = "CmbProveedores";
            this.CmbProveedores.Size = new System.Drawing.Size(317, 24);
            this.CmbProveedores.TabIndex = 0;
            this.CmbProveedores.SelectedIndexChanged += new System.EventHandler(this.CmbProveedores_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccionar proveedor :";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.TxtFechaDePedido);
            this.splitContainer1.Panel1.Controls.Add(this.CmbProductos);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.CmbTipoDeProducto);
            this.splitContainer1.Panel1.Controls.Add(this.BtnRegistrarPedido);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.CmbProveedores);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.LblMontoAPagar);
            this.splitContainer1.Panel2.Controls.Add(this.BtnQuitarProducto);
            this.splitContainer1.Panel2.Controls.Add(this.DgvProductosProveedor);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Size = new System.Drawing.Size(959, 459);
            this.splitContainer1.SplitterDistance = 187;
            this.splitContainer1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(458, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha de pedido :";
            // 
            // TxtFechaDePedido
            // 
            this.TxtFechaDePedido.Enabled = false;
            this.TxtFechaDePedido.Location = new System.Drawing.Point(581, 33);
            this.TxtFechaDePedido.Name = "TxtFechaDePedido";
            this.TxtFechaDePedido.ReadOnly = true;
            this.TxtFechaDePedido.Size = new System.Drawing.Size(100, 22);
            this.TxtFechaDePedido.TabIndex = 6;
            // 
            // CmbProductos
            // 
            this.CmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbProductos.FormattingEnabled = true;
            this.CmbProductos.Location = new System.Drawing.Point(42, 120);
            this.CmbProductos.Name = "CmbProductos";
            this.CmbProductos.Size = new System.Drawing.Size(317, 24);
            this.CmbProductos.TabIndex = 4;
            this.CmbProductos.SelectedIndexChanged += new System.EventHandler(this.CmbProductos_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seleccionar producto :";
            // 
            // CmbTipoDeProducto
            // 
            this.CmbTipoDeProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoDeProducto.FormattingEnabled = true;
            this.CmbTipoDeProducto.Location = new System.Drawing.Point(42, 77);
            this.CmbTipoDeProducto.Name = "CmbTipoDeProducto";
            this.CmbTipoDeProducto.Size = new System.Drawing.Size(317, 24);
            this.CmbTipoDeProducto.TabIndex = 2;
            this.CmbTipoDeProducto.SelectedIndexChanged += new System.EventHandler(this.CmbTipoDeProducto_SelectedIndexChanged);
            // 
            // BtnRegistrarPedido
            // 
            this.BtnRegistrarPedido.Location = new System.Drawing.Point(796, 33);
            this.BtnRegistrarPedido.Name = "BtnRegistrarPedido";
            this.BtnRegistrarPedido.Size = new System.Drawing.Size(138, 50);
            this.BtnRegistrarPedido.TabIndex = 7;
            this.BtnRegistrarPedido.Text = "Registrar pedido";
            this.BtnRegistrarPedido.UseVisualStyleBackColor = true;
            this.BtnRegistrarPedido.Click += new System.EventHandler(this.BtnRegistrarPedido_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccionar tipo de producto :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(585, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Monto total a pagar :";
            // 
            // LblMontoAPagar
            // 
            this.LblMontoAPagar.AutoSize = true;
            this.LblMontoAPagar.Location = new System.Drawing.Point(710, 14);
            this.LblMontoAPagar.Name = "LblMontoAPagar";
            this.LblMontoAPagar.Size = new System.Drawing.Size(15, 16);
            this.LblMontoAPagar.TabIndex = 6;
            this.LblMontoAPagar.Text = "0";
            // 
            // BtnQuitarProducto
            // 
            this.BtnQuitarProducto.Location = new System.Drawing.Point(12, 14);
            this.BtnQuitarProducto.Name = "BtnQuitarProducto";
            this.BtnQuitarProducto.Size = new System.Drawing.Size(126, 33);
            this.BtnQuitarProducto.TabIndex = 9;
            this.BtnQuitarProducto.Text = "Quitar producto";
            this.BtnQuitarProducto.UseVisualStyleBackColor = true;
            this.BtnQuitarProducto.Click += new System.EventHandler(this.BtnQuitarProducto_Click);
            // 
            // DgvProductosProveedor
            // 
            this.DgvProductosProveedor.AllowUserToAddRows = false;
            this.DgvProductosProveedor.AllowUserToDeleteRows = false;
            this.DgvProductosProveedor.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvProductosProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductosProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Descripcion,
            this.Marca,
            this.RutProveedor,
            this.FechaDeVencimiento,
            this.PrecioDeCompra,
            this.Stock,
            this.Cantidad});
            this.DgvProductosProveedor.Location = new System.Drawing.Point(12, 53);
            this.DgvProductosProveedor.MultiSelect = false;
            this.DgvProductosProveedor.Name = "DgvProductosProveedor";
            this.DgvProductosProveedor.ReadOnly = true;
            this.DgvProductosProveedor.RowHeadersVisible = false;
            this.DgvProductosProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProductosProveedor.Size = new System.Drawing.Size(922, 203);
            this.DgvProductosProveedor.TabIndex = 8;
            this.DgvProductosProveedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProductosProveedor_CellClick);
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "Id producto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Producto";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // RutProveedor
            // 
            this.RutProveedor.HeaderText = "Proveedor";
            this.RutProveedor.Name = "RutProveedor";
            this.RutProveedor.ReadOnly = true;
            // 
            // FechaDeVencimiento
            // 
            this.FechaDeVencimiento.HeaderText = "Fecha de vencimiento";
            this.FechaDeVencimiento.Name = "FechaDeVencimiento";
            this.FechaDeVencimiento.ReadOnly = true;
            // 
            // PrecioDeCompra
            // 
            this.PrecioDeCompra.HeaderText = "Precio de compra";
            this.PrecioDeCompra.Name = "PrecioDeCompra";
            this.PrecioDeCompra.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // GenerarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(959, 459);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GenerarPedido";
            this.Text = "Generar pedido";
            this.Load += new System.EventHandler(this.GenerarPedido_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductosProveedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbProveedores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox CmbProductos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbTipoDeProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnRegistrarPedido;
        private System.Windows.Forms.DataGridView DgvProductosProveedor;
        private System.Windows.Forms.Button BtnQuitarProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn RutProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioDeCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblMontoAPagar;
        private System.Windows.Forms.TextBox TxtFechaDePedido;
        private System.Windows.Forms.Label label5;
    }
}