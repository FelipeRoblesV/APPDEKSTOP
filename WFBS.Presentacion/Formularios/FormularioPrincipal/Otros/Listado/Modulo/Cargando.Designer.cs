namespace WFBS.Presentacion.Formularios.FormularioPrincipal.Otros.Listado.Modulo
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
            this.colorTransicion = new Bunifu.Framework.UI.BunifuColorTransition(this.components);
            this.timerColor = new System.Windows.Forms.Timer(this.components);
            this.timerPreloader = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.barraProgreso = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMensaje = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorTransicion
            // 
            this.colorTransicion.Color1 = System.Drawing.Color.White;
            this.colorTransicion.Color2 = System.Drawing.Color.White;
            this.colorTransicion.ProgessValue = 0;
            // 
            // timerColor
            // 
            this.timerColor.Interval = 10;
            // 
            // timerPreloader
            // 
            this.timerPreloader.Enabled = true;
            this.timerPreloader.Interval = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(139)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1496, 619);
            this.tableLayoutPanel1.TabIndex = 41;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(139)))));
            this.panel1.Controls.Add(this.barraProgreso);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1496, 303);
            this.panel1.TabIndex = 38;
            // 
            // barraProgreso
            // 
            this.barraProgreso.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.barraProgreso.animated = true;
            this.barraProgreso.animationIterval = 5;
            this.barraProgreso.animationSpeed = 15;
            this.barraProgreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(139)))));
            this.barraProgreso.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barraProgreso.BackgroundImage")));
            this.barraProgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.barraProgreso.ForeColor = System.Drawing.Color.SeaGreen;
            this.barraProgreso.LabelVisible = false;
            this.barraProgreso.LineProgressThickness = 8;
            this.barraProgreso.LineThickness = 5;
            this.barraProgreso.Location = new System.Drawing.Point(650, 98);
            this.barraProgreso.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.barraProgreso.MaxValue = 100;
            this.barraProgreso.Name = "barraProgreso";
            this.barraProgreso.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.barraProgreso.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(68)))), ((int)(((byte)(91)))));
            this.barraProgreso.Size = new System.Drawing.Size(196, 196);
            this.barraProgreso.TabIndex = 37;
            this.barraProgreso.Value = 30;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(139)))));
            this.panel2.Controls.Add(this.lblMensaje);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 312);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1496, 304);
            this.panel2.TabIndex = 39;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMensaje.Font = new System.Drawing.Font("Roboto Light", 30F);
            this.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(216)))), ((int)(((byte)(165)))));
            this.lblMensaje.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMensaje.Location = new System.Drawing.Point(481, 3);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(534, 139);
            this.lblMensaje.TabIndex = 36;
            this.lblMensaje.Text = "Cargando Formulario Evaluaciones";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Cargando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(1496, 619);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cargando";
            this.Text = "Cargando";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuColorTransition colorTransicion;
        private System.Windows.Forms.Timer timerColor;
        private System.Windows.Forms.Timer timerPreloader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar barraProgreso;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMensaje;
    }
}