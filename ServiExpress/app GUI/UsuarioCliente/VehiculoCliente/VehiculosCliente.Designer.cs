namespace ServiExpress.app_GUI.Usuario1
{
    partial class VehiculosCliente
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
            this.DgvVehiculosCliente = new System.Windows.Forms.DataGridView();
            this.BtnAgregarVehiculo = new System.Windows.Forms.Button();
            this.Patente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_de_vehículo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVehiculosCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvVehiculosCliente
            // 
            this.DgvVehiculosCliente.AllowUserToAddRows = false;
            this.DgvVehiculosCliente.AllowUserToDeleteRows = false;
            this.DgvVehiculosCliente.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvVehiculosCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVehiculosCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Patente,
            this.Tipo_de_vehículo,
            this.Marca,
            this.Modelo,
            this.Año});
            this.DgvVehiculosCliente.Location = new System.Drawing.Point(180, 54);
            this.DgvVehiculosCliente.MultiSelect = false;
            this.DgvVehiculosCliente.Name = "DgvVehiculosCliente";
            this.DgvVehiculosCliente.ReadOnly = true;
            this.DgvVehiculosCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DgvVehiculosCliente.RowHeadersVisible = false;
            this.DgvVehiculosCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvVehiculosCliente.Size = new System.Drawing.Size(544, 384);
            this.DgvVehiculosCliente.TabIndex = 0;
            // 
            // BtnAgregarVehiculo
            // 
            this.BtnAgregarVehiculo.Location = new System.Drawing.Point(12, 54);
            this.BtnAgregarVehiculo.Name = "BtnAgregarVehiculo";
            this.BtnAgregarVehiculo.Size = new System.Drawing.Size(141, 39);
            this.BtnAgregarVehiculo.TabIndex = 1;
            this.BtnAgregarVehiculo.Text = "Agregar Vehículo";
            this.BtnAgregarVehiculo.UseVisualStyleBackColor = true;
            this.BtnAgregarVehiculo.Click += new System.EventHandler(this.BtnAgregarVehiculo_Click);
            // 
            // Patente
            // 
            this.Patente.HeaderText = "Patente";
            this.Patente.Name = "Patente";
            this.Patente.ReadOnly = true;
            // 
            // Tipo_de_vehículo
            // 
            this.Tipo_de_vehículo.HeaderText = "Tipo de vehículo";
            this.Tipo_de_vehículo.Name = "Tipo_de_vehículo";
            this.Tipo_de_vehículo.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // Año
            // 
            this.Año.HeaderText = "Año";
            this.Año.Name = "Año";
            this.Año.ReadOnly = true;
            // 
            // VehiculosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(176)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(812, 457);
            this.Controls.Add(this.BtnAgregarVehiculo);
            this.Controls.Add(this.DgvVehiculosCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VehiculosCliente";
            this.Text = "VehiculosCliente";
            this.Load += new System.EventHandler(this.VehiculosCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvVehiculosCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvVehiculosCliente;
        private System.Windows.Forms.Button BtnAgregarVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_de_vehículo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
    }
}