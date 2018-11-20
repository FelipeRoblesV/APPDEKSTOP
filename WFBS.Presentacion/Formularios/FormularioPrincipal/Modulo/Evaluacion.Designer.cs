namespace WFBS.Presentacion.Formularios.FormularioPrincipal.Modulo
{
    partial class Evaluacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Evaluacion));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblDiasHabiles = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lblNombreFormulario = new System.Windows.Forms.Label();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAccion = new System.Windows.Forms.Button();
            this.PanelContenido = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpFechaTermino = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pbEvaluacion = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pbAutoevaluacion = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label3 = new System.Windows.Forms.Label();
            this.numDiasHabiles = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblErrorNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.tbPonderacion = new System.Windows.Forms.TrackBar();
            this.IniciarProceso = new System.ComponentModel.BackgroundWorker();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panelBotones.SuspendLayout();
            this.PanelContenido.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiasHabiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPonderacion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(102)))));
            this.lblNombre.Location = new System.Drawing.Point(12, 6);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(134, 15);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre Evaluacion";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(102)))));
            this.lblFechaInicio.Location = new System.Drawing.Point(12, 70);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(112, 15);
            this.lblFechaInicio.TabIndex = 44;
            this.lblFechaInicio.Text = "Fecha de Inicio ";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CalendarFont = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtpFechaInicio.CalendarMonthBackground = System.Drawing.Color.Blue;
            this.dtpFechaInicio.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dtpFechaInicio.Location = new System.Drawing.Point(15, 88);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(299, 20);
            this.dtpFechaInicio.TabIndex = 45;
            // 
            // lblDiasHabiles
            // 
            this.lblDiasHabiles.AutoSize = true;
            this.lblDiasHabiles.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasHabiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(102)))));
            this.lblDiasHabiles.Location = new System.Drawing.Point(12, 136);
            this.lblDiasHabiles.Name = "lblDiasHabiles";
            this.lblDiasHabiles.Size = new System.Drawing.Size(221, 15);
            this.lblDiasHabiles.TabIndex = 47;
            this.lblDiasHabiles.Text = "Dias para Realizar la Evaluacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(9, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 119;
            this.label1.Text = "Ponderacion";
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
            this.panelTitulo.TabIndex = 123;
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
            this.panelBotones.TabIndex = 124;
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
            this.PanelContenido.Controls.Add(this.panel2);
            this.PanelContenido.Controls.Add(this.panel1);
            this.PanelContenido.Controls.Add(this.label5);
            this.PanelContenido.Controls.Add(this.label6);
            this.PanelContenido.Controls.Add(this.pbEvaluacion);
            this.PanelContenido.Controls.Add(this.label4);
            this.PanelContenido.Controls.Add(this.label10);
            this.PanelContenido.Controls.Add(this.pbAutoevaluacion);
            this.PanelContenido.Controls.Add(this.label3);
            this.PanelContenido.Controls.Add(this.numDiasHabiles);
            this.PanelContenido.Controls.Add(this.label2);
            this.PanelContenido.Controls.Add(this.lblErrorNombre);
            this.PanelContenido.Controls.Add(this.txtNombre);
            this.PanelContenido.Controls.Add(this.tbPonderacion);
            this.PanelContenido.Controls.Add(this.lblNombre);
            this.PanelContenido.Controls.Add(this.lblFechaInicio);
            this.PanelContenido.Controls.Add(this.dtpFechaInicio);
            this.PanelContenido.Controls.Add(this.lblDiasHabiles);
            this.PanelContenido.Controls.Add(this.label1);
            this.PanelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenido.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.PanelContenido.Location = new System.Drawing.Point(0, 25);
            this.PanelContenido.Name = "PanelContenido";
            this.PanelContenido.Size = new System.Drawing.Size(334, 652);
            this.PanelContenido.TabIndex = 125;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(76)))), ((int)(((byte)(98)))));
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.dtpFechaTermino);
            this.panel2.Location = new System.Drawing.Point(12, 206);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 61);
            this.panel2.TabIndex = 172;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(102)))));
            this.label16.Location = new System.Drawing.Point(8, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(141, 14);
            this.label16.TabIndex = 142;
            this.label16.Text = "Fecha Termino Esperada";
            // 
            // dtpFechaTermino
            // 
            this.dtpFechaTermino.CalendarFont = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaTermino.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtpFechaTermino.CalendarMonthBackground = System.Drawing.Color.Blue;
            this.dtpFechaTermino.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dtpFechaTermino.Enabled = false;
            this.dtpFechaTermino.Location = new System.Drawing.Point(10, 28);
            this.dtpFechaTermino.Name = "dtpFechaTermino";
            this.dtpFechaTermino.Size = new System.Drawing.Size(280, 20);
            this.dtpFechaTermino.TabIndex = 172;
            this.dtpFechaTermino.Value = new System.DateTime(2020, 11, 20, 16, 1, 0, 0);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(76)))), ((int)(((byte)(98)))));
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(10, 558);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 88);
            this.panel1.TabIndex = 171;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Roboto Light", 8F);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.label15.Location = new System.Drawing.Point(8, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(277, 16);
            this.label15.TabIndex = 145;
            this.label15.Text = "Es el puntaje maximo posible a sacar como promedio.";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Roboto Light", 8F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.label14.Location = new System.Drawing.Point(8, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(277, 23);
            this.label14.TabIndex = 144;
            this.label14.Text = "Es el puntaje esperado como promedio.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.label13.Location = new System.Drawing.Point(8, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 14);
            this.label13.TabIndex = 143;
            this.label13.Text = "NOTA MAXIMA:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.label12.Location = new System.Drawing.Point(8, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 14);
            this.label12.TabIndex = 142;
            this.label12.Text = "NOTA ESPERADA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.label5.Location = new System.Drawing.Point(126, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 19);
            this.label5.TabIndex = 170;
            this.label5.Text = "Ponderacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.label6.Location = new System.Drawing.Point(168, 504);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 19);
            this.label6.TabIndex = 169;
            this.label6.Text = "Evaluacion";
            // 
            // pbEvaluacion
            // 
            this.pbEvaluacion.animated = false;
            this.pbEvaluacion.animationIterval = 5;
            this.pbEvaluacion.animationSpeed = 300;
            this.pbEvaluacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(84)))), ((int)(((byte)(109)))));
            this.pbEvaluacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbEvaluacion.BackgroundImage")));
            this.pbEvaluacion.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Bold);
            this.pbEvaluacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(136)))));
            this.pbEvaluacion.LabelVisible = true;
            this.pbEvaluacion.LineProgressThickness = 4;
            this.pbEvaluacion.LineThickness = 5;
            this.pbEvaluacion.Location = new System.Drawing.Point(15, 459);
            this.pbEvaluacion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pbEvaluacion.MaxValue = 100;
            this.pbEvaluacion.Name = "pbEvaluacion";
            this.pbEvaluacion.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(76)))), ((int)(((byte)(98)))));
            this.pbEvaluacion.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.pbEvaluacion.Size = new System.Drawing.Size(90, 90);
            this.pbEvaluacion.TabIndex = 168;
            this.pbEvaluacion.Value = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.label4.Location = new System.Drawing.Point(116, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 167;
            this.label4.Text = "Ponderacion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 12F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.label10.Location = new System.Drawing.Point(141, 400);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 19);
            this.label10.TabIndex = 166;
            this.label10.Text = "Auto-Evaluacion";
            // 
            // pbAutoevaluacion
            // 
            this.pbAutoevaluacion.animated = false;
            this.pbAutoevaluacion.animationIterval = 5;
            this.pbAutoevaluacion.animationSpeed = 300;
            this.pbAutoevaluacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(84)))), ((int)(((byte)(109)))));
            this.pbAutoevaluacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbAutoevaluacion.BackgroundImage")));
            this.pbAutoevaluacion.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Bold);
            this.pbAutoevaluacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(136)))));
            this.pbAutoevaluacion.LabelVisible = true;
            this.pbAutoevaluacion.LineProgressThickness = 4;
            this.pbAutoevaluacion.LineThickness = 5;
            this.pbAutoevaluacion.Location = new System.Drawing.Point(15, 361);
            this.pbAutoevaluacion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pbAutoevaluacion.MaxValue = 100;
            this.pbAutoevaluacion.Name = "pbAutoevaluacion";
            this.pbAutoevaluacion.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(76)))), ((int)(((byte)(98)))));
            this.pbAutoevaluacion.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.pbAutoevaluacion.Size = new System.Drawing.Size(90, 90);
            this.pbAutoevaluacion.TabIndex = 165;
            this.pbAutoevaluacion.Value = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 9F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(63)))), ((int)(((byte)(44)))));
            this.label3.Location = new System.Drawing.Point(9, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 14);
            this.label3.TabIndex = 163;
            this.label3.Text = "Texto de error para el nombre del funcionario";
            this.label3.Visible = false;
            // 
            // numDiasHabiles
            // 
            this.numDiasHabiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(76)))), ((int)(((byte)(98)))));
            this.numDiasHabiles.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDiasHabiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(136)))));
            this.numDiasHabiles.Location = new System.Drawing.Point(15, 154);
            this.numDiasHabiles.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numDiasHabiles.Name = "numDiasHabiles";
            this.numDiasHabiles.Size = new System.Drawing.Size(299, 23);
            this.numDiasHabiles.TabIndex = 162;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(63)))), ((int)(((byte)(44)))));
            this.label2.Location = new System.Drawing.Point(9, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 14);
            this.label2.TabIndex = 160;
            this.label2.Text = "Texto de error para el nombre del funcionario";
            this.label2.Visible = false;
            // 
            // lblErrorNombre
            // 
            this.lblErrorNombre.AutoSize = true;
            this.lblErrorNombre.Font = new System.Drawing.Font("Roboto", 9F);
            this.lblErrorNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(63)))), ((int)(((byte)(44)))));
            this.lblErrorNombre.Location = new System.Drawing.Point(12, 50);
            this.lblErrorNombre.Name = "lblErrorNombre";
            this.lblErrorNombre.Size = new System.Drawing.Size(249, 14);
            this.lblErrorNombre.TabIndex = 159;
            this.lblErrorNombre.Text = "Texto de error para el nombre del funcionario";
            this.lblErrorNombre.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(76)))), ((int)(((byte)(98)))));
            this.txtNombre.Font = new System.Drawing.Font("Roboto Light", 9.75F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(136)))));
            this.txtNombre.Location = new System.Drawing.Point(15, 24);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(299, 23);
            this.txtNombre.TabIndex = 157;
            // 
            // tbPonderacion
            // 
            this.tbPonderacion.Location = new System.Drawing.Point(12, 300);
            this.tbPonderacion.Maximum = 100;
            this.tbPonderacion.Name = "tbPonderacion";
            this.tbPonderacion.Size = new System.Drawing.Size(302, 45);
            this.tbPonderacion.TabIndex = 123;
            this.tbPonderacion.TickFrequency = 5;
            this.tbPonderacion.Value = 30;
            this.tbPonderacion.ValueChanged += new System.EventHandler(this.tbPonderacion_ValueChanged);
            // 
            // IniciarProceso
            // 
            this.IniciarProceso.WorkerReportsProgress = true;
            this.IniciarProceso.DoWork += new System.ComponentModel.DoWorkEventHandler(this.IniciarProceso_DoWork);
            this.IniciarProceso.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.IniciarProceso_ProgressChanged);
            // 
            // Evaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(334, 729);
            this.Controls.Add(this.PanelContenido);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Evaluacion";
            this.Text = "Evaluacion";
            this.panelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panelBotones.ResumeLayout(false);
            this.PanelContenido.ResumeLayout(false);
            this.PanelContenido.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiasHabiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPonderacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblDiasHabiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label lblNombreFormulario;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAccion;
        private System.Windows.Forms.Panel PanelContenido;
        private System.Windows.Forms.TrackBar tbPonderacion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblErrorNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numDiasHabiles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuCircleProgressbar pbEvaluacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuCircleProgressbar pbAutoevaluacion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpFechaTermino;
        private System.ComponentModel.BackgroundWorker IniciarProceso;
    }
}