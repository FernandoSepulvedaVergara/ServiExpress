namespace ServiExpress.app_GUI
{
    partial class FormUsuario3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnDatosPersonales = new System.Windows.Forms.Button();
            this.BtnReservasDeAtencion = new System.Windows.Forms.Button();
            this.BtnVentas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(145, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1207, 687);
            this.panel1.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 359);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 41);
            this.button3.TabIndex = 12;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // BtnDatosPersonales
            // 
            this.BtnDatosPersonales.Location = new System.Drawing.Point(6, 29);
            this.BtnDatosPersonales.Name = "BtnDatosPersonales";
            this.BtnDatosPersonales.Size = new System.Drawing.Size(133, 41);
            this.BtnDatosPersonales.TabIndex = 10;
            this.BtnDatosPersonales.Text = "Datos personales";
            this.BtnDatosPersonales.UseVisualStyleBackColor = true;
            // 
            // BtnReservasDeAtencion
            // 
            this.BtnReservasDeAtencion.Location = new System.Drawing.Point(6, 76);
            this.BtnReservasDeAtencion.Name = "BtnReservasDeAtencion";
            this.BtnReservasDeAtencion.Size = new System.Drawing.Size(133, 41);
            this.BtnReservasDeAtencion.TabIndex = 15;
            this.BtnReservasDeAtencion.Text = "Reservas de atención";
            this.BtnReservasDeAtencion.UseVisualStyleBackColor = true;
            this.BtnReservasDeAtencion.Click += new System.EventHandler(this.BtnReservasDeAtencion_Click);
            // 
            // BtnVentas
            // 
            this.BtnVentas.Location = new System.Drawing.Point(6, 123);
            this.BtnVentas.Name = "BtnVentas";
            this.BtnVentas.Size = new System.Drawing.Size(133, 41);
            this.BtnVentas.TabIndex = 16;
            this.BtnVentas.Text = "Ventas";
            this.BtnVentas.UseVisualStyleBackColor = true;
            this.BtnVentas.Click += new System.EventHandler(this.BtnVentas_Click);
            // 
            // FormUsuario3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1364, 711);
            this.Controls.Add(this.BtnVentas);
            this.Controls.Add(this.BtnReservasDeAtencion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnDatosPersonales);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUsuario3";
            this.Text = "formUsuario3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormUsuario3_FormClosed);
            this.Load += new System.EventHandler(this.FormUsuario3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BtnDatosPersonales;
        private System.Windows.Forms.Button BtnReservasDeAtencion;
        private System.Windows.Forms.Button BtnVentas;
    }
}