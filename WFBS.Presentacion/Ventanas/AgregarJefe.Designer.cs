namespace WFBS.Presentacion.Ventanas
{
    partial class AgregarJefe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarJefe));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Accion2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Accion1 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cbJefeFuncionario = new System.Windows.Forms.ComboBox();
            this.lblErrorJefe = new System.Windows.Forms.Label();
            this.Efecto_orillas = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(352, 27);
            this.panel1.TabIndex = 1;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.bunifuImageButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuImageButton1.Image = global::WFBS.Presentacion.Properties.Resources.CerrarFP;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(326, 1);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
            this.panel2.Controls.Add(this.btn_Accion2);
            this.panel2.Controls.Add(this.btn_Accion1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 95);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(30, 2, 30, 2);
            this.panel2.Size = new System.Drawing.Size(352, 42);
            this.panel2.TabIndex = 2;
            // 
            // btn_Accion2
            // 
            this.btn_Accion2.ActiveBorderThickness = 1;
            this.btn_Accion2.ActiveCornerRadius = 20;
            this.btn_Accion2.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(138)))), ((int)(((byte)(148)))));
            this.btn_Accion2.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.btn_Accion2.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(138)))), ((int)(((byte)(148)))));
            this.btn_Accion2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
            this.btn_Accion2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Accion2.BackgroundImage")));
            this.btn_Accion2.ButtonText = "Cancelar";
            this.btn_Accion2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Accion2.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Accion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Accion2.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Accion2.IdleBorderThickness = 1;
            this.btn_Accion2.IdleCornerRadius = 20;
            this.btn_Accion2.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(177)))), ((int)(((byte)(184)))));
            this.btn_Accion2.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
            this.btn_Accion2.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(177)))), ((int)(((byte)(184)))));
            this.btn_Accion2.Location = new System.Drawing.Point(193, 2);
            this.btn_Accion2.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Accion2.Name = "btn_Accion2";
            this.btn_Accion2.Size = new System.Drawing.Size(129, 38);
            this.btn_Accion2.TabIndex = 1;
            this.btn_Accion2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Accion2.Click += new System.EventHandler(this.btn_Accion2_Click);
            // 
            // btn_Accion1
            // 
            this.btn_Accion1.ActiveBorderThickness = 1;
            this.btn_Accion1.ActiveCornerRadius = 20;
            this.btn_Accion1.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(138)))), ((int)(((byte)(148)))));
            this.btn_Accion1.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.btn_Accion1.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(138)))), ((int)(((byte)(148)))));
            this.btn_Accion1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
            this.btn_Accion1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Accion1.BackgroundImage")));
            this.btn_Accion1.ButtonText = "Aceptar";
            this.btn_Accion1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Accion1.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Accion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Accion1.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Accion1.IdleBorderThickness = 1;
            this.btn_Accion1.IdleCornerRadius = 20;
            this.btn_Accion1.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(177)))), ((int)(((byte)(184)))));
            this.btn_Accion1.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
            this.btn_Accion1.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(177)))), ((int)(((byte)(184)))));
            this.btn_Accion1.Location = new System.Drawing.Point(30, 2);
            this.btn_Accion1.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Accion1.Name = "btn_Accion1";
            this.btn_Accion1.Size = new System.Drawing.Size(134, 38);
            this.btn_Accion1.TabIndex = 0;
            this.btn_Accion1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Accion1.Click += new System.EventHandler(this.btn_Accion1_Click);
            // 
            // cbJefeFuncionario
            // 
            this.cbJefeFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.cbJefeFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJefeFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbJefeFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(136)))));
            this.cbJefeFuncionario.FormattingEnabled = true;
            this.cbJefeFuncionario.Location = new System.Drawing.Point(30, 47);
            this.cbJefeFuncionario.Name = "cbJefeFuncionario";
            this.cbJefeFuncionario.Size = new System.Drawing.Size(292, 21);
            this.cbJefeFuncionario.TabIndex = 142;
            // 
            // lblErrorJefe
            // 
            this.lblErrorJefe.AutoSize = true;
            this.lblErrorJefe.Font = new System.Drawing.Font("Roboto", 9F);
            this.lblErrorJefe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(63)))), ((int)(((byte)(44)))));
            this.lblErrorJefe.Location = new System.Drawing.Point(27, 71);
            this.lblErrorJefe.Name = "lblErrorJefe";
            this.lblErrorJefe.Size = new System.Drawing.Size(249, 14);
            this.lblErrorJefe.TabIndex = 153;
            this.lblErrorJefe.Text = "Texto de error para el nombre del funcionario";
            this.lblErrorJefe.Visible = false;
            // 
            // Efecto_orillas
            // 
            this.Efecto_orillas.ElipseRadius = 10;
            this.Efecto_orillas.TargetControl = this;
            // 
            // AgregarJefe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(352, 137);
            this.Controls.Add(this.lblErrorJefe);
            this.Controls.Add(this.cbJefeFuncionario);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarJefe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarJefe";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Accion2;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Accion1;
        private System.Windows.Forms.ComboBox cbJefeFuncionario;
        private System.Windows.Forms.Label lblErrorJefe;
        private Bunifu.Framework.UI.BunifuElipse Efecto_orillas;
    }
}