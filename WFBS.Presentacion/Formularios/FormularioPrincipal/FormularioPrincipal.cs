using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFBS.Presentacion.Formularios.FormularioPrincipal.Otros;
using WFBS.Presentacion.Formularios.FormularioPrincipal.Otros.Listado;

namespace WFBS.Presentacion.Formularios.FormularioPrincipal
{
    public partial class FormularioPrincipal : Form
    {

        #region DEFINIR PARAMETROS
        private ListadoPrincipal ListarFuncionario, ListarJefeFuncionario, ListarPerfil, ListarCargo,ListarCompetencia, ListarEvaluacion;
        private ListadoReporte ListadoReporte;
        private Aplicacion app;
        private Dashboard dashboard;
        private Logotipo logo = new Logotipo();
        private int numero = 0;
        private double numero2 = 0;
        private int estadoDashboard = 0, estadoFuncionario = 0, estadoPerfil = 0, estadoCompetencia = 0, estadoEvaluacion = 0, estadoReporte = 0;
        #endregion

        public FormularioPrincipal()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
        }
        #region INICIALIZAR FORMULARIO
        private void InicializarToolTip()
        {
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
                if(estadoDashboard == 0)
                {
                    IniciarProcemiento(1);
                }


            }
            if (btn.Name == btnFuncionario.Name)
            {
                if (estadoFuncionario == 0)
                {
                    IniciarProcemiento(2);
                }
            }
            if (btn.Name == btnPerfil.Name)
            {
                if (estadoPerfil == 0)
                {
                    IniciarProcemiento(3);
                }
            }
            if (btn.Name == btnCompetencia.Name)
            {
                if (estadoCompetencia == 0)
                {
                    IniciarProcemiento(4);
                }
            }
            if (btn.Name == btnEvaluacion.Name)
            {
                if (estadoEvaluacion == 0)
                {
                    IniciarProcemiento(5);
                }

            }
            if (btn.Name == btnReporte.Name)
            {
                if (estadoReporte == 0)
                {
                    IniciarProcemiento(6);
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

        private void IniciarProcemiento(int numero)
        {
            switch (numero)
            {
                case 1:
                    inicializarEstado();
                    InicializarBotones();
                    OcultarMenu();
                    InicializarSideMenu();
                    PanelCRUD.Visible = false;
                    panelMenuDatagrid.Visible = false;
                    this.btnDashboard.Image = Properties.Resources.Dashboard_Active;
                    this.SidePanelDashboardMini.BackColor = Color.FromArgb(125, 62, 55);

                    AbrirFormulario(dashboard);
                    estadoDashboard = 1;
                    
                    this.numero = numero;
                    break;
                case 2:
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
                case 3:
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
                case 4:
                    inicializarEstado();
                    InicializarBotones();
                    OcultarMenu();
                    InicializarSideMenu();
                    PanelCRUD.Visible = false;
                    panelMenuDatagrid.Visible = false;
                    this.btnCompetencia.Image = Properties.Resources.Competencia_Active;
                    this.SidePanelCompetenciaMini.BackColor = Color.FromArgb(125, 62, 55);
                    GenerarControlesSubFormulario(4.1);
                    AbrirFormulario(ListarCompetencia);

                    estadoCompetencia = 1;

                    this.numero = numero;
                    break;
                case 5:
                    inicializarEstado();
                    InicializarBotones();
                    OcultarMenu();
                    InicializarSideMenu();
                    PanelCRUD.Visible = false;
                    panelMenuDatagrid.Visible = false;
                    this.btnEvaluacion.Image = Properties.Resources.Evaluacion_Active;
                    this.SidePanelEvaluacionMini.BackColor = Color.FromArgb(125, 62, 55);
                    AbrirFormulario(ListarEvaluacion);
                    GenerarControlesSubFormulario(5.1);
                    estadoEvaluacion = 1;
                    this.numero = numero;
                    break;
                case 6:
                    inicializarEstado();
                    InicializarBotones();
                    OcultarMenu();
                    InicializarSideMenu();
                    PanelCRUD.Visible = false;
                    panelMenuDatagrid.Visible = false;
                    this.btnReporte.Image = Properties.Resources.Reporte_Active;
                    this.SidePanelReporteMini.BackColor = Color.FromArgb(125, 62, 55);
                    AbrirFormulario(logo);
                    estadoReporte = 1;
                    this.numero = numero;
                    break;
            }
        }

        private void GenerarControlesPrincipales(int numero)
        {
            switch (numero)
            {
                case 2:
                    panelSubMenuOculto.Visible = true;
                    btnAccion1.Text = "Funcionario";
                    btnAccion2.Text = "Jefe Funcionario";
                    btnAccion1.Visible = true;
                    btnAccion2.Visible = true;
                    btnAccion1.Enabled = true;
                    btnAccion2.Enabled = true;
                    break;
                case 3:
                    panelSubMenuOculto.Visible = true;
                    btnAccion1.Text = "Perfil";
                    btnAccion2.Text = "Cargo";
                    btnAccion1.Visible = true;
                    btnAccion2.Visible = true;
                    btnAccion1.Enabled = true;
                    btnAccion2.Enabled = true;
                    break;
                case 6:
                    break;
            }
        }


        private void btnMenuOculto_Click(object sender, EventArgs e)
        {
            BunifuFlatButton btn = sender as BunifuFlatButton;

            switch (this.numero)
            {
                case 2:
                    if (btn.Name == btnAccion1.Name)
                    {
                        btnAccion1.Enabled = false;
                        btnAccion2.Enabled = true;
                        PanelCRUD.Visible = false;
                        AbrirFormulario(ListarFuncionario);
                        GenerarControlesSubFormulario(2.1);

                    }
                    if (btn.Name == btnAccion2.Name)
                    {
                        btnAccion1.Enabled = true;
                        btnAccion2.Enabled = false;
                        PanelCRUD.Visible = false;


                        AbrirFormulario(ListarJefeFuncionario);
                        GenerarControlesSubFormulario(2.2);
                    }
                    break;
                case 3:
                    if (btn.Name == btnAccion1.Name)
                    {
                        btnAccion1.Enabled = false;
                        btnAccion2.Enabled = true;
                        PanelCRUD.Visible = false;
                        AbrirFormulario(ListarPerfil);
                        GenerarControlesSubFormulario(3.1);
                    }
                    if (btn.Name == btnAccion2.Name)
                    {
                        btnAccion1.Enabled = true;
                        btnAccion2.Enabled = false;
                        PanelCRUD.Visible = false;
                        AbrirFormulario(ListarCargo);
                        GenerarControlesSubFormulario(3.2);
                    }
                    break;
            }
        }

        private void GenerarControlesSubFormulario(double numero)
        {
            switch (numero)
            {
                case 2.1:
                    InicializarSubMenu();
                    panelSubMenuOculto.Visible = true;
                    numero2 = numero;
                    break;
                case 2.2:
                    InicializarSubMenu();
                    panelSubMenuOculto.Visible = true;
                    numero2 = numero;
                    break;
                case 3.1:
                    InicializarSubMenu();
                    panelSubMenuOculto.Visible = true;
                    numero2 = numero;
                    break;
                case 3.2:
                    InicializarSubMenu();
                    panelSubMenuOculto.Visible = true;
                    numero2 = numero;
                    break;
                case 4.2:
                    numero2 = numero;
                    break;
                case 5.2:
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
                case 1:
                    dashboard = new Dashboard();
                    break;
            }
        }

        public void DefinirFormulario(int numero, DataSet lista, bool estado)
        {
            switch (numero)
            {
                case 1:
                    ListarFuncionario = new ListadoPrincipal();
                    ListarFuncionario.DefinirFormulario(numero,lista,estado);
                    //ListarFuncionario.DefinirModulo(1);
                    break;
               case 2:
                    ListarJefeFuncionario = new ListadoPrincipal();
                    ListarJefeFuncionario.DefinirFormulario(numero, lista,estado);
                    break;
                     case 3:
                        ListarPerfil = new ListadoPrincipal();
                         ListarPerfil.DefinirFormulario(numero, lista,estado);
                         break;
                     case 4:
                         ListarCargo = new ListadoPrincipal();
                        ListarCargo.DefinirFormulario(numero, lista,estado);
                         break;
                case 5:
                    ListarCompetencia = new ListadoPrincipal();
                    ListarCompetencia.DefinirFormulario(numero, lista,estado);

                    break;
                case 6:
                    ListarEvaluacion = new ListadoPrincipal();
                    ListarEvaluacion.DefinirFormulario(numero, lista,estado);
                    break;
                //case 7:
                //    ListadoReporte = new ListadoReporte();
                //    //     ListadoReporte.DefinirFormulario(numero, lista);
                //    break;
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
                case 2.1:
                    if (btn.Name == btnAgregar.Name)
                    {
                        MessageBox.Show("AGREGAR");
                        //if (ModuloFuncionario == null)
                        //{ ModuloFuncionario = new Modulos.ModuloFuncionario(); }
                        //PanelCRUD.Visible = true;
                        //ModuloFuncionario.InicializarAgregarFuncionario();
                        //AbrirModulo(ModuloFuncionario);
                    }


                    break;
                case 2.2:
                    if (btn.Name == btnAgregar.Name)
                    {
                        //if (ModulojefeFuncionario == null)
                        //{ ModulojefeFuncionario = new Modulos.ModuloJefeFuncionario(); }
                        //PanelCRUD.Visible = true;
                        //AbrirModulo(ModulojefeFuncionario);
                    }
                    break;
            }
        }
        #endregion





        #region CONTROL DEL FORMULARIO
        private void btnControles_Click(object sender, EventArgs e)
        {

            Bunifu.Framework.UI.BunifuImageButton btn = sender as Bunifu.Framework.UI.BunifuImageButton;

            if (btn.Name == btn_cerrarFormulario.Name)
            {
                app.Controles(1);
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
            if (btn.Name == btnCerrarSesion.Name)
            {

                //FALTA MENSAJE DE SOLICITUD SALIR
                app.Controles(5);
            }


        }
        #endregion



        #region METODOS ABRIR FORMULARIO


        private void AbrirFormulario(object formHijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
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
