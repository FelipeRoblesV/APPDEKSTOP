namespace WFBS.Presentacion.Formularios.Login.Modulo
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
            this.panelFooter = new System.Windows.Forms.Panel();
            this.separador_footer = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblVersion = new System.Windows.Forms.Label();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.timerPreloader = new System.Windows.Forms.Timer(this.components);
            this.timerColor = new System.Windows.Forms.Timer(this.components);
            this.colorTransicion = new Bunifu.Framework.UI.BunifuColorTransition(this.components);
            this.barraProgreso = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.panelFooter.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Roboto Light", 15F);
            this.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(216)))), ((int)(((byte)(165)))));
            this.lblMensaje.Location = new System.Drawing.Point(12, 398);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(240, 85);
            this.lblMensaje.TabIndex = 32;
            this.lblMensaje.Text = "Iniciando el formulario";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMensaje.Visible = false;
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.separador_footer);
            this.panelFooter.Controls.Add(this.lblVersion);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 827);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(264, 42);
            this.panelFooter.TabIndex = 33;
            // 
            // separador_footer
            // 
            this.separador_footer.BackColor = System.Drawing.Color.Transparent;
            this.separador_footer.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.separador_footer.LineThickness = 1;
            this.separador_footer.Location = new System.Drawing.Point(0, 0);
            this.separador_footer.Name = "separador_footer";
            this.separador_footer.Size = new System.Drawing.Size(246, 10);
            this.separador_footer.TabIndex = 51;
            this.separador_footer.Transparency = 255;
            this.separador_footer.Vertical = false;
            // 
            // lblVersion
            // 
            this.lblVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVersion.Font = new System.Drawing.Font("Roboto Light", 9.75F);
            this.lblVersion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblVersion.Location = new System.Drawing.Point(0, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(264, 42);
            this.lblVersion.TabIndex = 5;
            this.lblVersion.Text = "V2.2.1 - APLICACION DE ESCRITORIO";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.barraProgreso);
            this.panelPrincipal.Controls.Add(this.lblMensaje);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(264, 827);
            this.panelPrincipal.TabIndex = 34;
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
            this.barraProgreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.barraProgreso.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barraProgreso.BackgroundImage")));
            this.barraProgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.barraProgreso.ForeColor = System.Drawing.Color.SeaGreen;
            this.barraProgreso.LabelVisible = false;
            this.barraProgreso.LineProgressThickness = 8;
            this.barraProgreso.LineThickness = 5;
            this.barraProgreso.Location = new System.Drawing.Point(85, 296);
            this.barraProgreso.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.barraProgreso.MaxValue = 100;
            this.barraProgreso.Name = "barraProgreso";
            this.barraProgreso.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.barraProgreso.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(68)))), ((int)(((byte)(91)))));
            this.barraProgreso.Size = new System.Drawing.Size(93, 93);
            this.barraProgreso.TabIndex = 31;
            this.barraProgreso.Value = 30;
            this.barraProgreso.Visible = false;
            // 
            // Cargando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(264, 869);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelFooter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cargando";
            this.Text = "CargandoFormulario";
            this.panelFooter.ResumeLayout(false);
            this.panelPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lblMensaje;
        private Bunifu.Framework.UI.BunifuCircleProgressbar barraProgreso;
        private System.Windows.Forms.Panel panelFooter;
        private Bunifu.Framework.UI.BunifuSeparator separador_footer;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Timer timerPreloader;
        private System.Windows.Forms.Timer timerColor;
        private Bunifu.Framework.UI.BunifuColorTransition colorTransicion;
    }
}