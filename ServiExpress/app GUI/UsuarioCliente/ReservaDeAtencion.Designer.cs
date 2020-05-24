namespace ServiExpress.app_GUI.Usuario1
{
    partial class ReservaDeAtencion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservaDeAtencion));
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.CmbSeleccionarHoras = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbSeleccionarServicios = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbSeleccionarVehículo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblVehículoSeleccionado = new System.Windows.Forms.Label();
            this.LblFechaSeleccionada = new System.Windows.Forms.Label();
            this.LblHoraSeleccionada = new System.Windows.Forms.Label();
            this.LblServicioSeleccionado = new System.Windows.Forms.Label();
            this.BtnReservarAtención = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.CmbSeleccionarSucursal = new System.Windows.Forms.ComboBox();
            this.LblSucursalSeleccionado = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnMaps = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.monthCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar.Location = new System.Drawing.Point(20, 330);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 2;
            this.monthCalendar.TabStop = false;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // CmbSeleccionarHoras
            // 
            this.CmbSeleccionarHoras.BackColor = System.Drawing.Color.White;
            this.CmbSeleccionarHoras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbSeleccionarHoras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSeleccionarHoras.FormattingEnabled = true;
            this.CmbSeleccionarHoras.Location = new System.Drawing.Point(226, 144);
            this.CmbSeleccionarHoras.Name = "CmbSeleccionarHoras";
            this.CmbSeleccionarHoras.Size = new System.Drawing.Size(107, 21);
            this.CmbSeleccionarHoras.TabIndex = 3;
            this.CmbSeleccionarHoras.SelectedIndexChanged += new System.EventHandler(this.CmbSeleccionarHoras_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccionar hora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Seleccionar servicio";
            // 
            // CmbSeleccionarServicios
            // 
            this.CmbSeleccionarServicios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbSeleccionarServicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSeleccionarServicios.FormattingEnabled = true;
            this.CmbSeleccionarServicios.Location = new System.Drawing.Point(18, 203);
            this.CmbSeleccionarServicios.Name = "CmbSeleccionarServicios";
            this.CmbSeleccionarServicios.Size = new System.Drawing.Size(315, 21);
            this.CmbSeleccionarServicios.TabIndex = 5;
            this.CmbSeleccionarServicios.SelectedIndexChanged += new System.EventHandler(this.CmbSeleccionarServicios_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Seleccionar vehículo";
            // 
            // CmbSeleccionarVehículo
            // 
            this.CmbSeleccionarVehículo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbSeleccionarVehículo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSeleccionarVehículo.FormattingEnabled = true;
            this.CmbSeleccionarVehículo.Location = new System.Drawing.Point(18, 144);
            this.CmbSeleccionarVehículo.Name = "CmbSeleccionarVehículo";
            this.CmbSeleccionarVehículo.Size = new System.Drawing.Size(156, 21);
            this.CmbSeleccionarVehículo.TabIndex = 7;
            this.CmbSeleccionarVehículo.SelectedIndexChanged += new System.EventHandler(this.CmbSeleccionarVehículo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(235, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Servicio: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(235, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Hora: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(235, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fecha: ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(235, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Vehículo: ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // LblVehículoSeleccionado
            // 
            this.LblVehículoSeleccionado.AutoSize = true;
            this.LblVehículoSeleccionado.Location = new System.Drawing.Point(376, 294);
            this.LblVehículoSeleccionado.Name = "LblVehículoSeleccionado";
            this.LblVehículoSeleccionado.Size = new System.Drawing.Size(0, 13);
            this.LblVehículoSeleccionado.TabIndex = 17;
            // 
            // LblFechaSeleccionada
            // 
            this.LblFechaSeleccionada.AutoSize = true;
            this.LblFechaSeleccionada.Location = new System.Drawing.Point(376, 223);
            this.LblFechaSeleccionada.Name = "LblFechaSeleccionada";
            this.LblFechaSeleccionada.Size = new System.Drawing.Size(0, 13);
            this.LblFechaSeleccionada.TabIndex = 16;
            // 
            // LblHoraSeleccionada
            // 
            this.LblHoraSeleccionada.AutoSize = true;
            this.LblHoraSeleccionada.Location = new System.Drawing.Point(376, 246);
            this.LblHoraSeleccionada.Name = "LblHoraSeleccionada";
            this.LblHoraSeleccionada.Size = new System.Drawing.Size(0, 13);
            this.LblHoraSeleccionada.TabIndex = 15;
            // 
            // LblServicioSeleccionado
            // 
            this.LblServicioSeleccionado.AutoSize = true;
            this.LblServicioSeleccionado.Location = new System.Drawing.Point(376, 268);
            this.LblServicioSeleccionado.Name = "LblServicioSeleccionado";
            this.LblServicioSeleccionado.Size = new System.Drawing.Size(0, 13);
            this.LblServicioSeleccionado.TabIndex = 14;
            // 
            // BtnReservarAtención
            // 
            this.BtnReservarAtención.BackColor = System.Drawing.Color.Yellow;
            this.BtnReservarAtención.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReservarAtención.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReservarAtención.Location = new System.Drawing.Point(455, 456);
            this.BtnReservarAtención.Name = "BtnReservarAtención";
            this.BtnReservarAtención.Size = new System.Drawing.Size(428, 65);
            this.BtnReservarAtención.TabIndex = 19;
            this.BtnReservarAtención.Text = "Reservar";
            this.BtnReservarAtención.UseVisualStyleBackColor = false;
            this.BtnReservarAtención.Click += new System.EventHandler(this.BtnReservarAtención_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Seleccionar sucursal";
            // 
            // CmbSeleccionarSucursal
            // 
            this.CmbSeleccionarSucursal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbSeleccionarSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSeleccionarSucursal.FormattingEnabled = true;
            this.CmbSeleccionarSucursal.Location = new System.Drawing.Point(18, 68);
            this.CmbSeleccionarSucursal.Name = "CmbSeleccionarSucursal";
            this.CmbSeleccionarSucursal.Size = new System.Drawing.Size(156, 21);
            this.CmbSeleccionarSucursal.TabIndex = 20;
            this.CmbSeleccionarSucursal.SelectedIndexChanged += new System.EventHandler(this.CmbSeleccionarSucursal_SelectedIndexChanged);
            // 
            // LblSucursalSeleccionado
            // 
            this.LblSucursalSeleccionado.AutoSize = true;
            this.LblSucursalSeleccionado.Location = new System.Drawing.Point(376, 317);
            this.LblSucursalSeleccionado.Name = "LblSucursalSeleccionado";
            this.LblSucursalSeleccionado.Size = new System.Drawing.Size(0, 13);
            this.LblSucursalSeleccionado.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(235, 449);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Sucursal: ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(265, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Selecciona el dia que deseas ser atendido";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnMaps
            // 
            this.btnMaps.BackColor = System.Drawing.Color.Lime;
            this.btnMaps.Location = new System.Drawing.Point(226, 62);
            this.btnMaps.Name = "btnMaps";
            this.btnMaps.Size = new System.Drawing.Size(107, 31);
            this.btnMaps.TabIndex = 31;
            this.btnMaps.Text = "Ver ubucacion";
            this.btnMaps.UseVisualStyleBackColor = false;
            this.btnMaps.Click += new System.EventHandler(this.btnMaps_Click);
            // 
            // ReservaDeAtencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 521);
            this.Controls.Add(this.btnMaps);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LblSucursalSeleccionado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CmbSeleccionarSucursal);
            this.Controls.Add(this.BtnReservarAtención);
            this.Controls.Add(this.LblVehículoSeleccionado);
            this.Controls.Add(this.LblFechaSeleccionada);
            this.Controls.Add(this.LblHoraSeleccionada);
            this.Controls.Add(this.LblServicioSeleccionado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbSeleccionarVehículo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbSeleccionarServicios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbSeleccionarHoras);
            this.Controls.Add(this.monthCalendar);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReservaDeAtencion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReservaDeAtencion";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.ReservaDeAtencion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.ComboBox CmbSeleccionarHoras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbSeleccionarServicios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbSeleccionarVehículo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblVehículoSeleccionado;
        private System.Windows.Forms.Label LblFechaSeleccionada;
        private System.Windows.Forms.Label LblHoraSeleccionada;
        private System.Windows.Forms.Label LblServicioSeleccionado;
        private System.Windows.Forms.Button BtnReservarAtención;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CmbSeleccionarSucursal;
        private System.Windows.Forms.Label LblSucursalSeleccionado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnMaps;
    }
}