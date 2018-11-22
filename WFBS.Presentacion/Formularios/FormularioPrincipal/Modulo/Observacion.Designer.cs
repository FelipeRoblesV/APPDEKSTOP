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
            this.label16 = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lblNombreFormulario = new System.Windows.Forms.Label();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAccion = new System.Windows.Forms.Button();
            this.PanelContenido = new System.Windows.Forms.Panel();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.lblErrorMensaje = new System.Windows.Forms.Label();
            this.lblErrorNivel = new System.Windows.Forms.Label();
            this.rbBajo = new System.Windows.Forms.RadioButton();
            this.rbAlto = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(102)))));
            this.lblNombre.Location = new System.Drawing.Point(12, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(150, 15);
            this.lblNombre.TabIndex = 55;
            this.lblNombre.Text = "Mensaje Observacion";
            // 
            // lblRecuerdame
            // 
            this.lblRecuerdame.AutoSize = true;
            this.lblRecuerdame.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblRecuerdame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(102)))));
            this.lblRecuerdame.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRecuerdame.Location = new System.Drawing.Point(12, 192);
            this.lblRecuerdame.Name = "lblRecuerdame";
            this.lblRecuerdame.Size = new System.Drawing.Size(127, 15);
            this.lblRecuerdame.TabIndex = 66;
            this.lblRecuerdame.Text = "Nivel Observacion";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.label16.Location = new System.Drawing.Point(8, 25);
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
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
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
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
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
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // 
            // PanelContenido
            // 
            this.PanelContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(84)))), ((int)(((byte)(109)))));
            this.PanelContenido.Controls.Add(this.txtMensaje);
            this.PanelContenido.Controls.Add(this.lblErrorMensaje);
            this.PanelContenido.Controls.Add(this.lblErrorNivel);
            this.PanelContenido.Controls.Add(this.rbBajo);
            this.PanelContenido.Controls.Add(this.rbAlto);
            this.PanelContenido.Controls.Add(this.panel1);
            this.PanelContenido.Controls.Add(this.lblNombre);
            this.PanelContenido.Controls.Add(this.lblRecuerdame);
            this.PanelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenido.Location = new System.Drawing.Point(0, 25);
            this.PanelContenido.Name = "PanelContenido";
            this.PanelContenido.Size = new System.Drawing.Size(334, 652);
            this.PanelContenido.TabIndex = 150;
            // 
            // txtMensaje
            // 
            this.txtMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(84)))), ((int)(((byte)(109)))));
            this.txtMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(136)))));
            this.txtMensaje.Location = new System.Drawing.Point(12, 27);
            this.txtMensaje.MaxLength = 1000;
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(310, 131);
            this.txtMensaje.TabIndex = 155;
            // 
            // lblErrorMensaje
            // 
            this.lblErrorMensaje.AutoSize = true;
            this.lblErrorMensaje.Font = new System.Drawing.Font("Roboto", 9F);
            this.lblErrorMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(63)))), ((int)(((byte)(44)))));
            this.lblErrorMensaje.Location = new System.Drawing.Point(9, 161);
            this.lblErrorMensaje.Name = "lblErrorMensaje";
            this.lblErrorMensaje.Size = new System.Drawing.Size(249, 14);
            this.lblErrorMensaje.TabIndex = 154;
            this.lblErrorMensaje.Text = "Texto de error para el nombre del funcionario";
            this.lblErrorMensaje.Visible = false;
            // 
            // lblErrorNivel
            // 
            this.lblErrorNivel.AutoSize = true;
            this.lblErrorNivel.Font = new System.Drawing.Font("Roboto", 9F);
            this.lblErrorNivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(63)))), ((int)(((byte)(44)))));
            this.lblErrorNivel.Location = new System.Drawing.Point(12, 239);
            this.lblErrorNivel.Name = "lblErrorNivel";
            this.lblErrorNivel.Size = new System.Drawing.Size(249, 14);
            this.lblErrorNivel.TabIndex = 153;
            this.lblErrorNivel.Text = "Texto de error para el nombre del funcionario";
            this.lblErrorNivel.Visible = false;
            // 
            // rbBajo
            // 
            this.rbBajo.AutoSize = true;
            this.rbBajo.FlatAppearance.BorderSize = 0;
            this.rbBajo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.rbBajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbBajo.Font = new System.Drawing.Font("Roboto Light", 13F);
            this.rbBajo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(102)))));
            this.rbBajo.Location = new System.Drawing.Point(173, 210);
            this.rbBajo.Name = "rbBajo";
            this.rbBajo.Size = new System.Drawing.Size(105, 26);
            this.rbBajo.TabIndex = 151;
            this.rbBajo.TabStop = true;
            this.rbBajo.Text = "Nivel Bajo";
            this.rbBajo.UseVisualStyleBackColor = true;
            // 
            // rbAlto
            // 
            this.rbAlto.AutoSize = true;
            this.rbAlto.FlatAppearance.BorderSize = 0;
            this.rbAlto.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.rbAlto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbAlto.Font = new System.Drawing.Font("Roboto Light", 13F);
            this.rbAlto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(102)))));
            this.rbAlto.Location = new System.Drawing.Point(38, 210);
            this.rbAlto.Name = "rbAlto";
            this.rbAlto.Size = new System.Drawing.Size(101, 26);
            this.rbAlto.TabIndex = 150;
            this.rbAlto.TabStop = true;
            this.rbAlto.Text = "Nivel Alto";
            this.rbAlto.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(76)))), ((int)(((byte)(98)))));
            this.panel1.Controls.Add(this.label16);
            this.panel1.Location = new System.Drawing.Point(10, 519);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 127);
            this.panel1.TabIndex = 149;
            // 
            // IniciarProceso
            // 
            this.IniciarProceso.WorkerReportsProgress = true;
            this.IniciarProceso.DoWork += new System.ComponentModel.DoWorkEventHandler(this.IniciarProceso_DoWork);
            this.IniciarProceso.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.IniciarProceso_ProgressChanged);
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
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label lblNombreFormulario;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAccion;
        private System.Windows.Forms.Panel PanelContenido;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker IniciarProceso;
        private System.Windows.Forms.RadioButton rbBajo;
        private System.Windows.Forms.RadioButton rbAlto;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Label lblErrorMensaje;
        private System.Windows.Forms.Label lblErrorNivel;
    }
}