namespace ServiExpress.app_GUI.UsuarioAdministrador
{
    partial class AdministrarProductos
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CmbProductos = new System.Windows.Forms.ComboBox();
            this.CmbSeleccionarProducto = new System.Windows.Forms.ComboBox();
            this.TxtStockCritico = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TxtProveedor = new System.Windows.Forms.TextBox();
            this.TxtOrdenDePedido = new System.Windows.Forms.TextBox();
            this.BtnGenerarPedido = new System.Windows.Forms.Button();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.TxtFechaDeVencimiento = new System.Windows.Forms.TextBox();
            this.TxtPrecioDeCompra = new System.Windows.Forms.TextBox();
            this.TxtPrecioDeVenta = new System.Windows.Forms.TextBox();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.TxtIdProducto = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.CmbProductos);
            this.splitContainer1.Panel1.Controls.Add(this.CmbSeleccionarProducto);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TxtStockCritico);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel2.Controls.Add(this.TxtProveedor);
            this.splitContainer1.Panel2.Controls.Add(this.TxtOrdenDePedido);
            this.splitContainer1.Panel2.Controls.Add(this.BtnGenerarPedido);
            this.splitContainer1.Panel2.Controls.Add(this.TxtDescripcion);
            this.splitContainer1.Panel2.Controls.Add(this.TxtMarca);
            this.splitContainer1.Panel2.Controls.Add(this.TxtFechaDeVencimiento);
            this.splitContainer1.Panel2.Controls.Add(this.TxtPrecioDeCompra);
            this.splitContainer1.Panel2.Controls.Add(this.TxtPrecioDeVenta);
            this.splitContainer1.Panel2.Controls.Add(this.TxtStock);
            this.splitContainer1.Panel2.Controls.Add(this.TxtIdProducto);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(962, 525);
            this.splitContainer1.SplitterDistance = 109;
            this.splitContainer1.TabIndex = 0;
            // 
            // CmbProductos
            // 
            this.CmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbProductos.FormattingEnabled = true;
            this.CmbProductos.Location = new System.Drawing.Point(36, 55);
            this.CmbProductos.Name = "CmbProductos";
            this.CmbProductos.Size = new System.Drawing.Size(284, 21);
            this.CmbProductos.TabIndex = 1;
            this.CmbProductos.SelectedIndexChanged += new System.EventHandler(this.CmbProductos_SelectedIndexChanged);
            // 
            // CmbSeleccionarProducto
            // 
            this.CmbSeleccionarProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSeleccionarProducto.FormattingEnabled = true;
            this.CmbSeleccionarProducto.Location = new System.Drawing.Point(36, 12);
            this.CmbSeleccionarProducto.Name = "CmbSeleccionarProducto";
            this.CmbSeleccionarProducto.Size = new System.Drawing.Size(284, 21);
            this.CmbSeleccionarProducto.TabIndex = 0;
            this.CmbSeleccionarProducto.SelectedIndexChanged += new System.EventHandler(this.CmbSeleccionarProducto_SelectedIndexChanged);
            // 
            // TxtStockCritico
            // 
            this.TxtStockCritico.Enabled = false;
            this.TxtStockCritico.Location = new System.Drawing.Point(482, 124);
            this.TxtStockCritico.Name = "TxtStockCritico";
            this.TxtStockCritico.ReadOnly = true;
            this.TxtStockCritico.Size = new System.Drawing.Size(100, 20);
            this.TxtStockCritico.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Red;
            this.pictureBox2.Location = new System.Drawing.Point(474, 115);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 37);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // TxtProveedor
            // 
            this.TxtProveedor.Enabled = false;
            this.TxtProveedor.Location = new System.Drawing.Point(482, 292);
            this.TxtProveedor.Name = "TxtProveedor";
            this.TxtProveedor.ReadOnly = true;
            this.TxtProveedor.Size = new System.Drawing.Size(100, 20);
            this.TxtProveedor.TabIndex = 10;
            // 
            // TxtOrdenDePedido
            // 
            this.TxtOrdenDePedido.Enabled = false;
            this.TxtOrdenDePedido.Location = new System.Drawing.Point(482, 250);
            this.TxtOrdenDePedido.Name = "TxtOrdenDePedido";
            this.TxtOrdenDePedido.ReadOnly = true;
            this.TxtOrdenDePedido.Size = new System.Drawing.Size(100, 20);
            this.TxtOrdenDePedido.TabIndex = 9;
            // 
            // BtnGenerarPedido
            // 
            this.BtnGenerarPedido.Location = new System.Drawing.Point(12, 167);
            this.BtnGenerarPedido.Name = "BtnGenerarPedido";
            this.BtnGenerarPedido.Size = new System.Drawing.Size(155, 50);
            this.BtnGenerarPedido.TabIndex = 8;
            this.BtnGenerarPedido.Text = "Generar pedido";
            this.BtnGenerarPedido.UseVisualStyleBackColor = true;
            this.BtnGenerarPedido.Click += new System.EventHandler(this.BtnGenerarPedido_Click);
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Enabled = false;
            this.TxtDescripcion.Location = new System.Drawing.Point(309, 124);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.ReadOnly = true;
            this.TxtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.TxtDescripcion.TabIndex = 7;
            // 
            // TxtMarca
            // 
            this.TxtMarca.Enabled = false;
            this.TxtMarca.Location = new System.Drawing.Point(309, 167);
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.ReadOnly = true;
            this.TxtMarca.Size = new System.Drawing.Size(100, 20);
            this.TxtMarca.TabIndex = 6;
            // 
            // TxtFechaDeVencimiento
            // 
            this.TxtFechaDeVencimiento.Enabled = false;
            this.TxtFechaDeVencimiento.Location = new System.Drawing.Point(309, 212);
            this.TxtFechaDeVencimiento.Name = "TxtFechaDeVencimiento";
            this.TxtFechaDeVencimiento.ReadOnly = true;
            this.TxtFechaDeVencimiento.Size = new System.Drawing.Size(100, 20);
            this.TxtFechaDeVencimiento.TabIndex = 5;
            // 
            // TxtPrecioDeCompra
            // 
            this.TxtPrecioDeCompra.Enabled = false;
            this.TxtPrecioDeCompra.Location = new System.Drawing.Point(482, 167);
            this.TxtPrecioDeCompra.Name = "TxtPrecioDeCompra";
            this.TxtPrecioDeCompra.ReadOnly = true;
            this.TxtPrecioDeCompra.Size = new System.Drawing.Size(100, 20);
            this.TxtPrecioDeCompra.TabIndex = 4;
            // 
            // TxtPrecioDeVenta
            // 
            this.TxtPrecioDeVenta.Enabled = false;
            this.TxtPrecioDeVenta.Location = new System.Drawing.Point(482, 212);
            this.TxtPrecioDeVenta.Name = "TxtPrecioDeVenta";
            this.TxtPrecioDeVenta.ReadOnly = true;
            this.TxtPrecioDeVenta.Size = new System.Drawing.Size(100, 20);
            this.TxtPrecioDeVenta.TabIndex = 3;
            // 
            // TxtStock
            // 
            this.TxtStock.Enabled = false;
            this.TxtStock.Location = new System.Drawing.Point(482, 77);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.ReadOnly = true;
            this.TxtStock.Size = new System.Drawing.Size(100, 20);
            this.TxtStock.TabIndex = 2;
            // 
            // TxtIdProducto
            // 
            this.TxtIdProducto.Enabled = false;
            this.TxtIdProducto.Location = new System.Drawing.Point(309, 77);
            this.TxtIdProducto.Name = "TxtIdProducto";
            this.TxtIdProducto.ReadOnly = true;
            this.TxtIdProducto.Size = new System.Drawing.Size(100, 20);
            this.TxtIdProducto.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Location = new System.Drawing.Point(474, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 37);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // AdministrarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(962, 525);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdministrarProductos";
            this.Text = "AdministrarProductos";
            this.Load += new System.EventHandler(this.AdministrarProductos_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox CmbSeleccionarProducto;
        private System.Windows.Forms.Button BtnGenerarPedido;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtMarca;
        private System.Windows.Forms.TextBox TxtFechaDeVencimiento;
        private System.Windows.Forms.TextBox TxtPrecioDeCompra;
        private System.Windows.Forms.TextBox TxtPrecioDeVenta;
        private System.Windows.Forms.TextBox TxtStock;
        private System.Windows.Forms.TextBox TxtIdProducto;
        private System.Windows.Forms.ComboBox CmbProductos;
        private System.Windows.Forms.TextBox TxtProveedor;
        private System.Windows.Forms.TextBox TxtOrdenDePedido;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtStockCritico;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}