using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using WFBS.Presentacion.Formularios.Login;

namespace WFBS.Presentacion.Ventanas
{
    public partial class Cerrar : Form
    { 

        private int estado = 0;
        private Login login;
        private Formularios.FormularioPrincipal.FormularioPrincipal formularioPrincipal;
        private Aplicacion app;
        public Cerrar()
        {
            InitializeComponent();
        }

        public void ventanaCerrarLogin(Login login)
        {
            this.login = login;
            lblMensaje.Text = "¿Esta Seguro que quiere cerrar ahora?";
            btn_Accion1.ButtonText = "Aceptar";
            btn_Accion2.ButtonText = "Cancelar";
            estado = 1;
        }


        public void ventanaCerrarFormularioPrincipal(Formularios.FormularioPrincipal.FormularioPrincipal Formulario)
        {
            this.formularioPrincipal = Formulario;
            lblMensaje.Text = "¿Esta Seguro que quiere cerrar ahora?";
            btn_Accion1.ButtonText = "Aceptar";
            btn_Accion2.ButtonText = "Cancelar";
            estado = 2;
        }

        public void ventanaCerrarSesion(Aplicacion aplication)
        {
            this.app = aplication;
            lblMensaje.Text = "¿Esta Seguro que quiere cerrar Sesion ahora?";
            btn_Accion1.ButtonText = "Aceptar";
            btn_Accion2.ButtonText = "Cancelar";
            estado = 3;
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAccion_click(object sender, EventArgs e)
        {
            BunifuThinButton2 btn = sender as BunifuThinButton2;

            switch (this.estado)
            {
                case 1:
                    if(btn_Accion1.Name == btn.Name)
                    {
                        login.CerrarFormulario();
                    }
                    if(btn_Accion2.Name == btn.Name)
                    {
                        this.Close();
                    }
                    break;
                case 2:
                    if (btn_Accion1.Name == btn.Name)
                    {
                        formularioPrincipal.CerrarFormulario();
                    }
                    if (btn_Accion2.Name == btn.Name)
                    {
                        this.Close();
                    }
                    break;
                case 3:
                    if (btn_Accion1.Name == btn.Name)
                    {
                        app.iniciarAplicacion(1);
                        this.Close();
                    }
                    if (btn_Accion2.Name == btn.Name)
                    {
                        this.Close();
                    }
                    break;
            }
        }
    }
}
