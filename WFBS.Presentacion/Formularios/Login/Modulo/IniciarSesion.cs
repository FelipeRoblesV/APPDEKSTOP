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
        private int numero = 0, numero2 = 0;

        public IniciarSesion()
        {
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
            login.VerificacionCorrecta(iniciar.mensaje);

            if (formulario == null)
            {
                formulario = new FormularioPrincipal.FormularioPrincipal();
            }

            switch (this.numero2)
            {
                case 1:
                    formulario.DefinirFormulario(this.numero2, iniciar.listarFuncionario);
                    break;
                case 2:
                    formulario.DefinirFormulario(this.numero2, iniciar.listarJefeFuncionario);
                    break;
                case 3:
                    formulario.DefinirFormulario(this.numero2, iniciar.listarPerfil);
                    break;
                case 4:
                    formulario.DefinirFormulario(this.numero2, iniciar.listarCargo);
                    break;
                case 5:
                    formulario.DefinirFormulario(this.numero2, iniciar.listarPerfil);
                    break;
                case 6:
                    formulario.DefinirFormulario(this.numero2, iniciar.listarPerfil);
                    break;
                case 7:
                    formulario.DefinirFormulario(this.numero2, iniciar.listarPerfil);
                    break;
                case 8:
                    formulario.DefinirAplicacion(1);

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
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.RecordarUsuario = String.Empty;
                    Properties.Settings.Default.ChkRecordarUsuario = false;
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
                for (int i = 0; i < 9; i++)
                {

                    switch (i)
                    {
                        case 1:
                            iniciar.mensaje = "Cargando Funcionario";
                            daoFuncionario daoFun = new daoFuncionario();
                            iniciar.listarFuncionario = daoFun.listar();
                            this.numero2 = i;
                            break;

                        case 2:
                            iniciar.mensaje = "Cargando Jefe Funcionario";
                            daoJefeFuncionario daoJefeFuncionario = new daoJefeFuncionario();
                            iniciar.listarJefeFuncionario = daoJefeFuncionario.listar();
                            this.numero2 = i;
                            break;
                        case 3:
                            iniciar.mensaje = "Cargando Perfil";
                            daoPerfil daoPerfil = new daoPerfil();
                            iniciar.listarPerfil = daoPerfil.listar();
                            this.numero2 = i;
                            break;
                        case 4:
                            iniciar.mensaje = "Cargando Cargo";
                            daoCargo daoCargo = new daoCargo();
                            iniciar.listarCargo = daoCargo.listar();
                            System.Threading.Thread.Sleep(1000);
                            this.numero2 = i;
                            break;
                        case 5:
                            iniciar.mensaje = "Cargando Competencia";
                            System.Threading.Thread.Sleep(2000);
                            this.numero2 = i;
                            break;
                        case 6:
                            iniciar.mensaje = "Cargando Evaluacion";
                            System.Threading.Thread.Sleep(2000);
                            this.numero2 = i;
                            break;
                        case 7:
                            iniciar.mensaje = "Cargando Reporte";
                            System.Threading.Thread.Sleep(2000);
                            this.numero2 = i;
                            break;
                        case 8:
                            iniciar.mensaje = "Iniciando Aplicacion";
                            System.Threading.Thread.Sleep(2000);
                            this.numero2 = i;
                            break;
                    }
                    IniciarAplicacion.ReportProgress((i + 1), iniciar);

                }
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
                }

                lblErrorGeneral.Visible = false;
                IniciarSesion_background();
            }
        }



    }
}
