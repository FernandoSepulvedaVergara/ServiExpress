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
            this.TxtDescripcion.Location = new System.Drawing.Point(258, 118);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(246, 20);
            this.TxtDescripcion.TabIndex = 0;
            // 
            // BtnGuardarProducto
            // 
            this.BtnGuardarProducto.Location = new System.Drawing.Point(258, 324);
            this.BtnGuardarProducto.Name = "BtnGuardarProducto";
            this.BtnGuardarProducto.Size = new System.Drawing.Size(102, 38);
            this.BtnGuardarProducto.TabIndex = 1;
            this.BtnGuardarProducto.Text = "Guardar nuevo producto";
            this.BtnGuardarProducto.UseVisualStyleBackColor = true;
            this.BtnGuardarProducto.Click += new System.EventHandler(this.BtnGuardarProducto_Click);
            // 
            // CmbTipoDeProducto
            // 
            this.CmbTipoDeProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoDeProducto.FormattingEnabled = true;
            this.CmbTipoDeProducto.Location = new System.Drawing.Point(52, 57);
            this.CmbTipoDeProducto.Name = "CmbTipoDeProducto";
            this.CmbTipoDeProducto.Size = new System.Drawing.Size(258, 21);
            this.CmbTipoDeProducto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccionar tipo de producto :";
            // 
            // TxtMarca
            // 
            this.TxtMarca.Location = new System.Drawing.Point(258, 148);
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.Size = new System.Drawing.Size(246, 20);
            this.TxtMarca.TabIndex = 4;
            // 
            // TxtStock
            // 
            this.TxtStock.Location = new System.Drawing.Point(258, 244);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(131, 20);
            this.TxtStock.TabIndex = 7;
            // 
            // TxtPrecioDeCompra
            // 
            this.TxtPrecioDeCompra.Location = new System.Drawing.Point(258, 211);
            this.TxtPrecioDeCompra.Name = "TxtPrecioDeCompra";
            this.TxtPrecioDeCompra.Size = new System.Drawing.Size(131, 20);
            this.TxtPrecioDeCompra.TabIndex = 8;
            // 
            // TxtFechaDeVencimiento
            // 
            this.TxtFechaDeVencimiento.Location = new System.Drawing.Point(258, 179);
            this.TxtFechaDeVencimiento.Name = "TxtFechaDeVencimiento";
            this.TxtFechaDeVencimiento.Size = new System.Drawing.Size(131, 20);
            this.TxtFechaDeVencimiento.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Producto :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Marca :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fecha de vencimiento :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Precio de compra :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Stock inicial :";
            // 
            // AgregarNuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(598, 415);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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