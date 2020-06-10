namespace ServiExpress.app_GUI.UsuarioEmpleado
{
    partial class Reservaciones
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
            this.DgvReservaciones = new System.Windows.Forms.DataGridView();
            this.EstadoDeAtención = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RutCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdReservación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReservaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvReservaciones
            // 
            this.DgvReservaciones.AllowUserToAddRows = false;
            this.DgvReservaciones.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DgvReservaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvReservaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EstadoDeAtención,
            this.HoraReserva,
            this.FechaReserva,
            this.RutCliente,
            this.Patente,
            this.IdReservación,
            this.Sucursal});
            this.DgvReservaciones.Location = new System.Drawing.Point(10, 12);
            this.DgvReservaciones.MultiSelect = false;
            this.DgvReservaciones.Name = "DgvReservaciones";
            this.DgvReservaciones.ReadOnly = true;
            this.DgvReservaciones.RowHeadersVisible = false;
            this.DgvReservaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvReservaciones.Size = new System.Drawing.Size(780, 360);
            this.DgvReservaciones.TabIndex = 1;
            // 
            // EstadoDeAtención
            // 
            this.EstadoDeAtención.HeaderText = "Estado de atención";
            this.EstadoDeAtención.Name = "EstadoDeAtención";
            this.EstadoDeAtención.ReadOnly = true;
            // 
            // HoraReserva
            // 
            this.HoraReserva.HeaderText = "Hora de reservación";
            this.HoraReserva.Name = "HoraReserva";
            this.HoraReserva.ReadOnly = true;
            // 
            // FechaReserva
            // 
            this.FechaReserva.HeaderText = "Fecha de reservación";
            this.FechaReserva.Name = "FechaReserva";
            this.FechaReserva.ReadOnly = true;
            // 
            // RutCliente
            // 
            this.RutCliente.HeaderText = "Rut cliente";
            this.RutCliente.Name = "RutCliente";
            this.RutCliente.ReadOnly = true;
            // 
            // Patente
            // 
            this.Patente.HeaderText = "Patente";
            this.Patente.Name = "Patente";
            this.Patente.ReadOnly = true;
            // 
            // IdReservación
            // 
            this.IdReservación.HeaderText = "Id reservación";
            this.IdReservación.Name = "IdReservación";
            this.IdReservación.ReadOnly = true;
            // 
            // Sucursal
            // 
            this.Sucursal.HeaderText = "Sucursal";
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.ReadOnly = true;
            // 
            // Reservaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgvReservaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reservaciones";
            this.Text = "Reservaciones";
            this.Load += new System.EventHandler(this.Reservaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvReservaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvReservaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoDeAtención;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn RutCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdReservación;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sucursal;
    }
}