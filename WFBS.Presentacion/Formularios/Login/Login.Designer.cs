namespace WFBS.Presentacion.Formularios.Login
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelModulo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelImagen = new System.Windows.Forms.Panel();
            this.btnMinimizarFormulario = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnCerrarFormulario = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarFormulario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarFormulario)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.panelModulo);
            this.panelPrincipal.Controls.Add(this.panel1);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelPrincipal.Location = new System.Drawing.Point(1332, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(264, 896);
            this.panelPrincipal.TabIndex = 0;
            // 
            // panelModulo
            // 
            this.panelModulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.panelModulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelModulo.Location = new System.Drawing.Point(0, 27);
            this.panelModulo.Name = "panelModulo";
            this.panelModulo.Size = new System.Drawing.Size(264, 869);
            this.panelModulo.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.btnMinimizarFormulario);
            this.panel1.Controls.Add(this.btnCerrarFormulario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(264, 27);
            this.panel1.TabIndex = 0;
            // 
            // panelImagen
            // 
            this.panelImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.panelImagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImagen.Location = new System.Drawing.Point(0, 0);
            this.panelImagen.Name = "panelImagen";
            this.panelImagen.Size = new System.Drawing.Size(1332, 896);
            this.panelImagen.TabIndex = 1;
            // 
            // btnMinimizarFormulario
            // 
            this.btnMinimizarFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.btnMinimizarFormulario.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizarFormulario.Image = global::WFBS.Presentacion.Properties.Resources.MinimizeFP;
            this.btnMinimizarFormulario.ImageActive = null;
            this.btnMinimizarFormulario.Location = new System.Drawing.Point(209, 1);
            this.btnMinimizarFormulario.Name = "btnMinimizarFormulario";
            this.btnMinimizarFormulario.Size = new System.Drawing.Size(27, 25);
            this.btnMinimizarFormulario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizarFormulario.TabIndex = 1;
            this.btnMinimizarFormulario.TabStop = false;
            this.btnMinimizarFormulario.Zoom = 0;
            this.btnMinimizarFormulario.Click += new System.EventHandler(this.btnControles_Click);
            // 
            // btnCerrarFormulario
            // 
            this.btnCerrarFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.btnCerrarFormulario.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrarFormulario.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarFormulario.Image")));
            this.btnCerrarFormulario.ImageActive = null;
            this.btnCerrarFormulario.Location = new System.Drawing.Point(236, 1);
            this.btnCerrarFormulario.Name = "btnCerrarFormulario";
            this.btnCerrarFormulario.Size = new System.Drawing.Size(27, 25);
            this.btnCerrarFormulario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarFormulario.TabIndex = 0;
            this.btnCerrarFormulario.TabStop = false;
            this.btnCerrarFormulario.Zoom = 0;
            this.btnCerrarFormulario.Click += new System.EventHandler(this.btnControles_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 896);
            this.Controls.Add(this.panelImagen);
            this.Controls.Add(this.panelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.panelPrincipal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarFormulario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarFormulario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelImagen;
        private System.Windows.Forms.Panel panelModulo;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimizarFormulario;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrarFormulario;
    }
}