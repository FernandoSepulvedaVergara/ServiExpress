namespace ServiExpress.app_GUI
{
    partial class FormUsuario1
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
            this.BtnDatosPersonales = new System.Windows.Forms.Button();
            this.BtnReservaAtencion = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnVehículos = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnDatosPersonales
            // 
            this.BtnDatosPersonales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDatosPersonales.Location = new System.Drawing.Point(12, 50);
            this.BtnDatosPersonales.Name = "BtnDatosPersonales";
            this.BtnDatosPersonales.Size = new System.Drawing.Size(133, 41);
            this.BtnDatosPersonales.TabIndex = 2;
            this.BtnDatosPersonales.Text = "Datos personales";
            this.BtnDatosPersonales.UseVisualStyleBackColor = true;
            // 
            // BtnReservaAtencion
            // 
            this.BtnReservaAtencion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReservaAtencion.Location = new System.Drawing.Point(12, 140);
            this.BtnReservaAtencion.Name = "BtnReservaAtencion";
            this.BtnReservaAtencion.Size = new System.Drawing.Size(133, 41);
            this.BtnReservaAtencion.TabIndex = 3;
            this.BtnReservaAtencion.Text = "Reservar atención";
            this.BtnReservaAtencion.UseVisualStyleBackColor = true;
            this.BtnReservaAtencion.Click += new System.EventHandler(this.BtnReservaAtencion_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 488);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 41);
            this.button3.TabIndex = 4;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // BtnVehículos
            // 
            this.BtnVehículos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVehículos.Location = new System.Drawing.Point(12, 97);
            this.BtnVehículos.Name = "BtnVehículos";
            this.BtnVehículos.Size = new System.Drawing.Size(133, 37);
            this.BtnVehículos.TabIndex = 2;
            this.BtnVehículos.Text = "Mis vehículos";
            this.BtnVehículos.UseVisualStyleBackColor = true;
            this.BtnVehículos.Click += new System.EventHandler(this.BtnVehículos_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.BtnReservaAtencion);
            this.splitContainer1.Panel1.Controls.Add(this.BtnDatosPersonales);
            this.splitContainer1.Panel1.Controls.Add(this.BtnVehículos);
            this.splitContainer1.Size = new System.Drawing.Size(884, 541);
            this.splitContainer1.SplitterDistance = 155;
            this.splitContainer1.TabIndex = 9;
            // 
            // FormUsuario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 541);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUsuario1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnDatosPersonales;
        private System.Windows.Forms.Button BtnReservaAtencion;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BtnVehículos;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}