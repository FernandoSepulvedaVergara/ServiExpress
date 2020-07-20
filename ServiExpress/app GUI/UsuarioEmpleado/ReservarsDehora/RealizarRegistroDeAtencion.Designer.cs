namespace ServiExpress.app_GUI.UsuarioEmpleado.ReservarsDehora
{
    partial class RealizarRegistroDeAtencion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnRegistrarAtencion = new System.Windows.Forms.Button();
            this.BtnCancelarAtencion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtRutCliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.CmbTipoDeDocumento = new System.Windows.Forms.ComboBox();
            this.BtnQuitarProducto = new System.Windows.Forms.Button();
            this.LblMontoTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DgvProductos = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_de_vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbProductos = new System.Windows.Forms.ComboBox();
            this.CmbTipoDeProducto = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbTipoDeServicios = new System.Windows.Forms.ComboBox();
            this.TxtIdReservaDeAtencion = new System.Windows.Forms.TextBox();
            this.TxtHoraAtencion = new System.Windows.Forms.TextBox();
            this.TxtFechaAtencion = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRegistrarAtencion
            // 
            this.BtnRegistrarAtencion.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnRegistrarAtencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrarAtencion.Location = new System.Drawing.Point(816, 47);
            this.BtnRegistrarAtencion.Name = "BtnRegistrarAtencion";
            this.BtnRegistrarAtencion.Size = new System.Drawing.Size(131, 58);
            this.BtnRegistrarAtencion.TabIndex = 1;
            this.BtnRegistrarAtencion.Text = "Registrar atención";
            this.BtnRegistrarAtencion.UseVisualStyleBackColor = false;
            this.BtnRegistrarAtencion.Click += new System.EventHandler(this.BtnRegistrarAtencion_Click);
            // 
            // BtnCancelarAtencion
            // 
            this.BtnCancelarAtencion.BackColor = System.Drawing.Color.Gold;
            this.BtnCancelarAtencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarAtencion.Location = new System.Drawing.Point(816, 145);
            this.BtnCancelarAtencion.Name = "BtnCancelarAtencion";
            this.BtnCancelarAtencion.Size = new System.Drawing.Size(131, 58);
            this.BtnCancelarAtencion.TabIndex = 2;
            this.BtnCancelarAtencion.Text = "Cancelar atención";
            this.BtnCancelarAtencion.UseVisualStyleBackColor = false;
            this.BtnCancelarAtencion.Click += new System.EventHandler(this.BtnCancelarAtencion_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.TxtRutCliente);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CmbTipoDeServicios);
            this.panel1.Controls.Add(this.TxtIdReservaDeAtencion);
            this.panel1.Controls.Add(this.TxtHoraAtencion);
            this.panel1.Controls.Add(this.TxtFechaAtencion);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(29, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 595);
            this.panel1.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(92, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Rut cliente :";
            // 
            // TxtRutCliente
            // 
            this.TxtRutCliente.Enabled = false;
            this.TxtRutCliente.Location = new System.Drawing.Point(179, 47);
            this.TxtRutCliente.Name = "TxtRutCliente";
            this.TxtRutCliente.Size = new System.Drawing.Size(159, 22);
            this.TxtRutCliente.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(244, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Información de atención";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.CmbTipoDeDocumento);
            this.panel2.Controls.Add(this.BtnQuitarProducto);
            this.panel2.Controls.Add(this.LblMontoTotal);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.DgvProductos);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.CmbProductos);
            this.panel2.Controls.Add(this.CmbTipoDeProducto);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(769, 415);
            this.panel2.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Tipo de documento";
            // 
            // CmbTipoDeDocumento
            // 
            this.CmbTipoDeDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoDeDocumento.FormattingEnabled = true;
            this.CmbTipoDeDocumento.Location = new System.Drawing.Point(23, 61);
            this.CmbTipoDeDocumento.Name = "CmbTipoDeDocumento";
            this.CmbTipoDeDocumento.Size = new System.Drawing.Size(401, 24);
            this.CmbTipoDeDocumento.TabIndex = 17;
            // 
            // BtnQuitarProducto
            // 
            this.BtnQuitarProducto.Location = new System.Drawing.Point(3, 179);
            this.BtnQuitarProducto.Name = "BtnQuitarProducto";
            this.BtnQuitarProducto.Size = new System.Drawing.Size(120, 26);
            this.BtnQuitarProducto.TabIndex = 5;
            this.BtnQuitarProducto.Text = "Quitar producto";
            this.BtnQuitarProducto.UseVisualStyleBackColor = true;
            this.BtnQuitarProducto.Click += new System.EventHandler(this.BtnQuitarProducto_Click);
            // 
            // LblMontoTotal
            // 
            this.LblMontoTotal.AutoSize = true;
            this.LblMontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMontoTotal.Location = new System.Drawing.Point(631, 72);
            this.LblMontoTotal.Name = "LblMontoTotal";
            this.LblMontoTotal.Size = new System.Drawing.Size(18, 20);
            this.LblMontoTotal.TabIndex = 16;
            this.LblMontoTotal.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(508, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Monto a pagar :";
            // 
            // DgvProductos
            // 
            this.DgvProductos.AllowUserToAddRows = false;
            this.DgvProductos.AllowUserToDeleteRows = false;
            this.DgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvProductos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Descripcion,
            this.Marca,
            this.Fecha_de_vencimiento,
            this.Precio_unitario,
            this.Stock,
            this.Cantidad});
            this.DgvProductos.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvProductos.EnableHeadersVisualStyles = false;
            this.DgvProductos.Location = new System.Drawing.Point(3, 211);
            this.DgvProductos.MultiSelect = false;
            this.DgvProductos.Name = "DgvProductos";
            this.DgvProductos.ReadOnly = true;
            this.DgvProductos.RowHeadersVisible = false;
            this.DgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProductos.Size = new System.Drawing.Size(746, 161);
            this.DgvProductos.TabIndex = 9;
            this.DgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProductos_CellClick);
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "Id producto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Width = 92;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 105;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Width = 71;
            // 
            // Fecha_de_vencimiento
            // 
            this.Fecha_de_vencimiento.HeaderText = "Fecha de vencimiento";
            this.Fecha_de_vencimiento.Name = "Fecha_de_vencimiento";
            this.Fecha_de_vencimiento.ReadOnly = true;
            this.Fecha_de_vencimiento.Width = 150;
            // 
            // Precio_unitario
            // 
            this.Precio_unitario.HeaderText = "Precio unitario";
            this.Precio_unitario.Name = "Precio_unitario";
            this.Precio_unitario.ReadOnly = true;
            this.Precio_unitario.Width = 108;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 67;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 87;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(261, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Agregar productos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tipo de producto";
            // 
            // CmbProductos
            // 
            this.CmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbProductos.FormattingEnabled = true;
            this.CmbProductos.Location = new System.Drawing.Point(24, 141);
            this.CmbProductos.Name = "CmbProductos";
            this.CmbProductos.Size = new System.Drawing.Size(400, 24);
            this.CmbProductos.TabIndex = 11;
            this.CmbProductos.SelectedIndexChanged += new System.EventHandler(this.CmbProductos_SelectedIndexChanged);
            // 
            // CmbTipoDeProducto
            // 
            this.CmbTipoDeProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoDeProducto.FormattingEnabled = true;
            this.CmbTipoDeProducto.Location = new System.Drawing.Point(23, 101);
            this.CmbTipoDeProducto.Name = "CmbTipoDeProducto";
            this.CmbTipoDeProducto.Size = new System.Drawing.Size(401, 24);
            this.CmbTipoDeProducto.TabIndex = 10;
            this.CmbTipoDeProducto.SelectedIndexChanged += new System.EventHandler(this.CmbTipoDeProducto_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha de atención :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hora de atención :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Servicio realizado :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id reserva de atención :";
            // 
            // CmbTipoDeServicios
            // 
            this.CmbTipoDeServicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoDeServicios.FormattingEnabled = true;
            this.CmbTipoDeServicios.Location = new System.Drawing.Point(179, 125);
            this.CmbTipoDeServicios.Name = "CmbTipoDeServicios";
            this.CmbTipoDeServicios.Size = new System.Drawing.Size(360, 24);
            this.CmbTipoDeServicios.TabIndex = 3;
            // 
            // TxtIdReservaDeAtencion
            // 
            this.TxtIdReservaDeAtencion.Enabled = false;
            this.TxtIdReservaDeAtencion.Location = new System.Drawing.Point(179, 155);
            this.TxtIdReservaDeAtencion.Name = "TxtIdReservaDeAtencion";
            this.TxtIdReservaDeAtencion.Size = new System.Drawing.Size(159, 22);
            this.TxtIdReservaDeAtencion.TabIndex = 2;
            // 
            // TxtHoraAtencion
            // 
            this.TxtHoraAtencion.Enabled = false;
            this.TxtHoraAtencion.Location = new System.Drawing.Point(179, 99);
            this.TxtHoraAtencion.Name = "TxtHoraAtencion";
            this.TxtHoraAtencion.Size = new System.Drawing.Size(119, 22);
            this.TxtHoraAtencion.TabIndex = 1;
            // 
            // TxtFechaAtencion
            // 
            this.TxtFechaAtencion.Enabled = false;
            this.TxtFechaAtencion.Location = new System.Drawing.Point(179, 73);
            this.TxtFechaAtencion.Name = "TxtFechaAtencion";
            this.TxtFechaAtencion.Size = new System.Drawing.Size(119, 22);
            this.TxtFechaAtencion.TabIndex = 0;
            // 
            // RealizarRegistroDeAtencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1043, 636);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnCancelarAtencion);
            this.Controls.Add(this.BtnRegistrarAtencion);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RealizarRegistroDeAtencion";
            this.Text = "Registrar atención";
            this.Load += new System.EventHandler(this.RealizarReservaDeAtencion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnRegistrarAtencion;
        private System.Windows.Forms.Button BtnCancelarAtencion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtFechaAtencion;
        private System.Windows.Forms.TextBox TxtHoraAtencion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbTipoDeServicios;
        private System.Windows.Forms.TextBox TxtIdReservaDeAtencion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbProductos;
        private System.Windows.Forms.ComboBox CmbTipoDeProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_de_vencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridView DgvProductos;
        private System.Windows.Forms.Label LblMontoTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnQuitarProducto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtRutCliente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CmbTipoDeDocumento;
    }
}