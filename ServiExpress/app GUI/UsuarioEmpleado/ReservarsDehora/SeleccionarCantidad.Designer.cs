﻿namespace ServiExpress.app_GUI.UsuarioEmpleado.ReservarsDehora
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
            this.NudCantidad.Location = new System.Drawing.Point(80, 95);
            this.NudCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudCantidad.Name = "NudCantidad";
            this.NudCantidad.ReadOnly = true;
            this.NudCantidad.Size = new System.Drawing.Size(110, 22);
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
            this.label1.Location = new System.Drawing.Point(81, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stock : ";
            // 
            // BtnGuardarCantidad
            // 
            this.BtnGuardarCantidad.BackColor = System.Drawing.Color.Yellow;
            this.BtnGuardarCantidad.Location = new System.Drawing.Point(80, 140);
            this.BtnGuardarCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnGuardarCantidad.Name = "BtnGuardarCantidad";
            this.BtnGuardarCantidad.Size = new System.Drawing.Size(110, 33);
            this.BtnGuardarCantidad.TabIndex = 3;
            this.BtnGuardarCantidad.Text = "Guardar";
            this.BtnGuardarCantidad.UseVisualStyleBackColor = false;
            this.BtnGuardarCantidad.Click += new System.EventHandler(this.BtnGuardarCantidad_Click);
            // 
            // LblStock
            // 
            this.LblStock.AutoSize = true;
            this.LblStock.Location = new System.Drawing.Point(149, 37);
            this.LblStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblStock.Name = "LblStock";
            this.LblStock.Size = new System.Drawing.Size(15, 16);
            this.LblStock.TabIndex = 4;
            this.LblStock.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Precio unitario : ";
            // 
            // LblPrecioUnitario
            // 
            this.LblPrecioUnitario.AutoSize = true;
            this.LblPrecioUnitario.Location = new System.Drawing.Point(149, 11);
            this.LblPrecioUnitario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPrecioUnitario.Name = "LblPrecioUnitario";
            this.LblPrecioUnitario.Size = new System.Drawing.Size(15, 16);
            this.LblPrecioUnitario.TabIndex = 6;
            this.LblPrecioUnitario.Text = "0";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(149, 67);
            this.LblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(15, 16);
            this.LblTotal.TabIndex = 8;
            this.LblTotal.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total : ";
            // 
            // SeleccionarCantidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(255, 186);
            this.ControlBox = false;
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblPrecioUnitario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblStock);
            this.Controls.Add(this.BtnGuardarCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NudCantidad);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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