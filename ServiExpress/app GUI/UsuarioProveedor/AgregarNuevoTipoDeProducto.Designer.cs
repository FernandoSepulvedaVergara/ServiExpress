namespace ServiExpress.app_GUI.UsuarioProveedor
{
    partial class AgregarNuevoTipoDeProducto
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
            this.button1 = new System.Windows.Forms.Button();
            this.TxtNuevoTipoDeProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 154);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Guardar tipo de producto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtNuevoTipoDeProducto
            // 
            this.TxtNuevoTipoDeProducto.Location = new System.Drawing.Point(173, 72);
            this.TxtNuevoTipoDeProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtNuevoTipoDeProducto.Name = "TxtNuevoTipoDeProducto";
            this.TxtNuevoTipoDeProducto.Size = new System.Drawing.Size(370, 22);
            this.TxtNuevoTipoDeProducto.TabIndex = 1;
            this.TxtNuevoTipoDeProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNuevoTipoDeProducto_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo de producto :";
            // 
            // AgregarNuevoTipoDeProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(556, 249);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNuevoTipoDeProducto);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarNuevoTipoDeProducto";
            this.Text = "Nuevo tipo de producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtNuevoTipoDeProducto;
        private System.Windows.Forms.Label label1;
    }
}