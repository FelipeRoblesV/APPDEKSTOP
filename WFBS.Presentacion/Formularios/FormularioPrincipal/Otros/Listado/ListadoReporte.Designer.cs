namespace WFBS.Presentacion.Formularios.FormularioPrincipal.Otros.Listado
{
    partial class ListadoReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoReporte));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnExportarExcel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnImportarPDF = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelMapaSitio = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblMapaSitio_3 = new System.Windows.Forms.Label();
            this.lblSeparacionMapa_2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblMapaSitio_2 = new System.Windows.Forms.Label();
            this.lblSeparacionMapa_1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblMapaSitio_1 = new System.Windows.Forms.Label();
            this.btnRegresar = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.panelMapaSitio.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(25, 10, 25, 10);
            this.panel1.Size = new System.Drawing.Size(1496, 52);
            this.panel1.TabIndex = 11;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDescripcion.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.lblDescripcion.Location = new System.Drawing.Point(232, 10);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblDescripcion.Size = new System.Drawing.Size(759, 32);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripcion del Formulario";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(222, 10);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.bunifuSeparator1.Size = new System.Drawing.Size(10, 32);
            this.bunifuSeparator1.TabIndex = 4;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.lblTitulo.Location = new System.Drawing.Point(25, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(197, 32);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Reporte General";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.panelBotones.Controls.Add(this.btnExportarExcel);
            this.panelBotones.Controls.Add(this.btnImportarPDF);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotones.Location = new System.Drawing.Point(0, 676);
            this.panelBotones.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Padding = new System.Windows.Forms.Padding(30, 5, 5, 5);
            this.panelBotones.Size = new System.Drawing.Size(1496, 55);
            this.panelBotones.TabIndex = 12;
            this.panelBotones.Visible = false;
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(92)))), ((int)(((byte)(119)))));
            this.btnExportarExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(92)))), ((int)(((byte)(119)))));
            this.btnExportarExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportarExcel.BorderRadius = 2;
            this.btnExportarExcel.ButtonText = "Importar a EXCEL";
            this.btnExportarExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportarExcel.DisabledColor = System.Drawing.Color.Gray;
            this.btnExportarExcel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExportarExcel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExportarExcel.Iconimage = global::WFBS.Presentacion.Properties.Resources._1485481269_37_78645;
            this.btnExportarExcel.Iconimage_right = null;
            this.btnExportarExcel.Iconimage_right_Selected = null;
            this.btnExportarExcel.Iconimage_Selected = null;
            this.btnExportarExcel.IconMarginLeft = 2;
            this.btnExportarExcel.IconMarginRight = 0;
            this.btnExportarExcel.IconRightVisible = true;
            this.btnExportarExcel.IconRightZoom = 0D;
            this.btnExportarExcel.IconVisible = true;
            this.btnExportarExcel.IconZoom = 90D;
            this.btnExportarExcel.IsTab = false;
            this.btnExportarExcel.Location = new System.Drawing.Point(255, 5);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(92)))), ((int)(((byte)(119)))));
            this.btnExportarExcel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnExportarExcel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExportarExcel.selected = false;
            this.btnExportarExcel.Size = new System.Drawing.Size(225, 45);
            this.btnExportarExcel.TabIndex = 1;
            this.btnExportarExcel.Text = "Importar a EXCEL";
            this.btnExportarExcel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExportarExcel.Textcolor = System.Drawing.Color.White;
            this.btnExportarExcel.TextFont = new System.Drawing.Font("Roboto", 12F);
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // btnImportarPDF
            // 
            this.btnImportarPDF.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(92)))), ((int)(((byte)(119)))));
            this.btnImportarPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(92)))), ((int)(((byte)(119)))));
            this.btnImportarPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImportarPDF.BorderRadius = 2;
            this.btnImportarPDF.ButtonText = "Importar a PDF";
            this.btnImportarPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportarPDF.DisabledColor = System.Drawing.Color.Gray;
            this.btnImportarPDF.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnImportarPDF.Iconcolor = System.Drawing.Color.Transparent;
            this.btnImportarPDF.Iconimage = global::WFBS.Presentacion.Properties.Resources._1485481179_20_78631;
            this.btnImportarPDF.Iconimage_right = null;
            this.btnImportarPDF.Iconimage_right_Selected = null;
            this.btnImportarPDF.Iconimage_Selected = null;
            this.btnImportarPDF.IconMarginLeft = 2;
            this.btnImportarPDF.IconMarginRight = 0;
            this.btnImportarPDF.IconRightVisible = true;
            this.btnImportarPDF.IconRightZoom = 0D;
            this.btnImportarPDF.IconVisible = true;
            this.btnImportarPDF.IconZoom = 90D;
            this.btnImportarPDF.IsTab = false;
            this.btnImportarPDF.Location = new System.Drawing.Point(30, 5);
            this.btnImportarPDF.Name = "btnImportarPDF";
            this.btnImportarPDF.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(92)))), ((int)(((byte)(119)))));
            this.btnImportarPDF.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnImportarPDF.OnHoverTextColor = System.Drawing.Color.White;
            this.btnImportarPDF.selected = false;
            this.btnImportarPDF.Size = new System.Drawing.Size(225, 45);
            this.btnImportarPDF.TabIndex = 0;
            this.btnImportarPDF.Text = "Importar a PDF";
            this.btnImportarPDF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnImportarPDF.Textcolor = System.Drawing.Color.White;
            this.btnImportarPDF.TextFont = new System.Drawing.Font("Roboto", 12F);
            this.btnImportarPDF.Click += new System.EventHandler(this.btnImportarPDF_Click);
            // 
            // panelMapaSitio
            // 
            this.panelMapaSitio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.panelMapaSitio.Controls.Add(this.panel5);
            this.panelMapaSitio.Controls.Add(this.panel4);
            this.panelMapaSitio.Controls.Add(this.panel3);
            this.panelMapaSitio.Controls.Add(this.btnRegresar);
            this.panelMapaSitio.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMapaSitio.Location = new System.Drawing.Point(0, 52);
            this.panelMapaSitio.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panelMapaSitio.Name = "panelMapaSitio";
            this.panelMapaSitio.Padding = new System.Windows.Forms.Padding(50, 5, 0, 0);
            this.panelMapaSitio.Size = new System.Drawing.Size(1496, 30);
            this.panelMapaSitio.TabIndex = 14;
            this.panelMapaSitio.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblMapaSitio_3);
            this.panel5.Controls.Add(this.lblSeparacionMapa_2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(305, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(195, 25);
            this.panel5.TabIndex = 22;
            // 
            // lblMapaSitio_3
            // 
            this.lblMapaSitio_3.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblMapaSitio_3.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold);
            this.lblMapaSitio_3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.lblMapaSitio_3.Location = new System.Drawing.Point(19, 0);
            this.lblMapaSitio_3.Name = "lblMapaSitio_3";
            this.lblMapaSitio_3.Size = new System.Drawing.Size(173, 25);
            this.lblMapaSitio_3.TabIndex = 20;
            this.lblMapaSitio_3.Text = "Reporte General";
            this.lblMapaSitio_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeparacionMapa_2
            // 
            this.lblSeparacionMapa_2.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSeparacionMapa_2.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold);
            this.lblSeparacionMapa_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.lblSeparacionMapa_2.Location = new System.Drawing.Point(0, 0);
            this.lblSeparacionMapa_2.Name = "lblSeparacionMapa_2";
            this.lblSeparacionMapa_2.Size = new System.Drawing.Size(19, 25);
            this.lblSeparacionMapa_2.TabIndex = 19;
            this.lblSeparacionMapa_2.Text = "\\";
            this.lblSeparacionMapa_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblMapaSitio_2);
            this.panel4.Controls.Add(this.lblSeparacionMapa_1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(139, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(166, 25);
            this.panel4.TabIndex = 21;
            // 
            // lblMapaSitio_2
            // 
            this.lblMapaSitio_2.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblMapaSitio_2.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold);
            this.lblMapaSitio_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.lblMapaSitio_2.Location = new System.Drawing.Point(19, 0);
            this.lblMapaSitio_2.Name = "lblMapaSitio_2";
            this.lblMapaSitio_2.Size = new System.Drawing.Size(152, 25);
            this.lblMapaSitio_2.TabIndex = 18;
            this.lblMapaSitio_2.Text = "Evaluacion";
            this.lblMapaSitio_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeparacionMapa_1
            // 
            this.lblSeparacionMapa_1.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSeparacionMapa_1.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold);
            this.lblSeparacionMapa_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.lblSeparacionMapa_1.Location = new System.Drawing.Point(0, 0);
            this.lblSeparacionMapa_1.Name = "lblSeparacionMapa_1";
            this.lblSeparacionMapa_1.Size = new System.Drawing.Size(19, 25);
            this.lblSeparacionMapa_1.TabIndex = 17;
            this.lblSeparacionMapa_1.Text = "\\";
            this.lblSeparacionMapa_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblMapaSitio_1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(50, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(89, 25);
            this.panel3.TabIndex = 20;
            // 
            // lblMapaSitio_1
            // 
            this.lblMapaSitio_1.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblMapaSitio_1.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold);
            this.lblMapaSitio_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.lblMapaSitio_1.Location = new System.Drawing.Point(0, 0);
            this.lblMapaSitio_1.Name = "lblMapaSitio_1";
            this.lblMapaSitio_1.Size = new System.Drawing.Size(91, 25);
            this.lblMapaSitio_1.TabIndex = 11;
            this.lblMapaSitio_1.Text = "Perfil";
            this.lblMapaSitio_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRegresar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.ImageActive = null;
            this.btnRegresar.Location = new System.Drawing.Point(1369, 5);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(127, 25);
            this.btnRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRegresar.TabIndex = 15;
            this.btnRegresar.TabStop = false;
            this.btnRegresar.Zoom = 10;
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(139)))));
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 82);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(1496, 594);
            this.panelContenido.TabIndex = 17;
            // 
            // ListadoReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 731);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelMapaSitio);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListadoReporte";
            this.Text = "ListadoReporte";
            this.panel1.ResumeLayout(false);
            this.panelBotones.ResumeLayout(false);
            this.panelMapaSitio.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDescripcion;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Panel panelMapaSitio;
        private Bunifu.Framework.UI.BunifuImageButton btnRegresar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblMapaSitio_1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblMapaSitio_2;
        private System.Windows.Forms.Label lblSeparacionMapa_1;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblMapaSitio_3;
        private System.Windows.Forms.Label lblSeparacionMapa_2;
        private Bunifu.Framework.UI.BunifuFlatButton btnImportarPDF;
        private Bunifu.Framework.UI.BunifuFlatButton btnExportarExcel;
    }
}