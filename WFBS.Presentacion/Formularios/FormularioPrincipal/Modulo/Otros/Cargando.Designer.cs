namespace WFBS.Presentacion.Formularios.FormularioPrincipal.Modulo.Otros
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cargando));
            this.lblMensaje = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.timerPreloader = new System.Windows.Forms.Timer(this.components);
            this.timerColor = new System.Windows.Forms.Timer(this.components);
            this.colorTransicion = new Bunifu.Framework.UI.BunifuColorTransition(this.components);
            this.barraProgreso = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Roboto Light", 15F);
            this.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(216)))), ((int)(((byte)(165)))));
            this.lblMensaje.Location = new System.Drawing.Point(42, 409);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(240, 85);
            this.lblMensaje.TabIndex = 35;
            this.lblMensaje.Text = "Iniciando el formulario";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMensaje.Visible = false;
            // 
            // timerPreloader
            // 
            this.timerPreloader.Enabled = true;
            this.timerPreloader.Interval = 1;
            this.timerPreloader.Tick += new System.EventHandler(this.timerPreloader_Tick);
            // 
            // timerColor
            // 
            this.timerColor.Interval = 10;
            // 
            // colorTransicion
            // 
            this.colorTransicion.Color1 = System.Drawing.Color.White;
            this.colorTransicion.Color2 = System.Drawing.Color.White;
            this.colorTransicion.ProgessValue = 0;
            this.colorTransicion.OnValueChange += new System.EventHandler(this.colorTransicion_OnValueChange);
            // 
            // barraProgreso
            // 
            this.barraProgreso.animated = true;
            this.barraProgreso.animationIterval = 5;
            this.barraProgreso.animationSpeed = 15;
            this.barraProgreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.barraProgreso.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barraProgreso.BackgroundImage")));
            this.barraProgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.barraProgreso.ForeColor = System.Drawing.Color.SeaGreen;
            this.barraProgreso.LabelVisible = false;
            this.barraProgreso.LineProgressThickness = 8;
            this.barraProgreso.LineThickness = 5;
            this.barraProgreso.Location = new System.Drawing.Point(83, 241);
            this.barraProgreso.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.barraProgreso.MaxValue = 100;
            this.barraProgreso.Name = "barraProgreso";
            this.barraProgreso.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.barraProgreso.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(68)))), ((int)(((byte)(91)))));
            this.barraProgreso.Size = new System.Drawing.Size(159, 159);
            this.barraProgreso.TabIndex = 36;
            this.barraProgreso.Value = 30;
            this.barraProgreso.Visible = false;
            // 
            // Cargando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(334, 729);
            this.Controls.Add(this.barraProgreso);
            this.Controls.Add(this.lblMensaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cargando";
            this.Text = "Cargando";
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel lblMensaje;
        private Bunifu.Framework.UI.BunifuCircleProgressbar barraProgreso;
        private System.Windows.Forms.Timer timerPreloader;
        private System.Windows.Forms.Timer timerColor;
        private Bunifu.Framework.UI.BunifuColorTransition colorTransicion;
    }
}