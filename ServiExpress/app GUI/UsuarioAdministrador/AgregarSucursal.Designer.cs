namespace ServiExpress.app_GUI.UsuarioAdministrador
{
    partial class AgregarSucursal
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
            this.TxtSucursal = new System.Windows.Forms.TextBox();
            this.TxtDireccionSucursal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGuardarSucursal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtSucursal
            // 
            this.TxtSucursal.Location = new System.Drawing.Point(241, 96);
            this.TxtSucursal.MaxLength = 30;
            this.TxtSucursal.Name = "TxtSucursal";
            this.TxtSucursal.Size = new System.Drawing.Size(154, 22);
            this.TxtSucursal.TabIndex = 0;
            this.TxtSucursal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // TxtDireccionSucursal
            // 
            this.TxtDireccionSucursal.Location = new System.Drawing.Point(241, 149);
            this.TxtDireccionSucursal.MaxLength = 40;
            this.TxtDireccionSucursal.Name = "TxtDireccionSucursal";
            this.TxtDireccionSucursal.Size = new System.Drawing.Size(238, 22);
            this.TxtDireccionSucursal.TabIndex = 1;
            this.TxtDireccionSucursal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sucursal :";
            // 
            // BtnGuardarSucursal
            // 
            this.BtnGuardarSucursal.Location = new System.Drawing.Point(241, 208);
            this.BtnGuardarSucursal.Name = "BtnGuardarSucursal";
            this.BtnGuardarSucursal.Size = new System.Drawing.Size(135, 37);
            this.BtnGuardarSucursal.TabIndex = 3;
            this.BtnGuardarSucursal.Text = "Guardar sucursal";
            this.BtnGuardarSucursal.UseVisualStyleBackColor = true;
            this.BtnGuardarSucursal.Click += new System.EventHandler(this.BtnGuardarSucursal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dirección :";
            // 
            // AgregarSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(604, 320);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnGuardarSucursal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDireccionSucursal);
            this.Controls.Add(this.TxtSucursal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarSucursal";
            this.ShowIcon = false;
            this.Text = "AgregarSucursal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSucursal;
        private System.Windows.Forms.TextBox TxtDireccionSucursal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGuardarSucursal;
        private System.Windows.Forms.Label label2;
    }
}