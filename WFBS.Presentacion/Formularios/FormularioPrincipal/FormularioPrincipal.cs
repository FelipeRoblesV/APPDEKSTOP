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
using WFBS.Controlador;
using WFBS.Entidades;
using WFBS.Presentacion.Formularios.FormularioPrincipal.Clases;
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

        private Modulo.Funcionario modulofuncionario;
        private Modulo.JefeFuncionario moduloJefeFuncionario;
        private Modulo.Modulos_Adicionales.CargoFuncionario moduloCargoFuncionario;
        private Modulo.Perfil moduloPerfil;
        private Modulo.Cargo moduloCargo;
        private Modulo.Competencia moduloCompetencia;
        private Modulo.Observacion moduloObervacion;
        private Modulo.Evaluacion moduloEvaluacion;
        private Modulo.Preguntas moduloPreguntas;
        private Modulo.Alternativas moduloAlternativas;

        private ListadoPrincipal ListarFuncionario, ListarJefeFuncionario, ListarPerfil, ListarCargo, ListarCompetencia, ListarEvaluacion;
        private ListadoReporte ListadoReporte;
        private Aplicacion app;
        private Dashboard dashboard;
        private Logotipo logo = new Logotipo();
        private int estadoMR = 0;
        private double numero = 0, numero2 = 0, numeroCRUD = 0;
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
            if (estadoCRUD == 0)
            {
                resultado = false;
            }
            else
            {
                resultado = true;
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

        public void InicializarSubFormulario()
        {
            btnAgregar.Visible = true;
            btnModificar.Visible = true;
            btnEliminar.Visible = true;
            btnSubAccion1.Visible = true;
            btnSubAccion2.Visible = true;
            btnSubAccion3.Visible = true;
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
                if (estadoDashboard == 0 && estadoCRUD == 0)
                {
                    IniciarDashboard();
                }


            }
            if (btn.Name == btnFuncionario.Name)
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
            estadoCRUD = 1;
            dashboard.IniciarAplicacion();
        }

        public void TerminarDashboard()
        {
            AbrirFormulario(dashboard);
            estadoDashboard = 1;
            estadoCRUD = 0;
            this.numero = 0;
        }


        private void IniciarProcemiento(double numero)
        {
            switch (numero)
            {
                case 0:
                    inicializarEstado();
                    InicializarBotones();
                    OcultarMenu();
                    InicializarSideMenu();
                    PanelCRUD.Visible = false;
                    panelMenuDatagrid.Visible = false;
                    AbrirFormulario(logo);
                    break;
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

                    if (btn.Name == btnAccion2.Name && estadoCRUD == 0)
                    {
                        btnAccion1.Enabled = true;
                        btnAccion2.Enabled = false;
                        PanelCRUD.Visible = false;
                        AbrirFormulario(ListarCargo);
                        GenerarControlesSubFormulario(2.21);
                    }

                    break;
            }
        }

        public void GenerarControlesSubFormulario(double numero)
        {
            switch (numero)
            {
                case 1:
                    InicializarSubFormulario();
                    InicializarSubMenu();
                    panelSubMenuOculto.Visible = true;
                    btnSubAccion3.Visible = false;
                    btnSubAccion2.Visible = false;
                    btnSubAccion1.Visible = false;
                    btnAgregar.Visible = false;
                    btnEliminar.Visible = false;
                    btnModificar.Visible = false;
                    btnRefrescar.Visible = false;
                    break;
                case 1.11:
                    InicializarSubFormulario();
                    InicializarSubMenu();
                    panelSubMenuOculto.Visible = true;
                    btnSubAccion3.Visible = false;
                    btnSubAccion2.Visible = false;
                    numero2 = numero;
                    break;
                case 1.12:
                    InicializarSubFormulario();
                    panelMenuDatagrid.Visible = true;
                    btnSubAccion3.Visible = false;
                    btnSubAccion2.Visible = false;
                    btnSubAccion1.Visible = false;
                    btnAgregar.Visible = false;
                    btnEliminar.Visible = false;
                    btnModificar.Visible = false;
                    btnRefrescar.Visible = false;
                    break;
                case 1.21:
                    InicializarSubFormulario();
                    InicializarSubMenu();
                    panelSubMenuOculto.Visible = true;
                    btnSubAccion3.Visible = false;
                    btnSubAccion2.Visible = false;
                    numero2 = numero;
                    break;
                case 1.22:
                    InicializarSubFormulario();
                    panelMenuDatagrid.Visible = true;
                    btnSubAccion3.Visible = false;
                    btnSubAccion2.Visible = false;
                    btnSubAccion1.Visible = false;
                    btnAgregar.Visible = false;
                    btnEliminar.Visible = false;
                    btnModificar.Visible = false;
                    btnRefrescar.Visible = false;
                    break;
                case 2.11:
                    InicializarSubFormulario();
                    InicializarSubMenu();
                    panelSubMenuOculto.Visible = true;
                    btnSubAccion3.Visible = false;
                    numero2 = numero;
                    break;
                case 2.21:
                    InicializarSubFormulario();
                    InicializarSubMenu();
                    panelSubMenuOculto.Visible = true;
                    btnSubAccion3.Visible = false;
                    btnSubAccion2.Visible = false;
                    btnSubAccion1.Visible = false;
                    numero2 = numero;
                    break;
                case 3.1:
                    InicializarSubMenu();
                    panelSubMenuOculto.Visible = true;
                    btnSubAccion3.Visible = false;
                    btnSubAccion2.Visible = false;
                    btnSubAccion1.Visible = false;
                    OcultarMenu();

                    numero2 = numero;
                    break;
                case 3.2:
                    InicializarSubMenu();
                    panelSubMenuOculto.Visible = true;
                    btnSubAccion3.Visible = false;
                    btnSubAccion2.Visible = false;
                    btnSubAccion1.Visible = false;
                    OcultarMenu();

                    numero2 = numero;
                    break;
                case 4.1:
                    InicializarSubMenu();
                    panelSubMenuOculto.Visible = true;
                    btnSubAccion3.Visible = false;
                    btnSubAccion2.Visible = false;
                    btnSubAccion1.Visible = false;
                    OcultarMenu();

                    numero2 = numero;
                    break;
                case 4.2:
                    InicializarSubMenu();
                    panelSubMenuOculto.Visible = true;
                    btnSubAccion3.Visible = false;
                    btnSubAccion2.Visible = false;
                    btnSubAccion1.Visible = false;
                    OcultarMenu();

                    numero2 = numero;
                    break;
                case 4.3:
                    InicializarSubMenu();
                    panelSubMenuOculto.Visible = true;
                    btnSubAccion3.Visible = false;
                    btnSubAccion2.Visible = false;
                    btnSubAccion1.Visible = false;
                    OcultarMenu();

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

        public void ActualizarFormulario(double numero, DataSet lista, bool estado)
        {
            switch (numero)
            {
                case 1.11:
                    ListarFuncionario.ActualizarFormulario(numero, lista, estado);
                    break;
                case 1.21:
                    ListarJefeFuncionario.ActualizarFormulario(numero, lista, estado);
                    break;
                case 2.11:
                    ListarPerfil.ActualizarFormulario(numero, lista, estado);
                    break;
                case 2.21:
                    ListarCargo.ActualizarFormulario(numero, lista, estado);
                    break;
                case 3:
                    ListarCompetencia.ActualizarFormulario(numero, lista, estado);
                    break;
                case 3.1:
                    ListarCompetencia.ActualizarFormulario(numero, lista, estado);
                    break;
                case 3.2:
                    ListarCompetencia.ActualizarFormulario(numero, lista, estado);
                    break;
                case 4:
                    ListarEvaluacion.ActualizarFormulario(numero, lista, estado);
                    break;
                case 4.1:
                    ListarEvaluacion.ActualizarFormulario(numero, lista, estado);
                    break;
                case 4.2:
                    ListarEvaluacion.ActualizarFormulario(numero, lista, estado);
                    break;
                case 4.3:
                    ListarEvaluacion.ActualizarFormulario(numero, lista, estado);
                    break;
                case 5:
                    ListadoReporte.ActualizarFormulario(numero, lista, estado);
                    break;
            }
        }

        private void RecargarFormulario_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            numeroCRUD = 0;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            IniciarProcemiento(0);
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            switch (this.numero)
            {

                case 1:
                    switch (this.numero2)
                    {
                        case 1.11:
                            recargarListados(this.numero2);
                            break;
                        case 1.21:
                            recargarListados(numero2);
                            break;
                    }
                    break;
                case 2:
                    switch (this.numero2)
                    {
                        case 1:
                            recargarListados(this.numero);
                            break;
                        case 2.11:
                            recargarListados(this.numero2);
                            break;
                        case 2.21:
                            recargarListados(this.numero2);
                            break;
                    }
                    break;
                case 3:
                    switch (this.numero2)
                    {
                        case 3.1:
                            recargarListados(this.numero2);
                            break;
                        case 3.2:
                            recargarListados(this.numero2);
                            break;
                    }
                    break;
                        case 4:
                    switch (this.numero2)
                    {
                        case 4.1:
                            recargarListados(this.numero2);
                            break;
                        case 4.2:
                            recargarListados(this.numero2);
                            break;
                        case 4.3:
                            recargarListados(this.numero2);
                            break;
                    }
                    break;
            }


        }


        public void DefinirFormulario(double numero, DataSet lista, bool estado)
        {
            switch (numero)
            {
                case 1.11:
                    ListarFuncionario = new ListadoPrincipal();
                    ListarFuncionario.DefinirFormulario(numero, lista, estado);
                    ListarFuncionario.PasarDatos(this);
                    break;
                case 1.21:
                    ListarJefeFuncionario = new ListadoPrincipal();
                    ListarJefeFuncionario.DefinirFormulario(numero, lista, estado);
                    ListarJefeFuncionario.PasarDatos(this);
                    break;
                case 2.11:
                    ListarPerfil = new ListadoPrincipal();
                    ListarPerfil.DefinirFormulario(numero, lista, estado);
                    ListarPerfil.PasarDatos(this);
                    break;
                case 2.21:
                    ListarCargo = new ListadoPrincipal();
                    ListarCargo.DefinirFormulario(numero, lista, estado);
                    ListarCargo.PasarDatos(this);
                    break;
                case 3:
                    ListarCompetencia = new ListadoPrincipal();
                    ListarCompetencia.DefinirFormulario(numero, lista, estado);
                    ListarCompetencia.PasarDatos(this);

                    break;
                case 4:
                    ListarEvaluacion = new ListadoPrincipal();
                    ListarEvaluacion.DefinirFormulario(numero, lista, estado);
                    ListarEvaluacion.PasarDatos(this);
                    break;
                case 5:
                    ListadoReporte = new ListadoReporte();
                    ListadoReporte.DefinirFormulario(1, lista, estado);
                    break;
            }
        }



        private void RecargarFormulario_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            RecargarFormulario iniciar = (RecargarFormulario)e.UserState;
            int porcentaje = e.ProgressPercentage;

            switch (numeroCRUD)
            {
                case 1.11:
                    switch (porcentaje)
                    {
                        case 1:
                            Cargando cargar = new Cargando();
                            cargar.CambiarMensaje(iniciar.mensaje);
                            AbrirFormulario(cargar);
                            break;
                        case 2:
                            try
                            {
                                DataSet lista = iniciar.listarFuncionario;
                                ActualizarFormulario(1.11, lista, true);
                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                ActualizarFormulario(1.11, lista, false);
                            }
                            break;

                        case 3:
                            AbrirFormulario(ListarFuncionario);
                            break;
                    }
                    break;
                case 1.111:
                    switch (porcentaje)
                    {
                        case 1:
                            try
                            {
                                DataSet lista = iniciar.listarFuncionario;
                                ActualizarFormulario(1.11, lista, true);
                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                ActualizarFormulario(1.11, lista, false);
                            }
                            break;
                        case 2:
                            try
                            {
                                DataSet lista = iniciar.listarPerfil;
                                ActualizarFormulario(2.11, lista, true);
                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                ActualizarFormulario(2.11, lista, false);
                            }
                            break;

                    }
                    break;
                case 1.21:
                    switch (porcentaje)
                    {
                        case 1:
                            Cargando cargar = new Cargando();
                            cargar.CambiarMensaje(iniciar.mensaje);
                            AbrirFormulario(cargar);
                            break;
                        case 2:
                            try
                            {
                                DataSet lista = iniciar.listarJefeFuncionario;
                                ActualizarFormulario(1.21, lista, true);
                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                ActualizarFormulario(1.21, lista, false);
                            }
                            break;
                        case 3:
                            AbrirFormulario(ListarJefeFuncionario);
                            break;
                    }
                    break;
                case 1.211:
                    switch (porcentaje)
                    {
                        case 1:
                            try
                            {
                                DataSet lista = iniciar.listarJefeFuncionario;
                                ActualizarFormulario(1.21, lista, true);
                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                ActualizarFormulario(1.21, lista, false);
                            }
                            break;


                    }
                    break;
                case 2.11:
                    switch (porcentaje)
                    {
                        case 1:
                            Cargando cargar = new Cargando();
                            cargar.CambiarMensaje(iniciar.mensaje);
                            AbrirFormulario(cargar);
                            break;
                        case 2:
                            try
                            {
                                DataSet lista = iniciar.listarPerfil;
                                ActualizarFormulario(2.11, lista, true);
                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                ActualizarFormulario(2.11, lista, false);
                            }
                            break;
                        case 3:
                            AbrirFormulario(ListarPerfil);
                            break;


                    }
                    break;
                case 2.111:
                    switch (porcentaje)
                    {
                        case 1:
                            try
                            {
                                DataSet lista = iniciar.listarPerfil;
                                ActualizarFormulario(2.11, lista, true);
                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                ActualizarFormulario(2.11, lista, false);
                            }
                            break;
                        case 2:
                            try
                            {
                                DataSet lista = iniciar.listarCompetencia;
                                ActualizarFormulario(3, lista, true);
                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                ActualizarFormulario(3, lista, false);
                            }
                            break;
                        case 3:
                            try
                            {
                                DataSet lista = iniciar.listarEvaluacion;
                                ActualizarFormulario(4, lista, true);
                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                ActualizarFormulario(4, lista, false);
                            }
                            break;
                        case 4:
                            try
                            {
                                DataSet lista = iniciar.listarReporte;
                                ActualizarFormulario(5, lista, true);
                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                ActualizarFormulario(5, lista, false);
                            }
                            break;
                    }

                    break;
                case 2.21:
                    switch (porcentaje)
                    {
                        case 1:
                            Cargando cargar = new Cargando();
                            cargar.CambiarMensaje(iniciar.mensaje);
                            AbrirFormulario(cargar);
                            break;
                        case 2:
                            try
                            {
                                DataSet lista = iniciar.listarCargo;
                                ActualizarFormulario(2.21, lista, true);
                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                ActualizarFormulario(2.21, lista, false);
                            }
                            break;
                        case 3:
                            AbrirFormulario(ListarCargo);
                            break;


                    }
                    break;

                case 2.211:
                    switch (porcentaje)
                    {

                        case 1:
                            try
                            {
                                DataSet lista = iniciar.listarCargo;
                                ActualizarFormulario(2.21, lista, true);
                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                ActualizarFormulario(2.21, lista, false);
                            }
                            break;


                    }
                    break;

                case 3.1:
                    switch (porcentaje)
                    {
                        case 1:
                            Cargando cargar = new Cargando();
                            cargar.CambiarMensaje(iniciar.mensaje);
                            AbrirFormulario(cargar);
                            break;
                        case 2:
                            try
                            {
                                DataSet lista = iniciar.listarCompetencia;
                                ActualizarFormulario(3.1, lista, true);
                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                ActualizarFormulario(3.1, lista, false);
                            }
                            break;
                        case 3:
                            try
                            {
                                DataSet lista = iniciar.listarPerfil;
                                ActualizarFormulario(3, lista, true);
                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                ActualizarFormulario(3, lista, false);
                            }
                            break;

                        case 4:
                            AbrirFormulario(ListarCompetencia);
                            break;


                    }
                    break;

                case 3.11:
                    switch (porcentaje)
                    {
                        case 1:
                            try
                            {
                                DataSet lista = iniciar.listarCompetencia;
                                ActualizarFormulario(3.1, lista, true);
                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                ActualizarFormulario(3.1, lista, false);
                            }
                            break;
                        case 2:
                            try
                            {
                                DataSet lista = iniciar.listarPerfil;
                                ActualizarFormulario(3, lista, true);
                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                ActualizarFormulario(3, lista, false);
                            }
                            break;
                        case 3:
                            try
                            {
                                DataSet lista = iniciar.listarEvaluacion;
                                ActualizarFormulario(4, lista, true);
                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                ActualizarFormulario(4, lista, false);
                            }
                            break;

                    }

                    break;
                case 3.2:
                    switch (porcentaje)
                    {
                        case 1:
                            Cargando cargar = new Cargando();
                            cargar.CambiarMensaje(iniciar.mensaje);
                            AbrirFormulario(cargar);
                            break;
                        case 2:
                            try
                            {
                                DataSet lista = iniciar.listarCompetencia;
                                ActualizarFormulario(3.1, lista, true);
                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                ActualizarFormulario(3.1, lista, false);
                            }
                            break;
                        case 3:
                            try
                            {
                                DataSet lista = iniciar.listarObservacion;
                                ActualizarFormulario(3.2, lista, true);
                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                ActualizarFormulario(3.2, lista, false);
                            }
                            break;
                        case 4:
                            AbrirFormulario(ListarCompetencia);
                            break;


                    }
                    break;

                case 3.21:
                    switch (porcentaje)
                    {
                        case 1:
                            try
                            {
                                DataSet lista = iniciar.listarObservacion;
                                ActualizarFormulario(3.2, lista, true);
                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                ActualizarFormulario(3.2, lista, false);
                            }
                            break;
                        case 2:
                            try
                            {
                                DataSet lista = iniciar.listarCompetencia;
                                ActualizarFormulario(3.1, lista, true);
                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                ActualizarFormulario(3.1, lista, false);
                            }
                            break;
                        case 3:
                            try
                            {
                                DataSet lista = iniciar.listarPerfil;
                                ActualizarFormulario(3, lista, true);
                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                ActualizarFormulario(3, lista, false);
                            }
                            break;
               
     

                    }



                    break;
                case 4.1:
                    switch (porcentaje)
                    {
                        case 1:
                            Cargando cargar = new Cargando();
                            cargar.CambiarMensaje(iniciar.mensaje);
                            AbrirFormulario(cargar);
                            break;
                        case 2:
                            try
                            {
                                DataSet lista = iniciar.listarPerfil;
                                ActualizarFormulario(4, lista, true);
                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                ActualizarFormulario(4, lista, false);
                            }
                            break;
                        case 3:
                            try
                            {
                                DataSet lista = iniciar.listarEvaluacion;
                                ActualizarFormulario(4.1, lista, true);
                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                ActualizarFormulario(4.1, lista, false);
                            }
                            break;
                        case 4:
                            AbrirFormulario(ListarEvaluacion);
                            break;


                    }
                    break;
                case 4.11:
                    switch (porcentaje)
                    {
                        case 1:
                            try
                            {
                                DataSet lista = iniciar.listarPerfil;
                                ActualizarFormulario(4, lista, true);
                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                ActualizarFormulario(4, lista, false);
                            }
                            break;
                        case 2:
                            try
                            {
                                DataSet lista = iniciar.listarEvaluacion;
                                ActualizarFormulario(4.1, lista, true);
                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                ActualizarFormulario(4.1, lista, false);
                            }
                            break;

                    }
                    break;
                case 4.2:
                    switch (porcentaje)
                    {
                        case 1:
                            Cargando cargar = new Cargando();
                            cargar.CambiarMensaje(iniciar.mensaje);
                            AbrirFormulario(cargar);
                            break;
                        case 2:
                            try
                            {
                                DataSet lista = iniciar.listarPerfil;
                                ActualizarFormulario(4, lista, true);
                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                ActualizarFormulario(4, lista, false);
                            }
                            break;
                        case 3:
                            try
                            {
                                DataSet lista = iniciar.listarEvaluacion;
                                ActualizarFormulario(4.1, lista, true);
                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                ActualizarFormulario(4.1, lista, false);
                            }
                            break;
                        case 4:
                            try
                            {
                                DataSet lista = iniciar.listarPregunta;
                                ActualizarFormulario(4.2, lista, true);
                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                ActualizarFormulario(4.2, lista, false);
                            }
                            break;
                        case 5:
                            AbrirFormulario(ListarEvaluacion);
                            break;


                    }
                    break;
                case 4.21:
                    switch (porcentaje)
                    {
                        case 1:
                            try
                            {
                                DataSet lista = iniciar.listarPerfil;
                                ActualizarFormulario(4, lista, true);
                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                ActualizarFormulario(4, lista, false);
                            }
                            break;
                        case 2:
                            try
                            {
                                DataSet lista = iniciar.listarEvaluacion;
                                ActualizarFormulario(4.1, lista, true);
                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                ActualizarFormulario(4.1, lista, false);
                            }
                            break;
                        case 3:
                            try
                            {
                                DataSet lista = iniciar.listarPregunta;
                                ActualizarFormulario(4.2, lista, true);
                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                ActualizarFormulario(4.2, lista, false);
                            }
                            break;

                    }
                    break;

                case 4.3:
                    switch (porcentaje)
                    {
                        case 1:
                            Cargando cargar = new Cargando();
                            cargar.CambiarMensaje(iniciar.mensaje);
                            AbrirFormulario(cargar);
                            break;
                        case 2:
                            try
                            {
                                DataSet lista = iniciar.listarAlternativa;
                                ActualizarFormulario(4.3, lista, true);
                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                ActualizarFormulario(4.3, lista, false);
                            }
      
                            break;
                        case 3:
                            try
                            {
                                DataSet lista = iniciar.listarEvaluacion;
                                ActualizarFormulario(4.1, lista, true);
                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                ActualizarFormulario(4.1, lista, false);
                            }
                            break;
                        case 4:
                            try
                            {
                                DataSet lista = iniciar.listarPregunta;
                                ActualizarFormulario(4.2, lista, true);
                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                ActualizarFormulario(4.2, lista, false);
                            }
                            break;
                        case 5:
                            try
                            {
                                DataSet lista = iniciar.listarPerfil;
                                ActualizarFormulario(4, lista, true);
                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                ActualizarFormulario(4, lista, false);
                            }
                            break;
                        case 6:
                            AbrirFormulario(ListarEvaluacion);
                            break;


                    }
                    break;
                case 4.31:
                    switch (porcentaje)
                    {
                        case 1:
                            try
                            {
                                DataSet lista = iniciar.listarAlternativa;
                                ActualizarFormulario(4.3, lista, true);
                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                ActualizarFormulario(4.3, lista, false);
                            }
                    
                            break;
                        case 2:
                            try
                            {
                                DataSet lista = iniciar.listarEvaluacion;
                                ActualizarFormulario(4.1, lista, true);
                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                ActualizarFormulario(4.1, lista, false);
                            }
                            break;
                        case 3:
                            try
                            {
                                DataSet lista = iniciar.listarPregunta;
                                ActualizarFormulario(4.2, lista, true);
                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                ActualizarFormulario(4.2, lista, false);
                            }
                            break;
                        case 4:
                            try
                            {
                                DataSet lista = iniciar.listarPerfil;
                                ActualizarFormulario(4, lista, true);
                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                ActualizarFormulario(4, lista, false);
                            }
                            break;

                    }
                    break;

            }

        }



        private void RecargarFormulario_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                BackgroundWorker IniciarAplicacion = sender as BackgroundWorker;
                RecargarFormulario inicio = (RecargarFormulario)e.Argument;
                daoFuncionario dao = new daoFuncionario();
                daoJefeFuncionario daoJF = new daoJefeFuncionario();
                daoPerfil daoPerfil = new daoPerfil();
                daoCuestionario daoCuestionario = new daoCuestionario();
                daoCompetencia daoCompetencia = new daoCompetencia();
                daoCargo daoCargo = new daoCargo();
                daoReporte daoReporte = new daoReporte();
                daoObservacion daoObservacion = new daoObservacion();
                daoPreguntas daoPreguntas = new daoPreguntas();
                daoAlternativa daoAlternativa = new daoAlternativa();

                switch (inicio.numero)
                {
                    case 1.11:
                        inicio.mensaje = "Actualizando Funcionario";
                        IniciarAplicacion.ReportProgress(1, inicio);
                        inicio.listarFuncionario = dao.listar();
                        IniciarAplicacion.ReportProgress(2, inicio);
                        IniciarAplicacion.ReportProgress(3);
                        break;
                    case 1.111:
                        inicio.listarFuncionario = dao.listar();
                        IniciarAplicacion.ReportProgress(1, inicio);
                        break;
                    case 1.21:
                        inicio.mensaje = "Actualizando jefe funcionario";
                        IniciarAplicacion.ReportProgress(1, inicio);
                        inicio.listarJefeFuncionario = daoJF.listar();
                        IniciarAplicacion.ReportProgress(2, inicio);
                        IniciarAplicacion.ReportProgress(3);
                        break;
                    case 1.211:

                        inicio.listarJefeFuncionario = daoJF.listar();
                        IniciarAplicacion.ReportProgress(1, inicio);
                        inicio.listarPerfil = dao.listar();
                        IniciarAplicacion.ReportProgress(2, inicio);
                        break;
                    case 2.11:
                        inicio.mensaje = "Actualizando Perfil";
                        IniciarAplicacion.ReportProgress(1, inicio);
                        inicio.listarPerfil = daoPerfil.listar();
                        IniciarAplicacion.ReportProgress(2, inicio);
                        IniciarAplicacion.ReportProgress(3);
                        break;
                    case 2.111:
                        inicio.listarPerfil = daoPerfil.listar();
                        IniciarAplicacion.ReportProgress(1, inicio);
                        inicio.listarCompetencia = daoCompetencia.ListarPerfil();
                        IniciarAplicacion.ReportProgress(2, inicio);
                        inicio.listarEvaluacion = daoCuestionario.ListarPerfil();
                        IniciarAplicacion.ReportProgress(3, inicio);
                        inicio.listarReporte = daoReporte.listarPerfil();
                        IniciarAplicacion.ReportProgress(4, inicio);
                        break;
                    case 2.21:
                        inicio.mensaje = "Actualizando Cargo";
                        IniciarAplicacion.ReportProgress(1, inicio);
                        inicio.listarCargo = daoCargo.listar();
                        IniciarAplicacion.ReportProgress(2, inicio);
                        IniciarAplicacion.ReportProgress(3);
                        break;
                    case 2.211:
                        inicio.listarCargo = daoCargo.listar();
                        IniciarAplicacion.ReportProgress(1, inicio);
                        break;
                    case 3.1:
                        inicio.mensaje = "Actualizando Competencia";
                        IniciarAplicacion.ReportProgress(1, inicio);
                        inicio.listarCompetencia = daoCompetencia.Listar(ListarCompetencia.Recuperarid(2));
                        IniciarAplicacion.ReportProgress(2, inicio);
                        inicio.listarPerfil = daoCompetencia.ListarPerfil();
                        IniciarAplicacion.ReportProgress(3, inicio);
                        IniciarAplicacion.ReportProgress(4);
                        break;
                    case 3.11:
                        inicio.listarCompetencia = daoCompetencia.Listar(ListarCompetencia.Recuperarid(2));
                        IniciarAplicacion.ReportProgress(1, inicio);
                        inicio.listarPerfil = daoCompetencia.ListarPerfil();
                        IniciarAplicacion.ReportProgress(2, inicio);
                        inicio.listarEvaluacion = daoCuestionario.ListarPerfil();
                        IniciarAplicacion.ReportProgress(3, inicio);
                        break;
                    case 3.2:
                        inicio.mensaje = "Actualizando Observaciones";
                        IniciarAplicacion.ReportProgress(1, inicio);
                        inicio.listarCompetencia = daoCompetencia.Listar(ListarCompetencia.Recuperarid(2));
                        IniciarAplicacion.ReportProgress(2, inicio);
                        inicio.listarObservacion = daoObservacion.Listar(ListarCompetencia.Recuperarid(3));
                        IniciarAplicacion.ReportProgress(3, inicio);
                        IniciarAplicacion.ReportProgress(4);
                        break;
                    case 3.21:
                        inicio.listarObservacion = daoObservacion.Listar(ListarCompetencia.Recuperarid(3));

                        IniciarAplicacion.ReportProgress(1, inicio);
                        inicio.listarCompetencia = daoCompetencia.Listar(ListarCompetencia.Recuperarid(2));
                        IniciarAplicacion.ReportProgress(2, inicio);
                        inicio.listarPerfil = daoCompetencia.ListarPerfil();
                        IniciarAplicacion.ReportProgress(3, inicio);
                        break;
                    case 4.1:
                        inicio.mensaje = "Actualizando Evaluaciones";
                        IniciarAplicacion.ReportProgress(1, inicio);
                        inicio.listarPerfil = daoCuestionario.ListarPerfil();
                        IniciarAplicacion.ReportProgress(2, inicio);
                        inicio.listarEvaluacion = daoCuestionario.Listar(ListarEvaluacion.Recuperarid(4));
                        IniciarAplicacion.ReportProgress(3, inicio);
                        IniciarAplicacion.ReportProgress(4);
                        break;
                    case 4.11:
                        inicio.listarPerfil = daoCuestionario.ListarPerfil();
                        IniciarAplicacion.ReportProgress(1, inicio);
                        inicio.listarEvaluacion = daoCuestionario.Listar(ListarEvaluacion.Recuperarid(4));
                        IniciarAplicacion.ReportProgress(2, inicio);

                        break;
                    case 4.2:
                        inicio.mensaje = "Actualizando Preguntas";
                        IniciarAplicacion.ReportProgress(1, inicio);
                        inicio.listarPerfil = daoCuestionario.ListarPerfil();
                        IniciarAplicacion.ReportProgress(2, inicio);
                        inicio.listarEvaluacion = daoCuestionario.Listar(ListarEvaluacion.Recuperarid(4));
                        IniciarAplicacion.ReportProgress(3, inicio);
                        inicio.listarPregunta = daoPreguntas.Listar(ListarEvaluacion.Recuperarid(5));
                        IniciarAplicacion.ReportProgress(4, inicio);
                        IniciarAplicacion.ReportProgress(5);
                        break;
                    case 4.21:
                        inicio.listarPerfil = daoCuestionario.ListarPerfil();
                        IniciarAplicacion.ReportProgress(1, inicio);
                        inicio.listarEvaluacion = daoCuestionario.Listar(ListarEvaluacion.Recuperarid(4));
                        IniciarAplicacion.ReportProgress(2, inicio);
                        inicio.listarPregunta = daoPreguntas.Listar(ListarEvaluacion.Recuperarid(5));
                        IniciarAplicacion.ReportProgress(3, inicio);
                        break;

                    case 4.3:
                        inicio.mensaje = "Actualizando Alternativas";
                        IniciarAplicacion.ReportProgress(1, inicio);

                        inicio.listarAlternativa = daoAlternativa.Listar(ListarEvaluacion.Recuperarid(6)); 
                        IniciarAplicacion.ReportProgress(2, inicio);
                        inicio.listarEvaluacion = daoCuestionario.Listar(ListarEvaluacion.Recuperarid(4));
                        IniciarAplicacion.ReportProgress(3, inicio);
                        inicio.listarPregunta = daoPreguntas.Listar(ListarEvaluacion.Recuperarid(5));
                        IniciarAplicacion.ReportProgress(4, inicio);
                        inicio.listarPerfil = daoCuestionario.ListarPerfil();
                        IniciarAplicacion.ReportProgress(5, inicio);
                        IniciarAplicacion.ReportProgress(6);
                        break;
                    case 4.31:
                        inicio.listarAlternativa = daoAlternativa.Listar(ListarEvaluacion.Recuperarid(6));
                        
                        IniciarAplicacion.ReportProgress(1, inicio);
                        inicio.listarEvaluacion = daoCuestionario.Listar(ListarEvaluacion.Recuperarid(4));
                        IniciarAplicacion.ReportProgress(2, inicio);
                        inicio.listarPregunta = daoPreguntas.Listar(ListarEvaluacion.Recuperarid(5));
                        IniciarAplicacion.ReportProgress(3, inicio);
                        inicio.listarPerfil = daoCuestionario.ListarPerfil();
                        IniciarAplicacion.ReportProgress(4, inicio);
                        break;


                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        public void recargarListados(double numero)
        {
            RecargarFormulario iniciar = new RecargarFormulario();
            switch (numero)
            {
                case 1.11:
                    numeroCRUD = numero;
                    iniciar.numero = numero;
                    RecargarFormulario.RunWorkerAsync(iniciar);
                    break;
                case 1.111:
                    numeroCRUD = numero;
                    iniciar.numero = numero;
                    RecargarFormulario.RunWorkerAsync(iniciar);
                    break;
                case 1.21:
                    numeroCRUD = numero;
                    iniciar.numero = numero;
                    RecargarFormulario.RunWorkerAsync(iniciar);
                    break;
                case 1.211:
                    numeroCRUD = numero;
                    iniciar.numero = numero;
                    RecargarFormulario.RunWorkerAsync(iniciar);
                    break;
                case 2.11:
                    numeroCRUD = numero;
                    iniciar.numero = numero;
                    RecargarFormulario.RunWorkerAsync(iniciar);
                    break;
                case 2.111:
                    numeroCRUD = numero;
                    iniciar.numero = numero;
                    RecargarFormulario.RunWorkerAsync(iniciar);
                    break;
                case 2.21:
                    numeroCRUD = numero;
                    iniciar.numero = numero;
                    RecargarFormulario.RunWorkerAsync(iniciar);
                    break;
                case 2.211:
                    numeroCRUD = numero;
                    iniciar.numero = numero;
                    RecargarFormulario.RunWorkerAsync(iniciar);
                    break;
                case 3.1:
                    numeroCRUD = numero;
                    iniciar.numero = numero;
                    RecargarFormulario.RunWorkerAsync(iniciar);
                    break;
                case 3.11:
                    numeroCRUD = numero;
                    iniciar.numero = numero;
                    RecargarFormulario.RunWorkerAsync(iniciar);
                    break;
                case 3.2:
                    numeroCRUD = numero;
                    iniciar.numero = numero;
                    RecargarFormulario.RunWorkerAsync(iniciar);
                    break;
                case 3.21:
                    numeroCRUD = numero;
                    iniciar.numero = numero;
                    RecargarFormulario.RunWorkerAsync(iniciar);
                    break;
                case 4.1:
                    numeroCRUD = numero;
                    iniciar.numero = numero;
                    RecargarFormulario.RunWorkerAsync(iniciar);
                    break;
                case 4.11:
                    numeroCRUD = numero;
                    iniciar.numero = numero;
                    RecargarFormulario.RunWorkerAsync(iniciar);
                    break;
                case 4.2:
                    numeroCRUD = numero;
                    iniciar.numero = numero;
                    RecargarFormulario.RunWorkerAsync(iniciar);
                    break;
                case 4.21:
                    numeroCRUD = numero;
                    iniciar.numero = numero;
                    RecargarFormulario.RunWorkerAsync(iniciar);
                    break;
                case 4.3:
                    numeroCRUD = numero;
                    iniciar.numero = numero;
                    RecargarFormulario.RunWorkerAsync(iniciar);
                    break;
                case 4.31:
                    numeroCRUD = numero;
                    iniciar.numero = numero;
                    RecargarFormulario.RunWorkerAsync(iniciar);
                    break;
            }
        }


        public void TerminarProceso(double numero)
        {
            switch (numero)
            {
                case 1.11:
                    modulofuncionario.Close();
                    PanelCRUD.Visible = false;
                    estadoCRUD = 0;
                    break;
                case 1.12:
                    moduloCargoFuncionario.Close();
                    PanelCRUD.Visible = false;
                    estadoCRUD = 0;
                    break;
                case 1.21:
                    moduloJefeFuncionario.Close();
                    PanelCRUD.Visible = false;
                    estadoCRUD = 0;
                    break;
                case 1.3:
                    moduloCargoFuncionario.Close();
                    PanelCRUD.Visible = false;
                    estadoCRUD = 0;
                    break;
                case 2.11:
                    moduloPerfil.Close();
                    PanelCRUD.Visible = false;
                    estadoCRUD = 0;
                    break;
                case 2.21:
                    moduloCargo.Close();
                    PanelCRUD.Visible = false;
                    estadoCRUD = 0;
                    break;
                case 3.1:
                    moduloCompetencia.Close();
                    PanelCRUD.Visible = false;
                    estadoCRUD = 0;
                    break;
                case 3.2:
                    moduloObervacion.Close();
                    PanelCRUD.Visible = false;
                    estadoCRUD = 0;
                    break;
                case 4.1:
                    moduloEvaluacion.Close();
                    PanelCRUD.Visible = false;
                    estadoCRUD = 0;
                    break;
                case 4.2:
                    moduloPreguntas.Close();
                    PanelCRUD.Visible = false;
                    estadoCRUD = 0;
                    break;
                case 4.3:
                    moduloAlternativas.Close();
                    PanelCRUD.Visible = false;
                    estadoCRUD = 0;
                    break;


            }
        }

        public int RecuperaridDataGrid(int numero)
        {
            switch (numero)
            {
                default:
                    return 0;
                case 1:
                    return ListarFuncionario.Recuperarid(numero);

                case 2:
                    return ListarCompetencia.Recuperarid(numero);
                case 3:
                    return ListarCompetencia.Recuperarid(numero);
                case 4:
                    return ListarEvaluacion.Recuperarid(numero);
                case 5:
                    return ListarEvaluacion.Recuperarid(numero);
                case 6:
                    return ListarEvaluacion.Recuperarid(numero);
                case 7:
                    return ListarJefeFuncionario.Recuperarid(1);


            }
        }



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
                            moduloFuncionario.IniciarFormulario(1);
                            moduloFuncionario.PasarDatos(this);
                            AbrirModulo(moduloFuncionario);
                            PanelCRUD.Visible = true;
                            estadoCRUD = 1;
                            this.modulofuncionario = moduloFuncionario;
                        }
                        else
                        {
                            SystemSounds.Hand.Play();
                        }

                    }
                    if (btn.Name == btnModificar.Name)
                    {
                        if (estadoCRUD == 0)
                        {
                            if (ListarFuncionario.listaFuncionario.dt_Listar.SelectedRows.Count > 0)
                            {
                                string rut = ListarFuncionario.listaFuncionario.dt_Listar.CurrentRow.Cells[0].Value.ToString();
                                string run = rut.Replace(".", "").Replace("-", "").Trim().Substring(0, rut.Replace(".", "").Replace("-", "").Trim().Length - 1);

                                daoFuncionario dao = new daoFuncionario();
                                Modulo.Funcionario moduloFuncionario = new Modulo.Funcionario();
                                moduloFuncionario.PasarDatos(dao.RecuperarDatos(int.Parse(run)));
                                moduloFuncionario.PasarDatos(this);
                                moduloFuncionario.IniciarFormulario(2);
                                AbrirModulo(moduloFuncionario);
                                PanelCRUD.Visible = true;
                                estadoCRUD = 1;
                                this.modulofuncionario = moduloFuncionario;

                            }
                            else
                            {
                                Ventanas.Mensaje mensaje = new Ventanas.Mensaje();
                                mensaje.cambiarMensaje("Debe seleccionar una fila");
                                mensaje.ShowDialog();
                            }
                        }
                    }
                    if (btn.Name == btnEliminar.Name)
                    {
                        if (estadoCRUD == 0)
                        {
                            if (ListarFuncionario.listaFuncionario.dt_Listar.SelectedRows.Count > 0)
                            {
                                string rut = ListarFuncionario.listaFuncionario.dt_Listar.CurrentRow.Cells[0].Value.ToString();
                                string run = rut.Replace(".", "").Replace("-", "").Trim().Substring(0, rut.Replace(".", "").Replace("-", "").Trim().Length - 1);
                                Cl_Funcionario funcionario = new Cl_Funcionario();
                                funcionario.run = int.Parse(run);
                                daoFuncionario dao = new daoFuncionario();

                                if (dao.Eliminar(funcionario))
                                {
                                    Ventanas.Mensaje mensaje = new Ventanas.Mensaje();
                                    mensaje.cambiarMensaje("Elimino Correctamente");
                                    recargarListados(1.11);
                                    mensaje.ShowDialog();
                                }
                                else
                                {
                                    Ventanas.Mensaje mensaje = new Ventanas.Mensaje();
                                    mensaje.cambiarMensaje("No elimino Correctamente");
                                    mensaje.ShowDialog();
                                }


                            }
                            else
                            {
                                Ventanas.Mensaje mensaje = new Ventanas.Mensaje();
                                mensaje.cambiarMensaje("Debe seleccionar una fila");
                                mensaje.ShowDialog();
                            }
                        }
                    }
                    if (btn.Name == btnSubAccion1.Name)
                    {
                        if (estadoCRUD == 0)
                        {
                            if (ListarFuncionario.listaFuncionario.dt_Listar.SelectedRows.Count > 0)
                            {
                                string rut = ListarFuncionario.listaFuncionario.dt_Listar.CurrentRow.Cells[0].Value.ToString();
                                string run = rut.Replace(".", "").Replace("-", "").Trim().Substring(0, rut.Replace(".", "").Replace("-", "").Trim().Length - 1);

                                Modulo.Modulos_Adicionales.CargoFuncionario modulocargoFuncionario = new Modulo.Modulos_Adicionales.CargoFuncionario();
                                modulocargoFuncionario.pasarDatos(this);
                                modulocargoFuncionario.pasarDatos(int.Parse(run));
                                AbrirModulo(modulocargoFuncionario);
                                PanelCRUD.Visible = true;
                                estadoCRUD = 1;
                                this.moduloCargoFuncionario = modulocargoFuncionario;

                            }
                            else
                            {
                                Ventanas.Mensaje mensaje = new Ventanas.Mensaje();
                                mensaje.cambiarMensaje("Debe seleccionar una fila");
                                mensaje.ShowDialog();
                            }
                        }
                    }
                    break;
                case 1.21:
                    if (btn.Name == btnAgregar.Name)
                    {
                        if (estadoCRUD == 0)
                        {
                            Modulo.JefeFuncionario moduloJefeFuncionario = new Modulo.JefeFuncionario();
                            moduloJefeFuncionario.IniciarFormulario(1);
                            moduloJefeFuncionario.PasarDatos(this);
                            AbrirModulo(moduloJefeFuncionario);
                            PanelCRUD.Visible = true;
                            estadoCRUD = 1;
                            this.moduloJefeFuncionario = moduloJefeFuncionario;
                        }
                        else
                        {
                            SystemSounds.Hand.Play();
                        }
                    }

                    if (btn.Name == btnModificar.Name)
                    {
                        if (estadoCRUD == 0)
                        {
                            if (ListarJefeFuncionario.listaJefeFuncionario.dt_Listar.SelectedRows.Count > 0)
                            {
                                string rut = ListarJefeFuncionario.listaJefeFuncionario.dt_Listar.CurrentRow.Cells[0].Value.ToString();
                                string run = rut.Replace(".", "").Replace("-", "").Trim().Substring(0, rut.Replace(".", "").Replace("-", "").Trim().Length - 1);

                                daoJefeFuncionario dao = new daoJefeFuncionario();
                                Modulo.JefeFuncionario moduloFuncionario = new Modulo.JefeFuncionario();
                                moduloFuncionario.PasarDatos(dao.RecuperarDatos(int.Parse(run)));
                                moduloFuncionario.PasarDatos(this);
                                moduloFuncionario.IniciarFormulario(2);
                                AbrirModulo(moduloFuncionario);
                                PanelCRUD.Visible = true;
                                estadoCRUD = 1;
                                this.moduloJefeFuncionario = moduloFuncionario;

                            }
                            else
                            {
                                Ventanas.Mensaje mensaje = new Ventanas.Mensaje();
                                mensaje.cambiarMensaje("Debe seleccionar una fila");
                                mensaje.ShowDialog();
                            }
                        }
                    }


                    if (btn.Name == btnEliminar.Name)
                    {
                        if (estadoCRUD == 0)
                        {
                            if (ListarJefeFuncionario.listaJefeFuncionario.dt_Listar.SelectedRows.Count > 0)
                            {
                                string rut = ListarJefeFuncionario.listaJefeFuncionario.dt_Listar.CurrentRow.Cells[0].Value.ToString();
                                string run = rut.Replace(".", "").Replace("-", "").Trim().Substring(0, rut.Replace(".", "").Replace("-", "").Trim().Length - 1);
                                Cl_Jefe_Funcionario funcionario = new Cl_Jefe_Funcionario();
                                funcionario.run = int.Parse(run);
                                daoJefeFuncionario dao = new daoJefeFuncionario();

                                if (dao.Eliminar(funcionario))
                                {
                                    Ventanas.Mensaje mensaje = new Ventanas.Mensaje();
                                    mensaje.cambiarMensaje("Elimino Correctamente");
                                    recargarListados(1.21);
                                    mensaje.ShowDialog();
                                }
                                else
                                {
                                    Ventanas.Mensaje mensaje = new Ventanas.Mensaje();
                                    mensaje.cambiarMensaje("No elimino Correctamente");
                                    mensaje.ShowDialog();
                                }


                            }
                            else
                            {
                                Ventanas.Mensaje mensaje = new Ventanas.Mensaje();
                                mensaje.cambiarMensaje("Debe seleccionar una fila");
                                mensaje.ShowDialog();
                            }
                        }
                    }
                    if (btn.Name == btnSubAccion1.Name)
                    {
                        if (estadoCRUD == 0)
                        {
                            if (ListarJefeFuncionario.listaJefeFuncionario.dt_Listar.SelectedRows.Count > 0)
                            {
                                string rut = ListarJefeFuncionario.listaJefeFuncionario.dt_Listar.CurrentRow.Cells[0].Value.ToString();
                                string run = rut.Replace(".", "").Replace("-", "").Trim().Substring(0, rut.Replace(".", "").Replace("-", "").Trim().Length - 1);

                                Modulo.Modulos_Adicionales.CargoFuncionario modulocargoFuncionario = new Modulo.Modulos_Adicionales.CargoFuncionario();
                                modulocargoFuncionario.pasarDatos(this);
                                modulocargoFuncionario.pasarDatos(int.Parse(run));
                                AbrirModulo(modulocargoFuncionario);
                                PanelCRUD.Visible = true;
                                estadoCRUD = 1;
                                this.moduloCargoFuncionario = modulocargoFuncionario;

                            }
                            else
                            {
                                Ventanas.Mensaje mensaje = new Ventanas.Mensaje();
                                mensaje.cambiarMensaje("Debe seleccionar una fila");
                                mensaje.ShowDialog();
                            }
                        }
                    }

                    break;
                case 2.11:
                    if (btn.Name == btnAgregar.Name)
                    {
                        if (estadoCRUD == 0)
                        {
                            Modulo.Perfil moduloPerfil = new Modulo.Perfil();
                            moduloPerfil.IniciarFormulario(1);
                            moduloPerfil.PasarDatos(this);
                            AbrirModulo(moduloPerfil);
                            PanelCRUD.Visible = true;
                            estadoCRUD = 1;
                            this.moduloPerfil = moduloPerfil;
                        }
                        else
                        {
                            SystemSounds.Hand.Play();
                        }
                    }
                    if (btn.Name == btnModificar.Name)
                    {
                        if (estadoCRUD == 0)
                        {
                            if (ListarPerfil.listaPerfil.dt_Listar.SelectedRows.Count > 0)
                            {
                                string id = ListarPerfil.listaPerfil.dt_Listar.CurrentRow.Cells[1].Value.ToString();
                                daoPerfil dao = new daoPerfil();
                                Modulo.Perfil moduloPerfil = new Modulo.Perfil();
                                moduloPerfil.PasarDatos(dao.RecuperarDatos(int.Parse(id)));
                                moduloPerfil.PasarDatos(this);
                                moduloPerfil.IniciarFormulario(2);
                                AbrirModulo(moduloPerfil);
                                PanelCRUD.Visible = true;
                                estadoCRUD = 1;
                                this.moduloPerfil = moduloPerfil;

                            }
                            else
                            {
                                Ventanas.Mensaje mensaje = new Ventanas.Mensaje();
                                mensaje.cambiarMensaje("Debe seleccionar una fila");
                                mensaje.ShowDialog();
                            }
                        }
                    }

                    if (btn.Name == btnEliminar.Name)
                    {
                        if (estadoCRUD == 0)
                        {
                            if (ListarPerfil.listaPerfil.dt_Listar.SelectedRows.Count > 0)
                            {
                                int id = int.Parse(ListarPerfil.listaPerfil.dt_Listar.CurrentRow.Cells[1].Value.ToString());
                                Cl_Perfil perfil = new Cl_Perfil();
                                perfil.id = id;
                                daoPerfil dao = new daoPerfil();

                                if (dao.Eliminar(perfil))
                                {
                                    Ventanas.Mensaje mensaje = new Ventanas.Mensaje();
                                    mensaje.cambiarMensaje("Elimino Correctamente");
                                    recargarListados(2.11);
                                    mensaje.ShowDialog();
                                }
                                else
                                {
                                    Ventanas.Mensaje mensaje = new Ventanas.Mensaje();
                                    mensaje.cambiarMensaje("No elimino Correctamente");
                                    mensaje.ShowDialog();
                                }


                            }
                            else
                            {
                                Ventanas.Mensaje mensaje = new Ventanas.Mensaje();
                                mensaje.cambiarMensaje("Debe seleccionar una fila");
                                mensaje.ShowDialog();
                            }
                        }
                    }

                    if (btn.Name == btnSubAccion1.Name)
                    {
                        int id = int.Parse(ListarPerfil.listaPerfil.dt_Listar.CurrentRow.Cells[1].Value.ToString());
                        Cl_Perfil perfil = new Cl_Perfil();
                        perfil.id = id;
                        daoPerfil dao = new daoPerfil();

                        if (dao.CambiarEstadoObsoleto(perfil))
                        {
                            Ventanas.Mensaje mensaje = new Ventanas.Mensaje();
                            mensaje.cambiarMensaje("Se cambio el estado Correctamente");
                            recargarListados(2.11);
                            mensaje.ShowDialog();
                        }
                        else
                        {
                            Ventanas.Mensaje mensaje = new Ventanas.Mensaje();
                            mensaje.cambiarMensaje("No cambio el estado Correctamente");
                            mensaje.ShowDialog();
                        }


                    }
                    else
                    {
                        Ventanas.Mensaje mensaje = new Ventanas.Mensaje();
                        mensaje.cambiarMensaje("Debe seleccionar una fila");
                        mensaje.ShowDialog();
                    }
                    break;
                case 2.21:
                    if (btn.Name == btnAgregar.Name)
                    {
                        if (estadoCRUD == 0)
                        {
                            Modulo.Cargo moduloCargo = new Modulo.Cargo();
                            moduloCargo.IniciarFormulario(1);
                            moduloCargo.PasarDatos(this);
                            AbrirModulo(moduloCargo);
                            PanelCRUD.Visible = true;
                            estadoCRUD = 1;
                            this.moduloCargo = moduloCargo;
                        }
                        else
                        {
                            SystemSounds.Hand.Play();
                        }
                    }
                    if (btn.Name == btnModificar.Name)
                    {
                        if (estadoCRUD == 0)
                        {
                            if (ListarCargo.listaCargo.dt_Listar.SelectedRows.Count > 0)
                            {
                                string id = ListarCargo.listaCargo.dt_Listar.CurrentRow.Cells[0].Value.ToString();
                                daoCargo dao = new daoCargo();
                                Modulo.Cargo moduloCargo = new Modulo.Cargo();
                                moduloCargo.PasarDatos(dao.RecuperarDatos(int.Parse(id)));
                                moduloCargo.PasarDatos(this);
                                moduloCargo.IniciarFormulario(2);
                                AbrirModulo(moduloCargo);
                                PanelCRUD.Visible = true;
                                estadoCRUD = 1;
                                this.moduloCargo = moduloCargo;

                            }
                            else
                            {
                                Ventanas.Mensaje mensaje = new Ventanas.Mensaje();
                                mensaje.cambiarMensaje("Debe seleccionar una fila");
                                mensaje.ShowDialog();
                            }
                        }
                    }
                    if(btn.Name == btnEliminar.Name)
                    {
                        if (ListarCargo.listaCargo.dt_Listar.SelectedRows.Count > 0)
                        {
                            int id = int.Parse(ListarCargo.listaCargo.dt_Listar.CurrentRow.Cells[0].Value.ToString());
                            Cl_Cargo cargo = new Cl_Cargo();
                            cargo.id = id;
                            daoCargo dao = new daoCargo();

                            if (dao.Eliminar(cargo))
                            {
                                Ventanas.Mensaje mensaje = new Ventanas.Mensaje();
                                mensaje.cambiarMensaje("Elimino Correctamente");
                                recargarListados(2.21);
                                mensaje.ShowDialog();
                            }
                            else
                            {
                                Ventanas.Mensaje mensaje = new Ventanas.Mensaje();
                                mensaje.cambiarMensaje("No elimino Correctamente");
                                mensaje.ShowDialog();
                            }


                        }
                        else
                        {
                            Ventanas.Mensaje mensaje = new Ventanas.Mensaje();
                            mensaje.cambiarMensaje("Debe seleccionar una fila");
                            mensaje.ShowDialog();
                        }
                    }

                    break;
                case 3.1:
                    if (btn.Name == btnAgregar.Name)
                    {
                        if (estadoCRUD == 0)
                        {
                            Modulo.Competencia moduloCompetencia = new Modulo.Competencia();
                            moduloCompetencia.IniciarFormulario(1);
                            moduloCompetencia.PasarDatos(this);
                            AbrirModulo(moduloCompetencia);
                            PanelCRUD.Visible = true;
                            estadoCRUD = 1;
                            this.moduloCompetencia = moduloCompetencia;
                        }
                        else
                        {
                            SystemSounds.Hand.Play();
                        }

                    }
                    if (btn.Name == btnModificar.Name)
                    {
                        if (estadoCRUD == 0)
                        {
                            if (ListarCompetencia.listaCompetencia.dt_Listar.SelectedRows.Count > 0)
                            {
                                string idCompetencia = ListarCompetencia.listaCompetencia.dt_Listar.CurrentRow.Cells[0].Value.ToString();
                                daoCompetencia dao = new daoCompetencia();
                                Modulo.Competencia moduloCompetencia = new Modulo.Competencia();
                                moduloCompetencia.PasarDatos(dao.RecuperarDatos(int.Parse(idCompetencia)));
                                moduloCompetencia.PasarDatos(this);
                                moduloCompetencia.IniciarFormulario(2);
                                AbrirModulo(moduloCompetencia);
                                PanelCRUD.Visible = true;
                                estadoCRUD = 1;
                                this.moduloCompetencia = moduloCompetencia;

                            }
                            else
                            {
                                Ventanas.Mensaje mensaje = new Ventanas.Mensaje();
                                mensaje.cambiarMensaje("Debe seleccionar una fila");
                                mensaje.ShowDialog();
                            }
                        }
                    }
                    if (btn.Name == btnEliminar.Name)
                    {
                        if (estadoCRUD == 0)
                        {
                            if (ListarCompetencia.listaCompetencia.dt_Listar.SelectedRows.Count > 0)
                            {

                                int id = int.Parse(ListarCompetencia.listaCompetencia.dt_Listar.CurrentRow.Cells[0].Value.ToString());
                                Cl_Competencia competencia = new Cl_Competencia();
                                competencia.id = id;
                                daoCompetencia dao = new daoCompetencia();

                                if (dao.Eliminar(competencia))
                                {
                                    Ventanas.Mensaje mensaje = new Ventanas.Mensaje();
                                    mensaje.cambiarMensaje("Elimino Correctamente");
                                    recargarListados(3.1);
                                    mensaje.ShowDialog();
                                }
                                else
                                {
                                    Ventanas.Mensaje mensaje = new Ventanas.Mensaje();
                                    mensaje.cambiarMensaje("No elimino Correctamente");
                                    mensaje.ShowDialog();
                                }


                            }
                            else
                            {
                                Ventanas.Mensaje mensaje = new Ventanas.Mensaje();
                                mensaje.cambiarMensaje("Debe seleccionar una fila");
                                mensaje.ShowDialog();
                            }
                        }
                    }
                        break;

                case 3.2:
                    if (btn.Name == btnAgregar.Name)
                    {
                        if (btn.Name == btnAgregar.Name)
                        {
                            if (estadoCRUD == 0)
                            {
                                Modulo.Observacion moduloObservacion = new Modulo.Observacion();
                                moduloObservacion.IniciarFormulario(1);
                                moduloObservacion.PasarDatos(this);
                                AbrirModulo(moduloObservacion);
                                PanelCRUD.Visible = true;
                                estadoCRUD = 1;
                                this.moduloObervacion = moduloObservacion;
                            }
                            else
                            {
                                SystemSounds.Hand.Play();
                            }

                        }
                    }
                    if (btn.Name == btnModificar.Name)
                    {
                        if (estadoCRUD == 0)
                        {
                            if (ListarCompetencia.listaCompetencia_Observacion.dt_Listar.SelectedRows.Count > 0)
                            {
                                string idObservacion = ListarCompetencia.listaCompetencia_Observacion.dt_Listar.CurrentRow.Cells[0].Value.ToString();
                                daoObservacion dao = new daoObservacion();
                                Modulo.Observacion moduloObservacion = new Modulo.Observacion();
                                moduloObservacion.PasarDatos(dao.RecuperarDatos(int.Parse(idObservacion)));
                                moduloObservacion.PasarDatos(this);
                                moduloObservacion.IniciarFormulario(2);
                                AbrirModulo(moduloObservacion);
                                PanelCRUD.Visible = true;
                                estadoCRUD = 1;
                                this.moduloObervacion = moduloObservacion;
                            }
                            else
                            {
                                Ventanas.Mensaje mensaje = new Ventanas.Mensaje();
                                mensaje.cambiarMensaje("Debe seleccionar una fila");
                                mensaje.ShowDialog();
                            }
                        }
                    }
                    if (btn.Name == btnEliminar.Name)
                    {
                        if (estadoCRUD == 0)
                        {
                            if (ListarCompetencia.listaCompetencia_Observacion.dt_Listar.SelectedRows.Count > 0)
                            {

                                int id = int.Parse(ListarCompetencia.listaCompetencia_Observacion.dt_Listar.CurrentRow.Cells[0].Value.ToString());
                                Cl_Observacion observacion = new Cl_Observacion();
                                observacion.id = id;
                                daoObservacion dao = new daoObservacion();

                                if (dao.Eliminar(observacion))
                                {
                                    Ventanas.Mensaje mensaje = new Ventanas.Mensaje();
                                    mensaje.cambiarMensaje("Elimino Correctamente");
                                    recargarListados(3.1);
                                    mensaje.ShowDialog();
                                }
                                else
                                {
                                    Ventanas.Mensaje mensaje = new Ventanas.Mensaje();
                                    mensaje.cambiarMensaje("No elimino Correctamente");
                                    mensaje.ShowDialog();
                                }
                            }
                            else
                            {
                                Ventanas.Mensaje mensaje = new Ventanas.Mensaje();
                                mensaje.cambiarMensaje("Debe seleccionar una fila");
                                mensaje.ShowDialog();
                            }
                        }
                    }
                    break;
                case 4.1:
                    if (btn.Name == btnAgregar.Name)
                    {
                        if (btn.Name == btnAgregar.Name)
                        {
                            if (estadoCRUD == 0)
                            {
                                Modulo.Evaluacion moduloEvaluacion = new Modulo.Evaluacion();
                                moduloEvaluacion.IniciarFormulario(1);
                                moduloEvaluacion.PasarDatos(this);
                                AbrirModulo(moduloEvaluacion);
                                PanelCRUD.Visible = true;
                                estadoCRUD = 1;
                                this.moduloEvaluacion = moduloEvaluacion;
                            }
                            else
                            {
                                SystemSounds.Hand.Play();
                            }
                        }

                    }

                    if (btn.Name == btnModificar.Name)
                    {
                        if (estadoCRUD == 0)
                        {
                            if (ListarEvaluacion.listarEvaluacion.dt_Listar.SelectedRows.Count > 0)
                            {
                                string id = ListarEvaluacion.listarEvaluacion.dt_Listar.CurrentRow.Cells[0].Value.ToString();

                                daoCuestionario dao = new daoCuestionario();
                                Modulo.Evaluacion moduloEvaluacion = new Modulo.Evaluacion();
                                moduloEvaluacion.PasarDatos(dao.RecuperarDatos(int.Parse(id)));
                                moduloEvaluacion.PasarDatos(this);
                                moduloEvaluacion.IniciarFormulario(2);
                                AbrirModulo(moduloEvaluacion);
                                PanelCRUD.Visible = true;
                                estadoCRUD = 1;
                                this.moduloEvaluacion = moduloEvaluacion;

                            }
                            else
                            {
                                Ventanas.Mensaje mensaje = new Ventanas.Mensaje();
                                mensaje.cambiarMensaje("Debe seleccionar una fila");
                                mensaje.ShowDialog();
                            }
                        }
                    }


                    if (btn.Name == btnEliminar.Name)
                    {
                        if (estadoCRUD == 0)
                        {
                            if (ListarEvaluacion.listarEvaluacion.dt_Listar.SelectedRows.Count > 0)
                            {
                                string id = ListarEvaluacion.listarEvaluacion.dt_Listar.CurrentRow.Cells[0].Value.ToString();
                                Cl_Cuestionario cuestionario = new Cl_Cuestionario();
                                cuestionario.id = int.Parse(id);
                                daoCuestionario dao = new daoCuestionario();

                                if (dao.Eliminar(cuestionario))
                                {
                                    Ventanas.Mensaje mensaje = new Ventanas.Mensaje();
                                    mensaje.cambiarMensaje("Elimino Correctamente");
                                    recargarListados(4.1);
                                    mensaje.ShowDialog();
                                }
                                else
                                {
                                    Ventanas.Mensaje mensaje = new Ventanas.Mensaje();
                                    mensaje.cambiarMensaje("No elimino Correctamente");
                                    mensaje.ShowDialog();
                                }


                            }
                            else
                            {
                                Ventanas.Mensaje mensaje = new Ventanas.Mensaje();
                                mensaje.cambiarMensaje("Debe seleccionar una fila");
                                mensaje.ShowDialog();
                            }
                        }

                    }

                    break;
                case 4.2:
                    if (btn.Name == btnAgregar.Name)
                    {
                        if (btn.Name == btnAgregar.Name)
                        {
                            if (btn.Name == btnAgregar.Name)
                            {
                                if (estadoCRUD == 0)
                                {
                                    Modulo.Preguntas moduloPregunta = new Modulo.Preguntas();
                                    moduloPregunta.IniciarFormulario(1);
                                    moduloPregunta.PasarDatos(this);
                                    AbrirModulo(moduloPregunta);
                                    PanelCRUD.Visible = true;
                                    estadoCRUD = 1;
                                    this.moduloPreguntas = moduloPregunta;
                                }
                                else
                                {
                                    SystemSounds.Hand.Play();
                                }
                            }

                        }
                    }
                    if (btn.Name == btnModificar.Name)
                    {
                        if (estadoCRUD == 0)
                        {
                            if (ListarEvaluacion.listaEvaluacion_Pregunta.dt_Listar.SelectedRows.Count > 0)
                            {
                                string id = ListarEvaluacion.listaEvaluacion_Pregunta.dt_Listar.CurrentRow.Cells[0].Value.ToString();

                                daoPreguntas dao = new daoPreguntas();
                                Modulo.Preguntas moduloPregunta = new Modulo.Preguntas();
                                moduloPregunta.PasarDatos(dao.RecuperarDatos(int.Parse(id)));
                                moduloPregunta.PasarDatos(this);
                                moduloPregunta.IniciarFormulario(2);
                                AbrirModulo(moduloPregunta);
                                PanelCRUD.Visible = true;
                                estadoCRUD = 1;
                                this.moduloPreguntas = moduloPregunta;

                            }
                            else
                            {
                                Ventanas.Mensaje mensaje = new Ventanas.Mensaje();
                                mensaje.cambiarMensaje("Debe seleccionar una fila");
                                mensaje.ShowDialog();
                            }
                        }
                    }
                    if (btn.Name == btnEliminar.Name)
                    {
                        if (estadoCRUD == 0)
                        {
                            if (ListarEvaluacion.listaEvaluacion_Pregunta.dt_Listar.SelectedRows.Count > 0)
                            {
                                string id = ListarEvaluacion.listaEvaluacion_Pregunta.dt_Listar.CurrentRow.Cells[0].Value.ToString();
                                Cl_Preguntas pregunta = new Cl_Preguntas();
                                pregunta.id = int.Parse(id);
                                daoPreguntas dao = new daoPreguntas();

                                if (dao.Eliminar(pregunta))
                                {
                                    Ventanas.Mensaje mensaje = new Ventanas.Mensaje();
                                    mensaje.cambiarMensaje("Elimino Correctamente");
                                    recargarListados(4.2);
                                    mensaje.ShowDialog();
                                }
                                else
                                {
                                    Ventanas.Mensaje mensaje = new Ventanas.Mensaje();
                                    mensaje.cambiarMensaje("No elimino Correctamente");
                                    mensaje.ShowDialog();
                                }


                            }
                            else
                            {
                                Ventanas.Mensaje mensaje = new Ventanas.Mensaje();
                                mensaje.cambiarMensaje("Debe seleccionar una fila");
                                mensaje.ShowDialog();
                            }
                        }

                    }
                    break;
                case 4.3:
                    if (btn.Name == btnAgregar.Name)
                    {
                        if (btn.Name == btnAgregar.Name)
                        {
                            if (estadoCRUD == 0)
                            {
                                Modulo.Alternativas moduloAlternativas = new Modulo.Alternativas();
                                moduloAlternativas.IniciarFormulario(1);
                                moduloAlternativas.PasarDatos(this);
                                AbrirModulo(moduloAlternativas);
                                PanelCRUD.Visible = true;
                                estadoCRUD = 1;
                                this.moduloAlternativas = moduloAlternativas;
                            }
                            else
                            {
                                SystemSounds.Hand.Play();
                            }
                        }

                    }
                    if (btn.Name == btnModificar.Name)
                    {
                        if (estadoCRUD == 0)
                        {
                            if (ListarEvaluacion.listaEvaluacion_Alternativa.dt_Listar.SelectedRows.Count > 0)
                            {
                                string id = ListarEvaluacion.listaEvaluacion_Alternativa.dt_Listar.CurrentRow.Cells[0].Value.ToString();

                                daoAlternativa dao = new daoAlternativa();
                                Modulo.Alternativas moduloAlternativa = new Modulo.Alternativas();
                                moduloAlternativa.PasarDatos(dao.RecuperarDatos(int.Parse(id)));
                                moduloAlternativa.PasarDatos(this);
                                moduloAlternativa.IniciarFormulario(2);
                                AbrirModulo(moduloAlternativa);
                                PanelCRUD.Visible = true;
                                estadoCRUD = 1;
                                this.moduloAlternativas = moduloAlternativa;

                            }
                            else
                            {
                                Ventanas.Mensaje mensaje = new Ventanas.Mensaje();
                                mensaje.cambiarMensaje("Debe seleccionar una fila");
                                mensaje.ShowDialog();
                            }
                        }
                    }
                    if (btn.Name == btnEliminar.Name)
                    {
                        if (estadoCRUD == 0)
                        {
                            if (ListarEvaluacion.listaEvaluacion_Alternativa.dt_Listar.SelectedRows.Count > 0)
                            {
                                string id = ListarEvaluacion.listaEvaluacion_Alternativa.dt_Listar.CurrentRow.Cells[0].Value.ToString();
                                Cl_Alternativa alt = new Cl_Alternativa();
                                alt.id = int.Parse(id);
                                daoAlternativa dao = new daoAlternativa();

                                if (dao.Eliminar(alt))
                                {
                                    Ventanas.Mensaje mensaje = new Ventanas.Mensaje();
                                    mensaje.cambiarMensaje("Elimino Correctamente");
                                    recargarListados(4.3);
                                    mensaje.ShowDialog();
                                }
                                else
                                {
                                    Ventanas.Mensaje mensaje = new Ventanas.Mensaje();
                                    mensaje.cambiarMensaje("No elimino Correctamente");
                                    mensaje.ShowDialog();
                                }


                            }
                            else
                            {
                                Ventanas.Mensaje mensaje = new Ventanas.Mensaje();
                                mensaje.cambiarMensaje("Debe seleccionar una fila");
                                mensaje.ShowDialog();
                            }
                        }

                    }

                    break;

            }
        }
        #endregion





        #region CONTROL DEL FORMULARIO

        private void btnSubControles_Click(object sender, EventArgs e)
        {
            BunifuImageButton btn = sender as BunifuImageButton;

            if (btn.Name == btnCerrarSesion.Name)
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
                }
                else if (btnMaximizarFormulario.Visible == true)
                {
                    btnMaximizarFormulario.Visible = false;
                    estadoMR = 2;
                }


                app.Controles(6);
            }

            if (btn.Name == btnRestaurarFullScreen.Name)
            {
                btnRestaurarFullScreen.Visible = false;
                btnFullScreen.Visible = true;
                if (estadoMR == 1)
                {
                    btnRestaurarFormulario.Visible = true;
                }
                else if (estadoMR == 2)
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


        public void AbrirModuloExterno(object formHijo)
        {
            AbrirModulo(formHijo);
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
