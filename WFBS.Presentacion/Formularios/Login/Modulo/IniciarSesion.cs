using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFBS.Presentacion.Formularios.Login.Modulo.Clases;
using Bunifu.Framework.UI;


namespace WFBS.Presentacion.Formularios.Login.Modulo
{
    public partial class IniciarSesion : Form
    {
        private IniciarAplicacion iniciar;
        private Cargando preloader = new Cargando();
        private FormularioPrincipal.FormularioPrincipal formulario;
        private BackgroundWorker iniciarSesion, iniciarAplicacion;
        private bool respuesta = false;
        //private Cl_Usuario usuario;
        //private daoUsuario dao;
        private Aplicacion app;
        private Login login;
        private int numero = 0, numero2 = 0, estado = 0;

        public IniciarSesion()
        {
            InitializeComponent();
            txtUsuario.Text = Properties.Settings.Default.RecordarUsuario;
            chkRecuerdame.Checked = Properties.Settings.Default.ChkRecordarUsuario;
        }


        private void btnRedesSociales_Click(object sender, EventArgs e)
        {
            BunifuImageButton btn = sender as BunifuImageButton;

            if (btn.Name == btnFacebook.Name)
            {
                System.Diagnostics.Process.Start("www.facebook.cl");
            }else if (btn.Name == btnTwitter.Name)
            {
                System.Diagnostics.Process.Start("www.twitter.com");
            }
            else if (btn.Name == btnInstagram.Name)
            {
                System.Diagnostics.Process.Start("www.instagram..com");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            int contador = 1;
            if (txtUsuario.Text.Trim() == "")
            {
                lblUsuario.ForeColor = Color.FromArgb(152, 75, 67);
                txtUsuario.BorderColorIdle = Color.FromArgb(152, 75, 67);
                txtUsuario.BorderColorFocused = Color.FromArgb(111, 55, 49);
                txtUsuario.BorderColorMouseHover = Color.FromArgb(139, 69, 61);
                txtUsuario.ForeColor = Color.FromArgb(237, 83, 66);
                lblErrorGeneral.Text = "Faltan Ingresar datos en (Usuario)";
            }
            else
            {
                contador++;
                lblUsuario.ForeColor = Color.FromArgb(90, 99, 113);
                txtUsuario.BorderColorIdle = Color.FromArgb(90, 99, 113);
                txtUsuario.BorderColorFocused = Color.FromArgb(105, 99, 113);
                txtUsuario.BorderColorMouseHover = Color.FromArgb(105, 99, 113);
                txtUsuario.ForeColor = Color.FromArgb(206, 210, 217);

            }

            if (txtContraseña.Text.Trim() == "")
            {
                lblContraseña.ForeColor = Color.FromArgb(152, 75, 67);
                txtContraseña.BorderColorIdle = Color.FromArgb(152, 75, 67);
                txtContraseña.BorderColorFocused = Color.FromArgb(111, 55, 49);
                txtContraseña.BorderColorMouseHover = Color.FromArgb(139, 69, 61);
                txtContraseña.ForeColor = Color.FromArgb(237, 83, 66);
                lblErrorGeneral.Text = "Faltan Ingresar datos en (Contraseña)";
            }
            else
            {
                contador++;
                lblContraseña.ForeColor = Color.FromArgb(90, 99, 113);
                txtContraseña.BorderColorIdle = Color.FromArgb(90, 99, 113);
                txtContraseña.BorderColorFocused = Color.FromArgb(105, 99, 113);
                txtContraseña.BorderColorMouseHover = Color.FromArgb(105, 99, 113);
                txtContraseña.ForeColor = Color.FromArgb(206, 210, 217);
            }

            if (contador == 1)
            {
                lblErrorGeneral.Text = "Faltan Ingresar datos en (Usuario, Contraseña)";

            }
            else if (contador == 3)
            {
                MostrarLateral();
                IniciarSesion();

            }
        }



    }
}
