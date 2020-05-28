namespace ServiExpress.app_GUI.UsuarioEmpleado.ReservarsDehora
{
    partial class RealizarReservaDeAtencion
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
            this.BtnRegistrarAtencion = new System.Windows.Forms.Button();
            this.BtnCancelarAtencion = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbTipoDeServicios = new System.Windows.Forms.ComboBox();
            this.TxtIdReservaDeAtencion = new System.Windows.Forms.TextBox();
            this.TxtHoraAtencion = new System.Windows.Forms.TextBox();
            this.TxtFechaAtencion = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnRegistrarAtencion
            // 
            this.BtnRegistrarAtencion.Location = new System.Drawing.Point(609, 46);
            this.BtnRegistrarAtencion.Name = "BtnRegistrarAtencion";
            this.BtnRegistrarAtencion.Size = new System.Drawing.Size(108, 34);
            this.BtnRegistrarAtencion.TabIndex = 1;
            this.BtnRegistrarAtencion.Text = "Registrar atención";
            this.BtnRegistrarAtencion.UseVisualStyleBackColor = true;
            this.BtnRegistrarAtencion.Click += new System.EventHandler(this.BtnRegistrarAtencion_Click);
            // 
            // BtnCancelarAtencion
            // 
            this.BtnCancelarAtencion.Location = new System.Drawing.Point(609, 107);
            this.BtnCancelarAtencion.Name = "BtnCancelarAtencion";
            this.BtnCancelarAtencion.Size = new System.Drawing.Size(108, 34);
            this.BtnCancelarAtencion.TabIndex = 2;
            this.BtnCancelarAtencion.Text = "Cancelar atención";
            this.BtnCancelarAtencion.UseVisualStyleBackColor = true;
            this.BtnCancelarAtencion.Click += new System.EventHandler(this.BtnCancelarAtencion_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(609, 309);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(108, 34);
            this.BtnCerrar.TabIndex = 3;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CmbTipoDeServicios);
            this.panel1.Controls.Add(this.TxtIdReservaDeAtencion);
            this.panel1.Controls.Add(this.TxtHoraAtencion);
            this.panel1.Controls.Add(this.TxtFechaAtencion);
            this.panel1.Location = new System.Drawing.Point(43, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 297);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha de atención:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hora de atención:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Servicio realizado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id reserva de atención:";
            // 
            // CmbTipoDeServicios
            // 
            this.CmbTipoDeServicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoDeServicios.FormattingEnabled = true;
            this.CmbTipoDeServicios.Location = new System.Drawing.Point(150, 34);
            this.CmbTipoDeServicios.Name = "CmbTipoDeServicios";
            this.CmbTipoDeServicios.Size = new System.Drawing.Size(317, 21);
            this.CmbTipoDeServicios.TabIndex = 3;
            // 
            // TxtIdReservaDeAtencion
            // 
            this.TxtIdReservaDeAtencion.Enabled = false;
            this.TxtIdReservaDeAtencion.Location = new System.Drawing.Point(150, 61);
            this.TxtIdReservaDeAtencion.Name = "TxtIdReservaDeAtencion";
            this.TxtIdReservaDeAtencion.Size = new System.Drawing.Size(126, 20);
            this.TxtIdReservaDeAtencion.TabIndex = 2;
            // 
            // TxtHoraAtencion
            // 
            this.TxtHoraAtencion.Enabled = false;
            this.TxtHoraAtencion.Location = new System.Drawing.Point(150, 215);
            this.TxtHoraAtencion.Name = "TxtHoraAtencion";
            this.TxtHoraAtencion.Size = new System.Drawing.Size(126, 20);
            this.TxtHoraAtencion.TabIndex = 1;
            // 
            // TxtFechaAtencion
            // 
            this.TxtFechaAtencion.Enabled = false;
            this.TxtFechaAtencion.Location = new System.Drawing.Point(150, 189);
            this.TxtFechaAtencion.Name = "TxtFechaAtencion";
            this.TxtFechaAtencion.Size = new System.Drawing.Size(126, 20);
            this.TxtFechaAtencion.TabIndex = 0;
            // 
            // RealizarReservaDeAtencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(767, 390);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnCancelarAtencion);
            this.Controls.Add(this.BtnRegistrarAtencion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RealizarReservaDeAtencion";
            this.Text = "RealizarReservaDeAtencion";
            this.Load += new System.EventHandler(this.RealizarReservaDeAtencion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnRegistrarAtencion;
        private System.Windows.Forms.Button BtnCancelarAtencion;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtFechaAtencion;
        private System.Windows.Forms.TextBox TxtHoraAtencion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbTipoDeServicios;
        private System.Windows.Forms.TextBox TxtIdReservaDeAtencion;
    }
}