namespace ServiExpress.app_GUI.UsuarioEmpleado
{
    partial class Pagar
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
            this.TxtMontoPago = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnPagar = new System.Windows.Forms.Button();
            this.LblMontoAPagar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtMontoPago
            // 
            this.TxtMontoPago.Location = new System.Drawing.Point(133, 74);
            this.TxtMontoPago.Name = "TxtMontoPago";
            this.TxtMontoPago.Size = new System.Drawing.Size(100, 20);
            this.TxtMontoPago.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monto a pagar: ";
            // 
            // BtnPagar
            // 
            this.BtnPagar.Location = new System.Drawing.Point(327, 65);
            this.BtnPagar.Name = "BtnPagar";
            this.BtnPagar.Size = new System.Drawing.Size(117, 37);
            this.BtnPagar.TabIndex = 3;
            this.BtnPagar.Text = "Pagar";
            this.BtnPagar.UseVisualStyleBackColor = true;
            this.BtnPagar.Click += new System.EventHandler(this.BtnPagar_Click);
            // 
            // LblMontoAPagar
            // 
            this.LblMontoAPagar.AutoSize = true;
            this.LblMontoAPagar.Location = new System.Drawing.Point(130, 34);
            this.LblMontoAPagar.Name = "LblMontoAPagar";
            this.LblMontoAPagar.Size = new System.Drawing.Size(0, 13);
            this.LblMontoAPagar.TabIndex = 4;
            // 
            // Pagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(523, 191);
            this.Controls.Add(this.LblMontoAPagar);
            this.Controls.Add(this.BtnPagar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtMontoPago);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pagar";
            this.Text = "Pagar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtMontoPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnPagar;
        private System.Windows.Forms.Label LblMontoAPagar;
    }
}