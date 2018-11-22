namespace WFBS.Presentacion.Formularios.FormularioPrincipal.Modulo.Modulos_Adicionales
{
    partial class CargoFuncionario
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
            this.lbCargoIn = new System.Windows.Forms.ListBox();
            this.lbCargoOut = new System.Windows.Forms.ListBox();
            this.btnAgregar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnEliminar = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lblNombreFormulario = new System.Windows.Forms.Label();
            this.CargarFormulario = new System.ComponentModel.BackgroundWorker();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCargoIn
            // 
            this.lbCargoIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(76)))), ((int)(((byte)(98)))));
            this.lbCargoIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbCargoIn.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbCargoIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(230)))), ((int)(((byte)(192)))));
            this.lbCargoIn.FormattingEnabled = true;
            this.lbCargoIn.HorizontalScrollbar = true;
            this.lbCargoIn.ItemHeight = 18;
            this.lbCargoIn.Items.AddRange(new object[] {
            "EJEMPLO 1",
            "EJEMPLO 2",
            "EJEMPLO 3",
            "EJEMPLO 4",
            "EJEMPLO 5",
            "EJEMPLO 6",
            "EJEMPLO 7",
            "EJEMPLO 8",
            "EJEMPLO 9"});
            this.lbCargoIn.Location = new System.Drawing.Point(12, 48);
            this.lbCargoIn.Name = "lbCargoIn";
            this.lbCargoIn.Size = new System.Drawing.Size(310, 306);
            this.lbCargoIn.TabIndex = 52;
            // 
            // lbCargoOut
            // 
            this.lbCargoOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(76)))), ((int)(((byte)(98)))));
            this.lbCargoOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbCargoOut.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbCargoOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(230)))), ((int)(((byte)(192)))));
            this.lbCargoOut.FormattingEnabled = true;
            this.lbCargoOut.HorizontalScrollbar = true;
            this.lbCargoOut.ItemHeight = 18;
            this.lbCargoOut.Items.AddRange(new object[] {
            "EJEMPLO 1",
            "EJEMPLO 2",
            "EJEMPLO 3",
            "EJEMPLO 4",
            "EJEMPLO 5",
            "EJEMPLO 6",
            "EJEMPLO 7",
            "EJEMPLO 8",
            "EJEMPLO 9"});
            this.lbCargoOut.Location = new System.Drawing.Point(12, 393);
            this.lbCargoOut.Name = "lbCargoOut";
            this.lbCargoOut.Size = new System.Drawing.Size(310, 324);
            this.lbCargoOut.TabIndex = 53;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(84)))), ((int)(((byte)(109)))));
            this.btnAgregar.Image = global::WFBS.Presentacion.Properties.Resources.flecha_hacia_arriba;
            this.btnAgregar.ImageActive = null;
            this.btnAgregar.Location = new System.Drawing.Point(263, 362);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(25, 25);
            this.btnAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAgregar.TabIndex = 55;
            this.btnAgregar.TabStop = false;
            this.btnAgregar.Zoom = 10;
            this.btnAgregar.Click += new System.EventHandler(this.btnGeneral_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(84)))), ((int)(((byte)(109)))));
            this.btnEliminar.Image = global::WFBS.Presentacion.Properties.Resources.flecha_hacia_abajo;
            this.btnEliminar.ImageActive = null;
            this.btnEliminar.Location = new System.Drawing.Point(204, 362);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(25, 25);
            this.btnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEliminar.TabIndex = 54;
            this.btnEliminar.TabStop = false;
            this.btnEliminar.Zoom = 10;
            this.btnEliminar.Click += new System.EventHandler(this.btnGeneral_Click);
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
            this.panelTitulo.TabIndex = 139;
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
            // CargarFormulario
            // 
            this.CargarFormulario.WorkerReportsProgress = true;
            this.CargarFormulario.DoWork += new System.ComponentModel.DoWorkEventHandler(this.CargarFormulario_DoWork);
            this.CargarFormulario.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.CargarFormulario_ProgressChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 30);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(155, 15);
            this.bunifuCustomLabel1.TabIndex = 140;
            this.bunifuCustomLabel1.Text = "Cargos Seleccionados";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(9, 375);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(136, 15);
            this.bunifuCustomLabel2.TabIndex = 141;
            this.bunifuCustomLabel2.Text = "Cargos Disponibles";
            // 
            // CargoFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(84)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(334, 729);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lbCargoOut);
            this.Controls.Add(this.lbCargoIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CargoFuncionario";
            this.Text = "CargoFuncionario";
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbCargoIn;
        private System.Windows.Forms.ListBox lbCargoOut;
        private Bunifu.Framework.UI.BunifuImageButton btnEliminar;
        private Bunifu.Framework.UI.BunifuImageButton btnAgregar;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label lblNombreFormulario;
        private System.ComponentModel.BackgroundWorker CargarFormulario;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
    }
}