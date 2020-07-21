namespace ServiExpress.app_GUI.UsuarioAdministrador
{
    partial class AdministrarSucursales
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
            this.DgvSucursales = new System.Windows.Forms.DataGridView();
            this.IdSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIreccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAgregarSucursal = new System.Windows.Forms.Button();
            this.BtnEliminarSucursal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSucursales)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvSucursales
            // 
            this.DgvSucursales.AllowUserToAddRows = false;
            this.DgvSucursales.AllowUserToDeleteRows = false;
            this.DgvSucursales.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSucursales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdSucursal,
            this.Sucursal,
            this.DIreccion});
            this.DgvSucursales.Location = new System.Drawing.Point(84, 128);
            this.DgvSucursales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DgvSucursales.MultiSelect = false;
            this.DgvSucursales.Name = "DgvSucursales";
            this.DgvSucursales.ReadOnly = true;
            this.DgvSucursales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DgvSucursales.RowHeadersVisible = false;
            this.DgvSucursales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSucursales.Size = new System.Drawing.Size(483, 257);
            this.DgvSucursales.TabIndex = 1;
            // 
            // IdSucursal
            // 
            this.IdSucursal.HeaderText = "Id sucursal";
            this.IdSucursal.Name = "IdSucursal";
            this.IdSucursal.ReadOnly = true;
            // 
            // Sucursal
            // 
            this.Sucursal.HeaderText = "Sucursal";
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.ReadOnly = true;
            // 
            // DIreccion
            // 
            this.DIreccion.HeaderText = "Dirección";
            this.DIreccion.Name = "DIreccion";
            this.DIreccion.ReadOnly = true;
            // 
            // BtnAgregarSucursal
            // 
            this.BtnAgregarSucursal.Location = new System.Drawing.Point(84, 73);
            this.BtnAgregarSucursal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnAgregarSucursal.Name = "BtnAgregarSucursal";
            this.BtnAgregarSucursal.Size = new System.Drawing.Size(129, 28);
            this.BtnAgregarSucursal.TabIndex = 2;
            this.BtnAgregarSucursal.Text = "Agregar sucursal";
            this.BtnAgregarSucursal.UseVisualStyleBackColor = true;
            this.BtnAgregarSucursal.Click += new System.EventHandler(this.BtnAgregarSucursal_Click);
            // 
            // BtnEliminarSucursal
            // 
            this.BtnEliminarSucursal.Location = new System.Drawing.Point(275, 73);
            this.BtnEliminarSucursal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnEliminarSucursal.Name = "BtnEliminarSucursal";
            this.BtnEliminarSucursal.Size = new System.Drawing.Size(120, 28);
            this.BtnEliminarSucursal.TabIndex = 3;
            this.BtnEliminarSucursal.Text = "Eliminar sucursal";
            this.BtnEliminarSucursal.UseVisualStyleBackColor = true;
            this.BtnEliminarSucursal.Click += new System.EventHandler(this.BtnEliminarSucursal_Click);
            // 
            // AdministrarSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(730, 460);
            this.Controls.Add(this.BtnEliminarSucursal);
            this.Controls.Add(this.BtnAgregarSucursal);
            this.Controls.Add(this.DgvSucursales);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdministrarSucursales";
            this.Text = "AdministrarSucursales";
            this.Load += new System.EventHandler(this.AdministrarSucursales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSucursales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvSucursales;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIreccion;
        private System.Windows.Forms.Button BtnAgregarSucursal;
        private System.Windows.Forms.Button BtnEliminarSucursal;
    }
}