using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFBS.Presentacion.Formularios.FormularioPrincipal.Modulo;
using WFBS.Presentacion.Formularios.FormularioPrincipal.Modulo.Otros;
using WFBS.Presentacion.Formularios.FormularioPrincipal.Otros;
using WFBS.Presentacion.Formularios.FormularioPrincipal.Otros.Ayuda;
using WFBS.Presentacion.Formularios.FormularioPrincipal.Otros.Listado;

namespace WFBS.Presentacion.Formularios.FormularioPrincipal
{
    public partial class FormularioPrincipal : Form
    {


        #region DEFINIR PARAMETROS
        private bool respuesta = false;
        private ListadoPrincipal ListarFuncionario, ListarJefeFuncionario, ListarPerfil, ListarCargo,ListarCompetencia, ListarEvaluacion;
        private ListadoReporte ListadoReporte;
        private Aplicacion app;
        private Dashboard dashboard;
        private Logotipo logo = new Logotipo();
        private int estadoMR = 0;
        private double numero = 0, numero2 = 0;
        private int estadoDashboard = 0, estadoFuncionario = 0, estadoPerfil = 0, estadoCompetencia = 0, estadoEvaluacion = 0, estadoReporte = 0, estadoCRUD = 0;
        #endregion

        public FormularioPrincipal()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
            AbrirFormulario(logo);
        }

        public bool recibirMensajeFuncionario()
        {
            Ventanas.Cerrar ventana = new Ventanas.Cerrar();
            ventana.iniciarFormulario(4);
            ventana.PasarDatos(this);
            ventana.ShowDialog();
            return respuesta;
        }

        public void IngresarRespuesta(bool resp)
        {
            this.respuesta = resp;
        }

        public bool estadoActualCrud()
        {
            bool resultado = false;
            if(estadoCRUD == 0)
            {
                resultado= false;
            }else
            {
                resultado= true;
            }
            return resultado;
        }

        public void CargandoFormulario(string mensaje)
        {
            Cargando cargar = new Cargando();
            cargar.CambiarMensaje(mensaje);
            AbrirFormulario(cargar);
        }

        #region INICIALIZAR FORMULARIO
        private void InicializarToolTip(int numero)
        {
            switch (numero)
            {
                case 0:
                    ToolTip tt = new ToolTip();
                    tt.InitialDelay = 0;
                    tt.SetToolTip(this.btnDashboard, "DASHBOARD");
                    tt.SetToolTip(this.btnFuncionario, "FUNCIONARIO");
                    tt.SetToolTip(this.btnPerfil, "PERFIL");
                    tt.SetToolTip(this.btnCompetencia, "COMPETENCIA");
                    tt.SetToolTip(this.btnEvaluacion, "EVALUACION");
                    tt.SetToolTip(this.btnReporte, "REPORTE");

                    tt.SetToolTip(this.btnAyuda, "AYUDA");
                    tt.SetToolTip(this.btnCerrarSesion, "CERRAR SESION");
                    break;
            }

        }

        private void InicializarBotones()
        {
            btnDashboard.Image = Properties.Resources.Dashboard;
            btnFuncionario.Image = Properties.Resources.Funcionario;
            btnPerfil.Image = Properties.Resources.Perfil;
            btnCompetencia.Image = Properties.Resources.Competencia;
            btnEvaluacion.Image = Properties.Resources.Evaluacion;
            btnReporte.Image = Properties.Resources.Reporte;
        }
        private void InicializarSideMenu()
        {
            //botones <MINI>
            SidePanelDashboardMini.BackColor = Color.FromArgb(19, 27, 39);
            SidePanelFuncionarioMini.BackColor = Color.FromArgb(19, 27, 39);
            SidePanelPerfilMini.BackColor = Color.FromArgb(19, 27, 39);
            SidePanelCompetenciaMini.BackColor = Color.FromArgb(19, 27, 39);
            SidePanelEvaluacionMini.BackColor = Color.FromArgb(19, 27, 39);
            SidePanelReporteMini.BackColor = Color.FromArgb(19, 27, 39);
        }
        private void InicializarMenuOculto()
        {
            btnAccion2.Enabled = false;
            btnAccion1.Enabled = false;
            btnAccion1.Click -= null;
            btnAccion2.Click -= null;

        }

        private void OcultarMenu()
        {
            panelSubMenuOculto.Visible = false;
        }
        private void InicializarSubMenuAccionBoton()
        {
            btnAgregar.Click -= null;
            btnModificar.Click -= null;
            btnEliminar.Click -= null;
        }
        private void InicializarSubMenu()
        {
            if (panelMenuDatagrid.Visible == false)
            {
                panelMenuDatagrid.Visible = true;
            }

        }
        #endregion

        #region INICIAR APLICACION

        private void OcultalFormularios()
        {
            ListarFuncionario.Hide();
            ListarJefeFuncionario.Hide();
            ListarPerfil.Hide();
            ListarCargo.Hide();


        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            BunifuImageButton btn = sender as BunifuImageButton;

            if (btn.Name == btnDashboard.Name)
            {
                if(estadoDashboard == 0 && estadoCRUD == 0)
                {
                    IniciarDashboard();
                }


            }
            if (btn.Name == btnFuncionario.Name )
            {
                if (estadoFuncionario == 0 && estadoCRUD == 0)
                {
                    IniciarProcemiento(1);
                }
                else
                {
                    SystemSounds.Hand.Play();
                }
            }
            if (btn.Name == btnPerfil.Name)
            {
                if (estadoPerfil == 0 && estadoCRUD == 0)
                {
                    IniciarProcemiento(2);
                }
                else
                {
                    SystemSounds.Hand.Play();
                }
            }
            if (btn.Name == btnCompetencia.Name)
            {
                if (estadoCompetencia == 0 && estadoCRUD == 0)
                {
                    IniciarProcemiento(3);
                }
                else
                {
                    SystemSounds.Hand.Play();
                }
            }
            if (btn.Name == btnEvaluacion.Name)
            {
                if (estadoEvaluacion == 0 && estadoCRUD == 0)
                {
                    IniciarProcemiento(4);
                }
                else
                {
                    SystemSounds.Hand.Play();
                }

            }
            if (btn.Name == btnReporte.Name)
            {
                if (estadoReporte == 0 && estadoCRUD == 0)
                {
                    IniciarProcemiento(5);
                }
                else
                {
                    SystemSounds.Hand.Play();
                }

            }
        }
        private void inicializarEstado()
        {
            estadoDashboard = 0;
            estadoFuncionario = 0;
            estadoPerfil = 0;
            estadoCompetencia = 0;
            estadoEvaluacion = 0;
            estadoReporte = 0;
        }


        public void IniciarDashboard()
        {
            inicializarEstado();
            InicializarBotones();
            OcultarMenu();
            InicializarSideMenu();
            PanelCRUD.Visible = false;
            panelMenuDatagrid.Visible = false;
            this.btnDashboard.Image = Properties.Resources.Dashboard_Active;
            this.SidePanelDashboardMini.BackColor = Color.FromArgb(125, 62, 55);
            dashboard.IniciarAplicacion();
        }

        public void TerminarDashboard()
        {
            AbrirFormulario(dashboard);
            estadoDashboard = 1;
            this.numero = 0;
        }


        private void IniciarProcemiento(double numero)
        {
            switch (numero)
            {
                case 1:
                    inicializarEstado();
                    InicializarBotones();
                    InicializarMenuOculto();
                    InicializarSideMenu();
                    PanelCRUD.Visible = false;
                    panelMenuDatagrid.Visible = false;
                    this.btnFuncionario.Image = Properties.Resources.Funcionario_Active;
                    this.SidePanelFuncionarioMini.BackColor = Color.FromArgb(125, 62, 55);
                    GenerarControlesPrincipales(numero);
                    AbrirFormulario(logo);
                    estadoFuncionario = 1;
                    
                    this.numero = numero;
                    break;
                case 2:
                    inicializarEstado();
                    InicializarBotones();
                    InicializarMenuOculto();
                    InicializarSideMenu();
                    PanelCRUD.Visible = false;
                    panelMenuDatagrid.Visible = false;
                    this.btnPerfil.Image = Properties.Resources.Perfil_Active;
                    this.SidePanelPerfilMini.BackColor = Color.FromArgb(125, 62, 55);
                    GenerarControlesPrincipales(numero);
                    AbrirFormulario(logo);
                    estadoPerfil = 1;

                    this.numero = numero;

                    break;
                case 3:
                    inicializarEstado();
                    InicializarBotones();
                    OcultarMenu();
                    InicializarSideMenu();
                    PanelCRUD.Visible = false;
                    panelMenuDatagrid.Visible = false;
                    this.btnCompetencia.Image = Properties.Resources.Competencia_Active;
                    this.SidePanelCompetenciaMini.BackColor = Color.FromArgb(125, 62, 55);
                    if (ListarCompetencia.isActive())
                    {
                        ListarCompetencia.RestablecerNumero(numero);
                    }
                   
                    AbrirFormulario(ListarCompetencia);

                    estadoCompetencia = 1;

                    this.numero = numero;
                    break;
                case 4:
                    inicializarEstado();
                    InicializarBotones();
                    OcultarMenu();
                    InicializarSideMenu();
                    PanelCRUD.Visible = false;
                    panelMenuDatagrid.Visible = false;
                    this.btnEvaluacion.Image = Properties.Resources.Evaluacion_Active;
                    this.SidePanelEvaluacionMini.BackColor = Color.FromArgb(125, 62, 55);
                    if (ListarEvaluacion.isActive())
                    {
                        ListarEvaluacion.RestablecerNumero(numero);
                    }
                   AbrirFormulario(ListarEvaluacion);
                    estadoEvaluacion = 1;
                    this.numero = numero;
                    break;
                case 5:
                    inicializarEstado();
                    InicializarBotones();
                    OcultarMenu();
                    InicializarSideMenu();
                    PanelCRUD.Visible = false;
                    panelMenuDatagrid.Visible = false;
                    this.btnReporte.Image = Properties.Resources.Reporte_Active;
                    this.SidePanelReporteMini.BackColor = Color.FromArgb(125, 62, 55);
                    if (ListadoReporte.isActive())
                    {
                        ListadoReporte.RestablecerNumero(1);
                    }
                    AbrirFormulario(ListadoReporte);
                    estadoReporte = 1;
                    this.numero = numero;
                    break;
            }
        }

        private void GenerarControlesPrincipales(double numero)
        {
            switch (numero)
            {
                case 1:
                    panelSubMenuOculto.Visible = true;
                    btnAccion1.Text = "Funcionario";
                    btnAccion2.Text = "Jefe Funcionario";
                    btnAccion1.Visible = true;
                    btnAccion2.Visible = true;
                    btnAccion1.Enabled = true;
                    btnAccion2.Enabled = true;
                    break;
                case 2:
                    panelSubMenuOculto.Visible = true;
                    btnAccion1.Text = "Perfil";
                    btnAccion2.Text = "Cargo";
                    btnAccion1.Visible = true;
                    btnAccion2.Visible = true;
                    btnAccion1.Enabled = true;
                    btnAccion2.Enabled = true;
                    break;
            }
        }

        private void FormularioPrincipal_Shown(object sender, EventArgs e)
        {

        }

        private void btnMenuOculto_Click(object sender, EventArgs e)
        {
            BunifuFlatButton btn = sender as BunifuFlatButton;

            switch (this.numero)
            {
                case 1:
                    if (btn.Name == btnAccion1.Name && estadoCRUD == 0)
                    {
                        btnAccion1.Enabled = false;
                        btnAccion2.Enabled = true;
                        PanelCRUD.Visible = false;
                        if (ListarFuncionario.isActive())
                        {
                            ListarFuncionario.RestablecerNumero(1.11);
                            AbrirFormulario(ListarFuncionario);
                        }
                        else
                        {
                            AbrirFormulario(ListarFuncionario);
                        }
                        GenerarControlesSubFormulario(1.11);

                    }
    
                    if (btn.Name == btnAccion2.Name && estadoCRUD == 0)
                    {
                        btnAccion1.Enabled = true;
                        btnAccion2.Enabled = false;
                        PanelCRUD.Visible = false;

                        if (ListarJefeFuncionario.isActive())
                        {
                            ListarJefeFuncionario.RestablecerNumero(1.21);
                            AbrirFormulario(ListarJefeFuncionario);
                        }
                        else
                        {
                            AbrirFormulario(ListarJefeFuncionario);
                        }
                 
                        GenerarControlesSubFormulario(1.21);
                    }
    
                    break;
                case 2:
                    if (btn.Name == btnAccion1.Name && estadoCRUD == 0)
                    {
                        btnAccion1.Enabled = false;
                        btnAccion2.Enabled = true;
                        PanelCRUD.Visible = false;
                        AbrirFormulario(ListarPerfil);
                        GenerarControlesSubFormulario(2.11);
                    }
                    else
                    {
                        SystemSounds.Hand.Play();
                    }
                    if (btn.Name == btnAccion2.Name && estadoCRUD == 0)
                    {
                        btnAccion1.Enabled = true;
                        btnAccion2.Enabled = false;
                        PanelCRUD.Visible = false;
                        AbrirFormulario(ListarCargo);
                        GenerarControlesSubFormulario(2.22);
                    }

                    break;
            }
        }

        public void GenerarControlesSubFormulario(double numero)
        {
            switch (numero)
            {
                case 1.11:
                    InicializarSubMenu();
                    panelSubMenuOculto.Visible = true;
                    numero2 = numero;
                    break;
                case 1.12:
                    panelMenuDatagrid.Visible = false;
                    break;
                case 1.21:
                    InicializarSubMenu();
                    panelSubMenuOculto.Visible = true;
                    numero2 = numero;
                    break;
                case 1.22:
                    panelMenuDatagrid.Visible = false;
                    break;
                case 2.11:
                    InicializarSubMenu();
                    panelSubMenuOculto.Visible = true;
                    numero2 = numero;
                    break;
                case 2.21:
                    InicializarSubMenu();
                    panelSubMenuOculto.Visible = true;
                    numero2 = numero;
                    break;
                case 3.1:
                    InicializarSubMenu();
                    InicializarBotones();
                    OcultarMenu();
                    InicializarSubMenu();
                    numero2 = numero;
                    break;
                case 3.2:
                    InicializarSubMenu();
                    InicializarBotones();
                    OcultarMenu();
                    InicializarSubMenu();
                    numero2 = numero;
                    break;
                case 4.1:
                    InicializarSubMenu();
                    InicializarBotones();
                    OcultarMenu();
                    InicializarSubMenu();
                    numero2 = numero;
                    break;
                case 4.2:
                    InicializarSubMenu();
                    InicializarBotones();
                    OcultarMenu();
                    InicializarSubMenu();
                    numero2 = numero;
                    break;
                case 4.3:
                    InicializarSubMenu();
                    InicializarBotones();
                    OcultarMenu();
                    InicializarSubMenu();
                    numero2 = numero;
                    break;
            }
        }

        #endregion

        #region INICIAR FORMULARIOS
        public void pasarDatos(Aplicacion apli)
        {
            this.app = apli;
        }
        public void DefinirAplicacion(int numero)
        {
            switch (numero)
            {
                case 0:
                    dashboard = new Dashboard();
                    dashboard.pasarDatos(this);
                    break;
            }
        }

        public void DefinirFormulario(double numero, DataSet lista, bool estado)
        {
            switch (numero)
            {
                case 1.11:
                    ListarFuncionario = new ListadoPrincipal();
                    ListarFuncionario.DefinirFormulario(numero,lista,estado);
                    ListarFuncionario.PasarDatos(this);
                    break;
               case 1.21:
                    ListarJefeFuncionario = new ListadoPrincipal();
                    ListarJefeFuncionario.DefinirFormulario(numero, lista,estado);
                    ListarJefeFuncionario.PasarDatos(this);
                    break;
               case 2.11:
                    ListarPerfil = new ListadoPrincipal();
                    ListarPerfil.DefinirFormulario(numero, lista,estado);
                    ListarPerfil.PasarDatos(this);
                    break;
               case 2.21:
                         ListarCargo = new ListadoPrincipal();
                        ListarCargo.DefinirFormulario(numero, lista,estado);
                    ListarCargo.PasarDatos(this);
                    break;
                case 3:
                    ListarCompetencia = new ListadoPrincipal();
                    ListarCompetencia.DefinirFormulario(numero, lista,estado);
                    ListarCompetencia.PasarDatos(this);

                    break;
                case 4:
                    ListarEvaluacion = new ListadoPrincipal();
                    ListarEvaluacion.DefinirFormulario(numero, lista,estado);
                    ListarEvaluacion.PasarDatos(this);
                    break;
                case 5:
                    ListadoReporte = new ListadoReporte();
                     ListadoReporte.DefinirFormulario(1, lista,estado);
                    break;
            }
        }
        private void Agregar()
        {
            switch (this.numero2)
            {

                        case 4.1:
                    Modulo.Evaluacion evaluacion = new Modulo.Evaluacion();
                    evaluacion.AgregarFuncionario();
                    AbrirModulo(evaluacion);
                    PanelCRUD.Visible = true;

                            break;

            }
        }
        #endregion
        #region ACCION DE LOS BOTONES PARA EL SUBFORMULARIO

        private void btnAccionSubMenu_Click(object sender, EventArgs e)
        {
            PictureBox btn = sender as PictureBox;

            if (btn.Name == btnCerrar.Name)
            {
                PanelCRUD.Visible = false;
                panelSubMenuOculto.Visible = false;
                panelMenuDatagrid.Visible = false;
                IniciarProcemiento(1);
            }


            switch (this.numero2)
            {
                case 1.11:
                    if (btn.Name == btnAgregar.Name)
                    {
                        if (estadoCRUD == 0)
                        {
                            Modulo.Funcionario moduloFuncionario = new Modulo.Funcionario();
                            btnAgregar.BackColor = Color.FromArgb(35, 42, 55);
                            moduloFuncionario.IniciarFormulario(1);
                            moduloFuncionario.PasarDatos(this);
                            AbrirModulo(moduloFuncionario);
                            PanelCRUD.Visible = true;
                            estadoCRUD = 1;
                        }
                        else
                        {
                            SystemSounds.Hand.Play();
                        }

                    }
                    if (btn.Name == btnModificar.Name)
                    {
                        Estado estado = new Estado();
                        estado.estado(true, 1);
                        AbrirModulo(estado);
                        PanelCRUD.Visible = true;
                    }


                    break;
                case 2.2:
                    if (btn.Name == btnAgregar.Name)
                    {
                        MessageBox.Show("AGREGAR Jefe Funcionario");
                        //if (ModulojefeFuncionario == null)
                        //{ ModulojefeFuncionario = new Modulos.ModuloJefeFuncionario(); }
                        //PanelCRUD.Visible = true;
                        //AbrirModulo(ModulojefeFuncionario);
                    }
                    break;
                case 3.1:
                    if (btn.Name == btnAgregar.Name)
                    {
                        MessageBox.Show("AGREGAR COMPETENCIA");
                        //if (ModuloFuncionario == null)
                        //{ ModuloFuncionario = new Modulos.ModuloFuncionario(); }
                        //PanelCRUD.Visible = true;
                        //ModuloFuncionario.InicializarAgregarFuncionario();
                        //AbrirModulo(ModuloFuncionario);
                    }
                    break;
                case 3.2:
                    if (btn.Name == btnAgregar.Name)
                    {
                        MessageBox.Show("AGREGAR OBSERVACION");
                        //if (ModuloFuncionario == null)
                        //{ ModuloFuncionario = new Modulos.ModuloFuncionario(); }
                        //PanelCRUD.Visible = true;
                        //ModuloFuncionario.InicializarAgregarFuncionario();
                        //AbrirModulo(ModuloFuncionario);
                    }
                    break;
                case 4.1:
                    if (btn.Name == btnAgregar.Name)
                    {
                        MessageBox.Show("AGREGAR EVALUACION");
                        Agregar();
                        btnAgregar.BackColor = Color.FromArgb(49, 60, 77);

                    }
                    break;
                case 4.2:
                    if (btn.Name == btnAgregar.Name)
                    {
                        MessageBox.Show("AGREGAR PREGUNTAS");
                        //if (ModuloFuncionario == null)
                        //{ ModuloFuncionario = new Modulos.ModuloFuncionario(); }
                        //PanelCRUD.Visible = true;
                        //ModuloFuncionario.InicializarAgregarFuncionario();
                        //AbrirModulo(ModuloFuncionario);
                    }
                    break;
                case 4.3:
                    if (btn.Name == btnAgregar.Name)
                    {
                        MessageBox.Show("AGREGAR ALTERNATIVAS");
                        //if (ModuloFuncionario == null)
                        //{ ModuloFuncionario = new Modulos.ModuloFuncionario(); }
                        //PanelCRUD.Visible = true;
                        //ModuloFuncionario.InicializarAgregarFuncionario();
                        //AbrirModulo(ModuloFuncionario);
                    }
                    break;

            }
        }
        #endregion





        #region CONTROL DEL FORMULARIO

        private void btnSubControles_Click(object sender, EventArgs e)
        {
            BunifuImageButton btn = sender as BunifuImageButton;

            if(btn.Name == btnCerrarSesion.Name)
            {

                SystemSounds.Exclamation.Play();
                
                Ventanas.Cerrar cerrar = new Ventanas.Cerrar();
               
                cerrar.PasarDatos(app);
                cerrar.iniciarFormulario(3);
                cerrar.ShowDialog();

            }

            if (btn.Name == btnAyuda.Name)
            {
                Ayuda ayuda = new Ayuda();
                ayuda.ShowDialog();
            }

            if (btn.Name == btnFullScreen.Name)
            {
                btnFullScreen.Visible = false;
                btnRestaurarFullScreen.Visible = true;

                if (btnRestaurarFormulario.Visible == true)
                {
                    btnRestaurarFormulario.Visible = false;
                    estadoMR = 1;
                }else if (btnMaximizarFormulario.Visible == true){
                    btnMaximizarFormulario.Visible = false;
                    estadoMR = 2;
                }


                app.Controles(6);
            }

            if (btn.Name == btnRestaurarFullScreen.Name)
            {
                btnRestaurarFullScreen.Visible = false;
                btnFullScreen.Visible = true;
                if(estadoMR == 1)
                {
                    btnRestaurarFormulario.Visible = true;
                }else if (estadoMR == 2)
                {
                    btnMaximizarFormulario.Visible = true;
                }
                estadoMR = 0;
                
                
                app.Controles(7);

            }

        }

        private void btnControles_Click(object sender, EventArgs e)
        {

            BunifuImageButton btn = sender as BunifuImageButton;

            if (btn.Name == btn_cerrarFormulario.Name)
            {
                Ventanas.Cerrar cerrar = new Ventanas.Cerrar();
                cerrar.iniciarFormulario(2);
                cerrar.ShowDialog();
            }
            if (btn.Name == btnMinimizarFormulario.Name)
            {
                app.Controles(2);
            }

            if (btn.Name == btnMaximizarFormulario.Name)
            {
                app.Controles(3);
                btnMaximizarFormulario.Visible = false;
                btnRestaurarFormulario.Visible = true;


            }
            if (btn.Name == btnRestaurarFormulario.Name)
            {
                btnMaximizarFormulario.Visible = true;
                btnRestaurarFormulario.Visible = false;
                app.Controles(4);
            }


        }
        #endregion


        public void CerrarFormulario()
        {
            Application.Exit();
        }



        public void CargarFromularioCRUD()
        {
            Modulo.Otros.Cargando load = new Modulo.Otros.Cargando();
            AbrirModulo(load);

        }

        public bool estadoFinalCrud(int numero, bool resp, Funcionario fun)
        {
                  Estado ventanaEstado = new Estado();
                   ventanaEstado.estado(resp, 1);
                    AbrirModulo(ventanaEstado);
                    PanelCRUD.Visible = true;
            if (resp)
                    {
                       
                        System.Threading.Thread.Sleep(6000);
                        fun.Close();
                        PanelCRUD.Visible = false;
                        estadoCRUD = 0;

                        return true;

                    }
                    else
            { 
                        System.Threading.Thread.Sleep(6000);
                        AbrirModulo(fun);
                        return false;

                    }
        }

        #region METODOS ABRIR FORMULARIO


        private void AbrirFormulario(object formHijo)
        {
            this.PanelContenedor.Visible = false;
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
            this.PanelContenedor.Visible = true;
        }


        private void AbrirModulo(object formHijo)
        {
            if (this.PanelCRUD.Controls.Count > 0)
                this.PanelCRUD.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.PanelCRUD.Controls.Add(fh);
            this.PanelCRUD.Tag = fh;
            fh.Show();
        }

        #endregion
    }
}
