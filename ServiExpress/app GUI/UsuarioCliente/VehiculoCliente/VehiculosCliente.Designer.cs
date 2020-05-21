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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Patente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_de_vehículo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_de_motor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_de_chasis = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Numero_de_motor,
            this.Numero_de_chasis});
            this.DgvVehiculosCliente.Location = new System.Drawing.Point(159, 54);
            this.DgvVehiculosCliente.MultiSelect = false;
            this.DgvVehiculosCliente.Name = "DgvVehiculosCliente";
            this.DgvVehiculosCliente.ReadOnly = true;
            this.DgvVehiculosCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 144);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 39);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Patente
            // 
            this.Patente.HeaderText = "Patente";
            this.Patente.Name = "Patente";
            this.Patente.ReadOnly = true;
            // 
            // Tipo_de_vehículo
            // 
            this.Tipo_de_vehículo.HeaderText = "Tipo_de_vehículo";
            this.Tipo_de_vehículo.Name = "Tipo_de_vehículo";
            this.Tipo_de_vehículo.ReadOnly = true;
            // 
            // Numero_de_motor
            // 
            this.Numero_de_motor.HeaderText = "Numero_de_motor";
            this.Numero_de_motor.Name = "Numero_de_motor";
            this.Numero_de_motor.ReadOnly = true;
            // 
            // Numero_de_chasis
            // 
            this.Numero_de_chasis.HeaderText = "Numero_de_chasis";
            this.Numero_de_chasis.Name = "Numero_de_chasis";
            this.Numero_de_chasis.ReadOnly = true;
            // 
            // VehiculosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_de_vehículo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_de_motor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_de_chasis;
    }
}