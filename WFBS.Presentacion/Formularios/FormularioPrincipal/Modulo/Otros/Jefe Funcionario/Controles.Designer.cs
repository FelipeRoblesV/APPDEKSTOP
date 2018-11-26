namespace WFBS.Presentacion.Formularios.FormularioPrincipal.Modulo.Otros.Jefe_Funcionario
{
    partial class Controles
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
            this.lblErrorContraseña = new System.Windows.Forms.Label();
            this.txtRepetirContraseña = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblErrorRepetirContraseña = new System.Windows.Forms.Label();
            this.lblErrorTelefono = new System.Windows.Forms.Label();
            this.lblErrorSexo = new System.Windows.Forms.Label();
            this.lblErrorCorreo = new System.Windows.Forms.Label();
            this.lblErrorFechaNacimiento = new System.Windows.Forms.Label();
            this.lblErrorApellido = new System.Windows.Forms.Label();
            this.lblErrorNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.rbMujer = new System.Windows.Forms.RadioButton();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRepetirContraseña = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.rbHombre = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblErrorContraseña
            // 
            this.lblErrorContraseña.AutoSize = true;
            this.lblErrorContraseña.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblErrorContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(63)))), ((int)(((byte)(44)))));
            this.lblErrorContraseña.Location = new System.Drawing.Point(15, 478);
            this.lblErrorContraseña.Name = "lblErrorContraseña";
            this.lblErrorContraseña.Size = new System.Drawing.Size(309, 18);
            this.lblErrorContraseña.TabIndex = 190;
            this.lblErrorContraseña.Text = "Texto de error para el nombre del funcionario";
            this.lblErrorContraseña.Visible = false;
            // 
            // txtRepetirContraseña
            // 
            this.txtRepetirContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(76)))), ((int)(((byte)(98)))));
            this.txtRepetirContraseña.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.txtRepetirContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(136)))));
            this.txtRepetirContraseña.Location = new System.Drawing.Point(15, 518);
            this.txtRepetirContraseña.MaxLength = 13;
            this.txtRepetirContraseña.Name = "txtRepetirContraseña";
            this.txtRepetirContraseña.Size = new System.Drawing.Size(305, 27);
            this.txtRepetirContraseña.TabIndex = 188;
            this.txtRepetirContraseña.Visible = false;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(76)))), ((int)(((byte)(98)))));
            this.txtContraseña.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.txtContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(136)))));
            this.txtContraseña.Location = new System.Drawing.Point(14, 448);
            this.txtContraseña.MaxLength = 13;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(306, 27);
            this.txtContraseña.TabIndex = 187;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(76)))), ((int)(((byte)(98)))));
            this.txtTelefono.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(136)))));
            this.txtTelefono.Location = new System.Drawing.Point(15, 370);
            this.txtTelefono.MaxLength = 9;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(308, 27);
            this.txtTelefono.TabIndex = 186;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGeneral_KeyPress);
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(76)))), ((int)(((byte)(98)))));
            this.txtCorreo.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.txtCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(136)))));
            this.txtCorreo.Location = new System.Drawing.Point(15, 309);
            this.txtCorreo.MaxLength = 60;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(308, 27);
            this.txtCorreo.TabIndex = 185;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(76)))), ((int)(((byte)(98)))));
            this.txtApellido.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.txtApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(136)))));
            this.txtApellido.Location = new System.Drawing.Point(15, 105);
            this.txtApellido.MaxLength = 60;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(308, 27);
            this.txtApellido.TabIndex = 184;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGeneral_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(76)))), ((int)(((byte)(98)))));
            this.txtNombre.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(136)))));
            this.txtNombre.Location = new System.Drawing.Point(15, 29);
            this.txtNombre.MaxLength = 60;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(308, 27);
            this.txtNombre.TabIndex = 183;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGeneral_KeyPress);
            // 
            // lblErrorRepetirContraseña
            // 
            this.lblErrorRepetirContraseña.AutoSize = true;
            this.lblErrorRepetirContraseña.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblErrorRepetirContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(63)))), ((int)(((byte)(44)))));
            this.lblErrorRepetirContraseña.Location = new System.Drawing.Point(15, 548);
            this.lblErrorRepetirContraseña.Name = "lblErrorRepetirContraseña";
            this.lblErrorRepetirContraseña.Size = new System.Drawing.Size(309, 18);
            this.lblErrorRepetirContraseña.TabIndex = 182;
            this.lblErrorRepetirContraseña.Text = "Texto de error para el nombre del funcionario";
            this.lblErrorRepetirContraseña.Visible = false;
            // 
            // lblErrorTelefono
            // 
            this.lblErrorTelefono.AutoSize = true;
            this.lblErrorTelefono.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblErrorTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(63)))), ((int)(((byte)(44)))));
            this.lblErrorTelefono.Location = new System.Drawing.Point(15, 396);
            this.lblErrorTelefono.Name = "lblErrorTelefono";
            this.lblErrorTelefono.Size = new System.Drawing.Size(309, 18);
            this.lblErrorTelefono.TabIndex = 181;
            this.lblErrorTelefono.Text = "Texto de error para el nombre del funcionario";
            this.lblErrorTelefono.Visible = false;
            // 
            // lblErrorSexo
            // 
            this.lblErrorSexo.AutoSize = true;
            this.lblErrorSexo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblErrorSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(63)))), ((int)(((byte)(44)))));
            this.lblErrorSexo.Location = new System.Drawing.Point(15, 274);
            this.lblErrorSexo.Name = "lblErrorSexo";
            this.lblErrorSexo.Size = new System.Drawing.Size(309, 18);
            this.lblErrorSexo.TabIndex = 180;
            this.lblErrorSexo.Text = "Texto de error para el nombre del funcionario";
            this.lblErrorSexo.Visible = false;
            // 
            // lblErrorCorreo
            // 
            this.lblErrorCorreo.AutoSize = true;
            this.lblErrorCorreo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblErrorCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(63)))), ((int)(((byte)(44)))));
            this.lblErrorCorreo.Location = new System.Drawing.Point(15, 335);
            this.lblErrorCorreo.Name = "lblErrorCorreo";
            this.lblErrorCorreo.Size = new System.Drawing.Size(309, 18);
            this.lblErrorCorreo.TabIndex = 179;
            this.lblErrorCorreo.Text = "Texto de error para el nombre del funcionario";
            this.lblErrorCorreo.Visible = false;
            // 
            // lblErrorFechaNacimiento
            // 
            this.lblErrorFechaNacimiento.AutoSize = true;
            this.lblErrorFechaNacimiento.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblErrorFechaNacimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(63)))), ((int)(((byte)(44)))));
            this.lblErrorFechaNacimiento.Location = new System.Drawing.Point(15, 205);
            this.lblErrorFechaNacimiento.Name = "lblErrorFechaNacimiento";
            this.lblErrorFechaNacimiento.Size = new System.Drawing.Size(309, 18);
            this.lblErrorFechaNacimiento.TabIndex = 178;
            this.lblErrorFechaNacimiento.Text = "Texto de error para el nombre del funcionario";
            this.lblErrorFechaNacimiento.Visible = false;
            // 
            // lblErrorApellido
            // 
            this.lblErrorApellido.AutoSize = true;
            this.lblErrorApellido.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblErrorApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(63)))), ((int)(((byte)(44)))));
            this.lblErrorApellido.Location = new System.Drawing.Point(15, 135);
            this.lblErrorApellido.Name = "lblErrorApellido";
            this.lblErrorApellido.Size = new System.Drawing.Size(309, 18);
            this.lblErrorApellido.TabIndex = 177;
            this.lblErrorApellido.Text = "Texto de error para el nombre del funcionario";
            this.lblErrorApellido.Visible = false;
            // 
            // lblErrorNombre
            // 
            this.lblErrorNombre.AutoSize = true;
            this.lblErrorNombre.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblErrorNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(63)))), ((int)(((byte)(44)))));
            this.lblErrorNombre.Location = new System.Drawing.Point(15, 59);
            this.lblErrorNombre.Name = "lblErrorNombre";
            this.lblErrorNombre.Size = new System.Drawing.Size(309, 18);
            this.lblErrorNombre.TabIndex = 176;
            this.lblErrorNombre.Text = "Texto de error para el nombre del funcionario";
            this.lblErrorNombre.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(102)))));
            this.label2.Location = new System.Drawing.Point(15, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 25);
            this.label2.TabIndex = 164;
            this.label2.Text = "Apellido del jefe funcionario";
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(102)))));
            this.lblNombre.Location = new System.Drawing.Point(15, 6);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(273, 20);
            this.lblNombre.TabIndex = 163;
            this.lblNombre.Text = "Nombre del jefe funcionario";
            // 
            // rbMujer
            // 
            this.rbMujer.AutoSize = true;
            this.rbMujer.FlatAppearance.BorderSize = 0;
            this.rbMujer.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.rbMujer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbMujer.Font = new System.Drawing.Font("Roboto Light", 13F);
            this.rbMujer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(102)))));
            this.rbMujer.Location = new System.Drawing.Point(172, 245);
            this.rbMujer.Name = "rbMujer";
            this.rbMujer.Size = new System.Drawing.Size(72, 26);
            this.rbMujer.TabIndex = 167;
            this.rbMujer.TabStop = true;
            this.rbMujer.Text = "Mujer";
            this.rbMujer.UseVisualStyleBackColor = true;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold);
            this.lblContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(102)))));
            this.lblContraseña.Location = new System.Drawing.Point(15, 426);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(267, 19);
            this.lblContraseña.TabIndex = 174;
            this.lblContraseña.Text = "Contraseña del jefe funcionario";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(102)))));
            this.label3.Location = new System.Drawing.Point(15, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 19);
            this.label3.TabIndex = 166;
            this.label3.Text = "Fecha de nacimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(102)))));
            this.label7.Location = new System.Drawing.Point(15, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(246, 19);
            this.label7.TabIndex = 172;
            this.label7.Text = "Telefono del jefe funcionario";
            // 
            // lblRepetirContraseña
            // 
            this.lblRepetirContraseña.AutoSize = true;
            this.lblRepetirContraseña.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold);
            this.lblRepetirContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(102)))));
            this.lblRepetirContraseña.Location = new System.Drawing.Point(15, 496);
            this.lblRepetirContraseña.Name = "lblRepetirContraseña";
            this.lblRepetirContraseña.Size = new System.Drawing.Size(166, 19);
            this.lblRepetirContraseña.TabIndex = 175;
            this.lblRepetirContraseña.Text = "Repetir Contraseña";
            this.lblRepetirContraseña.Visible = false;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CalendarFont = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtpFechaNacimiento.CalendarMonthBackground = System.Drawing.Color.Blue;
            this.dtpFechaNacimiento.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(15, 175);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(308, 27);
            this.dtpFechaNacimiento.TabIndex = 168;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(102)))));
            this.label4.Location = new System.Drawing.Point(15, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 19);
            this.label4.TabIndex = 169;
            this.label4.Text = "Correo del jefe funcionario";
            // 
            // rbHombre
            // 
            this.rbHombre.AutoSize = true;
            this.rbHombre.FlatAppearance.BorderSize = 0;
            this.rbHombre.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.rbHombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbHombre.Font = new System.Drawing.Font("Roboto Light", 13F);
            this.rbHombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(102)))));
            this.rbHombre.Location = new System.Drawing.Point(62, 245);
            this.rbHombre.Name = "rbHombre";
            this.rbHombre.Size = new System.Drawing.Size(91, 26);
            this.rbHombre.TabIndex = 165;
            this.rbHombre.TabStop = true;
            this.rbHombre.Text = "Hombre";
            this.rbHombre.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(102)))));
            this.label5.Location = new System.Drawing.Point(15, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 19);
            this.label5.TabIndex = 171;
            this.label5.Text = "Sexo del jefe funcionario";
            // 
            // Controles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(84)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(334, 575);
            this.Controls.Add(this.lblErrorContraseña);
            this.Controls.Add(this.txtRepetirContraseña);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblErrorRepetirContraseña);
            this.Controls.Add(this.lblErrorTelefono);
            this.Controls.Add(this.lblErrorSexo);
            this.Controls.Add(this.lblErrorCorreo);
            this.Controls.Add(this.lblErrorFechaNacimiento);
            this.Controls.Add(this.lblErrorApellido);
            this.Controls.Add(this.lblErrorNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.rbMujer);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblRepetirContraseña);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbHombre);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Controles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Controles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblErrorContraseña;
        private System.Windows.Forms.TextBox txtRepetirContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblErrorRepetirContraseña;
        private System.Windows.Forms.Label lblErrorTelefono;
        private System.Windows.Forms.Label lblErrorSexo;
        private System.Windows.Forms.Label lblErrorCorreo;
        private System.Windows.Forms.Label lblErrorFechaNacimiento;
        private System.Windows.Forms.Label lblErrorApellido;
        private System.Windows.Forms.Label lblErrorNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.RadioButton rbMujer;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRepetirContraseña;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbHombre;
        private System.Windows.Forms.Label label5;
    }
}