namespace ServiExpress.app_GUI.UsuarioCliente
{
    partial class GlosarioDePagos
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
            this.DgvVentas = new System.Windows.Forms.DataGridView();
            this.Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoAPagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoPagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdAtencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvVentas
            // 
            this.DgvVentas.AllowUserToAddRows = false;
            this.DgvVentas.AllowUserToDeleteRows = false;
            this.DgvVentas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Venta,
            this.MontoAPagar,
            this.MontoPagado,
            this.Fecha,
            this.IdEstado,
            this.IdAtencion});
            this.DgvVentas.Location = new System.Drawing.Point(119, 67);
            this.DgvVentas.MultiSelect = false;
            this.DgvVentas.Name = "DgvVentas";
            this.DgvVentas.ReadOnly = true;
            this.DgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvVentas.Size = new System.Drawing.Size(643, 219);
            this.DgvVentas.TabIndex = 0;
            // 
            // Venta
            // 
            this.Venta.HeaderText = "Venta";
            this.Venta.Name = "Venta";
            this.Venta.ReadOnly = true;
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
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // IdEstado
            // 
            this.IdEstado.HeaderText = "Estado";
            this.IdEstado.Name = "IdEstado";
            this.IdEstado.ReadOnly = true;
            // 
            // IdAtencion
            // 
            this.IdAtencion.HeaderText = "Id atención";
            this.IdAtencion.Name = "IdAtencion";
            this.IdAtencion.ReadOnly = true;
            // 
            // BtnExportar
            // 
            this.BtnExportar.Location = new System.Drawing.Point(12, 67);
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.Size = new System.Drawing.Size(101, 39);
            this.BtnExportar.TabIndex = 1;
            this.BtnExportar.Text = "Exportar";
            this.BtnExportar.UseVisualStyleBackColor = true;
            // 
            // GlosarioDePagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnExportar);
            this.Controls.Add(this.DgvVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GlosarioDePagos";
            this.Text = "GlosarioDePagos";
            this.Load += new System.EventHandler(this.GlosarioDePagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoAPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoPagado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAtencion;
        private System.Windows.Forms.Button BtnExportar;
    }
}