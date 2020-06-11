namespace ServiExpress.app_GUI.UsuarioEmpleado.ReservarsDehora
{
    partial class SeleccionarCantidad
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
            this.NudCantidad = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGuardarCantidad = new System.Windows.Forms.Button();
            this.LblStock = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblPrecioUnitario = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // NudCantidad
            // 
            this.NudCantidad.Location = new System.Drawing.Point(74, 83);
            this.NudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudCantidad.Name = "NudCantidad";
            this.NudCantidad.ReadOnly = true;
            this.NudCantidad.Size = new System.Drawing.Size(83, 20);
            this.NudCantidad.TabIndex = 1;
            this.NudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudCantidad.ValueChanged += new System.EventHandler(this.NudCantidad_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stock : ";
            // 
            // BtnGuardarCantidad
            // 
            this.BtnGuardarCantidad.BackColor = System.Drawing.Color.Yellow;
            this.BtnGuardarCantidad.Location = new System.Drawing.Point(74, 119);
            this.BtnGuardarCantidad.Name = "BtnGuardarCantidad";
            this.BtnGuardarCantidad.Size = new System.Drawing.Size(83, 27);
            this.BtnGuardarCantidad.TabIndex = 3;
            this.BtnGuardarCantidad.Text = "Guardar";
            this.BtnGuardarCantidad.UseVisualStyleBackColor = false;
            this.BtnGuardarCantidad.Click += new System.EventHandler(this.BtnGuardarCantidad_Click);
            // 
            // LblStock
            // 
            this.LblStock.AutoSize = true;
            this.LblStock.Location = new System.Drawing.Point(71, 30);
            this.LblStock.Name = "LblStock";
            this.LblStock.Size = new System.Drawing.Size(13, 13);
            this.LblStock.TabIndex = 4;
            this.LblStock.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Precio unitario : ";
            // 
            // LblPrecioUnitario
            // 
            this.LblPrecioUnitario.AutoSize = true;
            this.LblPrecioUnitario.Location = new System.Drawing.Point(112, 9);
            this.LblPrecioUnitario.Name = "LblPrecioUnitario";
            this.LblPrecioUnitario.Size = new System.Drawing.Size(13, 13);
            this.LblPrecioUnitario.TabIndex = 6;
            this.LblPrecioUnitario.Text = "0";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(71, 54);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(13, 13);
            this.LblTotal.TabIndex = 8;
            this.LblTotal.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total : ";
            // 
            // SeleccionarCantidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(176)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(220, 158);
            this.ControlBox = false;
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblPrecioUnitario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblStock);
            this.Controls.Add(this.BtnGuardarCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NudCantidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SeleccionarCantidad";
            this.ShowIcon = false;
            this.Text = "Seleccionar cantidad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SeleccionarCantidad_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SeleccionarCantidad_FormClosed);
            this.Load += new System.EventHandler(this.SeleccionarCantidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NudCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGuardarCantidad;
        private System.Windows.Forms.Label LblStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblPrecioUnitario;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label label4;
    }
}