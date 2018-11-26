namespace WFBS.Presentacion.Formularios.FormularioPrincipal.Modulo.Otros
{
    partial class Estado
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
            this.panelEstado = new System.Windows.Forms.Panel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.imagenEstado = new System.Windows.Forms.PictureBox();
            this.panelEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenEstado)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEstado
            // 
            this.panelEstado.Controls.Add(this.lblMensaje);
            this.panelEstado.Controls.Add(this.imagenEstado);
            this.panelEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEstado.Location = new System.Drawing.Point(0, 0);
            this.panelEstado.Name = "panelEstado";
            this.panelEstado.Size = new System.Drawing.Size(334, 729);
            this.panelEstado.TabIndex = 0;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Roboto", 22F);
            this.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.lblMensaje.Location = new System.Drawing.Point(17, 456);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(298, 108);
            this.lblMensaje.TabIndex = 1;
            this.lblMensaje.Text = "Agregado Incorrectamente";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // imagenEstado
            // 
            this.imagenEstado.Image = global::WFBS.Presentacion.Properties.Resources.estado_correcto;
            this.imagenEstado.Location = new System.Drawing.Point(22, 91);
            this.imagenEstado.Name = "imagenEstado";
            this.imagenEstado.Size = new System.Drawing.Size(290, 339);
            this.imagenEstado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagenEstado.TabIndex = 0;
            this.imagenEstado.TabStop = false;
            // 
            // Estado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(334, 729);
            this.Controls.Add(this.panelEstado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Estado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Estado";
            this.panelEstado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagenEstado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEstado;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.PictureBox imagenEstado;
    }
}