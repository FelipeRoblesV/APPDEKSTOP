namespace WFBS.Presentacion.Formularios.Login.Modulo
{
    partial class Imagenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Imagenes));
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.Separador = new Bunifu.Framework.UI.BunifuSeparator();
            this.ImagenLogo = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Font = new System.Drawing.Font("Roboto Light", 11.75F);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(142)))), ((int)(((byte)(141)))));
            this.lblDescripcion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDescripcion.Location = new System.Drawing.Point(134, 818);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(119, 69);
            this.lblDescripcion.TabIndex = 12;
            this.lblDescripcion.Text = "Agencia de investigadores privados";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(142)))), ((int)(((byte)(141)))));
            this.lblTitulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitulo.Location = new System.Drawing.Point(134, 789);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(91, 33);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "WFBS";
            // 
            // Separador
            // 
            this.Separador.BackColor = System.Drawing.Color.Transparent;
            this.Separador.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.Separador.LineThickness = 1;
            this.Separador.Location = new System.Drawing.Point(118, 786);
            this.Separador.Name = "Separador";
            this.Separador.Size = new System.Drawing.Size(10, 98);
            this.Separador.TabIndex = 10;
            this.Separador.Transparency = 255;
            this.Separador.Vertical = true;
            // 
            // ImagenLogo
            // 
            this.ImagenLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.ImagenLogo.Image = ((System.Drawing.Image)(resources.GetObject("ImagenLogo.Image")));
            this.ImagenLogo.ImageActive = null;
            this.ImagenLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ImagenLogo.Location = new System.Drawing.Point(12, 784);
            this.ImagenLogo.Name = "ImagenLogo";
            this.ImagenLogo.Size = new System.Drawing.Size(100, 100);
            this.ImagenLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagenLogo.TabIndex = 9;
            this.ImagenLogo.TabStop = false;
            this.ImagenLogo.Zoom = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1332, 896);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Imagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 896);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.Separador);
            this.Controls.Add(this.ImagenLogo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Imagenes";
            this.Text = "Imagenes";
            ((System.ComponentModel.ISupportInitialize)(this.ImagenLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblTitulo;
        private Bunifu.Framework.UI.BunifuSeparator Separador;
        private Bunifu.Framework.UI.BunifuImageButton ImagenLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}