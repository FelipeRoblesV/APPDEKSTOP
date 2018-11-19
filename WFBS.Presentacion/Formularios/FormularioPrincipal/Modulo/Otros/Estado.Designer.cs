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
            this.lblMensaje = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.imagenEstado = new System.Windows.Forms.PictureBox();
            this.panelEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenEstado)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEstado
            // 
            this.panelEstado.Controls.Add(this.imagenEstado);
            this.panelEstado.Controls.Add(this.lblMensaje);
            this.panelEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEstado.Location = new System.Drawing.Point(0, 0);
            this.panelEstado.Name = "panelEstado";
            this.panelEstado.Size = new System.Drawing.Size(334, 729);
            this.panelEstado.TabIndex = 35;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Roboto Light", 15F);
            this.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.lblMensaje.Location = new System.Drawing.Point(12, 450);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(310, 85);
            this.lblMensaje.TabIndex = 35;
            this.lblMensaje.Text = "Se Agrego Correctamente";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imagenEstado
            // 
            this.imagenEstado.Location = new System.Drawing.Point(34, 193);
            this.imagenEstado.Name = "imagenEstado";
            this.imagenEstado.Size = new System.Drawing.Size(257, 254);
            this.imagenEstado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagenEstado.TabIndex = 36;
            this.imagenEstado.TabStop = false;
            // 
            // Estado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(334, 729);
            this.Controls.Add(this.panelEstado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Estado";
            this.Text = "Estado";
            this.panelEstado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagenEstado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEstado;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMensaje;
        private System.Windows.Forms.PictureBox imagenEstado;
    }
}