namespace ServiExpress.app_GUI
{
    partial class FormUsuario4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuario4));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BtnAdministrarSucursales = new System.Windows.Forms.Button();
            this.BtnAdministrarUsuarios = new System.Windows.Forms.Button();
            this.BtnPedidos = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnAdministrarProducto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnAdministrarProveedores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.BtnAdministrarUsuarios);
            this.splitContainer1.Panel1.Controls.Add(this.BtnAdministrarProveedores);
            this.splitContainer1.Panel1.Controls.Add(this.BtnAdministrarSucursales);
            this.splitContainer1.Panel1.Controls.Add(this.BtnPedidos);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.BtnAdministrarProducto);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Size = new System.Drawing.Size(1364, 721);
            this.splitContainer1.SplitterDistance = 192;
            this.splitContainer1.TabIndex = 0;
            // 
            // BtnAdministrarSucursales
            // 
            this.BtnAdministrarSucursales.Location = new System.Drawing.Point(26, 417);
            this.BtnAdministrarSucursales.Name = "BtnAdministrarSucursales";
            this.BtnAdministrarSucursales.Size = new System.Drawing.Size(133, 41);
            this.BtnAdministrarSucursales.TabIndex = 21;
            this.BtnAdministrarSucursales.Text = "Administrar sucursales";
            this.BtnAdministrarSucursales.UseVisualStyleBackColor = true;
            // 
            // BtnAdministrarUsuarios
            // 
            this.BtnAdministrarUsuarios.Location = new System.Drawing.Point(26, 190);
            this.BtnAdministrarUsuarios.Name = "BtnAdministrarUsuarios";
            this.BtnAdministrarUsuarios.Size = new System.Drawing.Size(133, 41);
            this.BtnAdministrarUsuarios.TabIndex = 20;
            this.BtnAdministrarUsuarios.Text = "Administrar usuarios";
            this.BtnAdministrarUsuarios.UseVisualStyleBackColor = true;
            this.BtnAdministrarUsuarios.Click += new System.EventHandler(this.BtnAdministrarUsuarios_Click);
            // 
            // BtnPedidos
            // 
            this.BtnPedidos.Location = new System.Drawing.Point(26, 360);
            this.BtnPedidos.Name = "BtnPedidos";
            this.BtnPedidos.Size = new System.Drawing.Size(133, 41);
            this.BtnPedidos.TabIndex = 19;
            this.BtnPedidos.Text = "Pedidos";
            this.BtnPedidos.UseVisualStyleBackColor = true;
            this.BtnPedidos.Click += new System.EventHandler(this.BtnPedidos_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Datos Personales";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(26, 525);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 41);
            this.button3.TabIndex = 18;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // BtnAdministrarProducto
            // 
            this.BtnAdministrarProducto.Location = new System.Drawing.Point(26, 304);
            this.BtnAdministrarProducto.Name = "BtnAdministrarProducto";
            this.BtnAdministrarProducto.Size = new System.Drawing.Size(133, 41);
            this.BtnAdministrarProducto.TabIndex = 17;
            this.BtnAdministrarProducto.Text = "Administrar productos";
            this.BtnAdministrarProducto.UseVisualStyleBackColor = true;
            this.BtnAdministrarProducto.Click += new System.EventHandler(this.BtnAdministrarProducto_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(26, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 101);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // BtnAdministrarProveedores
            // 
            this.BtnAdministrarProveedores.Location = new System.Drawing.Point(26, 247);
            this.BtnAdministrarProveedores.Name = "BtnAdministrarProveedores";
            this.BtnAdministrarProveedores.Size = new System.Drawing.Size(133, 41);
            this.BtnAdministrarProveedores.TabIndex = 22;
            this.BtnAdministrarProveedores.Text = "Administrar proveedores";
            this.BtnAdministrarProveedores.UseVisualStyleBackColor = true;
            // 
            // FormUsuario4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(176)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1364, 721);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormUsuario4";
            this.Text = "formUsuario4";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormUsuario4_FormClosed);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button BtnPedidos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BtnAdministrarProducto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnAdministrarSucursales;
        private System.Windows.Forms.Button BtnAdministrarUsuarios;
        private System.Windows.Forms.Button BtnAdministrarProveedores;
    }
}