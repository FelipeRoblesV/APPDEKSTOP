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
using WFBS.Entidades;
using WFBS.Controlador;

namespace WFBS.Presentacion.Formularios.Login.Modulo
{
    public partial class IniciarSesion : Form
    {
        private IniciarAplicacion iniciar;
        private Cargando preloader = new Cargando();
        private FormularioPrincipal.FormularioPrincipal formulario;
        private BackgroundWorker iniciarSesion, iniciarAplicacion;
        private bool respuesta = false;
        private Cl_Usuario usuario;
        private daoUsuario dao;
        private Aplicacion app;
        private Login login;
        private double numero = 0;

        public IniciarSesion()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
            txtUsuario.Text = Properties.Settings.Default.RecordarUsuario;
            chkRecuerdame.Checked = Properties.Settings.Default.ChkRecordarUsuario;
        }

        public void pasarDatos(Aplicacion apli, Login login)
        {
            this.app = apli;
            this.login = login;
        }

        public FormularioPrincipal.FormularioPrincipal recuperarFormulario()
        {
            return formulario;
        }

        #region INICIAR SESION
        private void IniciarSesion_background()
        {
            if (iniciarSesion == null)
            {
                if (usuario == null)
                {
                    usuario = new Cl_Usuario();
                }
                iniciarSesion = new BackgroundWorker();
                iniciarSesion.WorkerReportsProgress = true;
                iniciarSesion.DoWork += new DoWorkEventHandler(iniciarSesion_DoWork);
                iniciarSesion.RunWorkerCompleted += new RunWorkerCompletedEventHandler(iniciarSesion_RunWorkerCompleted);
                iniciarSesion.ProgressChanged += new ProgressChangedEventHandler(iniciarSesion_ProgressChanged);
            }
            if (iniciarSesion.IsBusy == false)
            {

                iniciarSesion.RunWorkerAsync(usuario);
            }

        }

        private void iniciarSesion_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            switch (this.numero)
            {
                case 1:
                    login.IniciarVerificacion();
                    break;
                case 2:
                    Exception exception = (Exception)e.UserState;
                    imagenLogotipo.Visible = false;
                    lbl_titulo.Visible = false;
                    lblErrorGeneral.Text = exception.Message;
                    lblErrorGeneral.Visible = true;
                    break;
            }
        }

        private void iniciarSesion_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {

                if (respuesta)
                {
                    if (chkRecuerdame.Checked == true)
                    {
                        Properties.Settings.Default.RecordarUsuario = txtUsuario.Text;
                        Properties.Settings.Default.ChkRecordarUsuario = true;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        Properties.Settings.Default.RecordarUsuario = String.Empty;
                        Properties.Settings.Default.ChkRecordarUsuario = false;
                        Properties.Settings.Default.Save();
                    }


                    IniciarAplicacion();


                }
                else
                {
                    login.VerificacionIncorrecta();
                }
            }
            catch (Exception ex)
            {

                lblErrorGeneral.Text = ex.Message;
            }

        }

        private void iniciarSesion_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker iniciarSesion = sender as BackgroundWorker;
            Cl_Usuario usuario = (Cl_Usuario)e.Argument;

            try
            {
                this.numero = 1;
                iniciarSesion.ReportProgress(1);
                usuario.rut = txtUsuario.Text;
                usuario.password = txtContraseña.Text;


                if (dao == null)
                {
                    dao = new daoUsuario();
                }
                respuesta = dao.Login(usuario);


            }
            catch (Exception ex)
            {
                this.numero = 2;
                iniciarSesion.ReportProgress(2, ex);
            }
        }

        #endregion

        #region INICIAR APLICACION

        private void IniciarAplicacion()
        {
            if (iniciarAplicacion == null)
            {
                iniciarAplicacion = new BackgroundWorker();
                iniciarAplicacion.WorkerReportsProgress = true;
                iniciarAplicacion.DoWork += new DoWorkEventHandler(iniciarAplicacion_DoWork);
                iniciarAplicacion.RunWorkerCompleted += new RunWorkerCompletedEventHandler(iniciarAplicacion_RunWorkerCompleted);
                iniciarAplicacion.ProgressChanged += new ProgressChangedEventHandler(iniciarAplicacion_ProgressChanged);
                iniciar = new IniciarAplicacion();
            }
            if (iniciarSesion.IsBusy == false)
            {
                iniciarAplicacion.RunWorkerAsync(iniciar);
            }

        }

        private void iniciarAplicacion_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            IniciarAplicacion iniciar = (IniciarAplicacion)e.UserState;
            

            int numero = e.ProgressPercentage;

            switch (numero)
            {
                case 1:
                    login.VerificacionCorrecta(iniciar.mensaje);
                    break;
                case 2:
                    if (formulario == null)
                    {
                        formulario = new FormularioPrincipal.FormularioPrincipal();
                    }
                    try
                    {
                        DataSet lista = iniciar.listarFuncionario;
                        formulario.DefinirFormulario(1.11, lista, true);
                    }
                    catch (Exception)
                    {
                        DataSet lista = null;
                        formulario.DefinirFormulario(1.11, lista, false);
                    }
                    try
                    {
                        DataSet lista = iniciar.listarJefeFuncionario;
                        formulario.DefinirFormulario(1.21, lista, true);
                    }
                    catch (Exception)
                    {
                        DataSet lista = null;
                        formulario.DefinirFormulario(1.21, lista, false);
                    }
                    try
                    {
                        DataSet lista = iniciar.listarPerfil;
                        formulario.DefinirFormulario(2.11, lista, true);
                    }
                    catch (Exception)
                    {
                        DataSet lista = null;
                        formulario.DefinirFormulario(2.11, lista, false);
                    }
                    try
                    {
                        DataSet lista = iniciar.listarCargo;
                        formulario.DefinirFormulario(2.21, lista, true);
                    }
                    catch (Exception)
                    {
                        DataSet lista = null;
                        formulario.DefinirFormulario(2.21, lista, false);
                    }
                    try
                    {
                        DataSet lista = iniciar.listarCompetencia;
                        formulario.DefinirFormulario(3, lista, true);
                    }
                    catch (Exception)
                    {
                        DataSet lista = null;
                        formulario.DefinirFormulario(3, lista, false);
                    }
                    try
                    {
                        DataSet lista = iniciar.listarEvaluacion;
                        formulario.DefinirFormulario(4, lista, true);
                    }
                    catch (Exception)
                    {
                        DataSet lista = null;
                        formulario.DefinirFormulario(4, lista, false);
                    }
                    try
                    {
                        DataSet lista = iniciar.listarReporte;
                        formulario.DefinirFormulario(5, lista, true);
                    }
                    catch (Exception)
                    {
                        DataSet lista = null;
                        formulario.DefinirFormulario(5, lista, false);
                    }

                    formulario.DefinirAplicacion(0);
                    break;
            }
        }

        private void iniciarAplicacion_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (chkRecuerdame.Checked == true)
                {
                    Properties.Settings.Default.RecordarUsuario = txtUsuario.Text;
                    Properties.Settings.Default.ChkRecordarUsuario = true;
                    Properties.Settings.Default.UsuarioConectado = txtUsuario.Text;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.RecordarUsuario = String.Empty;
                    Properties.Settings.Default.ChkRecordarUsuario = false;
                    Properties.Settings.Default.UsuarioConectado = txtUsuario.Text;
                    Properties.Settings.Default.Save();
                }
                app.iniciarAplicacion(2);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void iniciarAplicacion_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                BackgroundWorker IniciarAplicacion = sender as BackgroundWorker;
                IniciarAplicacion iniciar = (IniciarAplicacion)e.Argument;


                iniciar.mensaje = "Iniciando Aplicacion";
                IniciarAplicacion.ReportProgress(1, iniciar);
                daoFuncionario daoFun = new daoFuncionario();
                daoJefeFuncionario daoJefeFuncionario = new daoJefeFuncionario();
                daoPerfil daoPerfil = new daoPerfil();
                daoCargo daoCargo = new daoCargo();
                daoCompetencia daoCompetencia = new daoCompetencia();
                daoCuestionario daoEvaluacion = new daoCuestionario();
                daoPerfil daoReporte = new daoPerfil();


                iniciar.listarFuncionario = daoFun.listar();
                iniciar.listarJefeFuncionario = daoJefeFuncionario.listar();
                iniciar.listarPerfil = daoPerfil.listar();
                iniciar.listarCargo = daoCargo.listar();
                iniciar.listarCompetencia = daoCompetencia.ListarPerfil();
                iniciar.listarEvaluacion = daoEvaluacion.ListarPerfil();
                iniciar.listarReporte = daoReporte.listar();
                IniciarAplicacion.ReportProgress(2, iniciar);
            }
            catch (Exception)
            {

                throw;
            }
        }



        #endregion




        private void btnRedesSociales_Click(object sender, EventArgs e)
        {
            BunifuImageButton btn = sender as BunifuImageButton;

            if (btn.Name == btnFacebook.Name)
            {
                System.Diagnostics.Process.Start("www.facebook.cl");
            }
            else if (btn.Name == btnTwitter.Name)
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
                lblErrorGeneral.Visible = true;
            }
            else
            {
                contador++;
                lblUsuario.ForeColor = Color.FromArgb(90, 99, 113);
                txtUsuario.BorderColorIdle = Color.FromArgb(90, 99, 113);
                txtUsuario.BorderColorFocused = Color.FromArgb(105, 99, 113);
                txtUsuario.BorderColorMouseHover = Color.FromArgb(105, 99, 113);
                txtUsuario.ForeColor = Color.FromArgb(206, 210, 217);
                lblErrorGeneral.Visible = false;
            }

            if (txtContraseña.Text.Trim() == "")
            {
                lblContraseña.ForeColor = Color.FromArgb(152, 75, 67);
                txtContraseña.BorderColorIdle = Color.FromArgb(152, 75, 67);
                txtContraseña.BorderColorFocused = Color.FromArgb(111, 55, 49);
                txtContraseña.BorderColorMouseHover = Color.FromArgb(139, 69, 61);
                txtContraseña.ForeColor = Color.FromArgb(237, 83, 66);
                lblErrorGeneral.Text = "Faltan Ingresar datos en (Contraseña)";
                lblErrorGeneral.Visible = true;
            }
            else
            {
                contador++;
                lblContraseña.ForeColor = Color.FromArgb(90, 99, 113);
                txtContraseña.BorderColorIdle = Color.FromArgb(90, 99, 113);
                txtContraseña.BorderColorFocused = Color.FromArgb(105, 99, 113);
                txtContraseña.BorderColorMouseHover = Color.FromArgb(105, 99, 113);
                txtContraseña.ForeColor = Color.FromArgb(206, 210, 217);
                lblErrorGeneral.Visible = false;
            }

            if (contador == 1)
            {
                lblErrorGeneral.Text = "Faltan Ingresar datos en (Usuario, Contraseña)";
                lblErrorGeneral.Visible = true;

            }
            else if (contador == 3)
            {
                if (chkRecuerdame.Checked == false)
                {
                    Properties.Settings.Default.RecordarUsuario = String.Empty;
                    Properties.Settings.Default.ChkRecordarUsuario = false;
                    Properties.Settings.Default.Save();
                }

                lblErrorGeneral.Visible = false;
                IniciarSesion_background();
            }
        }



    }
}
