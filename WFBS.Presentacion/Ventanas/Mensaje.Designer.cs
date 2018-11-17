namespace WFBS.Presentacion.Ventanas
{
    partial class Mensaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mensaje));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Accion1 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(367, 27);
            this.panel1.TabIndex = 1;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuImageButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuImageButton1.Image = global::WFBS.Presentacion.Properties.Resources.CerrarFP;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(341, 1);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Accion1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 135);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.panel2.Size = new System.Drawing.Size(367, 42);
            this.panel2.TabIndex = 2;
            // 
            // btn_Accion1
            // 
            this.btn_Accion1.ActiveBorderThickness = 1;
            this.btn_Accion1.ActiveCornerRadius = 20;
            this.btn_Accion1.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_Accion1.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Accion1.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Accion1.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Accion1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Accion1.BackgroundImage")));
            this.btn_Accion1.ButtonText = "ThinButton";
            this.btn_Accion1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Accion1.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Accion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Accion1.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Accion1.IdleBorderThickness = 1;
            this.btn_Accion1.IdleCornerRadius = 20;
            this.btn_Accion1.IdleFillColor = System.Drawing.Color.White;
            this.btn_Accion1.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_Accion1.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Accion1.Location = new System.Drawing.Point(30, 0);
            this.btn_Accion1.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Accion1.Name = "btn_Accion1";
            this.btn_Accion1.Size = new System.Drawing.Size(302, 42);
            this.btn_Accion1.TabIndex = 0;
            this.btn_Accion1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Accion1.Click += new System.EventHandler(this.btn_Accion1_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblMensaje.Location = new System.Drawing.Point(0, 27);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(367, 108);
            this.lblMensaje.TabIndex = 3;
            this.lblMensaje.Text = "label1";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Mensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 177);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mensaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mensaje";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Accion1;
        private System.Windows.Forms.Label lblMensaje;
    }
}