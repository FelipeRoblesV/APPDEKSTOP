namespace WFBS.Presentacion.Formularios.FormularioPrincipal.Modulo
{
    partial class Observacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Observacion));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRecuerdame = new System.Windows.Forms.Label();
            this.chkNivel = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblErrorMensaje = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lblNombreFormulario = new System.Windows.Forms.Label();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAccion = new System.Windows.Forms.Button();
            this.PanelContenido = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMensaje = new System.Windows.Forms.RichTextBox();
            this.IniciarProceso = new System.ComponentModel.BackgroundWorker();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panelBotones.SuspendLayout();
            this.PanelContenido.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.lblNombre.Location = new System.Drawing.Point(12, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(150, 15);
            this.lblNombre.TabIndex = 55;
            this.lblNombre.Text = "Mensaje Observacion";
            // 
            // lblRecuerdame
            // 
            this.lblRecuerdame.AutoSize = true;
            this.lblRecuerdame.Font = new System.Drawing.Font("Roboto Medium", 11.75F, System.Drawing.FontStyle.Bold);
            this.lblRecuerdame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.lblRecuerdame.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRecuerdame.Location = new System.Drawing.Point(44, 223);
            this.lblRecuerdame.Name = "lblRecuerdame";
            this.lblRecuerdame.Size = new System.Drawing.Size(128, 19);
            this.lblRecuerdame.TabIndex = 66;
            this.lblRecuerdame.Text = "¿Es nivel Alto?";
            // 
            // chkNivel
            // 
            this.chkNivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkNivel.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkNivel.Checked = false;
            this.chkNivel.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.chkNivel.ForeColor = System.Drawing.Color.White;
            this.chkNivel.Location = new System.Drawing.Point(15, 222);
            this.chkNivel.Name = "chkNivel";
            this.chkNivel.Size = new System.Drawing.Size(20, 20);
            this.chkNivel.TabIndex = 65;
            // 
            // lblErrorMensaje
            // 
            this.lblErrorMensaje.AutoSize = true;
            this.lblErrorMensaje.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(83)))), ((int)(((byte)(66)))));
            this.lblErrorMensaje.Location = new System.Drawing.Point(9, 184);
            this.lblErrorMensaje.Name = "lblErrorMensaje";
            this.lblErrorMensaje.Size = new System.Drawing.Size(258, 15);
            this.lblErrorMensaje.TabIndex = 126;
            this.lblErrorMensaje.Text = "Texto de error para el nombre del funcionario";
            this.lblErrorMensaje.Visible = false;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.label16.Location = new System.Drawing.Point(8, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(292, 82);
            this.label16.TabIndex = 147;
            this.label16.Text = resources.GetString("label16.Text");
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panelTitulo.Controls.Add(this.btnCerrar);
            this.panelTitulo.Controls.Add(this.lblNombreFormulario);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Padding = new System.Windows.Forms.Padding(45, 1, 1, 1);
            this.panelTitulo.Size = new System.Drawing.Size(334, 25);
            this.panelTitulo.TabIndex = 148;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.Image = global::WFBS.Presentacion.Properties.Resources.flat_style_circle_block_icon_icons_com_66946;
            this.btnCerrar.Location = new System.Drawing.Point(303, 1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Padding = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Size = new System.Drawing.Size(30, 23);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 46;
            this.btnCerrar.TabStop = false;
            // 
            // lblNombreFormulario
            // 
            this.lblNombreFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.lblNombreFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombreFormulario.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Bold);
            this.lblNombreFormulario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.lblNombreFormulario.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblNombreFormulario.Location = new System.Drawing.Point(45, 1);
            this.lblNombreFormulario.Name = "lblNombreFormulario";
            this.lblNombreFormulario.Size = new System.Drawing.Size(288, 23);
            this.lblNombreFormulario.TabIndex = 45;
            this.lblNombreFormulario.Text = "Nombre Evaluacion";
            this.lblNombreFormulario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panelBotones.Controls.Add(this.btnLimpiar);
            this.panelBotones.Controls.Add(this.btnAccion);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotones.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBotones.Location = new System.Drawing.Point(0, 677);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(334, 52);
            this.panelBotones.TabIndex = 149;
            this.panelBotones.Visible = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(92)))), ((int)(((byte)(119)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(223, 6);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(82, 40);
            this.btnLimpiar.TabIndex = 135;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnAccion
            // 
            this.btnAccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(92)))), ((int)(((byte)(119)))));
            this.btnAccion.FlatAppearance.BorderSize = 0;
            this.btnAccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccion.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAccion.ForeColor = System.Drawing.Color.White;
            this.btnAccion.Location = new System.Drawing.Point(21, 6);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(196, 40);
            this.btnAccion.TabIndex = 134;
            this.btnAccion.Text = "Accion";
            this.btnAccion.UseVisualStyleBackColor = false;
            // 
            // PanelContenido
            // 
            this.PanelContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(84)))), ((int)(((byte)(109)))));
            this.PanelContenido.Controls.Add(this.panel1);
            this.PanelContenido.Controls.Add(this.txtMensaje);
            this.PanelContenido.Controls.Add(this.lblNombre);
            this.PanelContenido.Controls.Add(this.chkNivel);
            this.PanelContenido.Controls.Add(this.lblRecuerdame);
            this.PanelContenido.Controls.Add(this.lblErrorMensaje);
            this.PanelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenido.Location = new System.Drawing.Point(0, 25);
            this.PanelContenido.Name = "PanelContenido";
            this.PanelContenido.Size = new System.Drawing.Size(334, 652);
            this.PanelContenido.TabIndex = 150;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(76)))), ((int)(((byte)(98)))));
            this.panel1.Controls.Add(this.label16);
            this.panel1.Location = new System.Drawing.Point(10, 546);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 100);
            this.panel1.TabIndex = 149;
            // 
            // txtMensaje
            // 
            this.txtMensaje.AutoWordSelection = true;
            this.txtMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(84)))), ((int)(((byte)(109)))));
            this.txtMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(136)))));
            this.txtMensaje.Location = new System.Drawing.Point(12, 27);
            this.txtMensaje.MaxLength = 300;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(312, 154);
            this.txtMensaje.TabIndex = 148;
            this.txtMensaje.Text = "";
            // 
            // IniciarProceso
            // 
            this.IniciarProceso.WorkerReportsProgress = true;
            this.IniciarProceso.DoWork += new System.ComponentModel.DoWorkEventHandler(this.IniciarProceso_DoWork);
            // 
            // Observacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(334, 729);
            this.Controls.Add(this.PanelContenido);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Observacion";
            this.Text = "Observacion";
            this.panelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panelBotones.ResumeLayout(false);
            this.PanelContenido.ResumeLayout(false);
            this.PanelContenido.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRecuerdame;
        private Bunifu.Framework.UI.BunifuCheckbox chkNivel;
        private System.Windows.Forms.Label lblErrorMensaje;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label lblNombreFormulario;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAccion;
        private System.Windows.Forms.Panel PanelContenido;
        private System.Windows.Forms.RichTextBox txtMensaje;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker IniciarProceso;
    }
}