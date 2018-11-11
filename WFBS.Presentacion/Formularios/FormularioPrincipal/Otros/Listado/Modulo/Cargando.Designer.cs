namespace WFBS.Presentacion.Formularios.FormularioPrincipal.Otros.Listado.Modulo
{
    partial class Cargando
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cargando));
            this.barraProgreso = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.lblMensaje = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // barraProgreso
            // 
            this.barraProgreso.animated = true;
            this.barraProgreso.animationIterval = 1;
            this.barraProgreso.animationSpeed = 15;
            this.barraProgreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.barraProgreso.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barraProgreso.BackgroundImage")));
            this.barraProgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.barraProgreso.ForeColor = System.Drawing.Color.SeaGreen;
            this.barraProgreso.LabelVisible = false;
            this.barraProgreso.LineProgressThickness = 8;
            this.barraProgreso.LineThickness = 5;
            this.barraProgreso.Location = new System.Drawing.Point(621, 154);
            this.barraProgreso.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.barraProgreso.MaxValue = 100;
            this.barraProgreso.Name = "barraProgreso";
            this.barraProgreso.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.barraProgreso.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(68)))), ((int)(((byte)(91)))));
            this.barraProgreso.Size = new System.Drawing.Size(190, 190);
            this.barraProgreso.TabIndex = 33;
            this.barraProgreso.Value = 30;
            this.barraProgreso.Visible = false;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Roboto Light", 25F);
            this.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(216)))), ((int)(((byte)(165)))));
            this.lblMensaje.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMensaje.Location = new System.Drawing.Point(379, 353);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(643, 116);
            this.lblMensaje.TabIndex = 34;
            this.lblMensaje.Text = "Cargando Formulario Evaluaciones";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMensaje.Visible = false;
            // 
            // Cargando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(1496, 619);
            this.Controls.Add(this.barraProgreso);
            this.Controls.Add(this.lblMensaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cargando";
            this.Text = "Cargando";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCircleProgressbar barraProgreso;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMensaje;
    }
}