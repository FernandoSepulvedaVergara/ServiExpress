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
            this.DgvReservas = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnPedidos = new System.Windows.Forms.Button();
            this.BtnDatosPersonales = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnReservasDeAtencion = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DgvReservas);
            this.panel1.Location = new System.Drawing.Point(145, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 426);
            this.panel1.TabIndex = 13;
            // 
            // DgvReservas
            // 
            this.DgvReservas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvReservas.Location = new System.Drawing.Point(36, 111);
            this.DgvReservas.Name = "DgvReservas";
            this.DgvReservas.Size = new System.Drawing.Size(727, 299);
            this.DgvReservas.TabIndex = 0;
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
            // BtnPedidos
            // 
            this.BtnPedidos.Location = new System.Drawing.Point(6, 123);
            this.BtnPedidos.Name = "BtnPedidos";
            this.BtnPedidos.Size = new System.Drawing.Size(133, 41);
            this.BtnPedidos.TabIndex = 11;
            this.BtnPedidos.Text = "Pedidos";
            this.BtnPedidos.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Empleado";
            // 
            // BtnReservasDeAtencion
            // 
            this.BtnReservasDeAtencion.Location = new System.Drawing.Point(6, 76);
            this.BtnReservasDeAtencion.Name = "BtnReservasDeAtencion";
            this.BtnReservasDeAtencion.Size = new System.Drawing.Size(133, 41);
            this.BtnReservasDeAtencion.TabIndex = 15;
            this.BtnReservasDeAtencion.Text = "Reservas de atención";
            this.BtnReservasDeAtencion.UseVisualStyleBackColor = true;
            // 
            // FormUsuario3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 450);
            this.Controls.Add(this.BtnReservasDeAtencion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnPedidos);
            this.Controls.Add(this.BtnDatosPersonales);
            this.Name = "FormUsuario3";
            this.Text = "formUsuario3";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BtnPedidos;
        private System.Windows.Forms.Button BtnDatosPersonales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnReservasDeAtencion;
        private System.Windows.Forms.DataGridView DgvReservas;
    }
}