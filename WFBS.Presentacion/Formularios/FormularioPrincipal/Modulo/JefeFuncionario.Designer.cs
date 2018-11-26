namespace WFBS.Presentacion.Formularios.FormularioPrincipal.Modulo
{
    partial class JefeFuncionario
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
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lblNombreFormulario = new System.Windows.Forms.Label();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.txtRutFuncionario = new System.Windows.Forms.TextBox();
            this.btnVerificarFuncionario = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblRutFuncionario = new System.Windows.Forms.Label();
            this.lblErrorRut = new System.Windows.Forms.Label();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAccion = new System.Windows.Forms.Button();
            this.PanelContenido = new System.Windows.Forms.Panel();
            this.IniciarProceso = new System.ComponentModel.BackgroundWorker();
            this.CargarWebService = new System.ComponentModel.BackgroundWorker();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerificarFuncionario)).BeginInit();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
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
            this.panelTitulo.TabIndex = 51;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.Image = global::WFBS.Presentacion.Properties.Resources.icons8_cerrar_ventana_48;
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
            this.lblNombreFormulario.Font = new System.Drawing.Font("Roboto Medium", 13F, System.Drawing.FontStyle.Bold);
            this.lblNombreFormulario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.lblNombreFormulario.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblNombreFormulario.Location = new System.Drawing.Point(45, 1);
            this.lblNombreFormulario.Name = "lblNombreFormulario";
            this.lblNombreFormulario.Size = new System.Drawing.Size(288, 23);
            this.lblNombreFormulario.TabIndex = 45;
            this.lblNombreFormulario.Text = "Nombre Evaluacion";
            this.lblNombreFormulario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.panelSuperior.Controls.Add(this.txtRutFuncionario);
            this.panelSuperior.Controls.Add(this.btnVerificarFuncionario);
            this.panelSuperior.Controls.Add(this.lblRutFuncionario);
            this.panelSuperior.Controls.Add(this.lblErrorRut);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 25);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.panelSuperior.Size = new System.Drawing.Size(334, 77);
            this.panelSuperior.TabIndex = 53;
            this.panelSuperior.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSuperior_Paint);
            // 
            // txtRutFuncionario
            // 
            this.txtRutFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(84)))), ((int)(((byte)(109)))));
            this.txtRutFuncionario.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.txtRutFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(136)))));
            this.txtRutFuncionario.Location = new System.Drawing.Point(21, 30);
            this.txtRutFuncionario.MaxLength = 13;
            this.txtRutFuncionario.Name = "txtRutFuncionario";
            this.txtRutFuncionario.Size = new System.Drawing.Size(256, 27);
            this.txtRutFuncionario.TabIndex = 40;
            this.txtRutFuncionario.TextChanged += new System.EventHandler(this.txtRutFuncionario_TextChanged);
            this.txtRutFuncionario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGeneral_KeyDown);
            this.txtRutFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRutFuncionario_KeyPress);
            // 
            // btnVerificarFuncionario
            // 
            this.btnVerificarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.btnVerificarFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerificarFuncionario.Image = global::WFBS.Presentacion.Properties.Resources.icons8_búsqueda_32_5_;
            this.btnVerificarFuncionario.ImageActive = null;
            this.btnVerificarFuncionario.Location = new System.Drawing.Point(280, 30);
            this.btnVerificarFuncionario.Name = "btnVerificarFuncionario";
            this.btnVerificarFuncionario.Size = new System.Drawing.Size(28, 25);
            this.btnVerificarFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVerificarFuncionario.TabIndex = 39;
            this.btnVerificarFuncionario.TabStop = false;
            this.btnVerificarFuncionario.Visible = false;
            this.btnVerificarFuncionario.Zoom = 10;
            this.btnVerificarFuncionario.Click += new System.EventHandler(this.btnVerificarFuncionario_Click);
            // 
            // lblRutFuncionario
            // 
            this.lblRutFuncionario.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold);
            this.lblRutFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(102)))));
            this.lblRutFuncionario.Location = new System.Drawing.Point(17, 13);
            this.lblRutFuncionario.Name = "lblRutFuncionario";
            this.lblRutFuncionario.Size = new System.Drawing.Size(250, 20);
            this.lblRutFuncionario.TabIndex = 37;
            this.lblRutFuncionario.Text = "Rut del jefe funcionario";
            // 
            // lblErrorRut
            // 
            this.lblErrorRut.AutoSize = true;
            this.lblErrorRut.Font = new System.Drawing.Font("Roboto Light", 11F);
            this.lblErrorRut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(83)))), ((int)(((byte)(66)))));
            this.lblErrorRut.Location = new System.Drawing.Point(17, 56);
            this.lblErrorRut.Name = "lblErrorRut";
            this.lblErrorRut.Size = new System.Drawing.Size(300, 18);
            this.lblErrorRut.TabIndex = 33;
            this.lblErrorRut.Text = "Texto de error para el nombre del funcionario";
            this.lblErrorRut.Visible = false;
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
            this.panelBotones.TabIndex = 54;
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
            this.PanelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenido.Location = new System.Drawing.Point(0, 102);
            this.PanelContenido.Name = "PanelContenido";
            this.PanelContenido.Size = new System.Drawing.Size(334, 575);
            this.PanelContenido.TabIndex = 55;
            // 
            // IniciarProceso
            // 
            this.IniciarProceso.WorkerReportsProgress = true;
            this.IniciarProceso.DoWork += new System.ComponentModel.DoWorkEventHandler(this.IniciarProceso_DoWork);
            this.IniciarProceso.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.IniciarProceso_ProgressChanged);
            // 
            // CargarWebService
            // 
            this.CargarWebService.WorkerReportsProgress = true;
            this.CargarWebService.DoWork += new System.ComponentModel.DoWorkEventHandler(this.CargarWebService_DoWork);
            this.CargarWebService.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.CargarWebService_ProgressChanged);
            // 
            // JefeFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(334, 729);
            this.Controls.Add(this.PanelContenido);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JefeFuncionario";
            this.Text = "JefeFuncionario";
            this.panelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerificarFuncionario)).EndInit();
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label lblNombreFormulario;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.TextBox txtRutFuncionario;
        private Bunifu.Framework.UI.BunifuImageButton btnVerificarFuncionario;
        private System.Windows.Forms.Label lblRutFuncionario;
        private System.Windows.Forms.Label lblErrorRut;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAccion;
        private System.Windows.Forms.Panel PanelContenido;
        private System.ComponentModel.BackgroundWorker IniciarProceso;
        private System.ComponentModel.BackgroundWorker CargarWebService;
    }
}