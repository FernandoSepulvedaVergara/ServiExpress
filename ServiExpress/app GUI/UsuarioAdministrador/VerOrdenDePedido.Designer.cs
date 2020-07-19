﻿namespace ServiExpress.app_GUI.UsuarioAdministrador
{
    partial class VerOrdenDePedido
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIdOrdenDePedido = new System.Windows.Forms.TextBox();
            this.DgvPedidos = new System.Windows.Forms.DataGridView();
            this.IdPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioDeCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAPagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDeVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtAdministrador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtEstado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbCambiarEstado = new System.Windows.Forms.ComboBox();
            this.LblActualizarEstado = new System.Windows.Forms.Label();
            this.TxtFechaDePedido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtProveedor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id orden de pedido :";
            // 
            // TxtIdOrdenDePedido
            // 
            this.TxtIdOrdenDePedido.Enabled = false;
            this.TxtIdOrdenDePedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdOrdenDePedido.Location = new System.Drawing.Point(146, 27);
            this.TxtIdOrdenDePedido.Name = "TxtIdOrdenDePedido";
            this.TxtIdOrdenDePedido.ReadOnly = true;
            this.TxtIdOrdenDePedido.Size = new System.Drawing.Size(114, 22);
            this.TxtIdOrdenDePedido.TabIndex = 1;
            // 
            // DgvPedidos
            // 
            this.DgvPedidos.AllowUserToAddRows = false;
            this.DgvPedidos.AllowUserToDeleteRows = false;
            this.DgvPedidos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPedido,
            this.Cantidad,
            this.PrecioDeCompra,
            this.TotalAPagar,
            this.IdProducto,
            this.Producto,
            this.Marca,
            this.FechaDeVencimiento});
            this.DgvPedidos.Location = new System.Drawing.Point(3, 3);
            this.DgvPedidos.Name = "DgvPedidos";
            this.DgvPedidos.ReadOnly = true;
            this.DgvPedidos.RowHeadersVisible = false;
            this.DgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPedidos.Size = new System.Drawing.Size(873, 229);
            this.DgvPedidos.TabIndex = 2;
            // 
            // IdPedido
            // 
            this.IdPedido.HeaderText = "Id pedido";
            this.IdPedido.Name = "IdPedido";
            this.IdPedido.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // PrecioDeCompra
            // 
            this.PrecioDeCompra.HeaderText = "Precio de compra";
            this.PrecioDeCompra.Name = "PrecioDeCompra";
            this.PrecioDeCompra.ReadOnly = true;
            // 
            // TotalAPagar
            // 
            this.TotalAPagar.HeaderText = "Total a pagar";
            this.TotalAPagar.Name = "TotalAPagar";
            this.TotalAPagar.ReadOnly = true;
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // FechaDeVencimiento
            // 
            this.FechaDeVencimiento.HeaderText = "Fecha de vencimiento";
            this.FechaDeVencimiento.Name = "FechaDeVencimiento";
            this.FechaDeVencimiento.ReadOnly = true;
            // 
            // TxtAdministrador
            // 
            this.TxtAdministrador.Enabled = false;
            this.TxtAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAdministrador.Location = new System.Drawing.Point(379, 55);
            this.TxtAdministrador.Name = "TxtAdministrador";
            this.TxtAdministrador.ReadOnly = true;
            this.TxtAdministrador.Size = new System.Drawing.Size(122, 22);
            this.TxtAdministrador.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Administrador :";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.Location = new System.Drawing.Point(146, 81);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(114, 22);
            this.TxtTotal.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total :";
            // 
            // TxtEstado
            // 
            this.TxtEstado.Enabled = false;
            this.TxtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEstado.Location = new System.Drawing.Point(379, 81);
            this.TxtEstado.Name = "TxtEstado";
            this.TxtEstado.ReadOnly = true;
            this.TxtEstado.Size = new System.Drawing.Size(122, 22);
            this.TxtEstado.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(316, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Estado :";
            // 
            // CmbCambiarEstado
            // 
            this.CmbCambiarEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCambiarEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCambiarEstado.FormattingEnabled = true;
            this.CmbCambiarEstado.Location = new System.Drawing.Point(676, 29);
            this.CmbCambiarEstado.Name = "CmbCambiarEstado";
            this.CmbCambiarEstado.Size = new System.Drawing.Size(138, 24);
            this.CmbCambiarEstado.TabIndex = 9;
            this.CmbCambiarEstado.SelectedIndexChanged += new System.EventHandler(this.CmbCambiarEstado_SelectedIndexChanged);
            // 
            // LblActualizarEstado
            // 
            this.LblActualizarEstado.AutoSize = true;
            this.LblActualizarEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblActualizarEstado.Location = new System.Drawing.Point(553, 32);
            this.LblActualizarEstado.Name = "LblActualizarEstado";
            this.LblActualizarEstado.Size = new System.Drawing.Size(117, 16);
            this.LblActualizarEstado.TabIndex = 10;
            this.LblActualizarEstado.Text = "Actualizar estado :";
            // 
            // TxtFechaDePedido
            // 
            this.TxtFechaDePedido.Enabled = false;
            this.TxtFechaDePedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFechaDePedido.Location = new System.Drawing.Point(146, 55);
            this.TxtFechaDePedido.Name = "TxtFechaDePedido";
            this.TxtFechaDePedido.ReadOnly = true;
            this.TxtFechaDePedido.Size = new System.Drawing.Size(114, 22);
            this.TxtFechaDePedido.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha de pedido :";
            // 
            // TxtProveedor
            // 
            this.TxtProveedor.Enabled = false;
            this.TxtProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProveedor.Location = new System.Drawing.Point(379, 29);
            this.TxtProveedor.Name = "TxtProveedor";
            this.TxtProveedor.ReadOnly = true;
            this.TxtProveedor.Size = new System.Drawing.Size(122, 22);
            this.TxtProveedor.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(295, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Proveedor :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DgvPedidos);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 248);
            this.panel1.TabIndex = 15;
            // 
            // VerOrdenDePedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(897, 367);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtProveedor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtFechaDePedido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblActualizarEstado);
            this.Controls.Add(this.CmbCambiarEstado);
            this.Controls.Add(this.TxtEstado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtAdministrador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtIdOrdenDePedido);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VerOrdenDePedido";
            this.Text = "VerOrdenDePedido";
            this.Load += new System.EventHandler(this.VerOrdenDePedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIdOrdenDePedido;
        private System.Windows.Forms.DataGridView DgvPedidos;
        private System.Windows.Forms.TextBox TxtAdministrador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbCambiarEstado;
        private System.Windows.Forms.Label LblActualizarEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioDeCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeVencimiento;
        private System.Windows.Forms.TextBox TxtFechaDePedido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtProveedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}