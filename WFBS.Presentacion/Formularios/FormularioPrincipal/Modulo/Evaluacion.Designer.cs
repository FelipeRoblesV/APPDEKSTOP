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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnLimpiar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAccion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblDiasHabiles = new System.Windows.Forms.Label();
            this.txtDiasHabiles = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tbPonderacion = new Bunifu.Framework.UI.BunifuTrackbar();
            this.lblAuto = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPonderacionAuto = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblEva = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPonderacionEvaluacion = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErrorNombre = new System.Windows.Forms.Label();
            this.lblFechaError = new System.Windows.Forms.Label();
            this.lblDiasHabilesError = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblNombreFormulario = new System.Windows.Forms.Label();
            this.panelBotones.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.lblNombre.Location = new System.Drawing.Point(9, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(134, 15);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre Evaluacion";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.txtNombre.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(216)))), ((int)(((byte)(165)))));
            this.txtNombre.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.txtNombre.BorderThickness = 3;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(230)))), ((int)(((byte)(192)))));
            this.txtNombre.isPassword = false;
            this.txtNombre.Location = new System.Drawing.Point(12, 52);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(307, 23);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            this.panelBotones.Controls.Add(this.btnLimpiar);
            this.panelBotones.Controls.Add(this.btnAccion);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotones.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBotones.Location = new System.Drawing.Point(0, 696);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(334, 33);
            this.panelBotones.TabIndex = 42;
            this.panelBotones.Visible = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(92)))), ((int)(((byte)(119)))));
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.BorderRadius = 0;
            this.btnLimpiar.ButtonText = "Limpiar";
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.DisabledColor = System.Drawing.Color.Gray;
            this.btnLimpiar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLimpiar.Iconimage = null;
            this.btnLimpiar.Iconimage_right = null;
            this.btnLimpiar.Iconimage_right_Selected = null;
            this.btnLimpiar.Iconimage_Selected = null;
            this.btnLimpiar.IconMarginLeft = 0;
            this.btnLimpiar.IconMarginRight = 0;
            this.btnLimpiar.IconRightVisible = true;
            this.btnLimpiar.IconRightZoom = 0D;
            this.btnLimpiar.IconVisible = true;
            this.btnLimpiar.IconZoom = 90D;
            this.btnLimpiar.IsTab = false;
            this.btnLimpiar.Location = new System.Drawing.Point(179, 6);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(92)))), ((int)(((byte)(119)))));
            this.btnLimpiar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnLimpiar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLimpiar.selected = false;
            this.btnLimpiar.Size = new System.Drawing.Size(142, 23);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLimpiar.Textcolor = System.Drawing.Color.White;
            this.btnLimpiar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnAccion
            // 
            this.btnAccion.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(92)))), ((int)(((byte)(119)))));
            this.btnAccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccion.BorderRadius = 0;
            this.btnAccion.ButtonText = "Accion";
            this.btnAccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccion.DisabledColor = System.Drawing.Color.Gray;
            this.btnAccion.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAccion.Iconimage = null;
            this.btnAccion.Iconimage_right = null;
            this.btnAccion.Iconimage_right_Selected = null;
            this.btnAccion.Iconimage_Selected = null;
            this.btnAccion.IconMarginLeft = 0;
            this.btnAccion.IconMarginRight = 0;
            this.btnAccion.IconRightVisible = true;
            this.btnAccion.IconRightZoom = 0D;
            this.btnAccion.IconVisible = true;
            this.btnAccion.IconZoom = 90D;
            this.btnAccion.IsTab = false;
            this.btnAccion.Location = new System.Drawing.Point(12, 6);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(92)))), ((int)(((byte)(119)))));
            this.btnAccion.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAccion.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAccion.selected = false;
            this.btnAccion.Size = new System.Drawing.Size(147, 23);
            this.btnAccion.TabIndex = 0;
            this.btnAccion.Text = "Accion";
            this.btnAccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAccion.Textcolor = System.Drawing.Color.White;
            this.btnAccion.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.lblFechaInicio.Location = new System.Drawing.Point(12, 104);
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
            this.dtpFechaInicio.Location = new System.Drawing.Point(12, 122);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(305, 20);
            this.dtpFechaInicio.TabIndex = 45;
            // 
            // lblDiasHabiles
            // 
            this.lblDiasHabiles.AutoSize = true;
            this.lblDiasHabiles.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasHabiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.lblDiasHabiles.Location = new System.Drawing.Point(9, 169);
            this.lblDiasHabiles.Name = "lblDiasHabiles";
            this.lblDiasHabiles.Size = new System.Drawing.Size(91, 15);
            this.lblDiasHabiles.TabIndex = 47;
            this.lblDiasHabiles.Text = "Dias Habiles";
            // 
            // txtDiasHabiles
            // 
            this.txtDiasHabiles.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.txtDiasHabiles.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(216)))), ((int)(((byte)(165)))));
            this.txtDiasHabiles.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.txtDiasHabiles.BorderThickness = 3;
            this.txtDiasHabiles.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiasHabiles.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiasHabiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(230)))), ((int)(((byte)(192)))));
            this.txtDiasHabiles.isPassword = false;
            this.txtDiasHabiles.Location = new System.Drawing.Point(13, 189);
            this.txtDiasHabiles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiasHabiles.Name = "txtDiasHabiles";
            this.txtDiasHabiles.Size = new System.Drawing.Size(304, 23);
            this.txtDiasHabiles.TabIndex = 46;
            this.txtDiasHabiles.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbPonderacion
            // 
            this.tbPonderacion.BackColor = System.Drawing.Color.Transparent;
            this.tbPonderacion.BackgroudColor = System.Drawing.Color.DarkGray;
            this.tbPonderacion.BorderRadius = 0;
            this.tbPonderacion.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.tbPonderacion.Location = new System.Drawing.Point(12, 260);
            this.tbPonderacion.MaximumValue = 100;
            this.tbPonderacion.Name = "tbPonderacion";
            this.tbPonderacion.Size = new System.Drawing.Size(305, 30);
            this.tbPonderacion.SliderRadius = 25;
            this.tbPonderacion.TabIndex = 101;
            this.tbPonderacion.Value = 0;
            this.tbPonderacion.ValueChanged += new System.EventHandler(this.tbPonderacion_ValueChanged);
            // 
            // lblAuto
            // 
            this.lblAuto.AutoSize = true;
            this.lblAuto.Font = new System.Drawing.Font("Roboto", 6F);
            this.lblAuto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.lblAuto.Location = new System.Drawing.Point(13, 308);
            this.lblAuto.Name = "lblAuto";
            this.lblAuto.Size = new System.Drawing.Size(74, 10);
            this.lblAuto.TabIndex = 115;
            this.lblAuto.Text = "AUTOEVALUACION";
            // 
            // lblPonderacionAuto
            // 
            this.lblPonderacionAuto.AutoSize = true;
            this.lblPonderacionAuto.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPonderacionAuto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.lblPonderacionAuto.Location = new System.Drawing.Point(15, 293);
            this.lblPonderacionAuto.Name = "lblPonderacionAuto";
            this.lblPonderacionAuto.Size = new System.Drawing.Size(38, 15);
            this.lblPonderacionAuto.TabIndex = 114;
            this.lblPonderacionAuto.Text = "NUM";
            // 
            // lblEva
            // 
            this.lblEva.AutoSize = true;
            this.lblEva.Font = new System.Drawing.Font("Roboto", 6F);
            this.lblEva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.lblEva.Location = new System.Drawing.Point(264, 308);
            this.lblEva.Name = "lblEva";
            this.lblEva.Size = new System.Drawing.Size(53, 10);
            this.lblEva.TabIndex = 117;
            this.lblEva.Text = "EVALUACION";
            // 
            // lblPonderacionEvaluacion
            // 
            this.lblPonderacionEvaluacion.AutoSize = true;
            this.lblPonderacionEvaluacion.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPonderacionEvaluacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.lblPonderacionEvaluacion.Location = new System.Drawing.Point(281, 293);
            this.lblPonderacionEvaluacion.Name = "lblPonderacionEvaluacion";
            this.lblPonderacionEvaluacion.Size = new System.Drawing.Size(38, 15);
            this.lblPonderacionEvaluacion.TabIndex = 116;
            this.lblPonderacionEvaluacion.Text = "NUM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.label1.Location = new System.Drawing.Point(12, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 119;
            this.label1.Text = "Ponderacion";
            // 
            // lblErrorNombre
            // 
            this.lblErrorNombre.AutoSize = true;
            this.lblErrorNombre.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(83)))), ((int)(((byte)(66)))));
            this.lblErrorNombre.Location = new System.Drawing.Point(15, 80);
            this.lblErrorNombre.Name = "lblErrorNombre";
            this.lblErrorNombre.Size = new System.Drawing.Size(258, 15);
            this.lblErrorNombre.TabIndex = 120;
            this.lblErrorNombre.Text = "Texto de error para el nombre del funcionario";
            this.lblErrorNombre.Visible = false;
            // 
            // lblFechaError
            // 
            this.lblFechaError.AutoSize = true;
            this.lblFechaError.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(83)))), ((int)(((byte)(66)))));
            this.lblFechaError.Location = new System.Drawing.Point(12, 145);
            this.lblFechaError.Name = "lblFechaError";
            this.lblFechaError.Size = new System.Drawing.Size(258, 15);
            this.lblFechaError.TabIndex = 121;
            this.lblFechaError.Text = "Texto de error para el nombre del funcionario";
            this.lblFechaError.Visible = false;
            // 
            // lblDiasHabilesError
            // 
            this.lblDiasHabilesError.AutoSize = true;
            this.lblDiasHabilesError.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasHabilesError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(83)))), ((int)(((byte)(66)))));
            this.lblDiasHabilesError.Location = new System.Drawing.Point(12, 217);
            this.lblDiasHabilesError.Name = "lblDiasHabilesError";
            this.lblDiasHabilesError.Size = new System.Drawing.Size(258, 15);
            this.lblDiasHabilesError.TabIndex = 122;
            this.lblDiasHabilesError.Text = "Texto de error para el nombre del funcionario";
            this.lblDiasHabilesError.Visible = false;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.panelTitulo.Controls.Add(this.lblNombreFormulario);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.panelTitulo.Size = new System.Drawing.Size(334, 24);
            this.panelTitulo.TabIndex = 123;
            // 
            // lblNombreFormulario
            // 
            this.lblNombreFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.lblNombreFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombreFormulario.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold);
            this.lblNombreFormulario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.lblNombreFormulario.Location = new System.Drawing.Point(30, 0);
            this.lblNombreFormulario.Name = "lblNombreFormulario";
            this.lblNombreFormulario.Size = new System.Drawing.Size(304, 24);
            this.lblNombreFormulario.TabIndex = 45;
            this.lblNombreFormulario.Text = "Nombre Evaluacion";
            this.lblNombreFormulario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Evaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(334, 729);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.lblDiasHabilesError);
            this.Controls.Add(this.lblFechaError);
            this.Controls.Add(this.lblErrorNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEva);
            this.Controls.Add(this.lblPonderacionEvaluacion);
            this.Controls.Add(this.lblAuto);
            this.Controls.Add(this.lblPonderacionAuto);
            this.Controls.Add(this.tbPonderacion);
            this.Controls.Add(this.lblDiasHabiles);
            this.Controls.Add(this.txtDiasHabiles);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Evaluacion";
            this.Text = "Evaluacion";
            this.panelBotones.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNombre;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblDiasHabiles;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDiasHabiles;
        private Bunifu.Framework.UI.BunifuTrackbar tbPonderacion;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAuto;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPonderacionAuto;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEva;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPonderacionEvaluacion;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnLimpiar;
        private Bunifu.Framework.UI.BunifuFlatButton btnAccion;
        private System.Windows.Forms.Label lblErrorNombre;
        private System.Windows.Forms.Label lblFechaError;
        private System.Windows.Forms.Label lblDiasHabilesError;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblNombreFormulario;
    }
}