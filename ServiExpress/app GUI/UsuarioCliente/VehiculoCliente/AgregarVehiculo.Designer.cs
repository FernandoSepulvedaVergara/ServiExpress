namespace ServiExpress.app_GUI.Usuario1.VehiculoCliente
{
    partial class AgregarVehiculo
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
            this.BtnGuardarAgregarVehiculo = new System.Windows.Forms.Button();
            this.TxtPatente = new System.Windows.Forms.TextBox();
            this.CmbTipoDeVehiculo = new System.Windows.Forms.ComboBox();
            this.BtnCerrarAgregarVehiculo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNumeroChasis = new System.Windows.Forms.TextBox();
            this.TxtNumeroMotor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnGuardarAgregarVehiculo
            // 
            this.BtnGuardarAgregarVehiculo.Location = new System.Drawing.Point(363, 270);
            this.BtnGuardarAgregarVehiculo.Name = "BtnGuardarAgregarVehiculo";
            this.BtnGuardarAgregarVehiculo.Size = new System.Drawing.Size(128, 41);
            this.BtnGuardarAgregarVehiculo.TabIndex = 0;
            this.BtnGuardarAgregarVehiculo.Text = "Guardar";
            this.BtnGuardarAgregarVehiculo.UseVisualStyleBackColor = true;
            this.BtnGuardarAgregarVehiculo.Click += new System.EventHandler(this.BtnGuardarAgregarVehiculo_Click);
            // 
            // TxtPatente
            // 
            this.TxtPatente.Location = new System.Drawing.Point(31, 146);
            this.TxtPatente.Name = "TxtPatente";
            this.TxtPatente.Size = new System.Drawing.Size(100, 20);
            this.TxtPatente.TabIndex = 1;
            // 
            // CmbTipoDeVehiculo
            // 
            this.CmbTipoDeVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoDeVehiculo.FormattingEnabled = true;
            this.CmbTipoDeVehiculo.Location = new System.Drawing.Point(146, 145);
            this.CmbTipoDeVehiculo.Name = "CmbTipoDeVehiculo";
            this.CmbTipoDeVehiculo.Size = new System.Drawing.Size(100, 21);
            this.CmbTipoDeVehiculo.TabIndex = 2;
            // 
            // BtnCerrarAgregarVehiculo
            // 
            this.BtnCerrarAgregarVehiculo.Location = new System.Drawing.Point(512, 270);
            this.BtnCerrarAgregarVehiculo.Name = "BtnCerrarAgregarVehiculo";
            this.BtnCerrarAgregarVehiculo.Size = new System.Drawing.Size(128, 41);
            this.BtnCerrarAgregarVehiculo.TabIndex = 3;
            this.BtnCerrarAgregarVehiculo.Text = "Cancelar";
            this.BtnCerrarAgregarVehiculo.UseVisualStyleBackColor = true;
            this.BtnCerrarAgregarVehiculo.Click += new System.EventHandler(this.BtnCerrarAgregarVehiculo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Patente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Número de motor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo de vehículo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Número de chasis";
            // 
            // TxtNumeroChasis
            // 
            this.TxtNumeroChasis.Location = new System.Drawing.Point(31, 203);
            this.TxtNumeroChasis.Name = "TxtNumeroChasis";
            this.TxtNumeroChasis.Size = new System.Drawing.Size(100, 20);
            this.TxtNumeroChasis.TabIndex = 8;
            // 
            // TxtNumeroMotor
            // 
            this.TxtNumeroMotor.Location = new System.Drawing.Point(146, 203);
            this.TxtNumeroMotor.Name = "TxtNumeroMotor";
            this.TxtNumeroMotor.Size = new System.Drawing.Size(100, 20);
            this.TxtNumeroMotor.TabIndex = 9;
            // 
            // AgregarVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(652, 333);
            this.Controls.Add(this.TxtNumeroMotor);
            this.Controls.Add(this.TxtNumeroChasis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCerrarAgregarVehiculo);
            this.Controls.Add(this.CmbTipoDeVehiculo);
            this.Controls.Add(this.TxtPatente);
            this.Controls.Add(this.BtnGuardarAgregarVehiculo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarVehiculo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AgregarVehiculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGuardarAgregarVehiculo;
        private System.Windows.Forms.TextBox TxtPatente;
        private System.Windows.Forms.ComboBox CmbTipoDeVehiculo;
        private System.Windows.Forms.Button BtnCerrarAgregarVehiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNumeroChasis;
        private System.Windows.Forms.TextBox TxtNumeroMotor;
    }
}