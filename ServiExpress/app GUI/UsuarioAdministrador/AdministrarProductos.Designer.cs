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
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CmbProductos = new System.Windows.Forms.ComboBox();
            this.CmbSeleccionarProducto = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.ChbEstadoDeProducto = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtStockCritico = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtIdProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtPrecioDeVenta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPrecioDeCompra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtFechaDeVencimiento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtOrdenDePedido = new System.Windows.Forms.TextBox();
            this.TxtProveedor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.CmbProductos);
            this.splitContainer1.Panel1.Controls.Add(this.CmbSeleccionarProducto);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(962, 525);
            this.splitContainer1.SplitterDistance = 120;
            this.splitContainer1.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Seleccionar producto :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Seleccionar tipo de producto :";
            // 
            // CmbProductos
            // 
            this.CmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbProductos.FormattingEnabled = true;
            this.CmbProductos.Location = new System.Drawing.Point(36, 75);
            this.CmbProductos.Name = "CmbProductos";
            this.CmbProductos.Size = new System.Drawing.Size(284, 21);
            this.CmbProductos.TabIndex = 1;
            this.CmbProductos.SelectedIndexChanged += new System.EventHandler(this.CmbProductos_SelectedIndexChanged);
            // 
            // CmbSeleccionarProducto
            // 
            this.CmbSeleccionarProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSeleccionarProducto.FormattingEnabled = true;
            this.CmbSeleccionarProducto.Location = new System.Drawing.Point(36, 28);
            this.CmbSeleccionarProducto.Name = "CmbSeleccionarProducto";
            this.CmbSeleccionarProducto.Size = new System.Drawing.Size(284, 21);
            this.CmbSeleccionarProducto.TabIndex = 0;
            this.CmbSeleccionarProducto.SelectedIndexChanged += new System.EventHandler(this.CmbSeleccionarProducto_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.TxtStock);
            this.panel1.Controls.Add(this.ChbEstadoDeProducto);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.TxtStockCritico);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.TxtIdProducto);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TxtPrecioDeVenta);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TxtPrecioDeCompra);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TxtFechaDeVencimiento);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtMarca);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtDescripcion);
            this.panel1.Controls.Add(this.TxtOrdenDePedido);
            this.panel1.Controls.Add(this.TxtProveedor);
            this.panel1.Location = new System.Drawing.Point(36, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 381);
            this.panel1.TabIndex = 25;
            this.panel1.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Actualizar estado de producto";
            // 
            // TxtStock
            // 
            this.TxtStock.Enabled = false;
            this.TxtStock.Location = new System.Drawing.Point(662, 109);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.ReadOnly = true;
            this.TxtStock.Size = new System.Drawing.Size(100, 20);
            this.TxtStock.TabIndex = 2;
            // 
            // ChbEstadoDeProducto
            // 
            this.ChbEstadoDeProducto.AutoCheck = false;
            this.ChbEstadoDeProducto.AutoSize = true;
            this.ChbEstadoDeProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChbEstadoDeProducto.Location = new System.Drawing.Point(36, 33);
            this.ChbEstadoDeProducto.Name = "ChbEstadoDeProducto";
            this.ChbEstadoDeProducto.Size = new System.Drawing.Size(15, 14);
            this.ChbEstadoDeProducto.TabIndex = 24;
            this.ChbEstadoDeProducto.UseVisualStyleBackColor = true;
            this.ChbEstadoDeProducto.CheckedChanged += new System.EventHandler(this.ChbEstadoDeProducto_CheckedChanged);
            this.ChbEstadoDeProducto.Click += new System.EventHandler(this.ChbEstadoDeProducto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Location = new System.Drawing.Point(654, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 37);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(530, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Proveedor :";
            // 
            // TxtStockCritico
            // 
            this.TxtStockCritico.Enabled = false;
            this.TxtStockCritico.Location = new System.Drawing.Point(662, 154);
            this.TxtStockCritico.Name = "TxtStockCritico";
            this.TxtStockCritico.ReadOnly = true;
            this.TxtStockCritico.Size = new System.Drawing.Size(100, 20);
            this.TxtStockCritico.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(530, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Id orden de pedido :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Red;
            this.pictureBox2.Location = new System.Drawing.Point(654, 145);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 37);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(530, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Precio de venta :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Id producto :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(530, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Precio de compra :";
            // 
            // TxtIdProducto
            // 
            this.TxtIdProducto.Enabled = false;
            this.TxtIdProducto.Location = new System.Drawing.Point(157, 109);
            this.TxtIdProducto.Name = "TxtIdProducto";
            this.TxtIdProducto.ReadOnly = true;
            this.TxtIdProducto.Size = new System.Drawing.Size(100, 20);
            this.TxtIdProducto.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(530, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Stock crítico :";
            // 
            // TxtPrecioDeVenta
            // 
            this.TxtPrecioDeVenta.Enabled = false;
            this.TxtPrecioDeVenta.Location = new System.Drawing.Point(662, 244);
            this.TxtPrecioDeVenta.Name = "TxtPrecioDeVenta";
            this.TxtPrecioDeVenta.ReadOnly = true;
            this.TxtPrecioDeVenta.Size = new System.Drawing.Size(100, 20);
            this.TxtPrecioDeVenta.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(530, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Stock :";
            // 
            // TxtPrecioDeCompra
            // 
            this.TxtPrecioDeCompra.Enabled = false;
            this.TxtPrecioDeCompra.Location = new System.Drawing.Point(662, 199);
            this.TxtPrecioDeCompra.Name = "TxtPrecioDeCompra";
            this.TxtPrecioDeCompra.ReadOnly = true;
            this.TxtPrecioDeCompra.Size = new System.Drawing.Size(100, 20);
            this.TxtPrecioDeCompra.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Fecha de vencimiento :";
            // 
            // TxtFechaDeVencimiento
            // 
            this.TxtFechaDeVencimiento.Enabled = false;
            this.TxtFechaDeVencimiento.Location = new System.Drawing.Point(157, 244);
            this.TxtFechaDeVencimiento.Name = "TxtFechaDeVencimiento";
            this.TxtFechaDeVencimiento.ReadOnly = true;
            this.TxtFechaDeVencimiento.Size = new System.Drawing.Size(100, 20);
            this.TxtFechaDeVencimiento.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Marca :";
            // 
            // TxtMarca
            // 
            this.TxtMarca.Enabled = false;
            this.TxtMarca.Location = new System.Drawing.Point(157, 199);
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.ReadOnly = true;
            this.TxtMarca.Size = new System.Drawing.Size(187, 20);
            this.TxtMarca.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Producto :";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Enabled = false;
            this.TxtDescripcion.Location = new System.Drawing.Point(157, 156);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.ReadOnly = true;
            this.TxtDescripcion.Size = new System.Drawing.Size(304, 20);
            this.TxtDescripcion.TabIndex = 7;
            // 
            // TxtOrdenDePedido
            // 
            this.TxtOrdenDePedido.Enabled = false;
            this.TxtOrdenDePedido.Location = new System.Drawing.Point(662, 280);
            this.TxtOrdenDePedido.Name = "TxtOrdenDePedido";
            this.TxtOrdenDePedido.ReadOnly = true;
            this.TxtOrdenDePedido.Size = new System.Drawing.Size(100, 20);
            this.TxtOrdenDePedido.TabIndex = 9;
            // 
            // TxtProveedor
            // 
            this.TxtProveedor.Enabled = false;
            this.TxtProveedor.Location = new System.Drawing.Point(662, 322);
            this.TxtProveedor.Name = "TxtProveedor";
            this.TxtProveedor.ReadOnly = true;
            this.TxtProveedor.Size = new System.Drawing.Size(100, 20);
            this.TxtProveedor.TabIndex = 10;
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
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox CmbSeleccionarProducto;
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
        private System.Windows.Forms.CheckBox ChbEstadoDeProducto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
    }
}