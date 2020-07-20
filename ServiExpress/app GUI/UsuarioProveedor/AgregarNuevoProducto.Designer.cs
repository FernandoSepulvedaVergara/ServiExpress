namespace ServiExpress.app_GUI.UsuarioProveedor
{
    partial class AgregarNuevoProducto
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
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.BtnGuardarProducto = new System.Windows.Forms.Button();
            this.CmbTipoDeProducto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.TxtPrecioDeCompra = new System.Windows.Forms.TextBox();
            this.TxtFechaDeVencimiento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(344, 145);
            this.TxtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(327, 22);
            this.TxtDescripcion.TabIndex = 0;
            this.TxtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDescripcion_KeyPress);
            // 
            // BtnGuardarProducto
            // 
            this.BtnGuardarProducto.Location = new System.Drawing.Point(344, 399);
            this.BtnGuardarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGuardarProducto.Name = "BtnGuardarProducto";
            this.BtnGuardarProducto.Size = new System.Drawing.Size(136, 47);
            this.BtnGuardarProducto.TabIndex = 1;
            this.BtnGuardarProducto.Text = "Guardar nuevo producto";
            this.BtnGuardarProducto.UseVisualStyleBackColor = true;
            this.BtnGuardarProducto.Click += new System.EventHandler(this.BtnGuardarProducto_Click);
            // 
            // CmbTipoDeProducto
            // 
            this.CmbTipoDeProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoDeProducto.FormattingEnabled = true;
            this.CmbTipoDeProducto.Location = new System.Drawing.Point(69, 70);
            this.CmbTipoDeProducto.Margin = new System.Windows.Forms.Padding(4);
            this.CmbTipoDeProducto.Name = "CmbTipoDeProducto";
            this.CmbTipoDeProducto.Size = new System.Drawing.Size(343, 24);
            this.CmbTipoDeProducto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccionar tipo de producto :";
            // 
            // TxtMarca
            // 
            this.TxtMarca.Location = new System.Drawing.Point(344, 182);
            this.TxtMarca.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.Size = new System.Drawing.Size(327, 22);
            this.TxtMarca.TabIndex = 4;
            this.TxtMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDescripcion_KeyPress);
            // 
            // TxtStock
            // 
            this.TxtStock.Location = new System.Drawing.Point(344, 300);
            this.TxtStock.Margin = new System.Windows.Forms.Padding(4);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(173, 22);
            this.TxtStock.TabIndex = 7;
            this.TxtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtStock_KeyPress);
            // 
            // TxtPrecioDeCompra
            // 
            this.TxtPrecioDeCompra.Location = new System.Drawing.Point(344, 260);
            this.TxtPrecioDeCompra.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPrecioDeCompra.Name = "TxtPrecioDeCompra";
            this.TxtPrecioDeCompra.Size = new System.Drawing.Size(173, 22);
            this.TxtPrecioDeCompra.TabIndex = 8;
            this.TxtPrecioDeCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtStock_KeyPress);
            // 
            // TxtFechaDeVencimiento
            // 
            this.TxtFechaDeVencimiento.Location = new System.Drawing.Point(344, 220);
            this.TxtFechaDeVencimiento.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFechaDeVencimiento.MaxLength = 8;
            this.TxtFechaDeVencimiento.Name = "TxtFechaDeVencimiento";
            this.TxtFechaDeVencimiento.Size = new System.Drawing.Size(173, 22);
            this.TxtFechaDeVencimiento.TabIndex = 9;
            this.TxtFechaDeVencimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFechaDeVencimiento_KeyPress);
            this.TxtFechaDeVencimiento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtFechaDeVencimiento_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Producto :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Marca :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fecha de vencimiento :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 263);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Precio de compra :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 300);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Stock inicial :";
            // 
            // AgregarNuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(797, 511);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtFechaDeVencimiento);
            this.Controls.Add(this.TxtPrecioDeCompra);
            this.Controls.Add(this.TxtStock);
            this.Controls.Add(this.TxtMarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbTipoDeProducto);
            this.Controls.Add(this.BtnGuardarProducto);
            this.Controls.Add(this.TxtDescripcion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarNuevoProducto";
            this.Text = "Nuevo producto";
            this.Load += new System.EventHandler(this.AgregarNuevoProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Button BtnGuardarProducto;
        private System.Windows.Forms.ComboBox CmbTipoDeProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtMarca;
        private System.Windows.Forms.TextBox TxtStock;
        private System.Windows.Forms.TextBox TxtPrecioDeCompra;
        private System.Windows.Forms.TextBox TxtFechaDeVencimiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}