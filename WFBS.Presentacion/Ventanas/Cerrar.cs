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
using WFBS.Presentacion.Formularios.FormularioPrincipal.Modulo;
using WFBS.Presentacion.Formularios.Login;

namespace WFBS.Presentacion.Ventanas
{
    public partial class Cerrar : Form
    {
        private int estado = 0;
        private Login login;
        private Formularios.FormularioPrincipal.FormularioPrincipal formularioPrincipal;
        private Aplicacion app;
        private bool CambiarRut = false;
        public Cerrar()
        {
            InitializeComponent();
        }

        #region PASAR DATOS

        public void PasarDatos(Login login)
        {
            this.login = login;
        }

        public void PasarDatos(Formularios.FormularioPrincipal.FormularioPrincipal Formulario)
        {
            this.formularioPrincipal = Formulario;
        }

        public void PasarDatos(Aplicacion aplication)
        {
            this.app = aplication;
        }

        #endregion


        public void iniciarFormulario(int numero)
        {
            switch (numero)
            {
                case 1:
                    this.estado = numero;
                    lblMensaje.Text = "¿Esta Seguro que quiere cerrar ahora?";
                    btn_Accion1.ButtonText = "Aceptar";
                    btn_Accion2.ButtonText = "Cancelar";
                    break;
                case 2:
                    this.estado = numero;
                    lblMensaje.Text = "¿Esta Seguro que quiere cerrar ahora?";
                    btn_Accion1.ButtonText = "Aceptar";
                    btn_Accion2.ButtonText = "Cancelar";
                    break;
                case 3:
                    this.estado = numero;
                    lblMensaje.Text = "¿Esta Seguro que quiere cerrar ahora?";
                    btn_Accion1.ButtonText = "Aceptar";
                    btn_Accion2.ButtonText = "Cancelar";
                    break;
                case 4:
                    this.estado = numero;
                    lblMensaje.Text = "¿Esta Seguro que quiere borrar rut ingresado, si lo realiza se podria perder la informacion ingresada";
                    btn_Accion1.ButtonText = "Aceptar";
                    btn_Accion2.ButtonText = "Cancelar";
                    break;
            }
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
                        Application.Exit();
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
                case 4:
                    if (btn_Accion1.Name == btn.Name)
                    {

                        CambiarRut = true;
                        this.Close();
                    }
                    if (btn_Accion2.Name == btn.Name)
                    {
                        CambiarRut = false;
                        this.Close();
                    }
                    break;
            }
        }

        private void Cerrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (estado)
            {
                case 4:
                    formularioPrincipal.IngresarRespuesta(CambiarRut);
                    break;
            }
        }
    }
}
