using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFBS.Presentacion.Formularios.FormularioPrincipal;
using WFBS.Presentacion.Formularios.Login;

namespace WFBS.Presentacion
{
    public partial class Aplicacion : Form
    {
        private Login login;
        private FormularioPrincipal formularioPrincipal;

        public Aplicacion()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
            iniciarAplicacion(1);
        }

        public void iniciarAplicacion(int numero)
        {
            switch (numero)
            {
                case 1:
                    login = new Login();
                    login.pasarDatos(this);
                    login.IniciarLogin(1);
                    this.MaximumSize = new Size(1596, 896);
                    AbrirPanel(login);
                    break;
                case 2:
                    formularioPrincipal = login.recuperarDatos();
                    formularioPrincipal.pasarDatos(this);
                    this.MaximumSize = new Size(0, 0);
                    AbrirPanel(formularioPrincipal);
                    login.IniciarLogin(3);
                    break;
            }
        }


        private void AbrirPanel(object formHijo)
        {
            if (this.panelContenido.Controls.Count > 0)
                this.panelContenido.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenido.Controls.Add(fh);
            this.panelContenido.Tag = fh;
            fh.Show();
        }
        public Aplicacion PasarDatos()
        {
            return this;
        }

        #region CONTROLES DEL FORMULARIO

        int lx, ly;
        int sw, sh;
        public void Controles(int numero)
        {
            switch (numero)
            {
                case 1:
                    MessageBox.Show("CERRAR");
                    break;
                case 2:
                    this.WindowState = FormWindowState.Minimized;
                    break;
                case 3:
                    lx = this.Location.X;
                    ly = this.Location.Y;
                    sw = this.Size.Width;
                    sh = this.Size.Height;
                    this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                    this.Location = Screen.PrimaryScreen.WorkingArea.Location;x
                    break;
                case 4:
                    this.WindowState = FormWindowState.Normal;
                    this.Size = new Size(sw, sh);
                    this.Location = new Point(lx, ly);
                    break;
                case 5:
                    iniciarAplicacion(3);
                    break;

            }

        }

        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message msj)
        {
            const int CoordenadaWFP = 0x84;
            const int DesIzquierda = 16;
            const int DesDerecha = 17;
            if (msj.Msg == CoordenadaWFP)
            {
                int x = (int)(msj.LParam.ToInt64() & 0xFFFF);
                int y = (int)((msj.LParam.ToInt64() & 0xFFFF0000) >> 16);
                Point CoordenadaArea = PointToClient(new Point(x, y));
                Size TamañoAreaForm = ClientSize;
                if (CoordenadaArea.X >= TamañoAreaForm.Width - 16 && CoordenadaArea.Y >= TamañoAreaForm.Height - 16 && TamañoAreaForm.Height >= 16)
                {
                    msj.Result = (IntPtr)(IsMirrored ? DesIzquierda : DesDerecha);
                    return;
                }
            }
            base.WndProc(ref msj);
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            panelContenido.Region = region;

            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(19, 27, 39));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);


            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }
        #endregion
    }
}
