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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuario1));
            this.BtnDatosPersonales = new System.Windows.Forms.Button();
            this.BtnReservaAtencion = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnVehículos = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnGlosarioPago = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnDatosPersonales
            // 
            this.BtnDatosPersonales.BackColor = System.Drawing.Color.White;
            this.BtnDatosPersonales.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDatosPersonales.BackgroundImage")));
            this.BtnDatosPersonales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDatosPersonales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDatosPersonales.Location = new System.Drawing.Point(12, 25);
            this.BtnDatosPersonales.Name = "BtnDatosPersonales";
            this.BtnDatosPersonales.Size = new System.Drawing.Size(133, 91);
            this.BtnDatosPersonales.TabIndex = 2;
            this.BtnDatosPersonales.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnDatosPersonales.UseVisualStyleBackColor = false;
            // 
            // BtnReservaAtencion
            // 
            this.BtnReservaAtencion.BackColor = System.Drawing.Color.White;
            this.BtnReservaAtencion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnReservaAtencion.BackgroundImage")));
            this.BtnReservaAtencion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnReservaAtencion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReservaAtencion.Location = new System.Drawing.Point(12, 281);
            this.BtnReservaAtencion.Name = "BtnReservaAtencion";
            this.BtnReservaAtencion.Size = new System.Drawing.Size(133, 93);
            this.BtnReservaAtencion.TabIndex = 3;
            this.BtnReservaAtencion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnReservaAtencion.UseVisualStyleBackColor = false;
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
            this.BtnVehículos.BackColor = System.Drawing.Color.White;
            this.BtnVehículos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVehículos.BackgroundImage")));
            this.BtnVehículos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVehículos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVehículos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnVehículos.Location = new System.Drawing.Point(12, 150);
            this.BtnVehículos.Name = "BtnVehículos";
            this.BtnVehículos.Size = new System.Drawing.Size(133, 93);
            this.BtnVehículos.TabIndex = 2;
            this.BtnVehículos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnVehículos.UseVisualStyleBackColor = false;
            this.BtnVehículos.Click += new System.EventHandler(this.BtnVehículos_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.btnGlosarioPago);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.BtnReservaAtencion);
            this.splitContainer1.Panel1.Controls.Add(this.BtnDatosPersonales);
            this.splitContainer1.Panel1.Controls.Add(this.BtnVehículos);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(176)))), ((int)(((byte)(244)))));
            this.splitContainer1.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel2.BackgroundImage")));
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1003, 541);
            this.splitContainer1.SplitterDistance = 175;
            this.splitContainer1.TabIndex = 9;
            // 
            // btnGlosarioPago
            // 
            this.btnGlosarioPago.BackColor = System.Drawing.Color.White;
            this.btnGlosarioPago.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGlosarioPago.BackgroundImage")));
            this.btnGlosarioPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGlosarioPago.Location = new System.Drawing.Point(12, 414);
            this.btnGlosarioPago.Name = "btnGlosarioPago";
            this.btnGlosarioPago.Size = new System.Drawing.Size(133, 93);
            this.btnGlosarioPago.TabIndex = 0;
            this.btnGlosarioPago.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGlosarioPago.UseVisualStyleBackColor = false;
            this.btnGlosarioPago.Click += new System.EventHandler(this.btnGlosarioPago_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Glosario de Pago";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Reservar atención";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mis vehículos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos personales";
            // 
            // FormUsuario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1003, 541);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUsuario1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
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
        private System.Windows.Forms.Button btnGlosarioPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}