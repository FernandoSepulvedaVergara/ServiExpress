namespace ServiExpress.app_GUI.UsuarioProveedor
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
            this.CmbProductosProveedor = new System.Windows.Forms.ComboBox();
            this.CmbSeleccionarTipoDeProducto = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.ChbEstadoDeProducto = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtIdProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPrecioDeCompra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtFechaDeVencimiento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtProveedor = new System.Windows.Forms.TextBox();
            this.BtnActualizarProducto = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtmGuardar = new System.Windows.Forms.Button();
            this.NumStock = new System.Windows.Forms.NumericUpDown();
            this.BtnAgregarNuevoProducto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumStock)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.BtnAgregarNuevoProducto);
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.CmbProductosProveedor);
            this.splitContainer1.Panel1.Controls.Add(this.CmbSeleccionarTipoDeProducto);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(996, 541);
            this.splitContainer1.SplitterDistance = 123;
            this.splitContainer1.TabIndex = 1;
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
            // CmbProductosProveedor
            // 
            this.CmbProductosProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbProductosProveedor.FormattingEnabled = true;
            this.CmbProductosProveedor.Location = new System.Drawing.Point(36, 75);
            this.CmbProductosProveedor.Name = "CmbProductosProveedor";
            this.CmbProductosProveedor.Size = new System.Drawing.Size(284, 21);
            this.CmbProductosProveedor.TabIndex = 1;
            this.CmbProductosProveedor.SelectedIndexChanged += new System.EventHandler(this.CmbProductosProveedor_SelectedIndexChanged);
            // 
            // CmbSeleccionarTipoDeProducto
            // 
            this.CmbSeleccionarTipoDeProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSeleccionarTipoDeProducto.FormattingEnabled = true;
            this.CmbSeleccionarTipoDeProducto.Location = new System.Drawing.Point(36, 28);
            this.CmbSeleccionarTipoDeProducto.Name = "CmbSeleccionarTipoDeProducto";
            this.CmbSeleccionarTipoDeProducto.Size = new System.Drawing.Size(284, 21);
            this.CmbSeleccionarTipoDeProducto.TabIndex = 0;
            this.CmbSeleccionarTipoDeProducto.SelectedIndexChanged += new System.EventHandler(this.CmbSeleccionarTipoDeProducto_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.NumStock);
            this.panel1.Controls.Add(this.BtmGuardar);
            this.panel1.Controls.Add(this.BtnCancelar);
            this.panel1.Controls.Add(this.BtnActualizarProducto);
            this.panel1.Controls.Add(this.TxtStock);
            this.panel1.Controls.Add(this.ChbEstadoDeProducto);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.TxtIdProducto);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TxtPrecioDeCompra);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TxtFechaDeVencimiento);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtMarca);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtDescripcion);
            this.panel1.Controls.Add(this.TxtProveedor);
            this.panel1.Location = new System.Drawing.Point(36, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 381);
            this.panel1.TabIndex = 25;
            this.panel1.Visible = false;
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
            this.ChbEstadoDeProducto.Location = new System.Drawing.Point(35, 33);
            this.ChbEstadoDeProducto.Name = "ChbEstadoDeProducto";
            this.ChbEstadoDeProducto.Size = new System.Drawing.Size(15, 14);
            this.ChbEstadoDeProducto.TabIndex = 24;
            this.ChbEstadoDeProducto.UseVisualStyleBackColor = true;
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
            this.label10.Location = new System.Drawing.Point(530, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Proveedor :";
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
            this.label7.Location = new System.Drawing.Point(530, 159);
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
            this.TxtPrecioDeCompra.Location = new System.Drawing.Point(662, 156);
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
            this.TxtFechaDeVencimiento.Size = new System.Drawing.Size(187, 20);
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
            // TxtProveedor
            // 
            this.TxtProveedor.Enabled = false;
            this.TxtProveedor.Location = new System.Drawing.Point(662, 199);
            this.TxtProveedor.Name = "TxtProveedor";
            this.TxtProveedor.ReadOnly = true;
            this.TxtProveedor.Size = new System.Drawing.Size(100, 20);
            this.TxtProveedor.TabIndex = 10;
            // 
            // BtnActualizarProducto
            // 
            this.BtnActualizarProducto.Location = new System.Drawing.Point(187, 17);
            this.BtnActualizarProducto.Name = "BtnActualizarProducto";
            this.BtnActualizarProducto.Size = new System.Drawing.Size(110, 45);
            this.BtnActualizarProducto.TabIndex = 28;
            this.BtnActualizarProducto.Text = "Actualizar producto";
            this.BtnActualizarProducto.UseVisualStyleBackColor = true;
            this.BtnActualizarProducto.Click += new System.EventHandler(this.BtnActualizarProducto_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(330, 17);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(110, 45);
            this.BtnCancelar.TabIndex = 29;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Visible = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtmGuardar
            // 
            this.BtmGuardar.Location = new System.Drawing.Point(470, 17);
            this.BtmGuardar.Name = "BtmGuardar";
            this.BtmGuardar.Size = new System.Drawing.Size(110, 45);
            this.BtmGuardar.TabIndex = 30;
            this.BtmGuardar.Text = "Guardar";
            this.BtmGuardar.UseVisualStyleBackColor = true;
            this.BtmGuardar.Visible = false;
            this.BtmGuardar.Click += new System.EventHandler(this.BtmGuardar_Click);
            // 
            // NumStock
            // 
            this.NumStock.Location = new System.Drawing.Point(662, 109);
            this.NumStock.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumStock.Name = "NumStock";
            this.NumStock.ReadOnly = true;
            this.NumStock.Size = new System.Drawing.Size(100, 20);
            this.NumStock.TabIndex = 31;
            this.NumStock.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumStock.Visible = false;
            // 
            // BtnAgregarNuevoProducto
            // 
            this.BtnAgregarNuevoProducto.Location = new System.Drawing.Point(790, 15);
            this.BtnAgregarNuevoProducto.Name = "BtnAgregarNuevoProducto";
            this.BtnAgregarNuevoProducto.Size = new System.Drawing.Size(143, 45);
            this.BtnAgregarNuevoProducto.TabIndex = 30;
            this.BtnAgregarNuevoProducto.Text = "Agregar nuevo producto";
            this.BtnAgregarNuevoProducto.UseVisualStyleBackColor = true;
            this.BtnAgregarNuevoProducto.Click += new System.EventHandler(this.BtnAgregarNuevoProducto_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(631, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 45);
            this.button1.TabIndex = 31;
            this.button1.Text = "Agregar nuevo tipo de producto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdministrarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(996, 541);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.NumStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CmbProductosProveedor;
        private System.Windows.Forms.ComboBox CmbSeleccionarTipoDeProducto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtStock;
        private System.Windows.Forms.CheckBox ChbEstadoDeProducto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtIdProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtPrecioDeCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtFechaDeVencimiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtProveedor;
        private System.Windows.Forms.Button BtnActualizarProducto;
        private System.Windows.Forms.Button BtmGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.NumericUpDown NumStock;
        private System.Windows.Forms.Button BtnAgregarNuevoProducto;
        private System.Windows.Forms.Button button1;
    }
}