﻿namespace ServiExpress.app_GUI.UsuarioEmpleado
{
    partial class Ventas
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
            this.CmbFiltro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.DgvVentas = new System.Windows.Forms.DataGridView();
            this.EstadoDeVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoAPagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoPagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdAtencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtFiltro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbFiltro
            // 
            this.CmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFiltro.FormattingEnabled = true;
            this.CmbFiltro.Items.AddRange(new object[] {
            "Id venta",
            "Fecha venta",
            "Rut",
            "Patente"});
            this.CmbFiltro.Location = new System.Drawing.Point(151, 17);
            this.CmbFiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbFiltro.Name = "CmbFiltro";
            this.CmbFiltro.Size = new System.Drawing.Size(160, 24);
            this.CmbFiltro.TabIndex = 0;
            this.CmbFiltro.SelectedIndexChanged += new System.EventHandler(this.CmbFiltro_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtrar por :";
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.BackColor = System.Drawing.Color.Yellow;
            this.BtnFiltrar.Location = new System.Drawing.Point(355, 60);
            this.BtnFiltrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(184, 41);
            this.BtnFiltrar.TabIndex = 2;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = false;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // DgvVentas
            // 
            this.DgvVentas.AllowUserToAddRows = false;
            this.DgvVentas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EstadoDeVenta,
            this.IdVenta,
            this.Patente,
            this.MontoAPagar,
            this.MontoPagado,
            this.FechaVenta,
            this.Rut,
            this.IdAtencion,
            this.IdDocumento});
            this.DgvVentas.Location = new System.Drawing.Point(16, 130);
            this.DgvVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DgvVentas.MultiSelect = false;
            this.DgvVentas.Name = "DgvVentas";
            this.DgvVentas.ReadOnly = true;
            this.DgvVentas.RowHeadersVisible = false;
            this.DgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvVentas.Size = new System.Drawing.Size(930, 351);
            this.DgvVentas.TabIndex = 3;
            this.DgvVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVentas_CellClick);
            // 
            // EstadoDeVenta
            // 
            this.EstadoDeVenta.HeaderText = "Estado";
            this.EstadoDeVenta.Name = "EstadoDeVenta";
            this.EstadoDeVenta.ReadOnly = true;
            // 
            // IdVenta
            // 
            this.IdVenta.HeaderText = "Id venta";
            this.IdVenta.Name = "IdVenta";
            this.IdVenta.ReadOnly = true;
            // 
            // Patente
            // 
            this.Patente.HeaderText = "Patente";
            this.Patente.Name = "Patente";
            this.Patente.ReadOnly = true;
            // 
            // MontoAPagar
            // 
            this.MontoAPagar.HeaderText = "Monto a pagar";
            this.MontoAPagar.Name = "MontoAPagar";
            this.MontoAPagar.ReadOnly = true;
            // 
            // MontoPagado
            // 
            this.MontoPagado.HeaderText = "Monto pagado";
            this.MontoPagado.Name = "MontoPagado";
            this.MontoPagado.ReadOnly = true;
            // 
            // FechaVenta
            // 
            this.FechaVenta.HeaderText = "Fecha venta";
            this.FechaVenta.Name = "FechaVenta";
            this.FechaVenta.ReadOnly = true;
            // 
            // Rut
            // 
            this.Rut.HeaderText = "Rut";
            this.Rut.Name = "Rut";
            this.Rut.ReadOnly = true;
            // 
            // IdAtencion
            // 
            this.IdAtencion.HeaderText = "Id atención";
            this.IdAtencion.Name = "IdAtencion";
            this.IdAtencion.ReadOnly = true;
            // 
            // IdDocumento
            // 
            this.IdDocumento.HeaderText = "Documento";
            this.IdDocumento.Name = "IdDocumento";
            this.IdDocumento.ReadOnly = true;
            // 
            // TxtFiltro
            // 
            this.TxtFiltro.Location = new System.Drawing.Point(151, 75);
            this.TxtFiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtFiltro.Name = "TxtFiltro";
            this.TxtFiltro.Size = new System.Drawing.Size(160, 22);
            this.TxtFiltro.TabIndex = 4;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(176)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1032, 514);
            this.Controls.Add(this.TxtFiltro);
            this.Controls.Add(this.DgvVentas);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbFiltro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ventas";
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.DgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.DataGridView DgvVentas;
        private System.Windows.Forms.TextBox TxtFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoDeVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patente;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoAPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoPagado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rut;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAtencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDocumento;
    }
}